<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartSummary.aspx.cs" Inherits="STOHANZ.Controllers.CartSummary" %>

<div id="cartSummary">
    <span class="caption">
        <b>В корзине</b>
        <span id="csQuantity" runat="server">товаров, </span>
        <span> на </span>
        <span id="csTotal" runat="server"></span>
    </span>
    <a id="csLink" runat="server">Корзина</a>
</div>