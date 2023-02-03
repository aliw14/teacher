using System;

namespace teachers_login_news.managers
{
    internal class TeacherManager : ICrudService, IPrintService
    {
        private Teachers[] _teachers = new Teachers[100];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 99)
            {
                Console.WriteLine("limit kecildi 100 mellim daxil edile biler");
                return;
            }
            _teachers[_currentIndex++] = (Teachers)entity;
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null)
                    continue;

                if (id == _teachers[i].Id)
                {
                    found = true;

                    for (int j = i; j < _teachers.Length - 1; j++)
                    {
                        _teachers[j] = _teachers[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id}-li teacher silindi!");
                    return;
                }
            }

            if (!found)
                Console.WriteLine($"{id}-li teacher not found");
        }

        public Person Get(int id)
        {
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null) continue;

                if (_teachers[i].Id == id)
                {
                    return _teachers[i];
                }
            }

            Console.WriteLine("Not found!");

            return null;
        }

        public Person[] GetAll()
        {
            return _teachers;
        }


        public void Print()
        {
            foreach (var item in _teachers) 
            {
                if (item == null) 
                    continue;
                Console.WriteLine(item.ToString());
            }
        }


        public void Update(int id, Entity entity, Entity entity1)
        {
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null) continue;

                if (_teachers[i].Id == id)
                {
                    _teachers[i] = (Teachers)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }
            Console.WriteLine("not found!");
        }

        

        internal void Update(int id, Teachers teacher2)
        {
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null) continue;

                if (_teachers[i].Id == id)
                {
                    _teachers[i] = (teacher2);
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }
            Console.WriteLine("not found!");
        }
    }
}

