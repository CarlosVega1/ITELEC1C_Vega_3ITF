using Microsoft.AspNetCore.Mvc;
using VegaITELEC1C.Models;

namespace VegaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1 , FirstName = "Gabriel", LastName = "Montano", isTenured = true, Rank = Rank.Professor, HiringDate = DateTime.Parse("2022-08-26")
                },
                new Instructor()
                {
                    Id= 4 ,FirstName = "Shadow", LastName = "Garden", isTenured = false, Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-1-25")
                },
                new Instructor()
                {
                    Id= 2 ,FirstName = "Alena", LastName = "Varona", isTenured = true , Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-07")
                },
                new Instructor()
                {
                    Id= 3 ,FirstName = "Carlos", LastName = "Vega", isTenured = false , Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2020-01-25")
                }
            };

       
        public IActionResult Index()
        {
            
            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }
        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {

            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();

        }
        [HttpPost]
        public IActionResult UpdateInstructor(Instructor InstructorChanges)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == InstructorChanges.Id);

            if (instructor != null)
            {
                instructor.FirstName = InstructorChanges.FirstName;
                instructor.LastName = InstructorChanges.LastName;
                instructor.HiringDate = InstructorChanges.HiringDate;
                instructor.Rank = InstructorChanges.Rank;
                instructor.isTenured = InstructorChanges.isTenured;
            }

            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {

            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();

        }
        [HttpPost]
        public IActionResult DeleteInstructor(Instructor InstructorChanges)
        {
            Instructor? instructor= InstructorList.FirstOrDefault(st => st.Id == InstructorChanges.Id);

            if (instructor != null)
            {
                
                InstructorList.Remove(instructor);
            }

            return View("Index", InstructorList);
        }

    }

}

