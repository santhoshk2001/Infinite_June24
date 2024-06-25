using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Doctor
    {
        private string regnNo;
        private string name;
        private decimal feesCharged;

        public string RegnNo
        {
            get { return regnNo; }
            set { regnNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }

        public Doctor(string regnNo, string name, decimal feesCharged)
        {
            this.regnNo = regnNo;
            this.name = name;
            this.feesCharged = feesCharged;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fees Charged: {FeesCharged}");
        }
    }

    class Program5
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("12345", "Santhosh K", 2000m);

            doctor.DisplayDetails();

            doctor.RegnNo = "54321";
            doctor.Name = "Bharath";
            doctor.FeesCharged = 5000m;

            doctor.DisplayDetails();

            Console.ReadLine();
        }
    }
}
