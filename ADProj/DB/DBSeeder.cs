using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADProj.Models;

namespace ADProj.DB
{
    public class DBSeeder
    {
        public DBSeeder(ADProjContext dbcontext)
        {
            //test
            //Collectionpoint seeder
            CollectionPoint cp1 = new CollectionPoint()
            { Id = Guid.NewGuid().GetHashCode(),
                Name = "Science Lobby 1",
                Time = new System.DateTime(2020,1,1,1,13,30,00),
                EmployeeId = 3
            };
            dbcontext.Add(cp1);
         

            //Department seeder
            Department department1  = new Department()
            {
                Id = Guid.NewGuid().ToString(),
                Name="Science",
                DepartmentHeadId = 1,
                DepartmentRepresentativeId = 1, 
                CollectionPointId="1"
    };
            dbcontext.Add(department1);



            //Employee seeder
            Employee employee1 = new Employee()
            {
                Id = Guid.NewGuid().GetHashCode(),
                DepartmentId = "1",
                Role = "Employee",
                Name="John",
                Email="John@gmail.com",
                Password="Password"
            };
            dbcontext.Add(employee1);

            Employee employee2 = new Employee()
            {
                Id = Guid.NewGuid().GetHashCode(),
                DepartmentId = "1",
                Role = "Manager",
                Name = "David",
                Email = "David@gmail.com",
                Password = "Password"
            };
            dbcontext.Add(employee2);

            Employee employee3 = new Employee()
            {
                Id = Guid.NewGuid().GetHashCode(),
                DepartmentId = "1",
                Role = "Employee",
                Name = "Janice",
                Email = "Janice@gmail.com",
                Password = "Password"
            };

            dbcontext.Add(employee3);

            dbcontext.SaveChanges();
        }

        
    }
}
