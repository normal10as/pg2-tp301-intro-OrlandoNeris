
Imports Entidades

Module CotorraTest

    Sub main()

        Dim cotorra1 As Cotorra
        cotorra1 = New Cotorra

        MostrarCotorra(cotorra1)

        cotorra1.Nombre = "Pepa"
        cotorra1.FechaNac = #08/02/1993#
        cotorra1.CalcularEdad(cotorra1.FechaNac)
        cotorra1.Escuchar("Hola")
        cotorra1.Escuchar("Hola")
        cotorra1.Escuchar("como")
        cotorra1.Escuchar("como")
        cotorra1.Escuchar("estan")
        cotorra1.Escuchar("estan")

        MostrarCotorra(cotorra1)

        Console.ReadKey()
    End Sub

    Private Sub MostrarCotorra(cotorra1 As Cotorra)
        Console.WriteLine("")
        Console.WriteLine("Nombre: " & cotorra1.Nombre)
        Console.WriteLine("Edad: " & cotorra1.CalcularEdad(cotorra1.FechaNac))
        Console.WriteLine("Edad Humana: " & cotorra1.EdadHumana())
        Console.WriteLine("hablar: " & cotorra1.Hablar)
        Console.WriteLine("")
    End Sub
End Module
