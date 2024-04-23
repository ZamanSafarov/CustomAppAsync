using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure
{
    public enum Menu:byte
    {
        ClassroomAdd=1,
        ClassroomAll,
        ClassroomSingle,
        ClassroomRemove,

        StudentAdd,
        StudentAll,
        StudentSingle,
        StudentRemove,

        Exit
    }
}
