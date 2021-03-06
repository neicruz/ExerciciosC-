using UMLEntities.Entities.Enums;
using System.Collections.Generic;

namespace UMLEntities.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int mounth)
        {
            double sum = BaseSalary;
            foreach (HourContract varrer in Contracts)
            {
                if (varrer.Date.Year ==year && varrer.Date.Month == mounth)
                {
                    sum = sum + varrer.TotalValue();
                }
            }
            return sum;
        }
    }
}
