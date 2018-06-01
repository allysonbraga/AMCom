using AMcom.Teste.DAL.ContextoBanco;
using AMcom.Teste.DAL.Interfaces;
using System.Collections.Generic;

namespace AMcom.Teste.DAL
{
    public class UbsRepository : IRespositoryUbs
    {
        // Implemente um método que retorne uma lista/coleção de objetos do tipo Ubs.
        // Caso necessário, crie um parâmetro para filtrar os objetos dessa coleção se a lógica não for 
        // implementada na camada de serviços.
        public IEnumerable<Ubs> Selecionar()
        {
            var dadosArquivo = Recurso.ubs;
            return new LerCsv<Ubs>().Ler(dadosArquivo);
        }
    }
}
