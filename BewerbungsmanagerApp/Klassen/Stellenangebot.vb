Imports System.ComponentModel
Imports System.Reflection

Namespace Klassen

    ''' <author></author>
    ''' <summary>
    ''' Haupt(Model-)Klasse. Stellt das eigentliche Stellenangebot dar.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Stellenangebot
        Implements INotifyPropertyChanged

#Region "Enums"
        Public Enum Stati
            Offen = 0
            Wartet = 1
            Termin = 2
            Absage = 3
            Zusage = 4
            Unterlagen = 5
        End Enum
#End Region

#Region "Events"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        ''' <author></author>
        ''' <summary>
        ''' Benachrichtigt, dass sich eine Property geändert hat. Ist momentan noch nicht Refactoring-Sicher, da die Parameter Namen als String übergeben werden. Sollte noch durch Lambda-Expressions ersetzt werden.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub OnPropertyChanged(prop As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(prop))
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Delegate. Änderungen, die in Objekten passieren, werden nicht automatisch registiert. Hierfür wird auf die Events gehört und dann das PropertyChanged Event geworfen.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub OnClassPropertyChanged()
            OnPropertyChanged("Object") ' Name ist egal, da nur die eigentlich Registrierung der Änderung wichtig ist.
        End Sub


#End Region

#Region "Private Felder"
        Private _eingangsbestaetigungErhalten As Boolean
        Private _stellenBeschreibung As StellenBeschreibung
        Private _stellenbezeichnung As String
        Private _stellennummer As String
        Private _firma As Firma
        Private _status As Stati
        Private _datumErfasst As Date
        Private _datumVersendet As Nullable(Of Date)
        'Public _letzteRueckmeldung As Date
        Private _bewerbungswege As New List(Of Bewerbungsweg)
        Private _id As Guid = New Guid()
        Private _termine As BindingList(Of Termin) = New BindingList(Of Termin)
        Private _notizen As String
#End Region

#Region "Properties"
        Public ReadOnly Property Id() As Guid
            Get
                Return _id
            End Get
        End Property

        Public ReadOnly Property Termine() As BindingList(Of Termin)
            Get
                ' Termine nach Datum sortieren
                '_termine.Sort()
                ' Termine zurückgeben
                Return _termine
            End Get
        End Property
        Public Sub AddTermin(termin As Termin)
            _termine.Add(termin)
            _status = Stellenangebot.Stati.Termin
            OnPropertyChanged("Termine")
        End Sub

        Public Property Notizen() As String
            Get
                Return _notizen
            End Get
            Set(ByVal value As String)
                _notizen = value
                OnPropertyChanged("Notizen")
            End Set
        End Property

        Public Property StellenBeschreibung As StellenBeschreibung
            Get
                Return _stellenBeschreibung
            End Get
            Set(value As StellenBeschreibung)
                _stellenBeschreibung = value

                OnPropertyChanged("StellenBeschreibung")
            End Set
        End Property

        Public Property EingangsbestaetigungErhalten As Boolean
            Get
                Return _eingangsbestaetigungErhalten
            End Get
            Set(value As Boolean)
                _eingangsbestaetigungErhalten = value
                OnPropertyChanged("EingangsbestaetigungErhalten")
                OnPropertyChanged("Status")
            End Set
        End Property

        Public Property Stellenbezeichnung As String
            Get
                Return _stellenbezeichnung
            End Get
            Set(value As String)
                _stellenbezeichnung = value
                OnPropertyChanged("Stellenbezeichnung")
            End Set
        End Property

        Public Property Stellennummer As String
            Get
                Return _stellennummer
            End Get
            Set(value As String)
                _stellennummer = value
                OnPropertyChanged("Stellennummer")
            End Set
        End Property

        Public Property Firma As Firma
            Get
                Return _firma
            End Get
            Set(value As Firma)
                _firma = value

                OnPropertyChanged("Firma")
            End Set
        End Property

        Public Property Status As Stati
            Get
                Return _status
            End Get
            Set(value As Stati)
                _status = value
                OnPropertyChanged("Status")
            End Set
        End Property
        Public ReadOnly Property StatusAsShortString() As String
            Get
                Return ConvertStatusToShortString(_status, _eingangsbestaetigungErhalten)
            End Get
        End Property
        Public ReadOnly Property StatusAsLongString() As String
            Get
                Return ConvertStatusToLongString(_status, _eingangsbestaetigungErhalten)
            End Get
        End Property


        Public Property DatumVersendet As Nullable(Of Date)
            Get
                Return _datumVersendet
            End Get
            Set(value As Nullable(Of Date))
                _datumVersendet = value
                If value.HasValue Then
                    _status = Stati.Wartet
                Else
                    _status = Stati.Offen
                End If
                OnPropertyChanged("DatumVersendet")
                OnPropertyChanged("Status")
            End Set
        End Property



        Public Property DatumErfasst As Date
            Get
                Return _datumErfasst
            End Get
            Set(value As Date)
                _datumErfasst = value
                OnPropertyChanged("DatumErfasst")
            End Set
        End Property

        Public ReadOnly Property Bewerbungswege As List(Of Bewerbungsweg)
            Get
                Return _bewerbungswege
            End Get
        End Property
        Public ReadOnly Property BewerbungswegeAsString As String
            Get
                Return Bewerbungsweg.ListAsString(_bewerbungswege)
            End Get
        End Property
        Public Sub AddBewerbungsweg(bWeg As Bewerbungsweg)
            _bewerbungswege.Add(bWeg)
            ' NotifyPropertyChanged("Bewerbungswege")
        End Sub
