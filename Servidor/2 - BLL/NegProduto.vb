Imports DAL


Public Class NegProduto

    Public Function ConsultarProduto(intProdutoId As System.Nullable(Of Integer)) As List(Of Produto)
        Try
            Dim produtoColecao As New List(Of Produto)()

            Using bancoDados = New webserviceEntities()
                Dim produtoSelecionado = From p In bancoDados.Produto Where ((p.ProdutoId.Equals(intProdutoId)) OrElse (intProdutoId Is Nothing))

                If produtoSelecionado.Count() > 0 Then
                    For Each item As Produto In produtoSelecionado
                        Dim novoItem As New Produto()
                        novoItem.ProdutoId = item.ProdutoId
                        novoItem.Descricao = item.Descricao
                        novoItem.DataCadastro = item.DataCadastro
                        novoItem.ProdutoCategoria = New ProdutoCategoria()
                        
                        novoItem.ProdutoCategoria.ProdutoCategoriaId = item.ProdutoCategoria.ProdutoCategoriaId
                        novoItem.ProdutoCategoria.Descricao = item.ProdutoCategoria.Descricao

                        produtoColecao.Add(novoItem)
                    Next
                End If
            End Using


            Return produtoColecao
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
