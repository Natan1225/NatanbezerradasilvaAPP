using NatanbezerradasilvaClass;
using NomeSobreNomeAPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NatanbezerradasilvaAPP
{
    internal class Encomenda
    {
        public int Id_Encomenda { get; set; }
        public int Id_Cliente { get; set; }

        public DateTime Data_Encomenda { get; set; }

        public bool Status { get; set; }

        public DateTime Data_Entrega { get; set; }

        public Encomenda(int id_Encomenda, int id_Cliente, DateTime data_Encomenda, bool status, DateTime data_Entrega)
        {
            Id_Encomenda = id_Encomenda;
            Id_Cliente = id_Cliente;
            Data_Encomenda = data_Encomenda;
            Status = status;
            Data_Entrega = data_Entrega;
        }

        public Encomenda(DateTime data_Encomenda, bool status, DateTime data_Entrega)
        {
            Data_Encomenda = data_Encomenda;
            Status = status;
            Data_Entrega = data_Entrega;
        }

        public Encomenda()
        {
            Encomenda encomenda = new();
        }

        public void InserirEncomenda(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert into encomendas values {id}";
            cmd.Parameters.AddWithValue("id_encomenda",Id_Encomenda );
            cmd.Parameters.AddWithValue("id_cliente",Id_Cliente );
            cmd.Parameters.AddWithValue("dataencomenda", Data_Encomenda );
            cmd.Parameters.AddWithValue("status", Status );
            cmd.Parameters.AddWithValue("data_entrega", Data_Entrega );
            cmd.ExecuteReader();
            cmd.Connection.Close();

        }

        public static Encomenda ObterPorid(int id)
        {
            Encomenda encomenda = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from encomendas where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                encomenda = new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetDateTime(2),
                    dr.GetBoolean(3),
                    dr.GetDateTime(4)
                    );
            }
            return encomenda;

        }

        public static List<Encomenda> ObterporLista()
        {
            List<Encomenda> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from encomendas";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lista.Add(new(
                     dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetDateTime(2),
                    dr.GetBoolean(3),
                    dr.GetDateTime(4)
                    ));
            }
            return lista;
        }
    }

    



}
