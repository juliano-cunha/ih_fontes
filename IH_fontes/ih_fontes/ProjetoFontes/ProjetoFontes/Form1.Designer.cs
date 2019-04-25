namespace ProjetoFontes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_conectar = new System.Windows.Forms.Button();
            this.cbbox_conectar = new System.Windows.Forms.ComboBox();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.txbox_enviar = new System.Windows.Forms.TextBox();
            this.txbox_receber = new System.Windows.Forms.TextBox();
            this.timer_com = new System.Windows.Forms.Timer(this.components);
            this.serialport_01 = new System.IO.Ports.SerialPort(this.components);
            this.btn_pdf = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_conectar
            // 
            this.bt_conectar.Location = new System.Drawing.Point(218, 14);
            this.bt_conectar.Name = "bt_conectar";
            this.bt_conectar.Size = new System.Drawing.Size(75, 23);
            this.bt_conectar.TabIndex = 0;
            this.bt_conectar.Text = "Conectar";
            this.bt_conectar.UseVisualStyleBackColor = true;
            this.bt_conectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbox_conectar
            // 
            this.cbbox_conectar.FormattingEnabled = true;
            this.cbbox_conectar.Location = new System.Drawing.Point(91, 16);
            this.cbbox_conectar.Name = "cbbox_conectar";
            this.cbbox_conectar.Size = new System.Drawing.Size(121, 21);
            this.cbbox_conectar.TabIndex = 1;
            this.cbbox_conectar.SelectedIndexChanged += new System.EventHandler(this.cbbox_conectar_SelectedIndexChanged);
            // 
            // bt_enviar
            // 
            this.bt_enviar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_enviar.Location = new System.Drawing.Point(310, 61);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(103, 54);
            this.bt_enviar.TabIndex = 2;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // txbox_enviar
            // 
            this.txbox_enviar.Location = new System.Drawing.Point(30, 61);
            this.txbox_enviar.Multiline = true;
            this.txbox_enviar.Name = "txbox_enviar";
            this.txbox_enviar.Size = new System.Drawing.Size(274, 54);
            this.txbox_enviar.TabIndex = 3;
            // 
            // txbox_receber
            // 
            this.txbox_receber.Location = new System.Drawing.Point(12, 212);
            this.txbox_receber.Multiline = true;
            this.txbox_receber.Name = "txbox_receber";
            this.txbox_receber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbox_receber.Size = new System.Drawing.Size(431, 554);
            this.txbox_receber.TabIndex = 4;
            // 
            // timer_com
            // 
            this.timer_com.Interval = 1000;
            this.timer_com.Tick += new System.EventHandler(this.timer_com_Tick);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Location = new System.Drawing.Point(73, 173);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(296, 33);
            this.btn_pdf.TabIndex = 5;
            this.btn_pdf.Text = "Gerar Relatório";
            this.btn_pdf.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insira o código de barras para realizar o teste";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_limpa
            // 
            this.btn_limpa.Location = new System.Drawing.Point(294, 14);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(75, 23);
            this.btn_limpa.TabIndex = 8;
            this.btn_limpa.Text = "Limpa";
            this.btn_limpa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 778);
            this.Controls.Add(this.btn_limpa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.txbox_receber);
            this.Controls.Add(this.txbox_enviar);
            this.Controls.Add(this.bt_enviar);
            this.Controls.Add(this.cbbox_conectar);
            this.Controls.Add(this.bt_conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_conectar;
        private System.Windows.Forms.ComboBox cbbox_conectar;
        private System.Windows.Forms.Button bt_enviar;
        private System.Windows.Forms.TextBox txbox_enviar;
        private System.Windows.Forms.TextBox txbox_receber;
        private System.Windows.Forms.Timer timer_com;
        private System.IO.Ports.SerialPort serialport_01;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpa;
    }
}

