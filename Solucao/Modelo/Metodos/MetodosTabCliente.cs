﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Modelo
{
    public partial class TabCliente : IDisposable
    {
        public TabCliente()
        {
            this.codigo = Incrementa();
            this.inserido = true;
            this.editado = false;
        }

        public static Int32 Incrementa()
        {
            int retorno = 0;
            using (SqlConnection conexao = new SqlConnection(""))
            {
                conexao.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "SELECT ISNULL(MAX(Codigo),0) + 1 FROM Cliente";

                    using (SqlDataReader sql = comando.ExecuteReader())
                    {
                        if (sql.HasRows)
                        {
                            sql.Read();
                            retorno = sql.GetInt32(0);
                        }
                    }
                }
            }

            return retorno;
        }

        public static List<TabCliente> BuscarTodos()
        {
            List<TabCliente> retorno = null;

            using (SqlConnection conexao = new SqlConnection(""))
            {
                conexao.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "SELECT * FROM Cliente";

                    using (SqlDataReader sql = comando.ExecuteReader())
                    {
                        if (sql.HasRows)
                        {
                            while (sql.Read())
                            {
                                TabCliente cliente = new TabCliente();
                                cliente.codigo = sql.GetInt32(sql.GetOrdinal("Codigo"));
                                cliente.nome = sql.GetString(sql.GetOrdinal("Nome"));
                                cliente.dataCadastro = sql.GetDateTime(sql.GetOrdinal("DataCadastro"));

                                if (retorno == null)
                                {
                                    retorno = new List<TabCliente>();
                                }
                                cliente.inserido = false;
                                cliente.editado = false;
                                retorno.Add(cliente);
                            }
                        }
                    }
                }
            }

            return retorno;
        }

        public void Inserir()
        {
            using (SqlConnection conexao = new SqlConnection("Server=.\\sqlexpress;Database=loja;Trusted_Connection=True;"))
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception)
                {
                    throw;
                }
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.CommandText = "Insert Into Cliente (Codigo, Nome, DataCadastro) Values (@codigo, @nome, @datacadastro)";
                    comando.Connection = conexao;

                    comando.Parameters.AddWithValue("@codigo", this.codigo);
                    comando.Parameters.AddWithValue("@nome", this.nome);
                    comando.Parameters.AddWithValue("@datacadastro", this.dataCadastro);

                    try
                    {
                        comando.ExecuteNonQuery();
                        this.inserido = false;
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
            }
        }

        public void Atualizar()
        {
            using (SqlConnection conexao = new SqlConnection("Server=.\\sqlexpress;Database=loja;Trusted_Connection=True;"))
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception)
                {
                    throw;
                }
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.CommandText = "Update Cliente Set Nome = @nome, DataCadastro = @datacadastro Where Codigo = @codigo";
                    comando.Connection = conexao;

                    comando.Parameters.AddWithValue("@codigo", this.codigo);
                    comando.Parameters.AddWithValue("@nome", this.nome);
                    comando.Parameters.AddWithValue("@datacadastro", this.dataCadastro);

                    try
                    {
                        comando.ExecuteNonQuery();
                        this.editado = false;
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
            }
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public void Gravar()
        {
            if (inserido)
            {
                Inserir();
            }
            else if (editado)
            {
                Atualizar();
            }
        }

        public void Dispose()
        {
            Gravar();
        }

    }
}
