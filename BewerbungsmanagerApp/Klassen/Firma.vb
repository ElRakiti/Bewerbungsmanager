Imports System.ComponentModel

Namespace Klassen

    ''' <author></author>
    ''' <summary>
    ''' Klasse für die Firma. Zu der Firma gehören auch alle Ansprechpartner, die in einer BindingList (of Ansprechpartner) als Property gespeichert werden.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Firma
        Implements INotifyPropertyChanged

#Region "Private Felder"
        Private _ansprechpartner As BindingList(Of Ansprechpartner) = New BindingList(Of Ansprechpartner)
        Private _email As String
        Private _fax As String
        Private _firmenname As String
        Private _homepage As String
        Private _ort As String
        Private _plz As Integer
        Private _straße As String
        Private _telefon As String
#End Region

#Region "Properties"

        Public Property Firmenname As String
            Get
                Return _firmenname
            End Get
            Set(value As String)
                _firmenname = value
                OnPropertyChanged("Firmenname")
            End Set
        End Property

        Public Property Ansprechpartner As BindingList(Of Ansprechpartner)
            Get
                Return _ansprechpartner
            End Get
            Set(value As BindingList(Of Ansprechpartner))
                _ansprechpartner = value
                OnPropertyChanged("Ansprechpartner")
            End Set
        End Property

        Public Property Email As String
            Get
                Return _email
            End Get
            Set(value As String)
                _email = value
                OnPropertyChanged("EMail")
            End Set
        End Property

        Public Property Fax As String
            Get
                Return _fax
            End Get
            Set(value As String)
                _fax = value
                OnPropertyChanged("Fax")
            End Set
        End Property

        Public Property Homepage As String
            Get
                Return _homepage
            End Get
            Set(value As String)
                _homepage = value
                OnPropertyChanged("Homepage")
            End Set
        End Property

        Public Property Ort As String
            Get
                Return _ort
            End Get
            Set(value As String)
                _ort = value
                OnPropertyChanged("Ort")
            End Set
        End Property

        Public Property Plz As Integer
            Get
                Return _plz
            End Get
            Set(value As Integer)
                _plz = value
                OnPropertyChanged("PLZ")
            End Set
        End Property

        Public Property Straße As String
            Get
                Return _straße
            End Get
            Set(value As String)
                _straße = value
                OnPropertyChanged("Straße")
            End Set
        End Property

        Public Property Telefon As String
            Get
                Return _telefon
            End Get
            Set(value As String)
                _telefon = value
                OnPropertyChanged("Telefon")
            End Set
        End Property

#End Region

#Region "Konstruktoren"

        Public Sub New()

        End Sub

        Public Sub New(name As String)
            _firmenname = name
            _ansprechpartner.RaiseListChangedEvents = True
            AddHandler _ansprechpartner.ListChanged, AddressOf OnAnsprechpartnerChanged
        End Sub
#End Region

#Region "Events"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        ''' <author></author>
        ''' <summary>
        ''' Eventhandler. Registriert, wenn sich Eigenschaften der Ansprechpartner ändern und wirft wiederrum ein PropertyChanged Event dieser Klasse, damit die Änderung wie eine Änderung des Firmennames erkannt werden kann.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub OnAnsprechpartnerChanged(sender As Object, e As ListChangedEventArgs)
            Console.Out.WriteLine("Ansprechpartner changed")
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Ansprechpartner"))
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Eventhandler, kapselt das PropertyChanged Event, damit der Aufruf einfacher ist.
        ''' </summary>
        ''' <param name="prop"></param>
        ''' <remarks></remarks>
        Private Sub OnPropertyChanged(prop As String)
            Console.Out.WriteLine(prop + " changed")
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(prop))
        End Sub


#End Region
    End Class
End Namespace