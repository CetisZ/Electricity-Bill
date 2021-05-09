
namespace lab2
{
    partial class customerBills
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
            this.listBoxDisplayOut = new System.Windows.Forms.ListBox();
            this.listBoxDisplaySingle = new System.Windows.Forms.ListBox();
            this.comboNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listDisplayStatistics = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDisplayOut
            // 
            this.listBoxDisplayOut.FormattingEnabled = true;
            this.listBoxDisplayOut.ItemHeight = 15;
            this.listBoxDisplayOut.Location = new System.Drawing.Point(35, 32);
            this.listBoxDisplayOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDisplayOut.Name = "listBoxDisplayOut";
            this.listBoxDisplayOut.Size = new System.Drawing.Size(722, 169);
            this.listBoxDisplayOut.TabIndex = 0;
            // 
            // listBoxDisplaySingle
            // 
            this.listBoxDisplaySingle.FormattingEnabled = true;
            this.listBoxDisplaySingle.ItemHeight = 15;
            this.listBoxDisplaySingle.Location = new System.Drawing.Point(35, 245);
            this.listBoxDisplaySingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDisplaySingle.Name = "listBoxDisplaySingle";
            this.listBoxDisplaySingle.Size = new System.Drawing.Size(722, 49);
            this.listBoxDisplaySingle.TabIndex = 1;
            // 
            // comboNames
            // 
            this.comboNames.FormattingEnabled = true;
            this.comboNames.Location = new System.Drawing.Point(337, 212);
            this.comboNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboNames.Name = "comboNames";
            this.comboNames.Size = new System.Drawing.Size(133, 23);
            this.comboNames.TabIndex = 2;
            this.comboNames.SelectedIndexChanged += new System.EventHandler(this.comboNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Summary of Usage-All Customers:";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(360, 4);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(68, 22);
            this.btnViewAll.TabIndex = 4;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "View Usage for single customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Statistics:";
            // 
            // listDisplayStatistics
            // 
            this.listDisplayStatistics.FormattingEnabled = true;
            this.listDisplayStatistics.ItemHeight = 15;
            this.listDisplayStatistics.Location = new System.Drawing.Point(54, 343);
            this.listDisplayStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listDisplayStatistics.Name = "listDisplayStatistics";
            this.listDisplayStatistics.Size = new System.Drawing.Size(722, 64);
            this.listDisplayStatistics.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(361, 411);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 22);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(349, 310);
            this.btnViewStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(107, 22);
            this.btnViewStatistics.TabIndex = 9;
            this.btnViewStatistics.Text = "View Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // customerBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listDisplayStatistics);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboNames);
            this.Controls.Add(this.listBoxDisplaySingle);
            this.Controls.Add(this.listBoxDisplayOut);
            this.Name = "customerBills";
            this.Text = "customerBills";
            this.Load += new System.EventHandler(this.customerBills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplayOut;
        private System.Windows.Forms.ListBox listBoxDisplaySingle;
        private System.Windows.Forms.ComboBox comboNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listDisplayStatistics;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewStatistics;
    }
}