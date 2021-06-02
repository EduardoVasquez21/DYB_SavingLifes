
namespace ProyectoProgramacion.VISTA
{
    partial class FrmCompatibilidadSanguinea
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
            this.btnSalirTipoSangre = new System.Windows.Forms.Button();
            this.dtgCompatibilidad = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompatibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirTipoSangre
            // 
            this.btnSalirTipoSangre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirTipoSangre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalirTipoSangre.FlatAppearance.BorderSize = 2;
            this.btnSalirTipoSangre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirTipoSangre.Location = new System.Drawing.Point(584, 458);
            this.btnSalirTipoSangre.Name = "btnSalirTipoSangre";
            this.btnSalirTipoSangre.Size = new System.Drawing.Size(96, 27);
            this.btnSalirTipoSangre.TabIndex = 0;
            this.btnSalirTipoSangre.Text = "SALIR";
            this.btnSalirTipoSangre.UseVisualStyleBackColor = false;
            this.btnSalirTipoSangre.Click += new System.EventHandler(this.btnSalirTipoSangre_Click);
            // 
            // dtgCompatibilidad
            // 
            this.dtgCompatibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCompatibilidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCompatibilidad.BackgroundColor = System.Drawing.Color.Maroon;
            this.dtgCompatibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCompatibilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgCompatibilidad.Location = new System.Drawing.Point(31, 30);
            this.dtgCompatibilidad.Name = "dtgCompatibilidad";
            this.dtgCompatibilidad.Size = new System.Drawing.Size(649, 215);
            this.dtgCompatibilidad.TabIndex = 1;
            this.dtgCompatibilidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCompatibilidad_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Donante";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Grupo Sanguineo";
            this.Column3.Name = "Column3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoProgramacion.Properties.Resources.Donacion2;
            this.pictureBox1.Location = new System.Drawing.Point(111, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCompatibilidadSanguinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.Rojo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgCompatibilidad);
            this.Controls.Add(this.btnSalirTipoSangre);
            this.Name = "FrmCompatibilidadSanguinea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compatibilidad Sanguinea";
            this.Load += new System.EventHandler(this.FrmCompatibilidadSanguinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompatibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirTipoSangre;
        private System.Windows.Forms.DataGridView dtgCompatibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}