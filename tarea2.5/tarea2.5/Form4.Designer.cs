/*
 * Creado por SharpDevelop.
 * Usuario: Arturo_Gamer
 * Fecha: 04/11/2026
 * Hora: 09:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace tarea2._
{
	partial class Form4
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCorY = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtCorX = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(150, 83);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 15);
			this.label3.TabIndex = 11;
			this.label3.Text = "eje Y:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(150, 40);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "eje X:";
			// 
			// txtCorY
			// 
			this.txtCorY.Location = new System.Drawing.Point(150, 99);
			this.txtCorY.Margin = new System.Windows.Forms.Padding(2);
			this.txtCorY.Name = "txtCorY";
			this.txtCorY.Size = new System.Drawing.Size(68, 20);
			this.txtCorY.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(98, 131);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 39);
			this.button1.TabIndex = 8;
			this.button1.Text = "Revelar cuadrante";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtCorX
			// 
			this.txtCorX.Location = new System.Drawing.Point(150, 57);
			this.txtCorX.Margin = new System.Windows.Forms.Padding(2);
			this.txtCorX.Name = "txtCorX";
			this.txtCorX.Size = new System.Drawing.Size(68, 20);
			this.txtCorX.TabIndex = 7;
			this.txtCorX.TextChanged += new System.EventHandler(this.TxtCorXTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(43, 77);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 21);
			this.label1.TabIndex = 6;
			this.label1.Text = "Coordenada:";
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(278, 202);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCorY);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtCorX);
			this.Controls.Add(this.label1);
			this.Name = "Form4";
			this.Text = "Form4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCorX;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtCorY;
		private System.Windows.Forms.Label label3;
		

	}
}
