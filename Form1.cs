using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem != null)
            {
                lblResult.Text = "Сонгосон: " + cmbCity.SelectedItem.ToString();
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            btnResult.Enabled = chkEnable.Checked;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Сонгосон огноо: " + dtpDate.Value.ToShortDateString();
        }

        private void trkValue_Scroll(object sender, EventArgs e)
        {
            lblResult.Text = "Утга: " + trkValue.Value.ToString();
            prgValue.Value = trkValue.Value;
        }

        private void prgValue_Click(object sender, EventArgs e)
        {

        }

        private void prgValue_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string city = cmbCity.SelectedItem?.ToString() ?? "Сонгоогүй";
            string date = dtpDate.Value.ToShortDateString();
            int value = trkValue.Value;

            MessageBox.Show(
                "Сонгосон хот: " + city +
                "\nОгноо: " + date +
                "\nУтга: " + value,
                "Үр дүн"
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
