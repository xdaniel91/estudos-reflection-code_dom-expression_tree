﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposReflection
{
    public class CarrinhoCliente
    {
        public CarrinhoCliente()
        {
        }

        public CarrinhoCliente(string clienteId)
        {
            ClienteId = clienteId;
            Itens = new List<ItemCarrinho>();
        }

        public CarrinhoCliente(CarrinhoCliente carrinhoCliente)
        {
            this.ClienteId = carrinhoCliente.ClienteId;
            this.Itens = carrinhoCliente.Itens;
        }

        public string ClienteId { get; set; }
        public List<ItemCarrinho> Itens { get; set; }
        public decimal Total => Itens.Sum(i => i.Quantidade * i.PrecoUnitario);
    }
}
