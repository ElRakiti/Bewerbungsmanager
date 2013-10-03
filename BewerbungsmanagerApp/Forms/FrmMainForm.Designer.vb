Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmMainForm
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
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.NeueBewerbungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
            Me.GeneriereDummyStellenangebeoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
            Me.TutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.BearbeiteWebseitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.BearbeiteProgrammeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.HotItemStyle1 = New BrightIdeasSoftware.HotItemStyle()
            Me.cmsListView = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.BewerbungAlsVersendetMarkierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.RückmeldungVonFirmaErhaltenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EingangsbestätigungErhaltenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
            Me.InformationenNachreichenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
            Me.NeuerTerminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
            Me.AbsageErhaltenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ZusageErhalteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
            Me.StellenangebotLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.dlstvStellenangebote = New BrightIdeasSoftware.DataListView()
            Me.columnStellenbezeichnung = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.ColumnFirmenname = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.columnStatus = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.columnErfasst = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.columnVersendet = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.columnBewerbungswege = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.grpbVerlauf = New System.Windows.Forms.GroupBox()
            Me.lboxVerlauf = New System.Windows.Forms.ListBox()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.txtDBNotizen = New System.Windows.Forms.TextBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.lblDBStatus = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
            Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
            Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
            Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
            Me.cmsWebseiten = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.dlstvTermine = New BrightIdeasSoftware.DataListView()
            Me.columnTerminBez = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.columnTerminUhrzeit = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.columnTerminAnsprechpartner = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.columnTerminNotizen = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.cmsTermine = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.NeuerTerminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.TerminLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtNotizenStellendaten = New System.Windows.Forms.TextBox()
            Me.grpWege = New System.Windows.Forms.GroupBox()
            Me.btnOnlineFormular = New System.Windows.Forms.Button()
            Me.txtOnlineForumlar = New System.Windows.Forms.TextBox()
            Me.cmbTelefonAnsprech = New System.Windows.Forms.ComboBox()
            Me.cmbEMailAnsprech = New System.Windows.Forms.ComboBox()
            Me.cmbPostAnsprech = New System.Windows.Forms.ComboBox()
            Me.chkTelefon = New System.Windows.Forms.CheckBox()
            Me.chkOnline = New System.Windows.Forms.CheckBox()
            Me.chkEMail = New System.Windows.Forms.CheckBox()
            Me.chkPost = New System.Windows.Forms.CheckBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dlstvAnsprechpartner = New BrightIdeasSoftware.DataListView()
            Me.columnAnsprechpartnerName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.txtFHomepage = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
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
            Me.txtFEMail = New System.Windows.Forms.TextBox()
            Me.txtFFax = New System.Windows.Forms.TextBox()
            Me.txtFTelefon = New System.Windows.Forms.TextBox()
            Me.txtFOrt = New System.Windows.Forms.TextBox()
            Me.txtFPLZ = New System.Windows.Forms.MaskedTextBox()
            Me.txtFStrasse = New System.Windows.Forms.TextBox()
            Me.txtFName = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.dtpErfasst = New System.Windows.Forms.DateTimePicker()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.dtpVerschickt = New System.Windows.Forms.DateTimePicker()
            Me.txtStellenbezeichnung = New System.Windows.Forms.TextBox()
            Me.txtStellennummer = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.lblStellenbeschreibungPfad = New System.Windows.Forms.Label()
            Me.btnStellenbeschreibung = New System.Windows.Forms.Button()
            Me.txtStellenbeschreibung = New System.Windows.Forms.TextBox()
            Me.WebBrowserBeschreibung = New System.Windows.Forms.WebBrowser()
            Me.cmsEmail = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ÖffnenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.URLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.tooltxtEMail = New System.Windows.Forms.ToolStripTextBox()
            Me.cmsBewerbungsordner = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ÖffnenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.PfadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.tooltxtBewerbungsordner = New System.Windows.Forms.ToolStripTextBox()
            Me.cmsProgramme = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MenuStrip1.SuspendLayout()
            Me.cmsListView.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            CType(Me.dlstvStellenangebote, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpbVerlauf.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            CType(Me.dlstvTermine, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.cmsTermine.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.grpWege.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dlstvAnsprechpartner, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.cmsEmail.SuspendLayout()
            Me.cmsBewerbungsordner.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(5, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(1003, 24)
            Me.MenuStrip1.TabIndex = 0
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'DateiToolStripMenuItem
            '
            Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeueBewerbungToolStripMenuItem, Me.ToolStripMenuItem5, Me.GeneriereDummyStellenangebeoteToolStripMenuItem, Me.ToolStripMenuItem6, Me.TutorialToolStripMenuItem})
            Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
            Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
            Me.DateiToolStripMenuItem.Text = "&Datei"
            '
            'NeueBewerbungToolStripMenuItem
            '
            Me.NeueBewerbungToolStripMenuItem.Name = "NeueBewerbungToolStripMenuItem"
            Me.NeueBewerbungToolStripMenuItem.ShortcutKeyDisplayString = ""
            Me.NeueBewerbungToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
            Me.NeueBewerbungToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
            Me.NeueBewerbungToolStripMenuItem.Text = "&Neue Bewerbung"
            '
            'ToolStripMenuItem5
            '
            Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
            Me.ToolStripMenuItem5.Size = New System.Drawing.Size(305, 6)
            '
            'GeneriereDummyStellenangebeoteToolStripMenuItem
            '
            Me.GeneriereDummyStellenangebeoteToolStripMenuItem.Name = "GeneriereDummyStellenangebeoteToolStripMenuItem"
            Me.GeneriereDummyStellenangebeoteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
            Me.GeneriereDummyStellenangebeoteToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
            Me.GeneriereDummyStellenangebeoteToolStripMenuItem.Text = "&Generiere Dummy Stellenangebeote"
            '
            'ToolStripMenuItem6
            '
            Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
            Me.ToolStripMenuItem6.Size = New System.Drawing.Size(305, 6)
            '
            'TutorialToolStripMenuItem
            '
            Me.TutorialToolStripMenuItem.Name = "TutorialToolStripMenuItem"
            Me.TutorialToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
            Me.TutorialToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
            Me.TutorialToolStripMenuItem.Text = "Tutorial"
            '
            'BearbeitenToolStripMenuItem
            '
            Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BearbeiteWebseitenToolStripMenuItem, Me.BearbeiteProgrammeToolStripMenuItem})
            Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
            Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
            Me.BearbeitenToolStripMenuItem.Text = "&Einstellungen"
            '
            'BearbeiteWebseitenToolStripMenuItem
            '
            Me.BearbeiteWebseitenToolStripMenuItem.Name = "BearbeiteWebseitenToolStripMenuItem"
            Me.BearbeiteWebseitenToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
            Me.BearbeiteWebseitenToolStripMenuItem.Text = "Bearbeite &Webseiten"
            '
            'BearbeiteProgrammeToolStripMenuItem
            '
            Me.BearbeiteProgrammeToolStripMenuItem.Name = "BearbeiteProgrammeToolStripMenuItem"
            Me.BearbeiteProgrammeToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
            Me.BearbeiteProgrammeToolStripMenuItem.Text = "Bearbeite &Programme"
            '
            'StatusStrip1
            '
            Me.StatusStrip1.Location = New System.Drawing.Point(5, 708)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.Size = New System.Drawing.Size(1003, 22)
            Me.StatusStrip1.TabIndex = 1
            Me.StatusStrip1.Text = "StatusStrip1"
            '
            'HotItemStyle1
            '
            Me.HotItemStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption
            '
            'cmsListView
            '
            Me.cmsListView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.ToolStripMenuItem1, Me.BewerbungAlsVersendetMarkierenToolStripMenuItem, Me.RückmeldungVonFirmaErhaltenToolStripMenuItem, Me.ToolStripMenuItem7, Me.StellenangebotLöschenToolStripMenuItem})
            Me.cmsListView.Name = "cmsListView"
            Me.cmsListView.Size = New System.Drawing.Size(399, 104)
            '
            'ÖffnenToolStripMenuItem
            '
            Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
            Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(398, 22)
            Me.ÖffnenToolStripMenuItem.Text = "Stellendaten zeigen"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(395, 6)
            '
            'BewerbungAlsVersendetMarkierenToolStripMenuItem
            '
            Me.BewerbungAlsVersendetMarkierenToolStripMenuItem.Name = "BewerbungAlsVersendetMarkierenToolStripMenuItem"
            Me.BewerbungAlsVersendetMarkierenToolStripMenuItem.Size = New System.Drawing.Size(398, 22)
            Me.BewerbungAlsVersendetMarkierenToolStripMenuItem.Text = "Bewerbung als versendet / warte auf Rückmeldung markieren"
            '
            'RückmeldungVonFirmaErhaltenToolStripMenuItem
            '
            Me.RückmeldungVonFirmaErhaltenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EingangsbestätigungErhaltenToolStripMenuItem, Me.ToolStripMenuItem2, Me.InformationenNachreichenToolStripMenuItem, Me.ToolStripMenuItem4, Me.NeuerTerminToolStripMenuItem, Me.ToolStripMenuItem3, Me.AbsageErhaltenToolStripMenuItem, Me.ZusageErhalteToolStripMenuItem})
            Me.RückmeldungVonFirmaErhaltenToolStripMenuItem.Name = "RückmeldungVonFirmaErhaltenToolStripMenuItem"
            Me.RückmeldungVonFirmaErhaltenToolStripMenuItem.Size = New System.Drawing.Size(398, 22)
            Me.RückmeldungVonFirmaErhaltenToolStripMenuItem.Text = "Rückmeldung von Firma erhalten"
            '
            'EingangsbestätigungErhaltenToolStripMenuItem
            '
            Me.EingangsbestätigungErhaltenToolStripMenuItem.Name = "EingangsbestätigungErhaltenToolStripMenuItem"
            Me.EingangsbestätigungErhaltenToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
            Me.EingangsbestätigungErhaltenToolStripMenuItem.Text = "Eingangsbestätigung erhalten"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(228, 6)
            '
            'InformationenNachreichenToolStripMenuItem
            '
            Me.InformationenNachreichenToolStripMenuItem.Name = "InformationenNachreichenToolStripMenuItem"
            Me.InformationenNachreichenToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
            Me.InformationenNachreichenToolStripMenuItem.Text = "Unterlagen nachreichen"
            '
            'ToolStripMenuItem4
            '
            Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
            Me.ToolStripMenuItem4.Size = New System.Drawing.Size(228, 6)
            '
            'NeuerTerminToolStripMenuItem
            '
            Me.NeuerTerminToolStripMenuItem.Name = "NeuerTerminToolStripMenuItem"
            Me.NeuerTerminToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
            Me.NeuerTerminToolStripMenuItem.Text = "Neuer Termin"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(228, 6)
            '
            'AbsageErhaltenToolStripMenuItem
            '
            Me.AbsageErhaltenToolStripMenuItem.Name = "AbsageErhaltenToolStripMenuItem"
            Me.AbsageErhaltenToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
            Me.AbsageErhaltenToolStripMenuItem.Text = "Absage erhalten"
            '
            'ZusageErhalteToolStripMenuItem
            '
            Me.ZusageErhalteToolStripMenuItem.Name = "ZusageErhalteToolStripMenuItem"
            Me.ZusageErhalteToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
            Me.ZusageErhalteToolStripMenuItem.Text = "Zusage erhalten"
            '
            'ToolStripMenuItem7
            '
            Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
            Me.ToolStripMenuItem7.Size = New System.Drawing.Size(395, 6)
            '
            'StellenangebotLöschenToolStripMenuItem
            '
            Me.StellenangebotLöschenToolStripMenuItem.Name = "StellenangebotLöschenToolStripMenuItem"
            Me.StellenangebotLöschenToolStripMenuItem.Size = New System.Drawing.Size(398, 22)
            Me.StellenangebotLöschenToolStripMenuItem.Text = "Stellenangebot löschen"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.HotTrack = True
            Me.TabControl1.Location = New System.Drawing.Point(5, 24)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1003, 684)
            Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.TabControl1.TabIndex = 7
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.SplitContainer1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
            Me.TabPage1.Size = New System.Drawing.Size(995, 658)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Übersicht"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
            Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.dlstvStellenangebote)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.grpbVerlauf)
            Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox7)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Label25)
            Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox6)
            Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
            Me.SplitContainer1.Size = New System.Drawing.Size(989, 652)
            Me.SplitContainer1.SplitterDistance = 650
            Me.SplitContainer1.SplitterWidth = 10
            Me.SplitContainer1.TabIndex = 9
            '
            'dlstvStellenangebote
            '
            Me.dlstvStellenangebote.AllColumns.Add(Me.columnStellenbezeichnung)
            Me.dlstvStellenangebote.AllColumns.Add(Me.ColumnFirmenname)
            Me.dlstvStellenangebote.AllColumns.Add(Me.columnStatus)
            Me.dlstvStellenangebote.AllColumns.Add(Me.columnErfasst)
            Me.dlstvStellenangebote.AllColumns.Add(Me.columnVersendet)
            Me.dlstvStellenangebote.AllColumns.Add(Me.columnBewerbungswege)
            Me.dlstvStellenangebote.AutoGenerateColumns = False
            Me.dlstvStellenangebote.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnStellenbezeichnung, Me.ColumnFirmenname, Me.columnStatus, Me.columnErfasst, Me.columnVersendet, Me.columnBewerbungswege})
            Me.dlstvStellenangebote.ContextMenuStrip = Me.cmsListView
            Me.dlstvStellenangebote.Cursor = System.Windows.Forms.Cursors.Default
            Me.dlstvStellenangebote.DataSource = Nothing
            Me.dlstvStellenangebote.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dlstvStellenangebote.FullRowSelect = True
            Me.dlstvStellenangebote.HotItemStyle = Me.HotItemStyle1
            Me.dlstvStellenangebote.Location = New System.Drawing.Point(0, 0)
            Me.dlstvStellenangebote.MultiSelect = False
            Me.dlstvStellenangebote.Name = "dlstvStellenangebote"
            Me.dlstvStellenangebote.Size = New System.Drawing.Size(650, 652)
            Me.dlstvStellenangebote.TabIndex = 9
            Me.dlstvStellenangebote.UseCompatibleStateImageBehavior = False
            Me.dlstvStellenangebote.UseHotItem = True
            Me.dlstvStellenangebote.UseNotifyPropertyChanged = True
            Me.dlstvStellenangebote.View = System.Windows.Forms.View.Details
            '
            'columnStellenbezeichnung
            '
            Me.columnStellenbezeichnung.AspectName = "Stellenbezeichnung"
            Me.columnStellenbezeichnung.CellPadding = Nothing
            Me.columnStellenbezeichnung.Text = "Stellenbezeichnung"
            Me.columnStellenbezeichnung.Width = 120
            '
            'ColumnFirmenname
            '
            Me.ColumnFirmenname.AspectName = "Firma.Firmenname"
            Me.ColumnFirmenname.CellPadding = Nothing
            Me.ColumnFirmenname.Text = "Firma"
            Me.ColumnFirmenname.Width = 127
            '
            'columnStatus
            '
            Me.columnStatus.AspectName = "StatusAsShortString"
            Me.columnStatus.CellPadding = Nothing
            Me.columnStatus.Text = "Status"
            Me.columnStatus.Width = 126
            '
            'columnErfasst
            '
            Me.columnErfasst.AspectName = "DatumErfasst"
            Me.columnErfasst.AspectToStringFormat = ""
            Me.columnErfasst.CellPadding = Nothing
            Me.columnErfasst.Text = "Erfasst"
            Me.columnErfasst.Width = 90
            '
            'columnVersendet
            '
            Me.columnVersendet.AspectName = "DatumVersendet"
            Me.columnVersendet.CellPadding = Nothing
            Me.columnVersendet.CellVerticalAlignment = System.Drawing.StringAlignment.Center
            Me.columnVersendet.Text = "Versendet"
            Me.columnVersendet.Width = 99
            '
            'columnBewerbungswege
            '
            Me.columnBewerbungswege.AspectName = "BewerbungswegeAsString"
            Me.columnBewerbungswege.CellPadding = Nothing
            Me.columnBewerbungswege.Text = "Bewerbungswege"
            Me.columnBewerbungswege.Width = 102
            '
            'grpbVerlauf
            '
            Me.grpbVerlauf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpbVerlauf.Controls.Add(Me.lboxVerlauf)
            Me.grpbVerlauf.Location = New System.Drawing.Point(12, 350)
            Me.grpbVerlauf.Name = "grpbVerlauf"
            Me.grpbVerlauf.Size = New System.Drawing.Size(308, 142)
            Me.grpbVerlauf.TabIndex = 1
            Me.grpbVerlauf.TabStop = False
            Me.grpbVerlauf.Text = "Verlauf"
            '
            'lboxVerlauf
            '
            Me.lboxVerlauf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lboxVerlauf.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.lboxVerlauf.FormattingEnabled = True
            Me.lboxVerlauf.Location = New System.Drawing.Point(11, 24)
            Me.lboxVerlauf.Name = "lboxVerlauf"
            Me.lboxVerlauf.SelectionMode = System.Windows.Forms.SelectionMode.None
            Me.lboxVerlauf.Size = New System.Drawing.Size(285, 91)
            Me.lboxVerlauf.TabIndex = 13
            '
            'GroupBox7
            '
            Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox7.Controls.Add(Me.txtDBNotizen)
            Me.GroupBox7.Controls.Add(Me.Label27)
            Me.GroupBox7.Controls.Add(Me.lblDBStatus)
            Me.GroupBox7.Controls.Add(Me.Label26)
            Me.GroupBox7.Location = New System.Drawing.Point(12, 514)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(306, 118)
            Me.GroupBox7.TabIndex = 4
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Aktionen"
            '
            'txtDBNotizen
            '
            Me.txtDBNotizen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtDBNotizen.BackColor = System.Drawing.Color.White
            Me.txtDBNotizen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDBNotizen.Location = New System.Drawing.Point(61, 60)
            Me.txtDBNotizen.Multiline = True
            Me.txtDBNotizen.Name = "txtDBNotizen"
            Me.txtDBNotizen.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtDBNotizen.Size = New System.Drawing.Size(238, 47)
            Me.txtDBNotizen.TabIndex = 29
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(9, 60)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(46, 13)
            Me.Label27.TabIndex = 28
            Me.Label27.Text = "Notizen:"
            '
            'lblDBStatus
            '
            Me.lblDBStatus.AutoSize = True
            Me.lblDBStatus.Location = New System.Drawing.Point(126, 30)
            Me.lblDBStatus.Name = "lblDBStatus"
            Me.lblDBStatus.Size = New System.Drawing.Size(0, 13)
            Me.lblDBStatus.TabIndex = 24
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(9, 30)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(84, 13)
            Me.Label26.TabIndex = 23
            Me.Label26.Text = "Aktueller Status:"
            '
            'Label25
            '
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(12, 14)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(306, 23)
            Me.Label25.TabIndex = 3
            Me.Label25.Text = "Dashboard"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GroupBox6
            '
            Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox6.Controls.Add(Me.LinkLabel10)
            Me.GroupBox6.Controls.Add(Me.LinkLabel9)
            Me.GroupBox6.Controls.Add(Me.LinkLabel8)
            Me.GroupBox6.Controls.Add(Me.LinkLabel7)
            Me.GroupBox6.Location = New System.Drawing.Point(12, 254)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(306, 89)
            Me.GroupBox6.TabIndex = 2
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Schnellverknüpfungen"
            '
            'LinkLabel10
            '
            Me.LinkLabel10.AutoSize = True
            Me.LinkLabel10.Location = New System.Drawing.Point(14, 54)
            Me.LinkLabel10.Name = "LinkLabel10"
            Me.LinkLabel10.Size = New System.Drawing.Size(60, 13)
            Me.LinkLabel10.TabIndex = 3
            Me.LinkLabel10.TabStop = True
            Me.LinkLabel10.Text = "Programme"
            '
            'LinkLabel9
            '
            Me.LinkLabel9.AutoSize = True
            Me.LinkLabel9.Location = New System.Drawing.Point(169, 29)
            Me.LinkLabel9.Name = "LinkLabel9"
            Me.LinkLabel9.Size = New System.Drawing.Size(81, 13)
            Me.LinkLabel9.TabIndex = 2
            Me.LinkLabel9.TabStop = True
            Me.LinkLabel9.Text = "E-Mail Postfach"
            '
            'LinkLabel8
            '
            Me.LinkLabel8.AutoSize = True
            Me.LinkLabel8.Location = New System.Drawing.Point(169, 54)
            Me.LinkLabel8.Name = "LinkLabel8"
            Me.LinkLabel8.Size = New System.Drawing.Size(96, 13)
            Me.LinkLabel8.TabIndex = 1
            Me.LinkLabel8.TabStop = True
            Me.LinkLabel8.Text = "Bewerbungsordner"
            Me.LinkLabel8.Visible = False
            '
            'LinkLabel7
            '
            Me.LinkLabel7.AutoSize = True
            Me.LinkLabel7.ContextMenuStrip = Me.cmsWebseiten
            Me.LinkLabel7.Location = New System.Drawing.Point(14, 29)
            Me.LinkLabel7.Name = "LinkLabel7"
            Me.LinkLabel7.Size = New System.Drawing.Size(58, 13)
            Me.LinkLabel7.TabIndex = 0
            Me.LinkLabel7.TabStop = True
            Me.LinkLabel7.Text = "Webseiten"
            '
            'cmsWebseiten
            '
            Me.cmsWebseiten.Name = "cmsWebseiten"
            Me.cmsWebseiten.Size = New System.Drawing.Size(61, 4)
            '
            'GroupBox3
            '
            Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox3.Controls.Add(Me.Label1)
            Me.GroupBox3.Controls.Add(Me.MonthCalendar1)
            Me.GroupBox3.Location = New System.Drawing.Point(12, 40)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(306, 208)
            Me.GroupBox3.TabIndex = 0
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Allgemeines"
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(108, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(108, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Anstehende Termine:"
            '
            'MonthCalendar1
            '
            Me.MonthCalendar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday
            Me.MonthCalendar1.Location = New System.Drawing.Point(72, 34)
            Me.MonthCalendar1.Name = "MonthCalendar1"
            Me.MonthCalendar1.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.GroupBox8)
            Me.TabPage2.Controls.Add(Me.GroupBox4)
            Me.TabPage2.Controls.Add(Me.grpWege)
            Me.TabPage2.Controls.Add(Me.GroupBox2)
            Me.TabPage2.Controls.Add(Me.GroupBox1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
            Me.TabPage2.Size = New System.Drawing.Size(995, 663)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Stellendaten"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.dlstvTermine)
            Me.GroupBox8.Location = New System.Drawing.Point(379, 343)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(597, 306)
            Me.GroupBox8.TabIndex = 6
            Me.GroupBox8.TabStop = False
            Me.GroupBox8.Text = "Termine"
            '
            'dlstvTermine
            '
            Me.dlstvTermine.AllColumns.Add(Me.columnTerminBez)
            Me.dlstvTermine.AllColumns.Add(Me.columnTerminUhrzeit)
            Me.dlstvTermine.AllColumns.Add(Me.columnTerminAnsprechpartner)
            Me.dlstvTermine.AllColumns.Add(Me.columnTerminNotizen)
            Me.dlstvTermine.AutoGenerateColumns = False
            Me.dlstvTermine.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnTerminBez, Me.columnTerminUhrzeit, Me.columnTerminAnsprechpartner, Me.columnTerminNotizen})
            Me.dlstvTermine.ContextMenuStrip = Me.cmsTermine
            Me.dlstvTermine.Cursor = System.Windows.Forms.Cursors.Default
            Me.dlstvTermine.DataSource = Nothing
            Me.dlstvTermine.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dlstvTermine.EmptyListMsg = "Keine Termine vorhanden!"
            Me.dlstvTermine.FullRowSelect = True
            Me.dlstvTermine.HotItemStyle = Me.HotItemStyle1
            Me.dlstvTermine.Location = New System.Drawing.Point(3, 16)
            Me.dlstvTermine.MultiSelect = False
            Me.dlstvTermine.Name = "dlstvTermine"
            Me.dlstvTermine.ShowGroups = False
            Me.dlstvTermine.Size = New System.Drawing.Size(591, 287)
            Me.dlstvTermine.SortGroupItemsByPrimaryColumn = False
            Me.dlstvTermine.TabIndex = 5
            Me.dlstvTermine.UseCompatibleStateImageBehavior = False
            Me.dlstvTermine.UseHotItem = True
            Me.dlstvTermine.UseNotifyPropertyChanged = True
            Me.dlstvTermine.View = System.Windows.Forms.View.Details
            '
            'columnTerminBez
            '
            Me.columnTerminBez.AspectName = "Bezeichnung"
            Me.columnTerminBez.CellPadding = Nothing
            Me.columnTerminBez.Hideable = False
            Me.columnTerminBez.Text = "Bezeichnung"
            Me.columnTerminBez.Width = 150
            '
            'columnTerminUhrzeit
            '
            Me.columnTerminUhrzeit.AspectName = "Datum"
            Me.columnTerminUhrzeit.CellPadding = Nothing
            Me.columnTerminUhrzeit.Hideable = False
            Me.columnTerminUhrzeit.Text = "Uhrzeit"
            Me.columnTerminUhrzeit.Width = 132
            '
            'columnTerminAnsprechpartner
            '
            Me.columnTerminAnsprechpartner.AspectName = "Ansprechpartner"
            Me.columnTerminAnsprechpartner.CellPadding = Nothing
            Me.columnTerminAnsprechpartner.Text = "Ansprechpartner"
            Me.columnTerminAnsprechpartner.Width = 128
            '
            'columnTerminNotizen
            '
            Me.columnTerminNotizen.AspectName = "Notizen"
            Me.columnTerminNotizen.CellPadding = Nothing
            Me.columnTerminNotizen.Text = "Notizen"
            Me.columnTerminNotizen.Width = 309
            '
            'cmsTermine
            '
            Me.cmsTermine.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuerTerminToolStripMenuItem1, Me.TerminLöschenToolStripMenuItem})
            Me.cmsTermine.Name = "cmsTermine"
            Me.cmsTermine.Size = New System.Drawing.Size(157, 48)
            '
            'NeuerTerminToolStripMenuItem1
            '
            Me.NeuerTerminToolStripMenuItem1.Name = "NeuerTerminToolStripMenuItem1"
            Me.NeuerTerminToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
            Me.NeuerTerminToolStripMenuItem1.Text = "&Neuer Termin"
            '
            'TerminLöschenToolStripMenuItem
            '
            Me.TerminLöschenToolStripMenuItem.Name = "TerminLöschenToolStripMenuItem"
            Me.TerminLöschenToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
            Me.TerminLöschenToolStripMenuItem.Text = "Termin &löschen"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtNotizenStellendaten)
            Me.GroupBox4.Location = New System.Drawing.Point(8, 507)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(349, 145)
            Me.GroupBox4.TabIndex = 3
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Notizen"
            '
            'txtNotizenStellendaten
            '
            Me.txtNotizenStellendaten.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtNotizenStellendaten.Location = New System.Drawing.Point(3, 16)
            Me.txtNotizenStellendaten.Multiline = True
            Me.txtNotizenStellendaten.Name = "txtNotizenStellendaten"
            Me.txtNotizenStellendaten.Size = New System.Drawing.Size(343, 126)
            Me.txtNotizenStellendaten.TabIndex = 0
            '
            'grpWege
            '
            Me.grpWege.Controls.Add(Me.btnOnlineFormular)
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
            Me.grpWege.Size = New System.Drawing.Size(349, 158)
            Me.grpWege.TabIndex = 2
            Me.grpWege.TabStop = False
            Me.grpWege.Text = "Bewerbungswege"
            '
            'btnOnlineFormular
            '
            Me.btnOnlineFormular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnOnlineFormular.Location = New System.Drawing.Point(291, 85)
            Me.btnOnlineFormular.Name = "btnOnlineFormular"
            Me.btnOnlineFormular.Size = New System.Drawing.Size(36, 20)
            Me.btnOnlineFormular.TabIndex = 38
            Me.btnOnlineFormular.Text = "=>"
            Me.btnOnlineFormular.UseVisualStyleBackColor = True
            '
            'txtOnlineForumlar
            '
            Me.txtOnlineForumlar.Enabled = False
            Me.txtOnlineForumlar.Location = New System.Drawing.Point(78, 85)
            Me.txtOnlineForumlar.Name = "txtOnlineForumlar"
            Me.txtOnlineForumlar.Size = New System.Drawing.Size(204, 20)
            Me.txtOnlineForumlar.TabIndex = 35
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
            '
            'chkTelefon
            '
            Me.chkTelefon.AutoSize = True
            Me.chkTelefon.Location = New System.Drawing.Point(6, 122)
            Me.chkTelefon.Name = "chkTelefon"
            Me.chkTelefon.Size = New System.Drawing.Size(62, 17)
            Me.chkTelefon.TabIndex = 36
            Me.chkTelefon.Text = "Telefon"
            Me.chkTelefon.UseVisualStyleBackColor = True
            '
            'chkOnline
            '
            Me.chkOnline.AutoSize = True
            Me.chkOnline.Location = New System.Drawing.Point(6, 88)
            Me.chkOnline.Name = "chkOnline"
            Me.chkOnline.Size = New System.Drawing.Size(56, 17)
            Me.chkOnline.TabIndex = 34
            Me.chkOnline.Text = "Online"
            Me.chkOnline.UseVisualStyleBackColor = True
            '
            'chkEMail
            '
            Me.chkEMail.AutoSize = True
            Me.chkEMail.Location = New System.Drawing.Point(6, 54)
            Me.chkEMail.Name = "chkEMail"
            Me.chkEMail.Size = New System.Drawing.Size(55, 17)
            Me.chkEMail.TabIndex = 32
            Me.chkEMail.Text = "E-Mail"
            Me.chkEMail.UseVisualStyleBackColor = True
            '
            'chkPost
            '
            Me.chkPost.AutoSize = True
            Me.chkPost.Location = New System.Drawing.Point(6, 20)
            Me.chkPost.Name = "chkPost"
            Me.chkPost.Size = New System.Drawing.Size(47, 17)
            Me.chkPost.TabIndex = 30
            Me.chkPost.Text = "Post"
            Me.chkPost.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox2.Controls.Add(Me.dlstvAnsprechpartner)
            Me.GroupBox2.Controls.Add(Me.txtFHomepage)
            Me.GroupBox2.Controls.Add(Me.Label20)
            Me.GroupBox2.Controls.Add(Me.txtAPosition)
            Me.GroupBox2.Controls.Add(Me.cmbAAnrede)
            Me.GroupBox2.Controls.Add(Me.Label17)
            Me.GroupBox2.Controls.Add(Me.txtAName)
            Me.GroupBox2.Controls.Add(Me.Label18)
            Me.GroupBox2.Controls.Add(Me.txtAEMail)
            Me.GroupBox2.Controls.Add(Me.txtAFax)
            Me.GroupBox2.Controls.Add(Me.txtATelefon)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.Label15)
            Me.GroupBox2.Controls.Add(Me.btnDelAnsprechpartner)
            Me.GroupBox2.Controls.Add(Me.btnAddAnsprechpartner)
            Me.GroupBox2.Controls.Add(Me.txtFEMail)
            Me.GroupBox2.Controls.Add(Me.txtFFax)
            Me.GroupBox2.Controls.Add(Me.txtFTelefon)
            Me.GroupBox2.Controls.Add(Me.txtFOrt)
            Me.GroupBox2.Controls.Add(Me.txtFPLZ)
            Me.GroupBox2.Controls.Add(Me.txtFStrasse)
            Me.GroupBox2.Controls.Add(Me.txtFName)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.Label11)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Location = New System.Drawing.Point(8, 113)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(981, 214)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Firmendaten"
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
            Me.dlstvAnsprechpartner.HotItemStyle = Me.HotItemStyle1
            Me.dlstvAnsprechpartner.Location = New System.Drawing.Point(371, 54)
            Me.dlstvAnsprechpartner.Name = "dlstvAnsprechpartner"
            Me.dlstvAnsprechpartner.ShowGroups = False
            Me.dlstvAnsprechpartner.ShowHeaderInAllViews = False
            Me.dlstvAnsprechpartner.Size = New System.Drawing.Size(245, 147)
            Me.dlstvAnsprechpartner.TabIndex = 34
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
            'txtFHomepage
            '
            Me.txtFHomepage.Location = New System.Drawing.Point(53, 181)
            Me.txtFHomepage.Name = "txtFHomepage"
            Me.txtFHomepage.Size = New System.Drawing.Size(229, 20)
            Me.txtFHomepage.TabIndex = 33
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
            'txtAPosition
            '
            Me.txtAPosition.Location = New System.Drawing.Point(678, 77)
            Me.txtAPosition.Name = "txtAPosition"
            Me.txtAPosition.Size = New System.Drawing.Size(195, 20)
            Me.txtAPosition.TabIndex = 31
            '
            'cmbAAnrede
            '
            Me.cmbAAnrede.BackColor = System.Drawing.SystemColors.Window
            Me.cmbAAnrede.FormattingEnabled = True
            Me.cmbAAnrede.Items.AddRange(New Object() {"", "Herr", "Frau"})
            Me.cmbAAnrede.Location = New System.Drawing.Point(678, 24)
            Me.cmbAAnrede.Name = "cmbAAnrede"
            Me.cmbAAnrede.Size = New System.Drawing.Size(195, 21)
            Me.cmbAAnrede.TabIndex = 5
            Me.cmbAAnrede.Visible = False
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(629, 80)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(47, 13)
            Me.Label17.TabIndex = 30
            Me.Label17.Text = "Position:"
            '
            'txtAName
            '
            Me.txtAName.Location = New System.Drawing.Point(678, 51)
            Me.txtAName.Name = "txtAName"
            Me.txtAName.Size = New System.Drawing.Size(195, 20)
            Me.txtAName.TabIndex = 28
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(629, 28)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(44, 13)
            Me.Label18.TabIndex = 4
            Me.Label18.Text = "Anrede:"
            Me.Label18.Visible = False
            '
            'txtAEMail
            '
            Me.txtAEMail.Location = New System.Drawing.Point(678, 155)
            Me.txtAEMail.Name = "txtAEMail"
            Me.txtAEMail.Size = New System.Drawing.Size(195, 20)
            Me.txtAEMail.TabIndex = 27
            '
            'txtAFax
            '
            Me.txtAFax.Location = New System.Drawing.Point(678, 129)
            Me.txtAFax.Name = "txtAFax"
            Me.txtAFax.Size = New System.Drawing.Size(195, 20)
            Me.txtAFax.TabIndex = 26
            '
            'txtATelefon
            '
            Me.txtATelefon.Location = New System.Drawing.Point(678, 103)
            Me.txtATelefon.Name = "txtATelefon"
            Me.txtATelefon.Size = New System.Drawing.Size(195, 20)
            Me.txtATelefon.TabIndex = 25
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(629, 158)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(39, 13)
            Me.Label13.TabIndex = 24
            Me.Label13.Text = "E-Mail:"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(629, 132)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(27, 13)
            Me.Label14.TabIndex = 23
            Me.Label14.Text = "Fax:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(629, 106)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(28, 13)
            Me.Label15.TabIndex = 22
            Me.Label15.Text = "Tel.:"
            '
            'btnDelAnsprechpartner
            '
            Me.btnDelAnsprechpartner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDelAnsprechpartner.Location = New System.Drawing.Point(596, 24)
            Me.btnDelAnsprechpartner.Name = "btnDelAnsprechpartner"
            Me.btnDelAnsprechpartner.Size = New System.Drawing.Size(20, 20)
            Me.btnDelAnsprechpartner.TabIndex = 21
            Me.btnDelAnsprechpartner.Text = "-"
            Me.btnDelAnsprechpartner.UseVisualStyleBackColor = True
            '
            'btnAddAnsprechpartner
            '
            Me.btnAddAnsprechpartner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnAddAnsprechpartner.Location = New System.Drawing.Point(570, 24)
            Me.btnAddAnsprechpartner.Name = "btnAddAnsprechpartner"
            Me.btnAddAnsprechpartner.Size = New System.Drawing.Size(20, 20)
            Me.btnAddAnsprechpartner.TabIndex = 20
            Me.btnAddAnsprechpartner.Text = "+"
            Me.btnAddAnsprechpartner.UseVisualStyleBackColor = True
            '
            'txtFEMail
            '
            Me.txtFEMail.Location = New System.Drawing.Point(53, 155)
            Me.txtFEMail.Name = "txtFEMail"
            Me.txtFEMail.Size = New System.Drawing.Size(229, 20)
            Me.txtFEMail.TabIndex = 9
            '
            'txtFFax
            '
            Me.txtFFax.Location = New System.Drawing.Point(53, 130)
            Me.txtFFax.Name = "txtFFax"
            Me.txtFFax.Size = New System.Drawing.Size(229, 20)
            Me.txtFFax.TabIndex = 8
            '
            'txtFTelefon
            '
            Me.txtFTelefon.Location = New System.Drawing.Point(53, 105)
            Me.txtFTelefon.Name = "txtFTelefon"
            Me.txtFTelefon.Size = New System.Drawing.Size(229, 20)
            Me.txtFTelefon.TabIndex = 7
            '
            'txtFOrt
            '
            Me.txtFOrt.Location = New System.Drawing.Point(163, 80)
            Me.txtFOrt.Name = "txtFOrt"
            Me.txtFOrt.Size = New System.Drawing.Size(119, 20)
            Me.txtFOrt.TabIndex = 6
            '
            'txtFPLZ
            '
            Me.txtFPLZ.Location = New System.Drawing.Point(53, 80)
            Me.txtFPLZ.Mask = "00000"
            Me.txtFPLZ.Name = "txtFPLZ"
            Me.txtFPLZ.Size = New System.Drawing.Size(65, 20)
            Me.txtFPLZ.TabIndex = 5
            '
            'txtFStrasse
            '
            Me.txtFStrasse.Location = New System.Drawing.Point(53, 55)
            Me.txtFStrasse.Name = "txtFStrasse"
            Me.txtFStrasse.Size = New System.Drawing.Size(229, 20)
            Me.txtFStrasse.TabIndex = 4
            '
            'txtFName
            '
            Me.txtFName.Location = New System.Drawing.Point(53, 30)
            Me.txtFName.Name = "txtFName"
            Me.txtFName.Size = New System.Drawing.Size(229, 20)
            Me.txtFName.TabIndex = 3
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(629, 54)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(38, 13)
            Me.Label12.TabIndex = 9
            Me.Label12.Text = "Name:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(368, 28)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(88, 13)
            Me.Label11.TabIndex = 8
            Me.Label11.Text = "Ansprechpartner:"
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
            Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.Controls.Add(Me.Label16)
            Me.GroupBox1.Controls.Add(Me.dtpErfasst)
            Me.GroupBox1.Controls.Add(Me.Label19)
            Me.GroupBox1.Controls.Add(Me.dtpVerschickt)
            Me.GroupBox1.Controls.Add(Me.txtStellenbezeichnung)
            Me.GroupBox1.Controls.Add(Me.txtStellennummer)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(981, 101)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Grunddaten"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(490, 26)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(98, 13)
            Me.Label16.TabIndex = 6
            Me.Label16.Text = "Bewerbung erfasst:"
            '
            'dtpErfasst
            '
            Me.dtpErfasst.Checked = False
            Me.dtpErfasst.Enabled = False
            Me.dtpErfasst.Location = New System.Drawing.Point(619, 23)
            Me.dtpErfasst.Name = "dtpErfasst"
            Me.dtpErfasst.Size = New System.Drawing.Size(200, 20)
            Me.dtpErfasst.TabIndex = 5
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
            Me.dtpVerschickt.TabIndex = 3
            '
            'txtStellenbezeichnung
            '
            Me.txtStellenbezeichnung.Location = New System.Drawing.Point(112, 23)
            Me.txtStellenbezeichnung.Name = "txtStellenbezeichnung"
            Me.txtStellenbezeichnung.Size = New System.Drawing.Size(354, 20)
            Me.txtStellenbezeichnung.TabIndex = 2
            '
            'txtStellennummer
            '
            Me.txtStellennummer.Location = New System.Drawing.Point(112, 55)
            Me.txtStellennummer.Name = "txtStellennummer"
            Me.txtStellennummer.Size = New System.Drawing.Size(354, 20)
            Me.txtStellennummer.TabIndex = 2
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
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.lblStellenbeschreibungPfad)
            Me.TabPage3.Controls.Add(Me.btnStellenbeschreibung)
            Me.TabPage3.Controls.Add(Me.txtStellenbeschreibung)
            Me.TabPage3.Controls.Add(Me.WebBrowserBeschreibung)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
            Me.TabPage3.Size = New System.Drawing.Size(995, 663)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Stellenbeschreibung"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'lblStellenbeschreibungPfad
            '
            Me.lblStellenbeschreibungPfad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblStellenbeschreibungPfad.Location = New System.Drawing.Point(6, 365)
            Me.lblStellenbeschreibungPfad.Name = "lblStellenbeschreibungPfad"
            Me.lblStellenbeschreibungPfad.Size = New System.Drawing.Size(983, 21)
            Me.lblStellenbeschreibungPfad.TabIndex = 3
            Me.lblStellenbeschreibungPfad.Text = "Keine Stellenbeschreibung vorhanden."
            Me.lblStellenbeschreibungPfad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnStellenbeschreibung
            '
            Me.btnStellenbeschreibung.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnStellenbeschreibung.Location = New System.Drawing.Point(388, 293)
            Me.btnStellenbeschreibung.Name = "btnStellenbeschreibung"
            Me.btnStellenbeschreibung.Size = New System.Drawing.Size(219, 69)
            Me.btnStellenbeschreibung.TabIndex = 2
            Me.btnStellenbeschreibung.Text = "Stellenbeschreibung öffnen"
            Me.btnStellenbeschreibung.UseVisualStyleBackColor = True
            Me.btnStellenbeschreibung.Visible = False
            '
            'txtStellenbeschreibung
            '
            Me.txtStellenbeschreibung.BackColor = System.Drawing.Color.White
            Me.txtStellenbeschreibung.Location = New System.Drawing.Point(3, 0)
            Me.txtStellenbeschreibung.Multiline = True
            Me.txtStellenbeschreibung.Name = "txtStellenbeschreibung"
            Me.txtStellenbeschreibung.ReadOnly = True
            Me.txtStellenbeschreibung.Size = New System.Drawing.Size(989, 655)
            Me.txtStellenbeschreibung.TabIndex = 1
            Me.txtStellenbeschreibung.Visible = False
            '
            'WebBrowserBeschreibung
            '
            Me.WebBrowserBeschreibung.AllowNavigation = False
            Me.WebBrowserBeschreibung.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WebBrowserBeschreibung.Location = New System.Drawing.Point(3, 3)
            Me.WebBrowserBeschreibung.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowserBeschreibung.Name = "WebBrowserBeschreibung"
            Me.WebBrowserBeschreibung.ScriptErrorsSuppressed = True
            Me.WebBrowserBeschreibung.Size = New System.Drawing.Size(989, 657)
            Me.WebBrowserBeschreibung.TabIndex = 0
            Me.WebBrowserBeschreibung.Visible = False
            '
            'cmsEmail
            '
            Me.cmsEmail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem1, Me.URLToolStripMenuItem})
            Me.cmsEmail.Name = "cmsEmail"
            Me.cmsEmail.Size = New System.Drawing.Size(112, 48)
            '
            'ÖffnenToolStripMenuItem1
            '
            Me.ÖffnenToolStripMenuItem1.Name = "ÖffnenToolStripMenuItem1"
            Me.ÖffnenToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
            Me.ÖffnenToolStripMenuItem1.Text = "Öffnen"
            '
            'URLToolStripMenuItem
            '
            Me.URLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tooltxtEMail})
            Me.URLToolStripMenuItem.Name = "URLToolStripMenuItem"
            Me.URLToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
            Me.URLToolStripMenuItem.Text = "URL"
            '
            'tooltxtEMail
            '
            Me.tooltxtEMail.Name = "tooltxtEMail"
            Me.tooltxtEMail.Size = New System.Drawing.Size(100, 23)
            '
            'cmsBewerbungsordner
            '
            Me.cmsBewerbungsordner.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem2, Me.PfadToolStripMenuItem})
            Me.cmsBewerbungsordner.Name = "cmsBewerbungsordner"
            Me.cmsBewerbungsordner.Size = New System.Drawing.Size(112, 48)
            '
            'ÖffnenToolStripMenuItem2
            '
            Me.ÖffnenToolStripMenuItem2.Name = "ÖffnenToolStripMenuItem2"
            Me.ÖffnenToolStripMenuItem2.Size = New System.Drawing.Size(111, 22)
            Me.ÖffnenToolStripMenuItem2.Text = "Öffnen"
            '
            'PfadToolStripMenuItem
            '
            Me.PfadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tooltxtBewerbungsordner})
            Me.PfadToolStripMenuItem.Name = "PfadToolStripMenuItem"
            Me.PfadToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
            Me.PfadToolStripMenuItem.Text = "Pfad"
            '
            'tooltxtBewerbungsordner
            '
            Me.tooltxtBewerbungsordner.Name = "tooltxtBewerbungsordner"
            Me.tooltxtBewerbungsordner.Size = New System.Drawing.Size(100, 23)
            '
            'cmsProgramme
            '
            Me.cmsProgramme.Name = "cmsWebseiten"
            Me.cmsProgramme.Size = New System.Drawing.Size(61, 4)
            '
            'FrmMainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1008, 730)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.StatusStrip1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "FrmMainForm"
            Me.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Bewerbungsmanager"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.cmsListView.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            CType(Me.dlstvStellenangebote, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpbVerlauf.ResumeLayout(False)
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox7.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.GroupBox8.ResumeLayout(False)
            CType(Me.dlstvTermine, System.ComponentModel.ISupportInitialize).EndInit()
            Me.cmsTermine.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.grpWege.ResumeLayout(False)
            Me.grpWege.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dlstvAnsprechpartner, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            Me.cmsEmail.ResumeLayout(False)
            Me.cmsBewerbungsordner.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
        Friend WithEvents HotItemStyle1 As BrightIdeasSoftware.HotItemStyle
        Friend WithEvents cmsListView As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNotizenStellendaten As System.Windows.Forms.TextBox
        Friend WithEvents grpWege As System.Windows.Forms.GroupBox
        Friend WithEvents txtOnlineForumlar As System.Windows.Forms.TextBox
        Friend WithEvents cmbTelefonAnsprech As System.Windows.Forms.ComboBox
        Friend WithEvents cmbEMailAnsprech As System.Windows.Forms.ComboBox
        Friend WithEvents cmbPostAnsprech As System.Windows.Forms.ComboBox
        Friend WithEvents chkTelefon As System.Windows.Forms.CheckBox
        Friend WithEvents chkOnline As System.Windows.Forms.CheckBox
        Friend WithEvents chkEMail As System.Windows.Forms.CheckBox
        Friend WithEvents chkPost As System.Windows.Forms.CheckBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtFHomepage As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
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
        Friend WithEvents txtFEMail As System.Windows.Forms.TextBox
        Friend WithEvents txtFFax As System.Windows.Forms.TextBox
        Friend WithEvents txtFTelefon As System.Windows.Forms.TextBox
        Friend WithEvents txtFOrt As System.Windows.Forms.TextBox
        Friend WithEvents txtFPLZ As System.Windows.Forms.MaskedTextBox
        Friend WithEvents txtFStrasse As System.Windows.Forms.TextBox
        Friend WithEvents txtFName As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
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
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents BewerbungAlsVersendetMarkierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents RückmeldungVonFirmaErhaltenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents InformationenNachreichenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents NeuerTerminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AbsageErhaltenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ZusageErhalteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents NeueBewerbungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents grpbVerlauf As System.Windows.Forms.GroupBox
        Friend WithEvents lboxVerlauf As System.Windows.Forms.ListBox
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents lblDBStatus As System.Windows.Forms.Label
        Friend WithEvents LinkLabel10 As System.Windows.Forms.LinkLabel
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents txtDBNotizen As System.Windows.Forms.TextBox
        Friend WithEvents WebBrowserBeschreibung As System.Windows.Forms.WebBrowser
        Friend WithEvents txtStellenbeschreibung As System.Windows.Forms.TextBox
        Friend WithEvents EingangsbestätigungErhaltenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents dlstvStellenangebote As BrightIdeasSoftware.DataListView
        Friend WithEvents columnStellenbezeichnung As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ColumnFirmenname As BrightIdeasSoftware.OLVColumn
        Friend WithEvents columnStatus As BrightIdeasSoftware.OLVColumn
        Friend WithEvents columnVersendet As BrightIdeasSoftware.OLVColumn
        Friend WithEvents columnBewerbungswege As BrightIdeasSoftware.OLVColumn
        Friend WithEvents columnErfasst As BrightIdeasSoftware.OLVColumn
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
        Friend WithEvents txtStellenbezeichnung As System.Windows.Forms.TextBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents dtpErfasst As System.Windows.Forms.DateTimePicker
        Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
        Friend WithEvents dlstvTermine As BrightIdeasSoftware.DataListView
        Friend WithEvents columnTerminBez As BrightIdeasSoftware.OLVColumn
        Friend WithEvents columnTerminUhrzeit As BrightIdeasSoftware.OLVColumn
        Friend WithEvents columnTerminAnsprechpartner As BrightIdeasSoftware.OLVColumn
        Friend WithEvents columnTerminNotizen As BrightIdeasSoftware.OLVColumn
        Friend WithEvents dlstvAnsprechpartner As BrightIdeasSoftware.DataListView
        Friend WithEvents columnAnsprechpartnerName As BrightIdeasSoftware.OLVColumn
        Friend WithEvents btnOnlineFormular As System.Windows.Forms.Button
        Friend WithEvents cmsTermine As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents NeuerTerminToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TerminLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents GeneriereDummyStellenangebeoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cmsEmail As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ÖffnenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents URLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tooltxtEMail As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents cmsBewerbungsordner As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ÖffnenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PfadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tooltxtBewerbungsordner As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents cmsWebseiten As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents BearbeiteWebseitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents BearbeiteProgrammeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cmsProgramme As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents btnStellenbeschreibung As System.Windows.Forms.Button
        Friend WithEvents lblStellenbeschreibungPfad As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents TutorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents StellenangebotLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    End Class
End Namespace