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
            btnVolver = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            cmbSucursales = new ComboBox();
            gbModYEl = new GroupBox();
            dgvVentas = new DataGridView();
            gbVentas.SuspendLayout();
            gbModYEl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // gbVentas
            // 
            gbVentas.Controls.Add(cmbSucursales);
            gbVentas.Controls.Add(btnVolver);
            gbVentas.Controls.Add(btnAgregar);
            gbVentas.Location = new Point(23, 19);
            gbVentas.Name = "gbVentas";
            gbVentas.Size = new Size(205, 230);
            gbVentas.TabIndex = 0;
            gbVentas.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(25, 181);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(131, 252);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(17, 252);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(25, 119);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(25, 37);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(151, 28);
            cmbSucursales.TabIndex = 5;
            // 
            // gbModYEl
            // 
            gbModYEl.Controls.Add(dgvVentas);
            gbModYEl.Controls.Add(btnModificar);
            gbModYEl.Controls.Add(btnEliminar);
            gbModYEl.Location = new Point(272, 19);
            gbModYEl.Name = "gbModYEl";
            gbModYEl.Size = new Size(770, 295);
            gbModYEl.TabIndex = 4;
            gbModYEl.TabStop = false;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(17, 32);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(747, 188);
            dgvVentas.TabIndex = 0;
            // 
            // FormGestionVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1054, 330);
            Controls.Add(gbModYEl);
            Controls.Add(gbVentas);
            Name = "FormGestionVentas";
            Text = "FormGestionVentas";
            gbVentas.ResumeLayout(false);
            gbModYEl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
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
    }
}