<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgwProduto = New System.Windows.Forms.DataGridView()
        Me.btnConsultarProduto = New System.Windows.Forms.Button()
        CType(Me.dgwProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgwProduto
        '
        Me.dgwProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwProduto.Location = New System.Drawing.Point(12, 12)
        Me.dgwProduto.Name = "dgwProduto"
        Me.dgwProduto.Size = New System.Drawing.Size(488, 273)
        Me.dgwProduto.TabIndex = 3
        '
        'btnConsultarProduto
        '
        Me.btnConsultarProduto.Location = New System.Drawing.Point(425, 311)
        Me.btnConsultarProduto.Name = "btnConsultarProduto"
        Me.btnConsultarProduto.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultarProduto.TabIndex = 2
        Me.btnConsultarProduto.Text = "Consultar"
        Me.btnConsultarProduto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 346)
        Me.Controls.Add(Me.dgwProduto)
        Me.Controls.Add(Me.btnConsultarProduto)
        Me.Name = "Form1"
        Me.Text = "Consultar Produtos "
        CType(Me.dgwProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgwProduto As System.Windows.Forms.DataGridView
    Private WithEvents btnConsultarProduto As System.Windows.Forms.Button

End Class
