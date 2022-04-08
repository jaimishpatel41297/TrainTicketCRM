<%@ Page Title="" Language="C#" MasterPageFile="~/SuperAdmin.master" AutoEventWireup="true" CodeFile="AddEftticketlist.aspx.cs" Inherits="Addeftticketlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="plugins/bower_components/datatables/dataTables.bootstrap.js" type="text/javascript"></script>
    <script src="plugins/bower_components/jquery-datatables-editable/jquery.dataTables.js" type="text/javascript"></script>
    <script type="text/javascript">
        function ShowpopupUser() {
            debugger;
            $('#EFTticketlistmodel').modal('show');
        }
    </script>
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid" ng-app="Inquiry" ng-controller="InquiryController">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">Add Eft Ticket List </h4>
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
                        <asp:LinkButton runat="server" ID="lbLeague" data-toggle="modal" data-target="#EFTticketlistmodel" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect">Add EftTicket List</asp:LinkButton>
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
                                    <asp:BoundField DataField="ttname" HeaderText="TT Name" />
                                    <asp:BoundField DataField="FromEFTNo" HeaderText="From EFTNumber" />
                                    <asp:BoundField DataField="ToEFTNo" HeaderText="To EFTNumber" />
                                    <asp:BoundField DataField="StationName" HeaderText="Station Name" />
                                    <asp:BoundField DataField="Date" HeaderText="Date" DataFormatString="{0: dd-MM-yyyy}" />
                                    <asp:BoundField DataField="MRNo" HeaderText="MR Number" />
                                    <asp:BoundField DataField="Amount" HeaderText="Amount" />
                                    <asp:BoundField DataField="UTSNo" HeaderText="UTS Number" />
                                    <asp:BoundField DataField="Remark" HeaderText="Remark" />
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

        <div class="modal fade" id="EFTticketlistmodel" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" style="display: none;">
            <div class="modal-dialog" style="width: 80%;" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                        <h4 class="modal-title">Add NDA Data </h4>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;margin-top:6%;">
                                    <label for="">
                                        Select TT Name<asp:Label ID="lberror" runat="server" Text="*" ForeColor="Red" Visible="false"></asp:Label>
                                    </label>
                                    <div>
                                        <asp:DropDownList ID="ddltt" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="ddltt" ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                        </asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;margin-top:6%;">
                                    <label for="">
                                        Station Name
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtstname" ID="RequiredFieldValidator10" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtstname" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        MR No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtmr" ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtmr" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Amount
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtamt" ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtamt" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Date
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtdate" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtdate" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                        <asp:CalendarExtender ID="CalendarExtender3" runat="server" Format="yyyy-MM-dd" TargetControlID="txtdate"></asp:CalendarExtender>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        UTS No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtutsno" ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtutsno" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        From Eft No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtfrmeft" ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txtfrmeft" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 col-xs-6 col-sm-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        To Eft No
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txttoeft" ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                    </label>
                                    <div>
                                        <asp:TextBox ID="txttoeft" runat="server" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                <label for="">
                                    Remark
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="txtre" ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </label>
                                <div>
                                    <asp:TextBox ID="txtre" runat="server" TextMode="MultiLine" ValidationGroup="AddEmployee" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="modal-footer">
                        <div class="text-right">
                            <asp:LinkButton runat="server" ID="lbSubmit" ValidationGroup="AddEmployee" OnClick="lbSubmit_Click" CssClass="fcbtn btn btn-success btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Submit</asp:LinkButton>
                            <asp:LinkButton runat="server" ID="lbUpdate" ValidationGroup="AddEmployee" OnClick="lbUpdate_Click" Visible="false" CssClass="fcbtn btn btn-primary btn-outline btn-1d waves-effect" CommandArgument='<%# Eval("Id") %>'>Update</asp:LinkButton>
                            <asp:LinkButton runat="server" ID="lbCancel" data-dismiss="modal" OnClick="lbCancel_Click" CssClass="fcbtn btn btn-danger btn-outline btn-1d waves-effect">Cancel</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

