namespace Vista._3_Modulo_Ventas
{
    partial class FormABMVentas
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
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            lblVendedor = new Label();
            lblFecha = new Label();
            lblRazon = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            btnAgregar = new Button();
            btnFinalizar = new Button();
            btnVolver = new Button();
            gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // gbVentas
            // 
            gbVentas.Controls.Add(btnFinalizar);
            gbVentas.Controls.Add(btnAgregar);
            gbVentas.Controls.Add(textBox2);
            gbVentas.Controls.Add(dateTimePicker1);
            gbVentas.Controls.Add(textBox1);
            gbVentas.Controls.Add(lblVendedor);
            gbVentas.Controls.Add(lblFecha);
            gbVentas.Controls.Add(lblRazon);
            gbVentas.Location = new Point(25, 28);
            gbVentas.Name = "gbVentas";
            gbVentas.Size = new Size(383, 229);
            gbVentas.TabIndex = 0;
            gbVentas.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(118, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(25, 119);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(76, 20);
            lblVendedor.TabIndex = 2;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(25, 77);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(23, 37);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(97, 20);
            lblRazon.TabIndex = 0;
            lblRazon.Text = "Razon Social:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(448, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(659, 188);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(448, 275);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(659, 188);
            dataGridView2.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 184);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(274, 184);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(94, 29);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(25, 434);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormABMVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1145, 508);
            Controls.Add(btnVolver);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(gbVentas);
            Name = "FormABMVentas";
            Text = "FormABMVentas";
            gbVentas.ResumeLayout(false);
            gbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbVentas;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label lblVendedor;
        private Label lblFecha;
        private Label lblRazon;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btnFinalizar;
        private Button btnAgregar;
        private Button btnVolver;
    }
}