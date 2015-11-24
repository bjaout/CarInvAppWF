namespace CarInventoryWF
{
    partial class wndCar
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
            this.numPorte = new System.Windows.Forms.NumericUpDown();
            this.numPuissance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCoffre = new System.Windows.Forms.ListBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPuissance)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.numPorte, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numPuissance, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbCoffre, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMarque, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtModele, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnValider, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.39131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.39131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.39131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 295);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numPorte
            // 
            this.numPorte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPorte.Location = new System.Drawing.Point(286, 156);
            this.numPorte.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numPorte.Name = "numPorte";
            this.numPorte.Size = new System.Drawing.Size(277, 20);
            this.numPorte.TabIndex = 7;
            // 
            // numPuissance
            // 
            this.numPuissance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPuissance.Location = new System.Drawing.Point(286, 105);
            this.numPuissance.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPuissance.Name = "numPuissance";
            this.numPuissance.Size = new System.Drawing.Size(277, 20);
            this.numPuissance.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marque";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modèle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puissance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de portes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 51);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type de coffre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCoffre
            // 
            this.lbCoffre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCoffre.FormattingEnabled = true;
            this.lbCoffre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCoffre.Items.AddRange(new object[] {
            "Aucun",
            "Coffre",
            "Haillon"});
            this.lbCoffre.Location = new System.Drawing.Point(286, 207);
            this.lbCoffre.Name = "lbCoffre";
            this.lbCoffre.Size = new System.Drawing.Size(277, 45);
            this.lbCoffre.TabIndex = 8;
            // 
            // txtMarque
            // 
            this.txtMarque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarque.Location = new System.Drawing.Point(286, 3);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(277, 20);
            this.txtMarque.TabIndex = 9;
            // 
            // txtModele
            // 
            this.txtModele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModele.Location = new System.Drawing.Point(286, 54);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(277, 20);
            this.txtModele.TabIndex = 10;
            // 
            // btnValider
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnValider, 2);
            this.btnValider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValider.Location = new System.Drawing.Point(3, 258);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(560, 34);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // wndCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 295);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "wndCar";
            this.Text = "Paramètres de la voiture";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPuissance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPorte;
        private System.Windows.Forms.NumericUpDown numPuissance;
        private System.Windows.Forms.ListBox lbCoffre;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.Button btnValider;
    }
}