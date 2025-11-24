using Microsoft.Extensions.Logging;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Model;
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
            //UpdateData();
        }

        #region UpdateData
        private async void UpdateData()
        {
            try
            {
                BindingList<Product> products = await ProductService.Get();
                foreach(var p in products)
                {
                    List<Supplier> suppliers = await SupplierService.Get(p.SupplierId);
                    p.Supplier = suppliers.FirstOrDefault();
                }

                dgProduct.DataSource = products.Select(p => new ProductDTO()
                {
                    Id = p.Id,
                    SupplierName = p.Supplier.CompanyName,
                    ShortDescription = p.ShortDescription,
                    Amount = p.Amount,
                    EntryPrice = p.EntryPrice,
                    UniMeasure = p.UniMeasure,
                    TotalPrice = p.TotalPrice,
                    Date = p.Date,
                }).ToList();
            }
            catch (ArgumentNullException ane)
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
        private async void UpdateDetails()
        {
            if (dgProduct.SelectedRows.Count > 0)
            {
                Guid.TryParse(dgProduct.SelectedRows[0].Cells[0].Value.ToString(), out Guid id);

                Product product = await ProductService.Get(id);

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
            cbUniMeasure.SelectedIndex = 3;
    
            mtbDate.Text = DateTime.Today.ToString("dd/M/yyyy");

            cbSuppliers.DataSource = await SupplierService.Get();
            cbSuppliers.ValueMember = "id";
            cbSuppliers.DisplayMember = "CompanyName";

            dgProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "Código"
            });

            dgProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "SupplierName",
                HeaderText = "Fornecedor"
            });

            dgProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ShortDescription",
                HeaderText = "Descrição Resumida"
            });

            dgProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Date",
                HeaderText = "Data"
            });

            dgProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "UniMeasure",
                HeaderText = "Unidade Medida"
            });

            dgProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "EntryPrice",
                HeaderText = "Preço de entrada"
            });

            dgProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Amount",
                HeaderText = "Quantidade"
            });

            dgProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "Total"
            });

            UpdateData();

            dgProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProduct.MultiSelect = false;
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
            mtbDate.Text = DateTime.Today.ToString("dd/M/yyyy");
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

        #region dgProduct_KeyDown
        private void dgProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                Helpers.UpOrDown(e, dgProduct);
            }
            else if(e.KeyCode == Keys.Enter)
            {
                UpdateDetails();
                btnUpdate_Click(sender, e);
            }
        }
        #endregion

        #region txtAmount_KeyDown
        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    Decimal.TryParse(mtbCashPrice.Text, out decimal cashPrice);
                    Decimal.TryParse(mtbEntryPrice.Text, out decimal entryPrice);

                    decimal value = cashPrice - entryPrice;
                    decimal result = value * Decimal.Parse(txtAmount.Text);

                    mtbTotalPrice.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion
    }
}
