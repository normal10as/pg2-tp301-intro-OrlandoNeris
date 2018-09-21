Public Class Loro

    Protected _memoria As Queue(Of String)

    Private _edad As Short
    Public ReadOnly Property Edad As Short
        Get
            Return _edad
        End Get
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
        _edad = CalcularEdad(FechaNac)
    End Sub

    Public Function CalcularEdad(fechanac As Date) As UShort

        Return Today.Year - fechanac.Year
    End Function

    Public Function Hablar() As String
        Dim texto As String = ""
        While _memoria.Count > 0
            texto = texto & _memoria.Dequeue & " "
        End While
        Return texto
    End Function

    Public Overridable Sub Escuchar(palabra As String)
        _memoria.Enqueue(palabra)
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
