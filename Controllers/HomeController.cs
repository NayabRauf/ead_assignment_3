using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eadproject.Models;

namespace eadproject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DataClasses1DataContext dc = new DataClasses1DataContext();


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult BahriaTown()
        {
            var r = dc.Tables.ToList();
            var r1 = dc.Tables.ToList();
            foreach (var t in r)
            {
                r1 = dc.Tables.Where(c => c.Area.Equals("BahriaTown")).ToList();

            }
            if (r1 != null)
            {
                return View(r1);
            }
            else
            {
                return View();
            }
        }
        public ActionResult ModelTown()
        {
            var r = dc.Tables.ToList();
            var r1 = dc.Tables.ToList();
            foreach (var t in r)
            {
                r1 = dc.Tables.Where(c => c.Area.Equals("ModelTown")).ToList();

            }

            if (r1 != null)
            {
                return View(r1);
            }
            else
            {
                return View();
            }
        }
        public ActionResult ShowAllRecords()
        {
            return View(dc.Tables.ToList());
        }
        public ActionResult Thokar()
        {
            var r = dc.Tables.ToList();
            var r1 = dc.Tables.ToList();
            foreach (var t in r)
            {
                r1 = dc.Tables.Where(c => c.Area.Equals("Thokar")).ToList();
            }

            if (r1 != null)
            {
                return View(r1);
            }
            else
            {
                return View();
            }
        }
        public ActionResult MuslimTown()
        {
            var r = dc.Tables.ToList();
            var r1 = dc.Tables.ToList();
            foreach (var t in r)
            {
                r1 = dc.Tables.Where(c => c.Area.Equals("MuslimTown")).ToList();
            }
            if (r1 != null)
            {
                return View(r1);
            }
            else
            {
                return View();
            }
        }
        public ActionResult Add()
        {
            string h = Request["a"];
            Table t = new Table();
            t.Area = h;
           
            return View(t); 
        }
        /*  public ActionResult Edit(int id)
          {
          
              var r11 = dc.Tables.First(c => c.Id==id);
              return View(r11);
          }
          public ActionResult EditRecord(int id)
          {
              var r1= dc.Tables.First(c => c.Id == id);
          
              string M_name = Request["Masjidn"];
              string M_area = Request["MasjidArea"];
              string f_time = Convert.ToString(Request["FajrT"]);
              string z_time = Request["ZuhrT"];
              string a_time = Request["AsarT"];
              string m_time = Request["MaghribT"];
              string e_time = Request["EshaT"];
              r1.MasjidAddress = M_area;
              r1.MasjidName = M_name;
              r1.EshaTime = e_time;
              r1.FajrTime = f_time;
              r1.ZuhrTime = z_time;
              r1.MaghribTime = m_time;
              r1.AsarTime = (a_time);
              dc.SubmitChanges();
              return RedirectToAction("Index");
          }
         public ActionResult category()
          {
              return View(Request["cat"]);
          }*/
        public ActionResult Edit(int id)
        {
            var r11 = dc.Tables.First(c => c.Id == id);
            return View(r11);
        }
        public ActionResult Delete(int id)
        {
            var r11 = dc.Tables.First(c => c.Id == id);
            dc.Tables.DeleteOnSubmit(r11);
            dc.SubmitChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAllRecords()
        {
            dc.Tables.DeleteAllOnSubmit(dc.Tables.ToList());
            dc.SubmitChanges();
            //return RedirectToAction("Index");
            return View();
        }
        public ActionResult EditRecord(int id)
        {
            var r1 = dc.Tables.First(c => c.Id == id);

            string M_name = Request["Masjidn"];
            string M_area = Request["MasjidArea"];
            string f_time = Convert.ToString(Request["FajrT"]);
            string z_time = Request["ZuhrT"];
            string a_time = Request["AsarT"];
            string m_time = Request["MaghribT"];
            string e_time = Request["EshaT"];
            r1.MasjidAddress = M_area;
            r1.MasjidName = M_name;
            r1.EshaTime = e_time;
            r1.FajrTime = f_time;
            r1.ZuhrTime = z_time;
            r1.MaghribTime = m_time;
            r1.AsarTime = (a_time);
            dc.SubmitChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddRecord()
        {
            string a  = Request["area"];
            string M_name = Request["Masjidn"];
            string M_area = Request["MasjidArea"];
            string f_time = Convert.ToString(Request["FajrT"]);
            string z_time = Request["ZuhrT"];
            string a_time = Request["AsarT"];
            string m_time = Request["MaghribT"];
            string e_time = Request["EshaT"];
            Table t = new Table();
            t.Area = a;
            t.MasjidAddress = M_area;
            t.MasjidName = M_name;
            t.EshaTime = e_time;
            t.FajrTime = f_time;
            t.ZuhrTime = z_time;
            t.MaghribTime = m_time;
            t.AsarTime = (a_time);
            dc.Tables.InsertOnSubmit(t);
            dc.SubmitChanges();
            return RedirectToAction("Index");
            
        }
	}
}