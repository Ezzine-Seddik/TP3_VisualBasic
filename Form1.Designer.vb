<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CMB = New ComboBox()
        RB1 = New RadioButton()
        RB2 = New RadioButton()
        RB3 = New RadioButton()
        CB1 = New CheckBox()
        CB4 = New CheckBox()
        CB3 = New CheckBox()
        CB2 = New CheckBox()
        BTN = New Button()
        LB1 = New Label()
        LBL2 = New Label()
        SuspendLayout()
        ' 
        ' CMB
        ' 
        CMB.FormattingEnabled = True
        CMB.Items.AddRange(New Object() {"Petite", "Moyenne", "Grande"})
        CMB.Location = New Point(251, 30)
        CMB.Name = "CMB"
        CMB.Size = New Size(151, 28)
        CMB.TabIndex = 0
        ' 
        ' RB1
        ' 
        RB1.AutoSize = True
        RB1.Location = New Point(52, 88)
        RB1.Name = "RB1"
        RB1.Size = New Size(103, 24)
        RB1.TabIndex = 1
        RB1.TabStop = True
        RB1.Text = "Croute fine"
        RB1.UseVisualStyleBackColor = True
        ' 
        ' RB2
        ' 
        RB2.AutoSize = True
        RB2.Location = New Point(52, 144)
        RB2.Name = "RB2"
        RB2.Size = New Size(140, 24)
        RB2.TabIndex = 3
        RB2.TabStop = True
        RB2.Text = "Croute Classique"
        RB2.UseVisualStyleBackColor = True
        ' 
        ' RB3
        ' 
        RB3.AutoSize = True
        RB3.Location = New Point(52, 201)
        RB3.Name = "RB3"
        RB3.Size = New Size(127, 24)
        RB3.TabIndex = 4
        RB3.TabStop = True
        RB3.Text = "Croute epaisse"
        RB3.UseVisualStyleBackColor = True
        ' 
        ' CB1
        ' 
        CB1.AutoSize = True
        CB1.Location = New Point(382, 89)
        CB1.Name = "CB1"
        CB1.Size = New Size(122, 24)
        CB1.TabIndex = 5
        CB1.Text = "Champignons"
        CB1.UseVisualStyleBackColor = True
        ' 
        ' CB4
        ' 
        CB4.AutoSize = True
        CB4.Location = New Point(382, 265)
        CB4.Name = "CB4"
        CB4.Size = New Size(197, 24)
        CB4.TabIndex = 6
        CB4.Text = "Fromage supplémentaire"
        CB4.UseVisualStyleBackColor = True
        ' 
        ' CB3
        ' 
        CB3.AutoSize = True
        CB3.Location = New Point(382, 202)
        CB3.Name = "CB3"
        CB3.Size = New Size(86, 24)
        CB3.TabIndex = 7
        CB3.Text = "Poivrons"
        CB3.UseVisualStyleBackColor = True
        ' 
        ' CB2
        ' 
        CB2.AutoSize = True
        CB2.Location = New Point(382, 144)
        CB2.Name = "CB2"
        CB2.Size = New Size(71, 24)
        CB2.TabIndex = 8
        CB2.Text = "Olives"
        CB2.UseVisualStyleBackColor = True
        ' 
        ' BTN
        ' 
        BTN.Location = New Point(12, 334)
        BTN.Name = "BTN"
        BTN.Size = New Size(163, 29)
        BTN.TabIndex = 9
        BTN.Text = "Valider Commande"
        BTN.UseVisualStyleBackColor = True
        ' 
        ' LB1
        ' 
        LB1.AutoSize = True
        LB1.Location = New Point(52, 33)
        LB1.Name = "LB1"
        LB1.Size = New Size(160, 20)
        LB1.TabIndex = 10
        LB1.Text = "Coisir la Taille de pizza"
        ' 
        ' LBL2
        ' 
        LBL2.AutoSize = True
        LBL2.Location = New Point(212, 333)
        LBL2.MinimumSize = New Size(100, 30)
        LBL2.Name = "LBL2"
        LBL2.Size = New Size(100, 30)
        LBL2.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LBL2)
        Controls.Add(LB1)
        Controls.Add(BTN)
        Controls.Add(CB2)
        Controls.Add(CB3)
        Controls.Add(CB4)
        Controls.Add(CB1)
        Controls.Add(RB3)
        Controls.Add(RB2)
        Controls.Add(RB1)
        Controls.Add(CMB)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CMB As ComboBox
    Friend WithEvents RB1 As RadioButton
    Friend WithEvents RB2 As RadioButton
    Friend WithEvents RB3 As RadioButton
    Friend WithEvents CB1 As CheckBox
    Friend WithEvents CB4 As CheckBox
    Friend WithEvents CB3 As CheckBox
    Friend WithEvents CB2 As CheckBox
    Friend WithEvents BTN As Button
    Friend WithEvents LB1 As Label
    Friend WithEvents LBL2 As Label

End Class
