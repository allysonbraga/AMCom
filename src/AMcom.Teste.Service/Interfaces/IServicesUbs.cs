
using System.Collections.Generic;

namespace AMcom.Teste.Service
{
    public interface IServicesUbs : IServices<UbsDTO>
    {
        IEnumerable<UbsDTO> Selecionar(double latitude, double longitude, int quantidadeRetorno = 5);
    }
}