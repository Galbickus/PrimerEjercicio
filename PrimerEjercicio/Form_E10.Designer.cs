namespace PrimerEjercicio
{
    partial class Form_E10
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
            panel1 = new Panel();
            button_limpiar = new Button();
            button_ingresar = new Button();
            textBox_apellido = new TextBox();
            textBox_documento = new TextBox();
            textBox_nombre = new TextBox();
            l_apellido = new Label();
            l_documento = new Label();
            l_nombre = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.gradient_2;
            panel1.Controls.Add(button_limpiar);
            panel1.Controls.Add(button_ingresar);
            panel1.Controls.Add(textBox_apellido);
            panel1.Controls.Add(textBox_documento);
            panel1.Controls.Add(textBox_nombre);
            panel1.Controls.Add(l_apellido);
            panel1.Controls.Add(l_documento);
            panel1.Controls.Add(l_nombre);
            panel1.Font = new Font("Roboto", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(-2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 447);
            panel1.TabIndex = 0;
            // 
            // button_limpiar
            // 
            button_limpiar.BackColor = Color.MidnightBlue;
            button_limpiar.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpiar.ForeColor = SystemColors.ControlLightLight;
            button_limpiar.Location = new Point(607, 213);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(148, 89);
            button_limpiar.TabIndex = 7;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = false;
            // 
            // button_ingresar
            // 
            button_ingresar.BackColor = Color.MidnightBlue;
            button_ingresar.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ingresar.ForeColor = SystemColors.ControlLightLight;
            button_ingresar.Location = new Point(607, 53);
            button_ingresar.Name = "button_ingresar";
            button_ingresar.Size = new Size(148, 89);
            button_ingresar.TabIndex = 6;
            button_ingresar.Text = "Ingresar";
            button_ingresar.UseVisualStyleBackColor = false;
            // 
            // textBox_apellido
            // 
            textBox_apellido.Location = new Point(334, 269);
            textBox_apellido.Name = "textBox_apellido";
            textBox_apellido.Size = new Size(231, 35);
            textBox_apellido.TabIndex = 4;
            // 
            // textBox_documento
            // 
            textBox_documento.Location = new Point(334, 159);
            textBox_documento.Name = "textBox_documento";
            textBox_documento.Size = new Size(231, 35);
            textBox_documento.TabIndex = 5;
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(334, 50);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(231, 35);
            textBox_nombre.TabIndex = 3;
            // 
            // l_apellido
            // 
            l_apellido.AutoSize = true;
            l_apellido.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_apellido.ForeColor = SystemColors.ControlLightLight;
            l_apellido.Location = new Point(83, 155);
            l_apellido.Name = "l_apellido";
            l_apellido.Size = new Size(127, 37);
            l_apellido.TabIndex = 1;
            l_apellido.Text = "Apellido";
            l_apellido.Click += label1_Click;
            // 
            // l_documento
            // 
            l_documento.AutoSize = true;
            l_documento.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_documento.ForeColor = SystemColors.ControlLightLight;
            l_documento.Location = new Point(83, 265);
            l_documento.Name = "l_documento";
            l_documento.Size = new Size(173, 37);
            l_documento.TabIndex = 2;
            l_documento.Text = "Documento";
            // 
            // l_nombre
            // 
            l_nombre.AutoSize = true;
            l_nombre.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_nombre.ForeColor = SystemColors.ControlLightLight;
            l_nombre.Location = new Point(83, 46);
            l_nombre.Name = "l_nombre";
            l_nombre.Size = new Size(125, 37);
            l_nombre.TabIndex = 0;
            l_nombre.Text = "Nombre";
            // 
            // Form_E10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form_E10";
            Text = "Form Equipo 10";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label l_nombre;
        private Label l_documento;
        private Label l_apellido;
        private TextBox textBox_nombre;
        private TextBox textBox_documento;
        private TextBox textBox_apellido;
        private Button button_ingresar;
        private Button button_limpiar;
    }
}
