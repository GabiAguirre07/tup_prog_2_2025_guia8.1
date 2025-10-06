using Ej1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SaveFileDialog save;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            save = new SaveFileDialog();
            save.Filter = ("Archivos.txt|*.txt");
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(save.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    foreach (var item in lbxRecibos.Items)
                    {
                        sw.WriteLine(item);
                    }
                    MessageBox.Show("Recibo/s guardado/s correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
    }
}
