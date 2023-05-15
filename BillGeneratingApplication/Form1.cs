using CalculationLibrary;

namespace BillGeneratingApplication
{
    public partial class Form1 : Form
    {
        //Note the consumer type for 
        public bool consumerType = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAmnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double units = Convert.ToDouble(txtAmnt.Text);
                double amount;
                Class1 obj = new Class1();
                amount = obj.BillingAmt(consumerType, units);
                outputLbl.Text = amount.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Input!!!");
            }

        }

        private void radioResidential_CheckedChanged(object sender, EventArgs e)
        {
            consumerType = false;
        }

        private void radioCommercial_CheckedChanged(object sender, EventArgs e)
        {
            consumerType = true;

        }
    }
}