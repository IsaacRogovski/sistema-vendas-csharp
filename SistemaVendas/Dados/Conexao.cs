using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace SistemaVendas.Dados
{
    internal static class Conexao
    {
        private static readonly string connectionString =
            @"Server=localhost\SQLEXPRESS;
              Database=SistemaVendas;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public static SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }
    }
}