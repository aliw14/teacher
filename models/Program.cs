using teachers_login_news.managers;

namespace teachers_login_news;
class Program
{
    static void Main(string[] args)
    {
        TeacherManager teacherManager = new();

        string command = "";

        do
        {
            Console.Write("enter the command:");
            command = Console.ReadLine();
            if (command.ToLower().Equals("add teacher"))
            {
                var teacher = new Teachers
                {
                    Id = 1,
                    Age = 67,
                    Firstname = "Ali",
                    lastname = "Mammadov",
                    subject = "riyaziyyat",
                    EntryDate = DateTime.Now,
                    Profession = "Math",
                };

                var teacher2 = new Teachers
                {
                    Id = 2,
                    Age = 25,
                    Firstname = "kanan",
                    lastname = "xasiyev",
                    subject = "sport",
                    Profession = "sport",
                    EntryDate = DateTime.Now
                };


                teacherManager.Add(teacher);
                teacherManager.Add(teacher2);

            }
            else if (command.ToLower().Equals("print teacher"))
            {
                teacherManager.Print();
            }
            else if (command.ToLower().Equals("delete teacher"))
            {
                Console.WriteLine("id daxil edin!");
                var id = int.Parse(Console.ReadLine());

                teacherManager.Delete(id);
            }
            else if (command.ToLower().Equals("update teacher"))
            {
                Console.Write("id daxil edin!");
                var id = int.Parse(Console.ReadLine());
                // var existTeacher = teacherManager.Get(id);
                // if (existTeacher == null)
                //   continue;
                //Console.WriteLine(existTeacher);
                var teacher2 = new Teachers
                {
                    Age = 36,
                    EntryDate = DateTime.Now,
                    Id = 3,
                    Profession = "teacher",
                    Firstname = "murad",
                    lastname = "Xasiyev",
                    subject = "ədəbiyyat",

                };
                teacherManager.Update(id, teacher2);
            }

        } while (command.ToLower() != "quit");


    }
}

