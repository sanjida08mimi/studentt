using Microsoft.AspNetCore.Mvc;
using StudentInfo.Data;
using StudentInfo.Models.Domain;
using StudentInfo.Models.ViewModel;

namespace StudentInfo.Controllers
{
    public class AdminStudentController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddStudentRequest addStudentRequest)
        {
            var name = addStudentRequest.Name;
            var department = addStudentRequest.Department;
            var session = addStudentRequest.Session;
 

            return View ();
        }
    }
}
