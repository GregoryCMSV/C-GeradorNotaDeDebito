using GeradorNotaDeDebito.Configs;
using GeradorNotaDeDebito.DTOs;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GeradorNotaDeDebito.Services
{
    public class CNPJService
    {
        private HttpClient _httpClient;
        public CNPJService()
        {
            _httpClient = GenerateHttpClient();  
        }

        private HttpClient GenerateHttpClient()
        {
            var baseUrl = APISettings.Default.BaseURL;
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            return client;
        }

        public async Task<(CnpjApiDto, string)> GetCnpjInfo(string cnpj)
        {
            try
            {
                if (!ValidarCNPJ(cnpj))
                {
                    return (null, "CNPJ inválido");
                }

                var response = await _httpClient.GetAsync(cnpj);
                if (response.StatusCode == HttpStatusCode.NotFound) return (null, "CNPJ Não encontrado");
                var content = await response.Content.ReadAsStringAsync();
                var cnpjDto = JsonSerializer.Deserialize<CnpjApiDto>(content);
                return (cnpjDto, "Cnpj encontrado!");
            }
            catch (Exception ex)
            {
                return (null,  ex.Message);
            }
        }

        public bool ValidarCNPJ(string cnpj)
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
            {
                var valor = char.IsDigit(tempCnpj[i]) ? int.Parse(tempCnpj[i].ToString()) : (int)tempCnpj[i]- 48;
                soma += valor * multiplicador1[i];
            }

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();

            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
            {
                var valor = char.IsDigit(tempCnpj[i]) ? int.Parse(tempCnpj[i].ToString()) : (int)tempCnpj[i] - 48;
                soma += valor * multiplicador2[i];
            }

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

    }
}
