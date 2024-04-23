using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Student
    {
        public int Id { get; private set; }
        public int ClassroomId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        static int counter = 0;

        public Student()
        {
            this.Id = ++counter;
        }

        public override string? ToString()
        {
            return $"Id:{Id} - ClassroomId:{ClassroomId} - Name:{Name} - Surname:{Surname} ";
        }
    }
}
