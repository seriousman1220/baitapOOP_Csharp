using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    interface IPerson
    {
        string Skills
        {
            get { return Skills; }
            set { Skills = value; }
        }
        DateTime DateOfBirth
        {
            get { return DateOfBirth; }
        }
        int Age
        {
            get { return Age; }
        }
    }
}
