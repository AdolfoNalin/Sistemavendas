using MySqlX.XDevAPI;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Service;
using SistemaVenda.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmSupplier : Form
    {
        private bool _update = false;
        public frmSupplier()
        {
            InitializeComponent();
        }

        #region UpdateData
        private async void UpdateData()
        {
            List<Supplier> suppliers = null;
            suppliers = await SupplierService.Get();
            dgSupplier.DataSource = suppliers;
        }

        #endregion

        #region UpdateDetails
        private void UpdateDetails()
        {
            Supplier supplier = null;

            if (dgSupplier.SelectedRows.Count > 0)
            {
                supplier = (Supplier)dgSupplier.SelectedRows[0].DataBoundItem;

                txtCodigo.Text = supplier.Id.ToString();
                txtNome.Text = supplier.Name.ToString();
                txtApelido.Text = supplier.CompanyName.ToString();
                mtbIE.Text = supplier.IE.ToString();
                mtbCNPJ.Text = supplier.CNPJ.ToString();
                mtbCelular.Text = supplier.PhoneNumber.ToString();
                mtbTelefone.Text = supplier.TelephoneNumber.ToString();
                txtEmail.Text = supplier.Email.ToString();
                mtbCEP.Text = supplier.CEP.ToString();
                txtLogradouro.Text = supplier.Street.ToString();
                txtNumero.Text = supplier.Number.ToString();
                txtBairro.Text = supplier.Neighborhoods.ToString();
                txtCidade.Text = supplier.City.ToString();
                cbUF.Text = supplier.State.ToString();
                txtComplemento.Text = supplier.Complement?.ToString();
            }
        }
        #endregion

        #region Load
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "Código"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Nome"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CompanyName",
                HeaderText = "Empresa"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IE",
                HeaderText = "IE"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "RG",
                HeaderText = "RG"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DueDate",
                HeaderText = "Data de Nascimento"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PhoneNumber",
                HeaderText = "Celular"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TelephoneNumber",
                HeaderText = "Telefone"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CEP",
                HeaderText = "CEP"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "State",
                HeaderText = "Estado"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "City",
                HeaderText = "Cidade"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Neighborhoods",
                HeaderText = "Bairro"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Street",
                HeaderText = "Rua"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Number",
                HeaderText = "Número"
            });

            dgSupplier.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Complement",
                HeaderText = "Complemento"
            });

            UpdateData();

            dgSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSupplier.MultiSelect = false;
        }
        #endregion

        #region btnNew_Click
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            mtbCNPJ.Enabled = true;
            mtbIE.Enabled = true;
            tabSupplier.SelectedTab = tpDetails;
            Helpers.ClearScreen(this);
            _update = false;

            if (!_update)
            {
                mtbCNPJ.Enabled = true;
                mtbIE.Enabled = true;
            }
        }
        #endregion

        #region btnUpdate_Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            mtbCNPJ.Enabled = false;
            mtbIE.Enabled = false;

            _update = true;

            tabSupplier.SelectedTab = tpDetails;
        }
        #endregion

        #region btnSave_Click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            frmPassword screen = new frmPassword();
            screen.ShowDialog();

            if (screen.user.User != null)
            {
                Supplier supplier = new Supplier()
                {
                    Name = txtNome.Text,
                    CompanyName = txtApelido.Text,
                    Email = txtEmail.Text,
                    CNPJ = mtbCNPJ.Text,
                    IE = mtbIE.Text,
                    PhoneNumber = mtbCelular.Text,
                    TelephoneNumber = mtbTelefone.Text,
                    CEP = mtbCEP.Text,
                    State = cbUF.Text,
                    City = txtCidade.Text,
                    Street = txtLogradouro.Text,
                    Neighborhoods = txtBairro.Text,
                    Number = int.Parse(txtNumero.Text),
                    Complement = txtComplemento.Text,
                };

                if (supplier == null)
                {
                    throw new NullReferenceException("O fornecedor é nulo");
                }

                if (_update)
                {
                    supplier.Id = Guid.Parse(txtCodigo.Text ?? throw new ArgumentNullException("Código é nulo, verifique o fornecedor"));
                    SupplierService.Put(supplier);
                }
                else
                {
                    SupplierService.Post(supplier);
                }

                await Task.Delay(1500);
                UpdateData();
                tabSupplier.SelectedTab = tpConsult;
            }
        }
        #endregion

        #region btnExit_Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region btnCancel_click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
            tabSupplier.SelectedTab = tpConsult;
            UpdateData();
        }
        #endregion

        #region btnDelete_click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            frmPassword screen = new frmPassword();
            screen.ShowDialog();

            if (screen.user.User != null)
            {
                if (dgSupplier.SelectedRows.Count > 0)
                {
                    supplier = (Supplier)dgSupplier.SelectedRows[0].DataBoundItem;

                    SupplierService.Delete(supplier.Id);

                    await Task.Delay(1500);
                    UpdateData();
                    tabSupplier.SelectedTab = tpConsult;
                }
            }
        }
        #endregion

        #region mtbCEP_KeyPress
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                City city = SearchCEP.SearchCity(mtbCEP.Text);

                if (city != null)
                {
                    cbUF.Text = city.UF;
                    txtCidade.Text = city.Name;
                    txtBairro.Text = city.Neighborhood;
                    txtLogradouro.Text = city.Street;
                }
                else
                {
                    MessageBox.Show("CEP não encontrado");
                }
            }
        }
        #endregion

        #region txtSearch_KeyPress
        private async void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            await Task.Delay(800);

            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                await Task.Delay(1500);
                UpdateData();
            }
            else
            {
                await Task.Delay(800);
                List<Supplier> suppliers = await SupplierService.Get(txtSearch.Text);
                dgSupplier.DataSource = suppliers;
            }
        }
        #endregion

        #region btnSearch_Click
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await Task.Delay(800);

            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                await Task.Delay(1500);
                UpdateData();
            }
            else
            {
                await Task.Delay(800);
                List<Supplier> suppliers = await SupplierService.Get(txtSearch.Text);
                dgSupplier.DataSource = suppliers;
            }
        }
        #endregion

        #region dgSupplier_KeyDown
        private void dgSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) 
            {
                dgSupplier = Helpers.UpOrDown(e, dgSupplier);
            }
            else if(e.KeyCode == Keys.Enter)
            {
                UpdateDetails();
                btnUpdate_Click(sender, e);
            }
        }
        #endregion
    }
}
