using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Programmer : Employee, IPerson
    {
        private string _skills;
        private DateTime _DOB;
        private int _age;

        public Programmer()
        {
        }

        public Programmer(int id, string name) : base(id, name)
        {
            _skills = string.Empty;
            _DOB = DateTime.Now;
        }

        public Programmer(int id, string name, string skills, DateTime dOB) : base(id, name)
        {
            _skills = skills;
            _DOB = dOB;
        }

        

        public string Skills
        {
            get { return _skills; }
            set
            {
                if (value.Length < 0)
                    throw new Exception("Input value less than 0");
                else
                    _skills = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - _DOB.Year;
            }
        }

        public override void ShowInfo()
        {
            Console.Write("\nID: {0} | Name: {1}, Skills: {2} | DOB: {3} | Age: {4}", ID, Name, Skills, DateOfBirth, Age);
        }
    }
}
