using Core.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Managers
{
    public class ClassroomManager
    {
        Classroom[] data = new Classroom[0];


        public async Task Add(Classroom entity)
        {

            await Task.Run(() =>
            {
                int len = data.Length;
                Array.Resize(ref data, len + 1);
                data[len] = entity;
            });
        }
        public Classroom[] GetAll()
        {
            return data;
        }
        public async Task ShowAll()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("##################Classrooms#################");
            foreach (Classroom item in GetAll())
            {
                Console.WriteLine(item);
            }
            });
        }
        public async Task Remove(int id)
        {
            Classroom[] filteredClassroom = new Classroom[0];
            bool found = true;
            await Task.Run(() =>
            {
               
            foreach (var item in data)
            {
                if (!(item.Id == id))
                {
                    int len = filteredClassroom.Length;
                    Array.Resize(ref filteredClassroom, len + 1);
                    filteredClassroom[len] = item;
                    found = false;
                }
            }
            });
            if (found != false)
            {
                throw new ClasroomNotFoundException("No Classroom Found by Id");
            }
            data = filteredClassroom;
        }
        public async Task FindId(int id)
        {
            bool found = true;
            await Task.Run(() =>
            {
                foreach (Classroom classroom in data)
            {
                if (classroom.Id == id)
                {
                    Console.WriteLine(classroom);
                    found = false;
                }
            }
            });
            if (found != false)
            {
                throw new ClasroomNotFoundException("No Classroom Found by Id");
            }
        }
    }
}
