using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void jobscombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void algocombo_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  if (algocombo.Text == "FCFS" || algocombo.Text == "SJF")
            {
                quantumcombo.Text = "";
                quantumcombo.Enabled = false;
            }
            else
                quantumcombo.Enabled = true;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jobscombo.Text = "";
            algocombo.Text = "";
            clockcombo.Text = "";
            //quantumcombo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jobscombo.Text != "" && algocombo.Text != "" && ( algocombo.Text!="RR" || (/*quantumcombo.Text != "" &&*/ algocombo.Text == "RR")) && clockcombo.Text != "") {


                this.Hide();
               // ShedulingJobform sj = new ShedulingJobform();
                
                ShedulingJobform sj = new ShedulingJobform(jobscombo.Text, algocombo.Text, clockcombo.Text /*quantumcombo.Text*/);
                sj.Show();
        
            }
            else
            {
                MessageBox.Show("Some fields are empty");
            }
        }
    }
}
