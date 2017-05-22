using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleProTraining.Dal.Models;

namespace PeopleProTraining.Dal.Infrastructure
{
    public class PeopleProInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PeopleProContext>
    {
        protected override void Seed(PeopleProContext context)
        {
            
            base.Seed(context);
            return;
            

            var departments = new List<Department>
            {
                new Department { Name="Department Uno" },
                new Department { Name="Department Dos" }
            };

            var employees = new List<Employee>
            {
                new Employee {FirstName="Bob", LastName="Builder", Salary=10.0M, StartDate=DateTime.Parse("2017-04-18"), DepartmentId=1, BuildingId=1 },
                new Employee {FirstName="John", LastName="Smith", Salary=11.5M, StartDate=DateTime.Parse("2016-11-23"), DepartmentId=2, BuildingId=2 }
            };

            var buildings = new List<Building>
            {
                new Building { Name="The First Building of Uno", Address="Street 1"/*, Departments=new List<Department> { departments[0] }, Employees=new List<Employee> { employees[0] }*/ },
                new Building { Name="The Third Building of Dos", Address="Avenue A"/*, Departments=new List<Department> { departments[1] }, Employees=new List<Employee> { employees[1] }*/ }
            };

            departments.ForEach(d => context.Departments.Add(d));
            context.SaveChanges();

            buildings.ForEach(b => context.Buildings.Add(b));
            context.SaveChanges();

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();

        }
    }
}
