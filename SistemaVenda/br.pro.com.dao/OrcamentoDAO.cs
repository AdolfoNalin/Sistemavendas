using MySql.Data.MySqlClient;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.dao
{
    public class OrcamentoDAO
    {
        private MySqlConnection connection;

        #region Construtor
        public OrcamentoDAO() 
        { 
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region Gravar Orcamento
        /// <summary>
        /// 
        /// </summary>
        public void CadastrarOrcamento(Orcamento obj)
        {
            try
            {
                string cmdSql = @"insert into tb_orcamento (cliente_id,funcionario_id,desconto_porcentagem,descoto_real,acrescimo_porcentagem,acrescimo_real,
                subtotal_orcamento,total,alteracoes,data_orcamento,hora_orcamento, quantidade_total,obs)
                values (@cliente_id,@funcionario_id,@desconto_porcentagem,@desconto_real,@acrescimo_porcentagem,@acrescimo_real, @subtotal_orcamento, @total, @alteracoes,
                @data_orcamento,@hora_orcamento,@quantidade_total,obs)";

                MySqlCommand sqlCmd = new MySqlCommand(cmdSql, connection);
                sqlCmd.Parameters.AddWithValue("@cliente_id", obj.CodigoCliente);
                sqlCmd.Parameters.AddWithValue("@funcionario_id", obj.CodigoVendedor);
                sqlCmd.Parameters.AddWithValue("@desconto_porcentagem", obj.DescontoPorcentagem);
                sqlCmd.Parameters.AddWithValue("@desconto_real", obj.DescontoReal);
                sqlCmd.Parameters.AddWithValue("@acrescimo_porcentagem", obj.AcrescimoPorcentagem);
                sqlCmd.Parameters.AddWithValue("@acrescimo_real", obj.AcrescimoReal);
                sqlCmd.Parameters.AddWithValue("@subtotal_orcamento", obj.SubTotal);
                sqlCmd.Parameters.AddWithValue("@total", obj.Total);
                sqlCmd.Parameters.AddWithValue("@alteracoes", obj.Alteracoes);
                sqlCmd.Parameters.AddWithValue("@data_orcamento", obj.Data);
                sqlCmd.Parameters.AddWithValue("@hora_orcamento", obj.Hora);
                sqlCmd.Parameters.AddWithValue("@quantidade_total", obj.QuantidadeTotal);
                sqlCmd.Parameters.AddWithValue("@obs", obj.Obs);

                this.connection.Open();

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Orçcamento foi gravado com sucesso!");

                this.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Orçamento não foi gravado. Mensagem {ex.Message} com caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region EditarOrcamento
        public void EditarOrcamento(Orcamento obj)
        {
            try
            {
                string cmdSql = @"update tb_orcamentos set cliente_id=@cliente_id,funcionario_id=@vendedor_id,
                desconto_porcentagem=@desconto_porcentagem,desconto_real=@desconto_real,acrescimo_porcentagem=@acrescimo_porcentagem,acrescimo_real=@acrescimo_real,
                subtotal_orcamento=@subtotal,total=@total,alteracoes=@alteracoes,data_orcamento=@data,hora_orcamento=@hora, quantidade_total=@quantidadeTotal,obs=@obs
                where id=@id";

                MySqlCommand sqlCmd = new MySqlCommand(cmdSql, connection);
                sqlCmd.Parameters.AddWithValue("@cliente_id", obj.CodigoCliente);
                sqlCmd.Parameters.AddWithValue("@vendedor_id", obj.CodigoVendedor);
                sqlCmd.Parameters.AddWithValue("@desconto_porcentagem", obj.DescontoPorcentagem);
                sqlCmd.Parameters.AddWithValue("@desconto_real", obj.DescontoReal);
                sqlCmd.Parameters.AddWithValue("@acrescimo_porcentagem", obj.DescontoReal);
                sqlCmd.Parameters.AddWithValue("@acrescimo_real", obj.DescontoReal);
                sqlCmd.Parameters.AddWithValue("@subtotal", obj.SubTotal);
                sqlCmd.Parameters.AddWithValue("@total", obj.Total);
                sqlCmd.Parameters.AddWithValue("@alteracoes", obj.Alteracoes);
                sqlCmd.Parameters.AddWithValue("@data", obj.Data);
                sqlCmd.Parameters.AddWithValue("@hora", obj.Hora);
                sqlCmd.Parameters.AddWithValue("@quantidadeTotal", obj.QuantidadeTotal);
                sqlCmd.Parameters.AddWithValue("@obs", obj.Obs);
                sqlCmd.Parameters.AddWithValue("@id", obj.Codigo);

                this.connection.Open();

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Orçcamento foi gravado com sucesso!");

                this.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Orçamento não foi cadastrado. Messagem {ex.Message} como o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region ExcluirOrcamento
        public void ExcluirOrcamento(Orcamento obj)
        {
            try
            {
                string cmdSql = "delte * from tb_orcamento where codigo=@codigo";

                MySqlCommand sqlCmd = new MySqlCommand(cmdSql, connection);
                sqlCmd.Parameters.AddWithValue("@codigo", obj.Codigo);
                
                this.connection.Open();

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Orçcamento foi gravado com sucesso!");

                this.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Orçamento não foi excluido. Messagem {ex.Message} com caminho {ex.StackTrace}");
            }
           
        }
        #endregion

        #region ConsultarOrcamentoDetalhes
        public DataTable ConsultarOrcamentoDetalhes()
        {
            try
            {
                string sql = @"select o.id as 'Código',
                c.nome as 'Cliente',
                f.nome as 'Vendedor',
                o.total as 'Total',
                o.obs as 'Observações'
                from tb_orcamento as o
                join tb_clientes as c on (o.cliente_id = c.id)
                join tb_funcionarios as f on (o.funcionario_id = f.id)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um errodo do tipo {ex.Message} com o caminho {ex.StackTrace}");
                connection.Close();
                return null;
            }
        }
        #endregion

        #region ConsultarOrcamento
        public DataTable ConsultarOrcamento()
            {
                try
                {
                    string sql = @"select o.id as 'Código',
                    c.nome as 'Cliente',
                    f.nome as 'Vendedor',
                    o.desconto_porcentagem as 'Desconto Porcentagem',
                    o.descoto_real as 'Desconto Dinheiro',
                    o.acrescimo_porcentagem as 'Acrescimo Porcentagem',
                    o.acrescimo_real as 'Acrescimo Dinheiro',
                    o.subtotal_orcamento as 'SubTotal', 
                    o.total as 'Total', 
                    o.alteracoes as 'Alterações', 
                    o.data_orcamento as 'Data',
                    o.hora_orcamento as 'Data e Hora',
                    o.quantidade_total as 'Total Quantidade',
                    o.obs as 'Observação'
                    from tb_orcamento as o
                    join tb_clientes as c on (o.cliente_id = c.id)
                    join tb_funcionarios as f on (o.funcionario_id = f.id)";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    connection.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Aconteceu um errodo do tipo {ex.Message} com o caminho {ex.StackTrace}");
                    connection.Close();
                    return null;
                }
            }
        #endregion

        #region listarHistoricoOrcamneto
        /// <summary>
        /// Método que busca as informações das vendas 
        /// </summary>
        /// <param name="dataInicio">Data minima para procurar a venda</param>
        /// <param name="dataFim">DData maxima para procurar a venda</param>
        /// <returns></returns>
        public DataTable ListarHistoricoOrcamento(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                DataTable tabVendas = new DataTable();
                string sql = @"select o.id as 'Código',
                c.nome as 'Cliente',
                f.nome as 'Vendedor',
                o.desconto_porcentagem as 'Desconto Porcentagem',
                o.descoto_real as 'Desconto Real',
                o.acrescimo_porcentagem as 'Acrescimo Porcentagem',
                o.acrescimo_real as 'Acrescimo Real',
                o.subtotal_orcamento as 'Subtotal',
                o.total as 'Total',
                o.alteracoes as 'Alterações',
                o.data_orcamento as 'Data da Orçamento',
                o.hora_orcamento as 'Hora da Orçamento',
                o.quantidade_total as 'Quantidade de Itens',
                o.obs as 'Observações'
                from tb_orcamento as o
                join tb_clientes as c on (o.cliente_id = c.id)
                join tb_funcionarios as f on (o.funcionario_id= f.id)
                where o.data_orcamento between @datainicio and @datafim";

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

        #region ConsultarOrcamentoCodigo
        public Orcamento ConsultarOrcamentoCodigo(int id)
        {
            try
            {
                Orcamento obj = new Orcamento();
                string sql = "select * from tb_orcamento where id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    obj.Codigo = dr.GetInt32("id");
                    obj.CodigoCliente= dr.GetInt32("cliente_id");
                    obj.CodigoVendedor= dr.GetInt32("funcionario_id");
                    obj.DescontoPorcentagem = dr.GetDecimal("desconto_porcentagem");
                    obj.DescontoReal = dr.GetDecimal("descoto_real");
                    obj.AcrescimoPorcentagem= dr.GetDecimal("acrescimo_porcentagem");
                    obj.AcrescimoReal = dr.GetDecimal("acrescimo_real");
                    obj.SubTotal = dr.GetDecimal("subtotal_orcamento");
                    obj.Total = dr.GetDecimal("total");
                    obj.Alteracoes = dr.GetDecimal("alteracoes");
                    obj.Data = dr.GetDateTime("data_orcamento");
                    obj.Hora = dr.GetDateTime("hora_orcamento");
                    obj.QuantidadeTotal = dr.GetInt32("quantidade_total");
                    obj.Obs = dr.GetString("obs");
                }

                connection.Close();
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um errodo do tipo {ex.Message} com o caminho {ex.StackTrace}");
                connection.Close();
                return null;
            }

        }
        #endregion

        #region ConsultarOrcamentoIdCliente
        public Orcamento ConsultarOrcamentoIdCliente(int id)
        {
            try
            {
                Orcamento obj = new Orcamento();
                string sql = "select * from tb_orcamento where cliente_id = @cliente_id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@cliente_id", id);
                connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    obj.Codigo = dr.GetInt32("id");
                    obj.CodigoCliente = dr.GetInt32("cliente_id");
                    obj.CodigoVendedor = dr.GetInt32("funcionario_id");
                    obj.DescontoPorcentagem = dr.GetDecimal("desconto_porcentagem");
                    obj.DescontoReal = dr.GetDecimal("descoto_real");
                    obj.AcrescimoPorcentagem = dr.GetDecimal("acrescimo_porcentagem");
                    obj.AcrescimoReal = dr.GetDecimal("acrescimo_real");
                    obj.SubTotal = dr.GetDecimal("subtotal_orcamento");
                    obj.Total = dr.GetDecimal("total");
                    obj.Alteracoes = dr.GetDecimal("alteracoes");
                    obj.Data = dr.GetDateTime("data_orcamento");
                    obj.Hora = dr.GetDateTime("hora_orcamento");
                    obj.QuantidadeTotal = dr.GetInt32("quantidade_total");
                    obj.Obs = dr.GetString("obs");
                }

                connection.Close();
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um errodo do tipo {ex.Message} com o caminho {ex.StackTrace}");
                connection.Close();
                return null;
            }

        }
        #endregion

        #region UltimoOrcamento
        public int UltimoOrcamento()
        {
            try
            {
                int id = 0;

                string sql = "select max(id) id from tb_Orcamento";

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                connection.Open();

                MySqlDataReader DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    id = DR.GetInt32("id");
                    connection.Close();
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconeteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return 0;
            }
        }
        #endregion
    }
}
