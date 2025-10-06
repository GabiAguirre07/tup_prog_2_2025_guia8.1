using Ej2.Models;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAltaEvento_Click(object sender, EventArgs e)
        {
            string nombreEvento = tbNombre.Text;
            DateTime fechaEvento = dtpFecha.Value.Date;
            Evento evento = new Evento(fechaEvento, nombreEvento);
            lbxEventos.Items.Add(evento);
            tbNombre.Clear();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Evento seleccionado = lbxEventos.SelectedItem as Evento;
            if (seleccionado != null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos csv|*.csv";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = null;
                    StreamReader sr = null;
                    try
                    {
                        fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        sr = new StreamReader(fs);
                        string cabtecnico = sr.ReadLine();
                        string cabexpositor = sr.ReadLine();
                        while (sr.EndOfStream == false)
                        {
                            string linea = sr.ReadLine();
                            string[] separador = linea.Split(";");
                            IExportable registro = null;
                            if (separador[0] == "EXPOSITOR")
                            {
                                registro = new Expositor();
                            }
                            else if (separador[0] == "TECNICO")
                            {
                                registro = new Tecnico();
                            }
                            if (registro != null)
                            {
                                registro.Leer(separador);
                                seleccionado.RegistrarExportable(registro);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (sr != null) sr.Close();
                        if (fs != null) fs.Close();
                    }
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Evento seleccionado = lbxEventos.SelectedItem as Evento;
            if (seleccionado != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = ("Archivos.csv|*.csv");
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = null;
                    StreamWriter sw = null;
                    try
                    {
                        fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        string linea = "Tipo:TECNICO;CUIT;Nombre;Cargo";
                        sw.WriteLine(linea);
                        linea = "Tipo:EXPOSITOR; DNI; Nombre; Papel Protagónico";
                        sw.WriteLine(linea);
                        foreach (IExportable exportable in seleccionado.VerExportables())
                        {
                            sw.WriteLine(exportable.Escribir());
                        }
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
}
