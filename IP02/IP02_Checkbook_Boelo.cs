using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP02
{
    public class IP02_Checkbook_Boelo : Form
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.submit = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.NumericUpDown();
            this.bExit = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "cbk";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(335, 103);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(12, 73);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(85, 13);
            this.balanceLabel.TabIndex = 8;
            this.balanceLabel.Text = "Starting Balance";
            // 
            // balanceBox
            // 
            this.balanceBox.DecimalPlaces = 2;
            this.balanceBox.Location = new System.Drawing.Point(103, 71);
            this.balanceBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(140, 20);
            this.balanceBox.TabIndex = 9;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(173, 103);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 10;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(12, 35);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(317, 20);
            this.pathBox.TabIndex = 3;
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(335, 33);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 4;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "New CheckBook";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(124, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Existing Checkbook";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(254, 103);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 12;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // IP02_Checkbook_Boelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 138);
            this.ControlBox = false;
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.submit);
            this.Name = "IP02_Checkbook_Boelo";
            this.Text = "Boelo - Intro Project 2 - Checkbook Selection";
            ((System.ComponentModel.ISupportInitialize)(this.balanceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button submit;
        private Label balanceLabel;
        private NumericUpDown balanceBox;
        private Button bExit;
        private TextBox pathBox;
        private Button bBrowse;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button bClear;

        #endregion





        private double startingBalance;
        private string checkbookName;
        private bool existing;


        public IP02_Checkbook_Boelo()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (pathBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose wether to Create or open a checkbook.");
                //.Focus();
            }
            else
            {
                if(pathBox.Text.Trim() != "")
                {
                    checkbookName = pathBox.Text;
                    startingBalance = System.Convert.ToDouble(balanceBox.Value);
                }
                this.Close();
            }
        }

        public string getCheckbook()
        {
            return checkbookName;
        }

        public double getBalance()
        {
            return startingBalance;
        }

        public bool isExisting()
        {
            return existing;
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                saveFileDialog1.ShowDialog();
                checkbookName = saveFileDialog1.FileName;
            }
            else if(radioButton2.Checked)
            {
                openFileDialog1.ShowDialog();
                checkbookName = openFileDialog1.FileName;
            }
                
            pathBox.Text = checkbookName;
        }


        private void bClear_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            pathBox.Text = "";
            balanceBox.Value = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            balanceLabel.Show();
            balanceBox.Show();
            existing = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            balanceLabel.Hide();
            balanceBox.Hide();
            existing = true;
        }
    }
}
