
Imports System.ComponentModel
Imports Bewerbungsmanager.Klassen

Namespace Forms

    ''' <author></author>
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FrmProgramme
        Private _list As BindingList(Of Programm)
        Private _bindingSource As New BindingSource()


        ''' <author></author>
        ''' <summary>
        ''' Form-Load Event
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
        ''' <param name="list">Liste der Programme</param>
        ''' <remarks></remarks>
        Public Sub New(ByRef list As BindingList(Of Programm))
            _list = list
            InitializeComponent()
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Ausgewählten Eintrag löschen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub DelItem(sender As Object, e As EventArgs) Handles btnDel.Click
            If DataListView1.SelectedItem IsNot Nothing Then
                _bindingSource.RemoveCurrent()
                txtPfad.Clear()
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
            If Not String.IsNullOrEmpty(txtPfad.Text) Then
                Dim programm As New Programm
                programm.Pfad = txtPfad.Text

                programm.Name = txtName.Text

                _bindingSource.Add(programm)
                txtPfad.Clear()
                txtName.Clear()
                txtPfad.Focus()
            End If
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' Auf Enter reagieren
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Textbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
            If e.KeyChar = ChrW(Keys.Return) Then
                AddItem(sender, e)
            End If
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Ausgewählten Eintrag in Textfelder einfügen
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub DataListView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataListView1.SelectionChanged
            If DataListView1.SelectedItem IsNot Nothing Then
                txtPfad.Text = CType(_bindingSource.Current, Programm).Pfad
                txtName.Text = CType(_bindingSource.Current, Programm).Name
            End If
        End Sub

        ''' <author></author>
        ''' <summary>
        ''' Auf Delete-Taste / Entf-Taste reagieren
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ListBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataListView1.KeyUp
            If e.KeyCode = Keys.Delete And DataListView1.SelectedItem IsNot Nothing Then
                DelItem(sender, e)
            End If
        End Sub


        ''' <author></author>
        ''' <summary>
        ''' OpenFile Dialog öffnen, um Datei auszuwählen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                txtPfad.Text = OpenFileDialog1.FileName
            End If
        End Sub
    End Class
End Namespace