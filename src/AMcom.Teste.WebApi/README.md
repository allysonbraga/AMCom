## Web API

### Objetivo

Você deve implementar uma Web API para listar as Unidades Básicas de Saúde (UBSs) conforme os requisitos abaixo:

### Requisitos:

1. Crie um método acessível por HTTP GET para expor os dados da Web API.
2. Este método deve retornar uma lista das 5 UBSs (Unidades Básicas de Saúde) mas próximas de um ponto (latitude e longitude) e ordenada por avaliação de desempenho (da mais alta para a mais baixa).
3. O retorno do método deve ser um array de objetos no formato JSON, como no exemplo abaixo:
```
[{ "Nome": "UBS1", "Endereco": "R. das UBSs, 123", "Avaliacao": "Desempenho acima da média"}, ...]
```

### DICAS:

- Use o Postman ou qualquer cliente REST para realizar os testes de sua Web API.
- O array deve retornar somente 5 (ou menos) registros conforme os requisitos definidos acima.
- Use quaisquer recursos disponíveis (desde que sem custo) para executar os cálculos e a lógica necessária para realizar este exercício.
