using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojasCRUD.Models{

    public class Loja{

        public int Id { get; set; }

        [Display(Name = "Razão Social")]
        public string razaoSocial { get; set; }

        [Display(Name = "E-mail")]
        public string email { get; set; }
        
        [Display(Name = "Logradouro")]
        public string logradouro { get; set; }

        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Display(Name = "CEP")]
        public string cep { get; set; }

        [Display(Name = "UF")]
        public string uf { get; set; }

        [Display(Name = "Latitude")]
        public string Latitude { get; set; }
        [Display(Name = "Longitude")]
        public string Longitude { get; set; }
    }

}