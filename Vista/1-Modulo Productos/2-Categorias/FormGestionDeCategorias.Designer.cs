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
            btnRefrescar = new Button();
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
            dgvGestionCategorias.Location = new Point(21, 22);
            dgvGestionCategorias.Name = "dgvGestionCategorias";
            dgvGestionCategorias.Size = new Size(746, 306);
            dgvGestionCategorias.TabIndex = 9;
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
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(385, 395);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(100, 36);
            btnRefrescar.TabIndex = 10;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // grpTodo
            // 
            grpTodo.Controls.Add(groupBox1);
            grpTodo.Controls.Add(btnRefrescar);
            grpTodo.Controls.Add(btnAgregar);
            grpTodo.Controls.Add(btnModificar);
            grpTodo.Controls.Add(btnVolver);
            grpTodo.Controls.Add(btnEliminar);
            grpTodo.Location = new Point(12, 1);
            grpTodo.Name = "grpTodo";
            grpTodo.Size = new Size(809, 452);
            grpTodo.TabIndex = 11;
            grpTodo.TabStop = false;
            grpTodo.Text = "Categorias";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvGestionCategorias);
            groupBox1.Location = new Point(19, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 345);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Categorias";
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
            // FormGestionDeCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(831, 465);
            Controls.Add(grpTodo);
            Name = "FormGestionDeCategorias";
            Text = "FormGestionDeCategorias";
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
        private Button btnRefrescar;
        private GroupBox grpTodo;
        private GroupBox groupBox1;
        private Button btnAgregar;
    }
}