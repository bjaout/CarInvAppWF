﻿namespace CarInventoryWF
{
    partial class wndMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtxtAffichage = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNettoyer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(0, 150);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtxtAffichage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(583, 390);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 0;
            // 
            // rtxtAffichage
            // 
            this.rtxtAffichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtAffichage.Location = new System.Drawing.Point(0, 0);
            this.rtxtAffichage.Name = "rtxtAffichage";
            this.rtxtAffichage.Size = new System.Drawing.Size(457, 390);
            this.rtxtAffichage.TabIndex = 0;
            this.rtxtAffichage.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnAfficher, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAjouter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSupprimer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNettoyer, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(122, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAfficher.Location = new System.Drawing.Point(3, 3);
            this.btnAfficher.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(116, 91);
            this.btnAfficher.TabIndex = 0;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAjouter.Location = new System.Drawing.Point(3, 100);
            this.btnAjouter.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(116, 91);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSupprimer.Location = new System.Drawing.Point(3, 197);
            this.btnSupprimer.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(116, 91);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNettoyer
            // 
            this.btnNettoyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNettoyer.Location = new System.Drawing.Point(3, 294);
            this.btnNettoyer.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnNettoyer.Name = "btnNettoyer";
            this.btnNettoyer.Size = new System.Drawing.Size(116, 93);
            this.btnNettoyer.TabIndex = 3;
            this.btnNettoyer.Text = "Nettoyer";
            this.btnNettoyer.UseVisualStyleBackColor = true;
            this.btnNettoyer.Click += new System.EventHandler(this.btnNettoyer_Click);
            // 
            // wndMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 390);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(16, 200);
            this.Name = "wndMain";
            this.Text = "Vehicle Inventory";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtxtAffichage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNettoyer;
    }
}

