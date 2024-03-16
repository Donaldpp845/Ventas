namespace Ventas
{
    partial class Agregar_Clientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            btnguardar = new Button();
            dataGridViewClientes = new DataGridView();
            btneliminar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 96);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 0;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 179);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 0;
            label3.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(194, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(267, 31);
            txtApellido.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(194, 180);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(267, 31);
            txtEdad.TabIndex = 1;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(39, 298);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(112, 34);
            btnguardar.TabIndex = 2;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(521, 29);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewClientes.RowTemplate.Height = 33;
            dataGridViewClientes.Size = new Size(523, 303);
            dataGridViewClientes.TabIndex = 3;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(194, 298);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(112, 34);
            btneliminar.TabIndex = 4;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(349, 298);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Agregar_Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 406);
            Controls.Add(btnActualizar);
            Controls.Add(btneliminar);
            Controls.Add(dataGridViewClientes);
            Controls.Add(btnguardar);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Agregar_Clientes";
            Text = "Agregar_Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private Button btnguardar;
        private DataGridView dataGridViewClientes;
        private Button btneliminar;
        private Button btnActualizar;
    }
}