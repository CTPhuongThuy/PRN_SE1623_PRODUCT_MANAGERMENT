using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1623_OOP
{
    class Employee:Person
    {
        /*fileds*/
        /*properties/attributes*/
        private int _id;
       
        public double Salary { get; init; }
        public int Id { get => _id; set => _id = value; }
       
        //autopropertie
        public string NameOfCompany
        {
            get;
        } = "FPT";

        public Employee()
        {

        }

        public Employee(int id, string name,double salary)
        {
            Salary = salary;
            Id = id;
            Name = name;
        }
        public Employee(int id ,double salary, String name,Address address):base(name,address)
        {
            Salary = salary;
            Id = id;
        }
        public override string ToString()
        {
            return $"[Id= {this._id} ],name ={Name} salary = {this.Salary}" +
               
                $"Address ={Address}";
        }
    }
}
