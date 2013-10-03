Imports Bewerbungsmanager.Klassen
Imports BrightIdeasSoftware
Imports System.ComponentModel

Namespace Forms

    ''' <author></author>
    ''' <summary>
    ''' Hauptfenster
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FrmMainForm

#Region "Private Felder"
        Private _controller As Controller
        Private _bindingSource As BindingSource
        Private _frmTerminInfo As New FrmTerminInfo()
        Private _bindingSourceAnsprechpartnerEMail As BindingSource
        Private _bindingSourceAnsprechpartnerPost As BindingSource
        Private _bindingSourceAnsprechpartnerTelefon As BindingSource
        Private _settings As Settings
        Private _bindDtp As Binding
#End Region

        ''' <author></author>
        ''' <summary>
        ''' Form-Load, tritt auf, wenn das Form geladen wird
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load



            Icon = My.Resources.Icon

            Try
                _controller = New Controller(Me)
            Catch ex As Exception
                ' Todo: Fehlermeldung spezifizieren und je nach Fehlerfall abfangen
                MsgBox("Fehler beim Laden der Anwendung! Eventuell Datenbank bereits im Zugriff?")
                Application.Exit()
            End Try


            ' Bindingsource erstellen
            _bindingSource = New BindingSource()
            _bindingSource.DataSource = _controller.StellenList
            _settings = _controller.Settings



            ' Die Comboboxen für die Auswahl der Ansprechpartner brauchen jeweils eine eigene BindingSource, damit der "Cursor" der anderen nicht verändert wird.
            ' Sonst wählt man bei Post Ansprechpartner A aus, und bei allen anderen wird auch automatisch A gesetzt.
            _bindingSourceAnsprechpartnerEMail = New BindingSource()
            _bindingSourceAnsprechpartnerPost = New BindingSource()
            _bindingSourceAnsprechpartnerTelefon = New BindingSource()

            ' Lädt Webseiten aus den Settings ins Kontextmenü
            LadeWebseiten()

            LadeProgramme()

            tooltxtEMail.Text = _settings.EmailUrl

            ' DataBindings für Steuerelemente setzen
            SetzeDataBindings()

            ' AddHandler _controller.StellenList.ListChanged, AddressOf StellenListChanged
            AddHandler _bindingSource.CurrentItemChanged, AddressOf CurrentStellenangebotChanged


            KonfiguriereListView()
            dlstvStellenangebote.DataSource = _bindingSource


            ' Beim Start ist die aktuelle Auswahl noch nicht im Datalistview ausgewählt, deswegen hier manuell übernehmen.
            If _bindingSource.Count > 0 Then
                dlstvStellenangebote.SelectObject(_bindingSource.Item(0))

            End If

            CurrentStellenangebotChanged(Me, Nothing)


            If Not _settings.Tutorial Then
                _settings.Tutorial = True
                FrmInformationUni.ShowDialog()
            End If


        End Sub

