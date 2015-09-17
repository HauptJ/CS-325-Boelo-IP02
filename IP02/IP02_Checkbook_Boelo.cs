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
            this.bBrowseOpen = new System.Windows.Forms.Button();
            this.exisitingCheckbook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBrowseSave = new System.Windows.Forms.Button();
            this.startingValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.newCheckbook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.splitContainer1.Panel1.Controls.Add(this.bBrowseOpen);
            this.splitContainer1.Panel1.Controls.Add(this.exisitingCheckbook);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bBrowseSave);
            this.splitContainer1.Panel2.Controls.Add(this.startingValue);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.newCheckbook);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.submit);
            this.splitContainer1.Size = new System.Drawing.Size(336, 260);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 0;
            // 
            // bBrowseOpen
            // 
            this.bBrowseOpen.Location = new System.Drawing.Point(249, 32);
            this.bBrowseOpen.Name = "bBrowseOpen";
            this.bBrowseOpen.Size = new System.Drawing.Size(75, 23);
            this.bBrowseOpen.TabIndex = 4;
            this.bBrowseOpen.Text = "Browse";
            this.bBrowseOpen.UseVisualStyleBackColor = true;
            this.bBrowseOpen.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // exisitingCheckbook
            // 
            this.exisitingCheckbook.Location = new System.Drawing.Point(15, 35);
            this.exisitingCheckbook.Name = "exisitingCheckbook";
            this.exisitingCheckbook.Size = new System.Drawing.Size(228, 20);
            this.exisitingCheckbook.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chose Existing Checkbook";
            // 
            // bBrowseSave
            // 
            this.bBrowseSave.Location = new System.Drawing.Point(249, 32);
            this.bBrowseSave.Name = "bBrowseSave";
            this.bBrowseSave.Size = new System.Drawing.Size(75, 23);
            this.bBrowseSave.TabIndex = 5;
            this.bBrowseSave.Text = "Browse";
            this.bBrowseSave.UseVisualStyleBackColor = true;
            this.bBrowseSave.Click += new System.EventHandler(this.bBrowseSave_Click);
            // 
            // startingValue
            // 
            this.startingValue.Location = new System.Drawing.Point(103, 69);
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
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Starting Balance";
            // 
            // newCheckbook
            // 
            this.newCheckbook.Location = new System.Drawing.Point(15, 34);
            this.newCheckbook.Name = "newCheckbook";
            this.newCheckbook.Size = new System.Drawing.Size(228, 20);
            this.newCheckbook.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create New Checkbook";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(249, 100);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "cbk";
            // 
            // IP02_Checkbook_Boelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 260);
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
        
        private Button bBrowseOpen;
        private OpenFileDialog openFileDialog1;
        private Button bBrowseSave;
        private SaveFileDialog saveFileDialog1;

        private double startingBalance;
        private string checkbookName;


        public IP02_Checkbook_Boelo()
        {
            InitializeComponent();
        }

    

        private void submit_Click(object sender, EventArgs e)
        {
            if (exisitingCheckbook.Text.Trim() == "" & (newCheckbook.Text.Trim() == ""))
            {
                MessageBox.Show("Please Choose wether to Create or open a checkbook.");
                //.Focus();
            }
            else
            {
                if(exisitingCheckbook.Text.Trim()!= "")
                {
                    checkbookName = exisitingCheckbook.Text;
                }else if(newCheckbook.Text.Trim()!="")
                {
                    checkbookName = newCheckbook.Text;
                    startingBalance = System.Convert.ToDouble(startingValue.Value);
                    
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

        private void bBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            checkbookName = openFileDialog1.FileName;
            exisitingCheckbook.Text = checkbookName;
        }

        private void bBrowseSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            checkbookName = saveFileDialog1.FileName;
            newCheckbook.Text = checkbookName;
        }
        
 
    }
}
