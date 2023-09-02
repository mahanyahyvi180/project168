using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cEmployee s1 = new cEmployee();
            cEmployee s2 = new cEmployee();

            s1.firstname = "gholi";
            s2.lastname = "goli";

            s2 = s1;

            s1.firstname = "sanaz";
            label1.Text = s2.Concatinate("hghghvhv");
        }
    }
}
