
namespace ProyectoProgramacion.VISTA
{
    partial class FrmBuscarDonante
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
            this.lblIngreseDonante = new System.Windows.Forms.Label();
            this.txtDonanteaBuscar = new System.Windows.Forms.TextBox();
            this.dtgBuscarDonante = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarBDonante = new System.Windows.Forms.Button();
            this.btnSalirBDonante = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarDonante)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngreseDonante
            // 
            this.lblIngreseDonante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngreseDonante.AutoSize = true;
            this.lblIngreseDonante.BackColor = System.Drawing.Color.Navy;
            this.lblIngreseDonante.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseDonante.ForeColor = System.Drawing.Color.White;
            this.lblIngreseDonante.Location = new System.Drawing.Point(296, 40);
            this.lblIngreseDonante.Name = "lblIngreseDonante";
            this.lblIngreseDonante.Size = new System.Drawing.Size(313, 18);
            this.lblIngreseDonante.TabIndex = 0;
            this.lblIngreseDonante.Text = "Ingrese Nombre de Donante a Buscar";
            // 
            // txtDonanteaBuscar
            // 
            this.txtDonanteaBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonanteaBuscar.Location = new System.Drawing.Point(346, 83);
            this.txtDonanteaBuscar.Name = "txtDonanteaBuscar";
            this.txtDonanteaBuscar.Size = new System.Drawing.Size(222, 20);
            this.txtDonanteaBuscar.TabIndex = 1;
            this.txtDonanteaBuscar.TextChanged += new System.EventHandler(this.txtDonanteaBuscar_TextChanged);
            // 
            // dtgBuscarDonante
            // 
            this.dtgBuscarDonante.AllowUserToAddRows = false;
            this.dtgBuscarDonante.AllowUserToDeleteRows = false;
            this.dtgBuscarDonante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBuscarDonante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBuscarDonante.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dtgBuscarDonante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarDonante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column10,
            this.Column11});
            this.dtgBuscarDonante.Location = new System.Drawing.Point(12, 137);
            this.dtgBuscarDonante.Name = "dtgBuscarDonante";
            this.dtgBuscarDonante.ReadOnly = true;
            this.dtgBuscarDonante.Size = new System.Drawing.Size(836, 248);
            this.dtgBuscarDonante.TabIndex = 2;
            this.dtgBuscarDonante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBuscarDonante_CellContentClick);
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
            // Column7
            // 
            this.Column7.HeaderText = "Departamento";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "DUI";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edad";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Sexo";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grupo Sanguineo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Fecha Donacion";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Estatus";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // btnEliminarBDonante
            // 
            this.btnEliminarBDonante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarBDonante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEliminarBDonante.FlatAppearance.BorderSize = 2;
            this.btnEliminarBDonante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBDonante.Location = new System.Drawing.Point(278, 428);
            this.btnEliminarBDonante.Name = "btnEliminarBDonante";
            this.btnEliminarBDonante.Size = new System.Drawing.Size(89, 39);
            this.btnEliminarBDonante.TabIndex = 3;
            this.btnEliminarBDonante.Text = "ELIMINAR";
            this.btnEliminarBDonante.UseVisualStyleBackColor = false;
            this.btnEliminarBDonante.Click += new System.EventHandler(this.btnEliminarBDonante_Click);
            // 
            // btnSalirBDonante
            // 
            this.btnSalirBDonante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirBDonante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalirBDonante.FlatAppearance.BorderSize = 2;
            this.btnSalirBDonante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirBDonante.Location = new System.Drawing.Point(759, 446);
            this.btnSalirBDonante.Name = "btnSalirBDonante";
            this.btnSalirBDonante.Size = new System.Drawing.Size(89, 39);
            this.btnSalirBDonante.TabIndex = 4;
            this.btnSalirBDonante.Text = "SALIR";
            this.btnSalirBDonante.UseVisualStyleBackColor = false;
            this.btnSalirBDonante.Click += new System.EventHandler(this.btnSalirBDonante_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(312, 83);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 20);
            this.txtId.TabIndex = 6;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(435, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBuscarDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.azul_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSalirBDonante);
            this.Controls.Add(this.btnEliminarBDonante);
            this.Controls.Add(this.dtgBuscarDonante);
            this.Controls.Add(this.txtDonanteaBuscar);
            this.Controls.Add(this.lblIngreseDonante);
            this.Name = "FrmBuscarDonante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Donante";
            this.Load += new System.EventHandler(this.FrmBuscarDonante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarDonante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseDonante;
        private System.Windows.Forms.TextBox txtDonanteaBuscar;
        private System.Windows.Forms.DataGridView dtgBuscarDonante;
        private System.Windows.Forms.Button btnEliminarBDonante;
        private System.Windows.Forms.Button btnSalirBDonante;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}