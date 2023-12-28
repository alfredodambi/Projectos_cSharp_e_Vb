@Code
    ViewData("Title") = "Home Page"
    Dim successMessage As String = TempData("SuccessMessage")
    Dim errorMessage As String = ViewData("ErrorMessage")
End Code

<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="title">TASK LIST</h1>
    </section>
</main>
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