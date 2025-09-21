using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmScreenAuthorization : Form
    {
        public frmScreenAuthorization()
        {
            InitializeComponent();
        }

        public static List<CheckBox> checkBoxes = null;

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region chbAllCheck_CheckedChanged
        private void chbAllCheck_CheckedChanged(object sender, EventArgs e)
        {
            List<CheckBox> checkBoxs = new List<CheckBox>();
            checkBoxs.Add(chbSettings);
            checkBoxs.Add(chbUser);
            checkBoxs.Add(chbClient);
            checkBoxs.Add(chbEmployee);
            checkBoxs.Add(chbSupplier);
            checkBoxs.Add(chbProduct);
            checkBoxs.Add(chbSale);
            checkBoxs.Add(chbPaymentService);
            checkBoxs.Add(chbItemReturn);
           
            try
            {
                if (chbAllCheck.Checked)
                {
                    checkBoxs.All(x => x.Checked = true);
                }
                else
                {
                    checkBoxs.ForEach(x => x.Checked = false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.StackTrace}");
            }
        }
        #endregion

        #region btnNext_Click
        private void btnNext_Click(object sender, EventArgs e)
        {
            List<CheckBox> list = new List<CheckBox>
            {
                
                chbUser,
                chbClient,
                chbEmployee,
                chbSupplier,
                chbProduct,
                chbSale,
                chbPaymentService,
                chbItemReturn,
                chbSettings,
            };

            checkBoxes = list.Where(x => x.CheckState == CheckState.Checked).ToList();
            this.Hide();
        }
        #endregion
    }
}
