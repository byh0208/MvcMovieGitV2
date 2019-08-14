using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "This is my default action……";
        //}
        [HttpPost]
        public string Welcome()
        {
            return "This is the Welcome action method";
        }
        public IActionResult Welcome(string name,int NumTimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name},ID = {ID}");
            ViewData["message"] = "Hello:" + name;
            ViewData["NumTimes"] = NumTimes;

            return View();
        }
    }
}