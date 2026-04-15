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
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(!ValidateFields()) return;

            Config.Default.RAZAO_SOCIAL = txtRazaoSocial.Text;
            Config.Default.CNPJ = mtxtCNPJ.Text;
            Config.Default.END = txtEnd.Text;
            Config.Default.CEP = mtxtCEP.Text;
            Config.Default.TEL = mtxtTel.Text;
            Config.Default.VALOR = txtValor.Text;

            Config.Default.Save();

            MessageBox.Show("Configurações salvas com sucesso!");

            this.Visible = false;        
        }

        private bool ValidateFields()
        {

            return false;
        }
    }



}
