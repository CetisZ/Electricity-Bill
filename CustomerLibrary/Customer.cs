// Create a C# application that calculates and displays electricity bills for unique customers with the following data: administrative charge $12 and a charge of $0.07 for each kWh used.
// April 28, 2021; Ceti Zyko

// Project "Customer Data_Class" - Project file that contains Class customer, Constructor, and the calculation Method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public class Customer // this class is used to declare the properties for customer data as well for calcultions
    {
       
        private static int accountNumberSeed = 1234567890;
        public int AccountNo { get; }             // variable to store account number for each unique customer
        public string FirstName { get; set; }     // variable to store first name for each unique customer
        public string LastName { get; set; }      // variable to store last name for each unique customer
        public decimal NumberKWh { get; set; }    // variable to store KWh usage for each unique customer
        public decimal BillAmount { get; set; }   // variable to store bill amount

        public Customer()  // Constructor for customer object
        { }

        public Customer(string fName,string Lname, decimal kWh)   // Constructor for customer object
        {
            FirstName = fName;
            LastName = Lname;
            NumberKWh = kWh;
            AccountNo = accountNumberSeed;
            accountNumberSeed++;
            BillAmount = CalculateBillTotal(kWh);
        }

        public decimal CalculateBillTotal(decimal kWh) // Method to calculate total bill to be charged to customer
        {
            const decimal ADMIN_CHARGE = 12m;
            const decimal ENERGY_CHARGE = 0.07M;
            return (kWh * ENERGY_CHARGE + ADMIN_CHARGE);
        }


    }

  

    
}
