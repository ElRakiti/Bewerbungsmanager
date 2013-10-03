Imports System.ComponentModel

Namespace Klassen

    ''' <author></author>
    ''' <summary>
    ''' Klasse für den Ansprechpartner.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Ansprechpartner
        Implements INotifyPropertyChanged

#Region "Enums"
        Enum Anreden
            Leer = -1
            Herr = 0
            Frau = 1
        End Enum
#End Region

#Region "Private Fields"
        Private _email As String
        Private _fax As String
        Private _telefon As String
        Private _position As String
        Private _name As String
        Private _anrede As Anreden = Anreden.Leer
#End Region

#Region "Properties"
        Public Property Email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                _email = value
            End Set
        End Property


        Public Property Fax() As String
            Get
                Return _fax
            End Get
            Set(ByVal value As String)
                _fax = value
            End Set
        End Property


        Public Property Telefon() As String
            Get
                Return _telefon
            End Get
            Set(ByVal value As String)
                _telefon = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Name"))
            End Set
        End Property


        Public Property Position() As String
            Get
                Return _position
            End Get
            Set(ByVal value As String)
                _position = value
            End Set
        End Property

        Public Property Name As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Name"))
            End Set
        End Property

        Public Property Anrede As Anreden
            Get
                Return _anrede
            End Get
            Set(value As Anreden)
                _anrede = value
            End Set
        End Property

#End Region

#Region "Konstruktoren"

        Public Sub New()
        End Sub

        Public Sub New(name As String)
            _name = name
        End Sub
#End Region

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    End Class
End Namespace