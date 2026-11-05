/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 29/10/2026
 * Hora: 07:40 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tarea2._
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
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
			Form2 x=new Form2();
			x.ShowDialog();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form3 y=new Form3();
			y.ShowDialog();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form4 z=new Form4();
			z.ShowDialog();
		}
	}
}
