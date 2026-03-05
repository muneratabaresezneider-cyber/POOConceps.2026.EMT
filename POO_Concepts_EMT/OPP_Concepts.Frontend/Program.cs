using OPP_Comcepts.Backend;

try
{
    var employees = new List<Employee>();
    decimal payroll = 0;
    var employee1 = new Salaryemployee(1, "Maria", "Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    employees.Add(employee1);
    var employee2 = new Salaryemployee(2, "Joaquín", "Gonzales", true, new Date(1980, 3, 5), new Date(2016, 11, 16), 10395876);
    employees.Add(employee2);
    var employee3 = new Hourlyemployee(3, "Ana", "García", true, new Date(1995, 8, 20), new Date(2022, 6, 1), 18000, 95);
    employees.Add(employee3);
    var employee4 = new Hourlyemployee(4, "Kevin", "Rua", true, new Date(1998, 8, 20), new Date(2021, 6, 1), 10000, 112);
    employees.Add(employee4);
    var employee5 = new CommisionEmployee(5, "Sofia", "Lopez", true, new Date(1992, 12, 10), new Date(2018, 3, 15), 0.03f, 600000000);
    employees.Add(employee5);
    var employee6 = new CommisionEmployee(6, "Diego", "Martinez", true, new Date(1985, 7, 25), new Date(2010, 9, 30), 0.03f, 120000000);
    employees.Add(employee6);

    foreach (var employee in employees)
    {
        Console.WriteLine(new string('-', 48));
        Console.WriteLine(employee);
        payroll += employee.GetValueToPay();
    }
    Console.WriteLine(new string('=', 48));
    Console.WriteLine($"payroll...................: {payroll,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

