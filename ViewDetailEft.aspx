<%@ Page Title="" Language="C#" MasterPageFile="~/SuperAdmin.master" AutoEventWireup="true" CodeFile="ViewDetailEft.aspx.cs" Inherits="ViewDetailEft" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<div class="container-fluid">--%>
        <div class="row bg-title">
            <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                <h4 class="page-title">View Eft Details</h4>
            </div>
            <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            </div>
        </div>
        <div class="col-md-12 col-xs-12">
            <div class="white-box">
                <div class="row">
                    <div class="col-md-12" style="margin-bottom: 20px;">
                        <div class="col-md-3">
                            <strong>CollectedOn</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrcolon"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3 col-xs-6">
                            <strong>FromStation</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrfrmst"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3 col-xs-6">
                            <strong>ToStation</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrtost"></asp:Literal>
                            </p>
                        </div>
                        
                        <div class="col-md-3">
                            <strong>TicketNo</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrtickno"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>Weight</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrweigh"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>Weight Charge</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrweighchr"></asp:Literal>
                            </p>
                        </div>

                        
                        <div class="col-md-3">
                            <strong>Total</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrtotal"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>CGST</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrcgst"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>SGST</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrsgst"></asp:Literal>
                            </p>
                        </div>

                        <div class="col-md-3">
                            <strong>UGST</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrugst"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>IGST</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrigst"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>Reason Name</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrresnam"></asp:Literal>
                            </p>
                        </div>

                        <div class="col-md-3">
                            <strong>Class Name</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrclsname"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>StationName</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrstname"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>Passengers</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrpassenger"></asp:Literal>
                            </p>
                        </div>

                        <div class="col-md-3">
                            <strong>Avl From Station</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltravlfrmst"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>Avl To Station</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltravltost"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>AvlClassId</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltravlclsid"></asp:Literal>
                            </p>
                        </div>

                        <div class="col-md-3">
                            <strong>ModifiedDate</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrmoddate"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3">
                            <strong>Modified</strong>
                            <br />
                            <p class="text-muted">
                                <asp:Literal runat="server" ID="ltrismodi"></asp:Literal>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>

