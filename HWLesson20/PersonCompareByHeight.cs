using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson20
{
    class PersonCompareByHeight : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person x, Person y)
        {
            return (int)x.Height - (int)y.Height;
        }
    }
}
