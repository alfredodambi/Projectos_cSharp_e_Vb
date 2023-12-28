@ModelType MVC.Domain.Models.Purchase

@Code
    ViewData("Title") = If(Model.Id = 0, "Adicionar Compra", "Editar Compra")
    Dim successMessage As String = TempData("SuccessMessage")
    Dim errorMessage As String = ViewData("ErrorMessage")
End Code

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Registar Uma Compra</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.PurchaseDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PurchaseDate, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.PurchaseDate, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClientId, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                <!--@Html.EditorFor(Function(model) model.ClientId, New With {.htmlAttributes = New With {.class = "form-control"}})-->
                @Html.DropDownList("ClientId", CType(ViewData("Clients"), SelectList), "Selecione um Cliente", New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.ClientId, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ProductId, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                <!--@Html.EditorFor(Function(model) model.ProductId, New With {.htmlAttributes = New With {.class = "form-control"}})-->
                @Html.DropDownList("ProductId", CType(ViewData("Products"), SelectList), "Selecione um produto", New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.ProductId, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Quantity, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Quantity, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Quantity, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.TotalAmount, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TotalAmount, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.TotalAmount, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Registar" class="btn btn-info btn-sm" />
                <a class="btn btn-info btn-sm" href="@Url.Content("/Purchase/Index")">Ver a lista de Compras</a>
                <a class="btn btn-info btn-sm" href="@Url.Content("~/Client/Index")">Ver a lista de Cliente</a>
                <a class="btn btn-info btn-sm" href="@Url.Content("~/Product/Index")">Voltar para a lista de Productos</a>
            </div>
        </div>
    </div>


    @If Not String.IsNullOrEmpty(successMessage) Then
        @<div Class="alert alert-success">
            @successMessage
        </div>
    End If

    @If Not String.IsNullOrEmpty(errorMessage) Then
        @<div class="alert alert-danger">
            @errorMessage
        </div>
    End If
End Using