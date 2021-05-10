
namespace CarsRace
{
    partial class DriverForm
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
            this.driverName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driverName
            // 
            this.driverName.Location = new System.Drawing.Point(12, 31);
            this.driverName.Name = "driverName";
            this.driverName.Size = new System.Drawing.Size(125, 27);
            this.driverName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver Name";
            // 
            // carButton
            // 
            this.carButton.Location = new System.Drawing.Point(12, 91);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(94, 29);
            this.carButton.TabIndex = 2;
            this.carButton.Text = "Give Car";
            this.carButton.UseVisualStyleBackColor = true;
            this.carButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(331, 156);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 221);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.carButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driverName);
            this.Name = "DriverForm";
            this.Text = "DriverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox driverName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button carButton;
        private System.Windows.Forms.Button okButton;
    }
}