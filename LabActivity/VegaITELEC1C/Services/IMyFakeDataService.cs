using VegaITELEC1C.Models;

namespace VegaITELEC1C.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
