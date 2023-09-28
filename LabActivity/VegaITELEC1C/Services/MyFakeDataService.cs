using VegaITELEC1C.Models;
using VegaITELEC1C.Services;
namespace VegaITELEC1C.Services
{
   


public class MyFakeDataService : IMyFakeDataService
    {


        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
        public MyFakeDataService()//constructor
        {
            StudentList = new List<Student>
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
            
           
        

            InstructorList = new List<Instructor>
            {
                new Instructor()
            {
        Id = 1 , FirstName = "Gabriel", LastName = "Montano", isTenured = true, Rank = Rank.Professor, HiringDate = DateTime.Parse("2022-08-26")
                },
                new Instructor()
                {
        Id = 4 ,FirstName = "Shadow", LastName = "Garden", isTenured = false, Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-1-25")
                },
                new Instructor()
                {
        Id = 2 ,FirstName = "Alena", LastName = "Varona", isTenured = true , Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-07")
                },
                new Instructor()
                {
        Id = 3 ,FirstName = "Carlos", LastName = "Vega", isTenured = false , Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2020-01-25")
                }
            };
        }

       
    }

}



