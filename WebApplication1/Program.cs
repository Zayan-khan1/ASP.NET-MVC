using System;
using HRAdministrationAPI;
using System.Collections.Generic;
namespace SchoolHRAdministration
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                    Id =1,
                    FirstName="Bob",
                    LastName = "fisher",
                    Salary=40000

            };
            employees.Add(teacher1);
            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Jenny",
                LastName = "Tom",
                Salary = 50000

            };
            employees.Add(teacher2);
            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Brenda",
                LastName = "Lee",
                Salary = 60000

            };
            employees.Add(headOfDepartment);
            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Devlin",
                LastName = "Blown",
                Salary = 70000

            };
            employees.Add(deputyHeadMaster);
            IEmployee headmaster = new HeadMaster
            {
                Id = 5,
                FirstName = "Demian",
                LastName = "Jones",
                Salary = 90000

            };
            employees.Add(deputyHeadMaster);
        }
    }
    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }

    }
    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary *0.03m); }

    }
    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }
    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }




}