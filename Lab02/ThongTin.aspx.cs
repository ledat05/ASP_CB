using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class ThongTin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddlTrinhDo.Items.Add(new ListItem("Cao Đẳng", "CD"));
                ddlTrinhDo.Items.Add(new ListItem("Đại Học", "DH"));
                ddlTrinhDo.Items.Add(new ListItem("Sau Đại Học", "SDH"));


                lstNgheNghiep.Items.Add(new ListItem("Kỹ Sư", "KySu"));
                lstNgheNghiep.Items.Add(new ListItem("Giáo Viên", "GiaoVien"));
                lstNgheNghiep.Items.Add(new ListItem("Bác Sĩ", "BacSi"));
                lstNgheNghiep.Items.Add(new ListItem("Lập Trình Viên", "LapTrinhVien"));


                cblSoThich.Items.Add(new ListItem("Đọc Sách", "DocSach"));
                cblSoThich.Items.Add(new ListItem("Thể Thao", "TheThao"));
                cblSoThich.Items.Add(new ListItem("Du Lịch", "DuLich"));
                cblSoThich.Items.Add(new ListItem("Âm Nhạc", "AmNhac"));
            }
        }

        protected void btnGui_Click(object sender, EventArgs e)
        {
            try
            {

                string hoTen = txtHoTen.Text.Trim();
                string ngaySinh = txtNgaySinh.Text;
                string gioiTinh = rblGioiTinh.SelectedValue;
                string trinhDo = ddlTrinhDo.SelectedItem.Text;
                string ngheNghiep = lstNgheNghiep.SelectedItem?.Text ?? "Không chọn";

                var soThich = cblSoThich.Items.Cast<ListItem>()
                    .Where(item => item.Selected)
                    .Select(item => item.Text);
                string soThichText = string.Join(", ", soThich);


                string fileName = "Không có hình";
                if (fuHinh.HasFile)
                {
                    fileName = Path.GetFileName(fuHinh.FileName);
                    string uploadFolder = Server.MapPath("~/Uploads/");
                    if (!Directory.Exists(uploadFolder))
                    {
                        Directory.CreateDirectory(uploadFolder);
                    }
                    string filePath = Path.Combine(uploadFolder, fileName);
                    fuHinh.SaveAs(filePath);
                }


                lblResult.Text = $@"
                    <div class='p-3 border rounded bg-light'>
                        <h4 class='text-success'>Kết quả đăng ký</h4>
                        <p><strong>Họ và tên:</strong> {hoTen}</p>
                        <p><strong>Ngày sinh:</strong> {ngaySinh}</p>
                        <p><strong>Giới tính:</strong> {gioiTinh}</p>
                        <p><strong>Trình độ:</strong> {trinhDo}</p>
                        <p><strong>Nghề nghiệp:</strong> {ngheNghiep}</p>
                        <p><strong>Sở thích:</strong> {soThichText}</p>
                        <p><strong>Ảnh:</strong></p>
                        <img src='/Uploads/{fileName}' alt='Uploaded Image' class='img-thumbnail' style='max-width: 200px;' />
                    </div>";
                lblResult.CssClass = "mt-3";
            }
            catch (Exception ex)
            {
                lblResult.Text = $"<p class='text-danger'>Đã xảy ra lỗi: {ex.Message}</p>";
                lblResult.CssClass = "mt-3";
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
            rblGioiTinh.ClearSelection();
            ddlTrinhDo.ClearSelection();
            lstNgheNghiep.ClearSelection();
            foreach (ListItem item in cblSoThich.Items)
            {
                item.Selected = false;
            }
            lblResult.Text = string.Empty;
        }

    }
}