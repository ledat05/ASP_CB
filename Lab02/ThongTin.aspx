<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="thongtin.aspx.cs" Inherits="Lab02.ThongTin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dang Ki Thong Tin</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet">
    <style type="text/css">
        .form-control {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container d-flex justify-content-center align-items-center" style="height: 100vh;">
            <div class="w-50 p-4 border rounded shadow-sm">
                <h2 class="text-center mb-4">Đăng Ký Thông Tin</h2>

                <!-- Họ Tên -->
                <div class="mb-3">
                    <asp:Label ID="lblHoTen" runat="server" Text="Họ Và Tên:" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control" Width="276px"></asp:TextBox>
                </div>

                <!-- Ngày Sinh -->
                <div class="mb-3">
                    <asp:Label ID="lblNgaySinh" runat="server" Text="Ngày Sinh:" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtNgaySinh" runat="server" CssClass="form-control" TextMode="Date" Width="275px"></asp:TextBox>
                </div>

                <!-- Giới Tính -->
                <div class="mb-3">
                    <asp:Label ID="lblGioiTinh" runat="server" Text="Giới Tính:" CssClass="form-label"></asp:Label>
                    <asp:RadioButtonList ID="rblGioiTinh" runat="server" RepeatDirection="Horizontal" CssClass="form-check-inline">
                        <asp:ListItem Text="Nam" Value="Nam"></asp:ListItem>
                        <asp:ListItem Text="Nữ" Value="Nữ"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>

                <!-- Trình Độ -->
                <div class="mb-3">
                    <asp:Label ID="lblTrinhDo" runat="server" Text="Trình Độ:" CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlTrinhDo" runat="server" CssClass="form-select"></asp:DropDownList>
                </div>

                <!-- Nghề Nghiệp -->
                <div class="mb-3">
                    <asp:Label ID="lblNgheNghiep" runat="server" Text="Nghề Nghiệp:" CssClass="form-label"></asp:Label>
                    <asp:ListBox ID="lstNgheNghiep" runat="server" SelectionMode="Multiple" CssClass="form-control" size="5" Height="58px" Width="711px"></asp:ListBox>
                </div>

                <!-- Sở Thích -->
                <div class="mb-3">
                    <asp:Label ID="lblSoThich" runat="server" Text="Sở Thích:" CssClass="form-label"></asp:Label>
                    <asp:CheckBoxList ID="cblSoThich" runat="server" CssClass="form-check"></asp:CheckBoxList>
                </div>

                <!-- Tải Hình -->
                <div class="mb-3">
                    <asp:Label ID="lblHinh" runat="server" Text="Tải Hình:" CssClass="form-label"></asp:Label>
                    <asp:FileUpload ID="fuHinh" runat="server" CssClass="form-control"></asp:FileUpload>
                </div>

                <!-- Buttons -->
                <div class="mb-3">
                    <asp:Button ID="btnGui" runat="server" Text="Đăng Ký" OnClick="btnGui_Click" CssClass="btn btn-primary w-100"></asp:Button>
                    <asp:Button ID="btnReset" runat="server" Text="Quay Lại" OnClick="btnReset_Click" CssClass="btn btn-secondary w-100 mt-2"></asp:Button>
                </div>

                <!-- Result -->
                <div class="result mt-3">
                    <asp:Label ID="lblResult" runat="server" Text="" CssClass="form-text"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

