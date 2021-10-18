using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    abstract class Employee
    {
        private int _id;
        public int ID
        {
            get { return _id; }            
        } 
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 3)
                    throw new Exception("Input value has length less than 3 characters");
                else
                    _name = value;
            }
        }

        protected Employee(int id)
        {
            _id = id;
            this._name = "No name";
        }

        protected Employee(int id, string name) : this(id)
        {
            _name = name;
        }

        abstract public void ShowInfo();


    }
}
