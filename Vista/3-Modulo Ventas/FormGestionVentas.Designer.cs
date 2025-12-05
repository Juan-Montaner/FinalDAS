namespace Vista._3_Modulo_Ventas
{
    partial class FormGestionVentas
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
            gbVentas = new GroupBox();
            cmbSucursales = new ComboBox();
            btnAgregar = new Button();
            btnVolver = new Button();
            btnEliminar = new Button();
            gbModYEl = new GroupBox();
            dgvVentas = new DataGridView();
            btnFactura = new Button();
            groupBox1 = new GroupBox();
            gbVentas.SuspendLayout();
            gbModYEl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbVentas
            // 
            gbVentas.Controls.Add(cmbSucursales);
            gbVentas.Controls.Add(btnAgregar);
            gbVentas.Location = new Point(6, 295);
            gbVentas.Margin = new Padding(3, 2, 3, 2);
            gbVentas.Name = "gbVentas";
            gbVentas.Padding = new Padding(3, 2, 3, 2);
            gbVentas.Size = new Size(166, 115);
            gbVentas.TabIndex = 0;
            gbVentas.TabStop = false;
            gbVentas.Text = "Selecciona Sucursal";
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(15, 35);
            cmbSucursales.Margin = new Padding(3, 2, 3, 2);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(133, 23);
            cmbSucursales.TabIndex = 5;
            cmbSucursales.SelectedIndexChanged += cmbSucursales_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(66, 75);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 24);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(514, 371);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 39);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(331, 371);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // gbModYEl
            // 
            gbModYEl.Controls.Add(dgvVentas);
            gbModYEl.Location = new Point(6, 21);
            gbModYEl.Margin = new Padding(3, 2, 3, 2);
            gbModYEl.Name = "gbModYEl";
            gbModYEl.Padding = new Padding(3, 2, 3, 2);
            gbModYEl.Size = new Size(590, 270);
            gbModYEl.TabIndex = 4;
            gbModYEl.TabStop = false;
            gbModYEl.Text = "Lista de Ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(15, 24);
            dgvVentas.Margin = new Padding(3, 2, 3, 2);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(565, 232);
            dgvVentas.TabIndex = 0;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(178, 371);
            btnFactura.Margin = new Padding(3, 2, 3, 2);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(147, 39);
            btnFactura.TabIndex = 5;
            btnFactura.Text = "Generar Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Controls.Add(btnFactura);
            groupBox1.Controls.Add(gbModYEl);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(gbVentas);
            groupBox1.Location = new Point(5, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 424);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ventas";
            // 
            // FormGestionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(622, 430);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGestionVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Ventas";
            gbVentas.ResumeLayout(false);
            gbModYEl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbVentas;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnAgregar;
        private ComboBox cmbSucursales;
        private GroupBox gbModYEl;
        private DataGridView dgvVentas;
        private GroupBox groupBox1;
        private Button btnFactura;
    }
}