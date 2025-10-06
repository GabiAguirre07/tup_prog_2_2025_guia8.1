namespace Ej1
{
    partial class Form2
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
            lbxRecibos = new ListBox();
            button1 = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lbxRecibos
            // 
            lbxRecibos.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbxRecibos.FormattingEnabled = true;
            lbxRecibos.ItemHeight = 23;
            lbxRecibos.Location = new Point(23, 12);
            lbxRecibos.Name = "lbxRecibos";
            lbxRecibos.Size = new Size(527, 395);
            lbxRecibos.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(239, 429);
            button1.Name = "button1";
            button1.Size = new Size(324, 65);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(556, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(264, 71);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar Recibo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 506);
            Controls.Add(btnGuardar);
            Controls.Add(button1);
            Controls.Add(lbxRecibos);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        public ListBox lbxRecibos;
        private Button button1;
        private Button btnGuardar;
    }
}