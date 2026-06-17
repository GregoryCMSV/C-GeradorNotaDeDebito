using GeradorNotaDeDebito.Configs;
using GeradorNotaDeDebito.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
                var cnpjFormatado = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");
                if (cnpjFormatado.Length != 14)
                {
                    return (null, "CNPJ inválido");
                }

                var response = await _httpClient.GetAsync(cnpj);
                var content = await response.Content.ReadAsStringAsync();
                var cnpjDto = JsonSerializer.Deserialize<CnpjApiDto>(content);
                return (cnpjDto, "Cnpj encontrado!");
            }
            catch (Exception ex)
            {
                return (null,  ex.Message);
            }
        }

    }
}
