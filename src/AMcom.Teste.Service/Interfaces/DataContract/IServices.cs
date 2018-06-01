using System.Collections.Generic;

namespace AMcom.Teste.Service
{
    public interface IServices<TipoEntidade> where TipoEntidade : class
    {
        IEnumerable<TipoEntidade> Selecionar(double latitude, double longitude);
    }
}