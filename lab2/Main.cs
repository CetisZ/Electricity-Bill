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
    public partial class Main : Form // Class for GUI screen which has all necessary controls, looks neat, and is easy to use
    {

        readonly Customer[] customerArray;
        int customerCount = 0;


        public Main()
        {
            InitializeComponent();
            customerArray = new Customer[10];
        }




        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnAddCust_Click(object sender, EventArgs e) 
        {

            if ((txtFName.Text == "") | (txtKWhUsage.Text == "") | (txtLName.Text == ""))
            {
                MessageBox.Show("Please ensure all fields are filled.", "Field Input Incomplete");
            }

            else
            {
                try // FName and LName to be entered once. Usage kWh to be only positive value entry. No letters are accepted at kWh usgae box.
                {

                    if (!Decimal.TryParse(txtKWhUsage.Text, out _))
                        throw new Exception("No letter!");
                    decimal kWhusage = Convert.ToDecimal(txtKWhUsage.Text);
                    if (kWhusage < 0)
                        throw new Exception("Please enter a number > 0");
                    for (int i = 0; i < customerCount; i++)
                    {
                        if ((txtFName.Text == customerArray[i].FirstName) & (txtLName.Text == customerArray[i].LastName))
                        {
                            throw new Exception("Enter another user name!");
                        }
                    }
                    customerArray[customerCount] = new Customer(txtFName.Text, txtLName.Text, kWhusage);
                    customerCount++;



                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtKWhUsage.Text = "";
                    MessageBox.Show("Your information has been successfully saved.", "Data Saved");
                }
                catch (Exception ex) // Catches if negative number is entered and message is displayed. Catches repetitive FName and LName (can not be entered more than once)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e) // btnDisplay open new form to display customer info
        {
            customerBills displayCustomerBills = new customerBills();
            displayCustomerBills.customerArray = customerArray;
            displayCustomerBills.customerCount = customerCount;
            displayCustomerBills.ShowDialog();
            customerCount = displayCustomerBills.customerCount;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e) // btnExit to exit the display form, also Alt+E
        {
            this.Close();
        }
    }
}