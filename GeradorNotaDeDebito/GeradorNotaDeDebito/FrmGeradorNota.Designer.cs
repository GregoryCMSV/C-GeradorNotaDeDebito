namespace GeradorNotaDeDebito
{
    partial class FrmGeradorNota
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPDF = new Button();
            btnWord = new Button();
            lblGerar = new Label();
            lblRazaoSocial = new Label();
            lblCNPJ = new Label();
            lblEnd = new Label();
            label5 = new Label();
            lblCEP = new Label();
            lblTelefone = new Label();
            panel1 = new Panel();
            txtEndDestinatario = new TextBox();
            txtRazaoDestinatario = new TextBox();
            mtxtCNPJDestinatario = new MaskedTextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            lblDest = new Label();
            mtxtTel = new MaskedTextBox();
            mtxtCEP = new MaskedTextBox();
            dtpMes = new DateTimePicker();
            mtxtCNPJ = new MaskedTextBox();
            txtEnd = new TextBox();
            txtRazaoSocial = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            tsmiConfigurar = new ToolStripMenuItem();
            txtValor = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(743, 47);
            btnPDF.Margin = new Padding(4);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(96, 32);
            btnPDF.TabIndex = 0;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnWord
            // 
            btnWord.Location = new Point(847, 47);
            btnWord.Margin = new Padding(4);
            btnWord.Name = "btnWord";
            btnWord.Size = new Size(96, 32);
            btnWord.TabIndex = 1;
            btnWord.Text = "Word";
            btnWord.UseVisualStyleBackColor = true;
            btnWord.Click += btnWord_Click;
            // 
            // lblGerar
            // 
            lblGerar.AutoSize = true;
            lblGerar.Font = new Font("Segoe UI", 12F);
            lblGerar.Location = new Point(683, 53);
            lblGerar.Margin = new Padding(4, 0, 4, 0);
            lblGerar.Name = "lblGerar";
            lblGerar.Size = new Size(52, 21);
            lblGerar.TabIndex = 2;
            lblGerar.Text = "Gerar:";
            lblGerar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Font = new Font("Segoe UI", 12F);
            lblRazaoSocial.Location = new Point(20, 13);
            lblRazaoSocial.Margin = new Padding(4, 0, 4, 0);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(100, 21);
            lblRazaoSocial.TabIndex = 3;
            lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Font = new Font("Segoe UI", 12F);
            lblCNPJ.Location = new Point(71, 63);
            lblCNPJ.Margin = new Padding(4, 0, 4, 0);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(49, 21);
            lblCNPJ.TabIndex = 4;
            lblCNPJ.Text = "CNPJ:";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 12F);
            lblEnd.Location = new Point(43, 113);
            lblEnd.Margin = new Padding(4, 0, 4, 0);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(77, 21);
            lblEnd.TabIndex = 5;
            lblEnd.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(32, 77);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 6;
            label5.Text = "Valor:";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 12F);
            lblCEP.Location = new Point(81, 163);
            lblCEP.Margin = new Padding(4, 0, 4, 0);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(40, 21);
            lblCEP.TabIndex = 7;
            lblCEP.Text = "CEP:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F);
            lblTelefone.Location = new Point(50, 213);
            lblTelefone.Margin = new Padding(4, 0, 4, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(70, 21);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtEndDestinatario);
            panel1.Controls.Add(txtRazaoDestinatario);
            panel1.Controls.Add(mtxtCNPJDestinatario);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(12, 441);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 196);
            panel1.TabIndex = 9;
            // 
            // txtEndDestinatario
            // 
            txtEndDestinatario.Location = new Point(133, 143);
            txtEndDestinatario.Name = "txtEndDestinatario";
            txtEndDestinatario.Size = new Size(305, 29);
            txtEndDestinatario.TabIndex = 6;
            // 
            // txtRazaoDestinatario
            // 
            txtRazaoDestinatario.Location = new Point(133, 23);
            txtRazaoDestinatario.Name = "txtRazaoDestinatario";
            txtRazaoDestinatario.Size = new Size(305, 29);
            txtRazaoDestinatario.TabIndex = 5;
            // 
            // mtxtCNPJDestinatario
            // 
            mtxtCNPJDestinatario.Location = new Point(133, 83);
            mtxtCNPJDestinatario.Mask = "00.000.000/0000-00";
            mtxtCNPJDestinatario.Name = "mtxtCNPJDestinatario";
            mtxtCNPJDestinatario.Size = new Size(305, 29);
            mtxtCNPJDestinatario.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(43, 146);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(77, 21);
            label10.TabIndex = 2;
            label10.Text = "Endereço:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(71, 86);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 21);
            label9.TabIndex = 1;
            label9.Text = "CNPJ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(20, 26);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 21);
            label8.TabIndex = 0;
            label8.Text = "Razão Social:";
            // 
            // lblDest
            // 
            lblDest.AutoSize = true;
            lblDest.Font = new Font("Segoe UI", 12F);
            lblDest.Location = new Point(21, 416);
            lblDest.Margin = new Padding(4, 0, 4, 0);
            lblDest.Name = "lblDest";
            lblDest.Size = new Size(94, 21);
            lblDest.TabIndex = 3;
            lblDest.Text = "Destinatário";
            // 
            // mtxtTel
            // 
            mtxtTel.Location = new Point(133, 210);
            mtxtTel.Mask = "(00) 90000-0000";
            mtxtTel.Name = "mtxtTel";
            mtxtTel.Size = new Size(156, 29);
            mtxtTel.TabIndex = 11;
            // 
            // mtxtCEP
            // 
            mtxtCEP.Location = new Point(133, 160);
            mtxtCEP.Mask = "00000-000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(156, 29);
            mtxtCEP.TabIndex = 12;
            // 
            // dtpMes
            // 
            dtpMes.CustomFormat = "MMMM/yyyy";
            dtpMes.Format = DateTimePickerFormat.Custom;
            dtpMes.Location = new Point(92, 28);
            dtpMes.Name = "dtpMes";
            dtpMes.Size = new Size(200, 29);
            dtpMes.TabIndex = 13;
            // 
            // mtxtCNPJ
            // 
            mtxtCNPJ.Location = new Point(133, 60);
            mtxtCNPJ.Mask = "00.000.000/0000-00";
            mtxtCNPJ.Name = "mtxtCNPJ";
            mtxtCNPJ.Size = new Size(305, 29);
            mtxtCNPJ.TabIndex = 14;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(133, 110);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(305, 29);
            txtEnd.TabIndex = 15;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(133, 10);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(305, 29);
            txtRazaoSocial.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(39, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 17;
            label1.Text = "Mês:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(lblRazaoSocial);
            panel2.Controls.Add(txtRazaoSocial);
            panel2.Controls.Add(txtEnd);
            panel2.Controls.Add(mtxtTel);
            panel2.Controls.Add(mtxtCEP);
            panel2.Controls.Add(lblCNPJ);
            panel2.Controls.Add(mtxtCNPJ);
            panel2.Controls.Add(lblEnd);
            panel2.Controls.Add(lblCEP);
            panel2.Controls.Add(lblTelefone);
            panel2.Location = new Point(12, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 250);
            panel2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(21, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 7;
            label2.Text = "Emitente";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiConfigurar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiConfigurar
            // 
            tsmiConfigurar.Name = "tsmiConfigurar";
            tsmiConfigurar.Size = new Size(76, 20);
            tsmiConfigurar.Text = "Configurar";
            tsmiConfigurar.Click += tsmiConfigurar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(93, 74);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(199, 29);
            txtValor.TabIndex = 20;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // FrmGeradorNota
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 653);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(lblDest);
            Controls.Add(dtpMes);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(lblGerar);
            Controls.Add(btnWord);
            Controls.Add(btnPDF);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FrmGeradorNota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerar Nota de Debito";
            Load += FrmGeradorNota_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPDF;
        private Button btnWord;
        private Label lblGerar;
        private Label lblRazaoSocial;
        private Label lblCNPJ;
        private Label lblEnd;
        private Label label5;
        private Label lblCEP;
        private Label lblTelefone;
        private Panel panel1;
        private Label lblDest;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtEndDestinatario;
        private TextBox txtRazaoDestinatario;
        private MaskedTextBox mtxtCNPJDestinatario;
        private MaskedTextBox mtxtTel;
        private MaskedTextBox mtxtCEP;
        private DateTimePicker dtpMes;
        private MaskedTextBox mtxtCNPJ;
        private TextBox txtEnd;
        private TextBox txtRazaoSocial;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiConfigurar;
        private TextBox txtValor;
    }
}
