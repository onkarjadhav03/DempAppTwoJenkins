// See https://aka.ms/new-console-template for more information
using ConsoleApptwo;


List<Employee> employees = new List<Employee>()
{
    new Employee(){Id = 1,Name="Vijay",Desigination="Developer",DOJ=new DateTime(day:12,month:10,year:2022)},
    new Employee(){Id = 2,Name="Niraj",Desigination="Tester",DOJ=new DateTime(day:12,month:10,year:2022)},
    new Employee(){Id = 3,Name="Vipul",Desigination="Manager",DOJ=new DateTime(day:12,month:10,year:2022)},
    new Employee(){Id = 4,Name="Gagan",Desigination="Developer",DOJ=new DateTime(day:12,month:10,year:2022)},
    new Employee(){Id = 5,Name="Simi",Desigination="Manager",DOJ=new DateTime(day:12,month:10,year:2022)},
    new Employee(){Id = 6,Name="Ritesh",Desigination="Developer",DOJ=new DateTime(day:12,month:10,year:2022)},

};
Console.WriteLine("Id\t Name \t Desigination \t Date of joining");
foreach (Employee emp in employees)
{
    Console.Write(emp.Id + "\t ");
    Console.Write(emp.Name + "\t ");
    Console.Write(emp.Desigination + "\t \t");
    Console.Write(emp.DOJ.ToLongDateString());
    Console.Write("\n");
}

