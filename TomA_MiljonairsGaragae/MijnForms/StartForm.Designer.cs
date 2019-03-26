namespace TomA_MiljonairsGaragae
{
    partial class StartForm
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
            this.lblAantalPlaatsen = new System.Windows.Forms.Label();
            this.txtAantalPlaatsen = new System.Windows.Forms.TextBox();
            this.btnAanmaken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAantalPlaatsen
            // 
            this.lblAantalPlaatsen.AutoSize = true;
            this.lblAantalPlaatsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalPlaatsen.Location = new System.Drawing.Point(41, 49);
            this.lblAantalPlaatsen.Name = "lblAantalPlaatsen";
            this.lblAantalPlaatsen.Size = new System.Drawing.Size(236, 20);
            this.lblAantalPlaatsen.TabIndex = 0;
            this.lblAantalPlaatsen.Text = "Hoe veel plaatsen telt je garage:";
            // 
            // txtAantalPlaatsen
            // 
            this.txtAantalPlaatsen.Location = new System.Drawing.Point(283, 49);
            this.txtAantalPlaatsen.Name = "txtAantalPlaatsen";
            this.txtAantalPlaatsen.Size = new System.Drawing.Size(100, 20);
            this.txtAantalPlaatsen.TabIndex = 1;
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAanmaken.Location = new System.Drawing.Point(44, 101);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(339, 39);
            this.btnAanmaken.TabIndex = 2;
            this.btnAanmaken.Text = "Maak de garage aan";
            this.btnAanmaken.UseVisualStyleBackColor = true;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 181);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.txtAantalPlaatsen);
            this.Controls.Add(this.lblAantalPlaatsen);
            this.Name = "StartForm";
            this.Text = "Garage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAantalPlaatsen;
        private System.Windows.Forms.TextBox txtAantalPlaatsen;
        private System.Windows.Forms.Button btnAanmaken;
    }
}

