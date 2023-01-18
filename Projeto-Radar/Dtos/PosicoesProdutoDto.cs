using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projeto_Radar.Entitys;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Radar.Dtos
{
    public class PosicoesProdutoDto
    {   
        public int Id { get; set; }
        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
        public int CampanhaId { get; set; }
  


    }
}
