using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowBased.Entities;

namespace WowBased.Entities
{
    internal class Jogador
    {
        public string Nick { get; set; }
        public string Classe { get; set; }

        public string Spec { get; set; }


        public Jogador(string nick, string classe, string spec)
        {
            Classe = classe;
            Nick = nick;
            Spec = spec;
            
        }

        public int MediaDps(int dpsBurst, int dpsFinal)
        {
            int media = (dpsBurst + dpsFinal) / 2;
            return media;
        }
        

        public override string ToString()
        { 

            return $"Nick do Personagem: {Nick}\nClasse: {Classe}\nEspecialidade: {Spec}\n";
        }
    }
}

