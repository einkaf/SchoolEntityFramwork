using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Repository
    {
        private FinalDatabaseEntities repo = new FinalDatabaseEntities();
        public FinalDatabaseEntities db { get { return repo; } }

        public void AddStudent(string name, string surname, int age, bool exist)
        {
            Student student = new Student()
            {
                Name = name,
                SurName = surname,
                Age = age,
                Existed = exist
            };
            repo.Students.Add(student);
            repo.SaveChanges();
        }        

        public bool doesItExist(string test)
        {
            return db.Students.Any(s => s.SurName == test);
        }

        public void StudentIsExistedEdit(string name, string surname, int age, string searchTest)
        {
            Student student = db.Students.Single(a => a.SurName == searchTest);
            student.Age = age;
            student.Name = name;
            student.SurName = surname;

            repo.SaveChanges();
        }


        public void StudentIsExistedDelete(string lastname)
        {
            db.Students.Single(a => a.SurName == lastname).Existed = false;
            db.SaveChanges();
        }
    }
}
