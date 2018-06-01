## Camada de acesso a dados (DAL)

Use esta camada para prover os dados que serão necessários para a aplicação.

## Objetivo

Você deve importar o arquivo ubs.csv fornecido no diretório do projeto (seja usando um provedor de banco de dados em memória) ou mesmo uma lista ou coleção para que seja consultada pela camada de serviços por meio de um repositório.

### Requisitos:

1. Carregar o arquivo em anexo (ubs.csv) para uma lista/coleção de objetos do tipo Ubs (ver classe `Ubs.cs`) e retornar por meio de um repositório (ver classe `UbsRepository.cs`) os dados para serem utilizados pela camada de serviço.
2. IMPORTANTE: Caso você use uma fonte de dados externa a aplicação, inclua todos os componentes que sejam necessários para a execução da aplicação em outro ambiente sem que ela pare de funcionar.

### DICAS:

- Use algum provedor de dados em memória ou mesmo arquivo. A fonte de dados está disponível no arquivo ubs.zip (ubs.csv após descompactado) no diretório raiz deste projeto e incluído na solução.
- Lembre-se de criar o que for necessário para a injeção de dependência na camada de serviços.
- Esta camada não deve ser acessada diretamente pela Web API. Qualquer acesso a esta camada de dados deve ser feita por meio da camada de serviços.
- Você pode usar qualquer componente que seja necessário para a sua implementação funcionar desde que este componente possa ser instalável via Nuget e esteja disponível na web.
