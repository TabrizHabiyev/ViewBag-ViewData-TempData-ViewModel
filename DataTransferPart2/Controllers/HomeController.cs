using DataTransferPart2.Models;
using DataTransferPart2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransferPart2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            #region ViewBag,ViewData,TempData
            //ViewBag.Name = "Lorem";
            //List<Student> stu = new List<Student>
            //{
            //    new Student{Id=1,Name="Gunel",Age=19},
            //     new Student{Id=2,Name="Tural",Age=20},
            //      new Student{Id=3,Name="Habib",Age=25},

            //};
            //ViewBag.Students = stu;
            //ViewData["students"] = stu;
            //ViewBag.Name = "Ibrahim";
            //ViewData["LastName"] = "Aliyev";
            //TempData["Age"] = 27;
            //return RedirectToAction("About");
            //return RedirectToAction(nameof(About));
            #endregion

            

            List<Student> stu = new List<Student>
            {
                new Student{Id=1,Name="Gunel",Age=19},
                 new Student{Id=2,Name="Tural",Age=20},
                  new Student{Id=3,Name="Habib",Age=25},

            };
            int[] arr = new int[4] { 1,2,4,5};
            HomeVM homeVM = new HomeVM() { };
            homeVM.Students = stu;
            homeVM.arr = arr;
            return View(homeVM);
        }
        public IActionResult About()
        {
            TempData["Age"] = 25;
            return View();
        }
    }


}
