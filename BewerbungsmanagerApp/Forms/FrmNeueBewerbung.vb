Imports System.ComponentModel
Imports Bewerbungsmanager.Klassen
Imports Db4objects.Db4o.Internal.Metadata

Namespace Forms

    ''' <summary>
    ''' Autor: 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FrmNeueBewerbung

#Region "Private Felder"

        ' BindingList für Bindung von Ansprechpartnern und der Listbox
        Private _ansprechpartnerList As BindingList(Of Ansprechpartner) = New BindingList(Of Ansprechpartner)
        Private _bindingSource As New BindingSource()
        Private _bindingSourcePost As New BindingSource()
        Private _bindingSourceTelefon As New BindingSource()
        Private _bindingSourceEmail As New BindingSource()
        Private dictInformationen As New Dictionary(Of Control, String())

#End Region

#Region "Eventhandling Steuerlemente"

        ''' <author></author>
        ''' <summary>
        ''' Form-Load Event
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            With tcNeueBewerbung
                .SuspendLayout()
                'diese 3 Einstellungen verstecken die Reiter erst zur Laufzeit
                'bei Design-Arbeiten am Form sind die Reiter ja sehr nützlich 
                .SizeMode = TabSizeMode.Fixed
                .ItemSize = New Size(0, 1)
                .Appearance = TabAppearance.Buttons
                .ResumeLayout()
                cmbBezeichnung.Focus()
            End With

            lblTitel.Parent = PictureBox1
            lblTitel.Text = "Neues Stellenangebot - Grunddaten"

            _bindingSource.DataSource = _ansprechpartnerList
            _bindingSourceEmail.DataSource = _ansprechpartnerList
            _bindingSourcePost.DataSource = _ansprechpartnerList
            _bindingSourceTelefon.DataSource = _ansprechpartnerList


            ' BindingList und Listbox binden

            dlstvAnsprechpartner.DataSource = _bindingSource
            cmbPostAnsprech.DataSource = _bindingSourcePost
            cmbEMailAnsprech.DataSource = _bindingSourceEmail
            cmbTelefonAnsprech.DataSource = _bindingSourceTelefon

            cmbPostAnsprech.DisplayMember = "Name"
            cmbEMailAnsprech.DisplayMember = "Name"
            cmbTelefonAnsprech.DisplayMember = "Name"


            cmbPostAnsprech.DataBindings.Add("enabled", chkPost, "checked")
            cmbTelefonAnsprech.DataBindings.Add("enabled", chkTelefon, "checked")
            cmbEMailAnsprech.DataBindings.Add("enabled", chkEMail, "checked")
            txtOnlineForumlar.DataBindings.Add("enabled", chkOnline, "checked")

            AddHandler _ansprechpartnerList.ListChanged, AddressOf StatusFelderAnsprechpartner


            txtAEMail.DataBindings.Add("text", _bindingSource, "EMail")
            txtAFax.DataBindings.Add("text", _bindingSource, "Fax")
            txtAName.DataBindings.Add("text", _bindingSource, "Name")
            txtAPosition.DataBindings.Add("text", _bindingSource, "Position")
            txtATelefon.DataBindings.Add("text", _bindingSource, "Telefon")
            cmbAAnrede.DataBindings.Add("SelectedIndex", _bindingSource, "Anrede")

            dictInformationen.Add(cmbBezeichnung, {"Geben Sie hier die Stellenbezeichnung ein.", "Bitte geben Sie eine Stellenbezeichnung ein!"})
            dictInformationen.Add(txtStellennummer, {"Geben Sie hier eine Stellennummer ein, wenn eine vorhanden ist.", ""})
            dictInformationen.Add(txtFName, {"Geben Sie hier den Namen der Firma ein.", "Bitte geben Sie mindestens den Firmennamen ein!"})
            dictInformationen.Add(grpbFirmendaten, {"Geben Sie hier die Firmendaten, wie Straße und allgemeine Telefonnummer, an.", ""})
            dictInformationen.Add(grpWege, {"Wählen Sie hier die möglichen Bewerbungswege und eventuelle Ansprechpartner aus.", "Bitte wählen Sie mindestens einen Bewerbungsweg aus!"})
            dictInformationen.Add(grpbAnsprechpartner, {"Hier können Sie neue Ansprechpartner hinzufügen oder vorhandene löschen", ""})
            dictInformationen.Add(txtOnlineForumlar, {"Geben Sie hier den Link zu dem Online-Formular für die Bewerbung ein.", ""})
            dictInformationen.Add(txtNotizen, {"Hier können Sie zusätzliche Informationen eingeben.", ""})
            dictInformationen.Add(dtpVerschickt, {"Wurde die Bewerbung bereits verschickt? Dann aktivieren Sie das Häkchen und geben Sie ein Versanddatum ein.", ""})


        End Sub




        ''' <author></author>
        ''' <summary>
        ''' Die Art der Stellenbeschreibung ändert sich.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub cmbTyp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStellenbeschreibungTyp.SelectedIndexChanged
            Select Case cmbStellenbeschreibungTyp.SelectedIndex
                Case 0
                    lblURL.Visible = True
                    txtBeschreibungURL.Visible = True
                    webBrowser.Visible = True
                    btnURLAnzeigen.Visible = True
                    ' Weiter Button wird erst wieder aktiviert, wenn eine gültige Seite geladen wurde
                    btnNext.Enabled = False

                Case 1
                    lblURL.Visible = False
                    txtBeschreibungURL.Visible = False
                    webBrowser.Visible = False
                    btnURLAnzeigen.Visible = False
                    OpenFileDialog1.ShowDialog()
                    btnNext.Enabled = True


                Case Else
                    btnNext.Enabled = True
            End Select
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Vorherige Seite wird angewählt.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
            Select Case tcNeueBewerbung.SelectedIndex
                Case 0


                Case 1
                    btnNext.Text = "Weiter"
                    btnBack.Visible = False
                    tcNeueBewerbung.SelectedIndex -= 1
                    lblTitel.Text = "Neues Stellenangebot - Grunddaten"

                Case Else

            End Select
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Nächste Seite wird angewählt
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
            ClearInformationsLabel()
            ' Dim stelle As Stellenangebot
            Select Case tcNeueBewerbung.SelectedIndex
                Case 0
                    If ValidatePage(1) Then
                        btnBack.Visible = True
                        tcNeueBewerbung.SelectedIndex += 1
                        btnNext.Text = "Fertig"
                        lblTitel.Text = "Neues Stellenangebot - Stellenbeschreibung"
                    End If
                Case 1
                    ' stelle = createStelle()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Case Else

            End Select
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Eingegebene Url der Stellenbeschreibung wird intern im Browser aufgerufen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnURLAnzeigen_Click(sender As Object, e As EventArgs) Handles btnURLAnzeigen.Click
            webBrowser.Navigate(txtBeschreibungURL.Text)
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Enter-Klicken simuliert Button Klick zum Anzeigen 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub txtURL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBeschreibungURL.KeyPress
            If e.KeyChar = ChrW(Keys.Return) Then btnURLAnzeigen.PerformClick()
        End Sub

        Private Sub btnAddAnsprechpartner_Click(sender As Object, e As EventArgs) Handles btnAddAnsprechpartner.Click
            _ansprechpartnerList.Add(New Ansprechpartner("Ansprechpartner"))
        End Sub

        Private Sub btnDelAnsprechpartner_Click(sender As Object, e As EventArgs) Handles btnDelAnsprechpartner.Click
            If dlstvAnsprechpartner.SelectedObject IsNot Nothing Then
                _ansprechpartnerList.Remove(CType(dlstvAnsprechpartner.SelectedObject, Ansprechpartner))
            End If
        End Sub


        Private Sub webBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles webBrowser.DocumentCompleted
            ' Button wieder aktivieren
            btnNext.Enabled = True
        End Sub


        ' Validierungen

        Private Sub txtFName_Validating(sender As Object, e As CancelEventArgs) Handles txtFName.Validating
            If txtFName.Text.Length = 0 Then
                ErrorProvider.SetError(txtFName, dictInformationen(txtFName)(1))
                e.Cancel = True
            Else
                ErrorProvider.SetError(txtFName, String.Empty)
            End If
        End Sub

        Private Sub cmbBezeichnung_Validating(sender As Object, e As CancelEventArgs) Handles cmbBezeichnung.Validating
            If cmbBezeichnung.Text.Length = 0 Then
                ErrorProvider.SetError(cmbBezeichnung, dictInformationen(cmbBezeichnung)(1))
                e.Cancel = True
            Else
                ErrorProvider.SetError(cmbBezeichnung, String.Empty)
            End If
        End Sub


        Private Sub grpWege_Validating(sender As Object, e As CancelEventArgs) Handles grpWege.Validating
            ' Mindestens 1 Bewerbungsweg muss ausgewählt sein
            If Not (chkEMail.Checked Or chkOnline.Checked Or chkPost.Checked Or chkTelefon.Checked) Then
                ErrorProvider.SetError(grpWege, dictInformationen(grpWege)(1))
                e.Cancel = True
            Else
                ErrorProvider.SetError(grpWege, String.Empty)
            End If
        End Sub

       


        ''' <author></author>
        ''' <summary>
        ''' Setzt den Hilfetext für das aufgerufene Control (sender bzw. parent)
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SetInformationsLabel(sender As Object, e As EventArgs) Handles cmbBezeichnung.MouseEnter, txtStellennummer.MouseEnter, grpWege.MouseEnter, txtFName.MouseEnter, chkEMail.MouseEnter _
                                                                                   , chkOnline.MouseEnter, chkPost.MouseEnter, chkTelefon.MouseEnter, cmbEMailAnsprech.MouseEnter, cmbPostAnsprech.MouseEnter, cmbTelefonAnsprech.MouseEnter, txtFEMail.MouseEnter, txtFFax.MouseEnter _
                                                                                   , txtFHomepage.MouseEnter, txtFOrt.MouseEnter, txtFPLZ.MouseEnter, grpbAnsprechpartner.MouseEnter, grpbFirmendaten.MouseEnter, txtATelefon.MouseEnter, txtAPosition.MouseEnter, _
                                                                                   txtAName.MouseEnter, txtAFax.MouseEnter, txtAEMail.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, _
                                                                                   Label11.MouseEnter, dlstvAnsprechpartner.MouseEnter, cmbAAnrede.MouseEnter, btnDelAnsprechpartner.MouseEnter, btnAddAnsprechpartner.MouseEnter, dtpVerschickt.MouseEnter, txtNotizen.MouseEnter

            Dim control As Control = TryCast(sender, Control)


            ' Erst mit sender als Control suchen, wenn nicht, dann Parent versuchen (z.B. für Bewerbungswege)
            If Not dictInformationen.ContainsKey(control) Then

                ' Mit Parent suchen
                control = control.Parent
                If Not dictInformationen.ContainsKey(control) Then

                    Return
                End If
            End If

            If Not String.IsNullOrEmpty(ErrorProvider.GetError(control)) Then
                lblInformation.Text = dictInformationen.Item(control)(1)
                lblInformation.ForeColor = Color.Red
            Else
                lblInformation.Text = dictInformationen.Item(control)(0)
                lblInformation.ForeColor = Color.Black
            End If


        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Leert das Informationslabel
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ClearInformationsLabel() Handles cmbBezeichnung.MouseLeave, txtStellennummer.MouseLeave, grpWege.MouseLeave, txtFName.MouseLeave, grpbAnsprechpartner.MouseLeave, _
                                                     grpbFirmendaten.MouseLeave, dtpVerschickt.MouseLeave, txtNotizen.MouseLeave

            lblInformation.Text = String.Empty
            lblInformation.ForeColor = Color.Black
        End Sub




#End Region

#Region "Methoden"

        ''' <author></author>
        ''' <summary>
        ''' Genereriert eine neue Stelle mit den eingegebenen Daten und gibt sie zurück
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function CreateStelle() As Stellenangebot
            Dim stelle As Stellenangebot = New Stellenangebot()
            Dim firma As Firma = New Firma()
            Dim beschreibung As StellenBeschreibung

            stelle.DatumErfasst = DateAndTime.Now
            If dtpVerschickt.Checked Then
                stelle.DatumVersendet = dtpVerschickt.Value
                '  stelle.bewerbungVersendet(Date.Now)
            Else
                stelle.Status = Stellenangebot.Stati.Offen
            End If
            firma.Email = txtFEMail.Text
            firma.Fax = txtFFax.Text
            firma.Firmenname = txtFName.Text
            firma.Homepage = txtFHomepage.Text
            firma.Ort = txtFOrt.Text
            Integer.TryParse(txtFPLZ.Text, firma.Plz)
            firma.Straße = txtFStrasse.Text
            firma.Telefon = txtFStrasse.Text
            firma.Ansprechpartner = _ansprechpartnerList
            stelle.Firma = firma
            stelle.Stellenbezeichnung = cmbBezeichnung.Text
            stelle.Stellennummer = txtStellennummer.Text

            If chkEMail.Checked Then
                If cmbEMailAnsprech.SelectedIndex >= 0 Then
                    stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.EMail,
                                                              _ansprechpartnerList.Item(cmbEMailAnsprech.SelectedIndex)))
                Else
                    stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.EMail))
                End If

            End If

            If chkPost.Checked Then
                If cmbPostAnsprech.SelectedIndex >= 0 Then
                    stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.Post,
                                                              _ansprechpartnerList.Item(cmbPostAnsprech.SelectedIndex)))
                Else
                    stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.Post))
                End If
            End If


            If chkTelefon.Checked Then
                If cmbPostAnsprech.SelectedIndex >= 0 Then
                    stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.Telefon,
                                                              _ansprechpartnerList.Item(cmbTelefonAnsprech.SelectedIndex)))
                Else
                    stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.Telefon))
                End If
            End If

            If chkOnline.Checked Then
                stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.Online, txtOnlineForumlar.Text))
            End If


            Select Case cmbStellenbeschreibungTyp.SelectedIndex

                Case 0
                    ' Webseite
                    beschreibung = New StellenBeschreibung(StellenBeschreibung.BeschreibungTyp.Webseite)
                    beschreibung.Url = txtBeschreibungURL.Text
                    stelle.StellenBeschreibung = beschreibung


                    ' PDF
                Case 1
                    beschreibung = New StellenBeschreibung(StellenBeschreibung.BeschreibungTyp.PDF)
                    beschreibung.Pdf = OpenFileDialog1.FileName
                    stelle.StellenBeschreibung = beschreibung

                    ' Text
                Case 2
                    beschreibung = New StellenBeschreibung(StellenBeschreibung.BeschreibungTyp.Text)
                    beschreibung.Text = txtBeschreibungText.Text
                    stelle.StellenBeschreibung = New StellenBeschreibung(StellenBeschreibung.BeschreibungTyp.Text)
            End Select

            Return stelle
        End Function


        ''' <author></author>
        ''' <summary>
        ''' Validiert die angegebene Seite.Stellenangebot Aktuell nur für Seite 1 genutzt.
        ''' </summary>
        ''' <param name="page"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function ValidatePage(page As Integer) As Boolean
            Dim result As Boolean
            Select Case page
                Case 1
                    result = Me.ValidateChildren(ValidationConstraints.None)
                Case 2

                Case Else
                    Return result
            End Select

            Return result
        End Function




        ''' <author></author>
        ''' <summary>
        ''' Aktiviert bzw. Deaktiviert die Felder des Ansprechpartners
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub StatusFelderAnsprechpartner(sender As Object, e As ListChangedEventArgs)
            Dim state = _ansprechpartnerList.Count > 0

            txtAEMail.Enabled = state
            txtAFax.Enabled = state
            txtAName.Enabled = state
            txtAPosition.Enabled = state
            txtATelefon.Enabled = state
            cmbAAnrede.Enabled = state

        End Sub

#End Region

    End Class
End Namespace