namespace Vista._5_Modulo_Vendedores
{
    partial class FormGestionVendedores
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
            grpTodo = new GroupBox();
            gbListaVendedores = new GroupBox();
            dgvVendedores = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnVolver = new Button();
            btnEliminar = new Button();
            grpTodo.SuspendLayout();
            gbListaVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            SuspendLayout();
            // 
            // grpTodo
            // 
            grpTodo.Controls.Add(gbListaVendedores);
            grpTodo.Controls.Add(btnAgregar);
            grpTodo.Controls.Add(btnModificar);
            grpTodo.Controls.Add(btnVolver);
            grpTodo.Controls.Add(btnEliminar);
            grpTodo.Location = new Point(10, 10);
            grpTodo.Name = "grpTodo";
            grpTodo.Size = new Size(809, 445);
            grpTodo.TabIndex = 12;
            grpTodo.TabStop = false;
            grpTodo.Text = "Vendedores";
            // 
            // gbListaVendedores
            // 
            gbListaVendedores.Controls.Add(dgvVendedores);
            gbListaVendedores.Location = new Point(19, 22);
            gbListaVendedores.Name = "gbListaVendedores";
            gbListaVendedores.Size = new Size(780, 345);
            gbListaVendedores.TabIndex = 11;
            gbListaVendedores.TabStop = false;
            gbListaVendedores.Text = "Lista de Vendedores";
            // 
            // dgvVendedores
            // 
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Location = new Point(21, 22);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.RowHeadersWidth = 51;
            dgvVendedores.Size = new Size(746, 306);
            dgvVendedores.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(19, 395);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 36);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(141, 395);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 36);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(702, 395);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(97, 41);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(263, 395);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 36);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormGestionVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(830, 458);
            Controls.Add(grpTodo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGestionVendedores";
            Text = "Gestion de Vendedores";
            grpTodo.ResumeLayout(false);
            gbListaVendedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTodo;
        private GroupBox gbListaVendedores;
        private DataGridView dgvVendedores;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnVolver;
        private Button btnEliminar;
    }
}