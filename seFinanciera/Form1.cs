using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seFinanciera
{
    public partial class Form1 : Form
    {
        List<Reglas> reglas = new List<Reglas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool CapacidadAlta(HashSet<string> c)
        {

            return c.Contains("Alto") && c.Contains("Permanente") && c.Contains("SinAtrazos");
        }

        public bool CapacidadMedia(HashSet<string> c)
        {

            return c.Contains("Medio") && c.Contains("Permanente") && c.Contains("Atrazos");
        }
        public bool CapacidadBaja(HashSet<string> c)
        {

            return (c.Contains("Bajo") || c.Contains("Temporal")) && c.Contains("Atrazos");
        }


        public string Motor(List<Reglas> reglas, HashSet<string> hechos)
        {
            string conclusion = "";
            bool nuevoHecho;
            do
            {
                nuevoHecho = false;

                foreach (var regla in reglas)
                {
                    if (regla.Condicion(hechos) && !hechos.Contains(regla.Conclusion))
                    {
                        hechos.Add(regla.Conclusion);
                        nuevoHecho = true;
                        conclusion += regla.Conclusion + " ";
                    }
                }
            } while (nuevoHecho);

            return conclusion;

            

        }

        private void cmdSolucion_Click(object sender, EventArgs e)
        {
            HashSet<string> hechos = new HashSet<string>();
            reglas.Clear();

            reglas.Add(new Reglas(CapacidadAlta,"Cliente Preferencial,puede optar por un credito hipotecario a largo plazo"));
            reglas.Add(new Reglas(CapacidadMedia, "Cliente Regular,puede optar por un credito vehicular a medio plazo"));
            reglas.Add(new Reglas(CapacidadBaja, "Cliente de Riesgo,puede optar por un prestamo personal a corto plazo"));
            
            if (chkPermanente.Checked) hechos.Add("Permanente");
            if (chkTemporal.Checked) hechos.Add("Temporal");
            if (chkAlto.Checked) hechos.Add("Alto");
            if (chkMedio.Checked) hechos.Add("Medio");
            if (chkBajo.Checked) hechos.Add("Bajo");
            if (chkSinAtrazos.Checked) hechos.Add("SinAtrazos");
            if (chkAtrazos.Checked) hechos.Add("Atrazos");

            string razonamiento = Motor(reglas, hechos);
            if (razonamiento == "") razonamiento = "No hay suficientes datos para ofrecer solucion.";
            txtResultado.Text = razonamiento;

        }
    }
}
