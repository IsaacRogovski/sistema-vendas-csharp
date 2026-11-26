using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SistemaVendas.Dados
{
    internal class CategoriaDAO // dao vem de data access object, ou seja, objeto de acesso a dados
    {
        public static DataTable Listar()
        {
            DataTable tabela = new DataTable();

            string sql = @"
                SELECT
                    ID_CATEGORIA,
                    NM_CATEGORIA
                FROM tb_categoria
                ORDER BY NM_CATEGORIA;
            ";

            using SqlConnection conexao = Conexao.ObterConexao();

            using SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexao);

            adaptador.Fill(tabela);

            return tabela;
        }
    }
}