using ExercicioEnumaracaoComposicao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumaracaoComposicao.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        List<OrderItem> Items = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime date, OrderStatus status)
        {
            Date = date;
            Status = status;
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();

        public override string ToString()
        {
            StringBuilder dadosSaida = new StringBuilder();
            dadosSaida.AppendLine("- - Resumo do Pedido - -");
            dadosSaida.AppendLine($"Estado atual do pedido {Status}");
            dadosSaida.AppendLine($"Cliente: {Client} ");

            return dadosSaida.ToString();

            
        }
    }
}
