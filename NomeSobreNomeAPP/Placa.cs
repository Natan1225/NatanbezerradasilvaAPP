using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeSobreNomeAPP
{
    internal class Placa
    {
        public int Id_placa { get; set; }

        public string Tipo { get; set; }

        public int Tamanho { get; set; }

        public decimal Preço { get; set; }

        

        public Placa(int id_placa, string tipo, int tamanho, decimal preço)
        {
            Id_placa = id_placa;
            Tipo = tipo;
            Tamanho = tamanho;
            Preço = preço;
        }

        public Placa(string tipo, int tamanho, decimal preço)
        {
           
            Tipo = tipo;
            Tamanho = tamanho;
            Preço = preço;
        }


    }
}
