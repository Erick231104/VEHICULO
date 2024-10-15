namespace WindowsFormsApp1
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
            this.cbTipoAnimal = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            this.lblTipoAnimal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblHabitat = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTamañoAlas = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTamañoAlas = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.btnMostrarInfo = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTipoAnimal
            // 
            this.cbTipoAnimal.FormattingEnabled = true;
            this.cbTipoAnimal.Location = new System.Drawing.Point(383, 52);
            this.cbTipoAnimal.Name = "cbTipoAnimal";
            this.cbTipoAnimal.Size = new System.Drawing.Size(121, 21);
            this.cbTipoAnimal.TabIndex = 0;
            this.cbTipoAnimal.SelectedIndexChanged += new System.EventHandler(this.cbTipoAnimal_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(383, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(383, 211);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // txtHabitat
            // 
            this.txtHabitat.Location = new System.Drawing.Point(383, 270);
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.Size = new System.Drawing.Size(100, 20);
            this.txtHabitat.TabIndex = 3;
            // 
            // lblTipoAnimal
            // 
            this.lblTipoAnimal.AutoSize = true;
            this.lblTipoAnimal.Location = new System.Drawing.Point(234, 60);
            this.lblTipoAnimal.Name = "lblTipoAnimal";
            this.lblTipoAnimal.Size = new System.Drawing.Size(62, 13);
            this.lblTipoAnimal.TabIndex = 4;
            this.lblTipoAnimal.Text = "Tipo Animal";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(251, 149);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(254, 218);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            // 
            // lblHabitat
            // 
            this.lblHabitat.AutoSize = true;
            this.lblHabitat.Location = new System.Drawing.Point(254, 277);
            this.lblHabitat.Name = "lblHabitat";
            this.lblHabitat.Size = new System.Drawing.Size(39, 13);
            this.lblHabitat.TabIndex = 7;
            this.lblHabitat.Text = "habitat";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(383, 317);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 8;
            // 
            // txtTamañoAlas
            // 
            this.txtTamañoAlas.Location = new System.Drawing.Point(383, 367);
            this.txtTamañoAlas.Name = "txtTamañoAlas";
            this.txtTamañoAlas.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoAlas.TabIndex = 9;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(383, 418);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 10;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(254, 324);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 11;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTamañoAlas
            // 
            this.lblTamañoAlas.AutoSize = true;
            this.lblTamañoAlas.Location = new System.Drawing.Point(254, 374);
            this.lblTamañoAlas.Name = "lblTamañoAlas";
            this.lblTamañoAlas.Size = new System.Drawing.Size(69, 13);
            this.lblTamañoAlas.TabIndex = 12;
            this.lblTamañoAlas.Text = "Tamaño Alas";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(251, 421);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(67, 13);
            this.lblTemperatura.TabIndex = 13;
            this.lblTemperatura.Text = "Temperatura";
            // 
            // btnMostrarInfo
            // 
            this.btnMostrarInfo.Location = new System.Drawing.Point(621, 435);
            this.btnMostrarInfo.Name = "btnMostrarInfo";
            this.btnMostrarInfo.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarInfo.TabIndex = 14;
            this.btnMostrarInfo.Text = "Mostrar Info";
            this.btnMostrarInfo.UseVisualStyleBackColor = true;
            this.btnMostrarInfo.Click += new System.EventHandler(this.btnMostrarInfo_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(249, 471);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMostrarInfo);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblTamañoAlas);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtTamañoAlas);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblHabitat);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTipoAnimal);
            this.Controls.Add(this.txtHabitat);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbTipoAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoAnimal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtHabitat;
        private System.Windows.Forms.Label lblTipoAnimal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblHabitat;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTamañoAlas;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTamañoAlas;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Button btnMostrarInfo;
        private System.Windows.Forms.Label lblResultado;
    }
}

