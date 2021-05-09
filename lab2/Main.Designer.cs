
namespace lab2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNames = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblUsage = new System.Windows.Forms.Label();
            this.txtKWhUsage = new System.Windows.Forms.TextBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(32, 46);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(124, 15);
            this.lblNames.TabIndex = 0;
            this.lblNames.Text = "Please enter your info:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(33, 86);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 15);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(33, 124);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(66, 15);
            this.lblLName.TabIndex = 3;
            this.lblLName.Text = "Last Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(248, 80);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 23);
            this.txtFName.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(248, 121);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 23);
            this.txtLName.TabIndex = 5;
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Location = new System.Drawing.Point(33, 162);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(124, 15);
            this.lblUsage.TabIndex = 6;
            this.lblUsage.Text = "Number of kWh Used:";
            // 
            // txtKWhUsage
            // 
            this.txtKWhUsage.Location = new System.Drawing.Point(248, 162);
            this.txtKWhUsage.Name = "txtKWhUsage";
            this.txtKWhUsage.Size = new System.Drawing.Size(100, 23);
            this.txtKWhUsage.TabIndex = 8;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(392, 83);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(82, 22);
            this.btnAddCust.TabIndex = 10;
            this.btnAddCust.Text = "&Save\r\n";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(392, 124);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(82, 22);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnExit
            // 
            this.btnExit.CausesValidation = false;
            this.btnExit.Location = new System.Drawing.Point(392, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnAddCust;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(560, 294);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.txtKWhUsage);
            this.Controls.Add(this.lblUsage);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblNames);
            this.Name = "Main";
            this.Text = "WindowsForms";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.TextBox txtKWhUsage;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnExit;
    }
}

