namespace Examen_GL_Groupe01._2._Users_Controls
{
    partial class frmTelephone
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
            this.txtPersonne = new System.Windows.Forms.TextBox();
            this.txtIdPersonne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPersonne = new System.Windows.Forms.ComboBox();
            this.txtIdPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgTelephone = new System.Windows.Forms.DataGridView();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgTelephone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonne
            // 
            this.txtPersonne.BackColor = System.Drawing.Color.White;
            this.txtPersonne.Enabled = false;
            this.txtPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonne.Location = new System.Drawing.Point(22, 189);
            this.txtPersonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPersonne.Name = "txtPersonne";
            this.txtPersonne.Size = new System.Drawing.Size(354, 24);
            this.txtPersonne.TabIndex = 162;
            this.txtPersonne.Visible = false;
            // 
            // txtIdPersonne
            // 
            this.txtIdPersonne.BackColor = System.Drawing.Color.White;
            this.txtIdPersonne.Enabled = false;
            this.txtIdPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPersonne.Location = new System.Drawing.Point(22, 143);
            this.txtIdPersonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdPersonne.Name = "txtIdPersonne";
            this.txtIdPersonne.Size = new System.Drawing.Size(354, 24);
            this.txtIdPersonne.TabIndex = 163;
            this.txtIdPersonne.TextChanged += new System.EventHandler(this.txtIdPersonne_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 161;
            this.label3.Text = "PERSONNE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 160;
            this.label8.Text = "ID PERSONNE";
            // 
            // cmbPersonne
            // 
            this.cmbPersonne.BackColor = System.Drawing.Color.White;
            this.cmbPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonne.FormattingEnabled = true;
            this.cmbPersonne.Location = new System.Drawing.Point(22, 188);
            this.cmbPersonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPersonne.Name = "cmbPersonne";
            this.cmbPersonne.Size = new System.Drawing.Size(354, 25);
            this.cmbPersonne.TabIndex = 164;
            this.cmbPersonne.SelectedIndexChanged += new System.EventHandler(this.cmbPersonne_SelectedIndexChanged);
            // 
            // txtIdPhone
            // 
            this.txtIdPhone.BackColor = System.Drawing.Color.White;
            this.txtIdPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPhone.Location = new System.Drawing.Point(22, 97);
            this.txtIdPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdPhone.Multiline = true;
            this.txtIdPhone.Name = "txtIdPhone";
            this.txtIdPhone.Size = new System.Drawing.Size(354, 24);
            this.txtIdPhone.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 149;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 149;
            this.label4.Text = "INITIAL";
            // 
            // txtInitial
            // 
            this.txtInitial.BackColor = System.Drawing.Color.White;
            this.txtInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitial.Location = new System.Drawing.Point(392, 97);
            this.txtInitial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInitial.Multiline = true;
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(354, 24);
            this.txtInitial.TabIndex = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 149;
            this.label5.Text = "NUMERO";
            // 
            // DgTelephone
            // 
            this.DgTelephone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgTelephone.BackgroundColor = System.Drawing.Color.White;
            this.DgTelephone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgTelephone.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgTelephone.Location = new System.Drawing.Point(22, 254);
            this.DgTelephone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgTelephone.Name = "DgTelephone";
            this.DgTelephone.RowHeadersWidth = 51;
            this.DgTelephone.RowTemplate.Height = 24;
            this.DgTelephone.Size = new System.Drawing.Size(722, 268);
            this.DgTelephone.TabIndex = 165;
            this.DgTelephone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTelephone_CellContentClick);
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(392, 148);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(354, 24);
            this.txtNumero.TabIndex = 150;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(464, 546);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 36);
            this.btnPrint.TabIndex = 173;
            this.btnPrint.Text = "Imprimer";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(336, 546);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 36);
            this.btnDelete.TabIndex = 172;
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
            this.btnEnreg.Location = new System.Drawing.Point(116, 546);
            this.btnEnreg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(66, 36);
            this.btnEnreg.TabIndex = 171;
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
            this.btnModifier.Location = new System.Drawing.Point(212, 546);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(95, 36);
            this.btnModifier.TabIndex = 170;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.Location = new System.Drawing.Point(574, 546);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(80, 36);
            this.btnActualiser.TabIndex = 173;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 25);
            this.label2.TabIndex = 174;
            this.label2.Text = "GESTION TELEPHONES";
            // 
            // frmTelephone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtPersonne);
            this.Controls.Add(this.txtIdPersonne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbPersonne);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.txtIdPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgTelephone);
            this.Name = "frmTelephone";
            this.Size = new System.Drawing.Size(766, 597);
            this.Load += new System.EventHandler(this.frmTelephone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgTelephone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPersonne;
        private System.Windows.Forms.TextBox txtIdPersonne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPersonne;
        private System.Windows.Forms.TextBox txtIdPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgTelephone;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Label label2;
    }
}
