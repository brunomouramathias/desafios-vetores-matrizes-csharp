# Desafios Praticos com Vetores e Matrizes em C#

Esta colecao reune 30 exercicios para praticar a declaracao, preenchimento, iteracao e manipulacao de vetores e matrizes em C#. O objetivo e consolidar conceitos de indexacao, controle de fluxo, condicionais e validacoes de entrada. Todos os exercicios estao implementados em um projeto de console e podem ser executados individualmente atraves de um menu interativo.

## Estrutura do projeto
- `DesafiosVetoresMatrizes.csproj` – arquivo do projeto .NET com configuracoes basicas (target framework, nullability, etc.).
- `Program.cs` – exibe um menu com os 30 desafios e delega a execucao para metodos especificos.
- `Exercises/Exercises.cs` – classe estatica que contem a implementacao de cada exercicio numerado de 1 a 30.

## Como executar
1. Instale o SDK do .NET 7.0 ou superior.
2. No terminal, navegue ate a pasta `desafios-vetores-matrizes` e execute:
```
dotnet restore
dotnet run
```
3. Escolha o numero do exercicio que deseja executar no menu apresentado. Digite `0` para sair.

## Exercicios incluidos
Alguns exemplos de desafios que voce encontrara:
- Ler 6 numeros inteiros e verificar se estao em ordem crescente.
- Ler 10 numeros e exibir na ordem inversa.
- Ler 8 numeros de ponto flutuante e calcular a media.
- Ler n valores e determinar o maior e o menor.
- Operacoes com matrizes: soma, multiplicacao, transposicao, diagonal principal, soma de linhas e colunas.
- Rotacao de vetores, ordenacao (bubble sort) e verificacao de simetria.
- Listagem de numeros primos, identificacao de numeros unicos e calculo de frequencias.

Cada exercicio inclui validacao de entrada e utiliza lacos e condicionais para resolver o problema proposto.

## Contribuindo
Sinta-se a vontade para clonar o repositorio, sugerir melhorias ou propor novos exercicios. Estes exemplos sao destinados ao aprendizado, e toda contribuicao e bem-vinda.
