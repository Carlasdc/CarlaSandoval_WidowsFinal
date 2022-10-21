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
            int total = 0;
            for (int i =0; i <5; i++) {
                
                int horas = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas por dia: "));
                total = total + horas;
            }

            MessageBox.Show("El total de horas es: " + total);
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
