using System.ComponentModel.DataAnnotations;
using FichaCadastroAPI.Model;

namespace FichaCadastroAPI.DTOs
{
    public class GetTelefoneDTO
    {
      
        public string Contato { get; set; }
        
        public bool Ativo { get; set; }

        public virtual FichaModel Ficha { get; set; }
    }
}