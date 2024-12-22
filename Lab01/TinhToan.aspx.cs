using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class TinhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCong_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);
            int ketQua = so1 + so2;
            lblResult.Text = ketQua.ToString();
        }

        protected void btnTru_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);
            int ketQua = so1 - so2;
            lblResult.Text = ketQua.ToString();
        }

        protected void btnNhan_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);
            int ketQua = so1 * so2;
            lblResult.Text = ketQua.ToString();
        }

        protected void btnChia_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);
            if (so2 != 0)
            {
                int ketQua = so1 / so2;
                lblResult.Text = ketQua.ToString();
            }
            else
            {
                lblResult.Text = "Không thể chia cho 0";
            }
        }
    }
}