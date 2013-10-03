Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmWebseiten
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
            Me.lblTitel = New System.Windows.Forms.Label()
            Me.txtUrl = New System.Windows.Forms.TextBox()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.btnDel = New System.Windows.Forms.Button()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.DataListView1 = New BrightIdeasSoftware.DataListView()
            Me.columnUrl = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.columnName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblTitel
            '
            Me.lblTitel.AutoSize = True
            Me.lblTitel.Location = New System.Drawing.Point(7, 12)
            Me.lblTitel.Name = "lblTitel"
            Me.lblTitel.Size = New System.Drawing.Size(39, 13)
            Me.lblTitel.TabIndex = 0
            Me.lblTitel.Text = "Label1"
            '
            'txtUrl
            '
            Me.txtUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtUrl.Location = New System.Drawing.Point(3, 59)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(201, 20)
            Me.txtUrl.TabIndex = 1
            '
            'btnAdd
            '
            Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAdd.BackColor = System.Drawing.Color.White
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAdd.Location = New System.Drawing.Point(317, 59)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(20, 20)
            Me.btnAdd.TabIndex = 3
            Me.btnAdd.TabStop = False
            Me.btnAdd.Text = "+"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAdd.UseVisualStyleBackColor = False
            '
            'btnDel
            '
            Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnDel.BackColor = System.Drawing.Color.White
            Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDel.Location = New System.Drawing.Point(343, 59)
            Me.btnDel.Name = "btnDel"
            Me.btnDel.Size = New System.Drawing.Size(20, 20)
            Me.btnDel.TabIndex = 4
            Me.btnDel.TabStop = False
            Me.btnDel.Text = "-"
            Me.btnDel.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDel.UseVisualStyleBackColor = False
            '
            'txtName
            '
            Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtName.Location = New System.Drawing.Point(210, 59)
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(95, 20)
            Me.txtName.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(0, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 13)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "Webseite:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(207, 43)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(84, 13)
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "Name (optional):"
            '
            'DataListView1
            '
            Me.DataListView1.AllColumns.Add(Me.columnUrl)
            Me.DataListView1.AllColumns.Add(Me.columnName)
            Me.DataListView1.AutoGenerateColumns = False
            Me.DataListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnUrl, Me.columnName})
            Me.DataListView1.DataSource = Nothing
            Me.DataListView1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.DataListView1.FullRowSelect = True
            Me.DataListView1.Location = New System.Drawing.Point(0, 85)
            Me.DataListView1.Name = "DataListView1"
            Me.DataListView1.ShowGroups = False
            Me.DataListView1.Size = New System.Drawing.Size(372, 160)
            Me.DataListView1.TabIndex = 9
            Me.DataListView1.TabStop = False
            Me.DataListView1.UseCompatibleStateImageBehavior = False
            Me.DataListView1.View = System.Windows.Forms.View.Details
            '
            'columnUrl
            '
            Me.columnUrl.AspectName = "Url"
            Me.columnUrl.CellPadding = Nothing
            Me.columnUrl.Text = "URL"
            Me.columnUrl.Width = 242
            '
            'columnName
            '
            Me.columnName.AspectName = "Name"
            Me.columnName.CellPadding = Nothing
            Me.columnName.Text = "Name"
            Me.columnName.Width = 113
            '
            'FrmWebseiten
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(372, 245)
            Me.Controls.Add(Me.DataListView1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.btnDel)
            Me.Controls.Add(Me.btnAdd)
            Me.Controls.Add(Me.txtUrl)
            Me.Controls.Add(Me.lblTitel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmWebseiten"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Webseitenverknüpfungen"
            CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblTitel As System.Windows.Forms.Label
        Friend WithEvents txtUrl As System.Windows.Forms.TextBox
        Friend WithEvents btnAdd As System.Windows.Forms.Button
        Friend WithEvents btnDel As System.Windows.Forms.Button
        Friend WithEvents txtName As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents DataListView1 As BrightIdeasSoftware.DataListView
        Friend WithEvents columnUrl As BrightIdeasSoftware.OLVColumn
        Friend WithEvents columnName As BrightIdeasSoftware.OLVColumn
    End Class
End Namespace