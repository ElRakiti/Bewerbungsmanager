Namespace Forms
    ''' <author></author>
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FrmInformationUni

        Private _seite As Integer = 1


        Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
            _seite += 1
            Page(_seite)
        End Sub


        Private Sub Page(p As Integer)
            Select Case p
                Case 1
                    ' TextBox1.Visible = False

                    btnSkip.Visible = True
                    btnBack.Visible = False
                    PictureBox1.Image = My.Resources.tutorial1
                Case 2
                    btnBack.Visible = True
                    PictureBox1.Image = My.Resources.tutorial2
                Case 3
                    PictureBox1.Image = My.Resources.tutorial3
                Case 4
                    PictureBox1.Image = My.Resources.tutorial4
                Case 5
                    PictureBox1.Image = My.Resources.tutorial5
                Case 6
                    PictureBox1.Image = My.Resources.tutorial6
                Case 7
                    PictureBox1.Image = My.Resources.tutorial7
                    btnSkip.Visible = False
                    btnBack.Visible = False
                    btnNext.Text = "Fertig!"
                Case 8
                    Close()
            End Select
            Me.Size = PictureBox1.Image.Size
            Me.CenterToScreen()

        End Sub


        Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
            Close()
        End Sub

        Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
            _seite -= 1
            Page(_seite)
        End Sub

        Private Sub FrmInformationUni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            btnNext.BringToFront()
            btnBack.BringToFront()
            btnSkip.BringToFront()
            Me.Size = PictureBox1.Image.Size
            Me.CenterToScreen()

        End Sub

        Private Sub lblInfo_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        End Sub
    End Class
End Namespace