using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Kiosk_Sales_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          
        int kasaTutar = 0;
        

        private void button1_Click(object sender, EventArgs e)
        {

            int sweetcorn, water, tea, cookie, coffee, ticket, total;
            sweetcorn = Convert.ToInt16(txtSweecorn.Text);
            water = Convert.ToInt16(txtWater.Text);
            tea = Convert.ToInt16(txtTea.Text);
            cookie = Convert.ToInt16(txtCookie.Text);
            coffee = Convert.ToInt16(txtCoffee.Text);
            ticket = Convert.ToInt16(txtTicket.Text);

            total = sweetcorn * 4 + water * 1 + tea * 2 + cookie * 4 + coffee * 5 + ticket * 10;

            LblTotal.Text = total.ToString()+" $ ";

            kasaTutar = kasaTutar + total;
            LblTill.Text = kasaTutar.ToString() + " $ "; 

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtSweecorn.Text = "";
            txtWater.Text = "";
            txtTea.Text = "";
            txtCookie.Text = "";
            txtCoffee.Text = "";
            txtTicket.Text = "";

            txtSweecorn.Focus();  //Focus bir methoddur odaklamak imleci döndürmek için kullanılır

        }
    }
}
