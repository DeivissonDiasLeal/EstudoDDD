using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstudoDDD.MVC.ViewsModels
{
    public class ClienteViewModel
    {
        [Key]
        public int clienteId { get; set; }
                
        [Required(ErrorMessage = "Preencha o campo nome.")]
        [MaxLength(150, ErrorMessage = "Permitido até 150 caracteres.")]
        [MinLength(2, ErrorMessage = "Permitido no mínimo caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome.")]
        [MaxLength(150, ErrorMessage = "Permitido até 150 caracteres.")]
        [MinLength(2, ErrorMessage = "Permitido no mínimo caracteres.")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome.")]
        [MaxLength(100, ErrorMessage = "Permitido até 100 caracteres.")]
        [MinLength(2, ErrorMessage = "Permitido no mínimo caracteres.")]
        [EmailAddress(ErrorMessage = "Informe o E-mail válido.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime dataCadastro { get; set; }

        public bool ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}