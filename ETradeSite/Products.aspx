<%@ Page Title="ETrade" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="card">
            <div class="card-body">
                <b><h3 class="card-title">Add or Edit Operation</h3></b>
                     <!-- Model START -->
    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
      Add or Edit
    </button>

    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Add or Edit</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
              <asp:Label ID="Label4" runat="server" Text="Product ID"></asp:Label>
              <asp:TextBox ID="TextBox1" runat="server" Class="form-control" placeHolder="Update operation can be with id"></asp:TextBox>
          
              <asp:Label ID="Label5" runat="server" Font-Size="Medium" Text="Product Name"></asp:Label>
              <asp:TextBox ID="TextBox2" runat="server" Class="form-control"></asp:TextBox>

              <asp:Label ID="Label6" runat="server" Font-Size="Medium" Text="Product Description"></asp:Label>
              <asp:TextBox ID="TextBox3" runat="server" Class="form-control"></asp:TextBox>
          </div>
          <div class="modal-footer">
              <asp:Button ID="btn_close" runat="server" Text="Close" CssClass="btn btn-secondary" data-dismiss="modal" />
              <asp:Button ID="Button1" runat="server" Class="btn btn-success" OnClick="Button1_Click" Text="Add" Width="120px" />
              <asp:Button ID="Button2" runat="server" Class="btn btn-info"  OnClick="Button2_Click" Text="Edit" Width="120px" />

          </div>
        </div>
      </div>
    </div>
            

    <div class="card">
            <div class="card-body">
                <b><h3 class="card-title">Datas</h3></b>
                    <asp:GridView ID="GridView1" runat="server" Height="79px" Width="1071px">
                        <HeaderStyle BackColor="#660066" ForeColor="White" />
                    </asp:GridView>
            </div>
    </div>


    <div class="card">
            <div class="card-body">
                <b><h3 class="card-title">Search and Delete Operations</h3></b>
                 <asp:TextBox ID="txt_ara" runat="server" Class="form-control"></asp:TextBox>
                    <asp:Button ID="Button4" runat="server" Class="btn btn-warning" OnClick="Button4_Click" Text="Search" Width="120px" />
    
                    <asp:Button ID="Button3" runat="server" Class="btn btn-danger" OnClick="Button3_Click" OnClientClick="return confirm('Are you sure?');" Text="Delete" Width="120px" />
            </div>
    </div>

    </div>
</asp:Content>
