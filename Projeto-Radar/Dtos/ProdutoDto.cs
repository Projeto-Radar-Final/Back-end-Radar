using System.Text.Json.Serialization;

namespace Projeto_Radar.Dtos
{
    public class ProdutoDto
    {

        public string Nome { get; set; }


        public string Descricao { get; set; }


        public double Valor { get; set; }

        public int QtdEstoque { get; set; }

        public double Custo { get; set; }

        [JsonPropertyName("categoria_id")]
        public int CategoriaId { get; set; }


    }
}
