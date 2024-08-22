using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contRegistros = 0;

        Persona person;
        DepartamentoVehicular depto = new DepartamentoVehicular();
        RegistroVehiculo registro;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormPedirDatos datos = new FormPedirDatos();
            if (datos.ShowDialog() == DialogResult.OK)
            {
                person = new Persona(Convert.ToInt32(datos.tbDNI.Text), datos.tbNombre.Text);
                contRegistros++;
                RegistroVehiculo reg = depto.RegistrarVehiculo(person);
            }
        }

        private void btnListarRegistros_Click(object sender, EventArgs e)
        {
            lbxListarRegistros.Items.Clear();
            for (int i=0; i < contRegistros; i++)
            {
                RegistroVehiculo regi = depto.VerRegistro(i);
                lbxListarRegistros.Items.Add(regi.VerDetalle());
            }
        }
    }
}
