using Microsoft.AspNetCore.Mvc;
using VegaITELEC1C.Models;

namespace VegaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 1;
            st.StudentName = "Carlos Vega";
            st.DateEnrolled = DateTime.Parse( "30/8/2023");
            st.Course = Course.BSIT;
            st.Email = " carlosvincent.vega.cics@ust.edu.ph";
            ViewBag.Student = st;
            return View();
        }
    }
}
