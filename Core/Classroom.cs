using Core.Infrastructure;

namespace Core
{
    public class Classroom
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public int StudentLimit { get; private set; }
        private ClassroomType _classroomType;
        public ClassroomType ClassroomType
        {
            get { return _classroomType; }
            set
            {
                if (value == ClassroomType.Backend)
                {
                    _classroomType = value;
                    StudentLimit = 1;
                }
                else if (value == ClassroomType.Frontend)
                {
                    _classroomType = value;
                    StudentLimit = 2;
                }


            }
        }

        static int counter = 0;

        public Classroom()
        {
            this.Id = ++counter;
        }

        public override string? ToString()
        {
            return $"Id:{Id} Name:{Name} ClassroomType:{ClassroomType} StudentLimit:{StudentLimit}";
        }
    }
}
