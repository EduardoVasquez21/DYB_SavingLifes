
namespace ProyectoProgramacion.VISTA
{
    partial class FrmAgendarCita1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendarCita1));
            this.lblIngresarNombreCita = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtIngresarNombreCita = new System.Windows.Forms.TextBox();
            this.btnSalirCitas1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresarNombreCita
            // 
            this.lblIngresarNombreCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIngresarNombreCita.AutoSize = true;
            this.lblIngresarNombreCita.BackColor = System.Drawing.Color.Maroon;
            this.lblIngresarNombreCita.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNombreCita.ForeColor = System.Drawing.Color.White;
            this.lblIngresarNombreCita.Location = new System.Drawing.Point(149, 43);
            this.lblIngresarNombreCita.Name = "lblIngresarNombreCita";
            this.lblIngresarNombreCita.Size = new System.Drawing.Size(166, 16);
            this.lblIngresarNombreCita.TabIndex = 0;
            this.lblIngresarNombreCita.Text = "INGRESE SU NOMBRE";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BackColor = System.Drawing.Color.Maroon;
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(116, 186);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 28);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtIngresarNombreCita
            // 
            this.txtIngresarNombreCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngresarNombreCita.Location = new System.Drawing.Point(92, 134);
            this.txtIngresarNombreCita.Name = "txtIngresarNombreCita";
            this.txtIngresarNombreCita.Size = new System.Drawing.Size(290, 20);
            this.txtIngresarNombreCita.TabIndex = 3;
            this.txtIngresarNombreCita.TextChanged += new System.EventHandler(this.txtIngresarNombreCita_TextChanged);
            // 
            // btnSalirCitas1
            // 
            this.btnSalirCitas1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalirCitas1.BackColor = System.Drawing.Color.Maroon;
            this.btnSalirCitas1.FlatAppearance.BorderSize = 2;
            this.btnSalirCitas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirCitas1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCitas1.ForeColor = System.Drawing.Color.White;
            this.btnSalirCitas1.Location = new System.Drawing.Point(264, 186);
            this.btnSalirCitas1.Name = "btnSalirCitas1";
            this.btnSalirCitas1.Size = new System.Drawing.Size(97, 28);
            this.btnSalirCitas1.TabIndex = 5;
            this.btnSalirCitas1.Text = "SALIR";
            this.btnSalirCitas1.UseVisualStyleBackColor = false;
            this.btnSalirCitas1.Click += new System.EventHandler(this.btnSalirCitas1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personal Autorizado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProyectoProgramacion.Properties.Resources._gota_sangre;
            this.pictureBox1.Location = new System.Drawing.Point(313, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAgendarCita1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.Rojo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirCitas1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIngresarNombreCita);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblIngresarNombreCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgendarCita1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Cita 1";
            this.Load += new System.EventHandler(this.FrmAgendarCita1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarNombreCita;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtIngresarNombreCita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalirCitas1;
        private System.Windows.Forms.Label label1;
    }
}