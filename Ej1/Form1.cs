using Ej1.Models;
using System.Globalization;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbxEmpleados.SelectedIndexChanged += lbxEmpleados_SelectedValueChanged;
        }

        

        List<Empleado> empleados = new List<Empleado>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            lbxEmpleados.Items.Clear();
            lbxEmpleados.Items.AddRange(empleados.ToArray());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Archivos csv|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lbxEmpleados.Items.Clear();
                ofd.Title = "Importación de empleados";
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string cabAsalariado = sr.ReadLine();
                    string cabJornalero = sr.ReadLine();
                    while (sr.EndOfStream == false)
                    {
                        string linea = sr.ReadLine();
                        string[] separador = linea.Split(";");
                        string tipo = separador[0];
                        int DNI = Convert.ToInt32(separador[1]);
                        string nombre = separador[2];
                        Empleado empleado = null;
                        if (tipo == "Asalariado")
                        {
                            double basico = Double.Parse(separador[3],CultureInfo.InvariantCulture);
                            double aportes = Double.Parse(separador[4],CultureInfo.InvariantCulture);
                            empleado = new Asalariado(DNI, nombre, basico, aportes);

                        }
                        else if (tipo == "Jornalero")
                        {
                            int HorasTrabajadas = Convert.ToInt32(separador[3]);
                            double ImportePorHora = Double.Parse(separador[4],CultureInfo.InvariantCulture);
                            double Retenciones = Double.Parse(separador[5],CultureInfo.InvariantCulture);
                            empleado = new Jornalero(DNI, nombre, HorasTrabajadas, ImportePorHora, Retenciones);
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        empleados.Sort();
                        int idx = empleados.BinarySearch(empleado);
                        if (idx >= 0)
                        {
                            if (empleado is Asalariado)
                            {
                                ((Asalariado)empleados[idx]).Nombre = empleado.Nombre;
                                ((Asalariado)empleados[idx]).Basico = ((Asalariado)empleado).Basico;
                            }
                            else if (empleado is Jornalero)
                            {
                                ((Jornalero)empleados[idx]).Nombre= empleado.Nombre;
                               ((Jornalero)empleados[idx]).ImportePorHora = ((Jornalero)empleado).ImportePorHora;
                            }
                        }
                        else
                        {
                            empleados.Add(empleado);
                        }
                    }
                    btnMostrar.PerformClick();
                    MessageBox.Show("Empleados importados correctamente");
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

        private void button1_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Archivos csv|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("Tipo:Asalariado;DNI;Nombre;Básico,Aportes provisionales");
                    sw.WriteLine("Tipo:Jornalero; DNI; Nombre; Horas Trabajadas; Importe Por Hora; Retenciones");
                    foreach (IExportable empleado in empleados)
                    {
                        sw.WriteLine(empleado.Exportar());
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

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            Form2 modal = new Form2();
            modal.lbxRecibos.Items.Clear();
            modal.lbxRecibos.BeginUpdate();
            foreach (Empleado empleado in empleados)
            {
                modal.lbxRecibos.Items.AddRange(empleado.GenerarRecibo());
                modal.lbxRecibos.Items.Add("------------------------------------------------------");
            }
            modal.lbxRecibos.EndUpdate();
            modal.ShowDialog();
        }
        private void lbxEmpleados_SelectedValueChanged(object sender, EventArgs e)
        {
            Empleado seleccionado = lbxEmpleados.SelectedItem as Empleado;
            if (seleccionado != null)
            {
                Form2 modal = new Form2();
                modal.lbxRecibos.Items.Clear();
                modal.lbxRecibos.Items.AddRange(seleccionado.GenerarRecibo());
                modal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }

}
