using OPP_Comcepts.Backend;

try
{
    var employee1 = new Salaryemployee(1, "John", "Doe", true, new Date(1990, 5, 15), new Date(2015, 3, 1), 2500000);
    Console.WriteLine(employee1);   
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

