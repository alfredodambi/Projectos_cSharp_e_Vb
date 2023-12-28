@ModelType List(Of MVC.Domain.Models.Product)


            <table class="table table-bordered">
                <thead class="thead-custom">
                    <tr>
                        <th scope="col"> ID</th>
                        <th scope="col"> NOME</th>
                        <th scope="col"> PREÇO</th>
                        <th scope="col"> OPÇÕES</th>
                    </tr>
                </thead>

                <tbody>
                    @For Each product In Model
                        @<tr>
                            <td scope="row">@product.Id</td>
                            <td>@product.Name</td>
                            <td>@product.Price.ToString("C")</td>
                            <td>
                                @If User.IsInRole("Alfredo") Then
                                    @<p Class="btn btn-info btn-sm">@Html.ActionLink("Editar", "Edit", New With {.id = product.Id})</p>
                                End If
                                @If User.IsInRole("Admin") OrElse User.IsInRole("Alfredo") Then
                                    @<p Class="btn btn-warning btn-sm">@Html.ActionLink("Ver", "Details", New With {.id = product.Id}) </p>
                                End If

                                @If User.IsInRole("Alfredo") Then
                                    @<p Class="btn btn-danger btn-sm">@Html.ActionLink("Excluir", "Delete", New With {.id = product.Id}) </p>
                                End If
                            </td>
                          </tr>
                    Next
                 </tbody>
            </table>
