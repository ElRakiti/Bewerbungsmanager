Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProgramme
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
            Me.DataListView1 = New BrightIdeasSoftware.DataListView()
            Me.columnName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.columnPfad = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.btnDel = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.txtPfad = New System.Windows.Forms.TextBox()
            Me.lblTitel = New System.Windows.Forms.Label()
            Me.btnSearch = New System.Windows.Forms.Button()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DataListView1
            '
            Me.DataListView1.AllColumns.Add(Me.columnName)
            Me.DataListView1.AllColumns.Add(Me.columnPfad)
            Me.DataListView1.AutoGenerateColumns = False
            Me.DataListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnName, Me.columnPfad})
            Me.DataListView1.DataSource = Nothing
            Me.DataListView1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.DataListView1.FullRowSelect = True
            Me.DataListView1.Location = New System.Drawing.Point(0, 81)
            Me.DataListView1.Name = "DataListView1"
            Me.DataListView1.ShowGroups = False
            Me.DataListView1.Size = New System.Drawing.Size(446, 160)
            Me.DataListView1.TabIndex = 17
            Me.DataListView1.TabStop = False
            Me.DataListView1.UseCompatibleStateImageBehavior = False
            Me.DataListView1.View = System.Windows.Forms.View.Details
            '
            'columnName
            '
            Me.columnName.AspectName = "Name"
            Me.columnName.CellPadding = Nothing
            Me.columnName.DisplayIndex = 1
            Me.columnName.Text = "Name"
            Me.columnName.Width = 122
            '
            'columnPfad
            '
            Me.columnPfad.AspectName = "Pfad"
            Me.columnPfad.CellPadding = Nothing
            Me.columnPfad.DisplayIndex = 0
            Me.columnPfad.Text = "Pfad"
            Me.columnPfad.Width = 310
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(255, 37)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 13)
            Me.Label2.TabIndex = 16
            Me.Label2.Text = "Name:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(0, 37)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(32, 13)
            Me.Label1.TabIndex = 15
            Me.Label1.Text = "Pfad:"
            '
            'txtName
            '
            Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtName.Location = New System.Drawing.Point(258, 53)
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(121, 20)
            Me.txtName.TabIndex = 12
            '
            'btnDel
            '
            Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnDel.BackColor = System.Drawing.Color.White
            Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDel.Location = New System.Drawing.Point(417, 53)
            Me.btnDel.Name = "btnDel"
            Me.btnDel.Size = New System.Drawing.Size(20, 20)
            Me.btnDel.TabIndex = 14
            Me.btnDel.TabStop = False
            Me.btnDel.Text = "-"
            Me.btnDel.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDel.UseVisualStyleBackColor = False
            '
            'btnAdd
            '
            Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAdd.BackColor = System.Drawing.Color.White
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAdd.Location = New System.Drawing.Point(391, 53)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(20, 20)
            Me.btnAdd.TabIndex = 13
            Me.btnAdd.TabStop = False
            Me.btnAdd.Text = "+"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAdd.UseVisualStyleBackColor = False
            '
            'txtPfad
            '
            Me.txtPfad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtPfad.Location = New System.Drawing.Point(3, 53)
            Me.txtPfad.Name = "txtPfad"
            Me.txtPfad.ReadOnly = True
            Me.txtPfad.Size = New System.Drawing.Size(208, 20)
            Me.txtPfad.TabIndex = 11
            '
            'lblTitel
            '
            Me.lblTitel.AutoSize = True
            Me.lblTitel.Location = New System.Drawing.Point(7, 6)
            Me.lblTitel.Name = "lblTitel"
            Me.lblTitel.Size = New System.Drawing.Size(39, 13)
            Me.lblTitel.TabIndex = 10
            Me.lblTitel.Text = "Label1"
            '
            'btnSearch
            '
            Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSearch.BackColor = System.Drawing.Color.White
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSearch.Location = New System.Drawing.Point(217, 54)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(23, 21)
            Me.btnSearch.TabIndex = 18
            Me.btnSearch.TabStop = False
            Me.btnSearch.Text = "?"
            Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSearch.UseVisualStyleBackColor = False
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.CheckPathExists = False
            Me.OpenFileDialog1.DefaultExt = "exe"
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Me.OpenFileDialog1.Filter = ".exe Dateien|*.exe"
            Me.OpenFileDialog1.Title = "Programm auswählen"
            '
            'FrmProgramme
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(446, 241)
            Me.Controls.Add(Me.btnSearch)
            Me.Controls.Add(Me.DataListView1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.btnDel)
            Me.Controls.Add(Me.btnAdd)
            Me.Controls.Add(Me.txtPfad)
            Me.Controls.Add(Me.lblTitel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmProgramme"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Programmverknüpfungen"
            CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents DataListView1 As BrightIdeasSoftware.DataListView
        Friend WithEvents columnPfad As BrightIdeasSoftware.OLVColumn
        Friend WithEvents columnName As BrightIdeasSoftware.OLVColumn
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtName As System.Windows.Forms.TextBox
        Friend WithEvents btnDel As System.Windows.Forms.Button
        Friend WithEvents btnAdd As System.Windows.Forms.Button
        Friend WithEvents txtPfad As System.Windows.Forms.TextBox
        Friend WithEvents lblTitel As System.Windows.Forms.Label
        Friend WithEvents btnSearch As System.Windows.Forms.Button
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    End Class
End Namespace