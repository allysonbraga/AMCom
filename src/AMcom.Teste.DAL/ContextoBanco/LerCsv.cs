using AMcom.Teste.DAL.ContextoBanco.Mapeamento;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AMcom.Teste.DAL
{
    public class LerCsv<T> where T : class
    {
        public IEnumerable<T> Ler(string dadosCsv)
        {
            if (dadosCsv == null)
                return null;

            var configuracaoCsv = new Configuration() { Delimiter = ",", HasHeaderRecord = true, MissingFieldFound = null };
            configuracaoCsv.AutoMap<T>();
            var csvReader = new CsvReader(new StringReader(dadosCsv), configuracaoCsv);

            return csvReader.GetRecords<T>().ToList();
        }
    }
}
