Public Class frmMain

Public Saveur(7) As Saveurs 'Declaration de l'index des 8 saveurs
Public intMlGoutes As Integer = 30 'Parametre pour determiner le nombre de goutes pour atteindre 1Ml
Public X As Integer 'Compteur
Public BaseLiquide As Base 'Declaration de la base
Dim intNicEnlever As UInt64 'Valeur utiliser pour determiner le % de ml au VG/PG dependament du ml et % Nic

Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click
    MsgBox("Creer par William Morel, 2018", MsgBoxStyle.OkOnly)
End Sub

Private Sub ImprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerToolStripMenuItem.Click
    'Imprimer
    PrintForm1.Print()
End Sub

Private Sub QuitterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem1.Click
    End
End Sub

Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Instance de l'array de classes pour les saveurs et valeurs par defaut
    For Me.X = 0 To 7 Step 1
        Saveur(X) = New Saveurs
        Saveur(X).Nom = ""
        Saveur(X).Pourcent = 0
    Next X
    'Instance pour la base
    BaseLiquide = New Base

    txtPG.Text = 30 'TextBox PG, 30 par defaut
    txtVG.Text = 70 'TextBox VG, 70 par defaut
    txtMgNic.Text = 100 'TextBox Nic mg, 100 par defaut
    txtPourcentNic.Text = 3 'TextBox Nic %, 3 par defaut
    txtMlTotal.Text = 10 'TextBox ml total, 10 par defaut
    rdbVGNic.Checked = True 'Radiobutton VG checked par defaut
    rdbPGNic.Checked = False 'Radiobutton PG pas checked par defaut
    lblVGPrc.Text = txtVG.Text 'Mettre la valeur de txtVG dans lblVGPrc
    lblPGPrc.Text = txtPG.Text 'Mettre la valeur de txtPG dans lblPGPrc
    lstSaveurs.SelectedIndex = 0 'Selectionner le premier element de la liste
End Sub

Private Sub lstSaveurs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSaveurs.SelectedIndexChanged
    'Si le nom et % on ete sauvegarder dans la classe Saveur, ils seront affichers selon l'index de la liste
    If lstSaveurs.SelectedIndex = 0 Then
        txtNomSaveur.Text = Saveur(0).Nom
        txtPourcentSaveur.Text = Saveur(0).Pourcent
    End If
    If lstSaveurs.SelectedIndex = 1 Then
        txtNomSaveur.Text = Saveur(1).Nom
        txtPourcentSaveur.Text = Saveur(1).Pourcent
    End If
    If lstSaveurs.SelectedIndex = 2 Then
        txtNomSaveur.Text = Saveur(2).Nom
        txtPourcentSaveur.Text = Saveur(2).Pourcent
    End If
    If lstSaveurs.SelectedIndex = 3 Then
        txtNomSaveur.Text = Saveur(3).Nom
        txtPourcentSaveur.Text = Saveur(3).Pourcent
    End If
    If lstSaveurs.SelectedIndex = 4 Then
        txtNomSaveur.Text = Saveur(4).Nom
        txtPourcentSaveur.Text = Saveur(4).Pourcent
    End If
    If lstSaveurs.SelectedIndex = 5 Then
        txtNomSaveur.Text = Saveur(5).Nom
        txtPourcentSaveur.Text = Saveur(5).Pourcent
    End If
    If lstSaveurs.SelectedIndex = 6 Then
        txtNomSaveur.Text = Saveur(6).Nom
        txtPourcentSaveur.Text = Saveur(6).Pourcent
    End If
    If lstSaveurs.SelectedIndex = 7 Then
        txtNomSaveur.Text = Saveur(7).Nom
        txtPourcentSaveur.Text = Saveur(7).Pourcent
    End If
End Sub

