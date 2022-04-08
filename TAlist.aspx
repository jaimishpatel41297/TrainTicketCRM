<%@ Page Title="" Language="C#" MasterPageFile="~/SuperAdmin.master" AutoEventWireup="true" CodeFile="TAlist.aspx.cs" Inherits="TAlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">EFT Ticket List </h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
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
                    <div class="row">
                        <div class="col-sm-12 col-lg-12 col-xs-12">
                            <div class="col-sm-6 col-lg-6 col-xs-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Select Squad Name<asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red" Visible="false"></asp:Label>
                                    </label>
                                    <div>
                                        <asp:DropDownList ID="ddlselectsqd" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlselectsqd_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                    </div>
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="ddlselectsqd" ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="col-sm-6 col-lg-6 col-xs-6">
                                <div class="form-group" style="margin-left: 3%; margin-right: 3%;">
                                    <label for="">
                                        Select TTname<asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red" Visible="false"></asp:Label>
                                    </label>
                                    <div>
                                        <asp:DropDownList ID="ddlttname" runat="server" OnSelectedIndexChanged="ddlttname_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                    <asp:RequiredFieldValidator Display="Dynamic" ValidationGroup="AddEmployee" ControlToValidate="ddlttname" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12 col-xs-12 table-responsive">
                            <asp:GridView runat="server" ID="gv" CssClass="gvDataTable table table-striped table-bordered" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:TemplateField HeaderText="Sr. No.">
                                        <ItemTemplate>
                                            <%# Container.DataItemIndex + 1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Date" HeaderText="Date" DataFormatString="{0: dd-MM-yyyy}" />
                                    <asp:BoundField DataField="TrainNo" HeaderText="Train Number" />
                                    <asp:BoundField DataField="TimeLeft" HeaderText="Time Left" />
                                    <asp:BoundField DataField="TimeArrived" HeaderText="Time Arrived" />
                                    <asp:BoundField DataField="FromStation" HeaderText="From Station" />
                                    <asp:BoundField DataField="ToStation" HeaderText="To Station" />
                                    <asp:BoundField DataField="Pecentage" HeaderText="Pecentage" />
                                    <asp:BoundField DataField="Remark" HeaderText="Remark" />
                                    <asp:BoundField DataField="ttname" HeaderText="TT Name" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

