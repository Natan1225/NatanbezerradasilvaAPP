using NatanbezerradasilvaClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatanbezerradasilvaAPP
{
    internal class Avaliação
    {

        public int Id_Avaliação { get; set; }

        public int Id_Placa { get; set; }

        public int Id_Cliente { get; set; }

        public int Nota { get; set; }

        public string Comentario { get; set; }
        public Avaliação(int id_Avaliação, int id_Placa, int id_Cliente, int nota, string comentario)
        {
            Id_Avaliação = id_Avaliação;
            Id_Placa = id_Placa;
            Id_Cliente = id_Cliente;
            Nota = nota;
            Comentario = comentario;
        }

        public void Inseriravaliação()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select Avaliação"
        }
    }
    
}
