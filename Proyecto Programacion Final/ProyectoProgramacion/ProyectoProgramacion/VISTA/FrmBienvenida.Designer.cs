
namespace ProyectoProgramacion.VISTA
{
    partial class FrmBienvenida
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
            this.btnIngresarBienvenida = new System.Windows.Forms.Button();
            this.btnSalirBienvenida = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarBienvenida
            // 
            this.btnIngresarBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIngresarBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresarBienvenida.FlatAppearance.BorderSize = 0;
            this.btnIngresarBienvenida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIngresarBienvenida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIngresarBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarBienvenida.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarBienvenida.Location = new System.Drawing.Point(172, 271);
            this.btnIngresarBienvenida.Name = "btnIngresarBienvenida";
            this.btnIngresarBienvenida.Size = new System.Drawing.Size(104, 30);
            this.btnIngresarBienvenida.TabIndex = 0;
            this.btnIngresarBienvenida.Text = "INGRESAR";
            this.btnIngresarBienvenida.UseVisualStyleBackColor = false;
            this.btnIngresarBienvenida.Click += new System.EventHandler(this.btnIngresarBienvenida_Click);
            // 
            // btnSalirBienvenida
            // 
            this.btnSalirBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalirBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirBienvenida.FlatAppearance.BorderSize = 0;
            this.btnSalirBienvenida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalirBienvenida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalirBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirBienvenida.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirBienvenida.Location = new System.Drawing.Point(316, 271);
            this.btnSalirBienvenida.Name = "btnSalirBienvenida";
            this.btnSalirBienvenida.Size = new System.Drawing.Size(103, 30);
            this.btnSalirBienvenida.TabIndex = 1;
            this.btnSalirBienvenida.Text = "SALIR";
            this.btnSalirBienvenida.UseVisualStyleBackColor = false;
            this.btnSalirBienvenida.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBienvenida.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(190, 230);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(218, 23);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "Donating Your Blood";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = global::ProyectoProgramacion.Properties.Resources.sangre_gif;
            this.pictureBox1.Image = global::ProyectoProgramacion.Properties.Resources.Donacion1;
            this.pictureBox1.Location = new System.Drawing.Point(148, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "DYB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.Rojo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirBienvenida);
            this.Controls.Add(this.btnIngresarBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.FrmBienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarBienvenida;
        private System.Windows.Forms.Button btnSalirBienvenida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label label1;
    }
}