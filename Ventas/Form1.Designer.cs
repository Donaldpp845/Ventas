namespace Ventas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnagregarClie = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnagregarClie
            // 
            btnagregarClie.BackColor = Color.Lime;
            btnagregarClie.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregarClie.Location = new Point(248, 69);
            btnagregarClie.Name = "btnagregarClie";
            btnagregarClie.Size = new Size(356, 47);
            btnagregarClie.TabIndex = 0;
            btnagregarClie.Text = "Agregar Clientes";
            btnagregarClie.UseVisualStyleBackColor = false;
            btnagregarClie.Click += btnagregarClie_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(248, 218);
            button1.Name = "button1";
            button1.Size = new Size(356, 52);
            button1.TabIndex = 1;
            button1.Text = "Agregar Pedidos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(927, 443);
            Controls.Add(button1);
            Controls.Add(btnagregarClie);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnagregarClie;
        private Button button1;
    }
}