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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exisitingCheckbook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startingValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.newCheckbook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingValue)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.exisitingCheckbook);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.startingValue);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.newCheckbook);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.submit);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(284, 270);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 0;
            // 
            // exisitingCheckbook
            // 
            this.exisitingCheckbook.Location = new System.Drawing.Point(151, 45);
            this.exisitingCheckbook.Name = "exisitingCheckbook";
            this.exisitingCheckbook.Size = new System.Drawing.Size(100, 20);
            this.exisitingCheckbook.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chose Existing Checkbook";
            // 
            // startingValue
            // 
            this.startingValue.Location = new System.Drawing.Point(151, 60);
            this.startingValue.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.startingValue.Name = "startingValue";
            this.startingValue.Size = new System.Drawing.Size(100, 20);
            this.startingValue.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Starting Balance";
            // 
            // newCheckbook
            // 
            this.newCheckbook.Location = new System.Drawing.Point(151, 21);
            this.newCheckbook.Name = "newCheckbook";
            this.newCheckbook.Size = new System.Drawing.Size(100, 20);
            this.newCheckbook.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create New Checkbook";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(197, 118);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // IP02_Checkbook_Boelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.splitContainer1);
            this.Name = "IP02_Checkbook_Boelo";
            this.Text = "Check Book";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startingValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox exisitingCheckbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newCheckbook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.NumericUpDown startingValue;
        private string checkbookName;
        private double startingBalance;



        public IP02_Checkbook_Boelo()
        {
            InitializeComponent();
        }

    

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (exisitingCheckbook.Text.Trim() == "" & (newCheckbook.Text.Trim() == "" | startingValue.Value == 0))
            {
                MessageBox.Show("Please Choose wether to Create or open a checkbook.");
                //.Focus();
            }
            else
            {
                if(exisitingCheckbook.Text.Trim()!= "")
                {
                    checkbookName = exisitingCheckbook.Text;
                }else if(newCheckbook.Text.Trim()!="" & startingValue.Value != 0)
                {
                    checkbookName = newCheckbook.Text;
                    startingBalance = System.Convert.ToDouble(startingValue.Value);
                    
                }
                this.Close();
                
            }
        }

        private void startingVal_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public string getCheckbook()
        {
            return checkbookName;
        }

        public double getBalance()
        {
            return startingBalance;
        }
    }
}
