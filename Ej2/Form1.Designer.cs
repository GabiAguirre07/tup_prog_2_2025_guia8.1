namespace Ej2
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
            groupBox1 = new GroupBox();
            btnAltaEvento = new Button();
            tbNombre = new TextBox();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnImportar = new Button();
            lbxEventos = new ListBox();
            label3 = new Label();
            btnExportar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAltaEvento);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(859, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Evento Nuevo";
            // 
            // btnAltaEvento
            // 
            btnAltaEvento.Font = new Font("Arial", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAltaEvento.Location = new Point(556, 44);
            btnAltaEvento.Name = "btnAltaEvento";
            btnAltaEvento.Size = new Size(186, 99);
            btnAltaEvento.TabIndex = 4;
            btnAltaEvento.Text = "Alta Evento";
            btnAltaEvento.UseVisualStyleBackColor = true;
            btnAltaEvento.Click += btnAltaEvento_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(186, 105);
            tbNombre.Multiline = true;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(348, 34);
            tbNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 108);
            label2.Name = "label2";
            label2.Size = new Size(163, 24);
            label2.TabIndex = 2;
            label2.Text = "Nombre Evento:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(99, 55);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(168, 32);
            dtpFecha.TabIndex = 1;
            dtpFecha.Value = new DateTime(2025, 10, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 55);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExportar);
            groupBox2.Controls.Add(btnImportar);
            groupBox2.Controls.Add(lbxEventos);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(32, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(849, 419);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Administración de Eventos";
            // 
            // btnImportar
            // 
            btnImportar.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnImportar.Location = new Point(618, 79);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(225, 106);
            btnImportar.TabIndex = 5;
            btnImportar.Text = "Importar Tecnicos/Expositores";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // lbxEventos
            // 
            lbxEventos.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbxEventos.FormattingEnabled = true;
            lbxEventos.ItemHeight = 23;
            lbxEventos.Location = new Point(7, 79);
            lbxEventos.Name = "lbxEventos";
            lbxEventos.Size = new Size(597, 326);
            lbxEventos.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 45);
            label3.Name = "label3";
            label3.Size = new Size(584, 24);
            label3.TabIndex = 5;
            label3.Text = "Seleccione un evento del listado y realice alguna operación:";
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(618, 229);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(225, 106);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "Exportar Tecnicos/Expositores";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 655);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbNombre;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label1;
        private Button btnAltaEvento;
        private GroupBox groupBox2;
        private ListBox lbxEventos;
        private Label label3;
        private Button btnImportar;
        private Button btnExportar;
    }
}
