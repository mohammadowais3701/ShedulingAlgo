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
    public partial class ShedulingJobform : Form
    {
        String algo;
        Int32  quan,jobs,i,j,q,m,d,lastfinishjob,z,l,s,index,utilize;
        Double clock;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public ShedulingJobform()
        {
            InitializeComponent();
        }
        DataTable Table = new DataTable();
        Timer timer1 = new Timer
        {
            
            
        };
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0;


            for (i = 0; i < this.jobs; i++)
            {

                if (Convert.ToString(this.dataGridView1.Rows[i].Cells[1].Value) != "")
                {
                    if (i < (this.jobs - 1))
                    {
                       

                        if (Convert.ToInt32(this.dataGridView1.Rows[i].Cells[1].Value) >= Convert.ToInt32(this.dataGridView1.Rows[i + 1].Cells[1].Value))
                        {
                            MessageBox.Show("Arrival Time of Previous job should be less then next job");
                            k = 1;
                            break;
                        }

                    }
                }
                else
                {
                    MessageBox.Show(" Value of Arrival Time should not be empty");
                    k = 1;
                    break;
                } }
                for (i = 0; i < jobs; i++)
                {
                    if (Convert.ToString(this.dataGridView1.Rows[i].Cells[2].Value) == "")
                    {
                    MessageBox.Show("Value of Burst Time should not be empty");
                    k = 1;
                    break;
                    /* if (i < (this.jobs - 1))
                     {
                         if (Convert.ToInt32(this.dataGridView1.Rows[i].Cells[2].Value) > Convert.ToInt32(this.dataGridView1.Rows[i + 1].Cells[2].Value))
                         {
                             MessageBox.Show("Burst Time of Previous job should be less then next job");
                             k = 1;
                             break;
                         }
                     }
                     if (Convert.ToInt32(this.dataGridView1.Rows[i].Cells[2].Value) <= Convert.ToInt32(this.dataGridView1.Rows[i].Cells[1].Value))
                     {
                         MessageBox.Show("Arrival and Burst time should not be same");
                         k = 1;
                         break;

                     }*/


                }
                  /*  else
                    {
                        MessageBox.Show("Value of Burst Time should not be empty");
                        k = 1;
                        break;
                    }*/
                }
            
            if (k != 1 && j==0)
            {
                j = 1;
                timer1.Enabled = true;
                timer1.Start();
             timer1.Tick += new System.EventHandler(timer1_Tick);
                Stopbtn.Enabled = true;
                // MessageBox.Show("OKAY!");
            }
        }
        private void timer1_Tick(Object sender, EventArgs e)
        {

            timertxt.Text = Convert.ToString((Convert.ToInt32(timertxt.Text)) + 1);
            if (currentjobtxt.Text !="")
            {
                utilize++;
            }

            for (i = m; i < this.jobs; i++)
            {
                if (Convert.ToInt32(timertxt.Text) == Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value))
                {
                    if (currentjobtxt.Text != "")

                    {
                        //  MessageBox.Show(timertxt.Text);
                        this.q++;
                        dataGridView2.Rows[q].Cells[0].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                    }
                    else
                    {
                        currentjobtxt.Text = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);

                        for (z = 1; z <= this.jobs; z++)
                        {
                            // textBox1.Text = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            if (Convert.ToString(z) == currentjobtxt.Text)
                            {
                                //  textBox1.Text = Convert.ToString(z);
                                if (Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[0].Value) == 1)
                                    dataGridView1.Rows[z - 1].Cells[3].Value = lastfinishjob + Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[1].Value);

                                else if (lastfinishjob<Convert.ToInt32( dataGridView1.Rows[z - 1].Cells[1].Value))
                                {
                                    dataGridView1.Rows[z - 1].Cells[3].Value = dataGridView1.Rows[z - 1].Cells[1].Value;
                                }
                                else
                                    dataGridView1.Rows[z - 1].Cells[3].Value = lastfinishjob;
                                dataGridView1.Rows[z - 1].Cells[4].Value = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[3].Value) - Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[1].Value);
                                dataGridView1.Rows[z - 1].Cells[5].Value = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[3].Value) + Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[2].Value);
                                dataGridView1.Rows[z - 1].Cells[6].Value = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[5].Value) - Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[1].Value);
                                lastfinishjob = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[5].Value);

                            }
                        }
                    }
                    m++;
                }
           
            }
            if (algo == "SJF")
                SJF();
            else if (algo == "FCFS")
                FCFS();

        }
        private void SJF() {
            Int32 small, large;
            if (Convert.ToInt32(timertxt.Text) == lastfinishjob)
            {
                currentjobtxt.Text = "";
                l = l + 1;
                if (l == jobs+1)
                {
                  Double avg=0.0;
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer1.Tick -= new System.EventHandler(timer1_Tick);
                    Stopbtn.Enabled = false;
                    utilizationtxt.Text = Convert.ToString((utilize / Convert.ToDouble(timertxt.Text)) * 100) + "%";
                    for (i = 0; i < jobs; i++)
                    {
                        avg += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) / jobs;
                    }
                    avgtxt.Text = Convert.ToString(avg);
                    Throughput.Text = Convert.ToString(Convert.ToDouble(timertxt.Text) / jobs);
                }
            }
        

            if (Stopbtn.Enabled==true)
            for (i = 1; i <= q+1; i++)
            {
                    index = i;
                    if (currentjobtxt.Text == "")
                    {
                      //  textBox1.Text = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value)+"  i";
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[6].Value) == "")
                    {
                        //    textBox1.Text = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);


                        small = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                       
                        //    currentjobtxt.Text = Convert.ToString(dataGridView2.Rows[d].Cells[0].Value);
                        for (s = 2; s <= q+1; s++)
                        {
                            //if (s == Convert.ToInt32(dataGridView2.Rows[s].Cells[0].Value))
                            //{
                         //   MessageBox.Show(Convert.ToString(small));
                            if (Convert.ToString(dataGridView1.Rows[s].Cells[6].Value) == "")
                               {
                              //  MessageBox.Show(Convert.ToString(small));
                                //MessageBox.Show(Convert.ToString(dataGridView1.Rows[s].Cells[2]));
                                    if (Convert.ToInt32(dataGridView1.Rows[s].Cells[2].Value)<small)
                                    {
                                        small = Convert.ToInt32(dataGridView1.Rows[s].Cells[2].Value);
                                        index = s;
                     //               textBox1.Text = Convert.ToString(index);
                                    }


                                }

                           // }
                        }
                    }
                        //textBox1.Text = Convert.ToString(index);
                        
                        
                            currentjobtxt.Text = Convert.ToString(dataGridView2.Rows[index - 1].Cells[0].Value);
                            dataGridView2.Rows[index - 1].Cells[0].Value = "";
                        
                        
                        
                       
                        
                        
                    for (z = 1; z <= jobs; z++)
                    {
                        if (Convert.ToString(z) == currentjobtxt.Text)
                        {
                            if (lastfinishjob < Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[1].Value))
                                 dataGridView1.Rows[z - 1].Cells[3].Value = dataGridView1.Rows[z - 1].Cells[1].Value;
                            else
                            dataGridView1.Rows[z - 1].Cells[3].Value = lastfinishjob;
                            dataGridView1.Rows[z - 1].Cells[4].Value = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[3].Value) - Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[1].Value);

                            dataGridView1.Rows[z - 1].Cells[5].Value = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[3].Value) + Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[2].Value);
                            dataGridView1.Rows[z - 1].Cells[6].Value = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[5].Value) - Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[1].Value);
                            lastfinishjob = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[5].Value);
                        }
                    }
                    d++;

                }

            }

        
        }
        private void FCFS()
        {

            if (Convert.ToInt32(timertxt.Text) == lastfinishjob)
            {
                currentjobtxt.Text = "";
                l = l + 1;
                if (l == jobs+1)
                {
                    Double avg = 0;
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer1.Tick -= new System.EventHandler(timer1_Tick);
                    Stopbtn.Enabled = false;
                    utilizationtxt.Text = Convert.ToString((utilize / Convert.ToDouble(timertxt.Text)) * 100)+"%";
                    for (i = 0; i < jobs; i++)
                    {
                        avg += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value)/jobs;
                    }
                    avgtxt.Text = Convert.ToString(avg);
                    Throughput.Text = Convert.ToString(Convert.ToDouble(timertxt.Text) / jobs);
                }
            }
            
            for (i = d; i <= q; i++)
            {
                if (currentjobtxt.Text == "")
                {
                    currentjobtxt.Text = Convert.ToString(dataGridView2.Rows[d].Cells[0].Value);
              /*      for (s = 1; s < q; s++)
                    {
                       if( s==dataGridView2.Rows[s].Cells[0].Value)
                    }*/
                    dataGridView2.Rows[d].Cells[0].Value = "";
                    for (z = 1; z <= jobs; z++)
                    {
                        if(Convert.ToString(z)== currentjobtxt.Text)
                        {
                            if (lastfinishjob < Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[1].Value))
                                dataGridView1.Rows[z - 1].Cells[3].Value = dataGridView1.Rows[z - 1].Cells[1].Value;
                            else
                                dataGridView1.Rows[z - 1].Cells[3].Value = lastfinishjob;
                            dataGridView1.Rows[z - 1].Cells[4].Value = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[3].Value) - Convert.ToInt32( dataGridView1.Rows[z - 1].Cells[1].Value);

                            dataGridView1.Rows[z - 1].Cells[5].Value = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[3].Value) + Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[2].Value);
                            dataGridView1.Rows[z - 1].Cells[6].Value = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[5].Value) - Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[1].Value);
                            lastfinishjob = Convert.ToInt32(dataGridView1.Rows[z - 1].Cells[5].Value);
                        }
                    }
                    d++;

                }

            }
         
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
      
            timer1.Tick -= new System.EventHandler(timer1_Tick);

            j = 0;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void ShedulingJobform_Load(object sender, EventArgs e)
        {
            j = 0;
            index = 0;
            utilize= 0;
            
            this.l = 0;
            this.q = -1;//for queue
            this.m = 0;//for insert
            this.d = 0;//for sending element to current state
            this.lastfinishjob = 0;
            Stopbtn.Enabled = false;
            if (algo == "FCFS")
            {
                textBox1.Text = "FCFS";
                FCFS();
            }
            else if (algo == "SJF")
            {
                textBox1.Text = "SJF";
                SJF();
            }
            if (this.clock == 0.25)
            {
               // MessageBox.Show("0.25");
                timer1.Interval = 250;

            }
            else if (this.clock == 0.5)
            {
                //MessageBox.Show("0.5");
                timer1.Interval = 250*2;
            }
            else if (this.clock == 0.75)
            {
                //MessageBox.Show("0.75");
                timer1.Interval = 250*3;
            }
            else if (this.clock == 1.0)
            {
                //MessageBox.Show("1");
                timer1.Interval = 250*4;
            }
            else if (this.clock == 1.25)
            {
                //MessageBox.Show("1.25");
                timer1.Interval = 250*5;
            }
            else if (this.clock == 1.5)
            {
                //MessageBox.Show("1.5");
                timer1.Interval = 250*6;
            }
            else if (this.clock == 1.75)
            {
                //MessageBox.Show("1.75");
                timer1.Interval = 250*7;
            }
            else if (this.clock == 2.0)
            {
                //MessageBox.Show("2.0");
                timer1.Interval = 250*8;
            }
            for (i = 1; i <= 10; i++)
            {
                this.dataGridView2.Rows.Add();
            }
        }
        
       
        public ShedulingJobform(String jobs, String algo, String clock)
        {
            InitializeComponent();
            this.jobs = Convert.ToInt32(jobs);
            this.clock = Convert.ToDouble(clock);
        /*    if(quan!="")
            this.quan = Convert.ToInt32(quan);*/
            this.algo = algo;
            
            for (i = 1; i <= this.jobs; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[i - 1].Cells[0].ReadOnly = true;
                this.dataGridView1.Rows[i - 1].Cells[0].Value = i;

            }
            

        }
    }
}
