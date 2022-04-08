<%@ Page Title="" Language="C#" MasterPageFile="~/SuperAdmin.master" AutoEventWireup="true" CodeFile="Trainclassmaster.aspx.cs" Inherits="Trainclassmaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Add Train class</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="col-md-6 col-sm-6 col-xs-6">
                    <div class="white-box">
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
                        <div class="row">
                            <div class="col-sm-12 col-lg-12 col-xs-12">
                                <div class="form-group">
                                    <label for="">
                                        Class name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddSt" ControlToValidate="txtname" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox runat="server" ID="txtname" ValidationGroup="AddSt" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="text-right">
                                    <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddSt" OnClick="lbSubmit_Click" CommandArgument='<%# Eval("Id") %>' CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Submit</asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddSt" OnClick="lbUpdate_Click" CommandArgument='<%# Eval("Id") %>' Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect">Update</asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="lbCancel" OnClick="lbCancel_Click" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                    <div class="white-box">
                        <h3 class="box-title m-b-0">Data</h3>
                        <div class="row">
                            <div class="col-sm-12 col-xs-12 table-responsive">
                                <asp:GridView runat="server" ID="gv" CssClass="gvDataTable table table-striped table-bordered" AutoGenerateColumns="false">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Sr. No.">
                                            <ItemTemplate>
                                                <%# Container.DataItemIndex + 1 %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="ClassName" HeaderText="ClassName" />
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
        </div>
    </div>
</asp:Content>

