namespace GeradorNotaDeDebito.Modelos
{
    partial class UserConfig
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtValor = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            lblRazaoSocial = new Label();
            txtRazaoSocial = new TextBox();
            txtEnd = new TextBox();
            mtxtTel = new MaskedTextBox();
            mtxtCEP = new MaskedTextBox();
            lblCNPJ = new Label();
            mtxtCNPJ = new MaskedTextBox();
            lblEnd = new Label();
            lblCEP = new Label();
            lblTelefone = new Label();
            lblDest = new Label();
            panel1 = new Panel();
            txtEndDestinatario = new TextBox();
            txtRazaoDestinatario = new TextBox();
            mtxtCNPJDestinatario = new MaskedTextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(335, 589);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 38);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(452, 589);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 38);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(70, 536);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(199, 23);
            txtValor.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 29;
            label2.Text = "Emitente";
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
            panel2.Location = new Point(-1, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 250);
            panel2.TabIndex = 31;
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
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(133, 10);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(305, 23);
            txtRazaoSocial.TabIndex = 16;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(133, 110);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(305, 23);
            txtEnd.TabIndex = 15;
            // 
            // mtxtTel
            // 
            mtxtTel.Location = new Point(133, 210);
            mtxtTel.Mask = "(00) 90000-0000";
            mtxtTel.Name = "mtxtTel";
            mtxtTel.Size = new Size(156, 23);
            mtxtTel.TabIndex = 11;
            // 
            // mtxtCEP
            // 
            mtxtCEP.Location = new Point(133, 160);
            mtxtCEP.Mask = "00000-000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(156, 23);
            mtxtCEP.TabIndex = 12;
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
            // mtxtCNPJ
            // 
            mtxtCNPJ.Location = new Point(133, 60);
            mtxtCNPJ.Mask = "00.000.000/0000-00";
            mtxtCNPJ.Name = "mtxtCNPJ";
            mtxtCNPJ.Size = new Size(305, 23);
            mtxtCNPJ.TabIndex = 14;
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
            // lblDest
            // 
            lblDest.AutoSize = true;
            lblDest.Font = new Font("Segoe UI", 12F);
            lblDest.Location = new Point(8, 298);
            lblDest.Margin = new Padding(4, 0, 4, 0);
            lblDest.Name = "lblDest";
            lblDest.Size = new Size(94, 21);
            lblDest.TabIndex = 27;
            lblDest.Text = "Destinatário";
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
            panel1.Location = new Point(-1, 323);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 196);
            panel1.TabIndex = 30;
            // 
            // txtEndDestinatario
            // 
            txtEndDestinatario.Location = new Point(133, 143);
            txtEndDestinatario.Name = "txtEndDestinatario";
            txtEndDestinatario.Size = new Size(305, 23);
            txtEndDestinatario.TabIndex = 6;
            // 
            // txtRazaoDestinatario
            // 
            txtRazaoDestinatario.Location = new Point(133, 23);
            txtRazaoDestinatario.Name = "txtRazaoDestinatario";
            txtRazaoDestinatario.Size = new Size(305, 23);
            txtRazaoDestinatario.TabIndex = 5;
            // 
            // mtxtCNPJDestinatario
            // 
            mtxtCNPJDestinatario.Location = new Point(133, 83);
            mtxtCNPJDestinatario.Mask = "00.000.000/0000-00";
            mtxtCNPJDestinatario.Name = "mtxtCNPJDestinatario";
            mtxtCNPJDestinatario.Size = new Size(305, 23);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(9, 539);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 28;
            label5.Text = "Valor:";
            // 
            // UserConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(lblDest);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "UserConfig";
            Size = new Size(571, 646);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtValor;
        private Label label2;
        private Panel panel2;
        private Label lblRazaoSocial;
        private TextBox txtRazaoSocial;
        private TextBox txtEnd;
        private MaskedTextBox mtxtTel;
        private MaskedTextBox mtxtCEP;
        private Label lblCNPJ;
        private MaskedTextBox mtxtCNPJ;
        private Label lblEnd;
        private Label lblCEP;
        private Label lblTelefone;
        private Label lblDest;
        private Panel panel1;
        private TextBox txtEndDestinatario;
        private TextBox txtRazaoDestinatario;
        private MaskedTextBox mtxtCNPJDestinatario;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label5;
    }
}
