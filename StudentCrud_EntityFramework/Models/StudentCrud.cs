namespace StudentCrud_EntityFramework.Models
{
    public class StudentCrud
    {
        ApplicationDbContext context;
        private IConfiguration configuration;

        public StudentCrud(ApplicationDbContext context)
        {
            this.context = context;
        }

        public StudentCrud(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students.Where(x => x.IsActive == 1).ToList();
        }


        public Student GetStudentById(int id)
        {
            var student = context.Students.Where(x => x.Sid == id).FirstOrDefault();
            return student;
        }


        public int AddStudents(Student student)
        {
            student.IsActive = 1;
            int result = 0;
            context.Students.Add(student); 
            result = context.SaveChanges(); 
            return result;
        }
        public int Updatestudent(Student student)
        {
            int result = 0;
 
            var s = context.Students.Where(x => x.Sid == student.Sid).FirstOrDefault();
            if (s != null)
            {
                s.Sname = student.Sname;
                s.Course = student.Course;
                s.Percentage = student.Percentage;
                s.IsActive = 1;
                result = context.SaveChanges();
            }

            return result;
        }
        public int DeleteStudent(int id)
        {
            int result = 0;

            var s = context.Students.Where(x => x.Sid == id).FirstOrDefault();
            if (s != null)
            {
                s.IsActive = 0;
                result = context.SaveChanges(); 
            }
            return result;
        }
    }
}
