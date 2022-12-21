using ExercicioEnumaracaoComposicao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumaracaoComposicao.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime Date { get; set; }

        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }


        public override string ToString()
        {
            StringBuilder clienteDados = new StringBuilder();
            clienteDados.Append(Name + " ");
            clienteDados.Append(Date + " - ");
            clienteDados.Append(Email);
            

            return clienteDados.ToString();
        }
    }
}
