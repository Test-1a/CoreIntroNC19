using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using CoreIntroNC19.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreIntroNC19.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index(int salary, string name)
        {
            //return HtmlEncoder.Default.Encode($"Demo index id:{id} name {name}");
            //ViewData["id"] = salary;
            //ViewData["name"] = name;

            var model = new Person()
            {
                Name = name,
                Salary =salary
            };

            return View(model);
        }
    }
}