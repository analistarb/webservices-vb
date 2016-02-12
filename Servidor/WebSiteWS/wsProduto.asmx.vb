Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports BLL
Imports DAL

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="webserviceProduto")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class wsProduto
    Inherits System.Web.Services.WebService

    <WebMethod, ScriptMethod(ResponseFormat:=ResponseFormat.Json)> _
    Public Function ConsultarProduto() As String
        Try
            Dim negProduto As New NegProduto()
            Dim colecao As New List(Of Produto)()
            Dim jsSerializer As New JavaScriptSerializer()

            Dim json As String = String.Empty

            colecao.AddRange(negProduto.ConsultarProduto(Nothing))
            json = jsSerializer.Serialize(colecao)

            Return json
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class