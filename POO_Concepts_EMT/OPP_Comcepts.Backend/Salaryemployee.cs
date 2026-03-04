using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Comcepts.Backend;

public class Salaryemployee : Employee
{
    // Fields
    private decimal salary;

    //Constructors
    public Salaryemployee(int id, string firtsname, string lastname, bool isActive, Date bornDate, Date hireDate, decimal salary) : 
        base(id, firtsname, lastname, isActive, bornDate, hireDate)
    {
        Salary = salary;
    }

    // Properties
    public decimal Salary 
    { 
        get => salary; 
        set => salary = ValidateSalary(value); 
    }

    // Methods
    public override string ToString()
    {
        return base.ToString();
    }

    public override decimal GetValueToPay()
    {
        return salary;
    }

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 2000000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $2,000,000.");
        }
        return salary;
    }   
}

