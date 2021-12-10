
namespace ClinicaPrivada
{
    partial class FormuAgregarMedico
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
            this.LBLNombreMedic = new System.Windows.Forms.Label();
            this.TXTNombreMedic = new System.Windows.Forms.TextBox();
            this.TXTApellidoMedic = new System.Windows.Forms.TextBox();
            this.LBLApellidoMedic = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNAgregarMedico = new System.Windows.Forms.Button();
            this.CBboxEspecialidaMedic = new System.Windows.Forms.ComboBox();
            this.LBLEspecialidadMedic = new System.Windows.Forms.Label();
            this.TXTEdadMedic = new System.Windows.Forms.TextBox();
            this.LBLEdadMedic = new System.Windows.Forms.Label();
            this.TXTDniMedic = new System.Windows.Forms.TextBox();
            this.LBLDNIMedic = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLNombreMedic
            // 
            this.LBLNombreMedic.AutoSize = true;
            this.LBLNombreMedic.Location = new System.Drawing.Point(33, 35);
            this.LBLNombreMedic.Name = "LBLNombreMedic";
            this.LBLNombreMedic.Size = new System.Drawing.Size(51, 15);
            this.LBLNombreMedic.TabIndex = 0;
            this.LBLNombreMedic.Text = "Nombre";
            this.LBLNombreMedic.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTNombreMedic
            // 
            this.TXTNombreMedic.Location = new System.Drawing.Point(33, 53);
            this.TXTNombreMedic.Name = "TXTNombreMedic";
            this.TXTNombreMedic.Size = new System.Drawing.Size(161, 23);
            this.TXTNombreMedic.TabIndex = 1;
            // 
            // TXTApellidoMedic
            // 
            this.TXTApellidoMedic.Location = new System.Drawing.Point(33, 97);
            this.TXTApellidoMedic.Name = "TXTApellidoMedic";
            this.TXTApellidoMedic.Size = new System.Drawing.Size(161, 23);
            this.TXTApellidoMedic.TabIndex = 3;
            // 
            // LBLApellidoMedic
            // 
            this.LBLApellidoMedic.AutoSize = true;
            this.LBLApellidoMedic.Location = new System.Drawing.Point(33, 79);
            this.LBLApellidoMedic.Name = "LBLApellidoMedic";
            this.LBLApellidoMedic.Size = new System.Drawing.Size(51, 15);
            this.LBLApellidoMedic.TabIndex = 2;
            this.LBLApellidoMedic.Text = "Apellido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNAgregarMedico);
            this.groupBox1.Controls.Add(this.CBboxEspecialidaMedic);
            this.groupBox1.Controls.Add(this.LBLEspecialidadMedic);
            this.groupBox1.Controls.Add(this.TXTEdadMedic);
            this.groupBox1.Controls.Add(this.LBLEdadMedic);
            this.groupBox1.Controls.Add(this.TXTDniMedic);
            this.groupBox1.Controls.Add(this.LBLDNIMedic);
            this.groupBox1.Controls.Add(this.LBLNombreMedic);
            this.groupBox1.Controls.Add(this.TXTApellidoMedic);
            this.groupBox1.Controls.Add(this.TXTNombreMedic);
            this.groupBox1.Controls.Add(this.LBLApellidoMedic);
            this.groupBox1.Location = new System.Drawing.Point(167, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 331);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Medico";
            // 
            // BTNAgregarMedico
            // 
            this.BTNAgregarMedico.Location = new System.Drawing.Point(33, 282);
            this.BTNAgregarMedico.Name = "BTNAgregarMedico";
            this.BTNAgregarMedico.Size = new System.Drawing.Size(161, 23);
            this.BTNAgregarMedico.TabIndex = 10;
            this.BTNAgregarMedico.Text = "AgregarMedico";
            this.BTNAgregarMedico.UseVisualStyleBackColor = true;
            this.BTNAgregarMedico.Click += new System.EventHandler(this.BTNAgregarMedico_Click);
            // 
            // CBboxEspecialidaMedic
            // 
            this.CBboxEspecialidaMedic.FormattingEnabled = true;
            this.CBboxEspecialidaMedic.Location = new System.Drawing.Point(33, 230);
            this.CBboxEspecialidaMedic.Name = "CBboxEspecialidaMedic";
            this.CBboxEspecialidaMedic.Size = new System.Drawing.Size(161, 23);
            this.CBboxEspecialidaMedic.TabIndex = 9;
            // 
            // LBLEspecialidadMedic
            // 
            this.LBLEspecialidadMedic.AutoSize = true;
            this.LBLEspecialidadMedic.Location = new System.Drawing.Point(33, 211);
            this.LBLEspecialidadMedic.Name = "LBLEspecialidadMedic";
            this.LBLEspecialidadMedic.Size = new System.Drawing.Size(72, 15);
            this.LBLEspecialidadMedic.TabIndex = 8;
            this.LBLEspecialidadMedic.Text = "Especialidad";
            this.LBLEspecialidadMedic.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXTEdadMedic
            // 
            this.TXTEdadMedic.Location = new System.Drawing.Point(33, 185);
            this.TXTEdadMedic.Name = "TXTEdadMedic";
            this.TXTEdadMedic.Size = new System.Drawing.Size(161, 23);
            this.TXTEdadMedic.TabIndex = 7;
            // 
            // LBLEdadMedic
            // 
            this.LBLEdadMedic.AutoSize = true;
            this.LBLEdadMedic.Location = new System.Drawing.Point(33, 167);
            this.LBLEdadMedic.Name = "LBLEdadMedic";
            this.LBLEdadMedic.Size = new System.Drawing.Size(33, 15);
            this.LBLEdadMedic.TabIndex = 6;
            this.LBLEdadMedic.Text = "Edad";
            // 
            // TXTDniMedic
            // 
            this.TXTDniMedic.Location = new System.Drawing.Point(33, 141);
            this.TXTDniMedic.Name = "TXTDniMedic";
            this.TXTDniMedic.Size = new System.Drawing.Size(161, 23);
            this.TXTDniMedic.TabIndex = 5;
            // 
            // LBLDNIMedic
            // 
            this.LBLDNIMedic.AutoSize = true;
            this.LBLDNIMedic.Location = new System.Drawing.Point(33, 123);
            this.LBLDNIMedic.Name = "LBLDNIMedic";
            this.LBLDNIMedic.Size = new System.Drawing.Size(27, 15);
            this.LBLDNIMedic.TabIndex = 4;
            this.LBLDNIMedic.Text = "DNI";
            // 
            // FormuAgregarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 435);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormuAgregarMedico";
            this.Text = "FormuAgregarMedico";
            this.Load += new System.EventHandler(this.FormuAgregarMedico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBLNombreMedic;
        private System.Windows.Forms.TextBox TXTNombreMedic;
        private System.Windows.Forms.TextBox TXTApellidoMedic;
        private System.Windows.Forms.Label LBLApellidoMedic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLEspecialidadMedic;
        private System.Windows.Forms.TextBox TXTEdadMedic;
        private System.Windows.Forms.Label LBLEdadMedic;
        private System.Windows.Forms.TextBox TXTDniMedic;
        private System.Windows.Forms.Label LBLDNIMedic;
        private System.Windows.Forms.ComboBox CBboxEspecialidaMedic;
        private System.Windows.Forms.Button BTNAgregarMedico;
    }
}