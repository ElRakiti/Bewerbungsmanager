Imports Bewerbungsmanager.Klassen

Namespace Forms

    ''' <author></author>
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FrmNeuerTermin
        Private _stelle As Stellenangebot

        Public Sub New(stelle As Stellenangebot)
            InitializeComponent()

            _stelle = stelle

            ' Databindings
            cmbAnsprechpartner.DataSource = stelle.Firma.Ansprechpartner
            cmbAnsprechpartner.DisplayMember = "Name"
        End Sub

        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
            Dim termin As Termin = New Termin()
            Dim ansprechpartner As Ansprechpartner
            termin.Bezeichnung = cmbBezeichnung.Text
            termin.Datum = DateTimePicker1.Value
            termin.Notizen = txtNotizen.Text

            ' Wenn Ansprechpartner nicht vorhanden, dann On-The-Fly einen anlegen
            If cmbAnsprechpartner.SelectedIndex = -1 Then
                ansprechpartner = New Ansprechpartner(cmbAnsprechpartner.Text)
                _stelle.Firma.Ansprechpartner.Add(ansprechpartner)
                termin.Ansprechpartner = ansprechpartner
            Else
                termin.Ansprechpartner = _stelle.Firma.Ansprechpartner()(cmbAnsprechpartner.SelectedIndex)
            End If
            _stelle.AddTermin(termin)
            Close()
        End Sub


        Private Sub FrmNeuerTermin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace