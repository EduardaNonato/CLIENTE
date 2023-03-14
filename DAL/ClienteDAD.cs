using AdivocaciaCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdivocaciaCliente.DAL

{
    public class ClienteDAD
    {
        private SqlConnection conexao;
        

        public ClienteDAD()
        {
            _conexao = ConexaoBD.getConexao();
        }
        public List<Cliente> getTodosClientes()
        {
            string sql = "select * from Cliente";
            var dados = (List<Cliente>)_conexao.Query<Cliente>(sql);
            return dados;
        }
    }
}
