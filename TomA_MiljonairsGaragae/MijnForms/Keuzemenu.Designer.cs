namespace TomA_MiljonairsGaragae.MijnForms
{
    partial class Keuzemenu
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
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnVerwijderenAanpassen = new System.Windows.Forms.Button();
            this.btnIngeven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(36, 59);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(157, 23);
            this.btnZoeken.TabIndex = 0;
            this.btnZoeken.Text = "Auto zoeken";
            this.btnZoeken.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderenAanpassen
            // 
            this.btnVerwijderenAanpassen.Location = new System.Drawing.Point(36, 88);
            this.btnVerwijderenAanpassen.Name = "btnVerwijderenAanpassen";
            this.btnVerwijderenAanpassen.Size = new System.Drawing.Size(157, 23);
            this.btnVerwijderenAanpassen.TabIndex = 1;
            this.btnVerwijderenAanpassen.Text = "Veranderen of Verwijderen";
            this.btnVerwijderenAanpassen.UseVisualStyleBackColor = true;
            // 
            // btnIngeven
            // 
            this.btnIngeven.Location = new System.Drawing.Point(36, 30);
            this.btnIngeven.Name = "btnIngeven";
            this.btnIngeven.Size = new System.Drawing.Size(157, 23);
            this.btnIngeven.TabIndex = 2;
            this.btnIngeven.Text = "Auto ingeven";
            this.btnIngeven.UseVisualStyleBackColor = true;
            // 
            // Keuzemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 142);
            this.Controls.Add(this.btnIngeven);
            this.Controls.Add(this.btnVerwijderenAanpassen);
            this.Controls.Add(this.btnZoeken);
            this.Name = "Keuzemenu";
            this.Text = "Keuzemenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.Button btnVerwijderenAanpassen;
        private System.Windows.Forms.Button btnIngeven;
    }
}