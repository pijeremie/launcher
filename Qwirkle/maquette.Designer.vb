<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maquette
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maquette))
        Me.cmdMenu = New System.Windows.Forms.Button()
        Me.quitter = New System.Windows.Forms.Button()
        Me.Retour = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdMenu
        '
        Me.cmdMenu.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmdMenu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdMenu.Location = New System.Drawing.Point(19, 85)
        Me.cmdMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMenu.Name = "cmdMenu"
        Me.cmdMenu.Size = New System.Drawing.Size(103, 41)
        Me.cmdMenu.TabIndex = 27
        Me.cmdMenu.Text = "Menu"
        Me.cmdMenu.UseVisualStyleBackColor = False
        '
        'quitter
        '
        Me.quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.quitter.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.quitter.Location = New System.Drawing.Point(980, 29)
        Me.quitter.Margin = New System.Windows.Forms.Padding(4)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(60, 55)
        Me.quitter.TabIndex = 26
        Me.quitter.Text = "X"
        Me.quitter.UseVisualStyleBackColor = False
        '
        'Retour
        '
        Me.Retour.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Retour.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Retour.Location = New System.Drawing.Point(19, 36)
        Me.Retour.Margin = New System.Windows.Forms.Padding(4)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(103, 41)
        Me.Retour.TabIndex = 29
        Me.Retour.Text = "<"
        Me.Retour.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(170, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(755, 512)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'maquette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 553)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.cmdMenu)
        Me.Controls.Add(Me.quitter)
        Me.Name = "maquette"
        Me.Text = "HumanityPlanner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdMenu As Button
    Friend WithEvents quitter As Button
    Friend WithEvents Retour As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
