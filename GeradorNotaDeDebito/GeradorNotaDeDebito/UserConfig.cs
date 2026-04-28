using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorNotaDeDebito.Modelos
{
    public partial class UserConfig : UserControl
    {
        public UserConfig()
        {
            InitializeComponent();
            GetValues();
        }

        private void GetValues()
        {
            txtRazaoSocial.Text = Config.Default.RAZAO_SOCIAL;
            mtxtCNPJ.Text = Config.Default.CNPJ;
            txtEnd.Text = Config.Default.END;
            mtxtCEP.Text = Config.Default.CEP;
            mtxtTel.Text = Config.Default.TEL;
            txtValor.Text = Config.Default.VALOR;
            txtRazaoDestinatario.Text = BusinessConfig.Default.EMPRESA;
            txtEndDestinatario.Text = BusinessConfig.Default.EMPRESA_END;
            mtxtCNPJDestinatario.Text = BusinessConfig.Default.EMPRESA_CNPJ;

            ChangeBTNCancelarEnabled();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            Config.Default.RAZAO_SOCIAL = txtRazaoSocial.Text;
            Config.Default.CNPJ = mtxtCNPJ.Text;
            Config.Default.END = txtEnd.Text;
            Config.Default.CEP = mtxtCEP.Text;
            Config.Default.TEL = mtxtTel.Text;
            Config.Default.VALOR = txtValor.Text.Replace("R$","").Trim();

            Config.Default.Save();

            BusinessConfig.Default.EMPRESA = txtRazaoDestinatario.Text;
            BusinessConfig.Default.EMPRESA_END = txtEndDestinatario.Text;
            BusinessConfig.Default.EMPRESA_CNPJ = mtxtCNPJDestinatario.Text;
            BusinessConfig.Default.Save();

            MessageBox.Show("Configurações salvas com sucesso!");

            this.Visible = false;
        }

        private bool ValidateFields()
        {
            if(ShowAlertIfNull(txtRazaoSocial.Text, "A Razão Social do emitente é obrigatória.")) return false;
            if(ShowAlertIfNull(txtEnd.Text, "O Endereço do emitente é obrigatório.")) return false ;
            string cepNumeros = new string(mtxtCEP.Text.Where(char.IsDigit).ToArray());
            if (cepNumeros.Length != 8)
            {
                MessageBox.Show("O CEP deve conter 8 dígitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string telNumeros = new string(mtxtTel.Text.Where(char.IsDigit).ToArray());
            if (telNumeros.Length < 10)
            {
                MessageBox.Show("O Telefone deve conter no mínimo 10 dígitos (incluindo DDD).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if(ShowAlertIfCNPJNotValid(mtxtCNPJ.Text, "O CNPJ do emitente é inválido.")) return false;
            if(ShowAlertIfNull(txtRazaoDestinatario.Text, "A Razão Social do destinatário é obrigatória.")) return false;
            if(ShowAlertIfNull(txtEndDestinatario.Text, "O Endereço do destinatário obrigatório.")) return false;
            if(ShowAlertIfCNPJNotValid(mtxtCNPJDestinatario.Text, "O CNPJ do destinatário é inválido.")) return false;
            if(ShowAlertIfNull(txtValor.Text, "O Valor é obrigatório.")) return false;
            
            return true;
        }

        private bool ShowAlertIfNull(string text, string message)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private bool ShowAlertIfCNPJNotValid(string cnpj, string message)
        {
            if (!ValidarCNPJ(cnpj))
            {
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private bool ValidarCNPJ(string cnpj)
        {
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            bool todosIguais = true;
            for (int i = 1; i < cnpj.Length; i++)
            {
                if (cnpj[i] != cnpj[0])
                {
                    todosIguais = false;
                    break;
                }
            }
            if (todosIguais) return false;

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();

            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GetValues();
            this.Visible = false;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.TextChanged -= txtValor_TextChanged;
            string valorDigitado = new string(txtValor.Text.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(valorDigitado))
            {
                if (decimal.TryParse(valorDigitado, out decimal numero))
                {
                    numero = numero / 100;
                    txtValor.Text = numero.ToString("C");
                    txtValor.SelectionStart = txtValor.Text.Length;
                }
            }
            else
            {
                txtValor.Text = "";
            }

            txtValor.TextChanged += txtValor_TextChanged;
        }

        public void ChangeBTNCancelarEnabled()
        {
            btnCancelar.Enabled = !string.IsNullOrEmpty(txtRazaoSocial.Text);
        }
    }
}




