using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ClassRoom
    {
        private readonly IOgretmen _teacher;

        // Constructor Injection
        public ClassRoom(IOgretmen teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
