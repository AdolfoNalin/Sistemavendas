using MySql.Data.MySqlClient;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.dao
{
    public class DevolucaoDAO
    {
        #region connetion
        /// <summary>
        /// Atributo MySqlCoonction 
        /// </summary>
        private MySqlConnection connection;
        #endregion

        #region Construtor
        public DevolucaoDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarDevolucao
        public void CadastrarDevolucao(Devolucao obj)
        {
            try
            {
                string sql = @"insert into tb_devolucao (id,venda_id, cliente_id, produto_id, quantidade, motivo,total, observacoes)
            values(@venda_id, @cliente_id, @produto_id, @quantidade,@motivo, @total,@observacao)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@venda_id", obj.CodigoVenda);
                cmd.Parameters.AddWithValue("@cliente_id", obj.CodigoCliente);
                cmd.Parameters.AddWithValue("@produto_id", obj.CodigoProduto);
                cmd.Parameters.AddWithValue("@quantidade", obj.Quantidade);
                cmd.Parameters.AddWithValue("@Motivol", obj.Motivo);
                cmd.Parameters.AddWithValue("@total", obj.Total);
                cmd.Parameters.AddWithValue("@Observacao", obj.Obs);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"A devolução foi cadastrada com sucesso!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                connection.Close();
            }
        }
        #endregion

        #region EditarDevolucao
        public void EditarDevolucao(Devolucao obj)
        {
            try
            {
                string sql = @"update tb_devolucao set venda_id=@venda_id, cliente_id=@cliente_id, produto_id=@produto_id, 
                quantidade=@quantidade, motivo=@motivo,total=@total, observacoes=@observacoes";
            

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@venda_id", obj.CodigoVenda);
                cmd.Parameters.AddWithValue("@cliente_id", obj.CodigoCliente);
                cmd.Parameters.AddWithValue("@produto_id", obj.CodigoProduto);
                cmd.Parameters.AddWithValue("@quantidade", obj.Quantidade);
                cmd.Parameters.AddWithValue("@motivo", obj.Motivo);
                cmd.Parameters.AddWithValue("@total", obj.Total);
                cmd.Parameters.AddWithValue("@observacoes", obj.Obs);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"A devolução foi Editada com sucesso!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                connection.Close();
            }
        }
        #endregion

        #region ConsultarClientes
        /// <summary>
        /// Consulta do banco de dados, para listar os clientes cadastrado nele
        /// </summary>
        /// <returns>Retorna a  lista de clientes que está no banco de dados </returns>
        public DataTable ConsultarDevolucao()
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tbDevolucao= new DataTable();

                string sql = @"SELECT
                               d.id as 'Código',
                               v.id as 'Código da Venda',
                               c.nome as 'Nome Cliente',
                               p.descricao_resumida as 'Descrição Resumida',
                               p.quantidade as 'Quantidade',
                               d.motivo as 'Motivo Da Devolução',
                               d.Total as 'Total',
                               d.observacoes as 'Observação'
                               
                               FROM tb_devolucao as d
                               join tb_clientes as c on (d.cliente_id = c.id)
                               join tb_vendas as v on (d.venda_id = v.id)
                               join tb_produtos as p on (d.produto_id = p.id)";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql, connection);

                // 3 passo - Abertura da connection
                connection.Open();
                cmdSql.ExecuteNonQuery();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tbDevolucao);

                // 4 passo - Fechar a conexão
                connection.Close();
                return tbDevolucao;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace} Com a seguinte mesagem: {ex.Message}");
                connection.Close();
                return null;
            }
        }
        #endregion
    }
}
