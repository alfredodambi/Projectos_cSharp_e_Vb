@ModelType List(Of MVC.Domain.Models.Product)

<div class="container">
    <div class="row justify-content-end">
        <div class="col-md-4">
            <div class="form-group">
                @Using (Html.BeginForm("Index", "Product", FormMethod.Get, New With {.class = "form-inline"}))
                    @Html.AntiForgeryToken()

                @<div Class="input-group my-2">
            @Html.TextBox("searchString", Nothing, New With {.class = "form-control"})
                                    <div Class="input-group-append">
                                        <button type = "submit" Class="btn btn-primary">Pesquisar</button>
                                    </div>
                                </div>
                End Using
            </div>
        </div>
    </div>
</div>