#End Region

#Region "Konstruktor"
        Public Sub New()
            ' Auf Änderungen in der Firma hören. Muss noch angepasst werden, da die Zuweisung nicht korrekt funktioniert, wenn die Objekte aus der Datenbank geholt werden.
            ' Aktuell werden die Eventhandler im MainForm gesetzt. Sollte später hier geschehen, damit das View nur auf das PropertyChanged Event des Stellenangebots hören muss.

            'AddHandler _bewerbungswege.ListChanged, AddressOf OnClassPropertyChanged
            'AddHandler _firma.PropertyChanged, AddressOf OnClassPropertyChanged
            'AddHandler _stellenBeschreibung.PropertyChanged, AddressOf OnClassPropertyChanged
            'AddHandler Termine.ListChanged, AddressOf OnClassPropertyChanged
        End Sub
#End Region

#Region "Shared-Methods"
        ''' <author></author>
        ''' <summary>
        ''' Konvertiert einen übergebenen Status in einen detaillierten String.
        ''' </summary>
        ''' <param name="status">Zu konvertierender Status</param>
        ''' <param name="eb">Flag, ob Rückmeldung bereits erfolgt ist.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ConvertStatusToLongString(status As Stati, Optional eb As Boolean = False) As String
            Select Case status
                Case Stati.Offen
                    Return "Nicht verschickt"
                Case Stati.Wartet
                    Return IIf(eb, "Eingangsbestätigung - ", "").ToString() + "Warte auf Rückmeldung"
                Case Stati.Termin
                    Return "Anstehender Termin"
                Case Stati.Absage
                    Return "Absage erhalten"
                Case Stati.Zusage
                    Return "Zusage erhalten"
                Case Stati.Unterlagen
                    Return "Unterlagen nachreichen"
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select

        End Function

        ''' <author></author>
        ''' <summary>
        ''' Konvertiert einen übergebenen Status in einen kurzen String.
        ''' </summary>
        ''' <param name="status">Zu konvertierender Status</param>
        ''' <param name="eb">Flag, ob Rückmeldung bereits erfolgt ist.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ConvertStatusToShortString(status As Stati, Optional eb As Boolean = False) As String
            Select Case status
                Case Stati.Offen
                    Return "Offen"
                Case Stati.Wartet
                    Return IIf(eb, "EB - ", "").ToString() + "Wartet"
                Case Stati.Termin
                    Return "Termin"
                Case Stati.Absage
                    Return "Absage"
                Case Stati.Zusage
                    Return "Zusage"
                Case Stati.Unterlagen
                    Return "Unterlagen"
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select

        End Function

#End Region



    End Class
End Namespace