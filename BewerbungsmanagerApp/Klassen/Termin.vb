Imports System.ComponentModel

Namespace Klassen

    ''' <author></author>
    ''' <summary>
    ''' Klasse für Termine.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Termin
        Implements IComparable(Of Termin), INotifyPropertyChanged

#Region "Enums"
        Public Enum TerminTyp
            VorOrt
            Telefonat
        End Enum
#End Region

#Region "Private Felder"
        ' Typ wird momentan nicht genutzt
        Private _typ As TerminTyp
        Private _datum As DateTime
        Private _ansprechpartner As Ansprechpartner
        Private _bezeichnung As String
        Private _notizen As String
#End Region

#Region "Properties"
        Public ReadOnly Property Typ As TerminTyp
            Get
                Return _typ
            End Get

        End Property

        Public Property Datum As DateTime
            Get
                Return _datum
            End Get
            Set(value As DateTime)
                _datum = value
                OnPropertyChanged("Datum")
            End Set
        End Property
        Public ReadOnly Property ShortDatum As DateTime
            Get
                Return New DateTime(_datum.Year, _datum.Month, _datum.Day)
            End Get
        End Property
        Public ReadOnly Property UhrzeitAsString As String
            Get
                Return _datum.ToString("HH:mm \U\h\r")
            End Get
        End Property

        Public Property Ansprechpartner As Ansprechpartner
            Get
                Return _ansprechpartner
            End Get
            Set(value As Ansprechpartner)
                _ansprechpartner = value
                OnPropertyChanged("Ansprechpartner")
            End Set
        End Property

        Public Property Bezeichnung As String
            Get
                Return _bezeichnung
            End Get
            Set(value As String)
                _bezeichnung = value
                OnPropertyChanged("Bezeichnung")
            End Set
        End Property

        Public Property Notizen As String
            Get
                Return _notizen
            End Get
            Set(value As String)
                _notizen = value
                OnPropertyChanged("Notizen")
            End Set
        End Property

#End Region

#Region "Konstruktoren"
        Public Sub New()

        End Sub
        Public Sub New(datum As DateTime, typ As TerminTyp, Optional ansprechpartner As Ansprechpartner = Nothing, Optional bezeichnung As String = "")
            _datum = datum
            _typ = typ
            _ansprechpartner = ansprechpartner
            _bezeichnung = bezeichnung
        End Sub
#End Region

#Region "Methoden"
        Public Function CompareTo(other As Termin) As Integer Implements IComparable(Of Termin).CompareTo
            Return Datum.CompareTo(other.Datum)
        End Function
#End Region

#Region "Events"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub OnPropertyChanged(prop As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(prop))
        End Sub
#End Region
    End Class
End Namespace