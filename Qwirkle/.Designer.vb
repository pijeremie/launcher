<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frPagemenu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frPagemenu))
        Me.boutonInformations = New System.Windows.Forms.Button()
        Me.boutonAppli = New System.Windows.Forms.Button()
        Me.quitter = New System.Windows.Forms.Button()
        Me.boutonExplications = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boutonInformations
        '
        Me.boutonInformations.BackColor = System.Drawing.Color.Purple
        Me.boutonInformations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.boutonInformations.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boutonInformations.Location = New System.Drawing.Point(36, 42)
        Me.boutonInformations.Margin = New System.Windows.Forms.Padding(4)
        Me.boutonInformations.Name = "boutonInformations"
        Me.boutonInformations.Size = New System.Drawing.Size(178, 57)
        Me.boutonInformations.TabIndex = 1
        Me.boutonInformations.Text = "Informations"
        Me.boutonInformations.UseVisualStyleBackColor = False
        '
        'boutonAppli
        '
        Me.boutonAppli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boutonAppli.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.boutonAppli.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.boutonAppli.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boutonAppli.Location = New System.Drawing.Point(387, 390)
        Me.boutonAppli.Margin = New System.Windows.Forms.Padding(4)
        Me.boutonAppli.Name = "boutonAppli"
        Me.boutonAppli.Size = New System.Drawing.Size(312, 139)
        Me.boutonAppli.TabIndex = 3
        Me.boutonAppli.Text = "Explications de l'application"
        Me.boutonAppli.UseVisualStyleBackColor = False
        '
        'quitter
        '
        Me.quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.quitter.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.quitter.Location = New System.Drawing.Point(982, 42)
        Me.quitter.Margin = New System.Windows.Forms.Padding(4)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(60, 55)
        Me.quitter.TabIndex = 4
        Me.quitter.Text = "X"
        Me.quitter.UseVisualStyleBackColor = False
        '
        'boutonExplications
        '
        Me.boutonExplications.BackColor = System.Drawing.Color.Brown
        Me.boutonExplications.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.boutonExplications.ForeColor = System.Drawing.SystemColors.Control
        Me.boutonExplications.Location = New System.Drawing.Point(715, 390)
        Me.boutonExplications.Margin = New System.Windows.Forms.Padding(4)
        Me.boutonExplications.Name = "boutonExplications"
        Me.boutonExplications.Size = New System.Drawing.Size(308, 139)
        Me.boutonExplications.TabIndex = 2
        Me.boutonExplications.Text = "Comprendre la Trisomie 21"
        Me.boutonExplications.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(222, 52)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(726, 307)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(61, 390)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(312, 139)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Accéder à notre application"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frPagemenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 553)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.quitter)
        Me.Controls.Add(Me.boutonAppli)
        Me.Controls.Add(Me.boutonExplications)
        Me.Controls.Add(Me.boutonInformations)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frPagemenu"
        Me.Text = "HumanityPlanner"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents boutonInformations As Button
    Friend WithEvents boutonAppli As Button
    Friend WithEvents quitter As Button
    Friend WithEvents boutonExplications As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
