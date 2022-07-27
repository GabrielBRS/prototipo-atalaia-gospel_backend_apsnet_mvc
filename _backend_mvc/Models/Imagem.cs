﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_aspnetmvc_entityframework.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public string Caminho { get; set; }

        //Banco de dados
        public int ProdutoId { get; set; }

        //POO
        [ForeignKey("ProdutoId")]
        public virtual Product Produto { get; set; }
    }
}
