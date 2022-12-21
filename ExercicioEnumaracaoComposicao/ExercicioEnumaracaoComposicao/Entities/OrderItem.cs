using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumaracaoComposicao.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public double Total()
        {
            return 
        }

        public override string ToString()
        {
            StringBuilder itemPedido = new StringBuilder();
            itemPedido.AppendLine("Itens do pedido: ");
            itemPedido.Append(Product.Name + ", ");
            itemPedido.Append($"R${Price.ToString()}, ");
            itemPedido.Append($"Subtotal: {SubTotal} ");
            itemPedido.Append($"Preço total: ");


        }


    }
}
