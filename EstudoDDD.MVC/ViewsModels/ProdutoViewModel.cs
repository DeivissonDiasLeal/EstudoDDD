using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstudoDDD.MVC.ViewsModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int produtoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome.")]
        [MaxLength(150, ErrorMessage = "Permitido até 150 caracteres.")]
        [MinLength(2, ErrorMessage = "Permitido no mínimo caracteres.")]
        public string nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0", "9999999999")]
        [Required(ErrorMessage = "Preencha o campo preço.")]
        public decimal preco { get; set; }

        [DisplayName("Disponível?")]
        public bool ativo { get; set; }

        public int clienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}