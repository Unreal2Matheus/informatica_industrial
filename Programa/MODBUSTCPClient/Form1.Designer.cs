namespace MODBUSTCPClient
{
    partial class Form1
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
            this.bt_connect = new System.Windows.Forms.Button();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_porta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_endi = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.bt_bobinas = new System.Windows.Forms.Button();
            this.bt_regEntrada = new System.Windows.Forms.Button();
            this.bt_regHold = new System.Windows.Forms.Button();
            this.bt_enDiscretas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dados = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(225, 49);
            this.bt_connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(136, 71);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "Conectar";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(66, 49);
            this.tb_ip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(148, 26);
            this.tb_ip.TabIndex = 1;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // tb_porta
            // 
            this.tb_porta.Location = new System.Drawing.Point(66, 89);
            this.tb_porta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.Size = new System.Drawing.Size(56, 26);
            this.tb_porta.TabIndex = 2;
            this.tb_porta.Text = "502";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Porta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "End. inicial";
            // 
            // tb_endi
            // 
            this.tb_endi.Location = new System.Drawing.Point(114, 155);
            this.tb_endi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_endi.Name = "tb_endi";
            this.tb_endi.Size = new System.Drawing.Size(56, 26);
            this.tb_endi.TabIndex = 6;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(284, 155);
            this.tb_quantidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(56, 26);
            this.tb_quantidade.TabIndex = 5;
            // 
            // bt_bobinas
            // 
            this.bt_bobinas.Enabled = false;
            this.bt_bobinas.Location = new System.Drawing.Point(8, 37);
            this.bt_bobinas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_bobinas.Name = "bt_bobinas";
            this.bt_bobinas.Size = new System.Drawing.Size(160, 38);
            this.bt_bobinas.TabIndex = 9;
            this.bt_bobinas.Text = "Bobinas";
            this.bt_bobinas.UseVisualStyleBackColor = true;
            this.bt_bobinas.Click += new System.EventHandler(this.bt_bobinas_Click);
            // 
            // bt_regEntrada
            // 
            this.bt_regEntrada.Enabled = false;
            this.bt_regEntrada.Location = new System.Drawing.Point(8, 85);
            this.bt_regEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_regEntrada.Name = "bt_regEntrada";
            this.bt_regEntrada.Size = new System.Drawing.Size(160, 38);
            this.bt_regEntrada.TabIndex = 10;
            this.bt_regEntrada.Text = "Reg. Entrada";
            this.bt_regEntrada.UseVisualStyleBackColor = true;
            this.bt_regEntrada.Click += new System.EventHandler(this.bt_regEntrada_Click);
            // 
            // bt_regHold
            // 
            this.bt_regHold.Enabled = false;
            this.bt_regHold.Location = new System.Drawing.Point(177, 85);
            this.bt_regHold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_regHold.Name = "bt_regHold";
            this.bt_regHold.Size = new System.Drawing.Size(160, 38);
            this.bt_regHold.TabIndex = 11;
            this.bt_regHold.Text = "Reg. Holding";
            this.bt_regHold.UseVisualStyleBackColor = true;
            this.bt_regHold.Click += new System.EventHandler(this.bt_regHold_Click);
            // 
            // bt_enDiscretas
            // 
            this.bt_enDiscretas.Enabled = false;
            this.bt_enDiscretas.Location = new System.Drawing.Point(177, 37);
            this.bt_enDiscretas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_enDiscretas.Name = "bt_enDiscretas";
            this.bt_enDiscretas.Size = new System.Drawing.Size(160, 38);
            this.bt_enDiscretas.TabIndex = 12;
            this.bt_enDiscretas.Text = "Entradas Discretas";
            this.bt_enDiscretas.UseVisualStyleBackColor = true;
            this.bt_enDiscretas.Click += new System.EventHandler(this.bt_enDiscretas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bt_bobinas);
            this.panel1.Controls.Add(this.bt_enDiscretas);
            this.panel1.Controls.Add(this.bt_regEntrada);
            this.panel1.Controls.Add(this.bt_regHold);
            this.panel1.Location = new System.Drawing.Point(9, 215);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 128);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Funções de leitura";
            // 
            // tb_dados
            // 
            this.tb_dados.Location = new System.Drawing.Point(9, 352);
            this.tb_dados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_dados.Multiline = true;
            this.tb_dados.Name = "tb_dados";
            this.tb_dados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_dados.Size = new System.Drawing.Size(378, 235);
            this.tb_dados.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 592);
            this.Controls.Add(this.tb_dados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_endi);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_porta);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.bt_connect);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "MODBUS TCP CLIENT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.TextBox tb_porta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_endi;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.Button bt_bobinas;
        private System.Windows.Forms.Button bt_regEntrada;
        private System.Windows.Forms.Button bt_regHold;
        private System.Windows.Forms.Button bt_enDiscretas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dados;
    }
}

