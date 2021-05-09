// Create a C# application that calculates and displays electricity bills for unique customers with the following data: administrative charge $12 and a charge of $0.07 for each kWh used.
// April 28, 2021; Ceti Zyko
// Project WindowsForms - Project file that contains calculations and displays ALL and Single customers info and data.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class customerBills : Form // This is the class to calculate and display custumers data
    {
        public Customer[] customerArray { get; set; }
        public int customerCount { get; set; }
        public customerBills()
        {
            InitializeComponent();
        }

        private void customerBills_Load(object sender, EventArgs e) // Customers bill is loaded
        {
            listBoxDisplayOut.Items.Clear();
            comboNames.Items.Clear();
            for (int i = 0; i < customerCount; i++)
                comboNames.Items.Add($"{customerArray[i].FirstName} {customerArray[i].LastName}");
            
        }

        private void comboNames_SelectedIndexChanged(object sender, EventArgs e) // Generates array customer to View single list box in columns per selected custmer
        {
            listBoxDisplaySingle.Items.Clear();
            listBoxDisplaySingle.Items.Add($"Account Number\t\tFirstName\t\tLastName\t\tNo. kWh\t\tBill Amount");
            int personIndex = comboNames.SelectedIndex;
            listBoxDisplaySingle.Items.Add($"{customerArray[personIndex].AccountNo.ToString()}\t\t{customerArray[personIndex].FirstName}\t\t{customerArray[personIndex].LastName}\t\t{customerArray[personIndex].NumberKWh.ToString()}\t\t{customerArray[personIndex].BillAmount.ToString("c")}\n");
        }

        private void btnViewAll_Click(object sender, EventArgs e) // Generates array customers to be displayed on multiple list box
        {
            decimal totalKWh = 0m;
            decimal averageBill = 0m;
            listBoxDisplayOut.Items.Clear();
            listBoxDisplayOut.Items.Add($"Account Number\t\tFirstName\t\tLastName\t\tNo. kWh\t\tBill Amount");
            for (int i = 0; i < customerCount; i++)
            {
                listBoxDisplayOut.Items.Add($"{customerArray[i].AccountNo.ToString()}\t\t{customerArray[i].FirstName}\t\t{customerArray[i].LastName}\t\t{customerArray[i].NumberKWh.ToString()}\t\t{customerArray[i].BillAmount.ToString("c")}\n");
                totalKWh += customerArray[i].NumberKWh;
                averageBill += customerArray[i].BillAmount;
            }

                averageBill = averageBill / customerCount;
        }

        private void btnExit_Click(object sender, EventArgs e) // btnExit to leave the design form
        {
            this.Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e) // btnStatistics to display the keeping track of requried stattistics
        {
            decimal totalKWh = 0m;
            decimal averageBill = 0m;
            listDisplayStatistics.Items.Clear();
            for (int i = 0; i < customerCount; i++)
            {
                
                totalKWh += customerArray[i].NumberKWh;
                averageBill += customerArray[i].BillAmount;
            }

            averageBill = averageBill / customerCount;
            listDisplayStatistics.Items.Add("Monthly statistics:");
            listDisplayStatistics.Items.Add($"Total Customers processed: {customerCount.ToString()}");
            listDisplayStatistics.Items.Add($"Total KWh: {totalKWh.ToString()}");
            listDisplayStatistics.Items.Add($"Average Bill: {averageBill.ToString("c")}");

        }
    }
}
