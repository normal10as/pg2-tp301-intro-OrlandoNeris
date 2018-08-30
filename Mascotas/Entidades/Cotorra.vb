Public Class Cotorra
    Inherits Loro

    Private _edadHumana As UShort
    Public ReadOnly Property EdadHumana As UShort
        Get
            Return Edad * 2
        End Get
    End Property

    Sub New()
        MyBase.New
        Me.Nombre = "cotorra test"
        Me.FechaNac = Today
        Me.CalcularEdad(FechaNac)
    End Sub


End Class
