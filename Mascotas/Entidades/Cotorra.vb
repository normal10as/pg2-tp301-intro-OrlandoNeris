Public Class Cotorra
    Inherits Loro

    Dim Escucha As Boolean = True


    Public ReadOnly Property EdadHumana As UShort
        Get
            Return Edad * 2
        End Get
    End Property

    Sub New()
        MyBase.New
    End Sub

    Public Overrides Sub Escuchar(palabra As String)
        If Escucha = True Then
            _memoria.Enqueue(palabra)
            Escucha = False
        Else
            Escucha = True
        End If

    End Sub
End Class
