namespace Encuesta_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Español = new System.Windows.Forms.CheckBox();
            this.Ingles = new System.Windows.Forms.CheckBox();
            this.Aleman = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.Femenino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Comentarios = new System.Windows.Forms.RichTextBox();
            this.Edad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Edad)).BeginInit();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(217, 167);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(242, 20);
            this.Fecha.TabIndex = 0;
            // 
            // Español
            // 
            this.Español.AutoSize = true;
            this.Español.Location = new System.Drawing.Point(12, 119);
            this.Español.Name = "Español";
            this.Español.Size = new System.Drawing.Size(64, 17);
            this.Español.TabIndex = 1;
            this.Español.Text = "Español";
            this.Español.UseVisualStyleBackColor = true;
            // 
            // Ingles
            // 
            this.Ingles.AutoSize = true;
            this.Ingles.Location = new System.Drawing.Point(12, 142);
            this.Ingles.Name = "Ingles";
            this.Ingles.Size = new System.Drawing.Size(54, 17);
            this.Ingles.TabIndex = 2;
            this.Ingles.Text = "Ingles";
            this.Ingles.UseVisualStyleBackColor = true;
            // 
            // Aleman
            // 
            this.Aleman.AutoSize = true;
            this.Aleman.Location = new System.Drawing.Point(12, 163);
            this.Aleman.Name = "Aleman";
            this.Aleman.Size = new System.Drawing.Size(61, 17);
            this.Aleman.TabIndex = 3;
            this.Aleman.Text = "Aleman";
            this.Aleman.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado";
            // 
            // Estado
            // 
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Jalisco",
            "DF",
            "Monterrey",
            "Sinaloa"});
            this.Estado.Location = new System.Drawing.Point(12, 41);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(80, 21);
            this.Estado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Idiomas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sexo";
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(45, 199);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(73, 17);
            this.Masculino.TabIndex = 9;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Location = new System.Drawing.Point(47, 222);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(71, 17);
            this.Femenino.TabIndex = 10;
            this.Femenino.TabStop = true;
            this.Femenino.Text = "Femenino";
            this.Femenino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Comentarios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // Comentarios
            // 
            this.Comentarios.Location = new System.Drawing.Point(47, 348);
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.Size = new System.Drawing.Size(290, 96);
            this.Comentarios.TabIndex = 16;
            this.Comentarios.Text = "";
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(42, 286);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(88, 20);
            this.Edad.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 485);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Comentarios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Femenino);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aleman);
            this.Controls.Add(this.Ingles);
            this.Controls.Add(this.Español);
            this.Controls.Add(this.Fecha);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.CheckBox Español;
        private System.Windows.Forms.CheckBox Ingles;
        private System.Windows.Forms.CheckBox Aleman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.RadioButton Femenino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox Comentarios;
        private System.Windows.Forms.NumericUpDown Edad;
    }
}

