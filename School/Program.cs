using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Presentation refrence = new Presentation();
            while (true)
            {
                refrence.StudentMenu();

                ConsoleKeyInfo select = Console.ReadKey(true);
                switch (select.Key)
                {
                    case ConsoleKey.A:
                        refrence.Add();
                        break;

                    case ConsoleKey.P:
                        refrence.Print();
                        break;

                    case ConsoleKey.E:
                        refrence.Edite();
                        break;

                    case ConsoleKey.D:
                        refrence.Delete();
                        break;



                        //case ConsoleKey.Escape:
                        //    Representation.Exit();
                        //    return;

                        //default:
                        //    Representation.WrongInput();
                        //    break;
                }
            }
        }
    }
}
