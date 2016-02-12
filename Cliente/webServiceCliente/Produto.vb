

Public Class Produto
    Public Property ProdutoID() As Integer
        Get
            Return m_ProdutoID
        End Get
        Set(value As Integer)
            m_ProdutoID = value
        End Set
    End Property
    Private m_ProdutoID As Integer
    Public Property Descricao() As String
        Get
            Return m_Descricao
        End Get
        Set(value As String)
            m_Descricao = value
        End Set
    End Property
    Private m_Descricao As String
    Public Property ProdutoCategoriaId() As Integer
        Get
            Return m_ProdutoCategoriaId
        End Get
        Set(value As Integer)
            m_ProdutoCategoriaId = value
        End Set
    End Property
    Private m_ProdutoCategoriaId As Integer
    Public Property DataCadastro() As DateTime
        Get
            Return m_DataCadastro
        End Get
        Set(value As DateTime)
            m_DataCadastro = value
        End Set
    End Property
    Private m_DataCadastro As DateTime
End Class
