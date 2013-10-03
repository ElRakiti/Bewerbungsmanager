Imports System.ComponentModel

Namespace Klassen

    ''' <author></author>
    ''' <summary>
    ''' Klasse für die Anwendungseinstellungen. Hier werden z.B. die Schnellverknüpfungen oder der Zustand des Haupt-Listviews gespeichert.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Settings

#Region "Private Felder"
        Private _mainListViewSettings As Byte()
        Private _webseiten As New BindingList(Of Webseite)
        Private _programme As New BindingList(Of Programm)
        Private _emailUrl As String
        Private _tutorial As Boolean

#End Region

#Region "Properties"
        Public Property MainListViewSettings As Byte()
            Get
                Return _mainListViewSettings
            End Get
            Set(value As Byte())
                _mainListViewSettings = value
            End Set
        End Property

        Public Property Webseiten As BindingList(Of Webseite)
            Get
                Return _webseiten
            End Get
            Set(value As BindingList(Of Webseite))
                _webseiten = value
            End Set
        End Property

        Public Property Programme As BindingList(Of Programm)
            Get
                Return _programme
            End Get
            Set(value As BindingList(Of Programm))
                _programme = value
            End Set
        End Property

        Public Property EmailUrl As String
            Get
                Return _emailUrl
            End Get
            Set(value As String)
                _emailUrl = value
            End Set
        End Property

        Public Property Tutorial As Boolean
            Get
                Return _tutorial
            End Get
            Set(value As Boolean)
                _tutorial = value
            End Set
        End Property

#End Region

    End Class


    ''' <author></author>
    ''' <summary>
    ''' Schnellverknüpfungen für Programme
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Programm
        Private _pfad As String
        Private _name As String

        Public Property Pfad As String
            Get
                Return _pfad
            End Get
            Set(value As String)
                _pfad = value
            End Set
        End Property

        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property
    End Class


    ''' <author></author>
    ''' <summary>
    ''' Schnellverknüpfungen für Webseiten
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Webseite
        Private _url As String
        Private _name As String

        Public Property Url As String
            Get
                Return _url
            End Get
            Set(value As String)
                _url = value
            End Set
        End Property

        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Public Sub New()

        End Sub

        Public Sub New(url As String, name As String)
            _url = url
            _name = name
        End Sub
    End Class
End Namespace