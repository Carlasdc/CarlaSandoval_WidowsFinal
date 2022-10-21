using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CarlaSandoval_WidowsFinal
{
    public partial class Form1 : Form
    {
        private string nombre;
        private string apellido;
        private decimal sueldo;
        private string puesto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            this.nombre = txtNombre.Text.ToUpper();
            this.apellido = txtApellido.Text.ToUpper();
            decimal sueldo = Convert.ToInt32(txtSueldo.Text);
            string puesto = txtPuesto.Text.ToUpper();

            if(sueldo <= 0)
            {
                MessageBox.Show("Ingrese sueldo valido");
            }else
            {
                this.sueldo = sueldo;            
            }
            if (puesto != "DBA" && puesto != "Soporte tecnico" && puesto != "Desarrollador")
            {
                MessageBox.Show("Ingrese Puesto valido");
            }
            else
            {
                this.puesto = puesto;
            }

            MessageBox.Show("La informacion fue validada");

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show( this.nombre + ", " + this.apellido + ". Su puesto es: " + this.puesto );
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            int horasLunes = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Lunes: "));
            int horasMartes = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Martes: "));
            int horasMiercoles = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Miercoles: "));
            int horasJueves = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Jueves: "));
            int horasViernes = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Viernes: "));
            int Total = horasLunes + horasMartes + horasMiercoles + horasJueves + horasViernes;

            MessageBox.Show("El total de horas es: " + Total);
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
