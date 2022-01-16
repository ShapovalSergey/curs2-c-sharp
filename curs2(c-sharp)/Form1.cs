using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs2_c_sharp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void doctor_Click(object sender, EventArgs e)
        {
            Doc1 f = new Doc1();
            f.Show();
        }

        private void patient_Click(object sender, EventArgs e)
        {
            pat1 f = new pat1();
            f.Show();
        }
    }
}
