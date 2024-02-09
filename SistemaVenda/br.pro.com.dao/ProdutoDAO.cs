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
    public class ProdutoDAO
    {
        #region Connection 
        /// <summary>
        /// Variável que é responsável por conectar o banco de dados ao sistema
        /// </summary>
        private MySqlConnection connection;
        #endregion

        #region ProdutosDAO
        /// <summary>
        /// Construtor com a conexão 
        /// </summary>
        public ProdutoDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarProdutos
        /// <summary>
        /// Método que é resposável por cadastrar o obj no banco de dados
        /// </summary>
        /// <param name="obj">Parametro para ser cadastrado</param>
        public void CadastrarProdutos(Produto obj)
        {
            try
            {
                string sql = @"insert into tb_produtos (descricao_completa,descricao_resumida,preco_vista,preco_prazo,valor_entrada,
                valor_total,quantidade,unid_medida,data_entrada,hora_entrada,for_id)
 values(@descricao_com,@descricao_resu,@preco_vista,@preco_prazo,@valor_entrada,@valor_total,@qtd_estoque,@uni_medida,@data_entrada,@hora_entrada,@for_id)";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@descricao_com", obj.DescricaoCompleta);
                cmdSql.Parameters.AddWithValue("@descricao_resu", obj.DescricaoResumida);
                cmdSql.Parameters.AddWithValue("@preco_vista", obj.PrecoVista);
                cmdSql.Parameters.AddWithValue("@preco_prazo", obj.PrecoPrazo);
                cmdSql.Parameters.AddWithValue("@valor_entrada", obj.ValorEntrada);
                cmdSql.Parameters.AddWithValue("@valor_total", obj.ValorTotal);
                cmdSql.Parameters.AddWithValue("@qtd_estoque", obj.Quantidade);
                cmdSql.Parameters.AddWithValue("@uni_medida", obj.UniMedida);   
                cmdSql.Parameters.AddWithValue("@data_entrada", obj.Data);
                cmdSql.Parameters.AddWithValue("@hora_entrada", obj.Hora);
                //cmdSql.Parameters.AddWithValue("@imagem", obj.Imagem);
                cmdSql.Parameters.AddWithValue("@for_id", obj.CodigoFornecedor);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"Produto foi cadastrado com sucesso ");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do Tipo {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ConsultarProdutos
        /// <summary>
        /// Função que consulta os dados do obj e mostra no DataGrid
        /// </summary>
        /// <returns>Retorna um DataTable</returns>
        public DataTable ConsultarProdutos()
        {
            try
            {
                DataTable tabProduto = new DataTable();

                string sql = @"select  p.id as 'Código',
                                p.descricao_resumida as 'Descrição Resumida',
                                p.descricao_completa as 'Descrição Completa',
                                p.preco_vista as 'Preço á Vista',
                                p.preco_prazo as 'Preço á Prazo',
                                p.valor_entrada as 'Valor Entrada',
                                p.valor_total as 'Valor Total',
                                p.quantidade as 'Quantidade Estoque',
                                p.unid_medida as 'Unidade de Medida',
                                p.data_entrada as 'Data Entrada',
                                p.hora_entrada as 'Hora Entrada',
                                f.nome as 'Fornecedores'
                                from bdvendas2.tb_produtos as p join tb_fornecedores as f
                                on (p.for_id = f.id)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabProduto);

                connection.Close();
                return tabProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region ConsultarProdutoOrcamento
        public DataTable ConsutarProdutoOrcamento()
        {
            try
            {
                DataTable tabProduto = new DataTable();
                string sql = @"select * from tb_produtos";

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabProduto);

                connection.Close();
                return tabProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                this.connection.Close();
                return null;
            }
        }
        #endregion

        #region EditarProduto
        /// <summary>
        /// Método que edita as informações do obj dentro do
        /// </summary>
        /// <param name="obj"></param>
        public void EditarProduto(Produto obj)
        {
            try
            {

                string sql = @"update tb_produtos set descricao_completa=@descricao_com,descricao_resumida=@descricao_resu,preco_vista=@preco_vista,preco_prazo=@preco_prazo,
                valor_entrada=@valor_entrada,valor_total=@valor_total,quantidade=@qtd_estoque,unid_medida=@unid_medida,for_id=@for_id where id=@id";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);

                cmdSql.Parameters.AddWithValue("@descricao_com", obj.DescricaoCompleta);
                cmdSql.Parameters.AddWithValue("@descricao_resu", obj.DescricaoResumida);
                cmdSql.Parameters.AddWithValue("@preco_vista", obj.PrecoVista);
                cmdSql.Parameters.AddWithValue("@preco_prazo", obj.PrecoPrazo);
                cmdSql.Parameters.AddWithValue("@valor_entrada", obj.ValorEntrada);
                cmdSql.Parameters.AddWithValue("@valor_total", obj.ValorTotal);
                cmdSql.Parameters.AddWithValue("@qtd_estoque", obj.Quantidade);
                cmdSql.Parameters.AddWithValue("@unid_medida", obj.UniMedida);
                cmdSql.Parameters.AddWithValue("@data_entrada", obj.Data);
                cmdSql.Parameters.AddWithValue("@hora_entrada", obj.Hora);
                //cmdSql.Parameters.AddWithValue("@imagem", obj.Imagem);
                cmdSql.Parameters.AddWithValue("@for_id", obj.CodigoFornecedor);
                cmdSql.Parameters.AddWithValue("@id", obj.Codigo);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"O produto {obj.DescricaoResumida} foi editado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo: {ex.Message} com o caminnho para {ex.StackTrace}");
            }

        }
        #endregion

        #region ExcluirProduto
        /// <summary>
        /// Método que exclui o obj do banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void ExcluirProduto(Produto obj)
        {
            try
            {
                string sql = "delete from tb_produtos where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", obj.Codigo);

                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto foi excluido com sucesso!");

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region BuscarNome
        /// <summary>
        /// Função que busca o obj no banco de dados
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Retorna um produto de acordo com a descrição</returns>
        public DataTable BuscarProduto(string nome)
        {
            try
            {
                DataTable tabProdutos = new DataTable();
                string sql = "select * from tb_produtos where descricaoResumida = @descricao";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@descricao", nome);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabProdutos);

                connection.Close();

                return tabProdutos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region ListarProdutoNome
        /// <summary>
        /// Função que pesquisa o obj deacordo com o que o usuário digita
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Retorna o obj que está no banco de dados</returns>
        public DataTable ListarProdutoNome(string nome)
        {
            try
            {
                DataTable tabProdutos = new DataTable();
                string sql = "select * from bdvendas.tb_produtos where descricao like @descricao";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@descricao", nome);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabProdutos);

                connection.Close();
                return tabProdutos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como caminho {ex.StackTrace}");
                return null;
            }
        }
        #endregion
         
        #region BuscarProdutoVenda
        /// <summary>
        /// Função que pesquisa obj com id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna o obj</returns>
        public Produto BuscarProdutoVenda(int id)
        {
            try
            {
                Produto obj = new Produto();
                string sql = "select * from tb_produtos where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    obj.Codigo = dr.GetInt32("id");
                    obj.DescricaoResumida = dr.GetString("descricao_resumida");
                    obj.Quantidade = dr.GetInt32("quantidade");
                    obj.UniMedida = dr.GetString("unid_medida");
                    obj.PrecoVista = dr.GetDecimal("preco_vista");
                    obj.PrecoPrazo = dr.GetDecimal("preco_prazo");
                    //obj.Imagem = dr.GetByte("imagem");

                    connection.Close();
                    return obj;
                }
                else
                {
                    MessageBox.Show($"Por favor digite um código válido!");
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region ControlarEstoque
        /// <summary>
        /// Método que atualiza o estoque, baseado no Id
        /// </summary>
        /// <param name="idProduto">Id do obj</param>
        /// <param name="estoque">Quantidade que tem no estoque</param>
        public void ControlarEstoque(int idProduto, int estoque)
        {
            try
            {
                string sql = "update tb_produtos set quantidade = @estoque where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@estoque", estoque);
                cmd.Parameters.AddWithValue("@id", idProduto);

                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A conteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                connection.Close();
            }
        }
        #endregion

        #region RetornarEstoque
        /// <summary>
        /// Função que retorna a quantidade em estoque
        /// </summary>
        /// <param name="id">ID do produto</param>
        /// <returns>Retorna o ostoque atual</returns>
        public int RetornarEstoque(int id)
        {
            try
            {
                string sql = "select quantidade from tb_produtos where id = @id";
                int estoqueSaida = 0;

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                MySqlDataReader DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    estoqueSaida = DR.GetInt32("quantidade");
                    connection.Close();
                }

                return estoqueSaida;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com a mensagem {ex.StackTrace}");
                connection.Close();
                return 0;
            }
        }
        #endregion

        #region ConsultarProdutoNome
        public Produto ConsultarProdutoNome(int id)
        {
            try
            {
                Produto obj = new Produto();
                string sql = "select * from tb_produtos where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();

                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    obj.Codigo = rs.GetInt32("id");
                    obj.DescricaoResumida = rs.GetString("descricao_resumida");
                    obj.PrecoVista = rs.GetDecimal("preco_vista");
                    obj.PrecoPrazo = rs.GetDecimal("preco_prazo");
                    obj.Quantidade = rs.GetInt32("quantidade");

                    connection.Close();
                    return obj;
                }
                else
                {
                    MessageBox.Show("Protoduto não encontrado!");
                    connection.Close();
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                connection.Close();
                return null;
            }
        }
        #endregion
    }
}
