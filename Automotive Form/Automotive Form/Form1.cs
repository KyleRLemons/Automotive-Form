using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //FLUSHES
        private decimal FlushesCharges()
        {
            decimal total = 0;
            decimal radiatorFlushCost = 30.00m;
            decimal transmissionFlushCost = 80.00m;
            if (radiatorFlush.Checked == true)
            {
                total = total + radiatorFlushCost;
            }
            if (transmissionFlush.Checked == true)
            {
                total = total + transmissionFlushCost;
            }
            return total;
        }

        // OIL AND LUBE
        private decimal OilLubeCharges()
        {
            decimal total = 0;
            decimal oilChangeCost = 26.00m;
            decimal lubeJobCost = 18.00m;
            if (oilChange.Checked == true)
            {
                total = total + oilChangeCost;
            }
            if (lubeJob.Checked == true)
            {
                total = total + lubeJobCost;
            }
            return total;
        }
        //MISC
        public decimal MiscCharges()
        {
            decimal total = 0;
            decimal replaceMufflerCost = 100.00m;
            decimal inspectorCost = 15.00m;
            decimal tireRotationCost = 20.00m;
            if (replaceMuffler.Checked == true)
            {
                total = total + replaceMufflerCost;
            }
            if (inspector.Checked == true)
            {
                total = total + inspectorCost;
            }
            if (tireRotation.Checked == true)
            {
                total = total + tireRotationCost;
            }
            return total;
            
        }
        //PARTS AND LABOR
        public decimal PartsLaborCharges()
        {
            decimal partsCost = decimal.Parse(partsTextBox.Text);
            decimal laborCosts = decimal.Parse(laborTextBox.Text);
            decimal total = 0;
            if (partsTextBox.Text != "")
            {
                total = total + decimal.Parse(partsTextBox.Text);
            }
            if (laborTextBox.Text != "")
            {
                total = total + decimal.Parse(laborTextBox.Text);
            }
            if (partsTextBox.Text == "")
            {
                MessageBox.Show("Enter a value for parts");
            }
            if (laborTextBox.Text == "")
            {
                MessageBox.Show("Enter a value for labor");
            }
            return total;
        }
        //LABOR
        public decimal LaborCharges()
        {
            decimal laborCosts = decimal.Parse(laborTextBox.Text);
            decimal total = 0;
            if (laborTextBox.Text != "")
            {
                total = total + decimal.Parse(laborTextBox.Text);
            }
            if (laborTextBox.Text == "")
            {
                MessageBox.Show("Enter a value for labor");
            }
            return total;
        }

        //TAX
        public decimal TaxParts()
        {
            decimal tax = 0.06m;
            decimal total = 0;
            if (partsTextBox.Text != "")
            {
                total = decimal.Parse(partsTextBox.Text) * tax;
            }
            return total;
        }
        
        //CLEAR IT ALL
        public void ClearAll()
        {
            oilChange.Checked = false;
            lubeJob.Checked = false;
            radiatorFlush.Checked = false;
            transmissionFlush.Checked = false; 
            inspector.Checked = false;
            replaceMuffler.Checked = false;
            tireRotation.Checked = false;
            partsTextBox.Text = "";
            laborTextBox.Text = "";
            serviceLaborSumTextBox.Text = "";
            partsSumTextBox.Text = "";
            taxOnPartsTextBox.Text = "";
            totalFeesTextBox.Text = "";
        }
        //CALCULATE BUTTON AND ALGORITHM
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalFees = OilLubeCharges() + FlushesCharges() + MiscCharges() + PartsLaborCharges() + TaxParts();
                totalFeesTextBox.Text = totalFees.ToString();
                serviceLaborSumTextBox.Text = (OilLubeCharges() + FlushesCharges() + MiscCharges() + LaborCharges()).ToString();
                taxOnPartsTextBox.Text = (TaxParts().ToString());
                partsSumTextBox.Text = partsTextBox.Text;
            }
            catch
            {
                MessageBox.Show("Wrong data or no data entered");
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
