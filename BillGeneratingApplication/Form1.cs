using CalculationLibrary;
using System.Data;
using System.Xml;

namespace BillGeneratingApplication
{
    public partial class Form1 : Form
    {

        //Note the consumer type for Residential is false and for Commercial is True
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

        private void ReadToXMLBTN_Click_1(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("bill.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void WriteToXMLBTN_Click(object sender, EventArgs e)
        {
            string path = "bill.xml";
            XmlDocument doc = new XmlDocument();
            if (!System.IO.File.Exists(path))
            {

                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                XmlComment comment = doc.CreateComment("This is an XML Generated File");
                doc.AppendChild(declaration);
                doc.AppendChild(comment);


            }
            else
            {

                doc.Load(path);
            }

            //Get the root element
            XmlElement root = doc.CreateElement("bill");

            XmlElement Subroot = doc.CreateElement("bill");

            XmlElement units = doc.CreateElement("units");
            XmlElement amount = doc.CreateElement("amount");
            //XmlElement finalBillingAmtount = doc.CreateElement("finalBillingAmtount");
            XmlElement ConsumerType = doc.CreateElement("ConsumerType");



            //txt1 or txt2 ko change krlena

            units.InnerText = txtAmnt.Text;
            amount.InnerText = outputLbl.Text;

            if (consumerType == false)
            {
                ConsumerType.InnerText = "Commercial";

            }
            else
            {
                ConsumerType.InnerText = "Residential";

            }
            Subroot.AppendChild(units);
            Subroot.AppendChild(amount);
            root.AppendChild(Subroot);
            doc.AppendChild(root);


            doc.Save(path);
            MessageBox.Show("Details  added Successfully");
            txtAmnt.Text = String.Empty;
            outputLbl.Text = String.Empty;
        }
    }
}