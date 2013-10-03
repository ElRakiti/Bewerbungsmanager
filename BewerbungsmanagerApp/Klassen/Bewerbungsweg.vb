Imports System.ComponentModel

Namespace Klassen

    ''' <author></author>
    ''' <summary>
    ''' Klasse für die möglichen Bewerbungswege. Ansprechpartner bzw. das OnlineFormular (bei Online Bewerbungen) werden mit gespeichert.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Bewerbungsweg
        Implements INotifyPropertyChanged

#Region "Enums"
        Public Enum Typ
            Post = 0
            EMail = 1
            Telefon = 2
            Online = 3
        End Enum
#End Region

#Region "Events"

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub OnPropertyChanged(prop As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(prop))
        End Sub
#End Region

#Region "Private Felder"
        Private _weg As Typ
        Private _ansprechpartner As Ansprechpartner
        Private _onlineFormular As String
#End Region

#Region "Konstruktoren"
        Public Sub New(weg As Typ)
            _weg = weg
        End Sub

        ' Konstruktor für alle Bewerbungswege außer Online
        Public Sub New(weg As Typ, a As Ansprechpartner)
            _weg = weg
            Ansprechpartner = a
        End Sub

        'Konstruktor für Online Bewerbungsweg
        Public Sub New(weg As Typ, formular As String)
            _weg = weg
            OnlineFormular = formular
        End Sub
#End Region

#Region "Properties"
        Public ReadOnly Property Weg As Typ
            Get
                Return _weg
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

        Public Property OnlineFormular As String
            Get
                Return _onlineFormular
            End Get
            Set(value As String)
                _onlineFormular = value
                OnPropertyChanged("OnlineFormular")
            End Set
        End Property

#End Region

#Region "Shared Functions"
        ''' <summary>
        ''' Konvertiert eine Liste mit Bewerbungswegen in einen String
        ''' </summary>
        ''' <param name="wege"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ListAsString(wege As List(Of Bewerbungsweg)) As String
            Dim wegeString As String = ""

            For Each bweg As Bewerbungsweg In wege
                Select Case bweg.Weg
                    Case Bewerbungsweg.Typ.Post
                        wegeString += "Post" + ", "
                    Case Bewerbungsweg.Typ.EMail
                        wegeString += "E-Mail" + ", "
                    Case Bewerbungsweg.Typ.Online
                        wegeString += "Online" + ", "
                    Case Bewerbungsweg.Typ.Telefon
                        wegeString += "Telefon" + ", "
                End Select
            Next
            Return wegeString.Remove(wegeString.Length - 2, 2)

        End Function
#End Region

    End Class
End Namespace