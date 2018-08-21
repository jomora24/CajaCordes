namespace CajaCordes
{
    partial class FormRegistroBeneficiarios
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_parentesco = new System.Windows.Forms.ComboBox();
            this.txt_buscar_titular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar_titular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(181, 262);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 45;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(31, 262);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Registrar.TabIndex = 44;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Apellido Materno";
            // 
            // txt_materno
            // 
            this.txt_materno.Location = new System.Drawing.Point(135, 175);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(121, 20);
            this.txt_materno.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Parentesco";
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(135, 138);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(121, 20);
            this.txt_paterno.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Apellido Paterno";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(135, 101);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre";
            // 
            // cbox_parentesco
            // 
            this.cbox_parentesco.FormattingEnabled = true;
            this.cbox_parentesco.Items.AddRange(new object[] {
            "Hijo",
            "Hija",
            "Esposo",
            "Esposa",
            "Padre",
            "Madre"});
            this.cbox_parentesco.Location = new System.Drawing.Point(135, 214);
            this.cbox_parentesco.Name = "cbox_parentesco";
            this.cbox_parentesco.Size = new System.Drawing.Size(121, 21);
            this.cbox_parentesco.TabIndex = 46;
            // 
            // txt_buscar_titular
            // 
            this.txt_buscar_titular.Location = new System.Drawing.Point(135, 24);
            this.txt_buscar_titular.Name = "txt_buscar_titular";
            this.txt_buscar_titular.Size = new System.Drawing.Size(121, 20);
            this.txt_buscar_titular.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Buscar Titular";
            // 
            // btn_buscar_titular
            // 
            this.btn_buscar_titular.Location = new System.Drawing.Point(31, 62);
            this.btn_buscar_titular.Name = "btn_buscar_titular";
            this.btn_buscar_titular.Size = new System.Drawing.Size(225, 24);
            this.btn_buscar_titular.TabIndex = 49;
            this.btn_buscar_titular.Text = "Buscar Titular";
            this.btn_buscar_titular.UseVisualStyleBackColor = true;
            this.btn_buscar_titular.Click += new System.EventHandler(this.btn_buscar_titular_Click);
            // 
            // FormRegistroBeneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 312);
            this.Controls.Add(this.btn_buscar_titular);
            this.Controls.Add(this.txt_buscar_titular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_parentesco);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_materno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_paterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistroBeneficiarios";
            this.Text = "Registro de los Beneficiarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_materno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_parentesco;
        private System.Windows.Forms.TextBox txt_buscar_titular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buscar_titular;
    }
}