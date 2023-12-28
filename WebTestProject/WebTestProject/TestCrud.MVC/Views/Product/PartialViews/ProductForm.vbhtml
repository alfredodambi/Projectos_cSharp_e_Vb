@ModelType MVC.Domain.Models.Product

@Code
    ViewData("Title") = If(Model.Id = 0, "Adicionar Produto", "Editar Producto")
End Code

<div class="container">

    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()



        @<div class="form-group">
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    @Html.HiddenFor(Function(model) model.Id)
    <label for="Name" class="font-weight-bold" style="font-size: 18px;">Nome do Producto</label>
    @Html.TextBoxFor(Function(model) model.Name, New With {.class = "form-control", .style = "border: 1px solid #ccc; padding: 5px;"})
    @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
</div>

        @<div class="form-group">
    <label for="Price" class="font-weight-bold" style="font-size: 18px;">Preço do producto</label>
    @Html.TextBoxFor(Function(model) model.Price, New With {.class = "form-control", .style = "border: 1px solid #ccc; padding: 5px;"})
    @Html.ValidationMessageFor(Function(model) model.Price, "", New With {.class = "text-danger"})
</div>

        @<button type="submit" class="btn btn-primary" style="margin-top: 10px;">Salvar</button>
    End Using
</div>
