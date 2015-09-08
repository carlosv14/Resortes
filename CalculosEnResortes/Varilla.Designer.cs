namespace CalculosEnResortes
{
    partial class Varilla
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
            this.Esfuerzo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DefUnitaria = new System.Windows.Forms.TextBox();
            this.moduloEL = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Esfuerzo
            // 
            this.Esfuerzo.Location = new System.Drawing.Point(175, 90);
            this.Esfuerzo.Name = "Esfuerzo";
            this.Esfuerzo.Size = new System.Drawing.Size(24, 20);
            this.Esfuerzo.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "𝜎=";
            // 
            // DefUnitaria
            // 
            this.DefUnitaria.Location = new System.Drawing.Point(112, 150);
            this.DefUnitaria.Name = "DefUnitaria";
            this.DefUnitaria.Size = new System.Drawing.Size(24, 20);
            this.DefUnitaria.TabIndex = 20;
            // 
            // moduloEL
            // 
            this.moduloEL.Location = new System.Drawing.Point(111, 119);
            this.moduloEL.Name = "moduloEL";
            this.moduloEL.Size = new System.Drawing.Size(24, 20);
            this.moduloEL.TabIndex = 19;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(111, 90);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(24, 20);
            this.area.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(87, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "∈=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "E=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "A=";
            // 
            // Varilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Esfuerzo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DefUnitaria);
            this.Controls.Add(this.moduloEL);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Varilla";
            this.Text = "Varilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Esfuerzo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DefUnitaria;
        private System.Windows.Forms.TextBox moduloEL;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}