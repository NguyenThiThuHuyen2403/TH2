using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOnline.Models;

namespace SachOnline.Controllers
{
    public class SachOnlineController : Controller
    {
        // GET: SachOnline

        public ActionResult SachBanNhieuPartial()
        {
            var listSachMoi = LaySachMoi(6);
            return View(listSachMoi);
        }
        QLBanSachEntities data = new QLBanSachEntities();
        
        /// <summary> /// LaySachMoi /// </summary>
        // <param name="count">int</param>
        /// <returns>List</returns>
        private List<SACH> LaySachMoi(int count)
        {
            return data.SACHes.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }
        // GET: SachOnline
        public ActionResult Index()
        {
            //Lay 6 quyen sach moi
            var listSachMoi = LaySachMoi(6); 
            return View(listSachMoi);
        }
        public ActionResult ChuDePartial()
        {
            var listChuDe = from cd in data.CHUDEs select cd; 
            return PartialView(listChuDe);
        }
        public ActionResult NhaXuatBanPartial()
        {
            var listNhaXuatBan = from cd in data.NHAXUATBANs select cd; 
            return PartialView(listNhaXuatBan);
        }
    }


}

 
