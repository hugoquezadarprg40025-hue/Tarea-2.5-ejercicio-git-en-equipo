/*
 * Creado por SharpDevelop.
 * Usuario: Arturo_Gamer
 * Fecha: 04/11/2026
 * Hora: 10:15 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tarea2._
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double X1, X2, Y1, Y2, D;
			X1=Convert.ToDouble(txtX1.Text);
			X2=Convert.ToDouble(txtX2.Text);
			Y1=Convert.ToDouble(txtY1.Text);
			Y2=Convert.ToDouble(txtY2.Text);
			D=Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2));
			MessageBox.Show("La distancia entre el punto a y el punto b es: "+D.ToString("0.##"));
		}
	}
}
