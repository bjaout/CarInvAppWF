namespace CarInventoryWF
{
    partial class wndType
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoiture = new System.Windows.Forms.Button();
            this.btnMoto = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVoiture, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMoto, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez choisir le type de véhicule à ajouter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoiture
            // 
            this.btnVoiture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVoiture.Location = new System.Drawing.Point(3, 51);
            this.btnVoiture.Name = "btnVoiture";
            this.btnVoiture.Size = new System.Drawing.Size(130, 43);
            this.btnVoiture.TabIndex = 1;
            this.btnVoiture.Text = "Voiture";
            this.btnVoiture.UseVisualStyleBackColor = true;
            this.btnVoiture.Click += new System.EventHandler(this.btnVoiture_Click);
            // 
            // btnMoto
            // 
            this.btnMoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoto.Location = new System.Drawing.Point(139, 51);
            this.btnMoto.Name = "btnMoto";
            this.btnMoto.Size = new System.Drawing.Size(130, 43);
            this.btnMoto.TabIndex = 2;
            this.btnMoto.Text = "Moto";
            this.btnMoto.UseVisualStyleBackColor = true;
            this.btnMoto.Click += new System.EventHandler(this.btnMoto_Click);
            // 
            // wndType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 97);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "wndType";
            this.Text = "Choix du type de véhicule";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoiture;
        private System.Windows.Forms.Button btnMoto;
    }
}