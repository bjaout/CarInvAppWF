namespace CarInventoryWF
{
    partial class wndDelete
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
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbListe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSupprimer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnQuitter, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbListe
            // 
            this.lbListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(3, 3);
            this.lbListe.Name = "lbListe";
            this.tableLayoutPanel1.SetRowSpan(this.lbListe, 2);
            this.lbListe.Size = new System.Drawing.Size(424, 262);
            this.lbListe.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSupprimer.Location = new System.Drawing.Point(433, 3);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(102, 128);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Delete";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuitter.Location = new System.Drawing.Point(433, 137);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(102, 128);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Exit";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // wndDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "wndDelete";
            this.Text = "Suppression de véhicule";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnQuitter;
    }
}