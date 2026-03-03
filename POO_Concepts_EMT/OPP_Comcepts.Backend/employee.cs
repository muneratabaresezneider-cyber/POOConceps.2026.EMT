using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Comcepts.Backend
{
    public abstract class Employee
    {
        // Constructors
        public Employee(int id, string firtsname, string lastname, bool isActive, Date bornDate, Date hireDate)
        {
            Id = id;
            Firtsname = firtsname;
            Lastname = lastname;
            IsActive = isActive;
            BornDate = bornDate;
            HireDate = hireDate;
        }

        // Properties
        public int Id { get; set; }
        public string Firtsname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public bool IsActive { get; set; }
        public Date BornDate { get; set; } = null!;
        public Date HireDate { get; set; } = null!;

        // Methods
        public override string ToString()
        {
            return $"{Id}\t{Firtsname} {Lastname}\n\t" +
                   $"Value to pay: {GetValueToPay()}";
        }
        public abstract decimal GetValueToPay();
       
    }
}
