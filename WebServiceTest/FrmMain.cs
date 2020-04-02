using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qiyubrother;

namespace WebServiceTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtParameter1.TextChanged += (o, ex) => { txtParameter2.ReadOnly = (o as TextBox).Text == string.Empty; };
            txtParameter2.TextChanged += (o, ex) => { txtParameter3.ReadOnly = (o as TextBox).Text == string.Empty; };
            txtParameter3.TextChanged += (o, ex) => { txtParameter4.ReadOnly = (o as TextBox).Text == string.Empty; };
            txtParameter4.TextChanged += (o, ex) => { txtParameter5.ReadOnly = (o as TextBox).Text == string.Empty; };
            txtParameter5.TextChanged += (o, ex) => { txtParameter6.ReadOnly = (o as TextBox).Text == string.Empty; };
            txtParameter6.TextChanged += (o, ex) => { txtParameter7.ReadOnly = (o as TextBox).Text == string.Empty; };
            txtParameter7.TextChanged += (o, ex) => { txtParameter8.ReadOnly = (o as TextBox).Text == string.Empty; };
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            var lstParameters = new List<string>();
            if (txtParameter1.Text != string.Empty)
            {
                lstParameters.Add(txtParameter1.Text);
            }
            if (!txtParameter2.ReadOnly && txtParameter2.Text != string.Empty)
            {
                lstParameters.Add(txtParameter2.Text);
            }
            if (!txtParameter3.ReadOnly && txtParameter3.Text != string.Empty)
            {
                lstParameters.Add(txtParameter3.Text);
            }
            if (!txtParameter4.ReadOnly && txtParameter4.Text != string.Empty)
            {
                lstParameters.Add(txtParameter4.Text);
            }
            if (!txtParameter5.ReadOnly && txtParameter5.Text != string.Empty)
            {
                lstParameters.Add(txtParameter5.Text);
            }
            if (!txtParameter6.ReadOnly && txtParameter6.Text != string.Empty)
            {
                lstParameters.Add(txtParameter6.Text);
            }
            if (!txtParameter7.ReadOnly && txtParameter7.Text != string.Empty)
            {
                lstParameters.Add(txtParameter7.Text);
            }
            if (!txtParameter8.ReadOnly && txtParameter8.Text != string.Empty)
            {
                lstParameters.Add(txtParameter8.Text);
            }
            try
            {
                var rst = WebServiceHelper.CallMethod(txtUrl.Text, txtMethod.Text, lstParameters.ToArray());
                txtResult.Text = rst;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtResult.Clear();
            }
        }
    }
}
