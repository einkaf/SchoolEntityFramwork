using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Presentation : Repository
    {
        public void StudentMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t- Main Menu -\n");
            Console.WriteLine(new string('~', 50));
            Console.WriteLine("\n\tA) Add Student\n");
            Console.WriteLine("\n\tP) Print Student\n");
            Console.WriteLine("\n\tD) Delete Student\n");
            Console.WriteLine("\n\tE) Edite Student\n");
            Console.WriteLine("\n\tEscape) Sava Changes And Exit\n");
        }

        public void Add()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t- Add Menu -\n");
            Console.WriteLine(new string('~', 50));
            Console.Write("\n\tInsert the firstname of the Student : ");
            string insertFirstname = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n\t\t- Add Menu -\n");
            Console.WriteLine(new string('~', 50));
            Console.Write("\n\tInsert the lastname of the Student : ");
            string insertLastname = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n\t\t- Add Menu -\n");
            Console.WriteLine(new string('~', 50));
            Console.Write("\n\tInsert the age the Student : ");
            int age = Convert.ToInt16(Console.ReadLine());
            bool alieved = true;

            AddStudent(insertFirstname, insertLastname, age, alieved);
            Console.Clear();
            Console.WriteLine("\n\n\tInformation has been successfully saved...");
            Console.ReadKey();
        }

        public void Print()
        {
            Console.Clear();
            var list = db.Students.ToList();
            foreach (Student student in list)
            {
                if (student.Existed == true)
                {
                    Console.WriteLine($"Name : {student.Name}  -  SurName : {student.SurName}  -  Age : {student.Age}");
                }
            }
            Console.ReadKey();
        }

        public void Edite()
        {


            Console.Clear();
            Console.WriteLine("\n\t\t- Edite Menu -\n");
            Console.WriteLine(new string('~', 50));

            Console.Write("\n\tInset the last name of the student, whose you want to Edit: ");
            string searchLastname = Console.ReadLine();
            Console.Clear();
            bool test = doesItExist(searchLastname);
            if (test)
            {
                Console.Clear();
                Console.WriteLine("\n\t\t- Edite Menu -\n");
                Console.WriteLine(new string('~', 50));
                Console.Write("\n\tInsert the new firstname of the Student : ");
                string insertFirstname = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("\n\t\t- Edite Menu -\n");
                Console.WriteLine(new string('~', 50));
                Console.Write("\n\tInsert the new lastname of the Student : ");
                string insertLastname = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("\n\t\t- Edite Menu -\n");
                Console.WriteLine(new string('~', 50));
                Console.Write("\n\tInsert the new age the Student : ");
                int age = Convert.ToInt16(Console.ReadLine());

                StudentIsExistedEdit(insertFirstname, insertLastname, age, searchLastname);
                Console.Clear();
                Console.WriteLine("\n\n\tInformation has been successfully saved...");
                Console.ReadKey();
            }
            if (!test)
            {
                Console.Clear();
                Console.Write("\n\tDoes Not Exist");
            }
            Console.ReadKey();
        }


        public void Delete()
        {

            Console.Clear();
            Console.WriteLine("\n\t\t- Delete Menu -\n");
            Console.WriteLine(new string('~', 50));

            Console.Write("\n\tInset the last name of the student, whose you want to Delete: ");
            string searchLastname = Console.ReadLine();
            Console.Clear();
            bool test = doesItExist(searchLastname);
            if (test)
            {

                StudentIsExistedDelete(searchLastname);
                Console.Clear();
                Console.Write("\n\tHas deleted!");

            }

            if (!test)
            {
                Console.Clear();
                Console.Write("\n\tDoes Not Exist");
            }
            Console.ReadKey();
        }

    }
}
