﻿using MySql.Data.MySqlClient;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.dao
{
    public class VendaDAO
    {
        #region Connection
        /// <summary>
        /// Variável de conexão
        /// </summary>
        public MySqlConnection connection;
        #endregion

        #region Construtor
        /// <summary>
        /// Construtor com a conexão
        /// </summary>
        public VendaDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarVenda
        /// <summary>
        /// Método que cadastra o obj no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void CadastrarVenda(Venda obj)
        {
            try
            {
                string sql = @"insert into tb_vendas (cliente_id,forma_pagamento,sub_total,desconto_procentagem,desconto_real, total_venda, observacoes,subtotal,data_venda,hora_venda)
                               values (@cliente_id,forma_pagamento,@sub_total,@desconto_porcentagem,@desconto_real, @total_vendas, @observacoes,@subtotal,@data_venda,@hora_venda)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@cliente_id", obj.CodigoCliente);
                cmd.Parameters.AddWithValue("@forma_pagamento", obj.FormaPagamento);
                cmd.Parameters.AddWithValue("@sub_total", obj.SubTotal);
                cmd.Parameters.AddWithValue("@desconto_porcentagem", obj.DescontoPorcentagem);
                cmd.Parameters.AddWithValue("@desconto_real", obj.DescontoReal);
                cmd.Parameters.AddWithValue("@total_vendas", obj.TotalVenda);
                cmd.Parameters.AddWithValue("@observacoes", obj.Observacao);
                cmd.Parameters.AddWithValue("@subtotal", obj.SubTotalProduto);
                cmd.Parameters.AddWithValue("@data_venda", obj.Data);
                cmd.Parameters.AddWithValue("@hora_venda", obj.Hora);

                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                connection.Close();
            }
        }
        #endregion

        #region UltimaVenda
        /// <summary>
        /// Retorna o ultimo id, ou seja, a ultima venda que foi feita
        /// </summary>
        /// <returns>O id da venda</returns>
        public int UltimaVenda()
        {
            try
            {
                int idvenda = 0;

                string sql = "select max(id) id from tb_vendas";

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                connection.Open();

                MySqlDataReader DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    idvenda = DR.GetInt32("id");
                    connection.Close();
                }
                return idvenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconeteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return 0;
            }
        }
        #endregion

        #region listarHistoricoVenda
        /// <summary>
        /// Método que busca as informações das vendas 
        /// </summary>
        /// <param name="dataInicio">Data minima para procurar a venda</param>
        /// <param name="dataFim">DData maxima para procurar a venda</param>
        /// <returns></returns>
        public DataTable ListarHistoricoVenda(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                DataTable tabVendas = new DataTable();
                string sql = @"select v.id as 'Código',
                v.data_venda as 'Data da Venda',
                c.nome as 'Cliente',
                v.total_venda as 'Total',
                v.observacoes as 'Observações'
                from tb_vendas as v
                join tb_clientes as c on (v.cliente_id = c.id)
                where v.data_venda between @datainicio and @datafim";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@datainicio", dataInicio);
                cmd.Parameters.AddWithValue("@datafim", dataFim);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabVendas);

                connection.Close();

                return tabVendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region ConsultarVendas
        public DataTable ConsultarVenda()
        {
            try
            {
                DataTable tabvendas = new DataTable();
                string sql = @"select v.id as 'Código',
                v.data_venda as 'Data da Venda',
                c.nome as 'Cliente',
                v.total_venda as 'Total',
                v.observacoes as 'Observações'
                from tb_vendas as v
                join tb_clientes as c on (v.cliente_id = c.id)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabvendas);

                connection.Close();

                return tabvendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }

        }
        #endregion
    }
}
