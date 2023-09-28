using Microsoft.AspNetCore.Mvc;
using VegaITELEC1C.Models;
using VegaITELEC1C.Services;

namespace VegaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _dummyData;

        public InstructorController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }


        public IActionResult Index()
        {
            
            return View(_dummyData.InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

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
            _dummyData.InstructorList.Add(newInstructor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {

            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();

        }
        [HttpPost]
        public IActionResult UpdateInstructor(Instructor InstructorChanges)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == InstructorChanges.Id);

            if (instructor != null)
            {
                instructor.FirstName = InstructorChanges.FirstName;
                instructor.LastName = InstructorChanges.LastName;
                instructor.HiringDate = InstructorChanges.HiringDate;
                instructor.Rank = InstructorChanges.Rank;
                instructor.isTenured = InstructorChanges.isTenured;
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {

            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();

        }
        [HttpPost]
        public IActionResult DeleteInstructor(Instructor InstructorChanges)
        {
            Instructor? instructor= _dummyData.InstructorList.FirstOrDefault(st => st.Id == InstructorChanges.Id);

            if (instructor != null)
            {
                
                _dummyData.InstructorList.Remove(instructor);
            }

            return RedirectToAction("Index");
        }

    }

}

