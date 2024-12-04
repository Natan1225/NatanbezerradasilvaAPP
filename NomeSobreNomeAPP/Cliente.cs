using NatanbezerradasilvaClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NomeSobreNomeAPP
{
    internal class Cliente
    {
        public int Id_Cliente { get; set; }
        public string? Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }

        public string Endereço { get; }


        public Cliente()
        {
            Cliente cliente = new();
        }

        public Cliente(string? nome, string email, int telefone, string endereço)
        {

            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereço = endereço;
        }

        public Cliente(int id_Cliente, string? nome, string email, int telefone, string endereço)
        {
            Id_Cliente = id_Cliente;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereço = endereço;

        }
        public void InserirCliente()
        {
            var cmd = Banco.Abrir();
            var par = cmd.Parameters.AddWithValue;
            cmd.CommandText = $"insert into clientes values = {}";
            cmd.Parameters.AddWithValue("id_cliente", Id_Cliente);
            cmd.Parameters.AddWithValue("nome",Nome);
            cmd.Parameters.AddWithValue("email", Email);
            cmd.Parameters.AddWithValue("telefone", Telefone);
            cmd.Parameters.AddWithValue("endereço", Endereço);
            cmd.ExecuteReader();
            cmd.Connection.Close();
            
          

        }
       
        public void AlterarDadosdoCliente()
        {

        }
        
        public static Cliente ObterClienteporID(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetInt32(3),
                    dr.GetString(4)
                    ); 

            }
            return cliente;
        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                     dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetInt32(3),
                    dr.GetString(4)
                    ));
            }
            return lista;
        }

    }
}
