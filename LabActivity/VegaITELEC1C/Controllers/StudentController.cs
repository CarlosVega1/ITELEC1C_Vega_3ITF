using Microsoft.AspNetCore.Mvc;
using VegaITELEC1C.Models;
using VegaITELEC1C.Services;

namespace VegaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _dummyData;

        public StudentController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }
        public IActionResult Index()
        {

            return View(_dummyData.StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _dummyData.StudentList.Add(newStudent);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {

            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();

        }
        [HttpPost]
        public IActionResult UpdateStudent(Student StudentChanges)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == StudentChanges.Id);

            if (student != null)
            {
                student.FirstName = StudentChanges.FirstName;
                student.LastName = StudentChanges.LastName;
                student.Course = StudentChanges.Course;
                student.AdmissionDate = StudentChanges.AdmissionDate;
                student.Email = StudentChanges.Email;
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {

            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();

        }
        [HttpPost]
        public IActionResult DeleteStudent(Student StudentChanges)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == StudentChanges.Id);

            if (student != null)
            {
                //student.FirstName = StudentChanges.FirstName;
                //student.LastName = StudentChanges.LastName;
                //student.Course = StudentChanges.Course;
                //student.AdmissionDate = StudentChanges.AdmissionDate;
                //student.Email = StudentChanges.Email;
                _dummyData.StudentList.Remove(student);
            }

            return RedirectToAction("Index");
        }




    }
}
