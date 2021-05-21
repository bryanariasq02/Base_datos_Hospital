<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_Cita.aspx.cs" Inherits="Hospital.Frm_Cita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>Codigo Cita</td>
                <td>
                    <asp:TextBox ID="Txt_Codigo" runat="server" MaxLength="10"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Brn_Cita" runat="server" OnClick="Brn_Cita_Click" Text="Consultar Cita" />
                </td>
            </tr>
            <tr>
                <td>Fecha</td>
                <td>
                    <asp:TextBox ID="Txt_Fecha" runat="server" Enabled="False" MaxLength="10"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Hora</td>
                <td>
                    <asp:TextBox ID="Txt_Hora" runat="server" Enabled="False" MaxLength="10"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Consultorio</td>
                <td>
                    <asp:DropDownList ID="Ddl_Consultorio" runat="server" Enabled="False">
                        <asp:ListItem>101</asp:ListItem>
                        <asp:ListItem>102</asp:ListItem>
                        <asp:ListItem>103</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>ID_Paciente</td>
                <td>
                    <asp:TextBox ID="Txt_Paciente" runat="server" Enabled="False" MaxLength="10"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Btn_Paciente" runat="server" Enabled="False" Text="Consultar Paciente" OnClick="Btn_Paciente_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LblNomPaciente" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LblTelPaciente" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>ID_Medico</td>
                <td>
                    <asp:TextBox ID="Txt_Medico" runat="server" Enabled="False" MaxLength="10"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Btn_medico" runat="server" Enabled="False" Text="Consultar Medico" OnClick="Btn_medico_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LblNomMedico" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LblEspMedico" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Valor</td>
                <td>
                    <asp:TextBox ID="Txt_Valor" runat="server" Enabled="False" MaxLength="6"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Observaciones</td>
                <td>
                    <asp:TextBox ID="Txt_Observaciones" runat="server" Enabled="False" MaxLength="1000" TextMode="MultiLine" Height="91px" Width="243px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="LblMensaje" runat="server" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Btn_Guardar" runat="server" Enabled="False" Text="Guardar" OnClick="Btn_Guardar_Click" />
                </td>
                <td>
                    <asp:Button ID="Btn_Anular" runat="server" Enabled="False" Text="Anular" OnClick="Btn_Anular_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <asp:Button ID="Btn_Cancelar" runat="server" Text="Cancelar" OnClick="Btn_Cancelar_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
