namespace seFinanciera
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
            this.chkAlto = new System.Windows.Forms.CheckBox();
            this.chkMedio = new System.Windows.Forms.CheckBox();
            this.chkBajo = new System.Windows.Forms.CheckBox();
            this.chkPermanente = new System.Windows.Forms.CheckBox();
            this.chkTemporal = new System.Windows.Forms.CheckBox();
            this.chkSinAtrazos = new System.Windows.Forms.CheckBox();
            this.chkAtrazos = new System.Windows.Forms.CheckBox();
            this.cmdSolucion = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkAlto
            // 
            this.chkAlto.AutoSize = true;
            this.chkAlto.Location = new System.Drawing.Point(56, 103);
            this.chkAlto.Name = "chkAlto";
            this.chkAlto.Size = new System.Drawing.Size(119, 17);
            this.chkAlto.TabIndex = 0;
            this.chkAlto.Text = "Salario mayor a 50k";
            this.chkAlto.UseVisualStyleBackColor = true;
            // 
            // chkMedio
            // 
            this.chkMedio.AutoSize = true;
            this.chkMedio.Location = new System.Drawing.Point(56, 138);
            this.chkMedio.Name = "chkMedio";
            this.chkMedio.Size = new System.Drawing.Size(135, 17);
            this.chkMedio.TabIndex = 1;
            this.chkMedio.Text = "Salario entre 25k y 50k";
            this.chkMedio.UseVisualStyleBackColor = true;
            // 
            // chkBajo
            // 
            this.chkBajo.AutoSize = true;
            this.chkBajo.Location = new System.Drawing.Point(56, 176);
            this.chkBajo.Name = "chkBajo";
            this.chkBajo.Size = new System.Drawing.Size(120, 17);
            this.chkBajo.TabIndex = 2;
            this.chkBajo.Text = "Salario menor a 25k";
            this.chkBajo.UseVisualStyleBackColor = true;
            // 
            // chkPermanente
            // 
            this.chkPermanente.AutoSize = true;
            this.chkPermanente.Location = new System.Drawing.Point(244, 103);
            this.chkPermanente.Name = "chkPermanente";
            this.chkPermanente.Size = new System.Drawing.Size(122, 17);
            this.chkPermanente.TabIndex = 3;
            this.chkPermanente.Text = "Trabajo Permanente";
            this.chkPermanente.UseVisualStyleBackColor = true;
            // 
            // chkTemporal
            // 
            this.chkTemporal.AutoSize = true;
            this.chkTemporal.Location = new System.Drawing.Point(244, 138);
            this.chkTemporal.Name = "chkTemporal";
            this.chkTemporal.Size = new System.Drawing.Size(109, 17);
            this.chkTemporal.TabIndex = 4;
            this.chkTemporal.Text = "Trabajo Temporal";
            this.chkTemporal.UseVisualStyleBackColor = true;
            // 
            // chkSinAtrazos
            // 
            this.chkSinAtrazos.AutoSize = true;
            this.chkSinAtrazos.Location = new System.Drawing.Point(456, 103);
            this.chkSinAtrazos.Name = "chkSinAtrazos";
            this.chkSinAtrazos.Size = new System.Drawing.Size(224, 17);
            this.chkSinAtrazos.TabIndex = 5;
            this.chkSinAtrazos.Text = "No posee atrasos en préstamos anteriores";
            this.chkSinAtrazos.UseVisualStyleBackColor = true;
            // 
            // chkAtrazos
            // 
            this.chkAtrazos.AutoSize = true;
            this.chkAtrazos.Location = new System.Drawing.Point(456, 138);
            this.chkAtrazos.Name = "chkAtrazos";
            this.chkAtrazos.Size = new System.Drawing.Size(208, 17);
            this.chkAtrazos.TabIndex = 6;
            this.chkAtrazos.Text = "Posee atrasos en préstamos anteriores";
            this.chkAtrazos.UseVisualStyleBackColor = true;
            // 
            // cmdSolucion
            // 
            this.cmdSolucion.Location = new System.Drawing.Point(108, 280);
            this.cmdSolucion.Name = "cmdSolucion";
            this.cmdSolucion.Size = new System.Drawing.Size(75, 23);
            this.cmdSolucion.TabIndex = 7;
            this.cmdSolucion.Text = "Determinar";
            this.cmdSolucion.UseVisualStyleBackColor = true;
            this.cmdSolucion.Click += new System.EventHandler(this.cmdSolucion_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(211, 283);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(469, 46);
            this.txtResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.cmdSolucion);
            this.Controls.Add(this.chkAtrazos);
            this.Controls.Add(this.chkSinAtrazos);
            this.Controls.Add(this.chkTemporal);
            this.Controls.Add(this.chkPermanente);
            this.Controls.Add(this.chkBajo);
            this.Controls.Add(this.chkMedio);
            this.Controls.Add(this.chkAlto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAlto;
        private System.Windows.Forms.CheckBox chkMedio;
        private System.Windows.Forms.CheckBox chkBajo;
        private System.Windows.Forms.CheckBox chkPermanente;
        private System.Windows.Forms.CheckBox chkTemporal;
        private System.Windows.Forms.CheckBox chkSinAtrazos;
        private System.Windows.Forms.CheckBox chkAtrazos;
        private System.Windows.Forms.Button cmdSolucion;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

