/*

Program Author: Khalid Alghamdi

Assignment: Program 3: Lenny's Car Wash

Description:

A Program where you can Choose which tier you want to pay for,
with a real time updating Total price and Optional Addons. This is the event handler!!

*/
namespace WindowsFormsApp5
{
    partial class Form1
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
            this.AirFreshener = new System.Windows.Forms.CheckBox();
            this.VacuumService = new System.Windows.Forms.CheckBox();
            this.WaxOnService = new System.Windows.Forms.CheckBox();
            this.TireShineService = new System.Windows.Forms.CheckBox();
            this.BasicWashButton = new System.Windows.Forms.RadioButton();
            this.PremiumWashButton = new System.Windows.Forms.RadioButton();
            this.UltraWashButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AirFreshener
            // 
            this.AirFreshener.AutoSize = true;
            this.AirFreshener.Location = new System.Drawing.Point(253, 261);
            this.AirFreshener.Name = "AirFreshener";
            this.AirFreshener.Size = new System.Drawing.Size(88, 17);
            this.AirFreshener.TabIndex = 0;
            this.AirFreshener.Text = "Air Freshener";
            this.AirFreshener.UseVisualStyleBackColor = true;
            this.AirFreshener.CheckedChanged += new System.EventHandler(this.AddonsCheckBox_CheckedChanged);
            // 
            // VacuumService
            // 
            this.VacuumService.AutoSize = true;
            this.VacuumService.Location = new System.Drawing.Point(253, 285);
            this.VacuumService.Name = "VacuumService";
            this.VacuumService.Size = new System.Drawing.Size(104, 17);
            this.VacuumService.TabIndex = 1;
            this.VacuumService.Text = "Vacuum Service";
            this.VacuumService.UseVisualStyleBackColor = true;
            this.VacuumService.CheckedChanged += new System.EventHandler(this.AddonsCheckBox_CheckedChanged);
            // 
            // WaxOnService
            // 
            this.WaxOnService.AutoSize = true;
            this.WaxOnService.Location = new System.Drawing.Point(253, 309);
            this.WaxOnService.Name = "WaxOnService";
            this.WaxOnService.Size = new System.Drawing.Size(104, 17);
            this.WaxOnService.TabIndex = 2;
            this.WaxOnService.Text = "Wax On Service";
            this.WaxOnService.UseVisualStyleBackColor = true;
            this.WaxOnService.CheckedChanged += new System.EventHandler(this.AddonsCheckBox_CheckedChanged);
            // 
            // TireShineService
            // 
            this.TireShineService.AutoSize = true;
            this.TireShineService.Location = new System.Drawing.Point(253, 333);
            this.TireShineService.Name = "TireShineService";
            this.TireShineService.Size = new System.Drawing.Size(113, 17);
            this.TireShineService.TabIndex = 3;
            this.TireShineService.Text = "Tire Shine Service";
            this.TireShineService.UseVisualStyleBackColor = true;
            this.TireShineService.CheckedChanged += new System.EventHandler(this.AddonsCheckBox_CheckedChanged);
            // 
            // BasicWashButton
            // 
            this.BasicWashButton.AutoSize = true;
            this.BasicWashButton.Location = new System.Drawing.Point(253, 164);
            this.BasicWashButton.Name = "BasicWashButton";
            this.BasicWashButton.Size = new System.Drawing.Size(82, 17);
            this.BasicWashButton.TabIndex = 4;
            this.BasicWashButton.TabStop = true;
            this.BasicWashButton.Text = "Basic Wash";
            this.BasicWashButton.UseVisualStyleBackColor = true;
            this.BasicWashButton.CheckedChanged += new System.EventHandler(this.WashTierRadioButton_Click);
            // 
            // PremiumWashButton
            // 
            this.PremiumWashButton.AutoSize = true;
            this.PremiumWashButton.Location = new System.Drawing.Point(253, 188);
            this.PremiumWashButton.Name = "PremiumWashButton";
            this.PremiumWashButton.Size = new System.Drawing.Size(96, 17);
            this.PremiumWashButton.TabIndex = 5;
            this.PremiumWashButton.TabStop = true;
            this.PremiumWashButton.Text = "Premium Wash";
            this.PremiumWashButton.UseVisualStyleBackColor = true;
            this.PremiumWashButton.CheckedChanged += new System.EventHandler(this.WashTierRadioButton_Click);
            // 
            // UltraWashButton
            // 
            this.UltraWashButton.AutoSize = true;
            this.UltraWashButton.Location = new System.Drawing.Point(253, 212);
            this.UltraWashButton.Name = "UltraWashButton";
            this.UltraWashButton.Size = new System.Drawing.Size(78, 17);
            this.UltraWashButton.TabIndex = 6;
            this.UltraWashButton.TabStop = true;
            this.UltraWashButton.Text = "Ultra Wash";
            this.UltraWashButton.UseVisualStyleBackColor = true;
            this.UltraWashButton.CheckedChanged += new System.EventHandler(this.WashTierRadioButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(442, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total: $0.00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.BackColor = System.Drawing.Color.Silver;
            this.CheckoutButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CheckoutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CheckoutButton.Location = new System.Drawing.Point(447, 234);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(99, 35);
            this.CheckoutButton.TabIndex = 8;
            this.CheckoutButton.Text = "Check out";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(230, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lenny\'s Car Wash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(250, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Washing Tier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(250, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Add-ons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UltraWashButton);
            this.Controls.Add(this.PremiumWashButton);
            this.Controls.Add(this.BasicWashButton);
            this.Controls.Add(this.TireShineService);
            this.Controls.Add(this.WaxOnService);
            this.Controls.Add(this.VacuumService);
            this.Controls.Add(this.AirFreshener);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AirFreshener;
        private System.Windows.Forms.CheckBox VacuumService;
        private System.Windows.Forms.CheckBox WaxOnService;
        private System.Windows.Forms.CheckBox TireShineService;
        private System.Windows.Forms.RadioButton BasicWashButton;
        private System.Windows.Forms.RadioButton PremiumWashButton;
        private System.Windows.Forms.RadioButton UltraWashButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

