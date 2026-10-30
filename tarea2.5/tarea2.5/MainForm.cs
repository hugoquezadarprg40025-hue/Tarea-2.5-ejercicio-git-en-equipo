/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 29/10/2026
 * Hora: 07:28 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tarea2._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnVerificarClick(object sender, EventArgs e)
		{
			if(txtUsuario.Text=="" || txtContraseña.Text=="")
				MessageBox.Show("Ingrese su usuario y contraseña para loggearte");
			else
			{
				if(txtContraseña.Text=="skibidicito123" && txtUsuario.Text=="trabaja arturo")
				{
					Form1 x=new Form1();
					x.ShowDialog();
					//Si ves esto y eres arturo ve por que no se puede cerrar el mainform con this.Close();
					//this.Close;
				}
				else
					MessageBox.Show("El usuario o contraseña son incorrectos");
			}
		}
	}
}
