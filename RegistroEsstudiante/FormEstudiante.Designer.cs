namespace RegistroEsstudiante
{
    partial class FormEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelGrado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.NumericUpDown();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonBecado = new System.Windows.Forms.RadioButton();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Edad)).BeginInit();
            this.gbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(36, 18);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(44, 66);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(43, 16);
            this.labelEdad.TabIndex = 1;
            this.labelEdad.Text = "Edad:";
            // 
            // labelGrado
            // 
            this.labelGrado.AutoSize = true;
            this.labelGrado.Location = new System.Drawing.Point(36, 130);
            this.labelGrado.Name = "labelGrado";
            this.labelGrado.Size = new System.Drawing.Size(51, 16);
            this.labelGrado.TabIndex = 2;
            this.labelGrado.Text = "Grado: ";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(123, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // Edad
            // 
            this.Edad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Edad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Edad.Location = new System.Drawing.Point(123, 64);
            this.Edad.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Edad.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(120, 22);
            this.Edad.TabIndex = 4;
            this.Edad.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // cmbGrado
            // 
            this.cmbGrado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.cmbGrado.Location = new System.Drawing.Point(122, 130);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(121, 24);
            this.cmbGrado.TabIndex = 5;
            // 
            // gbEstado
            // 
            this.gbEstado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbEstado.Controls.Add(this.radioButtonRegular);
            this.gbEstado.Controls.Add(this.radioButtonBecado);
            this.gbEstado.Location = new System.Drawing.Point(43, 207);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(200, 100);
            this.gbEstado.TabIndex = 6;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado del Estudiante: ";
            this.gbEstado.Enter += new System.EventHandler(this.gbEstado_Enter);
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(6, 57);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(76, 20);
            this.radioButtonRegular.TabIndex = 7;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "Regular";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // radioButtonBecado
            // 
            this.radioButtonBecado.AutoSize = true;
            this.radioButtonBecado.Location = new System.Drawing.Point(6, 31);
            this.radioButtonBecado.Name = "radioButtonBecado";
            this.radioButtonBecado.Size = new System.Drawing.Size(76, 20);
            this.radioButtonBecado.TabIndex = 7;
            this.radioButtonBecado.TabStop = true;
            this.radioButtonBecado.Text = "Becado";
            this.radioButtonBecado.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonGuardar.Location = new System.Drawing.Point(96, 342);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(128, 67);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(713, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelGrado);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormEstudiante";
            this.Text = "FormEstudiante";
            this.Load += new System.EventHandler(this.FormEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Edad)).EndInit();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelGrado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown Edad;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonBecado;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}