<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DonDatHang.aspx.cs" Inherits="Lab02.DonDatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đơn đặt hàng</title>
    <style>
        .form-container {
            width: 500px;
            margin: 0 auto;
            border: 1px solid #000;
            background-color:#EED5D2;
            padding: 10px;
            text-align: center;
        }
        .form-header {
            background-color: #FF99CC;
            padding: 5px;
            font-weight: bold;
        }
        .form-row {
            margin: 10px 0;
            text-align: left;
        }
        .form-row label {
            display: inline-block;
            width: 100px;
        }
        .form-actions {
            margin-top: 10px;

        }
        .form-footer{
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <div class="form-header">
                ĐƠN ĐẶT HÀNG
            </div>
            <div class="form-row">
                <label for="txtKhachHang">Khách hàng:</label>
                <asp:TextBox ID="txtKhachHang" runat="server" Width="250px"></asp:TextBox>
            </div>
            <div class="form-row">
                <label for="txtDiaChi">Địa chỉ:</label>
                <asp:TextBox ID="txtDiaChi" runat="server" Width="250px"></asp:TextBox>
            </div>
            <div class="form-row">
                <label for="txtMaSoThue">Mã số thuế:</label>
                <asp:TextBox ID="txtMaSoThue" runat="server" Width="250px"></asp:TextBox>
            </div>
            <hr />
            <div class="form-row">
                <div style="float: left; width: 50%;">
                    <label for="ddlLoaiBanh">Chọn các loại bánh:</label><br />
                    <asp:DropDownList ID="ddlLoaiBanh" runat="server">

                    </asp:DropDownList>
                    <br />
                    <label for="txtSoLuong">Số lượng:</label>
                    <asp:TextBox ID="txtSoLuong" runat="server" Width="80px"></asp:TextBox> cái
                    <br />
                    <asp:Button ID="btnAdd" runat="server"  Text=">" OnClick="btnAdd_Click" />
                </div>
                <div style="float: right; width: 40%;">
                    <label style="width:200px">Danh sách bánh được đặt:</label><br />
                    <asp:ListBox  ID="lstBanh" runat="server" Width="200px" Height="100px" SelectionMode="Multiple"></asp:ListBox>
                    <asp:Button ID="btnRemove" runat="server" Text="Xóa" OnClick="btnRemove_Click" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnPrint" runat="server" Text="In đơn đặt hàng" OnClick="btnPrint_Click" />
            </div>
            <table class="form-footer">
                <asp:Label ID="LblHoadon" runat="server" Text="Hoá đơn"></asp:Label>

            </table>
            
        </div>
    </form>
</body>
</html>