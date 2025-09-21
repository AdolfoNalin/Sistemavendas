using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Service;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmProduct : Form
    {
        private bool _update = false;

        public frmProduct()
        {
            InitializeComponent();
            UpdateData();
        }

        #region UpdateData
        private async void UpdateData()
        {
            try
            {
                List<Product> products = await ProductService.Get();
                dgProduct.DataSource = products;
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }

        #endregion

        #region UpdateDetails
        private void UpdateDetails()
        {
            if (dgProduct.SelectedRows.Count > 0)
            {
                Product product = (Product)dgProduct.SelectedRows[0].DataBoundItem;

                mtbDate.Text = product.Date.ToString("dd/MM/yyyy");
                txtId.Text = product.Id.ToString();
                txtShortDescription.Text = product.ShortDescription;
                txtFullDescription.Text = product.FullDescription;
                mtbCashPrice.Text = product.CashPrice.ToString();
                mtbTermPrice.Text = product.TermPrice.ToString();
                mtbEntryPrice.Text = product.EntryPrice.ToString();
                txtAmount.Text = product.Amount.ToString();
                mtbTotalPrice.Text = product.TotalPrice.ToString();
                cbUniMeasure.Text = product.UniMeasure;
            }
        }
        #endregion

        #region Load
        private async void frmProduct_Load(object sender, EventArgs e)
        {
            mtbDate.Text = DateTime.Now.ToString("dd/mm/yyyy");

            cbSuppliers.DataSource = await SupplierService.Get();
            cbSuppliers.ValueMember = "id";
            cbSuppliers.DisplayMember = "name";
        }
        #endregion

        #region dgProduct_SelectionChanged
        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }
        #endregion

        #region btnExit_Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btnCancel_click
        private async void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateData();
            btnNew_Click(sender, e);
            await Task.Delay(800);
            tabProduct.SelectedTab = tpConsult;
        }
        #endregion

        #region btnSave_Click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime.TryParse(mtbDate.Text, out DateTime dt);
                Guid.TryParse(cbSuppliers.SelectedValue.ToString() ?? throw new ArgumentNullException("Fornecedor precisa ser selecionado"), out Guid supplierId);
                Product product = new Product()
                {
                    SupplierId = supplierId,
                    FullDescription = txtFullDescription.Text ?? throw new ArgumentNullException("Digite uma Descrição completa para o produto"),
                    ShortDescription = txtShortDescription.Text ?? throw new ArgumentNullException("Digite uma Descrição resumida para o produto"),
                    UniMeasure = cbUniMeasure.Text ?? throw new ArgumentNullException("Digite a unidade de mediade"),
                    Amount = Double.Parse(txtAmount.Text ?? throw new ArgumentNullException("Digite a quantidade")),
                    EntryPrice = Decimal.Parse(mtbEntryPrice.Text ?? throw new ArgumentNullException("Digite o preço de entrada")),
                    CashPrice = Decimal.Parse(mtbCashPrice.Text ?? throw new ArgumentNullException("Digite o preço á vista")),
                    TermPrice = Decimal.Parse(mtbTermPrice.Text ?? throw new ArgumentNullException("Digite o preço á prazo")),
                    TotalPrice = Decimal.Parse(mtbTotalPrice.Text),
                    Date = dt.ToUniversalTime(),
                };

                if (product is null)
                {
                    throw new ArgumentException("Preencha todos os campos");
                }
                else
                {
                    if (_update is false)
                    {
                        ProductService.Post(product);
                        await Task.Delay(1500);
                        UpdateData();
                        tabProduct.SelectedTab = tpConsult;
                    }
                    else
                    {
                        product.Id = Guid.Parse(txtId.Text ?? throw new ArgumentNullException("Id do produto é obrigatório"));
                        ProductService.Put(product);
                        await Task.Delay(1500);
                        UpdateData();
                        tabProduct.SelectedTab = tpConsult;
                    }

                    await Task.Delay(1500);
                    UpdateData();
                    tabProduct.SelectedTab = tpConsult;
                }
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnUpdate_Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           _update = true;
            txtId.Enabled = false;
   
            tabProduct.SelectedTab = tpDetails;
        }
        #endregion

        #region btnDelete_Click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = (Product)dgProduct.SelectedRows[0].DataBoundItem ?? throw new ArgumentException("Selecione o produto que vai ser deletado");
                ProductService.Delete(product.Id);
                await Task.Delay(1000);
                UpdateData();
                tabProduct.SelectedTab = tpConsult;
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnNew_Click
        private void btnNew_Click(object sender, EventArgs e)
        {
            Helpers.ClearScreen(this);
            tabProduct.SelectedTab = tpDetails;
        }
        #endregion

        #region txtSearch_KeyPress
        private async void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            await Task.Delay(800);

            if(String.IsNullOrEmpty(txtSearch.Text))
            {
                await Task.Delay(800);
                UpdateData();
            }
            else
            {
                await Task.Delay(800);
                List<Product> products = await ProductService.Get(txtSearch.Text);
                dgProduct.DataSource = products;
            }
        }
        #endregion

        #region txtShortDescription_KeyPress
        private async void txtShortDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            await Task.Delay(800);
            txtFullDescription.Text = txtShortDescription.Text;
        }
        #endregion
    }
}
