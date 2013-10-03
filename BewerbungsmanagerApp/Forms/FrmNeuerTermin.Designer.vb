Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmNeuerTermin
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
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.cmbAnsprechpartner = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.cmbBezeichnung = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtNotizen = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(43, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Uhrzeit:"
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.CustomFormat = "dddd, 'den' dd.MM.yyyy 'um' HH:mm 'Uhr'"
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.DateTimePicker1.Location = New System.Drawing.Point(106, 14)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(249, 20)
            Me.DateTimePicker1.TabIndex = 1
            '
            'cmbAnsprechpartner
            '
            Me.cmbAnsprechpartner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbAnsprechpartner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbAnsprechpartner.FormattingEnabled = True
            Me.cmbAnsprechpartner.Location = New System.Drawing.Point(106, 41)
            Me.cmbAnsprechpartner.Name = "cmbAnsprechpartner"
            Me.cmbAnsprechpartner.Size = New System.Drawing.Size(249, 21)
            Me.cmbAnsprechpartner.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(12, 70)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Bezeichnung:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(12, 45)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(88, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Ansprechpartner:"
            '
            'btnOk
            '
            Me.btnOk.Location = New System.Drawing.Point(275, 148)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(75, 23)
            Me.btnOk.TabIndex = 5
            Me.btnOk.Text = "OK"
            Me.btnOk.UseVisualStyleBackColor = True
            '
            'cmbBezeichnung
            '
            Me.cmbBezeichnung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbBezeichnung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbBezeichnung.FormattingEnabled = True
            Me.cmbBezeichnung.Items.AddRange(New Object() {"Bewerbungsgespräch", "Bewerbungsgespräch Telefon", "Telefonat", "Assesment Center"})
            Me.cmbBezeichnung.Location = New System.Drawing.Point(106, 69)
            Me.cmbBezeichnung.Name = "cmbBezeichnung"
            Me.cmbBezeichnung.Size = New System.Drawing.Size(249, 21)
            Me.cmbBezeichnung.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 95)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 13)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "Notizen:"
            '
            'txtNotizen
            '
            Me.txtNotizen.Location = New System.Drawing.Point(106, 97)
            Me.txtNotizen.Multiline = True
            Me.txtNotizen.Name = "txtNotizen"
            Me.txtNotizen.Size = New System.Drawing.Size(249, 45)
            Me.txtNotizen.TabIndex = 4
            '
            'FrmNeuerTermin
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(362, 179)
            Me.Controls.Add(Me.txtNotizen)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cmbBezeichnung)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.cmbAnsprechpartner)
            Me.Controls.Add(Me.DateTimePicker1)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Name = "FrmNeuerTermin"
            Me.Text = "NeuerTermin"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbAnsprechpartner As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents cmbBezeichnung As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtNotizen As System.Windows.Forms.TextBox
    End Class
End Namespace