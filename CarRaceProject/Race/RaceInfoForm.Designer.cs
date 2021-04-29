
namespace CarsRace
{
    partial class RaceInfoForm
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
            this.RaceName = new System.Windows.Forms.TextBox();
            this.driversList = new System.Windows.Forms.ListBox();
            this.raceLaps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RaceName
            // 
            this.RaceName.Location = new System.Drawing.Point(106, 19);
            this.RaceName.Name = "RaceName";
            this.RaceName.ReadOnly = true;
            this.RaceName.Size = new System.Drawing.Size(125, 27);
            this.RaceName.TabIndex = 0;
            // 
            // driversList
            // 
            this.driversList.FormattingEnabled = true;
            this.driversList.ItemHeight = 20;
            this.driversList.Location = new System.Drawing.Point(12, 155);
            this.driversList.Name = "driversList";
            this.driversList.Size = new System.Drawing.Size(242, 184);
            this.driversList.TabIndex = 1;
            // 
            // raceLaps
            // 
            this.raceLaps.Location = new System.Drawing.Point(106, 72);
            this.raceLaps.Name = "raceLaps";
            this.raceLaps.ReadOnly = true;
            this.raceLaps.Size = new System.Drawing.Size(125, 27);
            this.raceLaps.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Race Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Race Laps:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drivers In The Race";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(160, 345);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(53, 345);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 29);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // RaceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raceLaps);
            this.Controls.Add(this.driversList);
            this.Controls.Add(this.RaceName);
            this.Name = "RaceInfoForm";
            this.Text = "RaceInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RaceName;
        private System.Windows.Forms.ListBox driversList;
        private System.Windows.Forms.TextBox raceLaps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button removeButton;
    }
}