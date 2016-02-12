
'Para poder usar o JavaScriptSerializer (JSON)
Imports System.Web.Script.Serialization


'Adicionar Referencias = System.Web.Extensions

Public Class Form1
    Private wsProduto As webService.wsProdutoSoapClient
    Private jsSerializer As New JavaScriptSerializer()
    Private strJson As String = ""
    Private lstProduto As New List(Of Produto)()


    Private Sub btnConsultarProduto_Click(sender As Object, e As EventArgs) Handles btnConsultarProduto.Click
        Try
            wsProduto = New webService.wsProdutoSoapClient()

            strJson = wsProduto.ConsultarProduto()
            lstProduto = jsSerializer.Deserialize(Of List(Of Produto))(strJson)

            If lstProduto.Count() > 0 Then
                dgwProduto.DataSource = Nothing
                dgwProduto.DataSource = lstProduto
            Else
                MessageBox.Show("A consulta não retorno nenhum registro.")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar produtos no web service. Detalhes " & ex.Message)
        End Try
    End Sub


End Class

