using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Model;
using SistemaVenda.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmItemReturn : Form
    {
        public frmItemReturn()
        {
            InitializeComponent();
        }

        #region UpdateData
        private async void UpdateData()
        {
            dgItemReturn.DataSource = await ItemReturnService.Get();
        }
        #endregion

        #region UpdateDetailsReturn
        private void UpdateDetailsReturn()
        {
            if (dgItemReturn.SelectedRows.Count > 0)
            {
                ItemReturn item = dgItemReturn.SelectedRows[0].DataBoundItem as ItemReturn;
            }
        }
        #endregion

        #region UpdateDetailsSale
        private async void UpdateDetailsSale()
        {
            if (dgSale.SelectedRows.Count > 0)
            {
                Sale sale = dgSale.SelectedRows[0].DataBoundItem as Sale;

                BindingList<ProductShoppingCar> proCarSh = new BindingList<ProductShoppingCar>();

                Client client = await ClientService.Get(sale.ClientId);

                User user = await UserService.GetEmployee(sale.EmployeeId);

                BindingList<ItemSale> itens = await ItemSaleService.Get(sale.Id);

                string address = Helpers.Address(client);

                txtId.Text = sale.Id.ToString();
                txtClientId.Text = client.Id.ToString();
                txtName.Text = client.Name;
                mtbCPF.Text = client.CPF;
                txtAddress.Text = Helpers.Address(client);
                mtbPhone.Text = client.PhoneNumber;
                mtbAdditionCash.Text = sale.AdditionCash.ToString();
                mtbAdditionPorcentage.Text = sale.AdditionPorcentage.ToString();
                mtbCashDiscount.Text = Convert.ToString(sale.CashDiscount);
                mtbPercentageDiscount.Text = sale.PercentageDiscount.ToString();
                txtTotal.Text = sale.Total.ToString();

                cbUsers.Text = user.Login;

                foreach (var item in itens)
                {
                    ProductShoppingCar car = new ProductShoppingCar();
                    Product product = await ProductService.Get(item.ProductId);

                    car.ShortDescription = product.ShortDescription;
                    car.Amount = item.Amount;
                    car.CashPrice = product.CashPrice;
                    car.TermPrice = product.TermPrice;
                    car.TotalPrice = item.Subtotal;

                    proCarSh.Add(car);
                }

                dgShoppingCar.DataSource = proCarSh;
            }
        }
        #endregion

        #region dgSale_SelectionChanged
        private void dgSale_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetailsSale();
        }
        #endregion

        #region dgItemReturn_SelectionChanged
        private void dgItemReturn_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetailsReturn();
        }
        #endregion
    }
}
