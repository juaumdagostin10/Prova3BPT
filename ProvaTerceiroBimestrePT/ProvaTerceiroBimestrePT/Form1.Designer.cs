namespace ProvaTerceiroBimestrePT
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tBNomeIncluir = new System.Windows.Forms.TextBox();
            this.tBApelidoIncluir = new System.Windows.Forms.TextBox();
            this.tBTimeIncluir = new System.Windows.Forms.TextBox();
            this.dateIncluir = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateAlterar = new System.Windows.Forms.DateTimePicker();
            this.tBTimeAlterar = new System.Windows.Forms.TextBox();
            this.tBApelidoALterar = new System.Windows.Forms.TextBox();
            this.tbNomeAlterar = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBProcurarName = new System.Windows.Forms.TextBox();
            this.btnProcurarID = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tBNotaTimeAlterar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNotaTimeIncluir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 446);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tbNotaTimeIncluir);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnIncluir);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateIncluir);
            this.tabPage1.Controls.Add(this.tBTimeIncluir);
            this.tabPage1.Controls.Add(this.tBApelidoIncluir);
            this.tabPage1.Controls.Add(this.tBNomeIncluir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tBNotaTimeAlterar);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.textBProcurarName);
            this.tabPage2.Controls.Add(this.btnProcurarID);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dateAlterar);
            this.tabPage2.Controls.Add(this.tBTimeAlterar);
            this.tabPage2.Controls.Add(this.tBApelidoALterar);
            this.tabPage2.Controls.Add(this.tbNomeAlterar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar & Excluir";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tBNomeIncluir
            // 
            this.tBNomeIncluir.Location = new System.Drawing.Point(272, 84);
            this.tBNomeIncluir.Name = "tBNomeIncluir";
            this.tBNomeIncluir.Size = new System.Drawing.Size(251, 20);
            this.tBNomeIncluir.TabIndex = 0;
            // 
            // tBApelidoIncluir
            // 
            this.tBApelidoIncluir.Location = new System.Drawing.Point(272, 121);
            this.tBApelidoIncluir.Name = "tBApelidoIncluir";
            this.tBApelidoIncluir.Size = new System.Drawing.Size(251, 20);
            this.tBApelidoIncluir.TabIndex = 1;
            // 
            // tBTimeIncluir
            // 
            this.tBTimeIncluir.Location = new System.Drawing.Point(272, 158);
            this.tBTimeIncluir.Name = "tBTimeIncluir";
            this.tBTimeIncluir.Size = new System.Drawing.Size(251, 20);
            this.tBTimeIncluir.TabIndex = 2;
            // 
            // dateIncluir
            // 
            this.dateIncluir.Location = new System.Drawing.Point(272, 233);
            this.dateIncluir.Name = "dateIncluir";
            this.dateIncluir.Size = new System.Drawing.Size(251, 20);
            this.dateIncluir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apelido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time do Coração";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(335, 298);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(116, 31);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data de nascimento";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(199, 325);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(116, 31);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Time do Coração";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Apelido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nome";
            // 
            // dateAlterar
            // 
            this.dateAlterar.Location = new System.Drawing.Point(136, 267);
            this.dateAlterar.Name = "dateAlterar";
            this.dateAlterar.Size = new System.Drawing.Size(251, 20);
            this.dateAlterar.TabIndex = 13;
            // 
            // tBTimeAlterar
            // 
            this.tBTimeAlterar.Location = new System.Drawing.Point(136, 186);
            this.tBTimeAlterar.Name = "tBTimeAlterar";
            this.tBTimeAlterar.Size = new System.Drawing.Size(251, 20);
            this.tBTimeAlterar.TabIndex = 12;
            // 
            // tBApelidoALterar
            // 
            this.tBApelidoALterar.Location = new System.Drawing.Point(136, 149);
            this.tBApelidoALterar.Name = "tBApelidoALterar";
            this.tBApelidoALterar.Size = new System.Drawing.Size(251, 20);
            this.tBApelidoALterar.TabIndex = 11;
            // 
            // tbNomeAlterar
            // 
            this.tbNomeAlterar.Location = new System.Drawing.Point(136, 112);
            this.tbNomeAlterar.Name = "tbNomeAlterar";
            this.tbNomeAlterar.Size = new System.Drawing.Size(251, 20);
            this.tbNomeAlterar.TabIndex = 10;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(547, 357);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(431, 109);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 242);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // textBProcurarName
            // 
            this.textBProcurarName.Location = new System.Drawing.Point(514, 54);
            this.textBProcurarName.Name = "textBProcurarName";
            this.textBProcurarName.Size = new System.Drawing.Size(137, 20);
            this.textBProcurarName.TabIndex = 23;
            // 
            // btnProcurarID
            // 
            this.btnProcurarID.Location = new System.Drawing.Point(514, 80);
            this.btnProcurarID.Name = "btnProcurarID";
            this.btnProcurarID.Size = new System.Drawing.Size(137, 23);
            this.btnProcurarID.TabIndex = 22;
            this.btnProcurarID.Text = "Procurar";
            this.btnProcurarID.UseVisualStyleBackColor = true;
            this.btnProcurarID.Click += new System.EventHandler(this.btnProcurarID_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Nota do time de 0 á 10";
            // 
            // tBNotaTimeAlterar
            // 
            this.tBNotaTimeAlterar.Location = new System.Drawing.Point(136, 224);
            this.tBNotaTimeAlterar.Name = "tBNotaTimeAlterar";
            this.tBNotaTimeAlterar.Size = new System.Drawing.Size(251, 20);
            this.tBNotaTimeAlterar.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Nota do time de 0 á 10";
            // 
            // tbNotaTimeIncluir
            // 
            this.tbNotaTimeIncluir.Location = new System.Drawing.Point(272, 197);
            this.tbNotaTimeIncluir.Name = "tbNotaTimeIncluir";
            this.tbNotaTimeIncluir.Size = new System.Drawing.Size(251, 20);
            this.tbNotaTimeIncluir.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "CADASTRO DE TORCEDORES";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(470, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "PROCURAR ID PARA ALTERAR TORCEDOR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(164, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "ADICIONAR NOVAS INFORMAÇÕES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateIncluir;
        private System.Windows.Forms.TextBox tBTimeIncluir;
        private System.Windows.Forms.TextBox tBApelidoIncluir;
        private System.Windows.Forms.TextBox tBNomeIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBProcurarName;
        private System.Windows.Forms.Button btnProcurarID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateAlterar;
        private System.Windows.Forms.TextBox tBTimeAlterar;
        private System.Windows.Forms.TextBox tBApelidoALterar;
        private System.Windows.Forms.TextBox tbNomeAlterar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBNotaTimeAlterar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNotaTimeIncluir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

