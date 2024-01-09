using MySql.Data.MySqlClient;
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
    public class ItemOrcamentoDAO 
    {
        #region Campos
        MySqlConnection connection;
        #endregion

        #region Construtor
        public ItemOrcamentoDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarItemOrcamento
        public void CadastrarItemOrcamento(ItemOrcamento obj)
        {
            try
            {
                string sql = @"insert into tb_itensorcamento (orcamento_id, produto_id, qtd, subtotal_produto)
values (@orcamento_id, @produto_id, @qtd, @subtotal_produto)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@orcamento_id", obj.CodigoOrcamento);
                cmd.Parameters.AddWithValue("@produto_id", obj.CodigoProduto);
                cmd.Parameters.AddWithValue("@qtd", obj.Quantidade);
                cmd.Parameters.AddWithValue("@subtotal_produto", obj.Subtotal);

                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu eu erro do tipo {ex.Message} como o caminho {ex.StackTrace}");
                connection.Close();
            }
        }
        #endregion

        #region ListarItemOrcamento
        /// <summary>
        /// Função que busca os dados da venda, para passar para o data grid view
        /// </summary>
        /// <param name="id">Parametro para a pesquisa</param>
        /// <returns>DataTable</returns>
        public DataTable ListarItemOrcamento(int id)
        {
            try
            {
                DataTable tabListarItem = new DataTable();
                string sql = @"select p.id as ´Código,
                p.descricao_resumida as 'Descrição',
                i.qtd as 'Quantidade',
                p.preco_vista as 'Preço á Vista',
                p.preco_prazo as 'Preço á Prazo',
                i.subtotal_produto as 'SubTotal'
                from tb_itensorcamento as i join 
                tb_produtos as p on (i.produto_id = p.id) join
                tb_orcamento as o on(i.orcamento_id = o.id)
                where orcamento_id = @orcamento_id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@orcamento_id", id);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabListarItem);

                connection.Close();

                return tabListarItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
        }
        #endregion
    }
}
