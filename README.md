# Lanchonete Virtual - Sistema de Pedidos

## Descrição do Projeto

Este é um sistema simples para uma lanchonete virtual, desenvolvido em C# para rodar no console. O sistema permite:

## Funcionalidades

- **Cadastro de Produtos:** O sistema possui produtos cadastrados, como lanches, bebidas e sobremesas, com preços definidos.
- **Operações de Pedido:** O sistema permite:
  - Cadastro de produtos (X-Burguer, Refrigerante, Sorvete);
  - Adição e remoção de produtos do pedido;
  - Cálculo do valor total, aplicando descontos quando necessário;

Visualização e finalização do pedido.
- **Descontos e Condições Especiais:**
  - Se o valor total do pedido ultrapassar R$ 100,00, um desconto de 10% será aplicado.
  - Desconto ou brinde especial pode ser dado com base na quantidade de itens no pedido.
- **Finalização do Pedido:** O sistema exibe um resumo do pedido com o valor bruto, descontos aplicados e valor final a ser pago.

## Passo a Passo para Executar o Código

1. **Pré-requisitos:**
   - Certifique-se de ter o **.NET 6** ou superior instalado na sua máquina. Você pode verificar se tem o .NET instalado executando o comando:
     ```bash
     dotnet --version
     ```
   - Se não tiver o .NET, faça o download [aqui](https://dotnet.microsoft.com/download).

2. **Baixar o Repositório:**
   - Clone o repositório ou baixe o código diretamente do GitHub.
   - Para clonar, execute o comando:
     ```bash
     git clone https://github.com/Matos-Ricardo/CP1_RICARDO_PAULO-Csharp.git
     ```

3. **Executar o Programa:**
   - Navegue até o diretório onde o código foi baixado.
   - Compile e execute o programa com o comando:
     ```bash
     dotnet run
     ```

4. **Interagir com o Sistema:**
   - O sistema irá exibir um menu com opções. Você pode:
     - Listar os produtos disponíveis.
     - Adicionar ou remover produtos do pedido.
     - Visualizar o pedido.
     - Finalizar o pedido.

## Integrantes do Grupo

- **RICARDO - RM: 95906**
- **PAULO - RM: 551137**
- **GUSTAVO - RM: 98809**

## Versão do .NET/C# Utilizada

- **.NET 6** (ou superior)
- **C# 9.0** (ou superior)

## Exemplo de Execução

Quando o programa é iniciado, o menu será exibido:

```plaintext
Escolha uma opção:
a. Listar produtos disponíveis
b. Adicionar produto ao pedido
c. Remover produto do pedido
d. Visualizar pedido atual
e. Finalizar pedido e sair
