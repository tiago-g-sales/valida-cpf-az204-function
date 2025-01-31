using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MyCompanyAZ204.Function
{
    public class HttpTrigger1
    {
        private readonly ILogger<HttpTrigger1> _logger;

        public HttpTrigger1(ILogger<HttpTrigger1> logger)
        {
            _logger = logger;
        }

        [Function("HttpTrigger1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            string cpf = req.Query["cpf"];
            if (string.IsNullOrEmpty(cpf))
            {
                return new BadRequestObjectResult("Please pass a cpf on the query string");
            }
            if (cpf.Length != 11)
            {
                return new BadRequestObjectResult("Invalid CPF length");
            }

            if (!ValidaCPF(cpf))
            {
                return new BadRequestObjectResult("Invalid CPF");
            }

            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("CPF is valid");
        }



        private bool ValidaCPF(string cpf)
        {

            if (cpf.Length != 11)
            {
                return false;
            }
            int D1 = GetDigito(Somatorio(cpf));
            int D2 = GetDigito(D1*2 +Somatorio(cpf, true));
            
            if (cpf == cpf.Substring(0,9)+ D1.ToString() + D2.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private int GetDigito(int valor)
        {
            int resto = valor % 11;

            if (resto < 2)
            {
                return 0;
            }
            else
            {
                return 11 - resto;
            }

        }


        private int Somatorio(string cpf, bool segundoDigito = false)
        {
            int fator = 10;
            int Resultado = 0;
            int i = 0;

            if (segundoDigito){
                i = 1;
            }
            
            for (; i < 9; i++)
            {
                Resultado += int.Parse(cpf[i].ToString())*fator;
                fator--;

            }
            return Resultado;

        }
    }
}
