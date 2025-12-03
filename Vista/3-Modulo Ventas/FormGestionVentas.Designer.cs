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
            gbVentas.Location = new Point(9, 28);
            gbVentas.Name = "gbVentas";
            gbVentas.Size = new Size(205, 153);
            gbVentas.TabIndex = 0;
            gbVentas.TabStop = false;
            gbVentas.Text = "Selecciona Sucursal";
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(26, 32);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(151, 28);
            cmbSucursales.TabIndex = 5;
            cmbSucursales.SelectedIndexChanged += cmbSucursales_SelectedIndexChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(103, 81);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 52);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(6, 81);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 52);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(17, 313);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 43);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // gbModYEl
            // 
            gbModYEl.Controls.Add(dgvVentas);
            gbModYEl.Controls.Add(btnEliminar);
            gbModYEl.Location = new Point(221, 28);
            gbModYEl.Name = "gbModYEl";
            gbModYEl.Size = new Size(496, 360);
            gbModYEl.TabIndex = 4;
            gbModYEl.TabStop = false;
            gbModYEl.Text = "Lista de Ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(17, 32);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(457, 275);
            dgvVentas.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gbModYEl);
            groupBox1.Controls.Add(gbVentas);
            groupBox1.Location = new Point(14, 7);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(726, 409);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ventas";
            // 
            // FormGestionVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(753, 431);
            Controls.Add(groupBox1);
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
        private Button btnAgregar;
        private ComboBox cmbSucursales;
        private GroupBox gbModYEl;
        private DataGridView dgvVentas;
        private GroupBox groupBox1;
    }
}