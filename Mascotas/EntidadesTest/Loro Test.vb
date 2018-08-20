Imports Entidades

Module Loro_Test

    Sub main()

        Dim loro1 = New Loro
        Imprimir(loro1)

        loro1.Nombre = "Mariano"
        loro1.FechaNac = # 08/02/1993#
        loro1.Edad = loro1.CalcularEdad(loro1.FechaNac)
        loro1.Escuchar("Hola")
        loro1.Escuchar("Como")
        loro1.Escuchar("Estan")

        Imprimir(loro1)

        Console.ReadKey()

    End Sub

    Public Sub Imprimir(loro As Loro)

        Console.WriteLine("Nombre: " & loro.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & loro.FechaNac)
        Console.WriteLine("Edad: " & loro.Edad)
        Console.WriteLine("To String: " & loro.ToString)
        Console.WriteLine()

    End Sub


End Module
