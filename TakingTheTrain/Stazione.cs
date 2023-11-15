using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakingTheTrain
{
    internal class Stazione
    {

        public string? nome { get; set; }

        public Stazione(string nome)
        {
            this.nome = nome;
        }


        public override string ToString()
        {
            return $"Stazione di: {nome}";
        }
    }
}
