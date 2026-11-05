/*
 * Creado por SharpDevelop.
 * Usuario: Arturo_Gamer
 * Fecha: 04/11/2026
 * Hora: 10:15 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace tarea2._
{
	partial class Form3
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
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtY2 = new System.Windows.Forms.TextBox();
			this.txtX2 = new System.Windows.Forms.TextBox();
			this.txtY1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(195, 57);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 15);
			this.label6.TabIndex = 21;
			this.label6.Text = "Punto b:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(57, 57);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 20;
			this.label5.Text = "Punto a:";
			// 
			// txtY2
			// 
			this.txtY2.Location = new System.Drawing.Point(246, 107);
			this.txtY2.Margin = new System.Windows.Forms.Padding(2);
			this.txtY2.Name = "txtY2";
			this.txtY2.Size = new System.Drawing.Size(68, 20);
			this.txtY2.TabIndex = 19;
			// 
			// txtX2
			// 
			this.txtX2.Location = new System.Drawing.Point(246, 81);
			this.txtX2.Margin = new System.Windows.Forms.Padding(2);
			this.txtX2.Name = "txtX2";
			this.txtX2.Size = new System.Drawing.Size(68, 20);
			this.txtX2.TabIndex = 18;
			// 
			// txtY1
			// 
			this.txtY1.Location = new System.Drawing.Point(111, 107);
			this.txtY1.Margin = new System.Windows.Forms.Padding(2);
			this.txtY1.Name = "txtY1";
			this.txtY1.Size = new System.Drawing.Size(68, 20);
			this.txtY1.TabIndex = 17;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.button1.Location = new System.Drawing.Point(147, 145);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 28);
			this.button1.TabIndex = 16;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtX1
			// 
			this.txtX1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtX1.Location = new System.Drawing.Point(111, 81);
			this.txtX1.Margin = new System.Windows.Forms.Padding(2);
			this.txtX1.Name = "txtX1";
			this.txtX1.Size = new System.Drawing.Size(68, 20);
			this.txtX1.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(195, 109);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "Y2:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(195, 81);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "X2:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(57, 107);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Y1:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(57, 81);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "X1:";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 231);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtY2);
			this.Controls.Add(this.txtX2);
			this.Controls.Add(this.txtY1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtX1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtX2;
		private System.Windows.Forms.TextBox txtY2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtX1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtY1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}
