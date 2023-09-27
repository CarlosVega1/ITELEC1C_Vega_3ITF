using Microsoft.AspNetCore.Mvc;
using VegaITELEC1C.Models;

namespace VegaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Carlos",LastName = "Vega", IsRegular = IsRegular.Conditional, Course = Course.BSIT, AdmissionDate = DateTime.Parse("2020-04-20"), Email = "carlosvincent.vega.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 2,FirstName = "Alena",LastName = "Varona", IsRegular = IsRegular.Irregular, Course = Course.OTHER, AdmissionDate = DateTime.Parse("2022-05-25"), Email = "alena.varona.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 3,FirstName = "Shadow",LastName = "Garden", IsRegular = IsRegular.Regular, Course = Course.OTHER, AdmissionDate = DateTime.Parse("2020-08-12"), Email = "shadow.garden.cics@ust.edu.ph"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

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
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {

            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();

        }
        [HttpPost]
        public IActionResult UpdateStudent(Student StudentChanges)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == StudentChanges.Id);

            if (student != null)
            {
                student.FirstName = StudentChanges.FirstName;
                student.LastName = StudentChanges.LastName;
                student.Course = StudentChanges.Course;
                student.AdmissionDate = StudentChanges.AdmissionDate;
                student.Email = StudentChanges.Email;
            }

            return View("Index", StudentList);
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {

            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();

        }
        [HttpPost]
        public IActionResult DeleteStudent(Student StudentChanges)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == StudentChanges.Id);

            if (student != null)
            {
                //student.FirstName = StudentChanges.FirstName;
                //student.LastName = StudentChanges.LastName;
                //student.Course = StudentChanges.Course;
                //student.AdmissionDate = StudentChanges.AdmissionDate;
                //student.Email = StudentChanges.Email;
                StudentList.Remove(student);
            }

            return View("Index", StudentList);
        }




    }
}
