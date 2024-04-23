using Core.CustomExceptions;

namespace Core.Managers
{
    public class StudentManager
    {
        Student[] data = new Student[0];


       public async Task Add(Student entity)
        {

            await Task.Run(() =>
            {
                int len = data.Length;
                Array.Resize(ref data, len + 1);
                data[len] = entity;
            });
        }
        public Student[] GetAll()
        {
            return data;
        }
        public async Task ShowAll()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("##################Students#################");
            foreach (Student item in GetAll())
            {
                Console.WriteLine(item);
            }
            });
        }
        public async Task Remove(int id)
        {
            Student[] filteredStudent = new Student[0];
            bool found = true;
            await Task.Run(() =>
            {
               
            foreach (var item in data)
            {
                if (!(item.Id == id))
                {
                    int len = filteredStudent.Length;
                    Array.Resize(ref filteredStudent, len + 1);
                    filteredStudent[len] = item;
                    found = false;
                }
            }
            });
            if (found != false)
            {
                throw new ClasroomNotFoundException("No Student Found by Id");
            }
            data = filteredStudent;
        }
        public async Task FindId(int id)
        {
            bool found = true;
            await Task.Run(() =>
            {
                foreach (Student Student in data)
            {
                if (Student.Id == id)
                {
                    Console.WriteLine(Student);
                    found = false;
                }
            }
            });
            if (found != false)
            {
                throw new ClasroomNotFoundException("No Student Found by Id");
            }
        }
    }
}
