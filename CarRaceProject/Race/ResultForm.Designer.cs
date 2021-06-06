
namespace CarsRace
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstDriverTextBox = new System.Windows.Forms.TextBox();
            this.SecondDriverTextBox = new System.Windows.Forms.TextBox();
            this.thirdDriverTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Race Results(3 best)";
            // 
            // firstDriverTextBox
            // 
            this.firstDriverTextBox.Location = new System.Drawing.Point(22, 84);
            this.firstDriverTextBox.Name = "firstDriverTextBox";
            this.firstDriverTextBox.ReadOnly = true;
            this.firstDriverTextBox.Size = new System.Drawing.Size(273, 27);
            this.firstDriverTextBox.TabIndex = 1;
            // 
            // SecondDriverTextBox
            // 
            this.SecondDriverTextBox.Location = new System.Drawing.Point(22, 126);
            this.SecondDriverTextBox.Name = "SecondDriverTextBox";
            this.SecondDriverTextBox.ReadOnly = true;
            this.SecondDriverTextBox.Size = new System.Drawing.Size(273, 27);
            this.SecondDriverTextBox.TabIndex = 2;
            // 
            // thirdDriverTextBox
            // 
            this.thirdDriverTextBox.Location = new System.Drawing.Point(22, 175);
            this.thirdDriverTextBox.Name = "thirdDriverTextBox";
            this.thirdDriverTextBox.ReadOnly = true;
            this.thirdDriverTextBox.Size = new System.Drawing.Size(273, 27);
            this.thirdDriverTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "2.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-4, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "3.";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(178, 238);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 293);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thirdDriverTextBox);
            this.Controls.Add(this.SecondDriverTextBox);
            this.Controls.Add(this.firstDriverTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstDriverTextBox;
        private System.Windows.Forms.TextBox SecondDriverTextBox;
        private System.Windows.Forms.TextBox thirdDriverTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
    }
}