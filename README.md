# Exercícios de Programação

Este repositório contém soluções para cinco exercícios de programação em C#, cada um abordando um conceito fundamental de programação. A seguir, estão descrições detalhadas sobre o que cada programa faz.

## Exercício 1: Cálculo de Soma com Estrutura de Loop

### Descrição:

Este programa em C# calcula a soma de valores inteiros em uma sequência crescente a partir de um índice e imprime o resultado final. A estrutura de código é simples e utiliza um loop `while` para iterar e acumular o valor em uma variável chamada `SOMA`.

## Funcionalidade

O programa realiza o seguinte cálculo:

1. Define o valor de `INDICE` como 13, o valor inicial de `SOMA` como 0 e o contador `K` como 0.
2. Em seguida, usa um loop `while` que incrementa `K` em 1 a cada iteração e adiciona o valor de `K` à variável `SOMA`.
3. O loop continua até que `K` atinja o valor de `INDICE` (13), somando cada número de 1 até 13.
4. Ao final do loop, o programa imprime o valor total de `SOMA` no console.

### Exemplo de Saída

Para os valores definidos no programa:
- `INDICE = 13`
- Resultado final de `SOMA = 91`

---

## Exercício 2: Sequência de Fibonacci

### Descrição:
O programa recebe um número e gera a sequência de Fibonacci até esse número. Ele também verifica se o número informado faz parte dessa sequência. A sequência de Fibonacci é uma sequência numérica onde cada número é a soma dos dois anteriores, começando por 0 e 1.

### Funcionamento:
- O programa calcula os números de Fibonacci até que o número informado seja alcançado ou excedido.
- Ele verifica se o número informado está na sequência e imprime um resultado correspondente.

---

## Exercício 3: Faturamento Diário

### Descrição:
Dado um vetor contendo o valor de faturamento diário de uma distribuidora, o programa realiza os seguintes cálculos:
1. **Menor valor de faturamento**: Encontra o menor valor de faturamento em um dia específico.
2. **Maior valor de faturamento**: Encontra o maior valor de faturamento.
3. **Número de dias com faturamento acima da média**: Calcula a média mensal de faturamento (desconsiderando os dias com faturamento igual a zero) e conta quantos dias tiveram faturamento superior a essa média.

### Funcionamento:
- O programa utiliza os dados fornecidos (que podem ser importados de um arquivo JSON) e realiza as operações de cálculo necessárias para encontrar o menor e maior valor de faturamento, além da média.
- A média é calculada apenas considerando os dias em que houve faturamento.

---

## Exercício 4: Percentual de Faturamento por Estado

### Descrição:
Este programa calcula o percentual de representação de cada estado dentro do faturamento total mensal de uma distribuidora. Os estados e seus respectivos faturamentos são fornecidos, e o programa calcula o quanto cada estado contribui para o total.

### Funcionamento:
- O programa recebe os valores de faturamento por estado e calcula o faturamento total.
- Em seguida, para cada estado, o programa calcula o percentual do faturamento do estado em relação ao total mensal.

---

## Exercício 5: Inverter String

### Descrição:
Este programa recebe uma string e inverte seus caracteres, sem utilizar funções prontas como `reverse()`. O objetivo é mostrar como manipular strings e trabalhar com estruturas como arrays.

### Funcionamento:
- O programa converte a string em um vetor de caracteres.
- Utilizando dois índices (um no início e outro no final da string), ele troca os caracteres, movendo-se em direção ao centro da string, até que todos os caracteres sejam invertidos.

---
