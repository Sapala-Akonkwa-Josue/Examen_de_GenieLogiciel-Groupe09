namespace Examen_GL_Groupe01._2._Users_Controls
{
    partial class frmDomicile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdPersonne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPersonne = new System.Windows.Forms.ComboBox();
            this.txtIdDomicile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgDomicile = new System.Windows.Forms.DataGridView();
            this.cmbAdresse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAvenue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPersonne = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtNumAv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgDomicile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPersonne
            // 
            this.txtIdPersonne.BackColor = System.Drawing.Color.White;
            this.txtIdPersonne.Enabled = false;
            this.txtIdPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPersonne.Location = new System.Drawing.Point(23, 130);
            this.txtIdPersonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdPersonne.Name = "txtIdPersonne";
            this.txtIdPersonne.Size = new System.Drawing.Size(351, 24);
            this.txtIdPersonne.TabIndex = 179;
            this.txtIdPersonne.TextChanged += new System.EventHandler(this.txtIdPersonne_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 177;
            this.label3.Text = "PERSONNE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 176;
            this.label8.Text = "ID PERSONNE";
            // 
            // cmbPersonne
            // 
            this.cmbPersonne.BackColor = System.Drawing.Color.White;
            this.cmbPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonne.FormattingEnabled = true;
            this.cmbPersonne.Location = new System.Drawing.Point(23, 175);
            this.cmbPersonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPersonne.Name = "cmbPersonne";
            this.cmbPersonne.Size = new System.Drawing.Size(351, 25);
            this.cmbPersonne.TabIndex = 180;
            this.cmbPersonne.SelectedIndexChanged += new System.EventHandler(this.cmbPersonne_SelectedIndexChanged);
            // 
            // txtIdDomicile
            // 
            this.txtIdDomicile.BackColor = System.Drawing.Color.White;
            this.txtIdDomicile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDomicile.Location = new System.Drawing.Point(23, 84);
            this.txtIdDomicile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdDomicile.Multiline = true;
            this.txtIdDomicile.Name = "txtIdDomicile";
            this.txtIdDomicile.Size = new System.Drawing.Size(351, 24);
            this.txtIdDomicile.TabIndex = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 172;
            this.label1.Text = "ID";
            // 
            // DgDomicile
            // 
            this.DgDomicile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgDomicile.BackgroundColor = System.Drawing.Color.White;
            this.DgDomicile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDomicile.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgDomicile.Location = new System.Drawing.Point(23, 279);
            this.DgDomicile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgDomicile.Name = "DgDomicile";
            this.DgDomicile.RowHeadersWidth = 51;
            this.DgDomicile.RowTemplate.Height = 24;
            this.DgDomicile.Size = new System.Drawing.Size(722, 248);
            this.DgDomicile.TabIndex = 181;
            this.DgDomicile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDomicile_CellContentClick);
            // 
            // cmbAdresse
            // 
            this.cmbAdresse.BackColor = System.Drawing.Color.White;
            this.cmbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdresse.FormattingEnabled = true;
            this.cmbAdresse.Location = new System.Drawing.Point(393, 131);
            this.cmbAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAdresse.Name = "cmbAdresse";
            this.cmbAdresse.Size = new System.Drawing.Size(351, 25);
            this.cmbAdresse.TabIndex = 180;
            this.cmbAdresse.SelectedIndexChanged += new System.EventHandler(this.cmdAdresse_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 176;
            this.label7.Text = "ID ADRESSE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(390, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 177;
            this.label9.Text = "ADRESSE";
            // 
            // txtIdAdresse
            // 
            this.txtIdAdresse.BackColor = System.Drawing.Color.White;
            this.txtIdAdresse.Enabled = false;
            this.txtIdAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAdresse.Location = new System.Drawing.Point(393, 86);
            this.txtIdAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdAdresse.Name = "txtIdAdresse";
            this.txtIdAdresse.Size = new System.Drawing.Size(351, 24);
            this.txtIdAdresse.TabIndex = 179;
            this.txtIdAdresse.TextChanged += new System.EventHandler(this.txtIdAdresse_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 186;
            this.label5.Text = "NUMERO AVENUE";
            // 
            // txtAvenue
            // 
            this.txtAvenue.BackColor = System.Drawing.Color.White;
            this.txtAvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvenue.Location = new System.Drawing.Point(393, 176);
            this.txtAvenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAvenue.Name = "txtAvenue";
            this.txtAvenue.Size = new System.Drawing.Size(351, 24);
            this.txtAvenue.TabIndex = 189;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(390, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 188;
            this.label12.Text = "AVENUE";
            // 
            // txtPersonne
            // 
            this.txtPersonne.BackColor = System.Drawing.Color.White;
            this.txtPersonne.Enabled = false;
            this.txtPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonne.Location = new System.Drawing.Point(23, 176);
            this.txtPersonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPersonne.Name = "txtPersonne";
            this.txtPersonne.Size = new System.Drawing.Size(351, 24);
            this.txtPersonne.TabIndex = 190;
            this.txtPersonne.Visible = false;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.Color.White;
            this.txtAdresse.Enabled = false;
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(393, 132);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(351, 24);
            this.txtAdresse.TabIndex = 190;
            this.txtAdresse.Visible = false;
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.Location = new System.Drawing.Point(572, 560);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(80, 36);
            this.btnActualiser.TabIndex = 194;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(461, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 195;
            this.button1.Text = "Imprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(333, 560);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 36);
            this.btnDelete.TabIndex = 193;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnreg
            // 
            this.btnEnreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEnreg.FlatAppearance.BorderSize = 0;
            this.btnEnreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnreg.ForeColor = System.Drawing.Color.White;
            this.btnEnreg.Location = new System.Drawing.Point(112, 560);
            this.btnEnreg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(66, 36);
            this.btnEnreg.TabIndex = 192;
            this.btnEnreg.Text = "Insérer";
            this.btnEnreg.UseVisualStyleBackColor = false;
            this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(209, 560);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(95, 36);
            this.btnModifier.TabIndex = 191;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtNumAv
            // 
            this.txtNumAv.BackColor = System.Drawing.Color.White;
            this.txtNumAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAv.Location = new System.Drawing.Point(23, 223);
            this.txtNumAv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumAv.Name = "txtNumAv";
            this.txtNumAv.Size = new System.Drawing.Size(351, 24);
            this.txtNumAv.TabIndex = 189;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 196;
            this.label2.Text = "GESTION DOMICILES";
            // 
            // frmDomicile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtPersonne);
            this.Controls.Add(this.txtNumAv);
            this.Controls.Add(this.txtAvenue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdAdresse);
            this.Controls.Add(this.txtIdPersonne);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbAdresse);
            this.Controls.Add(this.cmbPersonne);
            this.Controls.Add(this.txtIdDomicile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgDomicile);
            this.Name = "frmDomicile";
            this.Size = new System.Drawing.Size(766, 605);
            this.Load += new System.EventHandler(this.frmDomicile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgDomicile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdPersonne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPersonne;
        private System.Windows.Forms.TextBox txtIdDomicile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgDomicile;
        private System.Windows.Forms.ComboBox cmbAdresse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAvenue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPersonne;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtNumAv;
        private System.Windows.Forms.Label label2;
    }
}