Private Sub btnConfirmSaveur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmSaveur.Click
    'Sauvegarder le nom et % dans la saveur selectionner, et changer le nom dans la liste
    If lstSaveurs.SelectedIndex = 0 Then
        'Si les textbox contiennent du texte, changer pour la valeur par defaut
        If IsNumeric(txtPourcentSaveur.Text) = False Then
            txtPourcentSaveur.Text = 3
        End If
        Saveur(0).Nom = txtNomSaveur.Text
        Saveur(0).Pourcent = Replace(txtPourcentSaveur.Text, ".", ",") 'Remplacer le point par une virgule
        lstSaveurs.Items(lstSaveurs.SelectedIndex) = txtNomSaveur.Text
        BaseLiquide.CalculPourcentTotal()
    End If
    If lstSaveurs.SelectedIndex = 1 Then
        'Si les textbox contiennent du texte, changer pour la valeur par defaut
        If IsNumeric(txtPourcentSaveur.Text) = False Then
            txtPourcentSaveur.Text = 3
        End If
        Saveur(1).Nom = txtNomSaveur.Text
        Saveur(1).Pourcent = Replace(txtPourcentSaveur.Text, ".", ",") 'Remplacer le point par une virgule
        lstSaveurs.Items(lstSaveurs.SelectedIndex) = txtNomSaveur.Text
        BaseLiquide.CalculPourcentTotal()
    End If
    If lstSaveurs.SelectedIndex = 2 Then
        'Si les textbox contiennent du texte, changer pour la valeur par defaut
        If IsNumeric(txtPourcentSaveur.Text) = False Then
            txtPourcentSaveur.Text = 3
        End If
        Saveur(2).Nom = txtNomSaveur.Text
        Saveur(2).Pourcent = Replace(txtPourcentSaveur.Text, ".", ",") 'Remplacer le point par une virgule
        lstSaveurs.Items(lstSaveurs.SelectedIndex) = txtNomSaveur.Text
        BaseLiquide.CalculPourcentTotal()
    End If
    If lstSaveurs.SelectedIndex = 3 Then
        'Si les textbox contiennent du texte, changer pour la valeur par defaut
        If IsNumeric(txtPourcentSaveur.Text) = False Then
            txtPourcentSaveur.Text = 3
        End If
        Saveur(3).Nom = txtNomSaveur.Text
        Saveur(3).Pourcent = Replace(txtPourcentSaveur.Text, ".", ",") 'Remplacer le point par une virgule
        lstSaveurs.Items(lstSaveurs.SelectedIndex) = txtNomSaveur.Text
        BaseLiquide.CalculPourcentTotal()
    End If
    If lstSaveurs.SelectedIndex = 4 Then
        'Si les textbox contiennent du texte, changer pour la valeur par defaut
        If IsNumeric(txtPourcentSaveur.Text) = False Then
            txtPourcentSaveur.Text = 3
        End If
        Saveur(4).Nom = txtNomSaveur.Text
        Saveur(4).Pourcent = Replace(txtPourcentSaveur.Text, ".", ",") 'Remplacer le point par une virgule
        lstSaveurs.Items(lstSaveurs.SelectedIndex) = txtNomSaveur.Text
        BaseLiquide.CalculPourcentTotal()
    End If
    If lstSaveurs.SelectedIndex = 5 Then
        'Si les textbox contiennent du texte, changer pour la valeur par defaut
        If IsNumeric(txtPourcentSaveur.Text) = False Then
            txtPourcentSaveur.Text = 3
        End If
        Saveur(5).Nom = txtNomSaveur.Text
        Saveur(5).Pourcent = Replace(txtPourcentSaveur.Text, ".", ",") 'Remplacer le point par une virgule
        lstSaveurs.Items(lstSaveurs.SelectedIndex) = txtNomSaveur.Text
        BaseLiquide.CalculPourcentTotal()
    End If
    If lstSaveurs.SelectedIndex = 6 Then
        'Si les textbox contiennent du texte, changer pour la valeur par defaut
        If IsNumeric(txtPourcentSaveur.Text) = False Then
            txtPourcentSaveur.Text = 3
        End If
        Saveur(6).Nom = txtNomSaveur.Text
        Saveur(6).Pourcent = Replace(txtPourcentSaveur.Text, ".", ",") 'Remplacer le point par une virgule
        lstSaveurs.Items(lstSaveurs.SelectedIndex) = txtNomSaveur.Text
        BaseLiquide.CalculPourcentTotal()
    End If
    If lstSaveurs.SelectedIndex = 7 Then
        'Si les textbox contiennent du texte, changer pour la valeur par defaut
        If IsNumeric(txtPourcentSaveur.Text) = False Then
            txtPourcentSaveur.Text = 3
        End If
        Saveur(7).Nom = txtNomSaveur.Text
        Saveur(7).Pourcent = Replace(txtPourcentSaveur.Text, ".", ",") 'Remplacer le point par une virgule
        lstSaveurs.Items(lstSaveurs.SelectedIndex) = txtNomSaveur.Text
        BaseLiquide.CalculPourcentTotal()
    End If
