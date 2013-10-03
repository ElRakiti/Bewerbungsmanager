Imports System.ComponentModel
Imports Bewerbungsmanager.Klassen

Namespace Forms

    ''' <author></author>
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FrmWebseiten

        Private _list As BindingList(Of Webseite)
        Private _bindingSource As New BindingSource()

        ''' <author></author>
        ''' <summary>
        ''' Form-Load EVent
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ListviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _bindingSource.DataSource = _list
            DataListView1.DataSource = _bindingSource

        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Konstruktor
        ''' </summary>
        ''' <param name="list"></param>
        ''' <remarks></remarks>
        Public Sub New(ByRef list As BindingList(Of Webseite))
            _list = list
            InitializeComponent()
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Ausgewählten Eintrag entfernen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub DelItem(sender As Object, e As EventArgs) Handles btnDel.Click
            If DataListView1.SelectedItem IsNot Nothing Then
                _bindingSource.RemoveCurrent()
                txtUrl.Clear()
                txtName.Clear()
            End If
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Neuen Eintrag aus Textfeldern hinzufügen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub AddItem(sender As Object, e As EventArgs) Handles btnAdd.Click
            If Not String.IsNullOrEmpty(txtUrl.Text) Then
                Dim webseite As New Webseite
                webseite.Url = txtUrl.Text
                If Not String.IsNullOrEmpty(txtName.Text) Then
                    webseite.Name = txtName.Text
                Else
                    webseite.Name = txtUrl.Text
                End If
                _bindingSource.Add(webseite)
                txtUrl.Clear()
                txtName.Clear()
                txtUrl.Focus()
            End If
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Auf Enter-Taste reagieren
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Textbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUrl.KeyPress, txtName.KeyPress
            If e.KeyChar = ChrW(Keys.Return) Then
                AddItem(sender, e)
            End If
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Textfelder mit ausgewählten Eintrag füllen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub DataListView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataListView1.SelectionChanged
            If DataListView1.SelectedItem IsNot Nothing Then
                txtUrl.Text = CType(_bindingSource.Current, Webseite).Url
                txtName.Text = CType(_bindingSource.Current, Webseite).Name
            End If
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Auf Entf-Taste reagieren.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ListBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataListView1.KeyUp
            If e.KeyCode = Keys.Delete And DataListView1.SelectedItem IsNot Nothing Then
                DelItem(sender, e)
            End If
        End Sub
    End Class
End Namespace