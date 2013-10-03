Imports System.ComponentModel
Imports Bewerbungsmanager.Forms

Namespace Klassen

    ''' <author></author>
    ''' <summary>
    ''' Die Controller Klasse ist die Schnittstelle zwischen Datenbank und View. Sie kapselt die Datenbankanfragen und stellt alle benötigten Objekte dem View zur Verfügung.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Controller


#Region "Private Felder"

        Private _view As FrmMainForm
        Private _stellenList As BindingList(Of Stellenangebot) = New BindingList(Of Stellenangebot)
        Private _datahandler As Datahandler
        Private _settings As Settings

#End Region

#Region "Properties"

        Public ReadOnly Property View() As FrmMainForm
            Get
                Return _view
            End Get
        End Property

        ''' <author></author>
        ''' <summary>
        ''' StellenList ist die Referenz mit allen vorhandenen Stellen. Das View ändert direkt in dieser Liste die Stellenangebote.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public ReadOnly Property StellenList() As BindingList(Of Stellenangebot)
            Get
                Return _stellenList
            End Get
        End Property

        ''' <author></author>
        ''' <summary>
        ''' Stellt die Anwendungseinstellungen bereit, z.B. wird hier der Status der Fenster, Listviews, etc. gespeichert.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property Settings As Settings
            Get
                Return _settings
            End Get
            Set(value As Settings)
                _settings = value
            End Set
        End Property

#End Region

#Region "Events / Delegaten"

        ''' <author></author>
        ''' <summary>
        ''' Delegate. Wird aufgerufen, wenn sich die aktuell ausgewählte Stelle bzw. die Eigenschaften ändern. Stelle wird dann hier gespeichert.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub StellenListChanged(sender As Object, e As ListChangedEventArgs)

            ' Welche Änderung ist aufgetreten?
            Select Case e.ListChangedType

                ' Eine neue Stelle wurde hinzugefügt
                Case ListChangedType.ItemAdded
                    _datahandler.SaveStelleToDatabase(_stellenList.Item(e.NewIndex))

                    ' Eine vorhandene Stelle wurde verändert. Stelle ist über Index "newIndex" zu ermitteln. Über e.PropertyDescriptor lässt sich auch ermitteln, was geändert wurde.
                Case ListChangedType.ItemChanged
                    _datahandler.SaveStelleToDatabase(_stellenList.Item(e.NewIndex))

                    ' Löschen muss noch eingebaut werden.
                Case ListChangedType.ItemDeleted
                    'stelle = _stellenList.Item(e.NewIndex)
                    _datahandler.DeleteStelleFromDatabase(_stellenList.Item(e.NewIndex))

                    ' Liste wurde geleert
                Case ListChangedType.Reset

            End Select

        End Sub
#End Region

#Region "Konstruktor"
        ''' <summary>
        ''' Konstruktor
        ''' </summary>
        ''' <param name="view">Referenz auf das View / Form, dass die Stellen darstellt</param>
        ''' <remarks></remarks>
        Public Sub New(view As FrmMainForm)
            _view = view
            _datahandler = New Datahandler()
            _datahandler.GetListFromDatabase(_stellenList)
            _settings = _datahandler.LoadSettings()

            AddHandler StellenList.ListChanged, AddressOf StellenListChanged

        End Sub

#End Region

#Region "Methoden"

        ''' <author></author>
        ''' <summary>
        ''' Generiert Dummy bzw. Beispiel Stellenangebote.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub GeneriereDummys()
            Dim random = New Random()
            Dim bezeichnungen() As String = {"Softwareentwickler .Net", "Softwareentwickler Java", "Junior Consultant", "Trainee", "Praktikum", "Anwendungsentwickler", "Projektmanager" _
                                             , "Spieleentwickler", "Android Entwicklung", "Q&A", "Berater", "Projektmitarbeiter", "Studentische Hilfskraft"}
            Dim beschreibung As StellenBeschreibung

            For i = 1 To 25
                Dim stelle = New Stellenangebot()
                stelle.Stellenbezeichnung = bezeichnungen(random.Next(0, bezeichnungen.Count()))
                stelle.Firma = New Firma("Firma " + i.ToString())

                stelle.DatumErfasst = New Date(2013, random.Next(1, 4), random.Next(1, 10))
                stelle.Stellennummer = random.Next(999999).ToString()

                stelle.Notizen = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."

                stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.Post))

                beschreibung = New StellenBeschreibung(StellenBeschreibung.BeschreibungTyp.Webseite)
                beschreibung.Url = "www.stepstone.de"
                stelle.StellenBeschreibung = beschreibung

                ' Bei der Hälfte der Stellen wird der Status auf versnedet gesetzt
                If i Mod 2 = 0 Then
                    stelle.Status = Stellenangebot.Stati.Wartet
                    stelle.DatumVersendet = New Date(2013, random.Next(1, 4), random.Next(1, 10))
                    stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.EMail))

                    beschreibung = New StellenBeschreibung(StellenBeschreibung.BeschreibungTyp.Text)
                    beschreibung.Text = "Ich bin eine textuelle Beschreibung der Stelle."
                    stelle.StellenBeschreibung = beschreibung

                    stelle.AddTermin(New Termin(New DateTime(Date.Today.Year, random.Next(Date.Today.Month, Date.Today.Month + 1), random.Next(1, 30), 14, 30, 0), Termin.TerminTyp.Telefonat, Nothing, "Bewerbungsgespräch"))
                    stelle.AddTermin(New Termin(New DateTime(Date.Today.Year, random.Next(Date.Today.Month, Date.Today.Month + 1), random.Next(1, 30), 16, 0, 0), Termin.TerminTyp.VorOrt, Nothing, "Bewerbungsgespräch"))

                    If i Mod 4 = 0 Then
                        stelle.AddBewerbungsweg(New Bewerbungsweg(Bewerbungsweg.Typ.Online, "www.stepstone.de"))
                        stelle.Firma.Ansprechpartner.Add(New Ansprechpartner("Peter Pan"))
                        stelle.AddTermin(New Termin(New DateTime(Date.Today.Year, random.Next(Date.Today.Month, Date.Today.Month + 1), random.Next(1, 30), 15, 59, 0), Termin.TerminTyp.VorOrt, stelle.Firma.Ansprechpartner.Item(0), "Bewerbungsgespräch"))
                        stelle.AddTermin(New Termin(New DateTime(Date.Today.Year, random.Next(Date.Today.Month, Date.Today.Month + 1), random.Next(1, 30), 14, 30, 0), Termin.TerminTyp.Telefonat, stelle.Firma.Ansprechpartner.Item(0), "Bewerbungsgespräch"))
                        stelle.AddTermin(New Termin(New DateTime(Date.Today.Year, random.Next(Date.Today.Month, Date.Today.Month + 1), random.Next(1, 30), 14, 30, 0), Termin.TerminTyp.VorOrt, stelle.Firma.Ansprechpartner.Item(0), "Bewerbungsgespräch"))
                    End If
                End If

                _stellenList.Add(stelle)

            Next


        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Speichert alle Stellenangebote in der Datenbank
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveList()
            _datahandler.SaveListToDatabase(_stellenList)
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Speichert die Einstellungen in der Datenbank
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveSettings()
            _datahandler.SaveSettings(_settings)
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Löscht eine Stelle aus der Datenbank
        ''' </summary>
        ''' <param name="stelle"></param>
        ''' <remarks></remarks>
        Public Sub DeleteStelle(stelle As Stellenangebot)
            _datahandler.DeleteStelleFromDatabase(stelle)
            _stellenList.Remove(stelle)
        End Sub
#End Region


    End Class
End Namespace