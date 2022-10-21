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
        private int horasLunes;
        private int horasMartes;
        private int horasMiercoles;
        private int horasJueves;
        private int horasViernes;
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean puestoValido(string puesto)
        {
            return puesto == "DBA" || puesto == "SOPORTE TECNICO" || puesto == "DESARROLLADOR";
              
        }

        private Boolean sueldoValido(decimal sueldo)
        {
            return sueldo > 0;
        }

        private Boolean nombreValido(string texto)
        {
            return texto.Length > 2 && texto.Length < 50;
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
           
            string nombre = txtNombre.Text.ToUpper();
            string apellido = txtApellido.Text.ToUpper();
            decimal sueldo = Convert.ToInt32(txtSueldo.Text);
            string puesto = txtPuesto.Text.ToUpper();
            if (puestoValido(puesto) && sueldoValido(sueldo) && nombreValido(nombre) && nombreValido(apellido)) {
                this.puesto = puesto;
                this.sueldo = sueldo;
                this.nombre = nombre;
                this.apellido = apellido;

                MessageBox.Show("La informacion ha sido Validada");
            }            
            if(!puestoValido(puesto))
            {
                MessageBox.Show("El puesto debe ser “Soporte Técnico”, “DBA” o “Desarrollador”");
            }
            if(!sueldoValido(sueldo))
            {
                MessageBox.Show("El sueldo debe ser mayor a 0");
            }
            if (!nombreValido(nombre))
            {
                MessageBox.Show("El nombre no es valido (Debe tener mas de 2 y menos de 50 caracteres)");
            }
            if (!nombreValido(apellido))
            {
                MessageBox.Show("El apellido no es valido (Debe tener mas de 2 y menos de 50 caracteres)");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show( this.nombre + ", " + this.apellido + ". Su puesto es: " + this.puesto );
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            this.horasLunes = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Lunes: ","HorasTrabajadas", "0"));
            this.horasMartes = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Martes: ", "HorasTrabajadas", "0"));
            this.horasMiercoles = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Miercoles: ", "HorasTrabajadas", "0"));
            this.horasJueves = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Jueves: ", "HorasTrabajadas", "0"));
            this.horasViernes = Convert.ToInt32(Interaction.InputBox("Ingrese numero de horas trabajadas Viernes: ", "HorasTrabajadas", "0"));
            int Total = this.horasLunes + this.horasMartes + this.horasMiercoles + this.horasJueves + this.horasViernes;
            decimal promedio = Total / 5;
            string diasMenosCuatroHoras = "";
            if(this.horasLunes < 4)
            {
                diasMenosCuatroHoras = diasMenosCuatroHoras + "Lunes ,";
            }
            if (this.horasMartes < 4)
            {
                diasMenosCuatroHoras = diasMenosCuatroHoras + "Martes ,";
            }
            if (this.horasMiercoles < 4)
            {
                diasMenosCuatroHoras = diasMenosCuatroHoras + "Miercoles ,";
            }
            if (this.horasJueves < 4)
            {
                diasMenosCuatroHoras = diasMenosCuatroHoras + "Jueves ,";
            }
            if (this.horasViernes < 4)
            {
                diasMenosCuatroHoras = diasMenosCuatroHoras + "Viernes .";
            }
            MessageBox.Show("El total de horas es: " + Total);
            MessageBox.Show("El promedio de horas trabajadas es: " + promedio);
            MessageBox.Show("Los dias trabajados menos de 4 horas son: " + diasMenosCuatroHoras);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.nombre = "";
            this.apellido = "";
            this.sueldo = 0;
            this.puesto = "";
            this.horasLunes = 0;
            this.horasMartes = 0;
            this.horasMiercoles = 0;
            this.horasJueves = 0;
            this.horasViernes = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtPuesto.Clear();
            txtSueldo.Clear();
        }
        
    }
}
