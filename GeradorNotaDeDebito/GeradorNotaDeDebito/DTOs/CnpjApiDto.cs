using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GeradorNotaDeDebito.DTOs
{
    public class CnpjApiDto
    {
        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("razao_social")]
        public string RazaoSocial { get; set; }

        [JsonPropertyName("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [JsonPropertyName("situacao_cadastral")]
        public string Ativo { get; set; }

        [JsonPropertyName("tipo_logradouro")]
        public string TipoLogradouro { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("uf")]
        public string UF { get; set; }

        [JsonPropertyName("municipio")]
        public string Municipio { get; set; }

        [JsonPropertyName("telefones")]
        public List<TelefoneApiDto> Telefones { get; set; }
    }

    public class TelefoneApiDto
    {
        [JsonPropertyName("ddd")]
        public string Ddd { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("is_fax")]
        public bool IsFax { get; set; }

    }
}
