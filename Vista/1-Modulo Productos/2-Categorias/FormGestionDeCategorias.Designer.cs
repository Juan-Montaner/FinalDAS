namespace Vista.Gestion_de_Productos
{
    partial class FormGestionDeCategorias
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
            dgvGestionCategorias = new DataGridView();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            grpTodo = new GroupBox();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGestionCategorias).BeginInit();
            grpTodo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGestionCategorias
            // 
            dgvGestionCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionCategorias.Location = new Point(24, 29);
            dgvGestionCategorias.Margin = new Padding(3, 4, 3, 4);
            dgvGestionCategorias.Name = "dgvGestionCategorias";
            dgvGestionCategorias.RowHeadersWidth = 51;
            dgvGestionCategorias.Size = new Size(853, 408);
            dgvGestionCategorias.TabIndex = 9;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(802, 512);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 55);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(301, 512);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 48);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(161, 512);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 48);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // grpTodo
            // 
            grpTodo.Controls.Add(groupBox1);
            grpTodo.Controls.Add(btnAgregar);
            grpTodo.Controls.Add(btnModificar);
            grpTodo.Controls.Add(btnVolver);
            grpTodo.Controls.Add(btnEliminar);
            grpTodo.Location = new Point(14, 1);
            grpTodo.Margin = new Padding(3, 4, 3, 4);
            grpTodo.Name = "grpTodo";
            grpTodo.Padding = new Padding(3, 4, 3, 4);
            grpTodo.Size = new Size(925, 583);
            grpTodo.TabIndex = 11;
            grpTodo.TabStop = false;
            grpTodo.Text = "Categorias";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvGestionCategorias);
            groupBox1.Location = new Point(22, 29);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(891, 460);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Categorias";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(22, 512);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 48);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormGestionDeCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(950, 595);
            Controls.Add(grpTodo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionDeCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Categorias";
            ((System.ComponentModel.ISupportInitialize)dgvGestionCategorias).EndInit();
            grpTodo.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGestionCategorias;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnModificar;
        private GroupBox grpTodo;
        private GroupBox groupBox1;
        private Button btnAgregar;
    }
}