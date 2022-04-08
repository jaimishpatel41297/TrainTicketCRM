<%@ Page Title="" Language="C#" MasterPageFile="~/SuperAdmin.master" AutoEventWireup="true" CodeFile="AddTTDetail.aspx.cs" Inherits="AddTTDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="plugins/bower_components/datatables/dataTables.bootstrap.js" type="text/javascript"></script>
    <script src="plugins/bower_components/jquery-datatables-editable/jquery.dataTables.js" type="text/javascript"></script>

    <script type="text/javascript">
        function ShowpopupUser() {
            debugger;
            $('#TTmodel').modal('show');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid" ng-app="Inquiry" ng-controller="InquiryController">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Add TTDetails </h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
        </div>
        <div class="row">
            <div class="col-md-5 col-sm-12 col-xs-12">

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
                        <asp:LinkButton runat="server" ID="lbLeague" data-toggle="modal" data-target="#TTmodel" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Add TTDetails</asp:LinkButton>

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
                                    <asp:BoundField DataField="station" HeaderText="station" />
                                    <asp:BoundField DataField="TTSquadName" HeaderText="TTSquadName" />
                                    <asp:BoundField DataField="IsSquadHead" HeaderText="IsSquadHead" />
                                    <asp:BoundField DataField="Name" HeaderText="Name" />
                                    <asp:BoundField DataField="AdharNo" HeaderText="AdharNo" />
                                    <asp:BoundField DataField="UserName" HeaderText="UserName" />
                                    <asp:BoundField DataField="Password" HeaderText="Password" />
                                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile No" />
                                    <asp:BoundField DataField="Branch" HeaderText="Branch" />
                                    <asp:BoundField DataField="Scale" HeaderText="Scale" />
                                    <asp:BoundField DataField="Division" HeaderText="Division" />
                                    <asp:BoundField DataField="PFno" HeaderText="PFno" />
                                    <asp:BoundField DataField="HQ" HeaderText="HQ" />
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

        <div class="modal fade" id="TTmodel" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
            <div class="modal-dialog" style="width: 80%;" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                        <h4 class="modal-title">Add TTdetails </h4>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%; margin-top: 6%;">
                                    <label for="">
                                        Select Station<asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red" Visible="false"></asp:Label>
                                    </label>
                                    <div>
                                        <asp:DropDownList ID="ddlstation" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="ddlstation" ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%; margin-top: 6%;">
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
                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%; margin-top: 6%;">
                                    <label for="">
                                        Adhar No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtahar" ID="RequiredFieldValidator12" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtahar" MaxLength="12"  runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%; margin-top: 3%;">
                                    <label for="">
                                        Make TT Squad Head:
                                            <br />
                                        <asp:CheckBox ID="status" OnCheckedChanged="status_CheckedChanged" Visible="true" AutoPostBack="true" runat="server" />
                                    </label>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div runat="server" id="ltrdrop" visible="true">
                                    <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                        <label for="">
                                            Select Squad Head
                                        </label>
                                        <div>
                                            <asp:DropDownList ID="ddlsquad" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlsquad_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-4">
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
                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Branch
                             <%--       <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtbrc" ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                             --%>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtbrc" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Scale
                                   <%-- <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtscl" ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>--%>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtscl" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Division
                                   <%-- <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtdiv" ID="RequiredFieldValidator9" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>--%>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtdiv" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        PF No
                                   <%-- <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtpf" ID="RequiredFieldValidator10" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>--%>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtpf" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Head Quarter
                                 <%--   <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txthq" ID="RequiredFieldValidator11" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>--%>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txthq" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Security Pin
                                  <%--  <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtpin" ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>--%>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtpin" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="modal-footer">
                        <div class="text-right">
                            <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddEmployee" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Submit</asp:LinkButton>
                            <%-- <asp:LinkButton runat="server" ID="LinkButton1" ValidationGroup="AddEmployee" OnClick="LinkButton1_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>GG Submit</asp:LinkButton>--%>
                            <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddEmployee" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                            <asp:LinkButton runat="server" ID="lbCancel" data-dismiss="modal" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

