namespace WindowsFormsApplication1
{
    partial class ShedulingJobform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bursttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnaround = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.timertxt = new System.Windows.Forms.TextBox();
            this.Stopbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.queue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.currentjobtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.utilizationtxt = new System.Windows.Forms.TextBox();
            this.Throughput = new System.Windows.Forms.TextBox();
            this.avgtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Job,
            this.ArrivalTime,
            this.bursttime,
            this.start,
            this.wait,
            this.finish,
            this.turnaround});
            this.dataGridView1.Location = new System.Drawing.Point(1, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Job
            // 
            this.Job.HeaderText = "Jobs#";
            this.Job.Name = "Job";
            this.Job.ReadOnly = true;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Arrival Time";
            this.ArrivalTime.Name = "ArrivalTime";
            // 
            // bursttime
            // 
            this.bursttime.HeaderText = "Burst Time";
            this.bursttime.Name = "bursttime";
            // 
            // start
            // 
            this.start.HeaderText = "Start Time";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // wait
            // 
            this.wait.HeaderText = "Waiting Time";
            this.wait.Name = "wait";
            this.wait.ReadOnly = true;
            // 
            // finish
            // 
            this.finish.HeaderText = "Finish Time";
            this.finish.Name = "finish";
            this.finish.ReadOnly = true;
            // 
            // turnaround
            // 
            this.turnaround.HeaderText = "Turn Around Time";
            this.turnaround.Name = "turnaround";
            this.turnaround.ReadOnly = true;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(12, 549);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(93, 549);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 2;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // timertxt
            // 
            this.timertxt.BackColor = System.Drawing.Color.Black;
            this.timertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timertxt.ForeColor = System.Drawing.SystemColors.Window;
            this.timertxt.Location = new System.Drawing.Point(83, 225);
            this.timertxt.Multiline = true;
            this.timertxt.Name = "timertxt";
            this.timertxt.Size = new System.Drawing.Size(38, 24);
            this.timertxt.TabIndex = 3;
            this.timertxt.Text = "0";
            this.timertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Stopbtn
            // 
            this.Stopbtn.Location = new System.Drawing.Point(174, 549);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(75, 23);
            this.Stopbtn.TabIndex = 4;
            this.Stopbtn.Text = "Stop";
            this.Stopbtn.UseVisualStyleBackColor = true;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "CLOCK:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.queue});
            this.dataGridView2.Location = new System.Drawing.Point(741, 252);
            this.dataGridView2.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(137, 287);
            this.dataGridView2.TabIndex = 6;
            // 
            // queue
            // 
            this.queue.HeaderText = "QUEUE";
            this.queue.Name = "queue";
            this.queue.ReadOnly = true;
            this.queue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(891, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Job in Progress";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(272, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 131);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // currentjobtxt
            // 
            this.currentjobtxt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.currentjobtxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.currentjobtxt.Location = new System.Drawing.Point(1055, 277);
            this.currentjobtxt.Multiline = true;
            this.currentjobtxt.Name = "currentjobtxt";
            this.currentjobtxt.Size = new System.Drawing.Size(67, 26);
            this.currentjobtxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(891, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Processor Utilization";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(891, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Average Waiting Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(891, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Throughput";
            // 
            // utilizationtxt
            // 
            this.utilizationtxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.utilizationtxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.utilizationtxt.Location = new System.Drawing.Point(1055, 321);
            this.utilizationtxt.Multiline = true;
            this.utilizationtxt.Name = "utilizationtxt";
            this.utilizationtxt.Size = new System.Drawing.Size(67, 26);
            this.utilizationtxt.TabIndex = 17;
            // 
            // Throughput
            // 
            this.Throughput.BackColor = System.Drawing.SystemColors.MenuText;
            this.Throughput.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Throughput.Location = new System.Drawing.Point(1055, 406);
            this.Throughput.Multiline = true;
            this.Throughput.Name = "Throughput";
            this.Throughput.Size = new System.Drawing.Size(67, 26);
            this.Throughput.TabIndex = 18;
            // 
            // avgtxt
            // 
            this.avgtxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.avgtxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.avgtxt.Location = new System.Drawing.Point(1055, 363);
            this.avgtxt.Multiline = true;
            this.avgtxt.Name = "avgtxt";
            this.avgtxt.Size = new System.Drawing.Size(67, 26);
            this.avgtxt.TabIndex = 19;
            // 
            // ShedulingJobform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1124, 584);
            this.Controls.Add(this.avgtxt);
            this.Controls.Add(this.Throughput);
            this.Controls.Add(this.utilizationtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentjobtxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stopbtn);
            this.Controls.Add(this.timertxt);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShedulingJobform";
            this.Text = "ShedulingJobform";
            this.Load += new System.EventHandler(this.ShedulingJobform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn bursttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn wait;
        private System.Windows.Forms.DataGridViewTextBoxColumn finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnaround;
        private System.Windows.Forms.TextBox timertxt;
        private System.Windows.Forms.Button Stopbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn queue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox currentjobtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox utilizationtxt;
        private System.Windows.Forms.TextBox Throughput;
        private System.Windows.Forms.TextBox avgtxt;
    }
}