End Sub

Private Sub tmrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
    'Si les textbox contiennent du texte, changer pour la valeur par defaut
    If IsNumeric(txtVG.Text) = False Then
        txtVG.Text = 70 'Remettre la valeur a defaut si une valeur non-numerique est dans le textbox
    End If
    'Mets a jour les noms de saveurs dans le tableau
    lblSaveur0.Text = Saveur(0).Nom
    lblSaveur1.Text = Saveur(1).Nom
    lblSaveur2.Text = Saveur(2).Nom
    lblSaveur3.Text = Saveur(3).Nom
    lblSaveur4.Text = Saveur(4).Nom
    lblSaveur5.Text = Saveur(5).Nom
    lblSaveur6.Text = Saveur(6).Nom
    lblSaveur7.Text = Saveur(7).Nom
    'Mets a jour les pourcentages dans le tableau
    lblSav0Prc.Text = Saveur(0).Pourcent
    lblSav1Prc.Text = Saveur(1).Pourcent
    lblSav2Prc.Text = Saveur(2).Pourcent
    lblSav3Prc.Text = Saveur(3).Pourcent
    lblSav4Prc.Text = Saveur(4).Pourcent
    lblSav5Prc.Text = Saveur(5).Pourcent
    lblSav6Prc.Text = Saveur(6).Pourcent
    lblSav7Prc.Text = Saveur(7).Pourcent
    lblNicPrc.Text = txtPourcentNic.Text
    'Retourne le pourcentage de tout les saveurs combiner
    BaseLiquide.sngPourcentSaveur = BaseLiquide.CalculPourcentTotal()
    'Mets a jours les millilitres dans le tableau
    lblSav0ml.Text = (BaseLiquide.intMlTotal / 100) * Saveur(0).Pourcent
    lblSav1ml.Text = (BaseLiquide.intMlTotal / 100) * Saveur(1).Pourcent
    lblSav2ml.Text = (BaseLiquide.intMlTotal / 100) * Saveur(2).Pourcent
    lblSav3ml.Text = (BaseLiquide.intMlTotal / 100) * Saveur(3).Pourcent
    lblSav4ml.Text = (BaseLiquide.intMlTotal / 100) * Saveur(4).Pourcent
    lblSav5ml.Text = (BaseLiquide.intMlTotal / 100) * Saveur(5).Pourcent
    lblSav6ml.Text = (BaseLiquide.intMlTotal / 100) * Saveur(6).Pourcent
    lblSav7ml.Text = (BaseLiquide.intMlTotal / 100) * Saveur(7).Pourcent
    lblVGml.Text = (BaseLiquide.intMlTotal / 100) * BaseLiquide.intVGNic
    lblPGml.Text = (BaseLiquide.intMlTotal / 100) * BaseLiquide.intPGNic
    'Sauvegarder les ml des saveurs
    Saveur(0).Ml = lblSav0ml.Text
    Saveur(1).Ml = lblSav1ml.Text
    Saveur(2).Ml = lblSav2ml.Text
    Saveur(3).Ml = lblSav3ml.Text
    Saveur(4).Ml = lblSav4ml.Text
    Saveur(5).Ml = lblSav5ml.Text
    Saveur(6).Ml = lblSav6ml.Text
    Saveur(7).Ml = lblSav7ml.Text
    'Sauvegarder les % VG/PG
    BaseLiquide.intVGPourcent = txtVG.Text
    BaseLiquide.intPGPourcent = txtPG.Text
    'Calcul pour determiner le nombre de % a enlever au VG/PG (Plus le ml et gouttes de Nic)
    Try 'Si ce bloc de code encontre une exception (souvent a cause qu'un textbox de la base est vide), ne pas l'executer
        'Si tout les textbox de la base sont plus que 0 et ne sont pas vides
        If txtMgNic.Text > 0 And txtMlTotal.Text > 0 And txtPourcentNic.Text > 0 And txtMgNic.Text <> "" And txtPourcentNic.Text <> "" And txtMlTotal.Text <> "" Then
            'Assignation des valeurs a la classe Base
            BaseLiquide.intMlTotal = txtMlTotal.Text
            BaseLiquide.intNicPourcent = txtPourcentNic.Text
            BaseLiquide.intNicMg = txtMgNic.Text
            intNicEnlever = BaseLiquide.CalculNicEnlever()
            'Si le radiobutton VG est checked
            If rdbVGNic.Checked = True Then
                'Si lblPGPrc.Text est plus que 0
                If Convert.ToSingle(lblPGPrc.Text) > 0 Then
                    'Enelever la quantiter de Nic selon son mg et %
                    lblPGPrc.Text = BaseLiquide.intPGPourcent - BaseLiquide.sngPourcentSaveur
                    lblVGPrc.Text = BaseLiquide.intVGPourcent - intNicEnlever
                    lblNicml.Text = BaseLiquide.CalculNicml()
                    lblNicgte.Text = Convert.ToInt32(BaseLiquide.CalculNicml() * intMlGoutes)
                'Si lblPGPrc.Text est moins que 0
                ElseIf Convert.ToSingle(lblPGPrc.Text) <= 0 Then
                    'Enelever la quantiter de Nic selon son mg et %
                    lblPGPrc.Text = 0
                    lblVGPrc.Text = 100 - BaseLiquide.sngPourcentSaveur - intNicEnlever
                    lblNicml.Text = BaseLiquide.CalculNicml()
                    lblNicgte.Text = Convert.ToInt32(BaseLiquide.CalculNicml() * intMlGoutes)
                End If
            'Si le radiobutton PG est checked
            ElseIf rdbPGNic.Checked = True Then
                'Si lblPGPrc.Text est plus que 0
                If Convert.ToInt32(lblPGPrc.Text) > 0 Then
                    'Enelever la quantiter de Nic selon son mg et %
                    lblPGPrc.Text = BaseLiquide.intPGPourcent - BaseLiquide.sngPourcentSaveur - intNicEnlever
                    lblVGPrc.Text = BaseLiquide.intVGPourcent
                    lblNicml.Text = BaseLiquide.CalculNicml()
                    lblNicgte.Text = Convert.ToInt32(BaseLiquide.CalculNicml() * intMlGoutes)
                End If
                'Si lblPGPrc.Text est moins que 0
                If Convert.ToInt32(lblPGPrc.Text) < 0 Then
                    'Enelever la quantiter de Nic selon son mg et %
                    lblPGPrc.Text = 0
                    lblVGPrc.Text = 100 - BaseLiquide.sngPourcentSaveur - intNicEnlever
                    lblNicml.Text = BaseLiquide.CalculNicml()
                    lblNicgte.Text = Convert.ToInt32(BaseLiquide.CalculNicml() * intMlGoutes)
                End If
            End If
        End If
    Catch ex As Exception
    End Try

    'Nombres de goutes: ((% * ml total) / 100) * goutes
    BaseLiquide.intVGNic = lblVGPrc.Text
    BaseLiquide.intPGNic = lblPGPrc.Text
    lblVGgte.Text = ((BaseLiquide.intVGNic * BaseLiquide.intMlTotal) / 100) * intMlGoutes
    lblPGgte.Text = ((BaseLiquide.intPGNic * BaseLiquide.intMlTotal) / 100) * intMlGoutes

    'Si la saveur contient un pourcentage, afficher son pourcentage
    If Saveur(0).Ml > 0 Then
        lblSav0gte.Text = Saveur(0).Ml * intMlGoutes
    End If
    If Saveur(1).Ml > 0 Then
        lblSav1gte.Text = Saveur(1).Ml * intMlGoutes
    End If
    If Saveur(2).Ml > 0 Then
        lblSav2gte.Text = Saveur(2).Ml * intMlGoutes
    End If
    If Saveur(3).Ml > 0 Then
        lblSav3gte.Text = Saveur(3).Ml * intMlGoutes
    End If
    If Saveur(4).Ml > 0 Then
        lblSav4gte.Text = Saveur(4).Ml * intMlGoutes
    End If
    If Saveur(5).Ml > 0 Then
        lblSav5gte.Text = Saveur(5).Ml * intMlGoutes
    End If
    If Saveur(6).Ml > 0 Then
        lblSav6gte.Text = Saveur(6).Ml * intMlGoutes
    End If
    If Saveur(7).Ml > 0 Then
        lblSav7gte.Text = Saveur(7).Ml * intMlGoutes
    End If

    'Si le textbox VG est plus grand que 100, le mettre a 100
    If BaseLiquide.intVGPourcent > 100 Then
        txtVG.Text = 100
    'Si le textbox VG est plus petit que 0, le mettre a 0
    ElseIf BaseLiquide.intVGPourcent < 0 Then
        txtVG.Text = 0
    End If
    ToolTip1.SetToolTip(txtVG, "Taux de VG dans la base")
    ToolTip1.SetToolTip(txtPG, "Taux de PG dans la base")
    ToolTip1.SetToolTip(txtMgNic, "Taux de nicotine dans la base de nicotine")
    ToolTip1.SetToolTip(txtPourcentNic, "Taux de Mg/Ml de nicotine")
    ToolTip1.SetToolTip(rdbVGNic, "Base de nicotine en VG")
    ToolTip1.SetToolTip(rdbPGNic, "Base de nicotine en PG")
    ToolTip1.SetToolTip(txtNomSaveur, "Nom de la saveur")
    ToolTip1.SetToolTip(txtPourcentSaveur, "Pourcent de saveur")
    ToolTip1.SetToolTip(txtMlTotal, "Quantiter finale totale")
