
namespace CarsRace
{
    partial class CreateRaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRaceForm));
            this.RaceNameBox = new System.Windows.Forms.TextBox();
            this.RaceBoxLabs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateRaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RaceNameBox
            // 
            resources.ApplyResources(this.RaceNameBox, "RaceNameBox");
            this.RaceNameBox.Name = "RaceNameBox";
            // 
            // RaceBoxLabs
            // 
            resources.ApplyResources(this.RaceBoxLabs, "RaceBoxLabs");
            this.RaceBoxLabs.Name = "RaceBoxLabs";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CreateRaceButton
            // 
            resources.ApplyResources(this.CreateRaceButton, "CreateRaceButton");
            this.CreateRaceButton.Name = "CreateRaceButton";
            this.CreateRaceButton.UseVisualStyleBackColor = true;
            this.CreateRaceButton.Click += new System.EventHandler(this.CreateRaceButton_Click);
            // 
            // CreateRaceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreateRaceButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RaceBoxLabs);
            this.Controls.Add(this.RaceNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateRaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RaceNameBox;
        private System.Windows.Forms.TextBox RaceBoxLabs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateRaceButton;
    }
}