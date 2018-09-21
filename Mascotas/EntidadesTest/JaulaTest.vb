
Imports Entidades

Module JaulaTest

    Sub main()

        Dim jaula1 = New Jaula
        Dim loro1 = New Loro
        Dim cotorra1 = New Cotorra
        Dim cotorra2 = New Cotorra
        Dim cotorra3 = New Cotorra
        Dim cotorra4 = New Cotorra

        cotorra1.Nombre = "Juana"
        cotorra2.Nombre = "Maria"
        cotorra3.Nombre = "Susana"
        cotorra4.Nombre = "Petunia"

        loro1.Nombre = "Pepe"

        jaula1.Nombre = "Jaula 1"
        jaula1.addCotorra(cotorra1)
        jaula1.addCotorra(cotorra2)
        jaula1.addCotorra(cotorra3)
        jaula1.addCotorra(cotorra4)
        jaula1.Loro = loro1


        Console.WriteLine("Nombre de la Jaula: " & jaula1.Nombre)
        Console.WriteLine("ToString: " & jaula1.ToString)
        Console.WriteLine("Loro en la jaula: " & jaula1.Loro.ToString)
        Console.Write("Cotorras en la Jaula: ")
        Dim aux As List(Of Cotorra) = jaula1.getAllCotorras
        For Each cotorra In aux
            Console.Write(" , " & cotorra.Nombre)
        Next

        Console.ReadKey()
    End Sub

End Module
