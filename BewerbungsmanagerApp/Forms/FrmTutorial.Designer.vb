Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmInformationUni
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformationUni))
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.btnNext = New System.Windows.Forms.Button()
            Me.btnSkip = New System.Windows.Forms.Button()
            Me.btnBack = New System.Windows.Forms.Button()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'PictureBox1
            '
            Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox1.Image = Global.Bewerbungsmanager.My.Resources.Resources.tutorial1
            Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(1143, 765)
            Me.PictureBox1.TabIndex = 0
            Me.PictureBox1.TabStop = False
            '
            'btnNext
            '
            Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNext.BackColor = System.Drawing.Color.White
            Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNext.Location = New System.Drawing.Point(1015, 719)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(116, 34)
            Me.btnNext.TabIndex = 3
            Me.btnNext.Text = "Weiter"
            Me.btnNext.UseVisualStyleBackColor = False
            '
            'btnSkip
            '
            Me.btnSkip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSkip.BackColor = System.Drawing.Color.White
            Me.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSkip.Location = New System.Drawing.Point(724, 719)
            Me.btnSkip.Name = "btnSkip"
            Me.btnSkip.Size = New System.Drawing.Size(116, 34)
            Me.btnSkip.TabIndex = 4
            Me.btnSkip.Text = "Tour überspringen"
            Me.btnSkip.UseVisualStyleBackColor = False
            Me.btnSkip.Visible = False
            '
            'btnBack
            '
            Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnBack.BackColor = System.Drawing.Color.White
            Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBack.Location = New System.Drawing.Point(893, 719)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New System.Drawing.Size(116, 34)
            Me.btnBack.TabIndex = 5
            Me.btnBack.Text = "Zurück"
            Me.btnBack.UseVisualStyleBackColor = False
            Me.btnBack.Visible = False
            '
            'FrmInformationUni
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(1143, 765)
            Me.Controls.Add(Me.btnSkip)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnNext)
            Me.Controls.Add(Me.PictureBox1)
            Me.DoubleBuffered = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "FrmInformationUni"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents btnNext As System.Windows.Forms.Button
        Friend WithEvents btnSkip As System.Windows.Forms.Button
        Friend WithEvents btnBack As System.Windows.Forms.Button
    End Class
End Namespace