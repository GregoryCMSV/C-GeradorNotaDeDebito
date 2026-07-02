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
            lbl_Config = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(335, 513);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 38);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(452, 513);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 38);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(138, 479);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(199, 23);
            txtValor.TabIndex = 8;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 56);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 29;
            label2.Text = "Emitente";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
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
            panel2.Location = new Point(3, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 184);
            panel2.TabIndex = 1;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Font = new Font("Segoe UI", 12F);
            lblRazaoSocial.Location = new Point(20, 60);
            lblRazaoSocial.Margin = new Padding(4, 0, 4, 0);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(100, 21);
            lblRazaoSocial.TabIndex = 3;
            lblRazaoSocial.Text = "Razão Social:";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRazaoSocial.Location = new Point(133, 57);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(305, 23);
            txtRazaoSocial.TabIndex = 1;
            // 
            // txtEnd
            // 
            txtEnd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEnd.Location = new Point(133, 86);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(305, 23);
            txtEnd.TabIndex = 2;
            // 
            // mtxtTel
            // 
            mtxtTel.HidePromptOnLeave = true;
            mtxtTel.Location = new Point(134, 144);
            mtxtTel.Mask = "(00) 90000-0000";
            mtxtTel.Name = "mtxtTel";
            mtxtTel.Size = new Size(130, 23);
            mtxtTel.TabIndex = 4;
            mtxtTel.Enter += mtxtTel_Enter;
            mtxtTel.Leave += mtxtTel_Leave;
            // 
            // mtxtCEP
            // 
            mtxtCEP.HidePromptOnLeave = true;
            mtxtCEP.Location = new Point(133, 115);
            mtxtCEP.Mask = "00000-000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(130, 23);
            mtxtCEP.TabIndex = 3;
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Font = new Font("Segoe UI", 12F);
            lblCNPJ.Location = new Point(71, 8);
            lblCNPJ.Margin = new Padding(4, 0, 4, 0);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(49, 21);
            lblCNPJ.TabIndex = 4;
            lblCNPJ.Text = "CNPJ:";
            // 
            // mtxtCNPJ
            // 
            mtxtCNPJ.HidePromptOnLeave = true;
            mtxtCNPJ.Location = new Point(133, 10);
            mtxtCNPJ.Mask = "AA\\.AAA\\.AAA/AAAA-00";
            mtxtCNPJ.Name = "mtxtCNPJ";
            mtxtCNPJ.Size = new Size(225, 23);
            mtxtCNPJ.TabIndex = 0;
            mtxtCNPJ.Leave += mtxtCNPJ_Leave;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 12F);
            lblEnd.Location = new Point(43, 84);
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
            lblCEP.Location = new Point(81, 113);
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
            lblTelefone.Location = new Point(50, 142);
            lblTelefone.Margin = new Padding(4, 0, 4, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(70, 21);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone:";
            // 
            // lblDest
            // 
            lblDest.AutoSize = true;
            lblDest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDest.Location = new Point(13, 283);
            lblDest.Margin = new Padding(4, 0, 4, 0);
            lblDest.Name = "lblDest";
            lblDest.Size = new Size(104, 21);
            lblDest.TabIndex = 27;
            lblDest.Text = "Destinatário";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtEndDestinatario);
            panel1.Controls.Add(txtRazaoDestinatario);
            panel1.Controls.Add(mtxtCNPJDestinatario);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(4, 308);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 148);
            panel1.TabIndex = 6;
            // 
            // txtEndDestinatario
            // 
            txtEndDestinatario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEndDestinatario.Location = new Point(133, 99);
            txtEndDestinatario.Name = "txtEndDestinatario";
            txtEndDestinatario.Size = new Size(305, 23);
            txtEndDestinatario.TabIndex = 7;
            // 
            // txtRazaoDestinatario
            // 
            txtRazaoDestinatario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRazaoDestinatario.Location = new Point(133, 70);
            txtRazaoDestinatario.Name = "txtRazaoDestinatario";
            txtRazaoDestinatario.Size = new Size(305, 23);
            txtRazaoDestinatario.TabIndex = 6;
            // 
            // mtxtCNPJDestinatario
            // 
            mtxtCNPJDestinatario.HidePromptOnLeave = true;
            mtxtCNPJDestinatario.Location = new Point(133, 23);
            mtxtCNPJDestinatario.Mask = "AA\\.AAA\\.AAA/AAAA-00";
            mtxtCNPJDestinatario.Name = "mtxtCNPJDestinatario";
            mtxtCNPJDestinatario.Size = new Size(225, 23);
            mtxtCNPJDestinatario.TabIndex = 5;
            mtxtCNPJDestinatario.Leave += mtxtCNPJDestinatario_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(43, 97);
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
            label9.Location = new Point(70, 21);
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
            label8.Location = new Point(20, 73);
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
            label5.Location = new Point(23, 481);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 28;
            label5.Text = "Valor Padrão:";
            // 
            // lbl_Config
            // 
            lbl_Config.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Config.AutoSize = true;
            lbl_Config.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Config.Location = new Point(13, 19);
            lbl_Config.Name = "lbl_Config";
            lbl_Config.Size = new Size(257, 25);
            lbl_Config.TabIndex = 33;
            lbl_Config.Text = "Configurar Valores Padrões";
            lbl_Config.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_Config);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(lblDest);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "UserConfig";
            Size = new Size(571, 570);
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
        private Label lbl_Config;
    }
}
