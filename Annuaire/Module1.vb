Imports System.IO

Public Module Module1

    Sub Main()
        LancerMenu()
    End Sub

    Sub LancerMenu()

        While True

            Console.Clear()
            Console.WriteLine("Selectionner votre option :")
            Console.WriteLine("1 - Créer un contact")
            Console.WriteLine("2 - Lister tous les contacts")
            Console.WriteLine("0 - Quitter")

            Dim choix As String = Console.ReadLine()

            If choix = "0" Then Exit While

            Select Case choix
                Case "1"
                    creerContact()
                Case "2"
                    listerContact()
            End Select

        End While

    End Sub


    Sub creerContact()
        Console.Clear()
        Console.WriteLine("Saississez le Nom : ")
        Dim nom As String = Console.ReadLine()
        Console.WriteLine("Saississez le Prénom : ")
        Dim prenom As String = Console.ReadLine()
        Console.WriteLine("Saississez la Date de naissance : ")
        Dim dateNaissance As String = Console.ReadLine()
        Console.WriteLine("Saississez le Téléphone : ")
        Dim telephone As String = Console.ReadLine()

        sauvegarderContact(nom, prenom, dateNaissance, telephone)

        Console.WriteLine("Contact sauvegardé.")
        Console.ReadLine()
    End Sub

    Sub sauvegarderContact(ByVal nom As String, ByVal prenom As String, ByVal dateNaissance As String, ByVal telephone As String)

        Dim writer As New StreamWriter("annuaire.csv", True)

        writer.WriteLine("{0};{1};{2};{3}", nom, prenom, dateNaissance, telephone)

        writer.Close()

    End Sub

    Sub listerContact()

        Dim contacts As List(Of String()) = chargerContacts()

        Console.Clear()
        For Each contact As String() In contacts
            Console.WriteLine("-------------------------")
            Console.WriteLine("Nom : {0}", contact(0))
            Console.WriteLine("Prénom : {0}", contact(1))
            Console.WriteLine("Date de naissance : {0}", contact(2))
            Console.WriteLine("Téléphone : {0}", contact(3))
            Console.WriteLine("-------------------------")
        Next

        Console.ReadLine()
    End Sub

    Function chargerContacts() As List(Of String())
        Dim contacts As New List(Of String())

        Dim reader As New StreamReader("annuaire.csv")

        While reader.EndOfStream = False

            Dim ligne = reader.ReadLine()
            Dim contact() As String = ligne.Split(";")

            contacts.Add(contact)
        End While

        reader.Close()

        Return contacts
    End Function

End Module
