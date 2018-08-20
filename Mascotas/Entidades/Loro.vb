Public Class Loro

    Private _memoria As Queue(Of String)

    Private _edad As Short
    Public Property Edad As Short
        Get
            Return _edad
        End Get
        Set(value As Short)
            _edad = value
        End Set
    End Property

    Private _fechaNac As Date
    Public Property FechaNac As Date
        Get
            Return _fechaNac
        End Get
        Set(value As Date)
            _fechaNac = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Sub New()
        _memoria = New Queue(Of String)
        FechaNac = Today
        Nombre = "sin nombre"
        Edad = CalcularEdad(FechaNac)
    End Sub

    Public Function CalcularEdad(fechanac As Date) As UShort
        Return Today.Year - fechanac.Year
    End Function

    Public Function Hablar() As String

        Return _memoria.Dequeue
    End Function

    Public Sub Escuchar(palabra As String)
        _memoria.Enqueue(palabra)
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
