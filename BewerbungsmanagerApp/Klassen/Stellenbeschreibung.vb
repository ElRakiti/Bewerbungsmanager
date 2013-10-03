Imports System.ComponentModel
Imports System.IO

Namespace Klassen

    ''' <author></author>
    ''' <summary>
    ''' Klasse für Stellenbeschreibung. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class StellenBeschreibung
        Implements INotifyPropertyChanged

#Region "Enums"
        Public Enum BeschreibungTyp
            Webseite
            PDF
            Text
        End Enum
#End Region

#Region "Private Felder"
        Private _url As String
        Private _pdf As Object
        Private _text As String
        Private _typ As BeschreibungTyp
#End Region

#Region "Properties"
        Public Property Url As String
            Get
                Return _url
            End Get
            Set(value As String)
                _url = value
                OnPropertyChanged("Url")
            End Set
        End Property

        Public Property Pdf As String
            Get
                Return _pdf.ToString()
            End Get
            Set(value As String)
                _pdf = value
                OnPropertyChanged("Pdf")
            End Set
        End Property

        Public Property Text As String
            Get
                Return _text
            End Get
            Set(value As String)
                _text = value
                OnPropertyChanged("Text")
            End Set
        End Property

        Public ReadOnly Property Typ As BeschreibungTyp
            Get
                Return _typ
            End Get
        End Property

#End Region

#Region "Konstruktor"
        Public Sub New(typ As BeschreibungTyp)
            _typ = typ
        End Sub
#End Region

#Region "Events"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub OnPropertyChanged(prop As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(prop))
        End Sub
#End Region
    End Class
End Namespace