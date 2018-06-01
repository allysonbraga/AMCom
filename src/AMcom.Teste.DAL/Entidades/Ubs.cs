using CsvHelper.Configuration.Attributes;

namespace AMcom.Teste.DAL
{
    public class Ubs
    {
        // Esta classe deve conter as seguintes propriedades:
        // vlr_latitude, vlr_longitude, nom_estab, dsc_endereco, dsc_bairro, dsc_cidade, dsc_estrut_fisic_ambiencia
        [Name("vlr_latitude")]
        public string Latitude { get; set; }

        [Name("vlr_longitude")]
        public string Longitude { get; set; }

        [Name("nom_estab")]
        public string Nome { get; set; }

        [Name("dsc_endereco")]
        public string Endereco { get; set; }

        [Name("dsc_bairro")]
        public string Bairro { get; set; }

        [Name("dsc_cidade")]
        public string Cidade { get; set; }

        [Name("dsc_estrut_fisic_ambiencia")]
        public string Avaliacao { get; set; }

        [Ignore]
        public double Distancia { get; set; }

        public override string ToString()
        {
            return Endereco + ", bairro: " + Bairro + ", cidade: " + Cidade;
        }
    }
}