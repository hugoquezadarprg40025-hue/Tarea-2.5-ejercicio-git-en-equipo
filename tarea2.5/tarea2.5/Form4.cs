/*
 * Creado por SharpDevelop.
 * Usuario: Arturo_Gamer
 * Fecha: 04/11/2026
 * Hora: 09:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tarea2._
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		
		void TxtCorXTextChanged(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			double X, Y;
			X=Convert.ToDouble(txtCorX.Text);
			Y=Convert.ToDouble(txtCorY.Text);
			if(X==0 && Y==0)
				MessageBox.Show("La coordenada se encuentra en el origen (punto cero)");
			else if(X>=0 && Y>=0)
				MessageBox.Show("La coordenada se encuentra en el cuadrante 1");
			else if(X<=0 && Y>=0)
				MessageBox.Show("La coordenada se encuentra en el cuadrante 2");
			else if(X<=0 && Y<=0)
				MessageBox.Show("La coordenada se encuentra en el cuadrante 3");
			else if(X>=0 && Y<=0)
				MessageBox.Show("La coordenada se encuentra en el cuadrante 4");			
		}
	}
}
