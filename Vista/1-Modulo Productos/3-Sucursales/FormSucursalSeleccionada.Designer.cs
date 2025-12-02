namespace Vista._1_Modulo_Productos._3_Sucursales
{
    partial class FormSucursalSeleccionada
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
            gbBotones = new GroupBox();
            dgvProductosSucursal = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            gbBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosSucursal).BeginInit();
            SuspendLayout();
            // 
            // gbBotones
            // 
            gbBotones.Controls.Add(btnVolver);
            gbBotones.Controls.Add(btnEliminar);
            gbBotones.Controls.Add(btnModificar);
            gbBotones.Controls.Add(btnAgregar);
            gbBotones.Location = new Point(12, 377);
            gbBotones.Name = "gbBotones";
            gbBotones.Size = new Size(997, 90);
            gbBotones.TabIndex = 0;
            gbBotones.TabStop = false;
            // 
            // dgvProductosSucursal
            // 
            dgvProductosSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosSucursal.Location = new Point(12, 12);
            dgvProductosSucursal.Name = "dgvProductosSucursal";
            dgvProductosSucursal.RowHeadersWidth = 51;
            dgvProductosSucursal.Size = new Size(997, 343);
            dgvProductosSucursal.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(19, 31);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(170, 31);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(319, 31);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(529, 31);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormSucursalSeleccionada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1028, 507);
            Controls.Add(dgvProductosSucursal);
            Controls.Add(gbBotones);
            Name = "FormSucursalSeleccionada";
            Text = "FormSucursalSeleccionada";
            gbBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductosSucursal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbBotones;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvProductosSucursal;
    }
}