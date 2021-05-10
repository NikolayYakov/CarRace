
namespace CarsRace
{
    partial class CarInfoForm
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
            this.modelBox = new System.Windows.Forms.TextBox();
            this.hpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.sportsCarButton = new System.Windows.Forms.RadioButton();
            this.muscleCarButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(12, 43);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(169, 27);
            this.modelBox.TabIndex = 0;
            // 
            // hpTextBox
            // 
            this.hpTextBox.Location = new System.Drawing.Point(12, 96);
            this.hpTextBox.Name = "hpTextBox";
            this.hpTextBox.Size = new System.Drawing.Size(169, 27);
            this.hpTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car HP";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(192, 175);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(94, 29);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // sportsCarButton
            // 
            this.sportsCarButton.AutoSize = true;
            this.sportsCarButton.Location = new System.Drawing.Point(12, 129);
            this.sportsCarButton.Name = "sportsCarButton";
            this.sportsCarButton.Size = new System.Drawing.Size(98, 24);
            this.sportsCarButton.TabIndex = 5;
            this.sportsCarButton.TabStop = true;
            this.sportsCarButton.Text = "Sports Car";
            this.sportsCarButton.UseVisualStyleBackColor = true;
            // 
            // muscleCarButton
            // 
            this.muscleCarButton.AutoSize = true;
            this.muscleCarButton.Location = new System.Drawing.Point(157, 129);
            this.muscleCarButton.Name = "muscleCarButton";
            this.muscleCarButton.Size = new System.Drawing.Size(102, 24);
            this.muscleCarButton.TabIndex = 6;
            this.muscleCarButton.TabStop = true;
            this.muscleCarButton.Text = "Muscle Car";
            this.muscleCarButton.UseVisualStyleBackColor = true;
            // 
            // CarInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 230);
            this.Controls.Add(this.muscleCarButton);
            this.Controls.Add(this.sportsCarButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hpTextBox);
            this.Controls.Add(this.modelBox);
            this.Name = "CarInfoForm";
            this.Text = "CarInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox hpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.RadioButton sportsCarButton;
        private System.Windows.Forms.RadioButton muscleCarButton;
    }
}