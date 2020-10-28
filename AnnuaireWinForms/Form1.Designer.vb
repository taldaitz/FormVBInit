<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.DPDateNaissance = New System.Windows.Forms.DateTimePicker()
        Me.LabelDateN = New System.Windows.Forms.Label()
        Me.TextBoxTel = New System.Windows.Forms.TextBox()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListViewContacts = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(180, 49)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxNom.TabIndex = 0
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(28, 49)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNom.TabIndex = 1
        Me.LabelNom.Text = "Nom"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(28, 77)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(57, 17)
        Me.LabelPrenom.TabIndex = 3
        Me.LabelPrenom.Text = "Prenom"
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(180, 77)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxPrenom.TabIndex = 2
        '
        'DPDateNaissance
        '
        Me.DPDateNaissance.Location = New System.Drawing.Point(180, 105)
        Me.DPDateNaissance.Name = "DPDateNaissance"
        Me.DPDateNaissance.Size = New System.Drawing.Size(200, 22)
        Me.DPDateNaissance.TabIndex = 4
        '
        'LabelDateN
        '
        Me.LabelDateN.AutoSize = True
        Me.LabelDateN.Location = New System.Drawing.Point(28, 110)
        Me.LabelDateN.Name = "LabelDateN"
        Me.LabelDateN.Size = New System.Drawing.Size(106, 17)
        Me.LabelDateN.TabIndex = 5
        Me.LabelDateN.Text = "Date naissance"
        '
        'TextBoxTel
        '
        Me.TextBoxTel.Location = New System.Drawing.Point(180, 133)
        Me.TextBoxTel.Name = "TextBoxTel"
        Me.TextBoxTel.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxTel.TabIndex = 6
        '
        'LabelTel
        '
        Me.LabelTel.AutoSize = True
        Me.LabelTel.Location = New System.Drawing.Point(28, 138)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(76, 17)
        Me.LabelTel.TabIndex = 7
        Me.LabelTel.Text = "Téléphone"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(129, 200)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(153, 38)
        Me.ButtonSave.TabIndex = 8
        Me.ButtonSave.Text = "Sauvegarder"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListViewContacts)
        Me.GroupBox1.Location = New System.Drawing.Point(490, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 316)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contacts"
        '
        'ListViewContacts
        '
        Me.ListViewContacts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderNom, Me.ColumnHeaderPrenom, Me.ColumnHeaderDN, Me.ColumnHeaderTel})
        Me.ListViewContacts.HideSelection = False
        Me.ListViewContacts.Location = New System.Drawing.Point(26, 41)
        Me.ListViewContacts.Name = "ListViewContacts"
        Me.ListViewContacts.Size = New System.Drawing.Size(582, 261)
        Me.ListViewContacts.TabIndex = 0
        Me.ListViewContacts.UseCompatibleStateImageBehavior = False
        Me.ListViewContacts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderNom
        '
        Me.ColumnHeaderNom.Text = "Nom"
        '
        'ColumnHeaderPrenom
        '
        Me.ColumnHeaderPrenom.Text = "Prénom"
        '
        'ColumnHeaderDN
        '
        Me.ColumnHeaderDN.Text = "Date de naissance"
        Me.ColumnHeaderDN.Width = 132
        '
        'ColumnHeaderTel
        '
        Me.ColumnHeaderTel.Text = "Téléphone"
        Me.ColumnHeaderTel.Width = 113
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.LabelTel)
        Me.Controls.Add(Me.TextBoxTel)
        Me.Controls.Add(Me.LabelDateN)
        Me.Controls.Add(Me.DPDateNaissance)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.TextBoxPrenom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents DPDateNaissance As DateTimePicker
    Friend WithEvents LabelDateN As Label
    Friend WithEvents TextBoxTel As TextBox
    Friend WithEvents LabelTel As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListViewContacts As ListView
    Friend WithEvents ColumnHeaderNom As ColumnHeader
    Friend WithEvents ColumnHeaderPrenom As ColumnHeader
    Friend WithEvents ColumnHeaderDN As ColumnHeader
    Friend WithEvents ColumnHeaderTel As ColumnHeader
End Class
