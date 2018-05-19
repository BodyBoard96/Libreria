namespace Libreria
{
    partial class ProveedorView
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
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDirec_Prov = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNRC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName_ejec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName_Prov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(510, 29);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(183, 20);
            this.txtNIT.TabIndex = 56;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(510, 150);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(183, 20);
            this.txtCel.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Celular ejecutivo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(510, 113);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '*';
            this.txtTelefono.Size = new System.Drawing.Size(183, 20);
            this.txtTelefono.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Telefono:";
            // 
            // txtDirec_Prov
            // 
            this.txtDirec_Prov.Location = new System.Drawing.Point(510, 72);
            this.txtDirec_Prov.Name = "txtDirec_Prov";
            this.txtDirec_Prov.Size = new System.Drawing.Size(183, 20);
            this.txtDirec_Prov.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Direccion Proveedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "NIT: ";
            // 
            // txtNRC
            // 
            this.txtNRC.Location = new System.Drawing.Point(190, 150);
            this.txtNRC.Name = "txtNRC";
            this.txtNRC.Size = new System.Drawing.Size(183, 20);
            this.txtNRC.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "NRC:";
            // 
            // txtName_ejec
            // 
            this.txtName_ejec.Location = new System.Drawing.Point(190, 113);
            this.txtName_ejec.Name = "txtName_ejec";
            this.txtName_ejec.Size = new System.Drawing.Size(183, 20);
            this.txtName_ejec.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nombre ejecutivo:";
            // 
            // txtName_Prov
            // 
            this.txtName_Prov.Location = new System.Drawing.Point(190, 72);
            this.txtName_Prov.Name = "txtName_Prov";
            this.txtName_Prov.Size = new System.Drawing.Size(183, 20);
            this.txtName_Prov.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre Proveedor:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(190, 29);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(183, 20);
            this.txtId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Identificador: ";
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Location = new System.Drawing.Point(15, 279);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.Size = new System.Drawing.Size(868, 329);
            this.dtgProveedor.TabIndex = 57;
            this.dtgProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProveedor_CellContentClick);
            // 
            // ProveedorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 620);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDirec_Prov);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNRC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName_ejec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName_Prov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "ProveedorView";
            this.Text = "ProveedorView";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtName_Prov, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtName_ejec, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNRC, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtDirec_Prov, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtCel, 0);
            this.Controls.SetChildIndex(this.txtNIT, 0);
            this.Controls.SetChildIndex(this.dtgProveedor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDirec_Prov;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNRC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName_ejec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName_Prov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgProveedor;
    }
}