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
            btnVolver = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            gbModYEl = new GroupBox();
            dgvVentas = new DataGridView();
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
            gbVentas.Controls.Add(btnVolver);
            gbVentas.Controls.Add(btnAgregar);
            gbVentas.Location = new Point(8, 21);
            gbVentas.Margin = new Padding(3, 2, 3, 2);
            gbVentas.Name = "gbVentas";
            gbVentas.Padding = new Padding(3, 2, 3, 2);
            gbVentas.Size = new Size(179, 115);
            gbVentas.TabIndex = 0;
            gbVentas.TabStop = false;
            gbVentas.Text = "Selecciona Sucursal";
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(23, 24);
            cmbSucursales.Margin = new Padding(3, 2, 3, 2);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(133, 23);
            cmbSucursales.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(90, 61);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 39);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(5, 61);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 39);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(113, 234);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 32);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(15, 234);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 32);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // gbModYEl
            // 
            gbModYEl.Controls.Add(dgvVentas);
            gbModYEl.Controls.Add(btnModificar);
            gbModYEl.Controls.Add(btnEliminar);
            gbModYEl.Location = new Point(193, 21);
            gbModYEl.Margin = new Padding(3, 2, 3, 2);
            gbModYEl.Name = "gbModYEl";
            gbModYEl.Padding = new Padding(3, 2, 3, 2);
            gbModYEl.Size = new Size(434, 270);
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
            dgvVentas.Size = new Size(400, 206);
            dgvVentas.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gbModYEl);
            groupBox1.Controls.Add(gbVentas);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 307);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ventas";
            // 
            // FormGestionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(659, 323);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGestionVentas";
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
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox cmbSucursales;
        private GroupBox gbModYEl;
        private DataGridView dgvVentas;
        private GroupBox groupBox1;
    }
}