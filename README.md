# AZ204 - DIO - Exercicio Valida CPF 
Azure Function Http Trigger 

# Desafio GOLang rate Limiter - FullCycle 

Aplicação em .Net Core (C#) sendo: 
  - Function Http Trigger

&nbsp;
- **Aplicação em Function**

## Funcionalidades

- **Valida CPF**
  - A função permite executar metodo get ou post rota base.

## Como Utilizar localmente:

1. **Requisitos:** 
   - Certifique-se de ter o Func instalado em sua máquina.
   - Certifique-se de ter o .Net Core 8.0 instalado em sua máquina.


&nbsp;
2. **Clonar o Repositório:**
&nbsp;

```bash
git clone https://github.com/tiago-g-sales/valida-cpf-az204-function.git
```
&nbsp;
3. **Acesse a pasta do app:**
&nbsp;

```bash
cd valida-cpf-az204-function
```
&nbsp;
4. **Rode o func strt para buildar e executar:**
&nbsp;

```bash 
 func start func localhost --dotnet-isolated
```

&nbsp;

## Como testar localmente:

curl --get http://localhost:7071/api/HttpTrigger1?cpf=32656345820



### Portas
HTTP server on port :7071 <br />

### HTTP COM APIKEY
 - Execute o curl abaixo ou use um aplicação client REST para realizar a requisição.   
    curl --request GET \
      --url http://localhost:7071/ \
      --header 'API_KEY: ABC123' \
      --header 'User-Agent: insomnia/10.0.0'

### HTTP POR IP DE ORIGEM
 - Execute o curl abaixo ou use um aplicação client REST para realizar a requisição.   
    curl --request GET \
      --url 'http://localhost:7071/api/HttpTrigger1?cpf=01125711078' \
      --header 'User-Agent: insomnia/10.0.0'

&nbsp;

  