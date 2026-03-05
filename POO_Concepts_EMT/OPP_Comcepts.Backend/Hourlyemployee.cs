using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Comcepts.Backend;
public class Hourlyemployee : Employee
{
    // Fields
    private decimal _hourlyValue;
    private float _workingHours;

    //Constructors
    public Hourlyemployee(int id, string firstname, string lastname, bool isActive, Date bornDate, Date hireDate, decimal hourlyValue, float workingHours) :
        base(id, firstname, lastname, isActive, bornDate, hireDate)
    {
        HourlyValue = hourlyValue;
        WorkingHours = workingHours;
    }

    // Properties
    public decimal HourlyValue
    {
        get => _hourlyValue;
        set => _hourlyValue = ValidateHourlyValue(value);
    }
    public float WorkingHours
    {
        get => _workingHours;
        set => _workingHours = ValidateWorkingHours(value);
    }

    public override decimal GetValueToPay()
    {
        return (decimal)WorkingHours * HourlyValue;
    }

    override public string ToString()
    {
        return base.ToString() + $"\n\tHourly Value......: {HourlyValue,20:C2}" +
                                 $"\n\tWorking Hours.....: {WorkingHours,20:N2}";
    }

    private decimal ValidateHourlyValue(decimal hourlyValue)
    {
        if (hourlyValue < 10000)
            throw new ArgumentOutOfRangeException(nameof(hourlyValue), "Hourly value must be greater than or equal to zero $10.000.");
        return hourlyValue;
    }

    private float ValidateWorkingHours(float workingHours)
    {
        if (workingHours < 0)
            throw new ArgumentOutOfRangeException(nameof(workingHours), "Working hours must be greater than or equal to 0.");
        return workingHours;
    }
}