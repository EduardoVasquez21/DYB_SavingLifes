
namespace ProyectoProgramacion.VISTA
{
    partial class FrmAgendarCitas2
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dtgAgendarCita = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnSalirAgendarCita2 = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNomUs = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendarCita)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.BackColor = System.Drawing.Color.Gold;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 45);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dtgAgendarCita
            // 
            this.dtgAgendarCita.AllowUserToAddRows = false;
            this.dtgAgendarCita.AllowUserToDeleteRows = false;
            this.dtgAgendarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgAgendarCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAgendarCita.BackgroundColor = System.Drawing.Color.Maroon;
            this.dtgAgendarCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgendarCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgAgendarCita.Location = new System.Drawing.Point(328, 57);
            this.dtgAgendarCita.Name = "dtgAgendarCita";
            this.dtgAgendarCita.ReadOnly = true;
            this.dtgAgendarCita.Size = new System.Drawing.Size(548, 150);
            this.dtgAgendarCita.TabIndex = 2;
            this.dtgAgendarCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgendarCita_CellClick);
            this.dtgAgendarCita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgendarCita_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Donante";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Grupo Sanguineo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de Donacion";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblUsuario.Enabled = false;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(722, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(24, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Lic.";
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgendarCita.BackColor = System.Drawing.Color.Maroon;
            this.btnAgendarCita.FlatAppearance.BorderSize = 2;
            this.btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCita.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgendarCita.Location = new System.Drawing.Point(214, 229);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(105, 29);
            this.btnAgendarCita.TabIndex = 4;
            this.btnAgendarCita.Text = "Agendar Cita";
            this.btnAgendarCita.UseVisualStyleBackColor = false;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnSalirAgendarCita2
            // 
            this.btnSalirAgendarCita2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirAgendarCita2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirAgendarCita2.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.Salir;
            this.btnSalirAgendarCita2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalirAgendarCita2.FlatAppearance.BorderSize = 0;
            this.btnSalirAgendarCita2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalirAgendarCita2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalirAgendarCita2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirAgendarCita2.Location = new System.Drawing.Point(758, 340);
            this.btnSalirAgendarCita2.Name = "btnSalirAgendarCita2";
            this.btnSalirAgendarCita2.Size = new System.Drawing.Size(118, 37);
            this.btnSalirAgendarCita2.TabIndex = 5;
            this.btnSalirAgendarCita2.UseVisualStyleBackColor = false;
            this.btnSalirAgendarCita2.Click += new System.EventHandler(this.btnSalirAgendarCita2_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(653, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 6;
            // 
            // lblNomUs
            // 
            this.lblNomUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomUs.AutoSize = true;
            this.lblNomUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNomUs.Enabled = false;
            this.lblNomUs.ForeColor = System.Drawing.Color.White;
            this.lblNomUs.Location = new System.Drawing.Point(767, 24);
            this.lblNomUs.Name = "lblNomUs";
            this.lblNomUs.Size = new System.Drawing.Size(83, 13);
            this.lblNomUs.TabIndex = 7;
            this.lblNomUs.Text = "Nombre Usuario";
            this.lblNomUs.Click += new System.EventHandler(this.lblNomUs_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(18, 255);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(142, 20);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.Visible = false;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.Enabled = false;
            this.txtId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtId.Location = new System.Drawing.Point(18, 229);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 20);
            this.txtId.TabIndex = 9;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // FrmAgendarCitas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.Rojo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 389);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblNomUs);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSalirAgendarCita2);
            this.Controls.Add(this.btnAgendarCita);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dtgAgendarCita);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "FrmAgendarCitas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Citas 2";
            this.Load += new System.EventHandler(this.FrmAgendarCitas2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendarCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dtgAgendarCita;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnSalirAgendarCita2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblNomUs;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtId;
    }
}