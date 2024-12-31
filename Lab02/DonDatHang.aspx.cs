using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class DonDatHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlLoaiBanh.Items.Add(new ListItem("Bánh Rán"));
                ddlLoaiBanh.Items.Add(new ListItem("Bán Su Kem"));
                ddlLoaiBanh.Items.Add(new ListItem("Bánh Bông Lan"));
                ddlLoaiBanh.Items.Add(new ListItem("Bánh Bông Lan Trứng Muối"));
                ddlLoaiBanh.Items.Add(new ListItem("Bánh Mỳ"));
                ddlLoaiBanh.Items.Add(new ListItem("Bánh Tổ Ong"));
                ddlLoaiBanh.Items.Add(new ListItem("Bánh Kem"));
                ddlLoaiBanh.Items.Add(new ListItem("Bánh Sandwith"));
            }
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            string kq = "<div class='h3 text-center'>HÓA ĐƠN ĐẶT HÀNG</div>";
            kq += "<div class='border' style='padding: 10px; border: 1px solid #000;'>";

            // Thu thập thông tin đơn hàng
            kq += string.Format("<p><b>Khách hàng:</b> {0}</p>", txtKhachHang.Text);
            kq += string.Format("<p><b>Địa chỉ:</b> {0}</p>", txtDiaChi.Text);
            kq += string.Format("<p><b>Mã số thuế:</b> {0}</p>", txtMaSoThue.Text);
            kq += "<p><b>Đặt các loại bánh sau:</b></p>";

            // Tạo bảng hiển thị danh sách bánh
            kq += "<table style='width: 100%; border-collapse: collapse;' border='1'>";
            kq += "<tr><th>Tên bánh</th><th>Số lượng</th></tr>";
            foreach (ListItem item in lstBanh.Items)
            {
                string[] details = item.Text.Split('(');
                string tenBanh = details[0].Trim(); // Tên bánh
                string soLuong = details[1].Replace(")", "").Trim(); // Số lượng

                // Thêm hàng vào bảng
                kq += string.Format("<tr><td>{0}</td><td>{1}</td></tr>", tenBanh, soLuong);
            }
            kq += "</tbody></table>";
            kq += "</div>";

            // Hồi đáp thông tin đơn hàng
            LblHoadon.Text = kq;
            LblHoadon.Visible = true;

        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            for(int i= lstBanh.Items.Count -1;i>=0; i--)
            {
                if(lstBanh.Items[i].Selected)
                {
                    lstBanh.Items.RemoveAt(i);
                }    
            }    

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string tenbanh = ddlLoaiBanh.SelectedItem.Text;
            int soluong = int.Parse(txtSoLuong.Text);
            string kq = string.Format("{0} ({1})", tenbanh, soluong);
            lstBanh.Items.Add(kq);
        }
    }
}