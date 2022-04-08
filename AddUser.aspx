<%@ Page Title="" Language="C#" MasterPageFile="~/SuperAdmin.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="plugins/bower_components/datatables/dataTables.bootstrap.js" type="text/javascript"></script>
    <script src="plugins/bower_components/jquery-datatables-editable/jquery.dataTables.js" type="text/javascript"></script>

    <script type="text/javascript">
        function ShowpopupUser() {
            debugger;
            $('#Usermodel').modal('show');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Add User </h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
        </div>
        <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">

                <p class="text-muted m-b-10 font-13">
                    <div class="alert alert-success alert-dismissable" id="divSuccess" runat="server" visible="false">
                        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                        Success ! Changes Done Successfully
                    </div>
                    <div class="alert alert-danger alert-dismissable" id="divError" runat="server" visible="false">
                        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                        Failure ! Changes Not Done Successfully !
                    </div>
                </p>

            </div>

            <div class="col-md-12 col-lg-12 col-xs-12 col-sm-12">
                <div class="white-box">
                    <h3 class="box-title m-b-0">Data</h3>
                    <div class="text-right">
                        <asp:LinkButton runat="server" ID="lbLeague" data-toggle="modal" data-target="#Usermodel" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Add User</asp:LinkButton>
                    </div>
                    <div class="row">
                        <div class="col-sm-12 col-xs-12 table-responsive">
                            <asp:GridView runat="server" ID="gv" CssClass="gvDataTable table-responsive table table-striped table-bordered" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:TemplateField HeaderText="Sr. No.">
                                        <ItemTemplate>
                                            <%# Container.DataItemIndex + 1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Name" HeaderText="Name" />
                                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile No" />
                                    <asp:BoundField DataField="UserName" HeaderText="User Name" />
                                    <asp:BoundField DataField="Password" HeaderText="Password" />
                                    <asp:BoundField DataField="Role" HeaderText="Role" />
                                    <asp:BoundField DataField="Divison" HeaderText="Divison" />
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="lbEdit" CssClass="btn btn-primary btn-circle waves-effect btn-sm fa fa-edit btn-outline" CommandArgument='<%# Eval("Id") %>' OnClick="lbEdit_Click"></asp:LinkButton>
                                            <asp:LinkButton runat="server" ID="lbDelete" OnClientClick="return confirm('Are You Sure Want To Delete ?')" CssClass="btn-outline btn btn-danger btn-circle waves-effect btn-sm fa fa-times" CommandArgument='<%# Eval("Id") %>' OnClick="lbDelete_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="modal fade" id="Usermodel" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
            <div class="modal-dialog" style="width: 80%;" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                        <h4 class="modal-title">Add User </h4>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%; margin-top: 6%;">
                                    <label for="">
                                        Select Role<asp:Label ID="lberror" runat="server" Text="*" ForeColor="Red" Visible="false"></asp:Label>
                                    </label>
                                    <div>
                                        <asp:DropDownList ID="ddlrole" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlrole_SelectedIndexChanged" AutoPostBack="true">
                                            <asp:ListItem Value="0" Text="Select Role"></asp:ListItem>
                                            <asp:ListItem Value="Super Admin" Text="Super Admin"></asp:ListItem>
                                            <asp:ListItem Value="DCTI" Text="DCTI"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%; margin-top: 6%;">
                                    <label for="" id="lbdivision" runat="server" visible="false">
                                        Select Division
                                    </label>
                                    <div>
                                        <asp:DropDownList ID="ddlDivision" runat="server" CssClass="form-control" Visible="false"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtName" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtName" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Mobile No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtno" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtno" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        UserName
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtusername" ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtusername" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Password
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtpwd" ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtpwd" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="modal-footer">
                        <div class="text-right">
                            <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddEmployee" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Submit</asp:LinkButton>
                            <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddEmployee" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                            <asp:LinkButton runat="server" ID="lbCancel" data-dismiss="modal" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

