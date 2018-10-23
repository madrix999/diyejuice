<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.components = New System.ComponentModel.Container()
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.OuvirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.EnregistrerSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
Me.QuitterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.lblNic = New System.Windows.Forms.Label()
Me.pnlBase = New System.Windows.Forms.Panel()
Me.txtMlTotal = New System.Windows.Forms.MaskedTextBox()
Me.txtMgNic = New System.Windows.Forms.MaskedTextBox()
Me.txtPourcentNic = New System.Windows.Forms.MaskedTextBox()
Me.rdbPGNic = New System.Windows.Forms.RadioButton()
Me.rdbVGNic = New System.Windows.Forms.RadioButton()
Me.lblPercent2 = New System.Windows.Forms.Label()
Me.lblMg = New System.Windows.Forms.Label()
Me.lblPourcentNic = New System.Windows.Forms.Label()
Me.lblMl2 = New System.Windows.Forms.Label()
Me.lblPercent1 = New System.Windows.Forms.Label()
Me.txtVG = New System.Windows.Forms.TextBox()
Me.txtPG = New System.Windows.Forms.TextBox()
Me.lblVG = New System.Windows.Forms.Label()
Me.lblMlTotal = New System.Windows.Forms.Label()
Me.lblPG = New System.Windows.Forms.Label()
Me.lblNicPourcent = New System.Windows.Forms.Label()
Me.pnlSaveurs = New System.Windows.Forms.Panel()
Me.btnConfirmSaveur = New System.Windows.Forms.Button()
Me.txtPourcentSaveur = New System.Windows.Forms.MaskedTextBox()
Me.txtNomSaveur = New System.Windows.Forms.TextBox()
Me.lblPourcent5 = New System.Windows.Forms.Label()
Me.lblPourcentageSaveur = New System.Windows.Forms.Label()
Me.lblNomSaveur = New System.Windows.Forms.Label()
Me.lstSaveurs = New System.Windows.Forms.ListBox()
Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
Me.Panel3 = New System.Windows.Forms.Panel()
Me.lblPGPrc = New System.Windows.Forms.Label()
Me.lblNicgte = New System.Windows.Forms.Label()
Me.lblVGgte = New System.Windows.Forms.Label()
Me.lblPGgte = New System.Windows.Forms.Label()
Me.lblNicml = New System.Windows.Forms.Label()
Me.lblVGml = New System.Windows.Forms.Label()
Me.lblPGml = New System.Windows.Forms.Label()
Me.lblVGPrc = New System.Windows.Forms.Label()
Me.lblNicPrc = New System.Windows.Forms.Label()
Me.lblSav7gte = New System.Windows.Forms.Label()
Me.lblSav0gte = New System.Windows.Forms.Label()
Me.lblSav6gte = New System.Windows.Forms.Label()
Me.lblSav1gte = New System.Windows.Forms.Label()
Me.lblSav5gte = New System.Windows.Forms.Label()
Me.lblSav2gte = New System.Windows.Forms.Label()
Me.lblSav4gte = New System.Windows.Forms.Label()
Me.lblSav3gte = New System.Windows.Forms.Label()
Me.lblSav7ml = New System.Windows.Forms.Label()
Me.lblSav0ml = New System.Windows.Forms.Label()
Me.lblSav6ml = New System.Windows.Forms.Label()
Me.lblSav1ml = New System.Windows.Forms.Label()
Me.lblSav5ml = New System.Windows.Forms.Label()
Me.lblSav2ml = New System.Windows.Forms.Label()
Me.lblSav4ml = New System.Windows.Forms.Label()
Me.lblSav3ml = New System.Windows.Forms.Label()
Me.lblSav7Prc = New System.Windows.Forms.Label()
Me.lblSav0Prc = New System.Windows.Forms.Label()
Me.lblSav6Prc = New System.Windows.Forms.Label()
Me.lblSav1Prc = New System.Windows.Forms.Label()
Me.lblSav5Prc = New System.Windows.Forms.Label()
Me.lblSav2Prc = New System.Windows.Forms.Label()
Me.lblSav4Prc = New System.Windows.Forms.Label()
Me.lblSav3Prc = New System.Windows.Forms.Label()
Me.lblSaveur7 = New System.Windows.Forms.Label()
Me.lblSaveur6 = New System.Windows.Forms.Label()
Me.lblSaveur5 = New System.Windows.Forms.Label()
Me.lblSaveur4 = New System.Windows.Forms.Label()
Me.lblSaveur3 = New System.Windows.Forms.Label()
Me.lblSaveur2 = New System.Windows.Forms.Label()
Me.lblSaveur1 = New System.Windows.Forms.Label()
Me.lblSaveur0 = New System.Windows.Forms.Label()
Me.lblPGRecette = New System.Windows.Forms.Label()
Me.lblVGRecette = New System.Windows.Forms.Label()
Me.lblGoutes = New System.Windows.Forms.Label()
Me.lblMl = New System.Windows.Forms.Label()
Me.lblPrc = New System.Windows.Forms.Label()
Me.lblNicRecette = New System.Windows.Forms.Label()
Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape15 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape14 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape13 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape12 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
Me.mnuMenuStrip.SuspendLayout()
Me.pnlBase.SuspendLayout()
Me.pnlSaveurs.SuspendLayout()
Me.Panel3.SuspendLayout()
Me.SuspendLayout()
'
'mnuMenuStrip
'
Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ToolStripMenuItem1})
Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
Me.mnuMenuStrip.Name = "mnuMenuStrip"
Me.mnuMenuStrip.Size = New System.Drawing.Size(225, 24)
Me.mnuMenuStrip.TabIndex = 0
Me.mnuMenuStrip.Text = "MenuStrip1"
'
'FichierToolStripMenuItem
'
Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvirToolStripMenuItem, Me.EnregistrerSousToolStripMenuItem, Me.ImprimerToolStripMenuItem, Me.QuitterToolStripMenuItem, Me.QuitterToolStripMenuItem1})
Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
Me.FichierToolStripMenuItem.Text = "&Fichier"
'
'OuvirToolStripMenuItem
'
Me.OuvirToolStripMenuItem.Name = "OuvirToolStripMenuItem"
Me.OuvirToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
Me.OuvirToolStripMenuItem.Text = "&Ouvir"
'
'EnregistrerSousToolStripMenuItem
'
Me.EnregistrerSousToolStripMenuItem.Name = "EnregistrerSousToolStripMenuItem"
Me.EnregistrerSousToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
Me.EnregistrerSousToolStripMenuItem.Text = "&Enregistrer sous"
'
'ImprimerToolStripMenuItem
'
Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
Me.ImprimerToolStripMenuItem.Text = "&Imprimer"
'
'QuitterToolStripMenuItem
'
Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(154, 6)
'
'QuitterToolStripMenuItem1
'
Me.QuitterToolStripMenuItem1.Name = "QuitterToolStripMenuItem1"
Me.QuitterToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
Me.QuitterToolStripMenuItem1.Text = "&Quitter"
'
'ToolStripMenuItem1
'
Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposToolStripMenuItem})
Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
Me.ToolStripMenuItem1.Text = "&?"
'
'AProposToolStripMenuItem
'
Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
Me.AProposToolStripMenuItem.Text = "&A propos"
'
'lblNic
'
Me.lblNic.AutoSize = True
Me.lblNic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblNic.Location = New System.Drawing.Point(11, 9)
Me.lblNic.Name = "lblNic"
Me.lblNic.Size = New System.Drawing.Size(31, 16)
Me.lblNic.TabIndex = 1
Me.lblNic.Text = "Nic"
'
'pnlBase
'
Me.pnlBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.pnlBase.Controls.Add(Me.txtMlTotal)
Me.pnlBase.Controls.Add(Me.txtMgNic)
Me.pnlBase.Controls.Add(Me.txtPourcentNic)
Me.pnlBase.Controls.Add(Me.rdbPGNic)
Me.pnlBase.Controls.Add(Me.rdbVGNic)
Me.pnlBase.Controls.Add(Me.lblPercent2)
Me.pnlBase.Controls.Add(Me.lblMg)
Me.pnlBase.Controls.Add(Me.lblPourcentNic)
Me.pnlBase.Controls.Add(Me.lblMl2)
Me.pnlBase.Controls.Add(Me.lblPercent1)
Me.pnlBase.Controls.Add(Me.txtVG)
Me.pnlBase.Controls.Add(Me.txtPG)
Me.pnlBase.Controls.Add(Me.lblVG)
Me.pnlBase.Controls.Add(Me.lblMlTotal)
Me.pnlBase.Controls.Add(Me.lblPG)
Me.pnlBase.Controls.Add(Me.lblNicPourcent)
Me.pnlBase.Controls.Add(Me.lblNic)
Me.pnlBase.Location = New System.Drawing.Point(12, 28)
Me.pnlBase.Name = "pnlBase"
Me.pnlBase.Size = New System.Drawing.Size(202, 145)
Me.pnlBase.TabIndex = 2
'
'txtMlTotal
'
Me.txtMlTotal.Location = New System.Drawing.Point(125, 114)
Me.txtMlTotal.Mask = "99999"
Me.txtMlTotal.Name = "txtMlTotal"
Me.txtMlTotal.Size = New System.Drawing.Size(37, 20)
Me.txtMlTotal.TabIndex = 10
Me.txtMlTotal.ValidatingType = GetType(Integer)
'
'txtMgNic
'
Me.txtMgNic.Location = New System.Drawing.Point(46, 8)
Me.txtMgNic.Mask = "99999"
Me.txtMgNic.Name = "txtMgNic"
Me.txtMgNic.Size = New System.Drawing.Size(36, 20)
Me.txtMgNic.TabIndex = 9
Me.txtMgNic.ValidatingType = GetType(Integer)
'
'txtPourcentNic
'
Me.txtPourcentNic.Location = New System.Drawing.Point(142, 64)
Me.txtPourcentNic.Mask = "99999"
Me.txtPourcentNic.Name = "txtPourcentNic"
Me.txtPourcentNic.Size = New System.Drawing.Size(36, 20)
Me.txtPourcentNic.TabIndex = 8
Me.txtPourcentNic.ValidatingType = GetType(Integer)
'
'rdbPGNic
'
Me.rdbPGNic.AutoSize = True
Me.rdbPGNic.Location = New System.Drawing.Point(125, 32)
Me.rdbPGNic.Name = "rdbPGNic"
Me.rdbPGNic.Size = New System.Drawing.Size(40, 17)
Me.rdbPGNic.TabIndex = 7
Me.rdbPGNic.TabStop = True
Me.rdbPGNic.Text = "PG"
Me.rdbPGNic.UseVisualStyleBackColor = True
'
'rdbVGNic
'
Me.rdbVGNic.AutoSize = True
Me.rdbVGNic.Location = New System.Drawing.Point(125, 9)
Me.rdbVGNic.Name = "rdbVGNic"
Me.rdbVGNic.Size = New System.Drawing.Size(40, 17)
Me.rdbVGNic.TabIndex = 7
Me.rdbVGNic.TabStop = True
Me.rdbVGNic.Text = "VG"
Me.rdbVGNic.UseVisualStyleBackColor = True
'
'lblPercent2
'
Me.lblPercent2.AutoSize = True
Me.lblPercent2.Location = New System.Drawing.Point(84, 68)
Me.lblPercent2.Name = "lblPercent2"
Me.lblPercent2.Size = New System.Drawing.Size(15, 13)
Me.lblPercent2.TabIndex = 4
Me.lblPercent2.Text = "%"
'
'lblMg
'
Me.lblMg.AutoSize = True
Me.lblMg.Location = New System.Drawing.Point(84, 11)
Me.lblMg.Name = "lblMg"
Me.lblMg.Size = New System.Drawing.Size(21, 13)
Me.lblMg.TabIndex = 4
Me.lblMg.Text = "mg"
'
'lblPourcentNic
'
Me.lblPourcentNic.AutoSize = True
Me.lblPourcentNic.Location = New System.Drawing.Point(180, 68)
Me.lblPourcentNic.Name = "lblPourcentNic"
Me.lblPourcentNic.Size = New System.Drawing.Size(15, 13)
Me.lblPourcentNic.TabIndex = 4
Me.lblPourcentNic.Text = "%"
'
'lblMl2
'
Me.lblMl2.AutoSize = True
Me.lblMl2.Location = New System.Drawing.Point(168, 117)
Me.lblMl2.Name = "lblMl2"
Me.lblMl2.Size = New System.Drawing.Size(17, 13)
Me.lblMl2.TabIndex = 4
Me.lblMl2.Text = "ml"
'
'lblPercent1
'
Me.lblPercent1.AutoSize = True
Me.lblPercent1.Location = New System.Drawing.Point(84, 92)
Me.lblPercent1.Name = "lblPercent1"
Me.lblPercent1.Size = New System.Drawing.Size(15, 13)
Me.lblPercent1.TabIndex = 4
Me.lblPercent1.Text = "%"
'
'txtVG
'
Me.txtVG.Location = New System.Drawing.Point(46, 64)
Me.txtVG.Name = "txtVG"
Me.txtVG.Size = New System.Drawing.Size(36, 20)
Me.txtVG.TabIndex = 3
'
'txtPG
'
Me.txtPG.Enabled = False
Me.txtPG.Location = New System.Drawing.Point(46, 88)
Me.txtPG.Name = "txtPG"
Me.txtPG.Size = New System.Drawing.Size(36, 20)
Me.txtPG.TabIndex = 3
'
'lblVG
'
Me.lblVG.AutoSize = True
Me.lblVG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblVG.Location = New System.Drawing.Point(11, 65)
Me.lblVG.Name = "lblVG"
Me.lblVG.Size = New System.Drawing.Size(29, 16)
Me.lblVG.TabIndex = 1
Me.lblVG.Text = "VG"
'
'lblMlTotal
'
Me.lblMlTotal.AutoSize = True
Me.lblMlTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblMlTotal.Location = New System.Drawing.Point(11, 115)
Me.lblMlTotal.Name = "lblMlTotal"
Me.lblMlTotal.Size = New System.Drawing.Size(108, 16)
Me.lblMlTotal.TabIndex = 1
Me.lblMlTotal.Text = "Quantite totale"
'
'lblPG
'
Me.lblPG.AutoSize = True
Me.lblPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblPG.Location = New System.Drawing.Point(11, 89)
Me.lblPG.Name = "lblPG"
Me.lblPG.Size = New System.Drawing.Size(29, 16)
Me.lblPG.TabIndex = 1
Me.lblPG.Text = "PG"
'
'lblNicPourcent
'
Me.lblNicPourcent.AutoSize = True
Me.lblNicPourcent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblNicPourcent.Location = New System.Drawing.Point(110, 66)
Me.lblNicPourcent.Name = "lblNicPourcent"
Me.lblNicPourcent.Size = New System.Drawing.Size(31, 16)
Me.lblNicPourcent.TabIndex = 1
Me.lblNicPourcent.Text = "Nic"
'
'pnlSaveurs
'
Me.pnlSaveurs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.pnlSaveurs.Controls.Add(Me.btnConfirmSaveur)
Me.pnlSaveurs.Controls.Add(Me.txtPourcentSaveur)
Me.pnlSaveurs.Controls.Add(Me.txtNomSaveur)
Me.pnlSaveurs.Controls.Add(Me.lblPourcent5)
Me.pnlSaveurs.Controls.Add(Me.lblPourcentageSaveur)
Me.pnlSaveurs.Controls.Add(Me.lblNomSaveur)
Me.pnlSaveurs.Controls.Add(Me.lstSaveurs)
Me.pnlSaveurs.Location = New System.Drawing.Point(13, 179)
Me.pnlSaveurs.Name = "pnlSaveurs"
Me.pnlSaveurs.Size = New System.Drawing.Size(200, 120)
Me.pnlSaveurs.TabIndex = 3
'
'btnConfirmSaveur
'
Me.btnConfirmSaveur.Location = New System.Drawing.Point(72, 83)
Me.btnConfirmSaveur.Name = "btnConfirmSaveur"
Me.btnConfirmSaveur.Size = New System.Drawing.Size(117, 23)
Me.btnConfirmSaveur.TabIndex = 4
Me.btnConfirmSaveur.Text = "&Confirmer"
Me.btnConfirmSaveur.UseVisualStyleBackColor = True
'
'txtPourcentSaveur
'
Me.txtPourcentSaveur.Location = New System.Drawing.Point(139, 41)
Me.txtPourcentSaveur.Name = "txtPourcentSaveur"
Me.txtPourcentSaveur.Size = New System.Drawing.Size(29, 20)
Me.txtPourcentSaveur.TabIndex = 3
'
'txtNomSaveur
'
Me.txtNomSaveur.Location = New System.Drawing.Point(107, 3)
Me.txtNomSaveur.Name = "txtNomSaveur"
Me.txtNomSaveur.Size = New System.Drawing.Size(87, 20)
Me.txtNomSaveur.TabIndex = 2
'
'lblPourcent5
'
Me.lblPourcent5.AutoSize = True
Me.lblPourcent5.Location = New System.Drawing.Point(174, 44)
Me.lblPourcent5.Name = "lblPourcent5"
Me.lblPourcent5.Size = New System.Drawing.Size(15, 13)
Me.lblPourcent5.TabIndex = 1
Me.lblPourcent5.Text = "%"
'
'lblPourcentageSaveur
'
Me.lblPourcentageSaveur.AutoSize = True
Me.lblPourcentageSaveur.Location = New System.Drawing.Point(69, 44)
Me.lblPourcentageSaveur.Name = "lblPourcentageSaveur"
Me.lblPourcentageSaveur.Size = New System.Drawing.Size(68, 13)
Me.lblPourcentageSaveur.TabIndex = 1
Me.lblPourcentageSaveur.Text = "Pourcentage"
'
'lblNomSaveur
'
Me.lblNomSaveur.AutoSize = True
Me.lblNomSaveur.Location = New System.Drawing.Point(69, 3)
Me.lblNomSaveur.Name = "lblNomSaveur"
Me.lblNomSaveur.Size = New System.Drawing.Size(32, 13)
Me.lblNomSaveur.TabIndex = 1
Me.lblNomSaveur.Text = "Nom:"
'
'lstSaveurs
'
Me.lstSaveurs.FormattingEnabled = True
Me.lstSaveurs.Items.AddRange(New Object() {"Saveur", "Saveur", "Saveur", "Saveur", "Saveur", "Saveur", "Saveur", "Saveur"})
Me.lstSaveurs.Location = New System.Drawing.Point(3, 3)
Me.lstSaveurs.Name = "lstSaveurs"
Me.lstSaveurs.Size = New System.Drawing.Size(60, 108)
Me.lstSaveurs.TabIndex = 0
'
'tmrTimer
'
Me.tmrTimer.Enabled = True
'
'PrintForm1
'
Me.PrintForm1.DocumentName = "document"
Me.PrintForm1.Form = Me
Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
Me.PrintForm1.PrintFileName = Nothing
'
'Panel3
'
Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.Panel3.Controls.Add(Me.lblPGPrc)
Me.Panel3.Controls.Add(Me.lblNicgte)
Me.Panel3.Controls.Add(Me.lblVGgte)
Me.Panel3.Controls.Add(Me.lblPGgte)
Me.Panel3.Controls.Add(Me.lblNicml)
Me.Panel3.Controls.Add(Me.lblVGml)
Me.Panel3.Controls.Add(Me.lblPGml)
Me.Panel3.Controls.Add(Me.lblVGPrc)
Me.Panel3.Controls.Add(Me.lblNicPrc)
Me.Panel3.Controls.Add(Me.lblSav7gte)
Me.Panel3.Controls.Add(Me.lblSav0gte)
Me.Panel3.Controls.Add(Me.lblSav6gte)
Me.Panel3.Controls.Add(Me.lblSav1gte)
Me.Panel3.Controls.Add(Me.lblSav5gte)
Me.Panel3.Controls.Add(Me.lblSav2gte)
Me.Panel3.Controls.Add(Me.lblSav4gte)
Me.Panel3.Controls.Add(Me.lblSav3gte)
Me.Panel3.Controls.Add(Me.lblSav7ml)
Me.Panel3.Controls.Add(Me.lblSav0ml)
Me.Panel3.Controls.Add(Me.lblSav6ml)
Me.Panel3.Controls.Add(Me.lblSav1ml)
Me.Panel3.Controls.Add(Me.lblSav5ml)
Me.Panel3.Controls.Add(Me.lblSav2ml)
Me.Panel3.Controls.Add(Me.lblSav4ml)
Me.Panel3.Controls.Add(Me.lblSav3ml)
Me.Panel3.Controls.Add(Me.lblSav7Prc)
Me.Panel3.Controls.Add(Me.lblSav0Prc)
Me.Panel3.Controls.Add(Me.lblSav6Prc)
Me.Panel3.Controls.Add(Me.lblSav1Prc)
Me.Panel3.Controls.Add(Me.lblSav5Prc)
Me.Panel3.Controls.Add(Me.lblSav2Prc)
Me.Panel3.Controls.Add(Me.lblSav4Prc)
Me.Panel3.Controls.Add(Me.lblSav3Prc)
Me.Panel3.Controls.Add(Me.lblSaveur7)
Me.Panel3.Controls.Add(Me.lblSaveur6)
Me.Panel3.Controls.Add(Me.lblSaveur5)
Me.Panel3.Controls.Add(Me.lblSaveur4)
Me.Panel3.Controls.Add(Me.lblSaveur3)
Me.Panel3.Controls.Add(Me.lblSaveur2)
Me.Panel3.Controls.Add(Me.lblSaveur1)
Me.Panel3.Controls.Add(Me.lblSaveur0)
Me.Panel3.Controls.Add(Me.lblPGRecette)
Me.Panel3.Controls.Add(Me.lblVGRecette)
Me.Panel3.Controls.Add(Me.lblGoutes)
Me.Panel3.Controls.Add(Me.lblMl)
Me.Panel3.Controls.Add(Me.lblPrc)
Me.Panel3.Controls.Add(Me.lblNicRecette)
Me.Panel3.Controls.Add(Me.ShapeContainer1)
Me.Panel3.Location = New System.Drawing.Point(14, 305)
Me.Panel3.Name = "Panel3"
Me.Panel3.Size = New System.Drawing.Size(200, 245)
Me.Panel3.TabIndex = 4
'
'lblPGPrc
'
Me.lblPGPrc.AutoSize = True
Me.lblPGPrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblPGPrc.Location = New System.Drawing.Point(79, 62)
Me.lblPGPrc.Name = "lblPGPrc"
Me.lblPGPrc.Size = New System.Drawing.Size(0, 12)
Me.lblPGPrc.TabIndex = 26
'
'lblNicgte
'
Me.lblNicgte.AutoSize = True
Me.lblNicgte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblNicgte.Location = New System.Drawing.Point(151, 23)
Me.lblNicgte.Name = "lblNicgte"
Me.lblNicgte.Size = New System.Drawing.Size(0, 12)
Me.lblNicgte.TabIndex = 25
'
'lblVGgte
'
Me.lblVGgte.AutoSize = True
Me.lblVGgte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblVGgte.Location = New System.Drawing.Point(150, 42)
Me.lblVGgte.Name = "lblVGgte"
Me.lblVGgte.Size = New System.Drawing.Size(0, 12)
Me.lblVGgte.TabIndex = 24
'
'lblPGgte
'
Me.lblPGgte.AutoSize = True
Me.lblPGgte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblPGgte.Location = New System.Drawing.Point(150, 62)
Me.lblPGgte.Name = "lblPGgte"
Me.lblPGgte.Size = New System.Drawing.Size(0, 12)
Me.lblPGgte.TabIndex = 23
'
'lblNicml
'
Me.lblNicml.AutoSize = True
Me.lblNicml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblNicml.Location = New System.Drawing.Point(112, 22)
Me.lblNicml.Name = "lblNicml"
Me.lblNicml.Size = New System.Drawing.Size(0, 12)
Me.lblNicml.TabIndex = 22
'
'lblVGml
'
Me.lblVGml.AutoSize = True
Me.lblVGml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblVGml.Location = New System.Drawing.Point(112, 42)
Me.lblVGml.Name = "lblVGml"
Me.lblVGml.Size = New System.Drawing.Size(0, 12)
Me.lblVGml.TabIndex = 21
'
'lblPGml
'
Me.lblPGml.AutoSize = True
Me.lblPGml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblPGml.Location = New System.Drawing.Point(111, 61)
Me.lblPGml.Name = "lblPGml"
Me.lblPGml.Size = New System.Drawing.Size(0, 12)
Me.lblPGml.TabIndex = 20
'
'lblVGPrc
'
Me.lblVGPrc.AutoSize = True
Me.lblVGPrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblVGPrc.Location = New System.Drawing.Point(79, 42)
Me.lblVGPrc.Name = "lblVGPrc"
Me.lblVGPrc.Size = New System.Drawing.Size(0, 12)
Me.lblVGPrc.TabIndex = 19
'
'lblNicPrc
'
Me.lblNicPrc.AutoSize = True
Me.lblNicPrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblNicPrc.Location = New System.Drawing.Point(78, 22)
Me.lblNicPrc.Name = "lblNicPrc"
Me.lblNicPrc.Size = New System.Drawing.Size(0, 12)
Me.lblNicPrc.TabIndex = 18
'
'lblSav7gte
'
Me.lblSav7gte.AutoSize = True
Me.lblSav7gte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav7gte.Location = New System.Drawing.Point(150, 225)
Me.lblSav7gte.Name = "lblSav7gte"
Me.lblSav7gte.Size = New System.Drawing.Size(0, 12)
Me.lblSav7gte.TabIndex = 15
'
'lblSav0gte
'
Me.lblSav0gte.AutoSize = True
Me.lblSav0gte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav0gte.Location = New System.Drawing.Point(150, 81)
Me.lblSav0gte.Name = "lblSav0gte"
Me.lblSav0gte.Size = New System.Drawing.Size(0, 12)
Me.lblSav0gte.TabIndex = 14
'
'lblSav6gte
'
Me.lblSav6gte.AutoSize = True
Me.lblSav6gte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav6gte.Location = New System.Drawing.Point(150, 203)
Me.lblSav6gte.Name = "lblSav6gte"
Me.lblSav6gte.Size = New System.Drawing.Size(0, 12)
Me.lblSav6gte.TabIndex = 17
'
'lblSav1gte
'
Me.lblSav1gte.AutoSize = True
Me.lblSav1gte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav1gte.Location = New System.Drawing.Point(150, 102)
Me.lblSav1gte.Name = "lblSav1gte"
Me.lblSav1gte.Size = New System.Drawing.Size(0, 12)
Me.lblSav1gte.TabIndex = 16
'
'lblSav5gte
'
Me.lblSav5gte.AutoSize = True
Me.lblSav5gte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav5gte.Location = New System.Drawing.Point(150, 183)
Me.lblSav5gte.Name = "lblSav5gte"
Me.lblSav5gte.Size = New System.Drawing.Size(0, 12)
Me.lblSav5gte.TabIndex = 11
'
'lblSav2gte
'
Me.lblSav2gte.AutoSize = True
Me.lblSav2gte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav2gte.Location = New System.Drawing.Point(150, 123)
Me.lblSav2gte.Name = "lblSav2gte"
Me.lblSav2gte.Size = New System.Drawing.Size(0, 12)
Me.lblSav2gte.TabIndex = 10
'
'lblSav4gte
'
Me.lblSav4gte.AutoSize = True
Me.lblSav4gte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav4gte.Location = New System.Drawing.Point(150, 163)
Me.lblSav4gte.Name = "lblSav4gte"
Me.lblSav4gte.Size = New System.Drawing.Size(0, 12)
Me.lblSav4gte.TabIndex = 13
'
'lblSav3gte
'
Me.lblSav3gte.AutoSize = True
Me.lblSav3gte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav3gte.Location = New System.Drawing.Point(150, 143)
Me.lblSav3gte.Name = "lblSav3gte"
Me.lblSav3gte.Size = New System.Drawing.Size(0, 12)
Me.lblSav3gte.TabIndex = 12
'
'lblSav7ml
'
Me.lblSav7ml.AutoSize = True
Me.lblSav7ml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav7ml.Location = New System.Drawing.Point(112, 225)
Me.lblSav7ml.Name = "lblSav7ml"
Me.lblSav7ml.Size = New System.Drawing.Size(0, 12)
Me.lblSav7ml.TabIndex = 7
'
'lblSav0ml
'
Me.lblSav0ml.AutoSize = True
Me.lblSav0ml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav0ml.Location = New System.Drawing.Point(112, 81)
Me.lblSav0ml.Name = "lblSav0ml"
Me.lblSav0ml.Size = New System.Drawing.Size(0, 12)
Me.lblSav0ml.TabIndex = 6
'
'lblSav6ml
'
Me.lblSav6ml.AutoSize = True
Me.lblSav6ml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav6ml.Location = New System.Drawing.Point(112, 203)
Me.lblSav6ml.Name = "lblSav6ml"
Me.lblSav6ml.Size = New System.Drawing.Size(0, 12)
Me.lblSav6ml.TabIndex = 9
'
'lblSav1ml
'
Me.lblSav1ml.AutoSize = True
Me.lblSav1ml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav1ml.Location = New System.Drawing.Point(112, 102)
Me.lblSav1ml.Name = "lblSav1ml"
Me.lblSav1ml.Size = New System.Drawing.Size(0, 12)
Me.lblSav1ml.TabIndex = 8
'
'lblSav5ml
'
Me.lblSav5ml.AutoSize = True
Me.lblSav5ml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav5ml.Location = New System.Drawing.Point(112, 183)
Me.lblSav5ml.Name = "lblSav5ml"
Me.lblSav5ml.Size = New System.Drawing.Size(0, 12)
Me.lblSav5ml.TabIndex = 3
'
'lblSav2ml
'
Me.lblSav2ml.AutoSize = True
Me.lblSav2ml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav2ml.Location = New System.Drawing.Point(112, 123)
Me.lblSav2ml.Name = "lblSav2ml"
Me.lblSav2ml.Size = New System.Drawing.Size(0, 12)
Me.lblSav2ml.TabIndex = 2
'
'lblSav4ml
'
Me.lblSav4ml.AutoSize = True
Me.lblSav4ml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav4ml.Location = New System.Drawing.Point(112, 163)
Me.lblSav4ml.Name = "lblSav4ml"
Me.lblSav4ml.Size = New System.Drawing.Size(0, 12)
Me.lblSav4ml.TabIndex = 5
'
'lblSav3ml
'
Me.lblSav3ml.AutoSize = True
Me.lblSav3ml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav3ml.Location = New System.Drawing.Point(112, 143)
Me.lblSav3ml.Name = "lblSav3ml"
Me.lblSav3ml.Size = New System.Drawing.Size(0, 12)
Me.lblSav3ml.TabIndex = 4
'
'lblSav7Prc
'
Me.lblSav7Prc.AutoSize = True
Me.lblSav7Prc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav7Prc.Location = New System.Drawing.Point(79, 225)
Me.lblSav7Prc.Name = "lblSav7Prc"
Me.lblSav7Prc.Size = New System.Drawing.Size(0, 12)
Me.lblSav7Prc.TabIndex = 0
'
'lblSav0Prc
'
Me.lblSav0Prc.AutoSize = True
Me.lblSav0Prc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav0Prc.Location = New System.Drawing.Point(79, 81)
Me.lblSav0Prc.Name = "lblSav0Prc"
Me.lblSav0Prc.Size = New System.Drawing.Size(0, 12)
Me.lblSav0Prc.TabIndex = 0
'
'lblSav6Prc
'
Me.lblSav6Prc.AutoSize = True
Me.lblSav6Prc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav6Prc.Location = New System.Drawing.Point(79, 203)
Me.lblSav6Prc.Name = "lblSav6Prc"
Me.lblSav6Prc.Size = New System.Drawing.Size(0, 12)
Me.lblSav6Prc.TabIndex = 0
'
'lblSav1Prc
'
Me.lblSav1Prc.AutoSize = True
Me.lblSav1Prc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav1Prc.Location = New System.Drawing.Point(79, 102)
Me.lblSav1Prc.Name = "lblSav1Prc"
Me.lblSav1Prc.Size = New System.Drawing.Size(0, 12)
Me.lblSav1Prc.TabIndex = 0
'
'lblSav5Prc
'
Me.lblSav5Prc.AutoSize = True
Me.lblSav5Prc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav5Prc.Location = New System.Drawing.Point(79, 183)
Me.lblSav5Prc.Name = "lblSav5Prc"
Me.lblSav5Prc.Size = New System.Drawing.Size(0, 12)
Me.lblSav5Prc.TabIndex = 0
'
'lblSav2Prc
'
Me.lblSav2Prc.AutoSize = True
Me.lblSav2Prc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav2Prc.Location = New System.Drawing.Point(79, 123)
Me.lblSav2Prc.Name = "lblSav2Prc"
Me.lblSav2Prc.Size = New System.Drawing.Size(0, 12)
Me.lblSav2Prc.TabIndex = 0
'
'lblSav4Prc
'
Me.lblSav4Prc.AutoSize = True
Me.lblSav4Prc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav4Prc.Location = New System.Drawing.Point(79, 163)
Me.lblSav4Prc.Name = "lblSav4Prc"
Me.lblSav4Prc.Size = New System.Drawing.Size(0, 12)
Me.lblSav4Prc.TabIndex = 0
'
'lblSav3Prc
'
Me.lblSav3Prc.AutoSize = True
Me.lblSav3Prc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSav3Prc.Location = New System.Drawing.Point(79, 143)
Me.lblSav3Prc.Name = "lblSav3Prc"
Me.lblSav3Prc.Size = New System.Drawing.Size(0, 12)
Me.lblSav3Prc.TabIndex = 0
'
'lblSaveur7
'
Me.lblSaveur7.AutoSize = True
Me.lblSaveur7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSaveur7.Location = New System.Drawing.Point(1, 224)
Me.lblSaveur7.Margin = New System.Windows.Forms.Padding(0)
Me.lblSaveur7.Name = "lblSaveur7"
Me.lblSaveur7.Size = New System.Drawing.Size(0, 12)
Me.lblSaveur7.TabIndex = 0
'
'lblSaveur6
'
Me.lblSaveur6.AutoSize = True
Me.lblSaveur6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSaveur6.Location = New System.Drawing.Point(1, 202)
Me.lblSaveur6.Margin = New System.Windows.Forms.Padding(0)
Me.lblSaveur6.Name = "lblSaveur6"
Me.lblSaveur6.Size = New System.Drawing.Size(0, 12)
Me.lblSaveur6.TabIndex = 0
'
'lblSaveur5
'
Me.lblSaveur5.AutoSize = True
Me.lblSaveur5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSaveur5.Location = New System.Drawing.Point(1, 182)
Me.lblSaveur5.Margin = New System.Windows.Forms.Padding(0)
Me.lblSaveur5.Name = "lblSaveur5"
Me.lblSaveur5.Size = New System.Drawing.Size(0, 12)
Me.lblSaveur5.TabIndex = 0
'
'lblSaveur4
'
Me.lblSaveur4.AutoSize = True
Me.lblSaveur4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSaveur4.Location = New System.Drawing.Point(1, 162)
Me.lblSaveur4.Margin = New System.Windows.Forms.Padding(0)
Me.lblSaveur4.Name = "lblSaveur4"
Me.lblSaveur4.Size = New System.Drawing.Size(0, 12)
Me.lblSaveur4.TabIndex = 0
'
'lblSaveur3
'
Me.lblSaveur3.AutoSize = True
Me.lblSaveur3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSaveur3.Location = New System.Drawing.Point(1, 142)
Me.lblSaveur3.Margin = New System.Windows.Forms.Padding(0)
Me.lblSaveur3.Name = "lblSaveur3"
Me.lblSaveur3.Size = New System.Drawing.Size(0, 12)
Me.lblSaveur3.TabIndex = 0
'
'lblSaveur2
'
Me.lblSaveur2.AutoSize = True
Me.lblSaveur2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSaveur2.Location = New System.Drawing.Point(1, 122)
Me.lblSaveur2.Margin = New System.Windows.Forms.Padding(0)
Me.lblSaveur2.Name = "lblSaveur2"
Me.lblSaveur2.Size = New System.Drawing.Size(0, 12)
Me.lblSaveur2.TabIndex = 0
'
'lblSaveur1
'
Me.lblSaveur1.AutoSize = True
Me.lblSaveur1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSaveur1.Location = New System.Drawing.Point(1, 101)
Me.lblSaveur1.Margin = New System.Windows.Forms.Padding(0)
Me.lblSaveur1.Name = "lblSaveur1"
Me.lblSaveur1.Size = New System.Drawing.Size(0, 12)
Me.lblSaveur1.TabIndex = 0
'
'lblSaveur0
'
Me.lblSaveur0.AutoSize = True
Me.lblSaveur0.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSaveur0.Location = New System.Drawing.Point(1, 80)
Me.lblSaveur0.Margin = New System.Windows.Forms.Padding(0)
Me.lblSaveur0.Name = "lblSaveur0"
Me.lblSaveur0.Size = New System.Drawing.Size(0, 12)
Me.lblSaveur0.TabIndex = 0
'
'lblPGRecette
'
Me.lblPGRecette.AutoSize = True
Me.lblPGRecette.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblPGRecette.Location = New System.Drawing.Point(49, 61)
Me.lblPGRecette.Name = "lblPGRecette"
Me.lblPGRecette.Size = New System.Drawing.Size(24, 13)
Me.lblPGRecette.TabIndex = 0
Me.lblPGRecette.Text = "PG"
'
'lblVGRecette
'
Me.lblVGRecette.AutoSize = True
Me.lblVGRecette.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblVGRecette.Location = New System.Drawing.Point(49, 41)
Me.lblVGRecette.Name = "lblVGRecette"
Me.lblVGRecette.Size = New System.Drawing.Size(24, 13)
Me.lblVGRecette.TabIndex = 0
Me.lblVGRecette.Text = "VG"
'
'lblGoutes
'
Me.lblGoutes.AutoSize = True
Me.lblGoutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblGoutes.Location = New System.Drawing.Point(146, 3)
Me.lblGoutes.Name = "lblGoutes"
Me.lblGoutes.Size = New System.Drawing.Size(47, 13)
Me.lblGoutes.TabIndex = 0
Me.lblGoutes.Text = "Goutes"
'
'lblMl
'
Me.lblMl.AutoSize = True
Me.lblMl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblMl.Location = New System.Drawing.Point(117, 2)
Me.lblMl.Name = "lblMl"
Me.lblMl.Size = New System.Drawing.Size(20, 13)
Me.lblMl.TabIndex = 0
Me.lblMl.Text = "Ml"
'
'lblPrc
'
Me.lblPrc.AutoSize = True
Me.lblPrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblPrc.Location = New System.Drawing.Point(84, 3)
Me.lblPrc.Name = "lblPrc"
Me.lblPrc.Size = New System.Drawing.Size(16, 13)
Me.lblPrc.TabIndex = 0
Me.lblPrc.Text = "%"
'
'lblNicRecette
'
Me.lblNicRecette.AutoSize = True
Me.lblNicRecette.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblNicRecette.Location = New System.Drawing.Point(47, 21)
Me.lblNicRecette.Name = "lblNicRecette"
Me.lblNicRecette.Size = New System.Drawing.Size(26, 13)
Me.lblNicRecette.TabIndex = 0
Me.lblNicRecette.Text = "Nic"
'
'ShapeContainer1
'
Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
Me.ShapeContainer1.Name = "ShapeContainer1"
Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape10, Me.LineShape15, Me.LineShape14, Me.LineShape13, Me.LineShape12, Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
Me.ShapeContainer1.Size = New System.Drawing.Size(196, 241)
Me.ShapeContainer1.TabIndex = 1
Me.ShapeContainer1.TabStop = False
'
'LineShape10
'
Me.LineShape10.Name = "LineShape10"
Me.LineShape10.X1 = 0
Me.LineShape10.X2 = 196
Me.LineShape10.Y1 = 219
Me.LineShape10.Y2 = 219
'
'LineShape15
'
Me.LineShape15.Name = "LineShape15"
Me.LineShape15.X1 = 0
Me.LineShape15.X2 = 197
Me.LineShape15.Y1 = 138
Me.LineShape15.Y2 = 138
'
'LineShape14
'
Me.LineShape14.Name = "LineShape14"
Me.LineShape14.X1 = 0
Me.LineShape14.X2 = 198
Me.LineShape14.Y1 = 158
Me.LineShape14.Y2 = 158
'
'LineShape13
'
Me.LineShape13.Name = "LineShape13"
Me.LineShape13.X1 = 0
Me.LineShape13.X2 = 196
Me.LineShape13.Y1 = 178
Me.LineShape13.Y2 = 178
'
'LineShape12
'
Me.LineShape12.Name = "LineShape12"
Me.LineShape12.X1 = -1
Me.LineShape12.X2 = 195
Me.LineShape12.Y1 = 198
Me.LineShape12.Y2 = 198
'
'LineShape9
'
Me.LineShape9.Name = "LineShape9"
Me.LineShape9.X1 = 0
Me.LineShape9.X2 = 196
Me.LineShape9.Y1 = 118
Me.LineShape9.Y2 = 118
'
'LineShape8
'
Me.LineShape8.Name = "LineShape8"
Me.LineShape8.X1 = -1
Me.LineShape8.X2 = 195
Me.LineShape8.Y1 = 77
Me.LineShape8.Y2 = 77
'
'LineShape7
'
Me.LineShape7.Name = "LineShape7"
Me.LineShape7.X1 = -2
Me.LineShape7.X2 = 197
Me.LineShape7.Y1 = 97
Me.LineShape7.Y2 = 97
'
'LineShape6
'
Me.LineShape6.Name = "LineShape6"
Me.LineShape6.X1 = 0
Me.LineShape6.X2 = 198
Me.LineShape6.Y1 = 37
Me.LineShape6.Y2 = 37
'
'LineShape5
'
Me.LineShape5.Name = "LineShape5"
Me.LineShape5.X1 = 0
Me.LineShape5.X2 = 196
Me.LineShape5.Y1 = 57
Me.LineShape5.Y2 = 57
'
'LineShape4
'
Me.LineShape4.Name = "LineShape4"
Me.LineShape4.X1 = 0
Me.LineShape4.X2 = 197
Me.LineShape4.Y1 = 17
Me.LineShape4.Y2 = 17
'
'LineShape3
'
Me.LineShape3.Name = "LineShape3"
Me.LineShape3.X1 = 145
Me.LineShape3.X2 = 145
Me.LineShape3.Y1 = -1
Me.LineShape3.Y2 = 247
'
'LineShape2
'
Me.LineShape2.Name = "LineShape2"
Me.LineShape2.X1 = 107
Me.LineShape2.X2 = 107
Me.LineShape2.Y1 = 0
Me.LineShape2.Y2 = 247
'
'LineShape1
'
Me.LineShape1.Name = "LineShape1"
Me.LineShape1.X1 = 74
Me.LineShape1.X2 = 74
Me.LineShape1.Y1 = -1
Me.LineShape1.Y2 = 242
'
'ToolTip1
'
'
'frmMain
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(225, 563)
Me.Controls.Add(Me.Panel3)
Me.Controls.Add(Me.pnlSaveurs)
Me.Controls.Add(Me.pnlBase)
Me.Controls.Add(Me.mnuMenuStrip)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
Me.MainMenuStrip = Me.mnuMenuStrip
Me.Name = "frmMain"
Me.Text = "DYI E-Juice"
Me.mnuMenuStrip.ResumeLayout(False)
Me.mnuMenuStrip.PerformLayout()
Me.pnlBase.ResumeLayout(False)
Me.pnlBase.PerformLayout()
Me.pnlSaveurs.ResumeLayout(False)
Me.pnlSaveurs.PerformLayout()
Me.Panel3.ResumeLayout(False)
Me.Panel3.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents mnuMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerSousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNic As System.Windows.Forms.Label
    Friend WithEvents pnlBase As System.Windows.Forms.Panel
    Friend WithEvents lblPercent2 As System.Windows.Forms.Label
    Friend WithEvents lblPercent1 As System.Windows.Forms.Label
    Friend WithEvents txtVG As System.Windows.Forms.TextBox
    Friend WithEvents txtPG As System.Windows.Forms.TextBox
    Friend WithEvents lblVG As System.Windows.Forms.Label
    Friend WithEvents lblPG As System.Windows.Forms.Label
    Friend WithEvents lblMg As System.Windows.Forms.Label
    Friend WithEvents pnlSaveurs As System.Windows.Forms.Panel
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents lstSaveurs As System.Windows.Forms.ListBox
    Friend WithEvents txtPourcentSaveur As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNomSaveur As System.Windows.Forms.TextBox
    Friend WithEvents lblPourcent5 As System.Windows.Forms.Label
    Friend WithEvents lblNomSaveur As System.Windows.Forms.Label
    Friend WithEvents btnConfirmSaveur As System.Windows.Forms.Button
    Friend WithEvents lblPourcentageSaveur As System.Windows.Forms.Label
    Friend WithEvents lblPourcentNic As System.Windows.Forms.Label
    Friend WithEvents lblNicPourcent As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblGoutes As System.Windows.Forms.Label
    Friend WithEvents lblMl As System.Windows.Forms.Label
    Friend WithEvents lblPrc As System.Windows.Forms.Label
    Friend WithEvents lblNicRecette As System.Windows.Forms.Label
    Friend WithEvents lblSaveur6 As System.Windows.Forms.Label
    Friend WithEvents lblSaveur5 As System.Windows.Forms.Label
    Friend WithEvents lblSaveur4 As System.Windows.Forms.Label
    Friend WithEvents lblSaveur3 As System.Windows.Forms.Label
    Friend WithEvents lblSaveur2 As System.Windows.Forms.Label
    Friend WithEvents lblSaveur1 As System.Windows.Forms.Label
    Friend WithEvents lblSaveur0 As System.Windows.Forms.Label
    Friend WithEvents lblPGRecette As System.Windows.Forms.Label
    Friend WithEvents lblVGRecette As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape15 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape14 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape13 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape12 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblSaveur7 As System.Windows.Forms.Label
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblNicml As System.Windows.Forms.Label
    Friend WithEvents lblVGml As System.Windows.Forms.Label
    Friend WithEvents lblPGml As System.Windows.Forms.Label
    Friend WithEvents lblVGPrc As System.Windows.Forms.Label
    Friend WithEvents lblNicPrc As System.Windows.Forms.Label
    Friend WithEvents lblSav7gte As System.Windows.Forms.Label
    Friend WithEvents lblSav0gte As System.Windows.Forms.Label
    Friend WithEvents lblSav6gte As System.Windows.Forms.Label
    Friend WithEvents lblSav1gte As System.Windows.Forms.Label
    Friend WithEvents lblSav5gte As System.Windows.Forms.Label
    Friend WithEvents lblSav2gte As System.Windows.Forms.Label
    Friend WithEvents lblSav4gte As System.Windows.Forms.Label
    Friend WithEvents lblSav3gte As System.Windows.Forms.Label
    Friend WithEvents lblSav7ml As System.Windows.Forms.Label
    Friend WithEvents lblSav0ml As System.Windows.Forms.Label
    Friend WithEvents lblSav6ml As System.Windows.Forms.Label
    Friend WithEvents lblSav1ml As System.Windows.Forms.Label
    Friend WithEvents lblSav5ml As System.Windows.Forms.Label
    Friend WithEvents lblSav2ml As System.Windows.Forms.Label
    Friend WithEvents lblSav4ml As System.Windows.Forms.Label
    Friend WithEvents lblSav3ml As System.Windows.Forms.Label
    Friend WithEvents lblSav7Prc As System.Windows.Forms.Label
    Friend WithEvents lblSav0Prc As System.Windows.Forms.Label
    Friend WithEvents lblSav6Prc As System.Windows.Forms.Label
    Friend WithEvents lblSav1Prc As System.Windows.Forms.Label
    Friend WithEvents lblSav5Prc As System.Windows.Forms.Label
    Friend WithEvents lblSav2Prc As System.Windows.Forms.Label
    Friend WithEvents lblSav4Prc As System.Windows.Forms.Label
    Friend WithEvents lblSav3Prc As System.Windows.Forms.Label
    Friend WithEvents lblNicgte As System.Windows.Forms.Label
    Friend WithEvents lblVGgte As System.Windows.Forms.Label
    Friend WithEvents lblPGgte As System.Windows.Forms.Label
    Friend WithEvents lblPGPrc As System.Windows.Forms.Label
    Friend WithEvents lblMl2 As System.Windows.Forms.Label
    Friend WithEvents lblMlTotal As System.Windows.Forms.Label
    Friend WithEvents rdbPGNic As System.Windows.Forms.RadioButton
    Friend WithEvents rdbVGNic As System.Windows.Forms.RadioButton
    Friend WithEvents txtPourcentNic As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMgNic As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMlTotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
