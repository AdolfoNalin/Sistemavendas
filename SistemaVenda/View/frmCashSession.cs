using Org.BouncyCastle.Tls;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Model;
using SistemaVenda.Service;
using System;
using System.ComponentModel;
using System.Fabric.Management.ServiceModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmCashSession : Form
    {
        public frmCashSession()
        {
            InitializeComponent();
        }

        private Sale _sale = new Sale();
        private bool _isOpen = false;
        private CashSession _cash = new CashSession();
        private decimal _total = 0;

        #region UpateDataSale
        public async void UpdateDataSale()
        {
            try
            {
                BindingList<Sale> sales = await SaleService.GetCash(_cash.Id);
                dgSale.DataSource = sales;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region UpdateDataCashSessionEnable
        private async void UpdateDataCashSessionEnable()
        {
            try
            {
                BindingList<CashSession> cashs = new BindingList<CashSession>();

                if (rbAll.Checked)
                {
                    UpdateDataCashSession();
                }
                else if (rbEnable.Checked)
                {
                    cashs = await CashSessionService.GetEnable(Enable.Habilitado);
                }
                else if (rbDisabel.Checked)
                {
                    cashs = await CashSessionService.GetEnable(Enable.Desabilitado);
                }

                cashs = Helpers.SwitchEnabel(cashs);

                dgCashSession.DataSource = cashs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region UpdateDataCashSession
        public async void UpdateDataCashSession()
        {
            try
            {
                BindingList<CashSession> cashDescks = await CashSessionService.Get();

                BindingList<CashSession> cashs = Helpers.SwitchEnabel(cashDescks);

                dgCashSession.DataSource = cashs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message},{ex.StackTrace},{ex.HelpLink}");
            }
        }
        #endregion

        #region UpdateDetails
        private void UpdateDetails()
        {
            if (dgCashSession.SelectedRows.Count > 0)
            {
                _cash = dgCashSession.SelectedRows[0].DataBoundItem as CashSession;
            }
        }
        #endregion

        #region btnExit_Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateDataCashSession();
            tabCashDesck.SelectedTab = tpConsult;
        }
        #endregion

        #region btnOpenCashSession_Click
        private void btnOpenCashSession_Click(object sender, EventArgs e)
        {
            try
            {
                _isOpen = true;
                Helpers.ClearScreen(this);
                mtbDate.Text = DateTime.UtcNow.ToString();
                tabCashDesck.SelectedTab = tpDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region Load
        private async void frmCashSession_Load(object sender, EventArgs e)
        {
            try
            {
                cbUser.DataSource = await UserService.Get();
                cbUser.ValueMember = "id";
                cbUser.DisplayMember = "name";

                rbAll.Checked = true;

                dgCashSession.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "id",
                    HeaderText = "Código",
                });

                dgCashSession.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "UserId",
                    HeaderText = "Usuário",
                });

                dgCashSession.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Date",
                    HeaderText = "Data",
                });

                dgCashSession.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "OpeningAmount",
                    HeaderText = "Valor de entrada",
                });

                dgCashSession.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Enable",
                    HeaderText = "Habilitado",
                });

                dgCashSession.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Status",
                    HeaderText = "Status",
                });

                dgCashSession.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Total",
                    HeaderText = "Total",
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Id",
                    HeaderText = "Código"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ClientId",
                    HeaderText = "Cliente"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Date",
                    HeaderText = "Data"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "EmployeeId",
                    HeaderText = "Funcionário"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "PaymentMethod",
                    HeaderText = "Forma de Pagamento"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "PercentageDiscount",
                    HeaderText = "Desconto Porcentagem"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "CashDiscount",
                    HeaderText = "Desconto Dinheiro"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "AdditionPorcentage",
                    HeaderText = "Adicionar Porcentagem"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "AdditionCash",
                    HeaderText = "Adicionar Dinheiro"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Total",
                    HeaderText = "Total"
                });

                dgSale.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Observation",
                    HeaderText = "Observação"
                });

                dgCashSession.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgCashSession.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnCloseCash_Click
        private async void btnCloseCash_Click(object sender, EventArgs e)
        {
            try
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if(screen.user.User != null)
                {
                    _isOpen = false;

                    UpdateDetails();
                    if (_cash.Status == IsCashSession.Close)
                    {
                        MessageBox.Show("Caixa selecionado, já está fechado!");
                    }
                    else
                    {
                        _cash.Status = IsCashSession.Close;

                        CashSessionService.Put(_cash);
                        if (_cash.Id == CashDesck.Id)
                        {
                            CashDesck.Status = IsCashSession.Close;
                        }
                        await Task.Delay(800);
                        UpdateDataCashSession();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnSave_Click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if(screen.user != null)
                {
                    if (!String.IsNullOrEmpty(txtEntryValue.Text))
                    {
                        Guid.TryParse(cbUser.SelectedValue.ToString(), out Guid userId);

                        IsCashSession isCash = IsCashSession.Close;
                        Enable enable = Enable.Enable;

                        if (cbStatus.Text.Equals("Aberto"))
                        {
                            isCash = IsCashSession.Open;
                        }
                        else
                        {
                            MessageBox.Show("Não é possivél deixar o caixa fechado");
                        }

                        if (cbEnabel.Text.Equals("Habilitado"))
                        {
                            enable = Enable.Enable;
                        }
                        else if (cbEnabel.Text.Equals("Desabilidado"))
                        {
                            enable = Enable.Disabel;
                        }

                        _cash = new CashSession()
                        {
                            UserId = screen.user.User.Id,
                            OpeningAmount = _total,
                            Date = DateTime.UtcNow,
                            Status = isCash,
                            Enable = enable,
                            Total = _total
                        };

                        if (_isOpen)
                        {
                            CashSessionService.Post(_cash);

                            await Task.Delay(800);
                            BindingList<CashSession> cashs = await CashSessionService.Get()
                                ?? throw new ArgumentNullException("Nenhum caixa foi encontrado");
                            _cash = null;
                            _cash = cashs.LastOrDefault();

                            CashDesck.Id = _cash.Id;
                            CashDesck.UserId = _cash.UserId;
                            CashDesck.Date = _cash.Date;
                            CashDesck.OpeningAmount = _cash.OpeningAmount;
                            CashDesck.Enable = _cash.Enable;
                            CashDesck.Status = _cash.Status;
                            CashDesck.Total = _cash.Total;

                            await Task.Delay(800);
                            btnCancel_Click(sender, e);
                        }
                        else
                        {
                            CashSessionService.Put(_cash);
                            await Task.Delay(800);
                            btnCancel_Click(sender, e);
                        }
                    }
                    else
                    {
                        throw new ArgumentNullException("É necessário ter o valor de entrada");
                    }
                }
                
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message, "ATENÇÃO");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region rbEnable_CheckedChanged
        private void rbEnable_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataCashSessionEnable();
        }
        #endregion

        #region rbDisabel_CheckedChanged
        private void rbDisabel_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataCashSessionEnable();
        }
        #endregion

        #region rbAll_CheckedChanged
        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataCashSession();
        }
        #endregion

        #region btnEnable_Click
        private async void btnEnable_Click(object sender, EventArgs e)
        {
            try
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if(screen.user.User != null)
                {
                    UpdateDetails();

                    _cash.Enable = Enable.Disabel;

                    CashSessionService.Enable(_cash);

                    await Task.Delay(800);
                    btnCancel_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btndetails_click
        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDetails();
                txtId.Enabled = false;
                cbUser.Enabled = false;
                cbUser.DisplayMember = "login";

                txtId.Text = _cash.Id.ToString();
                cbUser.SelectedValue = _cash.UserId;
                txtEntryValue.Text = _cash.OpeningAmount.ToString();
                cbEnabel.SelectedIndex =  _cash.Enable == Enable.Habilitado ? (int) Enable.Enable : (int) Enable.Disabel;
                cbStatus.SelectedIndex = _cash.Status == IsCashSession.Aberto ? (int) IsCashSession.Open : (int) IsCashSession.Close ;
                txtTotal.Text = _cash.Total.ToString();

                UpdateDataSale();

                tabCashDesck.SelectedTab = tpDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region txtEntryValue_KeyDown
        private void txtEntryValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _total = Decimal.Parse(txtEntryValue.Text);

                txtEntryValue.Text = txtEntryValue.Text.Insert(0, "R$");
                txtEntryValue.Text = txtEntryValue.Text.Insert(txtEntryValue.Text.Count(), ",00");

                txtTotal.Text = txtEntryValue.Text;

                cbEnabel.SelectedIndex = 0;
                cbStatus.SelectedIndex = 0;
            }
        }
        #endregion

        #region btnSearchDate_Click
        private async void btnSearchDate_Click(object sender, EventArgs e)
        {
            dgCashSession.DataSource = await CashSessionService.Get(startDate: DateTime.Parse(dtpStartDate.Text), endDate: DateTime.Parse(dtpEndDate.Text));
        }
        #endregion

        #region btnSearch_Click
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string value = txtSearch.Text;

                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Digite no campo ao lado para ter um resultado");
                }
                else
                {
                    dgCashSession.DataSource = await CashSessionService.GetEmployee(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region txtSearch_KeyDown
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
        #endregion

        #region btnCashout_Click
        private void btnCashout_Click(object sender, EventArgs e)
        {
            frmPassword screen = new frmPassword();
            screen.ShowDialog();

            if(screen.user.User != null)
            {

        
            }
        }
        #endregion

        #region btnAddCash_Click
        private void btnAddCash_Click(object sender, EventArgs e)
        {
            frmPassword screen = new frmPassword();
            screen.ShowDialog();

            if (screen.user.User != null)
            {

            }
        }
        #endregion

        #region dgCashSession_KeyDown
        private void dgCashSession_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dgCashSession = Helpers.UpOrDown(e, dgCashSession);
            }
            else if(e.KeyCode == Keys.Enter)
            {
                UpdateDetails();
                btnDetails_Click(sender, e);
            }
        }
        #endregion
    }
}
