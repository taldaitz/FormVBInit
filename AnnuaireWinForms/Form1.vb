Imports Annuaire

Public Class Form1

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim nom As String = TextBoxNom.Text
        Dim prenom As String = TextBoxPrenom.Text
        Dim dateNaissance As DateTime = DPDateNaissance.Value
        Dim telephone As String = TextBoxTel.Text

        Module1.sauvegarderContact(nom, prenom, dateNaissance.ToString(), telephone)

        TextBoxNom.Text = ""
        TextBoxPrenom.Text = ""
        DPDateNaissance.Value = DateTime.Today
        TextBoxTel.Text = ""

        chargerContactListView()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargerContactListView()
    End Sub

    Sub chargerContactListView()

        ListViewContacts.Items.Clear()

        Dim contacts As List(Of String()) = Module1.chargerContacts()

        For Each contact As String() In contacts
            ListViewContacts.Items.Add(New ListViewItem(contact))
        Next

    End Sub
End Class
