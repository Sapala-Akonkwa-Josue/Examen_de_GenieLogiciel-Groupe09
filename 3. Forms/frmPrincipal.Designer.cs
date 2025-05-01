namespace Examen_GL_Groupe01._3._Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdresse = new System.Windows.Forms.Button();
            this.btnPersonne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTelephone = new System.Windows.Forms.Button();
            this.btnDomicile = new System.Windows.Forms.Button();
            this.frmTelephone1 = new Examen_GL_Groupe01._2._Users_Controls.frmTelephone();
            this.frmPersonne1 = new Examen_GL_Groupe01._2._Users_Controls.frmPersonne();
            this.frmDomicile1 = new Examen_GL_Groupe01._2._Users_Controls.frmDomicile();
            this.frmAdresse1 = new Examen_GL_Groupe01._2._Users_Controls.frmAdresse();
            this.SidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Controls.Add(this.panel5);
            this.SidePanel.Location = new System.Drawing.Point(-2, 20);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(8, 46);
            this.SidePanel.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(0, 51);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 46);
            this.panel5.TabIndex = 4;
            // 
            // btnAdresse
            // 
            this.btnAdresse.BackColor = System.Drawing.Color.Navy;
            this.btnAdresse.FlatAppearance.BorderSize = 0;
            this.btnAdresse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdresse.ForeColor = System.Drawing.Color.White;
            this.btnAdresse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdresse.Location = new System.Drawing.Point(17, 72);
            this.btnAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdresse.Name = "btnAdresse";
            this.btnAdresse.Size = new System.Drawing.Size(118, 46);
            this.btnAdresse.TabIndex = 11;
            this.btnAdresse.Text = "Adresse";
            this.btnAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdresse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdresse.UseVisualStyleBackColor = false;
            this.btnAdresse.Click += new System.EventHandler(this.btnAdresse_Click);
            // 
            // btnPersonne
            // 
            this.btnPersonne.BackColor = System.Drawing.Color.Navy;
            this.btnPersonne.FlatAppearance.BorderSize = 0;
            this.btnPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonne.ForeColor = System.Drawing.Color.White;
            this.btnPersonne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonne.Location = new System.Drawing.Point(17, 20);
            this.btnPersonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPersonne.Name = "btnPersonne";
            this.btnPersonne.Size = new System.Drawing.Size(118, 46);
            this.btnPersonne.TabIndex = 10;
            this.btnPersonne.Text = "Personne";
            this.btnPersonne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonne.UseVisualStyleBackColor = false;
            this.btnPersonne.Click += new System.EventHandler(this.btnPersonne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 553);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Déconnection";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Navy;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.Image")));
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisconnect.Location = new System.Drawing.Point(44, 572);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(39, 35);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnTelephone);
            this.panel1.Controls.Add(this.btnAdresse);
            this.panel1.Controls.Add(this.btnDomicile);
            this.panel1.Controls.Add(this.btnPersonne);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 609);
            this.panel1.TabIndex = 10;
            // 
            // btnTelephone
            // 
            this.btnTelephone.BackColor = System.Drawing.Color.Navy;
            this.btnTelephone.FlatAppearance.BorderSize = 0;
            this.btnTelephone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelephone.ForeColor = System.Drawing.Color.White;
            this.btnTelephone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelephone.Location = new System.Drawing.Point(17, 175);
            this.btnTelephone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTelephone.Name = "btnTelephone";
            this.btnTelephone.Size = new System.Drawing.Size(118, 46);
            this.btnTelephone.TabIndex = 11;
            this.btnTelephone.Text = "Téléphone";
            this.btnTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelephone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTelephone.UseVisualStyleBackColor = false;
            this.btnTelephone.Click += new System.EventHandler(this.btnTelephone_Click);
            // 
            // btnDomicile
            // 
            this.btnDomicile.BackColor = System.Drawing.Color.Navy;
            this.btnDomicile.FlatAppearance.BorderSize = 0;
            this.btnDomicile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDomicile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomicile.ForeColor = System.Drawing.Color.White;
            this.btnDomicile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDomicile.Location = new System.Drawing.Point(17, 123);
            this.btnDomicile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDomicile.Name = "btnDomicile";
            this.btnDomicile.Size = new System.Drawing.Size(118, 46);
            this.btnDomicile.TabIndex = 10;
            this.btnDomicile.Text = "Domicile";
            this.btnDomicile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDomicile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDomicile.UseVisualStyleBackColor = false;
            this.btnDomicile.Click += new System.EventHandler(this.btnDomicile_Click);
            // 
            // frmTelephone1
            // 
            this.frmTelephone1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.frmTelephone1.Location = new System.Drawing.Point(134, 0);
            this.frmTelephone1.Name = "frmTelephone1";
            this.frmTelephone1.Size = new System.Drawing.Size(766, 630);
            this.frmTelephone1.TabIndex = 14;
            // 
            // frmPersonne1
            // 
            this.frmPersonne1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.frmPersonne1.Location = new System.Drawing.Point(134, 1);
            this.frmPersonne1.Margin = new System.Windows.Forms.Padding(2);
            this.frmPersonne1.Name = "frmPersonne1";
            this.frmPersonne1.Size = new System.Drawing.Size(766, 630);
            this.frmPersonne1.TabIndex = 13;
            // 
            // frmDomicile1
            // 
            this.frmDomicile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.frmDomicile1.Location = new System.Drawing.Point(134, 1);
            this.frmDomicile1.Name = "frmDomicile1";
            this.frmDomicile1.Size = new System.Drawing.Size(766, 630);
            this.frmDomicile1.TabIndex = 12;
            // 
            // frmAdresse1
            // 
            this.frmAdresse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.frmAdresse1.Location = new System.Drawing.Point(134, 0);
            this.frmAdresse1.Name = "frmAdresse1";
            this.frmAdresse1.Size = new System.Drawing.Size(766, 630);
            this.frmAdresse1.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 609);
            this.Controls.Add(this.frmTelephone1);
            this.Controls.Add(this.frmPersonne1);
            this.Controls.Add(this.frmDomicile1);
            this.Controls.Add(this.frmAdresse1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulaire Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.SidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdresse;
        private System.Windows.Forms.Button btnPersonne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTelephone;
        private System.Windows.Forms.Button btnDomicile;
        private _2._Users_Controls.frmAdresse frmAdresse1;
        private _2._Users_Controls.frmDomicile frmDomicile1;
        private _2._Users_Controls.frmPersonne frmPersonne1;
        private _2._Users_Controls.frmTelephone frmTelephone1;
    }
}