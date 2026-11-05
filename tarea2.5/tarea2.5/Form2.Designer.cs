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
	partial class Form2
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblCambio = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbMXNaUSD = new System.Windows.Forms.RadioButton();
			this.rdbUSDaMXN = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCalcular.Location = new System.Drawing.Point(198, 160);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(83, 23);
			this.btnCalcular.TabIndex = 10;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblCambio
			// 
			this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.lblCambio.Location = new System.Drawing.Point(156, 200);
			this.lblCambio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCambio.Name = "lblCambio";
			this.lblCambio.Size = new System.Drawing.Size(240, 15);
			this.lblCambio.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(95, 197);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Cambio:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(179, 130);
			this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(203, 20);
			this.txtCantidad.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbMXNaUSD);
			this.groupBox1.Controls.Add(this.rdbUSDaMXN);
			this.groupBox1.Location = new System.Drawing.Point(95, 61);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(285, 60);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de conversion:";
			// 
			// rdbMXNaUSD
			// 
			this.rdbMXNaUSD.Location = new System.Drawing.Point(166, 25);
			this.rdbMXNaUSD.Margin = new System.Windows.Forms.Padding(2);
			this.rdbMXNaUSD.Name = "rdbMXNaUSD";
			this.rdbMXNaUSD.Size = new System.Drawing.Size(95, 16);
			this.rdbMXNaUSD.TabIndex = 1;
			this.rdbMXNaUSD.TabStop = true;
			this.rdbMXNaUSD.Text = "MXN a USD";
			this.rdbMXNaUSD.UseVisualStyleBackColor = true;
			// 
			// rdbUSDaMXN
			// 
			this.rdbUSDaMXN.Location = new System.Drawing.Point(20, 25);
			this.rdbUSDaMXN.Margin = new System.Windows.Forms.Padding(2);
			this.rdbUSDaMXN.Name = "rdbUSDaMXN";
			this.rdbUSDaMXN.Size = new System.Drawing.Size(95, 16);
			this.rdbUSDaMXN.TabIndex = 0;
			this.rdbUSDaMXN.TabStop = true;
			this.rdbUSDaMXN.Text = "USD a MXN";
			this.rdbUSDaMXN.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(95, 130);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cantidad:";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 276);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblCambio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdbUSDaMXN;
		private System.Windows.Forms.RadioButton rdbMXNaUSD;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblCambio;
		private System.Windows.Forms.Button btnCalcular;
	}
}
