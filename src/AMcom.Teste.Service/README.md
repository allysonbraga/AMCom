## Camada de Serviços (Services)

Use esta camada para criar o(s) provedor(es) de dados provenientes da camada de acesso a dados (DAL) e disponibilizálos para a Web API.

Esta camada deve conter a lógica da aplicação (qualquer regra definida deve ser aplicada nas classes de serviços implementadas nesta camada).

### Objetivo

Você deve criar um método que retorne a lista de UBSs para a Web API com os valores preenchidos nas propriedades do objeto de retorno (ver classe `UbsDTO.cs`): Nome, Endereco e Avaliacao.

- Este método deve receber os valores de latitude e longitude fornecidos pelo método HTTP GET da Web API e filtar as 5 UBS mais próximas deste ponto.
- O endereço deve ser uma combinação dos campos dsc_endereco, dsc_bairro e dsc_cidade.
- O campo dsc_estrut_fisic_ambiencia contém a avaliação de desempenho para cada UBS. Use os dados deste campo ou defina o seu próprio mapeamente de avaliação para retornar as UBSs ordenadas por desempenho do mais alto para o mais baixo.

### Requisitos:

1. Implementar os provedores para que suas dependências sejam injetadas e utilizadas na Web API.
2. Injetar qualquer dependência necessária para o uso da camada de acesso a dados (DAL) pois os objetos devem estar desacoplados entre as camadas.

### DICAS:

- Você pode fazer uso de uma API externa, site, serviço ou implementar o seu próprio algoritmo de cálculo de distância entre os pontos (latitude e longitude).
- Lembre-se de criar o que for necessário para a injeção de dependência na Web API.
- Esta camada deve ser a única visível pela Web API. Qualquer acesso a camada de dados (DAL) deve ser feita por meio desta camada.
- Você pode usar qualquer componente que seja necessário para a sua implementação funcionar desde que este componente possa ser instalável via Nuget e esteja disponível na web.
- Quanto mais completa sua camada de serviços (lógica de aplicação), com mapeamentos, validações e tratamentos de exceções, mais completo será o seu exercício e mais pontos ele somará.
