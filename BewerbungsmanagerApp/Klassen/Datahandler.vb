Imports System.ComponentModel
Imports Db4objects.Db4o
Imports Db4objects.Db4o.Config
Imports Db4objects.Db4o.Internal.Activation

Namespace Klassen

    ''' <author></author>
    ''' <summary>
    ''' Datenbank Handling. Die Klasse führt die Datenbankabfragen durch, wie Lesen und Speichern der Stellenangebote oder Einstellungen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Datahandler

#Region "Private Felder"
        Private _database As IObjectContainer
#End Region

#Region "Konstruktor"
        ''' <author></author>
        ''' <summary>
        ''' Konstruktor.Stellenangebot 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            Dim config As IEmbeddedConfiguration = Db4oEmbedded.NewConfiguration()

            ' Kaskadierendes Update, damit sämtliche Eigenschaften (auch wenn Properties eigene Klassen sind) gespeichert werden.
            config.Common.ObjectClass(GetType(Stellenangebot)).CascadeOnUpdate(True)
            config.Common.UpdateDepth = 100

            ' Datebank wird momentan fest vorgegeben.
            ' Todo: Exceptionhandling einbauen.
            _database = Db4oEmbedded.OpenFile(config, Application.StartupPath + "\database.db")


        End Sub
#End Region

#Region "Methoden"

        ''' <author></author>
        ''' <summary>
        ''' Lädt alle Stellenangebote aus der Datenbank.
        ''' </summary>
        ''' <param name="list"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetListFromDatabase(ByRef list As BindingList(Of Stellenangebot)) As BindingList(Of Stellenangebot)
            Dim prototype As Stellenangebot = New Stellenangebot()
            Dim result As IObjectSet = _database.QueryByExample(prototype)

            While result.HasNext()
                list.Add(TryCast(result.Next(), Stellenangebot))
            End While
            Return list
        End Function

        ''' <author></author>
        ''' <summary>
        ''' Speichert alle Stellenangebote in 'list' in die Datenbank.
        ''' </summary>
        ''' <param name="list">Zu speichernde Liste mit Stellenangebote</param>
        ''' <remarks></remarks>
        Public Sub SaveListToDatabase(list As BindingList(Of Stellenangebot))
            For Each stelle As Stellenangebot In list
                _database.Store(stelle)
            Next
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Speichert eine einzelne Stelle in der Datenbank. Wird genutzt bei einer Neuanlage, damit nicht immer unnötig alle Stellen gespeichert werden.
        ''' </summary>
        ''' <param name="stelle"></param>
        ''' <remarks></remarks>
        Public Sub SaveStelleToDatabase(stelle As Stellenangebot)
            _database.Store(stelle)
        End Sub



        ''' <author></author>
        ''' <summary>
        ''' Löscht eine Stelle aus der DB.
        ''' </summary>
        ''' <param name="stelle"></param>
        ''' <remarks></remarks>
        Public Sub DeleteStelleFromDatabase(stelle As Stellenangebot)
            _database.Delete(stelle)
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Lädt die Einstellungen aus der Datenbank.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function LoadSettings() As Settings
            Dim result As IObjectSet = _database.QueryByExample(New Settings())
            If result.HasNext() Then
                Return CType(result.Next(), Settings)
            Else
                Return New Settings()
            End If
        End Function


        ''' <author></author>
        ''' <summary>
        ''' Speichert die Einstellungen in der Datenbank.
        ''' </summary>
        ''' <param name="setting"></param>
        ''' <remarks></remarks>
        Public Sub SaveSettings(setting As Settings)
            _database.Store(setting)
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Datenbank schließen
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overrides Sub Finalize()
            _database.Close()
        End Sub

#End Region

    End Class
End Namespace