using DocumentFormat.OpenXml.Packaging;
using GeradorNotaDeDebito.Modelos;
using Spire.Doc;
using System.Security;

namespace GeradorNotaDeDebito
{
    public partial class FrmGeradorNota : Form
    {

        private UserConfig uc = null;

        public FrmGeradorNota()
        {
            //Config.Default.Reset();
            InitializeComponent();
        }

        private void FrmGeradorNota_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Config.Default.RAZAO_SOCIAL))
            {
                CreateShowUserConfig();
            }
            else
            {
                CarregarDadosNaTela();
            }
        }

        private void TsmiConfigurar_Click(object sender, EventArgs e)
        {
            CreateShowUserConfig();
        }

        private void CreateShowUserConfig()
        {
            if(uc is null)
            {
                tsmiConfigurar.Visible = false;
                uc = new Modelos.UserConfig();
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
                uc.BringToFront();
                uc.VisibleChanged += UserConfig_VisibleChanged;
            }
            else
            {
                uc.BringToFront();
                uc.Visible = true;
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            string modeloPath = Path.Combine(Application.StartupPath, "Modelos", "Modelo.docx");

            if (!File.Exists(modeloPath))
            {
                MessageBox.Show("Arquivo Modelo.docx não encontrado!");
                return;
            }

            string numeroNota = GetNFNumber();

            string tempDocx = Path.Combine(Path.GetTempPath(), $"NotaTemp_{numeroNota}.docx");
            File.Copy(modeloPath, tempDocx, true);

            try
            {
                SubstituirTagsNoOpenXML(tempDocx, numeroNota);

                string pastaDestino = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string pdfPath = Path.Combine(pastaDestino, $"NotaDebito_{numeroNota}.pdf");

                Document document = new Document();
                document.LoadFromFile(tempDocx);
                document.SaveToFile(pdfPath, FileFormat.PDF);

                MessageBox.Show($"PDF gerado com sucesso na sua Área de Trabalho!\nArquivo: {Path.GetFileName(pdfPath)}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
            finally
            {
                if (File.Exists(tempDocx))
                {
                    File.Delete(tempDocx);
                }
            }
        }


        private string GetNFNumber()
        {
            return dtpMes.Value.ToString("MMyyyy");
        }

        private void SubstituirTagsNoOpenXML(string filePath, string numeroNota)
        {
            //DateTime dataAtual = DateTime.Now;

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, true))
            {
                string docText = null;

                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    docText = sr.ReadToEnd();
                }

                string Escapar(string texto) => SecurityElement.Escape(texto ?? "");

                
                docText = docText.Replace("{{RAZAO_SOCIAL}}", Escapar(txtRazaoSocial.Text));
                docText = docText.Replace("{{CNPJ}}", Escapar(mtxtCNPJ.Text));
                docText = docText.Replace("{{END}}", Escapar(txtEnd.Text));
                docText = docText.Replace("{{CEP}}", Escapar(mtxtCEP.Text));
                docText = docText.Replace("{{TEL}}", Escapar(mtxtTel.Text));
                docText = docText.Replace("{{VALOR}}", Escapar(txtValor.Text.Replace("R$","")));

                docText = docText.Replace("{{EMPRESA}}", Escapar(txtRazaoDestinatario.Text));
                docText = docText.Replace("{{EMPRESA_CNPJ}}", Escapar(mtxtCNPJDestinatario.Text));
                docText = docText.Replace("{{EMPRESA_END}}", Escapar(txtEndDestinatario.Text));

                var dataSelecionada = dtpMes.Value;
                DateTime primeiroDia = new DateTime(dataSelecionada.Year, dataSelecionada.Month, 1);
                int diasNoMes = DateTime.DaysInMonth(dataSelecionada.Year, dataSelecionada.Month);
                DateTime ultimoDia = new DateTime(dataSelecionada.Year, dataSelecionada.Month, diasNoMes);

                docText = docText.Replace("{{DATA}}", primeiroDia.ToString("dd/MM/yyyy"));
                docText = docText.Replace("{{NUM_NOTA}}", numeroNota);
                docText = docText.Replace("{{MES}}", dataSelecionada.ToString("MMMM"));
                docText = docText.Replace("{{VENCIMENTO}}", ultimoDia.ToString("dd/MM/yyyy"));

                using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                {
                    sw.Write(docText);
                }
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {

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

        private void CarregarDadosNaTela()
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
            tsmiConfigurar.Visible = true;
        }

        private void UserConfig_VisibleChanged(object sender, EventArgs e)
        {
            dynamic dymSender = sender as dynamic;
            if (dymSender.Visible)
            {
                uc?.ChangeBTNCancelarEnabled();
                tsmiConfigurar.Visible = false;
            }
            else
            {
                CarregarDadosNaTela();
            }
        }
    }
}
