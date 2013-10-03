Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmTerminInfo
        Inherits System.Windows.Forms.Form

        'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Wird vom Windows Form-Designer benötigt.
        Private components As System.ComponentModel.IContainer

        'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblDatum = New System.Windows.Forms.Label()
            Me.lstbTermine = New System.Windows.Forms.ListBox()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(83, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Termine am:"
            '
            'lblDatum
            '
            Me.lblDatum.AutoSize = True
            Me.lblDatum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDatum.Location = New System.Drawing.Point(110, 18)
            Me.lblDatum.Name = "lblDatum"
            Me.lblDatum.Size = New System.Drawing.Size(49, 16)
            Me.lblDatum.TabIndex = 1
            Me.lblDatum.Text = "Label2"
            '
            'lstbTermine
            '
            Me.lstbTermine.BackColor = System.Drawing.Color.White
            Me.lstbTermine.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.lstbTermine.FormattingEnabled = True
            Me.lstbTermine.Location = New System.Drawing.Point(15, 49)
            Me.lstbTermine.Name = "lstbTermine"
            Me.lstbTermine.SelectionMode = System.Windows.Forms.SelectionMode.None
            Me.lstbTermine.Size = New System.Drawing.Size(275, 78)
            Me.lstbTermine.TabIndex = 2
            '
            'FrmTerminInfo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(302, 139)
            Me.Controls.Add(Me.lstbTermine)
            Me.Controls.Add(Me.lblDatum)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "FrmTerminInfo"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "TermineInfo"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblDatum As System.Windows.Forms.Label
        Friend WithEvents lstbTermine As System.Windows.Forms.ListBox
    End Class
End Namespace