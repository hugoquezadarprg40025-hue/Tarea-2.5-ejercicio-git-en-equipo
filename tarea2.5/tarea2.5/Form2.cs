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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double cambio, cantidad;
			cantidad=Convert.ToDouble(txtCantidad.Text);
			if((rdbMXNaUSD.Checked==false && rdbUSDaMXN.Checked==false) || txtCantidad.Text=="")
				MessageBox.Show("Porfavor seleccione un tipo de convercion");
			else
			{
				if(rdbUSDaMXN.Checked)
				{
					cambio=cantidad*18.58;
					lblCambio.Text=cantidad+" USD a MXN son: "+cambio.ToString("0.###")+" MXN";
				}
				else if(rdbMXNaUSD.Checked)
				{
					cambio=cantidad*0.054;
					lblCambio.Text=cantidad+" MXN a USD son: "+cambio.ToString("0.###")+" USD";
				}
			}
		}
	}
}