#Region "Events / Eventhandling / Delegates"


        ''' <author></author>
        ''' <summary>
        ''' Delegate, der vom BindingSource Event 'CurrentItemChanged' aufgerufen wird. Hier wird neben dem automatischen DataBinding manuell auf Änderungen reagiert, z.B. wenn die aktuell ausgewählte
        ''' Stelle geändert wird. Unter anderem werden Steuerlemente im Dashboard aktualisiert.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub CurrentStellenangebotChanged(sender As Object, e As EventArgs)
            If _bindingSource.Current IsNot Nothing Then
                TabPage2.Enabled = True
                TabPage3.Enabled = True
                AktualisiereKomponenten(TryCast(_bindingSource.Current, Stellenangebot))
            Else
                TabPage2.Enabled = False
                TabPage3.Enabled = False
            End If
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Delegate, wird aufgerufen, nachdem das Form für eine neue Stelle geschlossen wurde. Erstellt neue Stelle und übergibt sie dem Controller.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub NeueStelleFormClosing(sender As Object, e As EventArgs)
            Dim form As FrmNeueBewerbung = DirectCast(sender, FrmNeueBewerbung)
            If form.DialogResult = DialogResult.OK Then
                _controller.StellenList.Add(form.CreateStelle())
            End If
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Delegate, der aufgerufen wird, wenn das Steuerlement die Werte aus dem Objekt zur Anzeige formatiert. Wird dafür benutzt, damit NULL / Nothing Werte behandelt werden können.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub DateTimePickerNullableFormat(sender As Object, e As ConvertEventArgs)
            Dim bind As Binding = TryCast(sender, Binding)
            Dim dtp As DateTimePicker

            If bind IsNot Nothing Then
                dtp = TryCast(bind.Control, DateTimePicker)

                If dtp IsNot Nothing Then

                    ' Kommt aus dem Objekt Nothing (weil die Bewerbung noch nicht verschickt wurde), wird die Checkbox des DateTimePickers auf False gesetzt
                    If e.Value Is Nothing Then

                        dtp.ShowCheckBox = True
                        dtp.Checked = False

                        ' Da der Wert Null / Nothing ist, muss ein Wert auf das Control gesetzt werden. Dabei wird der alte Wert verwendet, da hier keine Change-Events geworfen werden.
                        e.Value = dtp.Value
                    Else
                        dtp.ShowCheckBox = True
                        dtp.Checked = True
                    End If
                End If
            End If
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Zeigt das Tutorial erneut an
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub TutorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorialToolStripMenuItem.Click
            FrmInformationUni.ShowDialog()
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Delegate, der aufgerufen wird, wenn das Steuerlement die Werte zur Weitergabe an das Objekt formatiert. Wird dafür benutzt, damit NULL / Nothing Werte behandelt werden können.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub DateTimePickerNullableParse(sender As Object, e As ConvertEventArgs)
            Dim bind As Binding = TryCast(sender, Binding)
            Dim dtp As DateTimePicker

            If bind IsNot Nothing Then
                dtp = TryCast(bind.Control, DateTimePicker)

                If dtp IsNot Nothing Then

                    If Not dtp.Checked Then

                        dtp.ShowCheckBox = True
                        dtp.Checked = False
                        e.Value = New Nullable(Of Date)()

                    Else
                        dtp.ShowCheckBox = True
                        dtp.Checked = True
                        e.Value = New Nullable(Of Date)(Convert.ToDateTime(e.Value))
                    End If
                End If
            End If
        End Sub



        ''' <author></author>
        ''' <summary>
        ''' Zeichnet 3 Punkte auf dem Splitter, um diesen besser kenntlich zu machen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SplitContainer1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Paint
            Dim control = TryCast(sender, SplitContainer)


            '3 Punkte zeichnen
            Dim points As Point() = New Point(2) {}
            Dim w = control.Width
            Dim h = control.Height
            Dim d = control.SplitterDistance
            Dim sW = 10

            ' Splitter-Breite festsetzen
            control.SplitterWidth = sW

            If SplitContainer1.Panel2Collapsed Then
                'Position der Punkte berechnen
                points(0) = New Point(CInt(w - 5), CInt((h / 2)))
                points(1) = New Point(points(0).X, points(0).Y - 10)
                points(2) = New Point(points(0).X, points(0).Y + 10)
            Else

                points(0) = New Point(CInt(d + 2 + (sW / 2)), CInt((h / 2)))
                points(1) = New Point(points(0).X, points(0).Y - 10)
                points(2) = New Point(points(0).X, points(0).Y + 10)
            End If

            For Each p As Point In points
                p.Offset(-2, -2)
                e.Graphics.FillEllipse(SystemBrushes.ControlDark, New Rectangle(p, New Size(3, 3)))

                p.Offset(1, 1)
                e.Graphics.FillEllipse(SystemBrushes.ControlLight, New Rectangle(p, New Size(3, 3)))
            Next
        End Sub



        ''' <author></author>
        ''' <summary>
        ''' Zeigt das NeuerTermin Fenster an, wenn auf das Listview geklickt wird und noch kein Termin vorhanden ist.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub dlstvTermine_Click(sender As Object, e As EventArgs) Handles dlstvTermine.Click
            If dlstvTermine.Items.Count = 0 Then
                ShowNeuerTerminForm()
            End If
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Neuen Ansprechpartner unter "Stellendaten" hinzufügen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnAddAnsprechpartner_Click(sender As Object, e As EventArgs) Handles btnAddAnsprechpartner.Click
            TryCast(_bindingSource.Current, Stellenangebot).Firma.Ansprechpartner.Add(New Ansprechpartner("Ansprechpartner"))
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Ausgewählten Ansprechpartner unter "Stellendaten" löschen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnDelAnsprechpartner_Click(sender As Object, e As EventArgs) Handles btnDelAnsprechpartner.Click
            Dim stelle = TryCast(_bindingSource.Current, Stellenangebot)
            If dlstvAnsprechpartner.SelectedObject IsNot Nothing Then
                stelle.Firma.Ansprechpartner.Remove(CType(dlstvAnsprechpartner.SelectedObject, Ansprechpartner))
            End If

        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Speichern aller Daten beim Schließen des Forms
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            _controller.SaveList()

            _settings.MainListViewSettings = dlstvStellenangebote.SaveState()
            _controller.SaveSettings()
        End Sub



        ''' <author></author>
        ''' <summary>
        ''' Klick auf Online-Formular anzeigen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnOnlineFormular_Click(sender As Object, e As EventArgs) Handles btnOnlineFormular.Click
            Try
                Process.Start(txtOnlineForumlar.Text)
            Catch ex As Exception
                MsgBox("Fehler beim Starten der Webseite. Bitte prüfen Sie das Url Format!")
            End Try
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Ausgewählten Termin löschen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub TerminLöschenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminLöschenToolStripMenuItem.Click
            With dlstvTermine
                If .SelectedObject IsNot Nothing Then
                    CType(_bindingSource.Current, Stellenangebot).Termine.Remove(CType(.SelectedObject, Termin))
                    CType(_bindingSource.Current, Stellenangebot).OnPropertyChanged("Temine") ' Property Changed Event. Wird später klassenintern geregelt.
                End If
            End With
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Entf-Taste löscht auch ausgewählten Termin
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub dlstvTermine_KeyUp(sender As Object, e As KeyEventArgs) Handles dlstvTermine.KeyUp
            If e.KeyCode = Keys.Delete Then
                TerminLöschenToolStripMenuItem_Click(Me, Nothing)
            End If
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Dummy Stellenangebote
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub GeneriereDummyStellenangebeoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneriereDummyStellenangebeoteToolStripMenuItem.Click
            _controller.GeneriereDummys()

            ' Alles nötige aktualisieren
            dlstvStellenangebote.SelectObject(_bindingSource.Item(0))

            CurrentStellenangebotChanged(Me, Nothing)
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Dashboard verstecken, muss noch eingebaut werden.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SplitContainer1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SplitContainer1.MouseDoubleClick
            '        SplitContainer1.Panel2Collapsed = Not SplitContainer1.Panel2Collapsed
            '       SplitContainer1.Refresh()
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Webseiten-Schnellverküpfungen bearbeiten
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub BearbeiteWebseitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BearbeiteWebseitenToolStripMenuItem.Click
            Dim frmListView As New FrmWebseiten(_settings.Webseiten)

            frmListView.lblTitel.Text = "Hier können Sie neue Webseiten hinzufügen oder vorhandene löschen."
            frmListView.Text = "Webseiten bearbeiten"
            frmListView.ShowDialog()

            ' Kontextmenü aktualisieren
            LadeWebseiten()

            _controller.SaveSettings()

        End Sub



        ''' <author></author>
        ''' <summary>
        ''' Stellenbeschreibung laden, wenn Tab geöffnet wird.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
            If e.TabPageIndex = 2 And Not IsNothing(_bindingSource.Current()) Then
                LadeStellenbeschreibung(CType(_bindingSource.Current, Stellenangebot))
            End If
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Stellendaten anzeigen bei Klick auf das Kontextmenü bzw. Doppelklick auf das Listview
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ZeigeStellendaten(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click, dlstvStellenangebote.MouseDoubleClick
            If Not IsNothing(_bindingSource.Current) Then
                TabControl1.SelectTab(1)
            End If
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Webseiten Schnellverknüpfungen anzeigen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
            cmsWebseiten.Show(Cursor.Position)
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Ausgewählte Schnellverknüpfung (Webseite) laden.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub WebseiteClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsWebseiten.ItemClicked
            Try
                Process.Start(CType(e.ClickedItem.Tag, Webseite).Url)
            Catch ex As Exception
                MsgBox("Fehler beim Laden der Webseite. Bitte prüfen Sie die URL!", , "Fehler")
            End Try

        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Programm Schnellverknüpfungen bearbeiten
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub BearbeiteProgrammeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BearbeiteProgrammeToolStripMenuItem.Click
            Dim frmProgramme As New FrmProgramme(_settings.Programme)

            frmProgramme.lblTitel.Text = "Hier können Sie neue Programmverknüpfungen hinzufügen oder vorhandene löschen."
            frmProgramme.Text = "Programme bearbeiten"
            frmProgramme.ShowDialog()

            ' Kontextmenü aktualisieren
            LadeProgramme()

            _controller.SaveSettings()

        End Sub



        ''' <author></author>
        ''' <summary>
        ''' Ausgewählte Schnellverknüpfung (Webseite) laden.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ProgrammClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsProgramme.ItemClicked
            Try
                Process.Start(CType(e.ClickedItem.Tag, Programm).Pfad)
            Catch ex As Exception
                MsgBox("Fehler beim Öffnen des Programmes. Bitte prüfen Sie den Pfad!", , "Fehler")
            End Try

        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Programm Schnellverknüpfung öffnen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
            cmsProgramme.Show(Cursor.Position)
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Kontextmenü für Schnellverknüpfung auf E-Mail Ordner
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
            cmsEmail.Show(Cursor.Position)
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' E-Mail Schnellverknüpfung öffnen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ÖffnenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem1.Click
            Try
                Process.Start(tooltxtEMail.Text)
            Catch ex As Exception
                MsgBox("Fehler beim Laden der Webseite. Bitte prüfen Sie die URL!", , "Fehler")
            End Try
        End Sub




        ''' <author></author>
        ''' <summary>
        ''' Speichern der E-Mail Url
        ''' Zwischenlösung, da "Leave" Event nicht richtig geworfen wird.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub tooltxtEMail_TextChanged(sender As Object, e As EventArgs) Handles tooltxtEMail.TextChanged
            ' Url in Settings speichern
            _settings.EmailUrl = tooltxtEMail.Text

        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Stellenbeschreibung in Form von Datei öffnen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnStellenbeschreibung_Click(sender As Object, e As EventArgs) Handles btnStellenbeschreibung.Click
            Try
                Process.Start(CType(_bindingSource.Current, Stellenangebot).StellenBeschreibung.Pdf)
            Catch ex As Exception

                ' Todo: Fehlermeldung spezifizieren
                MsgBox("Fehler beim Öffnen der Datei!")
            End Try
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Stellenangebot löschen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub StellenangebotLöschenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StellenangebotLöschenToolStripMenuItem.Click
            Dim stelle As Stellenangebot = TryCast(_bindingSource.Current, Stellenangebot)
            If stelle IsNot Nothing Then
                If MsgBox("Möchten Sie die Stelle " + stelle.Stellenbezeichnung + " wirklich löschen?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = DialogResult.Yes Then
                    _controller.DeleteStelle(stelle)
                End If
            End If

        End Sub

        ' "Databinding" für Comboboxen Bewerbungswege mit Ansprechpartner

        Private Sub chkPost_Leave(sender As Object, e As EventArgs) Handles chkPost.Leave
            Dim wegeList As List(Of Bewerbungsweg) = TryCast(_bindingSource.Current, Stellenangebot).Bewerbungswege
            Dim bWeg As Bewerbungsweg

            If chkPost.Checked Then

                ' Bewerbungsweg in Liste suchen
                bWeg = wegeList.Find(Function(p) p.Weg = Bewerbungsweg.Typ.Post)

                ' Bewerbungsweg noch nicht vorhanden? Dann anlegen
                If IsNothing(bWeg) Then
                    bWeg = New Bewerbungsweg(Bewerbungsweg.Typ.Post)
                    wegeList.Add(bWeg)
                End If

                ' Ansprechpartner setzen
                bWeg.Ansprechpartner = CType(cmbPostAnsprech.SelectedItem, Ansprechpartner)

            Else
                ' Bewerbungsweg löschen
                wegeList.RemoveAll(Function(p) p.Weg = Bewerbungsweg.Typ.Post)
            End If
        End Sub

        Private Sub cmbPostAnsprech_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPostAnsprech.SelectionChangeCommitted
            Dim wegeList As List(Of Bewerbungsweg) = TryCast(_bindingSource.Current, Stellenangebot).Bewerbungswege
            Dim bWeg As Bewerbungsweg

            ' Bewerbungsweg in Liste suchen
            bWeg = wegeList.Find(Function(p) p.Weg = Bewerbungsweg.Typ.Post)

            ' Ansprechpartner setzen
            bWeg.Ansprechpartner = CType(cmbPostAnsprech.SelectedItem, Ansprechpartner)

        End Sub

        Private Sub chkTelefon_Leave(sender As Object, e As EventArgs) Handles chkTelefon.Leave
            Dim wegeList As List(Of Bewerbungsweg) = TryCast(_bindingSource.Current, Stellenangebot).Bewerbungswege
            Dim bWeg As Bewerbungsweg

            If chkTelefon.Checked Then

                ' Bewerbungsweg in Liste suchen
                bWeg = wegeList.Find(Function(p) p.Weg = Bewerbungsweg.Typ.Telefon)

                ' Bewerbungsweg noch nicht vorhanden? Dann anlegen
                If IsNothing(bWeg) Then
                    bWeg = New Bewerbungsweg(Bewerbungsweg.Typ.Telefon)
                    wegeList.Add(bWeg)
                End If

                ' Ansprechpartner setzen
                bWeg.Ansprechpartner = CType(cmbTelefonAnsprech.SelectedItem, Ansprechpartner)

            Else
                ' Bewerbungsweg löschen
                wegeList.RemoveAll(Function(p) p.Weg = Bewerbungsweg.Typ.Telefon)
            End If
        End Sub

        Private Sub cmbTelefonAnsprech_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTelefonAnsprech.SelectionChangeCommitted
            Dim wegeList As List(Of Bewerbungsweg) = TryCast(_bindingSource.Current, Stellenangebot).Bewerbungswege
            Dim bWeg As Bewerbungsweg

            ' Bewerbungsweg in Liste suchen
            bWeg = wegeList.Find(Function(p) p.Weg = Bewerbungsweg.Typ.Telefon)

            ' Ansprechpartner setzen
            bWeg.Ansprechpartner = CType(cmbTelefonAnsprech.SelectedItem, Ansprechpartner)

        End Sub

        Private Sub chkEMail_Leave(sender As Object, e As EventArgs) Handles chkEMail.Leave
            Dim wegeList As List(Of Bewerbungsweg) = TryCast(_bindingSource.Current, Stellenangebot).Bewerbungswege
            Dim bWeg As Bewerbungsweg

            If chkEMail.Checked Then

                ' Bewerbungsweg in Liste suchen
                bWeg = wegeList.Find(Function(p) p.Weg = Bewerbungsweg.Typ.EMail)

                ' Bewerbungsweg noch nicht vorhanden? Dann anlegen
                If IsNothing(bWeg) Then
                    bWeg = New Bewerbungsweg(Bewerbungsweg.Typ.EMail)
                    wegeList.Add(bWeg)
                End If

                ' Ansprechpartner setzen
                bWeg.Ansprechpartner = CType(cmbEMailAnsprech.SelectedItem, Ansprechpartner)

            Else
                ' Bewerbungsweg löschen
                wegeList.RemoveAll(Function(p) p.Weg = Bewerbungsweg.Typ.EMail)
            End If
        End Sub

        Private Sub cmbEMailAnsprech_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbEMailAnsprech.SelectionChangeCommitted
            Dim wegeList As List(Of Bewerbungsweg) = TryCast(_bindingSource.Current, Stellenangebot).Bewerbungswege
            Dim bWeg As Bewerbungsweg

            ' Bewerbungsweg in Liste suchen
            bWeg = wegeList.Find(Function(p) p.Weg = Bewerbungsweg.Typ.EMail)

            ' Ansprechpartner setzen
            bWeg.Ansprechpartner = CType(cmbEMailAnsprech.SelectedItem, Ansprechpartner)

        End Sub

        Private Sub chkOnline_Leave(sender As Object, e As EventArgs) Handles chkOnline.Leave
            Dim wegeList As List(Of Bewerbungsweg) = TryCast(_bindingSource.Current, Stellenangebot).Bewerbungswege
            Dim bWeg As Bewerbungsweg

            If chkOnline.Checked Then

                ' Bewerbungsweg in Liste suchen
                bWeg = wegeList.Find(Function(p) p.Weg = Bewerbungsweg.Typ.Online)

                ' Bewerbungsweg noch nicht vorhanden? Dann anlegen
                If IsNothing(bWeg) Then
                    bWeg = New Bewerbungsweg(Bewerbungsweg.Typ.Online)
                    wegeList.Add(bWeg)
                End If

                ' Ansprechpartner setzen
                bWeg.OnlineFormular = txtOnlineForumlar.Text

            Else
                ' Bewerbungsweg löschen
                wegeList.RemoveAll(Function(p) p.Weg = Bewerbungsweg.Typ.Online)
            End If
        End Sub

        Private Sub txtOnlineFormular_Leave(sender As Object, e As EventArgs) Handles txtOnlineForumlar.Leave
            Dim wegeList As List(Of Bewerbungsweg) = TryCast(_bindingSource.Current, Stellenangebot).Bewerbungswege
            Dim bWeg As Bewerbungsweg

            ' Bewerbungsweg in Liste suchen
            bWeg = wegeList.Find(Function(p) p.Weg = Bewerbungsweg.Typ.Online)

            ' Ansprechpartner setzen
            bWeg.OnlineFormular = txtOnlineForumlar.Text

        End Sub
#End Region

#Region "Komponenten konfigurieren"

        ''' <author></author>
        ''' <summary>
        ''' Konfiguriert das DataListView (z.B Delegaten setzen, die die Spalten formatieren)
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub KonfiguriereListView()

            If _settings.MainListViewSettings IsNot Nothing Then
                dlstvStellenangebote.RestoreState(_settings.MainListViewSettings)
            End If


            columnVersendet.AspectToStringConverter = Function(value As Object)
                                                          If DirectCast(value, Nullable(Of Date)).HasValue Then
                                                              Return DirectCast(value, Date).ToString("dd.MM.yyyy")
                                                          Else
                                                              Return "Nicht versendet"
                                                          End If
                                                      End Function

            columnErfasst.AspectToStringConverter = Function(value As Object)
                                                        Return DirectCast(value, Date).ToString("dd.MM.yyyy")
                                                    End Function

            columnTerminUhrzeit.AspectToStringConverter = Function(value As Object)
                                                              Return DirectCast(value, DateTime).ToString("dd.MM.yyyy HH:mm \U\h\r")
                                                          End Function

            columnVersendet.GroupKeyGetter = Function(value As Object)
                                                 Dim stelle As Stellenangebot = TryCast(value, Stellenangebot)

                                                 If stelle.DatumVersendet.HasValue Then
                                                     Return New Date(stelle.DatumVersendet.Value.Year, stelle.DatumVersendet.Value.Month, 1)
                                                 Else
                                                     Return Nothing
                                                 End If

                                             End Function

            columnVersendet.GroupKeyToTitleConverter = Function(key As Object)
                                                           If key IsNot Nothing Then
                                                               Return DirectCast(key, Date).ToString("MMMM yyyy")
                                                           Else
                                                               Return "Nicht versendet"
                                                           End If
                                                       End Function

            columnErfasst.GroupKeyGetter = Function(value As Object)
                                               Dim stelle As Stellenangebot = TryCast(value, Stellenangebot)
                                               Return New Date(stelle.DatumErfasst.Year, stelle.DatumErfasst.Month, 1)
                                           End Function

            columnErfasst.GroupKeyToTitleConverter = Function(key As Object)
                                                         Return DirectCast(key, Date).ToString("MMMM yyyy")
                                                     End Function

            columnTerminAnsprechpartner.AspectToStringConverter = Function(value As Object)
                                                                      If Not IsNothing(TryCast(value, Ansprechpartner)) Then
                                                                          Return TryCast(value, Ansprechpartner).Name
                                                                      Else
                                                                          Return String.Empty
                                                                      End If

                                                                  End Function


            ' Textoverlay für Termine Listview
            Dim textOverlay As TextOverlay = TryCast(dlstvTermine.EmptyListMsgOverlay, TextOverlay)
            textOverlay.Text = "Keine Termine vorhanden." + vbNewLine + vbNewLine + "Termin anlegen?"

            textOverlay.TextColor = Color.DarkGray
            textOverlay.BackColor = Color.White
            textOverlay.BorderColor = Color.White
            textOverlay.BorderWidth = 0.0F
            textOverlay.Font = New Font("Arial", 24)
            'textOverlay.Rotation = -5



        End Sub



        ''' <author></author>
        ''' <summary>
        ''' Setzt die DataBindings der Textfelder
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub SetzeDataBindings()
            ' Binding für DateTimePicker. Format / Parse Events müssen verarbeitet werden, damit 'NULL' Werte verarbeitet werden können.
            _bindDtp = New Binding("value", _bindingSource, "DatumVersendet", True, DataSourceUpdateMode.OnPropertyChanged)
            dtpVerschickt.DataBindings.Add(_bindDtp)

            ' Dim bindChkEmail As Binding = New Binding("checked", _bindingSource, "Bewerbungswege", True)
            ' chkEMail.DataBindings.Add(bindChkEmail)

            AddHandler _bindDtp.Format, AddressOf DateTimePickerNullableFormat
            AddHandler _bindDtp.Parse, AddressOf DateTimePickerNullableParse




            txtStellenbezeichnung.DataBindings.Add("text", _bindingSource, "Stellenbezeichnung")
            txtStellennummer.DataBindings.Add("text", _bindingSource, "Stellennummer")
            dtpErfasst.DataBindings.Add("value", _bindingSource, "DatumErfasst")


            txtFName.DataBindings.Add("text", _bindingSource, "Firma.Firmenname")
            txtFStrasse.DataBindings.Add("text", _bindingSource, "Firma.Straße")
            txtFPLZ.DataBindings.Add("text", _bindingSource, "Firma.PLZ")
            txtFOrt.DataBindings.Add("text", _bindingSource, "Firma.Ort")
            txtFTelefon.DataBindings.Add("text", _bindingSource, "Firma.Telefon")
            txtFFax.DataBindings.Add("text", _bindingSource, "Firma.Fax")
            txtFEMail.DataBindings.Add("text", _bindingSource, "Firma.EMail")
            txtFHomepage.DataBindings.Add("text", _bindingSource, "Firma.Homepage")
            txtNotizenStellendaten.DataBindings.Add("text", _bindingSource, "Notizen")


            txtDBNotizen.DataBindings.Add("text", _bindingSource, "Notizen")
            lblDBStatus.DataBindings.Add("text", _bindingSource, "StatusAsLongString")



            dlstvAnsprechpartner.DataMember = "Firma.Ansprechpartner"
            dlstvAnsprechpartner.DataSource = _bindingSource

            txtAEMail.DataBindings.Add("text", _bindingSource, "Firma.Ansprechpartner.EMail")
            txtAFax.DataBindings.Add("text", _bindingSource, "Firma.Ansprechpartner.Fax")
            txtAName.DataBindings.Add("text", _bindingSource, "Firma.Ansprechpartner.Name")
            txtAPosition.DataBindings.Add("text", _bindingSource, "Firma.Ansprechpartner.Position")
            txtATelefon.DataBindings.Add("text", _bindingSource, "Firma.Ansprechpartner.Telefon")

            cmbAAnrede.DataBindings.Add("SelectedIndex", _bindingSource, "Firma.Ansprechpartner.Anrede")





            dlstvTermine.DataMember = "Termine"
            dlstvTermine.DataSource = _bindingSource





            cmbPostAnsprech.DataBindings.Add("enabled", chkPost, "checked")
            cmbEMailAnsprech.DataBindings.Add("enabled", chkEMail, "checked")


            cmbTelefonAnsprech.DataBindings.Add("enabled", chkTelefon, "checked")

            txtOnlineForumlar.DataBindings.Add("enabled", chkOnline, "checked")





        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Formfür neuen Termin anzeigen
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ShowNeuerTerminForm()
            Dim stelle As Stellenangebot = DirectCast(_bindingSource.Current, Stellenangebot)
            If stelle IsNot Nothing Then
                Dim frmTermin As FrmNeuerTermin = New FrmNeuerTermin(stelle)
                frmTermin.Show()
                frmTermin.Location = Cursor.Position
            End If
        End Sub

#End Region

#Region "Komponenten aktualisieren"

        ''' <author></author>
        ''' <summary>
        ''' Schaltet die Felder für Ansprechpartner ein / aus, je nachdem, ob bereits ein Ansprechpartner vorhanden ist.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub StatusFelderAnsprechpartner(sender As Object, e As EventArgs) 'Handles btnAddAnsprechpartner.Click, btnDelAnsprechpartner.Click
            Dim state = TryCast(_bindingSource.Current, Stellenangebot).Firma.Ansprechpartner.Count > 0

            txtAEMail.Enabled = state
            txtAFax.Enabled = state
            txtAName.Enabled = state
            txtAPosition.Enabled = state
            txtATelefon.Enabled = state
            cmbAAnrede.Enabled = state

        End Sub


        ''' <author></author>
        ''' <summary>
        ''' "Sammel"-Methode, ruft alle Methoden auf, die die Komponenten (wie den Kalender, Kontextmenü, etc.) konfiguriert.
        ''' </summary>
        ''' <param name="stelle"></param>
        ''' <remarks></remarks>
        Private Sub AktualisiereKomponenten(stelle As Stellenangebot)
            AktualisiereKalender()
            KonfiguriereKontextMenue(stelle)
            ZeigeStellenverlauf(stelle)

            AktualisiereStellendaten(stelle)
            _bindDtp.ReadValue()
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Aktualisiert die Stellendaten, die (noch) nicht über das globale DataBinding geregelt werden.
        ''' </summary>
        ''' <param name="stelle"></param>
        ''' <remarks></remarks>
        Private Sub AktualisiereStellendaten(stelle As Stellenangebot)
            ' Ansprechpartner in Comboboxen anzeigen
            _bindingSourceAnsprechpartnerEMail.DataSource = stelle.Firma.Ansprechpartner
            cmbEMailAnsprech.DataSource = _bindingSourceAnsprechpartnerEMail
            cmbEMailAnsprech.DisplayMember = "Name"
            _bindingSourceAnsprechpartnerPost.DataSource = stelle.Firma.Ansprechpartner
            cmbPostAnsprech.DataSource = _bindingSourceAnsprechpartnerPost
            cmbPostAnsprech.DisplayMember = "Name"
            _bindingSourceAnsprechpartnerTelefon.DataSource = stelle.Firma.Ansprechpartner
            cmbTelefonAnsprech.DataSource = _bindingSourceAnsprechpartnerTelefon
            cmbTelefonAnsprech.DisplayMember = "Name"

            ' Checkboxen aktivieren, wenn Bewerbungsweg vorhanden
            Dim bWegEmail = stelle.Bewerbungswege.Find(Function(w) w.Weg = Bewerbungsweg.Typ.EMail)
            Dim bWegOnline = stelle.Bewerbungswege.Find(Function(w) w.Weg = Bewerbungsweg.Typ.Online)
            Dim bWegPost = stelle.Bewerbungswege.Find(Function(w) w.Weg = Bewerbungsweg.Typ.Post)
            Dim bWegTelefon = stelle.Bewerbungswege.Find(Function(w) w.Weg = Bewerbungsweg.Typ.Telefon)

            chkEMail.Checked = Not IsNothing(bWegEmail)
            chkOnline.Checked = Not IsNothing(bWegOnline)
            chkPost.Checked = Not IsNothing(bWegPost)
            chkTelefon.Checked = Not IsNothing(bWegTelefon)

            If chkEMail.Checked Then
                cmbEMailAnsprech.SelectedItem = bWegEmail.Ansprechpartner
            End If
            If chkOnline.Checked Then
                txtOnlineForumlar.Text = bWegOnline.OnlineFormular
            End If
            If chkPost.Checked Then
                cmbPostAnsprech.SelectedItem = bWegPost.Ansprechpartner
            End If
            If chkTelefon.Checked Then
                cmbTelefonAnsprech.SelectedItem = bWegTelefon.Ansprechpartner
            End If


            ' Handler wird dafür benutzt, die Textfelder für den Ansprechpartner auf Tab 2 zu aktivieren / deaktivieren.
            ' Es wir dein eigener Handler benutzt, da das ListChange Event der Ansprechpartner-Liste in der Firma nicht bis zur BindingSource weitergeleitet wird. Muss noch geprüft werden, warum
            AddHandler stelle.Firma.Ansprechpartner.ListChanged, AddressOf StatusFelderAnsprechpartner
            'AddHandler stelle.Firma.PropertyChanged, AddressOf 
            StatusFelderAnsprechpartner(Me, Nothing)


        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Markiert im Kalender alle Tage fett, an denen ein Termin ist.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub AktualisiereKalender()
            Dim dict As Dictionary(Of Date, List(Of String)) = New Dictionary(Of Date, List(Of String))
            For Each stelle As Stellenangebot In _controller.StellenList
                For Each termin As Termin In stelle.Termine
                    MonthCalendar1.AddBoldedDate(termin.ShortDatum)
                    If Not dict.ContainsKey(termin.ShortDatum) Then
                        dict.Add(termin.ShortDatum, New List(Of String)())
                    End If
                    dict.Item(termin.ShortDatum).Add(termin.Bezeichnung + " bei " + stelle.Firma.Firmenname + " um " + termin.UhrzeitAsString)
                Next
            Next
            MonthCalendar1.Tag = dict
            MonthCalendar1.UpdateBoldedDates()
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Konfiguriert das Kontextmenü für das Listview. Deaktiviert nicht benutzbare Felder
        ''' </summary>
        ''' <param name="stelle"></param>
        ''' <remarks></remarks>
        Private Sub KonfiguriereKontextMenue(stelle As Stellenangebot)
            ' Erst mal alle aktivieren
            For Each item As Object In cmsListView.Items
                If TypeOf item Is ToolStripMenuItem Then
                    DirectCast(item, ToolStripMenuItem).Enabled = True
                End If
            Next

            ' Bereits eine Absage / Zusage erhalten? Dann alles deaktivieren und Sub verlassen
            ' If stelle.Status = Stellenangebot.Stati.Absage Or stelle.Status = Stellenangebot.Stati.Zusage Then
            ' BewerbungAlsVersendetMarkierenToolStripMenuItem.Enabled = False
            ' RückmeldungVonFirmaErhaltenToolStripMenuItem.Enabled = False
            ' Return
            ' End If

            ' Als versendet nur makieren, wenn nicht bereits geschehen. Außerdem alle anderen Felder deaktivieren
            If stelle.DatumVersendet.HasValue Then
                BewerbungAlsVersendetMarkierenToolStripMenuItem.Enabled = False
            Else
                BewerbungAlsVersendetMarkierenToolStripMenuItem.Enabled = True
                RückmeldungVonFirmaErhaltenToolStripMenuItem.Enabled = False
            End If

            ' Bewerbung bereits versendet?
            BewerbungAlsVersendetMarkierenToolStripMenuItem.Enabled = Not stelle.DatumVersendet.HasValue

            ' Dasselbe für die Eingangsbestätigung
            EingangsbestätigungErhaltenToolStripMenuItem.Enabled = Not stelle.EingangsbestaetigungErhalten And stelle.Status = Stellenangebot.Stati.Wartet



        End Sub



        ''' <summary>
        ''' Zeigt den gesamten Stellen Verlauf an. Wird noch modifiziert und später in den Stellendaten angezeigt. Wurde vorher im Dashboard genutzt, ist quasi al Backup momentan da
        ''' </summary>
        ''' <param name="stelle"></param>
        ''' <remarks></remarks>
        Private Sub ZeigeStellenverlauf(stelle As Stellenangebot)
            Dim t As Termin
            Dim txt As String = String.Empty
            Dim n As Integer = 0

            grpbVerlauf.Text = "Verlauf von: " + stelle.Stellenbezeichnung + " bei " + stelle.Firma.Firmenname

            With lboxVerlauf
                .Items.Clear()
                .Items.Add("")
                .Items.Add("Bewerbung erfasst am " + stelle.DatumErfasst.ToString("dd.MM.yyyy"))
                .Items.Add("")
                If stelle.DatumVersendet.HasValue Then
                    .Items.Add("Bewerbung versendet am " + stelle.DatumVersendet.Value.ToString("dd.MM.yyyy"))
                    .Items.Add("")
                End If
                If stelle.Termine.Count > 0 Then
                    ' Jetzt alle anstehenden Termine. Sollte später noch optimiert werden, sodass die Liste nicht zweimal durchlaufen werden muss

                    For i As Integer = 0 To stelle.Termine.Count - 1
                        t = stelle.Termine(i)
                        ' Nur zukünftige Termine
                        If t.Datum > DateTime.Now Then
                            n += 1
                        End If
                    Next

                    If n > 0 Then
                        ' Eintrag hinzufügen
                        txt = "Anstehende Termine: " + n.ToString()
                        .Items.Add(txt)
                    End If

                End If
            End With
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Lädt die Stellenbeschreibung (momentan nur Webseite) und zeigt sie an.
        ''' </summary>
        ''' <param name="stelle"></param>
        ''' <remarks></remarks>
        Private Sub LadeStellenbeschreibung(stelle As Stellenangebot)
            Select Case stelle.StellenBeschreibung.Typ
                Case StellenBeschreibung.BeschreibungTyp.PDF
                    lblStellenbeschreibungPfad.Text = CType(_bindingSource.Current, Stellenangebot).StellenBeschreibung.Pdf
                    WebBrowserBeschreibung.Visible = False
                    txtStellenbeschreibung.Visible = False
                    btnStellenbeschreibung.Visible = True
                    lblStellenbeschreibungPfad.Visible = True
                Case StellenBeschreibung.BeschreibungTyp.Webseite
                    WebBrowserBeschreibung.Visible = True
                    txtStellenbeschreibung.Visible = False
                    btnStellenbeschreibung.Visible = False
                    lblStellenbeschreibungPfad.Visible = False
                    WebBrowserBeschreibung.Navigate(stelle.StellenBeschreibung.Url)
                Case StellenBeschreibung.BeschreibungTyp.Text
                    WebBrowserBeschreibung.Visible = False
                    txtStellenbeschreibung.Visible = True
                    btnStellenbeschreibung.Visible = False
                    lblStellenbeschreibungPfad.Visible = False
                    txtStellenbeschreibung.Text = stelle.StellenBeschreibung.Text

            End Select
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Füllt das Kontextmenü mit den gespeicherten Webseiten für den Schnellzugriff
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub LadeProgramme()
            Dim toolItem As ToolStripMenuItem
            cmsProgramme.Items.Clear()
            For Each programm As Programm In _settings.Programme

                toolItem = New ToolStripMenuItem()
                toolItem.Tag = programm
                toolItem.Text = programm.Name
                cmsProgramme.Items.Add(toolItem)
            Next
        End Sub



        ''' <author></author>
        ''' <summary>
        ''' Füllt das Kontextmenü mit den gespeicherten Webseiten für den Schnellzugriff
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub LadeWebseiten()
            Dim toolItem As ToolStripMenuItem
            cmsWebseiten.Items.Clear()
            For Each webseite As Webseite In _settings.Webseiten
                ' Todo: Benutzerdefinierten Namen für die Webseiten angeben
                toolItem = New ToolStripMenuItem()
                toolItem.Tag = webseite
                toolItem.Text = webseite.Name
                cmsWebseiten.Items.Add(toolItem)
            Next
        End Sub

#End Region

#Region "Kontextmenü"

        ''' <author></author>
        ''' <summary>
        ''' Setz den Status einer Stellenanzeige / Bewerbung auf "Eingangsbestätigung erhalten / Warte auf Rückmeldung"
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub EingangsbestätigungErhaltenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EingangsbestätigungErhaltenToolStripMenuItem.Click
            TryCast(_bindingSource.Current, Stellenangebot).EingangsbestaetigungErhalten = True
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Markiert eine Bewerbung als "versendet" und setzt den Status auf "Warte auf Rückmeldung"
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub BewerbungAlsVersendetMarkierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerbungAlsVersendetMarkierenToolStripMenuItem.Click
            TryCast(_bindingSource.Current, Stellenangebot).DatumVersendet = Date.Today
        End Sub


        ''' <author>Mirco Kriestem</author>
        ''' <summary>
        ''' Setzt den Status der Bewerbung auf "Unterlagen Unterlagen". 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub InformationenNachreichenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationenNachreichenToolStripMenuItem.Click
            TryCast(_bindingSource.Current, Stellenangebot).Status = Stellenangebot.Stati.Unterlagen
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Setzt den Status auf "Absage"
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub AbsageErhaltenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsageErhaltenToolStripMenuItem.Click
            TryCast(_bindingSource.Current, Stellenangebot).Status = Stellenangebot.Stati.Absage
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Setzt den Status auf "Zusage"
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ZusageErhalteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZusageErhalteToolStripMenuItem.Click
            TryCast(_bindingSource.Current, Stellenangebot).Status = Stellenangebot.Stati.Zusage
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Zeigt ein Form an, mit dem ein neuer Termin hinzugefügt werden kann.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub NeuerTerminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NeuerTerminToolStripMenuItem.Click, NeuerTerminToolStripMenuItem1.Click
            ShowNeuerTerminForm()
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Erstellt Form für eine neue Stelle / Bewerbung und zeigt dieses an.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub NeueBewerbungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeueBewerbungToolStripMenuItem.Click
            Dim frm As FrmNeueBewerbung = New FrmNeueBewerbung()
            AddHandler frm.FormClosing, AddressOf NeueStelleFormClosing
            frm.ShowDialog()
        End Sub

#End Region

#Region "Kalender"

        ''' <author></author>
        ''' <summary>
        ''' Versteckt das Info-Fenster wieder
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MonthCalendar1_MouseMove(sender As Object, e As MouseEventArgs) Handles MonthCalendar1.MouseMove
            _frmTerminInfo.Hide()
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Zeigt ein kleines Info-Fenster an, welche Termeine an dem ausgewählten Tag stattfinden
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MonthCalendar1_MouseUp(sender As Object, e As MouseEventArgs) Handles MonthCalendar1.MouseUp
            Dim p As Point = (MonthCalendar1.PointToClient(Cursor.Position))
            Dim hit As MonthCalendar.HitTestInfo = MonthCalendar1.HitTest(p)
            If MonthCalendar1.BoldedDates.Contains(hit.Time) Then
                Dim dict As Dictionary(Of Date, List(Of String)) = CType(MonthCalendar1.Tag, Dictionary(Of Date, List(Of String)))
                _frmTerminInfo.lblDatum.Text = hit.Time.ToString("dd.MM.yyyy")
                _frmTerminInfo.lstbTermine.Items.Clear()
                For Each str As String In dict.Item(hit.Time)
                    _frmTerminInfo.lstbTermine.Items.Add(str)
                Next
                Dim p2 As Point = New Point()
                If (Cursor.Position.X + _frmTerminInfo.Size.Width) > Screen.FromControl(Me).WorkingArea.Width Then
                    ' Funktioniert irgendwie nicht. Muss noch gefixt werden.
                    p2.X = Cursor.Position.X '- _frmTerminInfo.Size.Width
                Else
                    p2.X = Cursor.Position.X
                End If
                p2.Y = Cursor.Position.Y
                _frmTerminInfo.Location = p2
                _frmTerminInfo.Show()
            End If
        End Sub

#End Region





    End Class
End Namespace