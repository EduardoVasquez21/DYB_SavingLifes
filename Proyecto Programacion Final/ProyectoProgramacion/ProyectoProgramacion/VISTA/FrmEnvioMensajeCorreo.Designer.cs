
namespace ProyectoProgramacion.VISTA
{
    partial class FrmEnvioMensajeCorreo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAjuntarArchivo = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtgEnviarCorreo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnatras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEnviarCorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asunto:";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(114, 176);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(233, 20);
            this.txtPara.TabIndex = 3;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(57, 305);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(623, 74);
            this.txtMensaje.TabIndex = 5;
            this.txtMensaje.Text = "\"Tu donación sanguínea ha sido realizada exitosamente y ha salvado una vida. ¡Gra" +
    "cias por convertirte en un heroe!";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(114, 259);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(543, 20);
            this.txtAsunto.TabIndex = 6;
            this.txtAsunto.Text = "DYB Saving Lifes";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(647, 417);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(110, 33);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adjuntar Archivo:";
            // 
            // txtAjuntarArchivo
            // 
            this.txtAjuntarArchivo.Location = new System.Drawing.Point(114, 218);
            this.txtAjuntarArchivo.Name = "txtAjuntarArchivo";
            this.txtAjuntarArchivo.Size = new System.Drawing.Size(437, 20);
            this.txtAjuntarArchivo.TabIndex = 9;
            this.txtAjuntarArchivo.Text = "C:\\Users\\Vkaiido\\Desktop\\DonarSangre.png";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(568, 215);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(78, 25);
            this.btnExaminar.TabIndex = 10;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtgEnviarCorreo
            // 
            this.dtgEnviarCorreo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEnviarCorreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEnviarCorreo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgEnviarCorreo.Location = new System.Drawing.Point(215, 34);
            this.dtgEnviarCorreo.Name = "dtgEnviarCorreo";
            this.dtgEnviarCorreo.Size = new System.Drawing.Size(421, 124);
            this.dtgEnviarCorreo.TabIndex = 11;
            this.dtgEnviarCorreo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEnviarCorreo_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre Donante";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Correo Electronico";
            this.Column2.Name = "Column2";
            // 
            // btnatras
            // 
            this.btnatras.BackColor = System.Drawing.Color.Firebrick;
            this.btnatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnatras.FlatAppearance.BorderSize = 2;
            this.btnatras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnatras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnatras.Location = new System.Drawing.Point(36, 417);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(81, 33);
            this.btnatras.TabIndex = 12;
            this.btnatras.Text = "Regresar";
            this.btnatras.UseVisualStyleBackColor = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // FrmEnvioMensajeCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(836, 474);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.dtgEnviarCorreo);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtAjuntarArchivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmEnvioMensajeCorreo";
            this.Text = "FrmEnvioMensajeCorreo";
            this.Load += new System.EventHandler(this.FrmEnvioMensajeCorreo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEnviarCorreo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAjuntarArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dtgEnviarCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnatras;
    }
}