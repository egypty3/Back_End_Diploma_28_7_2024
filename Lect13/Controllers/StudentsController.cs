using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lect13.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		[HttpGet]
		[Route("AStudent")]
		public Student GetAStudent()
		{
			// we used the object initilizer here cause we didn't declared a constructor 
			// that accepts all the parameters

			Student student = new Student()
			{
				StudentId = 1,
				StudentName = "Gamal Ghetas",
				Age = 22,
				Address = "Cairo, Egypt"
			};
			return student;
		}

		[HttpGet]
		[Route("FiveStudents")]
		public List<Student> Get5Students()
		{
			// we used the object initilizer here cause we didn't declared a constructor 
			// that accepts all the parameters

			//var student1 = new Student() { StudentId = 1, StudentName = "John" };
			//var student2 = new Student() { StudentId = 2, StudentName = "Steve" };
			//var student3 = new Student() { StudentId = 3, StudentName = "Bill" };
			//var student4 = new Student() { StudentId = 3, StudentName = "Bill" };
			//var student5 = new Student() { StudentId = 5, StudentName = "Ron" };

			//List<Student> studentList = new List<Student>() 
			//{
			//	student1, student2, student3, student4, student5 
			//};
			//return studentList;


			return new List<Student>()
			{
				new Student() { StudentId = 1, StudentName = "John" ,Age = 23,Address="Ay 3nwan"},
				new Student() { StudentId = 2, StudentName = "Steve" },
				new Student() { StudentId = 3, StudentName = "Bill" },
				new Student() { StudentId = 4, StudentName = "Emma" },
				new Student() { StudentId = 5, StudentName = "Ron" }
			};
		}

		[HttpGet]
		[Route("StudentFamily")]
		public DataStore<string, string> GetStudentFamily()
		{
			DataStore<string,string>dataStore = new DataStore<string,string>();

			dataStore.Data1 = "Ali";
			dataStore.Data2 = "Gamal";
			return dataStore;
			
			
			
		}

		[HttpGet]
		[Route("StudentDegrees")]
		public DataStore<int, int> GetDegrees()
		{
			DataStore<int, int> dataStore = new DataStore<int, int>();

			dataStore.Data1 =46;
			dataStore.Data2 = 50;
			return dataStore;



		}
	}
}
