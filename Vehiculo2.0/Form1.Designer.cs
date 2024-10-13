namespace Vehiculo2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtCapacidadBateria = new System.Windows.Forms.TextBox();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblCapacidadBateria = new System.Windows.Forms.Label();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(287, 353);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Vehiculo:";
            // 
            // cbmTipoVehiculo
            // 
            this.cbmTipoVehiculo.FormattingEnabled = true;
            this.cbmTipoVehiculo.Location = new System.Drawing.Point(406, 58);
            this.cbmTipoVehiculo.Name = "cbmTipoVehiculo";
            this.cbmTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbmTipoVehiculo.TabIndex = 2;
            this.cbmTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbmTipoVehiculo_SelectedIndexChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(406, 112);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(406, 170);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 4;
            this.txtAnio.TextChanged += new System.EventHandler(this.txtAño_TextChanged);
            // 
            // txtCapacidadBateria
            // 
            this.txtCapacidadBateria.Location = new System.Drawing.Point(406, 228);
            this.txtCapacidadBateria.Name = "txtCapacidadBateria";
            this.txtCapacidadBateria.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadBateria.TabIndex = 5;
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(406, 275);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(100, 20);
            this.txtCilindrada.TabIndex = 6;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(284, 112);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(284, 170);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año:";
            this.lblAnio.Click += new System.EventHandler(this.lblAño_Click);
            // 
            // lblCapacidadBateria
            // 
            this.lblCapacidadBateria.AutoSize = true;
            this.lblCapacidadBateria.Location = new System.Drawing.Point(284, 235);
            this.lblCapacidadBateria.Name = "lblCapacidadBateria";
            this.lblCapacidadBateria.Size = new System.Drawing.Size(96, 13);
            this.lblCapacidadBateria.TabIndex = 9;
            this.lblCapacidadBateria.Text = "Capacidad bateria:";
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Location = new System.Drawing.Point(284, 282);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(56, 13);
            this.lblCilindrada.TabIndex = 10;
            this.lblCilindrada.Text = "Cilindrada:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(434, 358);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Location = new System.Drawing.Point(434, 390);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(67, 13);
            this.lblCombustible.TabIndex = 12;
            this.lblCombustible.Text = "Combustible:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCombustible);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCilindrada);
            this.Controls.Add(this.lblCapacidadBateria);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtCilindrada);
            this.Controls.Add(this.txtCapacidadBateria);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.cbmTipoVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmTipoVehiculo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtCapacidadBateria;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblCapacidadBateria;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblCombustible;
    }
}

