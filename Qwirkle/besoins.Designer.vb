<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class besoins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(besoins))
        Me.Retour = New System.Windows.Forms.Button()
        Me.cmdMenu = New System.Windows.Forms.Button()
        Me.quitter = New System.Windows.Forms.Button()
        Me.nbjoueur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Retour
        '
        Me.Retour.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Retour.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Retour.Location = New System.Drawing.Point(33, 31)
        Me.Retour.Margin = New System.Windows.Forms.Padding(4)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(103, 41)
        Me.Retour.TabIndex = 32
        Me.Retour.Text = "<"
        Me.Retour.UseVisualStyleBackColor = False
        '
        'cmdMenu
        '
        Me.cmdMenu.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmdMenu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdMenu.Location = New System.Drawing.Point(33, 80)
        Me.cmdMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMenu.Name = "cmdMenu"
        Me.cmdMenu.Size = New System.Drawing.Size(103, 41)
        Me.cmdMenu.TabIndex = 31
        Me.cmdMenu.Text = "Menu"
        Me.cmdMenu.UseVisualStyleBackColor = False
        '
        'quitter
        '
        Me.quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.quitter.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.quitter.Location = New System.Drawing.Point(985, 24)
        Me.quitter.Margin = New System.Windows.Forms.Padding(4)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(60, 55)
        Me.quitter.TabIndex = 30
        Me.quitter.Text = "X"
        Me.quitter.UseVisualStyleBackColor = False
        '
        'nbjoueur
        '
        Me.nbjoueur.AutoSize = True
        Me.nbjoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.nbjoueur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nbjoueur.Location = New System.Drawing.Point(41, 198)
        Me.nbjoueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nbjoueur.Name = "nbjoueur"
        Me.nbjoueur.Size = New System.Drawing.Size(484, 26)
        Me.nbjoueur.TabIndex = 33
        Me.nbjoueur.Text = "Besoins de la personne en milieu de travail :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(51, 235)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(950, 26)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "- Accompagnement sur mesure et durable d’accès à l’emploi et de maintien de l’emp" &
    "loi, "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(51, 270)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 26)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "- Définition du poste, "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(51, 455)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(574, 26)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "- L’incitation de la personne à prendre des initiatives."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(51, 418)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(405, 26)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "- L’accompagnement de la personne,"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(51, 381)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(923, 26)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "- L’anticipation et la résolution des difficultés qu'elle peut rencontrer dans sa" &
    " mission, "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(51, 343)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(654, 26)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "- L’adaptation aux codes de fonctionnement de l’entreprise,  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(51, 306)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(364, 26)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "- L’accueil par l’équipe salariée,  "
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(373, 24)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(342, 142)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'besoins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 553)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nbjoueur)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.cmdMenu)
        Me.Controls.Add(Me.quitter)
        Me.Name = "besoins"
        Me.Text = "HumanityPlanner"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Retour As Button
    Friend WithEvents cmdMenu As Button
    Friend WithEvents quitter As Button
    Friend WithEvents nbjoueur As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
