using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02HW_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string start = dateTimePicker1.Value.ToString("yyyyMMddHHmmss");
            string end = dateTimePicker2.Value.ToString("yyyyMMddHHmmss");
            int a = int.Parse(start);
            int b = int.Parse(end);
            
            DateTime c = new DateTime(a);
            DateTime d = new DateTime(b);
            TimeSpan ts = d - c;
            double getMinute = ts.TotalMinutes;
            label1.Text = ($"{getMinute}");
            //textBox1.Text = dateTimePicker1.Value.ToString("yy/M/d");
            //DateTime start = Convert.ToDateTime("2011-04-25 15:50:39");
            //int C = A - B;
            //label1.Text = ($"C");
        }
    }
}
