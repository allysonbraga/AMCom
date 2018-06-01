using System.Collections.Generic;

namespace AMcom.Teste.DAL.Interfaces.DataContract
{
    public interface IRepository<TipoEntidade> where TipoEntidade : class
    {
        IEnumerable<TipoEntidade> Selecionar();
    }
}
