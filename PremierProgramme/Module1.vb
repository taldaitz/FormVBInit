Module Module1

    ''' <summary>
    ''' Porte d'entrée de mon application
    ''' </summary>
    Sub Main()

        Console.WriteLine("Bienvenue à la formation VB.Net")
        Console.WriteLine("2eme ligne")
        Console.WriteLine("3eme ligne")

        'lit la prochaine ligne sur la console
        Console.ReadLine()

        Dim chiffre As String = "18"

        Dim chiffreInt As Integer = Convert.ToInt32(chiffre)

        chiffreInt += 2

    End Sub

End Module
