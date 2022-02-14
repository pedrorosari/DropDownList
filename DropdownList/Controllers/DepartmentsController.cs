using DropdownList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace DropdownList.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index(Department department)
        {
            Department contrato = new Department();



            List < Department > list = new List<Department>();
                list.AddRange(contrato.dirs);



            return View(list);
        }
    }
}
