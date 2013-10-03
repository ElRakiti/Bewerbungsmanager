Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmNeueBewerbung
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
            Me.components = New System.ComponentModel.Container()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.lblTitel = New System.Windows.Forms.Label()
            Me.tcNeueBewerbung = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.grpbAnsprechpartner = New System.Windows.Forms.GroupBox()
            Me.dlstvAnsprechpartner = New BrightIdeasSoftware.DataListView()
            Me.columnAnsprechpartnerName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.txtAPosition = New System.Windows.Forms.TextBox()
            Me.cmbAAnrede = New System.Windows.Forms.ComboBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.txtAName = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtAEMail = New System.Windows.Forms.TextBox()
            Me.txtAFax = New System.Windows.Forms.TextBox()
            Me.txtATelefon = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.btnDelAnsprechpartner = New System.Windows.Forms.Button()
            Me.btnAddAnsprechpartner = New System.Windows.Forms.Button()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtNotizen = New System.Windows.Forms.TextBox()
            Me.grpWege = New System.Windows.Forms.GroupBox()
            Me.txtOnlineForumlar = New System.Windows.Forms.TextBox()
            Me.cmbTelefonAnsprech = New System.Windows.Forms.ComboBox()
            Me.cmbEMailAnsprech = New System.Windows.Forms.ComboBox()
            Me.cmbPostAnsprech = New System.Windows.Forms.ComboBox()
            Me.chkTelefon = New System.Windows.Forms.CheckBox()
            Me.chkOnline = New System.Windows.Forms.CheckBox()
            Me.chkEMail = New System.Windows.Forms.CheckBox()
            Me.chkPost = New System.Windows.Forms.CheckBox()
            Me.grpbFirmendaten = New System.Windows.Forms.GroupBox()
            Me.txtFHomepage = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtFEMail = New System.Windows.Forms.TextBox()
            Me.txtFFax = New System.Windows.Forms.TextBox()
            Me.txtFTelefon = New System.Windows.Forms.TextBox()
            Me.txtFOrt = New System.Windows.Forms.TextBox()
            Me.txtFPLZ = New System.Windows.Forms.MaskedTextBox()
            Me.txtFStrasse = New System.Windows.Forms.TextBox()
            Me.txtFName = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.dtpVerschickt = New System.Windows.Forms.DateTimePicker()
            Me.txtStellennummer = New System.Windows.Forms.TextBox()
            Me.cmbBezeichnung = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.btnURLAnzeigen = New System.Windows.Forms.Button()
            Me.txtBeschreibungText = New System.Windows.Forms.TextBox()
            Me.webBrowser = New System.Windows.Forms.WebBrowser()
            Me.txtBeschreibungURL = New System.Windows.Forms.TextBox()
            Me.lblURL = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.cmbStellenbeschreibungTyp = New System.Windows.Forms.ComboBox()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.btnBack = New System.Windows.Forms.Button()
            Me.btnNext = New System.Windows.Forms.Button()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.lblInformation = New System.Windows.Forms.Label()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcNeueBewerbung.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.grpbAnsprechpartner.SuspendLayout()
            CType(Me.dlstvAnsprechpartner, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            Me.grpWege.SuspendLayout()
            Me.grpbFirmendaten.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox1.Image = Global.Bewerbungsmanager.My.Resources.Resources.banner
            Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(931, 83)
            Me.PictureBox1.TabIndex = 0
            Me.PictureBox1.TabStop = False
            '
            'lblTitel
            '
            Me.lblTitel.AutoSize = True
            Me.lblTitel.BackColor = System.Drawing.Color.Transparent
            Me.lblTitel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitel.ForeColor = System.Drawing.Color.White
            Me.lblTitel.Location = New System.Drawing.Point(19, 28)
            Me.lblTitel.Name = "lblTitel"
            Me.lblTitel.Size = New System.Drawing.Size(383, 30)
            Me.lblTitel.TabIndex = 1
            Me.lblTitel.Text = "Neue Bewerbung anlegen - Grunddaten"
            '
            'tcNeueBewerbung
            '
            Me.tcNeueBewerbung.Controls.Add(Me.TabPage1)
            Me.tcNeueBewerbung.Controls.Add(Me.TabPage2)
            Me.tcNeueBewerbung.Controls.Add(Me.TabPage3)
            Me.tcNeueBewerbung.Dock = System.Windows.Forms.DockStyle.Top
            Me.tcNeueBewerbung.Location = New System.Drawing.Point(0, 83)
            Me.tcNeueBewerbung.Name = "tcNeueBewerbung"
            Me.tcNeueBewerbung.SelectedIndex = 0
            Me.tcNeueBewerbung.Size = New System.Drawing.Size(931, 522)
            Me.tcNeueBewerbung.TabIndex = 1
            Me.tcNeueBewerbung.TabStop = False
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.White
            Me.TabPage1.Controls.Add(Me.grpbAnsprechpartner)
            Me.TabPage1.Controls.Add(Me.GroupBox4)
            Me.TabPage1.Controls.Add(Me.grpWege)
            Me.TabPage1.Controls.Add(Me.grpbFirmendaten)
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(923, 496)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "TabPage1"
            '
            'grpbAnsprechpartner
            '
            Me.grpbAnsprechpartner.Controls.Add(Me.dlstvAnsprechpartner)
            Me.grpbAnsprechpartner.Controls.Add(Me.txtAPosition)
            Me.grpbAnsprechpartner.Controls.Add(Me.cmbAAnrede)
            Me.grpbAnsprechpartner.Controls.Add(Me.Label17)
            Me.grpbAnsprechpartner.Controls.Add(Me.txtAName)
            Me.grpbAnsprechpartner.Controls.Add(Me.Label18)
            Me.grpbAnsprechpartner.Controls.Add(Me.txtAEMail)
            Me.grpbAnsprechpartner.Controls.Add(Me.txtAFax)
            Me.grpbAnsprechpartner.Controls.Add(Me.txtATelefon)
            Me.grpbAnsprechpartner.Controls.Add(Me.Label13)
            Me.grpbAnsprechpartner.Controls.Add(Me.Label14)
            Me.grpbAnsprechpartner.Controls.Add(Me.Label15)
            Me.grpbAnsprechpartner.Controls.Add(Me.btnDelAnsprechpartner)
            Me.grpbAnsprechpartner.Controls.Add(Me.btnAddAnsprechpartner)
            Me.grpbAnsprechpartner.Controls.Add(Me.Label12)
            Me.grpbAnsprechpartner.Controls.Add(Me.Label11)
            Me.grpbAnsprechpartner.Location = New System.Drawing.Point(369, 102)
            Me.grpbAnsprechpartner.Name = "grpbAnsprechpartner"
            Me.grpbAnsprechpartner.Size = New System.Drawing.Size(546, 235)
            Me.grpbAnsprechpartner.TabIndex = 4
            Me.grpbAnsprechpartner.TabStop = False
            Me.grpbAnsprechpartner.Text = "Ansprechpartner"
            '
            'dlstvAnsprechpartner
            '
            Me.dlstvAnsprechpartner.AllColumns.Add(Me.columnAnsprechpartnerName)
            Me.dlstvAnsprechpartner.AutoGenerateColumns = False
            Me.dlstvAnsprechpartner.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnAnsprechpartnerName})
            Me.dlstvAnsprechpartner.Cursor = System.Windows.Forms.Cursors.Default
            Me.dlstvAnsprechpartner.DataSource = Nothing
            Me.dlstvAnsprechpartner.FullRowSelect = True
            Me.dlstvAnsprechpartner.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
            Me.dlstvAnsprechpartner.Location = New System.Drawing.Point(21, 57)
            Me.dlstvAnsprechpartner.Name = "dlstvAnsprechpartner"
            Me.dlstvAnsprechpartner.ShowGroups = False
            Me.dlstvAnsprechpartner.ShowHeaderInAllViews = False
            Me.dlstvAnsprechpartner.Size = New System.Drawing.Size(245, 147)
            Me.dlstvAnsprechpartner.TabIndex = 51
            Me.dlstvAnsprechpartner.TabStop = False
            Me.dlstvAnsprechpartner.UseCompatibleStateImageBehavior = False
            Me.dlstvAnsprechpartner.UseHotItem = True
            Me.dlstvAnsprechpartner.UseNotifyPropertyChanged = True
            Me.dlstvAnsprechpartner.View = System.Windows.Forms.View.Details
            '
            'columnAnsprechpartnerName
            '
            Me.columnAnsprechpartnerName.AspectName = "Name"
            Me.columnAnsprechpartnerName.CellPadding = Nothing
            Me.columnAnsprechpartnerName.Width = 240
            '
            'txtAPosition
            '
            Me.txtAPosition.Enabled = False
            Me.txtAPosition.Location = New System.Drawing.Point(328, 84)
            Me.txtAPosition.Name = "txtAPosition"
            Me.txtAPosition.Size = New System.Drawing.Size(195, 20)
            Me.txtAPosition.TabIndex = 50
            Me.txtAPosition.TabStop = False
            '
            'cmbAAnrede
            '
            Me.cmbAAnrede.BackColor = System.Drawing.SystemColors.Window
            Me.cmbAAnrede.Enabled = False
            Me.cmbAAnrede.FormattingEnabled = True
            Me.ErrorProvider.SetIconAlignment(Me.cmbAAnrede, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
            Me.cmbAAnrede.Items.AddRange(New Object() {"", "Herr", "Frau"})
            Me.cmbAAnrede.Location = New System.Drawing.Point(328, 31)
            Me.cmbAAnrede.Name = "cmbAAnrede"
            Me.cmbAAnrede.Size = New System.Drawing.Size(195, 21)
            Me.cmbAAnrede.TabIndex = 37
            Me.cmbAAnrede.TabStop = False
            Me.cmbAAnrede.Visible = False
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(279, 87)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(47, 13)
            Me.Label17.TabIndex = 49
            Me.Label17.Text = "Position:"
            '
            'txtAName
            '
            Me.txtAName.Enabled = False
            Me.txtAName.Location = New System.Drawing.Point(328, 58)
            Me.txtAName.Name = "txtAName"
            Me.txtAName.Size = New System.Drawing.Size(195, 20)
            Me.txtAName.TabIndex = 48
            Me.txtAName.TabStop = False
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(279, 35)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(44, 13)
            Me.Label18.TabIndex = 36
            Me.Label18.Text = "Anrede:"
            Me.Label18.Visible = False
            '
            'txtAEMail
            '
            Me.txtAEMail.Enabled = False
            Me.txtAEMail.Location = New System.Drawing.Point(328, 162)
            Me.txtAEMail.Name = "txtAEMail"
            Me.txtAEMail.Size = New System.Drawing.Size(195, 20)
            Me.txtAEMail.TabIndex = 47
            Me.txtAEMail.TabStop = False
            '
            'txtAFax
            '
            Me.txtAFax.Enabled = False
            Me.txtAFax.Location = New System.Drawing.Point(328, 136)
            Me.txtAFax.Name = "txtAFax"
            Me.txtAFax.Size = New System.Drawing.Size(195, 20)
            Me.txtAFax.TabIndex = 46
            Me.txtAFax.TabStop = False
            '
            'txtATelefon
            '
            Me.txtATelefon.Enabled = False
            Me.txtATelefon.Location = New System.Drawing.Point(328, 110)
            Me.txtATelefon.Name = "txtATelefon"
            Me.txtATelefon.Size = New System.Drawing.Size(195, 20)
            Me.txtATelefon.TabIndex = 45
            Me.txtATelefon.TabStop = False
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(279, 165)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(39, 13)
            Me.Label13.TabIndex = 44
            Me.Label13.Text = "E-Mail:"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(279, 139)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(27, 13)
            Me.Label14.TabIndex = 43
            Me.Label14.Text = "Fax:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(279, 113)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(28, 13)
            Me.Label15.TabIndex = 42
            Me.Label15.Text = "Tel.:"
            '
            'btnDelAnsprechpartner
            '
            Me.btnDelAnsprechpartner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDelAnsprechpartner.Location = New System.Drawing.Point(246, 31)
            Me.btnDelAnsprechpartner.Name = "btnDelAnsprechpartner"
            Me.btnDelAnsprechpartner.Size = New System.Drawing.Size(20, 20)
            Me.btnDelAnsprechpartner.TabIndex = 41
            Me.btnDelAnsprechpartner.TabStop = False
            Me.btnDelAnsprechpartner.Text = "-"
            Me.btnDelAnsprechpartner.UseVisualStyleBackColor = True
            '
            'btnAddAnsprechpartner
            '
            Me.btnAddAnsprechpartner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnAddAnsprechpartner.Location = New System.Drawing.Point(220, 31)
            Me.btnAddAnsprechpartner.Name = "btnAddAnsprechpartner"
            Me.btnAddAnsprechpartner.Size = New System.Drawing.Size(20, 20)
            Me.btnAddAnsprechpartner.TabIndex = 40
            Me.btnAddAnsprechpartner.TabStop = False
            Me.btnAddAnsprechpartner.Text = "+"
            Me.btnAddAnsprechpartner.UseVisualStyleBackColor = True
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(279, 61)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(38, 13)
            Me.Label12.TabIndex = 39
            Me.Label12.Text = "Name:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(18, 35)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(88, 13)
            Me.Label11.TabIndex = 38
            Me.Label11.Text = "Ansprechpartner:"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtNotizen)
            Me.GroupBox4.Location = New System.Drawing.Point(369, 343)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(546, 147)
            Me.GroupBox4.TabIndex = 3
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Notizen"
            '
            'txtNotizen
            '
            Me.txtNotizen.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtNotizen.Location = New System.Drawing.Point(3, 16)
            Me.txtNotizen.Multiline = True
            Me.txtNotizen.Name = "txtNotizen"
            Me.txtNotizen.Size = New System.Drawing.Size(540, 128)
            Me.txtNotizen.TabIndex = 0
            '
            'grpWege
            '
            Me.grpWege.Controls.Add(Me.txtOnlineForumlar)
            Me.grpWege.Controls.Add(Me.cmbTelefonAnsprech)
            Me.grpWege.Controls.Add(Me.cmbEMailAnsprech)
            Me.grpWege.Controls.Add(Me.cmbPostAnsprech)
            Me.grpWege.Controls.Add(Me.chkTelefon)
            Me.grpWege.Controls.Add(Me.chkOnline)
            Me.grpWege.Controls.Add(Me.chkEMail)
            Me.grpWege.Controls.Add(Me.chkPost)
            Me.grpWege.Location = New System.Drawing.Point(8, 343)
            Me.grpWege.Name = "grpWege"
            Me.grpWege.Size = New System.Drawing.Size(335, 147)
            Me.grpWege.TabIndex = 2
            Me.grpWege.TabStop = False
            Me.grpWege.Text = "Bewerbungswege"
            '
            'txtOnlineForumlar
            '
            Me.txtOnlineForumlar.Enabled = False
            Me.txtOnlineForumlar.Location = New System.Drawing.Point(78, 85)
            Me.txtOnlineForumlar.Name = "txtOnlineForumlar"
            Me.txtOnlineForumlar.Size = New System.Drawing.Size(249, 20)
            Me.txtOnlineForumlar.TabIndex = 35
            Me.txtOnlineForumlar.TabStop = False
            '
            'cmbTelefonAnsprech
            '
            Me.cmbTelefonAnsprech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTelefonAnsprech.Enabled = False
            Me.cmbTelefonAnsprech.FormattingEnabled = True
            Me.cmbTelefonAnsprech.Location = New System.Drawing.Point(78, 118)
            Me.cmbTelefonAnsprech.Name = "cmbTelefonAnsprech"
            Me.cmbTelefonAnsprech.Size = New System.Drawing.Size(249, 21)
            Me.cmbTelefonAnsprech.TabIndex = 37
            Me.cmbTelefonAnsprech.TabStop = False
            '
            'cmbEMailAnsprech
            '
            Me.cmbEMailAnsprech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEMailAnsprech.Enabled = False
            Me.cmbEMailAnsprech.FormattingEnabled = True
            Me.cmbEMailAnsprech.Location = New System.Drawing.Point(78, 50)
            Me.cmbEMailAnsprech.Name = "cmbEMailAnsprech"
            Me.cmbEMailAnsprech.Size = New System.Drawing.Size(249, 21)
            Me.cmbEMailAnsprech.TabIndex = 33
            Me.cmbEMailAnsprech.TabStop = False
            '
            'cmbPostAnsprech
            '
            Me.cmbPostAnsprech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPostAnsprech.Enabled = False
            Me.cmbPostAnsprech.FormattingEnabled = True
            Me.cmbPostAnsprech.Location = New System.Drawing.Point(78, 18)
            Me.cmbPostAnsprech.Name = "cmbPostAnsprech"
            Me.cmbPostAnsprech.Size = New System.Drawing.Size(249, 21)
            Me.cmbPostAnsprech.TabIndex = 31
            Me.cmbPostAnsprech.TabStop = False
            '
            'chkTelefon
            '
            Me.chkTelefon.AutoSize = True
            Me.chkTelefon.Location = New System.Drawing.Point(6, 122)
            Me.chkTelefon.Name = "chkTelefon"
            Me.chkTelefon.Size = New System.Drawing.Size(62, 17)
            Me.chkTelefon.TabIndex = 29
            Me.chkTelefon.Text = "Telefon"
            Me.chkTelefon.UseVisualStyleBackColor = True
            '
            'chkOnline
            '
            Me.chkOnline.AutoSize = True
            Me.chkOnline.Location = New System.Drawing.Point(6, 88)
            Me.chkOnline.Name = "chkOnline"
            Me.chkOnline.Size = New System.Drawing.Size(56, 17)
            Me.chkOnline.TabIndex = 27
            Me.chkOnline.Text = "Online"
            Me.chkOnline.UseVisualStyleBackColor = True
            '
            'chkEMail
            '
            Me.chkEMail.AutoSize = True
            Me.chkEMail.Location = New System.Drawing.Point(6, 54)
            Me.chkEMail.Name = "chkEMail"
            Me.chkEMail.Size = New System.Drawing.Size(55, 17)
            Me.chkEMail.TabIndex = 25
            Me.chkEMail.Text = "E-Mail"
            Me.chkEMail.UseVisualStyleBackColor = True
            '
            'chkPost
            '
            Me.chkPost.AutoSize = True
            Me.chkPost.Location = New System.Drawing.Point(6, 20)
            Me.chkPost.Name = "chkPost"
            Me.chkPost.Size = New System.Drawing.Size(47, 17)
            Me.chkPost.TabIndex = 23
            Me.chkPost.Text = "Post"
            Me.chkPost.UseVisualStyleBackColor = True
            '
            'grpbFirmendaten
            '
            Me.grpbFirmendaten.Controls.Add(Me.txtFHomepage)
            Me.grpbFirmendaten.Controls.Add(Me.Label20)
            Me.grpbFirmendaten.Controls.Add(Me.txtFEMail)
            Me.grpbFirmendaten.Controls.Add(Me.txtFFax)
            Me.grpbFirmendaten.Controls.Add(Me.txtFTelefon)
            Me.grpbFirmendaten.Controls.Add(Me.txtFOrt)
            Me.grpbFirmendaten.Controls.Add(Me.txtFPLZ)
            Me.grpbFirmendaten.Controls.Add(Me.txtFStrasse)
            Me.grpbFirmendaten.Controls.Add(Me.txtFName)
            Me.grpbFirmendaten.Controls.Add(Me.Label10)
            Me.grpbFirmendaten.Controls.Add(Me.Label9)
            Me.grpbFirmendaten.Controls.Add(Me.Label8)
            Me.grpbFirmendaten.Controls.Add(Me.Label7)
            Me.grpbFirmendaten.Controls.Add(Me.Label6)
            Me.grpbFirmendaten.Controls.Add(Me.Label5)
            Me.grpbFirmendaten.Controls.Add(Me.Label4)
            Me.grpbFirmendaten.Location = New System.Drawing.Point(8, 102)
            Me.grpbFirmendaten.Name = "grpbFirmendaten"
            Me.grpbFirmendaten.Size = New System.Drawing.Size(335, 235)
            Me.grpbFirmendaten.TabIndex = 1
            Me.grpbFirmendaten.TabStop = False
            Me.grpbFirmendaten.Text = "Firmendaten"
            '
            'txtFHomepage
            '
            Me.txtFHomepage.Location = New System.Drawing.Point(53, 181)
            Me.txtFHomepage.Name = "txtFHomepage"
            Me.txtFHomepage.Size = New System.Drawing.Size(258, 20)
            Me.txtFHomepage.TabIndex = 21
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(9, 183)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(32, 13)
            Me.Label20.TabIndex = 32
            Me.Label20.Text = "URL:"
            '
            'txtFEMail
            '
            Me.txtFEMail.Location = New System.Drawing.Point(53, 155)
            Me.txtFEMail.Name = "txtFEMail"
            Me.txtFEMail.Size = New System.Drawing.Size(258, 20)
            Me.txtFEMail.TabIndex = 19
            '
            'txtFFax
            '
            Me.txtFFax.Location = New System.Drawing.Point(53, 130)
            Me.txtFFax.Name = "txtFFax"
            Me.txtFFax.Size = New System.Drawing.Size(258, 20)
            Me.txtFFax.TabIndex = 17
            '
            'txtFTelefon
            '
            Me.txtFTelefon.Location = New System.Drawing.Point(53, 105)
            Me.txtFTelefon.Name = "txtFTelefon"
            Me.txtFTelefon.Size = New System.Drawing.Size(258, 20)
            Me.txtFTelefon.TabIndex = 15
            '
            'txtFOrt
            '
            Me.txtFOrt.Location = New System.Drawing.Point(163, 80)
            Me.txtFOrt.Name = "txtFOrt"
            Me.txtFOrt.Size = New System.Drawing.Size(148, 20)
            Me.txtFOrt.TabIndex = 13
            '
            'txtFPLZ
            '
            Me.txtFPLZ.Location = New System.Drawing.Point(53, 80)
            Me.txtFPLZ.Mask = "00000"
            Me.txtFPLZ.Name = "txtFPLZ"
            Me.txtFPLZ.Size = New System.Drawing.Size(65, 20)
            Me.txtFPLZ.TabIndex = 11
            '
            'txtFStrasse
            '
            Me.txtFStrasse.Location = New System.Drawing.Point(53, 55)
            Me.txtFStrasse.Name = "txtFStrasse"
            Me.txtFStrasse.Size = New System.Drawing.Size(258, 20)
            Me.txtFStrasse.TabIndex = 9
            '
            'txtFName
            '
            Me.ErrorProvider.SetIconPadding(Me.txtFName, 5)
            Me.txtFName.Location = New System.Drawing.Point(53, 30)
            Me.txtFName.Name = "txtFName"
            Me.txtFName.Size = New System.Drawing.Size(258, 20)
            Me.txtFName.TabIndex = 7
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(9, 158)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(39, 13)
            Me.Label10.TabIndex = 6
            Me.Label10.Text = "E-Mail:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(9, 133)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(27, 13)
            Me.Label9.TabIndex = 5
            Me.Label9.Text = "Fax:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(9, 108)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(28, 13)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Tel.:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(133, 83)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(24, 13)
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "Ort:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(9, 83)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(30, 13)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "PLZ:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(9, 58)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(38, 13)
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "Straße"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(9, 33)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(38, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Name:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label19)
            Me.GroupBox1.Controls.Add(Me.dtpVerschickt)
            Me.GroupBox1.Controls.Add(Me.txtStellennummer)
            Me.GroupBox1.Controls.Add(Me.cmbBezeichnung)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(904, 90)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Grunddaten"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(490, 58)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(116, 13)
            Me.Label19.TabIndex = 4
            Me.Label19.Text = "Bewerbung verschickt:"
            '
            'dtpVerschickt
            '
            Me.dtpVerschickt.Checked = False
            Me.dtpVerschickt.Location = New System.Drawing.Point(619, 55)
            Me.dtpVerschickt.Name = "dtpVerschickt"
            Me.dtpVerschickt.ShowCheckBox = True
            Me.dtpVerschickt.Size = New System.Drawing.Size(200, 20)
            Me.dtpVerschickt.TabIndex = 5
            '
            'txtStellennummer
            '
            Me.txtStellennummer.Location = New System.Drawing.Point(112, 55)
            Me.txtStellennummer.Name = "txtStellennummer"
            Me.txtStellennummer.Size = New System.Drawing.Size(354, 20)
            Me.txtStellennummer.TabIndex = 23
            '
            'cmbBezeichnung
            '
            Me.cmbBezeichnung.FormattingEnabled = True
            Me.ErrorProvider.SetIconPadding(Me.cmbBezeichnung, 5)
            Me.cmbBezeichnung.Location = New System.Drawing.Point(112, 23)
            Me.cmbBezeichnung.Name = "cmbBezeichnung"
            Me.cmbBezeichnung.Size = New System.Drawing.Size(761, 21)
            Me.cmbBezeichnung.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 58)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(76, 13)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Stellennummer"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(6, 26)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(100, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Stellenbezeichnung"
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.White
            Me.TabPage2.Controls.Add(Me.btnURLAnzeigen)
            Me.TabPage2.Controls.Add(Me.txtBeschreibungText)
            Me.TabPage2.Controls.Add(Me.webBrowser)
            Me.TabPage2.Controls.Add(Me.txtBeschreibungURL)
            Me.TabPage2.Controls.Add(Me.lblURL)
            Me.TabPage2.Controls.Add(Me.Label16)
            Me.TabPage2.Controls.Add(Me.cmbStellenbeschreibungTyp)
            Me.ErrorProvider.SetIconAlignment(Me.TabPage2, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(923, 496)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "TabPage2"
            '
            'btnURLAnzeigen
            '
            Me.btnURLAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnURLAnzeigen.Location = New System.Drawing.Point(737, 19)
            Me.btnURLAnzeigen.Name = "btnURLAnzeigen"
            Me.btnURLAnzeigen.Size = New System.Drawing.Size(99, 36)
            Me.btnURLAnzeigen.TabIndex = 6
            Me.btnURLAnzeigen.Text = "Anzeigen"
            Me.btnURLAnzeigen.UseVisualStyleBackColor = True
            Me.btnURLAnzeigen.Visible = False
            '
            'txtBeschreibungText
            '
            Me.txtBeschreibungText.Location = New System.Drawing.Point(12, 70)
            Me.txtBeschreibungText.Multiline = True
            Me.txtBeschreibungText.Name = "txtBeschreibungText"
            Me.txtBeschreibungText.Size = New System.Drawing.Size(903, 372)
            Me.txtBeschreibungText.TabIndex = 5
            Me.txtBeschreibungText.Visible = False
            '
            'webBrowser
            '
            Me.webBrowser.Location = New System.Drawing.Point(13, 70)
            Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
            Me.webBrowser.Name = "webBrowser"
            Me.webBrowser.Size = New System.Drawing.Size(902, 372)
            Me.webBrowser.TabIndex = 4
            Me.webBrowser.Visible = False
            '
            'txtBeschreibungURL
            '
            Me.txtBeschreibungURL.Location = New System.Drawing.Point(428, 28)
            Me.txtBeschreibungURL.Name = "txtBeschreibungURL"
            Me.txtBeschreibungURL.Size = New System.Drawing.Size(303, 20)
            Me.txtBeschreibungURL.TabIndex = 3
            Me.txtBeschreibungURL.Visible = False
            '
            'lblURL
            '
            Me.lblURL.AutoSize = True
            Me.lblURL.Location = New System.Drawing.Point(361, 31)
            Me.lblURL.Name = "lblURL"
            Me.lblURL.Size = New System.Drawing.Size(32, 13)
            Me.lblURL.TabIndex = 2
            Me.lblURL.Text = "URL:"
            Me.lblURL.Visible = False
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(9, 31)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(28, 13)
            Me.Label16.TabIndex = 1
            Me.Label16.Text = "Typ:"
            '
            'cmbStellenbeschreibungTyp
            '
            Me.cmbStellenbeschreibungTyp.BackColor = System.Drawing.SystemColors.Control
            Me.cmbStellenbeschreibungTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbStellenbeschreibungTyp.FormattingEnabled = True
            Me.cmbStellenbeschreibungTyp.Items.AddRange(New Object() {"Webseite", "Datei (PDF / Bilddatei)", "Text"})
            Me.cmbStellenbeschreibungTyp.Location = New System.Drawing.Point(80, 28)
            Me.cmbStellenbeschreibungTyp.Name = "cmbStellenbeschreibungTyp"
            Me.cmbStellenbeschreibungTyp.Size = New System.Drawing.Size(244, 21)
            Me.cmbStellenbeschreibungTyp.TabIndex = 0
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.Label21)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(923, 496)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "TabPage3"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(296, 225)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(355, 13)
            Me.Label21.TabIndex = 0
            Me.Label21.Text = "Hier können später Bewerbungsunterlagen generiert / abgelagert werden."
            '
            'btnBack
            '
            Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBack.Location = New System.Drawing.Point(631, 620)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New System.Drawing.Size(118, 31)
            Me.btnBack.TabIndex = 3
            Me.btnBack.Text = "Zurück"
            Me.btnBack.UseVisualStyleBackColor = True
            Me.btnBack.Visible = False
            '
            'btnNext
            '
            Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNext.Location = New System.Drawing.Point(801, 620)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(118, 31)
            Me.btnNext.TabIndex = 31
            Me.btnNext.Text = "Weiter"
            Me.btnNext.UseVisualStyleBackColor = True
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Me.OpenFileDialog1.Filter = "Alle Dateien|*.*"
            '
            'ErrorProvider
            '
            Me.ErrorProvider.BlinkRate = 750
            Me.ErrorProvider.ContainerControl = Me
            '
            'lblInformation
            '
            Me.lblInformation.AutoSize = True
            Me.lblInformation.Location = New System.Drawing.Point(14, 629)
            Me.lblInformation.Name = "lblInformation"
            Me.lblInformation.Size = New System.Drawing.Size(0, 13)
            Me.lblInformation.TabIndex = 32
            '
            'FrmNeueBewerbung
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(931, 660)
            Me.Controls.Add(Me.lblInformation)
            Me.Controls.Add(Me.btnNext)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.tcNeueBewerbung)
            Me.Controls.Add(Me.lblTitel)
            Me.Controls.Add(Me.PictureBox1)
            Me.DoubleBuffered = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmNeueBewerbung"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Neue Bewerbung anlegen"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcNeueBewerbung.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.grpbAnsprechpartner.ResumeLayout(False)
            Me.grpbAnsprechpartner.PerformLayout()
            CType(Me.dlstvAnsprechpartner, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.grpWege.ResumeLayout(False)
            Me.grpWege.PerformLayout()
            Me.grpbFirmendaten.ResumeLayout(False)
            Me.grpbFirmendaten.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitel As System.Windows.Forms.Label
        Friend WithEvents tcNeueBewerbung As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents btnBack As System.Windows.Forms.Button
        Friend WithEvents btnNext As System.Windows.Forms.Button
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents cmbStellenbeschreibungTyp As System.Windows.Forms.ComboBox
        Friend WithEvents lblURL As System.Windows.Forms.Label
        Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
        Friend WithEvents txtBeschreibungText As System.Windows.Forms.TextBox
        Friend WithEvents webBrowser As System.Windows.Forms.WebBrowser
        Friend WithEvents txtBeschreibungURL As System.Windows.Forms.TextBox
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents btnURLAnzeigen As System.Windows.Forms.Button
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNotizen As System.Windows.Forms.TextBox
        Friend WithEvents grpWege As System.Windows.Forms.GroupBox
        Friend WithEvents txtOnlineForumlar As System.Windows.Forms.TextBox
        Friend WithEvents cmbTelefonAnsprech As System.Windows.Forms.ComboBox
        Friend WithEvents cmbEMailAnsprech As System.Windows.Forms.ComboBox
        Friend WithEvents cmbPostAnsprech As System.Windows.Forms.ComboBox
        Friend WithEvents chkTelefon As System.Windows.Forms.CheckBox
        Friend WithEvents chkOnline As System.Windows.Forms.CheckBox
        Friend WithEvents chkEMail As System.Windows.Forms.CheckBox
        Friend WithEvents chkPost As System.Windows.Forms.CheckBox
        Friend WithEvents grpbFirmendaten As System.Windows.Forms.GroupBox
        Friend WithEvents txtFHomepage As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtFEMail As System.Windows.Forms.TextBox
        Friend WithEvents txtFFax As System.Windows.Forms.TextBox
        Friend WithEvents txtFTelefon As System.Windows.Forms.TextBox
        Friend WithEvents txtFOrt As System.Windows.Forms.TextBox
        Friend WithEvents txtFPLZ As System.Windows.Forms.MaskedTextBox
        Friend WithEvents txtFStrasse As System.Windows.Forms.TextBox
        Friend WithEvents txtFName As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents dtpVerschickt As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtStellennummer As System.Windows.Forms.TextBox
        Friend WithEvents cmbBezeichnung As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents grpbAnsprechpartner As System.Windows.Forms.GroupBox
        Friend WithEvents dlstvAnsprechpartner As BrightIdeasSoftware.DataListView
        Friend WithEvents columnAnsprechpartnerName As BrightIdeasSoftware.OLVColumn
        Friend WithEvents txtAPosition As System.Windows.Forms.TextBox
        Friend WithEvents cmbAAnrede As System.Windows.Forms.ComboBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents txtAName As System.Windows.Forms.TextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents txtAEMail As System.Windows.Forms.TextBox
        Friend WithEvents txtAFax As System.Windows.Forms.TextBox
        Friend WithEvents txtATelefon As System.Windows.Forms.TextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents btnDelAnsprechpartner As System.Windows.Forms.Button
        Friend WithEvents btnAddAnsprechpartner As System.Windows.Forms.Button
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents lblInformation As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
    End Class
End Namespace