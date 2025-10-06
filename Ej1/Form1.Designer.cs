namespace Ej1
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
            btnMostrar = new Button();
            lbxEmpleados = new ListBox();
            ofd = new OpenFileDialog();
            btnAgregar = new Button();
            button1 = new Button();
            sfd = new SaveFileDialog();
            btnRecibos = new Button();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(625, 264);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(302, 79);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar Empleados";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click_1;
            // 
            // lbxEmpleados
            // 
            lbxEmpleados.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbxEmpleados.FormattingEnabled = true;
            lbxEmpleados.ItemHeight = 23;
            lbxEmpleados.Location = new Point(12, 20);
            lbxEmpleados.Name = "lbxEmpleados";
            lbxEmpleados.ScrollAlwaysVisible = true;
            lbxEmpleados.Size = new Size(602, 487);
            lbxEmpleados.TabIndex = 1;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(625, 76);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(302, 71);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Importar Empleados";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(625, 172);
            button1.Name = "button1";
            button1.Size = new Size(302, 71);
            button1.TabIndex = 3;
            button1.Text = "Exportar Empleados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnRecibos
            // 
            btnRecibos.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRecibos.Location = new Point(625, 372);
            btnRecibos.Name = "btnRecibos";
            btnRecibos.Size = new Size(302, 79);
            btnRecibos.TabIndex = 4;
            btnRecibos.Text = "Generar Recibos\r\n";
            btnRecibos.UseVisualStyleBackColor = true;
            btnRecibos.Click += btnRecibos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 519);
            Controls.Add(btnRecibos);
            Controls.Add(button1);
            Controls.Add(btnAgregar);
            Controls.Add(lbxEmpleados);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrar;
        private ListBox lbxEmpleados;
        private OpenFileDialog ofd;
        private Button btnAgregar;
        private Button button1;
        private SaveFileDialog sfd;
        private Button btnRecibos;
    }
}
