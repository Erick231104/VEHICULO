namespace GestionEmpleados
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
            this.cbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAnioIngreso = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblTarifaPorHora = new System.Windows.Forms.Label();
            this.lblHorasTrabajadas = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblPorcentajeComision = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAnioIngreso = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtTarifaPorHora = new System.Windows.Forms.TextBox();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.txtPorcentajeComision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTipoEmpleado
            // 
            this.cbTipoEmpleado.FormattingEnabled = true;
            this.cbTipoEmpleado.Location = new System.Drawing.Point(425, 59);
            this.cbTipoEmpleado.Name = "cbTipoEmpleado";
            this.cbTipoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbTipoEmpleado.TabIndex = 0;
            this.cbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbTipoEmpleado_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(289, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAnioIngreso
            // 
            this.lblAnioIngreso.AutoSize = true;
            this.lblAnioIngreso.Location = new System.Drawing.Point(289, 156);
            this.lblAnioIngreso.Name = "lblAnioIngreso";
            this.lblAnioIngreso.Size = new System.Drawing.Size(79, 13);
            this.lblAnioIngreso.TabIndex = 2;
            this.lblAnioIngreso.Text = "Año de Ingreso";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(289, 203);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salario";
            // 
            // lblTarifaPorHora
            // 
            this.lblTarifaPorHora.AutoSize = true;
            this.lblTarifaPorHora.Location = new System.Drawing.Point(289, 262);
            this.lblTarifaPorHora.Name = "lblTarifaPorHora";
            this.lblTarifaPorHora.Size = new System.Drawing.Size(78, 13);
            this.lblTarifaPorHora.TabIndex = 4;
            this.lblTarifaPorHora.Text = "Tarifa por Hora";
            // 
            // lblHorasTrabajadas
            // 
            this.lblHorasTrabajadas.AutoSize = true;
            this.lblHorasTrabajadas.Location = new System.Drawing.Point(289, 318);
            this.lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            this.lblHorasTrabajadas.Size = new System.Drawing.Size(91, 13);
            this.lblHorasTrabajadas.TabIndex = 5;
            this.lblHorasTrabajadas.Text = "Horas Trabajadas";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(289, 389);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(40, 13);
            this.lblVentas.TabIndex = 6;
            this.lblVentas.Text = "Ventas";
            // 
            // lblPorcentajeComision
            // 
            this.lblPorcentajeComision.AutoSize = true;
            this.lblPorcentajeComision.Location = new System.Drawing.Point(289, 434);
            this.lblPorcentajeComision.Name = "lblPorcentajeComision";
            this.lblPorcentajeComision.Size = new System.Drawing.Size(118, 13);
            this.lblPorcentajeComision.TabIndex = 7;
            this.lblPorcentajeComision.Text = "Porcentaje de Comision";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(303, 488);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(425, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtAnioIngreso
            // 
            this.txtAnioIngreso.Location = new System.Drawing.Point(425, 153);
            this.txtAnioIngreso.Name = "txtAnioIngreso";
            this.txtAnioIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtAnioIngreso.TabIndex = 10;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(425, 200);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 11;
            // 
            // txtTarifaPorHora
            // 
            this.txtTarifaPorHora.Location = new System.Drawing.Point(425, 259);
            this.txtTarifaPorHora.Name = "txtTarifaPorHora";
            this.txtTarifaPorHora.Size = new System.Drawing.Size(100, 20);
            this.txtTarifaPorHora.TabIndex = 12;
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(425, 315);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabajadas.TabIndex = 13;
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(425, 382);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(100, 20);
            this.txtVentas.TabIndex = 14;
            // 
            // txtPorcentajeComision
            // 
            this.txtPorcentajeComision.Location = new System.Drawing.Point(425, 427);
            this.txtPorcentajeComision.Name = "txtPorcentajeComision";
            this.txtPorcentajeComision.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeComision.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gestion de empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo de Empleado";
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(635, 459);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(143, 52);
            this.btnCalcularSalario.TabIndex = 19;
            this.btnCalcularSalario.Text = "Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 553);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPorcentajeComision);
            this.Controls.Add(this.txtVentas);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.txtTarifaPorHora);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtAnioIngreso);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPorcentajeComision);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.lblHorasTrabajadas);
            this.Controls.Add(this.lblTarifaPorHora);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblAnioIngreso);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbTipoEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAnioIngreso;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblTarifaPorHora;
        private System.Windows.Forms.Label lblHorasTrabajadas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblPorcentajeComision;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAnioIngreso;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtTarifaPorHora;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.TextBox txtPorcentajeComision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcularSalario;
    }
}

