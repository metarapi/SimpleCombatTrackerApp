
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.typLightning = new System.Windows.Forms.CheckBox();
            this.typAcid = new System.Windows.Forms.CheckBox();
            this.typCold = new System.Windows.Forms.CheckBox();
            this.typFire = new System.Windows.Forms.CheckBox();
            this.typThunder = new System.Windows.Forms.CheckBox();
            this.typPiercing = new System.Windows.Forms.CheckBox();
            this.typBludgeoning = new System.Windows.Forms.CheckBox();
            this.typSlashing = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.typRadiant = new System.Windows.Forms.CheckBox();
            this.typEnergy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // typLightning
            // 
            this.typLightning.AutoSize = true;
            this.typLightning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typLightning.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typLightning.Location = new System.Drawing.Point(194, 102);
            this.typLightning.Name = "typLightning";
            this.typLightning.Size = new System.Drawing.Size(80, 20);
            this.typLightning.TabIndex = 56;
            this.typLightning.Text = "Lightning";
            this.typLightning.UseVisualStyleBackColor = true;
            this.typLightning.CheckedChanged += new System.EventHandler(this.typLightning_CheckedChanged);
            // 
            // typAcid
            // 
            this.typAcid.AutoSize = true;
            this.typAcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typAcid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typAcid.Location = new System.Drawing.Point(194, 76);
            this.typAcid.Name = "typAcid";
            this.typAcid.Size = new System.Drawing.Size(54, 20);
            this.typAcid.TabIndex = 57;
            this.typAcid.Text = "Acid";
            this.typAcid.UseVisualStyleBackColor = true;
            this.typAcid.CheckedChanged += new System.EventHandler(this.typAcid_CheckedChanged);
            // 
            // typCold
            // 
            this.typCold.AutoSize = true;
            this.typCold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typCold.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typCold.Location = new System.Drawing.Point(194, 50);
            this.typCold.Name = "typCold";
            this.typCold.Size = new System.Drawing.Size(55, 20);
            this.typCold.TabIndex = 58;
            this.typCold.Text = "Cold";
            this.typCold.UseVisualStyleBackColor = true;
            this.typCold.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // typFire
            // 
            this.typFire.AutoSize = true;
            this.typFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typFire.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typFire.Location = new System.Drawing.Point(194, 24);
            this.typFire.Name = "typFire";
            this.typFire.Size = new System.Drawing.Size(50, 20);
            this.typFire.TabIndex = 59;
            this.typFire.Text = "Fire";
            this.typFire.UseVisualStyleBackColor = true;
            this.typFire.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // typThunder
            // 
            this.typThunder.AutoSize = true;
            this.typThunder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typThunder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typThunder.Location = new System.Drawing.Point(34, 102);
            this.typThunder.Name = "typThunder";
            this.typThunder.Size = new System.Drawing.Size(77, 20);
            this.typThunder.TabIndex = 60;
            this.typThunder.Text = "Thunder";
            this.typThunder.UseVisualStyleBackColor = true;
            this.typThunder.CheckedChanged += new System.EventHandler(this.typThunder_CheckedChanged);
            // 
            // typPiercing
            // 
            this.typPiercing.AutoSize = true;
            this.typPiercing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typPiercing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typPiercing.Location = new System.Drawing.Point(34, 76);
            this.typPiercing.Name = "typPiercing";
            this.typPiercing.Size = new System.Drawing.Size(76, 20);
            this.typPiercing.TabIndex = 61;
            this.typPiercing.Text = "Piercing";
            this.typPiercing.UseVisualStyleBackColor = true;
            this.typPiercing.CheckedChanged += new System.EventHandler(this.typPiercing_CheckedChanged);
            // 
            // typBludgeoning
            // 
            this.typBludgeoning.AutoSize = true;
            this.typBludgeoning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typBludgeoning.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typBludgeoning.Location = new System.Drawing.Point(34, 50);
            this.typBludgeoning.Name = "typBludgeoning";
            this.typBludgeoning.Size = new System.Drawing.Size(103, 20);
            this.typBludgeoning.TabIndex = 62;
            this.typBludgeoning.Text = "Bludgeoning";
            this.typBludgeoning.UseVisualStyleBackColor = true;
            this.typBludgeoning.CheckedChanged += new System.EventHandler(this.typBludgeoning_CheckedChanged);
            // 
            // typSlashing
            // 
            this.typSlashing.AutoSize = true;
            this.typSlashing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typSlashing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typSlashing.Location = new System.Drawing.Point(34, 24);
            this.typSlashing.Name = "typSlashing";
            this.typSlashing.Size = new System.Drawing.Size(79, 20);
            this.typSlashing.TabIndex = 55;
            this.typSlashing.Text = "Slashing";
            this.typSlashing.UseVisualStyleBackColor = true;
            this.typSlashing.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(69, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 26);
            this.textBox1.TabIndex = 63;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(155, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 64;
            this.button1.Text = "Inflict";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typRadiant
            // 
            this.typRadiant.AutoSize = true;
            this.typRadiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typRadiant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typRadiant.Location = new System.Drawing.Point(194, 128);
            this.typRadiant.Name = "typRadiant";
            this.typRadiant.Size = new System.Drawing.Size(74, 20);
            this.typRadiant.TabIndex = 65;
            this.typRadiant.Text = "Radiant";
            this.typRadiant.UseVisualStyleBackColor = true;
            this.typRadiant.CheckedChanged += new System.EventHandler(this.typRadiant_CheckedChanged);
            // 
            // typEnergy
            // 
            this.typEnergy.AutoSize = true;
            this.typEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typEnergy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.typEnergy.Location = new System.Drawing.Point(34, 128);
            this.typEnergy.Name = "typEnergy";
            this.typEnergy.Size = new System.Drawing.Size(70, 20);
            this.typEnergy.TabIndex = 66;
            this.typEnergy.Text = "Energy";
            this.typEnergy.UseVisualStyleBackColor = true;
            this.typEnergy.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(347, 212);
            this.Controls.Add(this.typRadiant);
            this.Controls.Add(this.typEnergy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.typLightning);
            this.Controls.Add(this.typAcid);
            this.Controls.Add(this.typCold);
            this.Controls.Add(this.typFire);
            this.Controls.Add(this.typThunder);
            this.Controls.Add(this.typPiercing);
            this.Controls.Add(this.typBludgeoning);
            this.Controls.Add(this.typSlashing);
            this.Name = "Form2";
            this.Text = "Damage";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox typLightning;
        private System.Windows.Forms.CheckBox typAcid;
        private System.Windows.Forms.CheckBox typCold;
        private System.Windows.Forms.CheckBox typFire;
        private System.Windows.Forms.CheckBox typThunder;
        private System.Windows.Forms.CheckBox typPiercing;
        private System.Windows.Forms.CheckBox typBludgeoning;
        private System.Windows.Forms.CheckBox typSlashing;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox typRadiant;
        private System.Windows.Forms.CheckBox typEnergy;
    }
}