End Sub

Private Sub txtVG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVG.TextChanged
    'Balancer le VG/PG pour que le tout soit egal a 100
    If IsNumeric(txtVG.Text) = True Then
        Int32.TryParse(txtVG.Text, BaseLiquide.intVGPourcent)
        If BaseLiquide.intVGPourcent <= 100 Or BaseLiquide.intVGPourcent >= 0 Then
            BaseLiquide.intPGPourcent = 100 - BaseLiquide.intVGPourcent
            txtPG.Text = BaseLiquide.intPGPourcent
        End If
    End If

End Sub

Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup
        'ToolTip1.SetToolTip(txtVG, "ton text")
        'ToolTip1.SetToolTip(txtPG, "ton text")
End Sub
End Class

'Definition de la classe Saveurs, qui servirat a entreposer toute les donnees relatives a chaque saveur
Public Class Saveurs
    Public Nom As String 'Nom de la saveur
    Public Pourcent As Single 'Pourcentage de la saveur
    Public Ml As Single 'Ml de la saveur
End Class
'Definition de la classe Base, qui servirat a entreposer toute les donnees relatives a la base du liquide
Public Class Base
    Public intVGPourcent As Integer 'Pourcent de VG selon txtVG
    Public intPGPourcent As Integer 'Pourcent de PG selon txtPG
    Public intVGNic As Integer 'Pourcent de VG apres avoir enlever le Nic
    Public intPGNic As Integer 'Pourcent de PG apres avoir enlever le Nic
    Public sngVGml As Single 'Ml de VG
    Public sngPGml As Single 'Ml de PG
    Public intNicMg As Integer 'Mg de Nic
    Public intNicPourcent As Integer 'Pourcents de Nic
    Public intMlTotal As Integer 'Quantiter totale de ml
    Public sngPourcentSaveur As Single 'Pourcents total de saveur
    'Calcul le pourcent de saveur total
    Function CalculPourcentTotal() As Single
        Dim resultat As Single = 0
        For frmMain.X = 0 To 7 Step 1
            resultat += frmMain.Saveur(frmMain.X).Pourcent
        Next
        Return resultat
    End Function
    'Calcul des ml de nic selon le mg, pourcent et ml total
    Function CalculNicml() As Single
        Dim resultat As Single = 0
        'Si tout les textbox de la base sont plus que 0 et ne sont pas vides
        If frmMain.txtMgNic.Text > 0 And frmMain.txtMlTotal.Text > 0 And frmMain.txtPourcentNic.Text > 0 And frmMain.txtMgNic.Text <> "" And frmMain.txtPourcentNic.Text <> "" And frmMain.txtMlTotal.Text <> "" Then
            resultat = intNicPourcent / intNicMg
            resultat = resultat * intMlTotal
            Return resultat
        Else
            Return resultat
        End If
    End Function
    'Calcul le nombre de pourcents a enlever selon le mg et pourcent
    Function CalculNicEnlever() As Integer
        Dim resultat As Integer = 0
        'Si tout les textbox de la base sont plus que 0 et ne sont pas vides
        If frmMain.txtMgNic.Text > 0 And frmMain.txtMlTotal.Text > 0 And frmMain.txtPourcentNic.Text > 0 And frmMain.txtMgNic.Text <> "" And frmMain.txtPourcentNic.Text <> "" And frmMain.txtMlTotal.Text <> "" Then
            resultat = ((CalculNicml() * 100) / intMlTotal)
            Return resultat
        Else
            Return resultat
        End If
    End Function
End Class
