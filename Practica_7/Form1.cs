using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encuesta_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estado = this.Estado.ActiveText;

		string lenguajes = "";
		if(this.Español.Active){
			lenguajes = "Español,";
		}

		if(this.Ingles.Active){
			lenguajes += "Inglés,";
		}

		if(this.Aleman.Active){
			lenguajes += "Aleman";
		}

		string sexo = "";
		if(this.Masculino.Active){
			sexo = "Masculino";
		}else if(this.Femenino.Active){
			sexo = "Femenino";
		}

		string comentario = this.Comentarios.Buffer.Text;
		string edad = this.Edad.Text;
		DateTime fecha = this.Fecha.GetDate();

		MessageDialog md = new MessageDialog (null, 
      	DialogFlags.Modal,
  		MessageType.Info, 
      	ButtonsType.None, "Estos son los datos: \n" +
                           "Estado: " + estado +"\n"+
                           "Edad: " + edad +"\n"+
                           "Lenguajes: " + lenguajes +"\n"+
                           "Sexo: " + sexo +"\n"+
                           "Comentario: " + comentario +"\n"+
                           "Fecha: " + fecha.ToShortDateString() +"\n");
		md.Show();

	}
        }

    }
}