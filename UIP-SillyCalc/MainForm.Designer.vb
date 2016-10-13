<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InputGroup = New System.Windows.Forms.GroupBox()
        Me.TextBoxB = New System.Windows.Forms.TextBox()
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.LabelB = New System.Windows.Forms.Label()
        Me.LabelA = New System.Windows.Forms.Label()
        Me.OutputGroup = New System.Windows.Forms.GroupBox()
        Me.OutputPanel = New System.Windows.Forms.Panel()
        Me.TextBoxMod = New System.Windows.Forms.TextBox()
        Me.TextBoxDiv = New System.Windows.Forms.TextBox()
        Me.TextBoxRDiv = New System.Windows.Forms.TextBox()
        Me.TextBoxMul = New System.Windows.Forms.TextBox()
        Me.TextBoxSub = New System.Windows.Forms.TextBox()
        Me.TextBoxAdd = New System.Windows.Forms.TextBox()
        Me.LabelMod = New System.Windows.Forms.Label()
        Me.LabelDiv = New System.Windows.Forms.Label()
        Me.LabelRealDiv = New System.Windows.Forms.Label()
        Me.LabelMulti = New System.Windows.Forms.Label()
        Me.LabelDiff = New System.Windows.Forms.Label()
        Me.LabelAggr = New System.Windows.Forms.Label()
        Me.LabelCopyRight = New System.Windows.Forms.Label()
        Me.InputGroup.SuspendLayout()
        Me.OutputGroup.SuspendLayout()
        Me.OutputPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputGroup
        '
        Me.InputGroup.Controls.Add(Me.TextBoxB)
        Me.InputGroup.Controls.Add(Me.TextBoxA)
        Me.InputGroup.Controls.Add(Me.LabelB)
        Me.InputGroup.Controls.Add(Me.LabelA)
        Me.InputGroup.Location = New System.Drawing.Point(14, 30)
        Me.InputGroup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputGroup.Name = "InputGroup"
        Me.InputGroup.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputGroup.Size = New System.Drawing.Size(303, 135)
        Me.InputGroup.TabIndex = 0
        Me.InputGroup.TabStop = False
        Me.InputGroup.Text = "Datos"
        '
        'TextBoxB
        '
        Me.TextBoxB.Location = New System.Drawing.Point(101, 76)
        Me.TextBoxB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxB.Name = "TextBoxB"
        Me.TextBoxB.Size = New System.Drawing.Size(171, 25)
        Me.TextBoxB.TabIndex = 3
        '
        'TextBoxA
        '
        Me.TextBoxA.Location = New System.Drawing.Point(101, 33)
        Me.TextBoxA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(171, 25)
        Me.TextBoxA.TabIndex = 2
        '
        'LabelB
        '
        Me.LabelB.AutoSize = True
        Me.LabelB.Location = New System.Drawing.Point(31, 81)
        Me.LabelB.Name = "LabelB"
        Me.LabelB.Size = New System.Drawing.Size(67, 17)
        Me.LabelB.TabIndex = 1
        Me.LabelB.Text = "Numero B"
        '
        'LabelA
        '
        Me.LabelA.AutoSize = True
        Me.LabelA.Location = New System.Drawing.Point(31, 38)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(68, 17)
        Me.LabelA.TabIndex = 0
        Me.LabelA.Text = "Numero A"
        '
        'OutputGroup
        '
        Me.OutputGroup.Controls.Add(Me.OutputPanel)
        Me.OutputGroup.Location = New System.Drawing.Point(14, 185)
        Me.OutputGroup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OutputGroup.Name = "OutputGroup"
        Me.OutputGroup.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OutputGroup.Size = New System.Drawing.Size(303, 250)
        Me.OutputGroup.TabIndex = 5
        Me.OutputGroup.TabStop = False
        Me.OutputGroup.Text = "Resultados"
        '
        'OutputPanel
        '
        Me.OutputPanel.AutoScroll = True
        Me.OutputPanel.Controls.Add(Me.TextBoxMod)
        Me.OutputPanel.Controls.Add(Me.TextBoxDiv)
        Me.OutputPanel.Controls.Add(Me.TextBoxRDiv)
        Me.OutputPanel.Controls.Add(Me.TextBoxMul)
        Me.OutputPanel.Controls.Add(Me.TextBoxSub)
        Me.OutputPanel.Controls.Add(Me.TextBoxAdd)
        Me.OutputPanel.Controls.Add(Me.LabelMod)
        Me.OutputPanel.Controls.Add(Me.LabelDiv)
        Me.OutputPanel.Controls.Add(Me.LabelRealDiv)
        Me.OutputPanel.Controls.Add(Me.LabelMulti)
        Me.OutputPanel.Controls.Add(Me.LabelDiff)
        Me.OutputPanel.Controls.Add(Me.LabelAggr)
        Me.OutputPanel.Location = New System.Drawing.Point(7, 27)
        Me.OutputPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OutputPanel.Name = "OutputPanel"
        Me.OutputPanel.Padding = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.OutputPanel.Size = New System.Drawing.Size(289, 196)
        Me.OutputPanel.TabIndex = 7
        '
        'TextBoxMod
        '
        Me.TextBoxMod.Location = New System.Drawing.Point(117, 163)
        Me.TextBoxMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxMod.Name = "TextBoxMod"
        Me.TextBoxMod.ReadOnly = True
        Me.TextBoxMod.Size = New System.Drawing.Size(149, 25)
        Me.TextBoxMod.TabIndex = 11
        '
        'TextBoxDiv
        '
        Me.TextBoxDiv.Location = New System.Drawing.Point(117, 132)
        Me.TextBoxDiv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDiv.Name = "TextBoxDiv"
        Me.TextBoxDiv.ReadOnly = True
        Me.TextBoxDiv.Size = New System.Drawing.Size(149, 25)
        Me.TextBoxDiv.TabIndex = 10
        '
        'TextBoxRDiv
        '
        Me.TextBoxRDiv.Location = New System.Drawing.Point(117, 101)
        Me.TextBoxRDiv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxRDiv.Name = "TextBoxRDiv"
        Me.TextBoxRDiv.ReadOnly = True
        Me.TextBoxRDiv.Size = New System.Drawing.Size(149, 25)
        Me.TextBoxRDiv.TabIndex = 9
        '
        'TextBoxMul
        '
        Me.TextBoxMul.Location = New System.Drawing.Point(117, 69)
        Me.TextBoxMul.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxMul.Name = "TextBoxMul"
        Me.TextBoxMul.ReadOnly = True
        Me.TextBoxMul.Size = New System.Drawing.Size(149, 25)
        Me.TextBoxMul.TabIndex = 8
        '
        'TextBoxSub
        '
        Me.TextBoxSub.Location = New System.Drawing.Point(117, 38)
        Me.TextBoxSub.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxSub.Name = "TextBoxSub"
        Me.TextBoxSub.ReadOnly = True
        Me.TextBoxSub.Size = New System.Drawing.Size(149, 25)
        Me.TextBoxSub.TabIndex = 7
        '
        'TextBoxAdd
        '
        Me.TextBoxAdd.Location = New System.Drawing.Point(117, 7)
        Me.TextBoxAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxAdd.Name = "TextBoxAdd"
        Me.TextBoxAdd.ReadOnly = True
        Me.TextBoxAdd.Size = New System.Drawing.Size(149, 25)
        Me.TextBoxAdd.TabIndex = 6
        '
        'LabelMod
        '
        Me.LabelMod.AutoSize = True
        Me.LabelMod.Location = New System.Drawing.Point(24, 169)
        Me.LabelMod.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.LabelMod.Name = "LabelMod"
        Me.LabelMod.Size = New System.Drawing.Size(55, 17)
        Me.LabelMod.TabIndex = 5
        Me.LabelMod.Text = "Residuo"
        '
        'LabelDiv
        '
        Me.LabelDiv.AutoSize = True
        Me.LabelDiv.Location = New System.Drawing.Point(24, 137)
        Me.LabelDiv.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.LabelDiv.Name = "LabelDiv"
        Me.LabelDiv.Size = New System.Drawing.Size(53, 17)
        Me.LabelDiv.TabIndex = 4
        Me.LabelDiv.Text = "Division"
        '
        'LabelRealDiv
        '
        Me.LabelRealDiv.AutoSize = True
        Me.LabelRealDiv.Location = New System.Drawing.Point(24, 106)
        Me.LabelRealDiv.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.LabelRealDiv.Name = "LabelRealDiv"
        Me.LabelRealDiv.Size = New System.Drawing.Size(82, 17)
        Me.LabelRealDiv.TabIndex = 3
        Me.LabelRealDiv.Text = "Division Real"
        '
        'LabelMulti
        '
        Me.LabelMulti.AutoSize = True
        Me.LabelMulti.Location = New System.Drawing.Point(24, 75)
        Me.LabelMulti.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.LabelMulti.Name = "LabelMulti"
        Me.LabelMulti.Size = New System.Drawing.Size(88, 17)
        Me.LabelMulti.TabIndex = 2
        Me.LabelMulti.Text = "Multiplicacion"
        '
        'LabelDiff
        '
        Me.LabelDiff.AutoSize = True
        Me.LabelDiff.Location = New System.Drawing.Point(24, 43)
        Me.LabelDiff.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.LabelDiff.Name = "LabelDiff"
        Me.LabelDiff.Size = New System.Drawing.Size(40, 17)
        Me.LabelDiff.TabIndex = 1
        Me.LabelDiff.Text = "Resta"
        '
        'LabelAggr
        '
        Me.LabelAggr.AutoSize = True
        Me.LabelAggr.Location = New System.Drawing.Point(24, 12)
        Me.LabelAggr.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.LabelAggr.Name = "LabelAggr"
        Me.LabelAggr.Size = New System.Drawing.Size(40, 17)
        Me.LabelAggr.TabIndex = 0
        Me.LabelAggr.Text = "Suma"
        '
        'LabelCopyRight
        '
        Me.LabelCopyRight.AutoSize = True
        Me.LabelCopyRight.Location = New System.Drawing.Point(128, 458)
        Me.LabelCopyRight.Name = "LabelCopyRight"
        Me.LabelCopyRight.Size = New System.Drawing.Size(78, 17)
        Me.LabelCopyRight.TabIndex = 6
        Me.LabelCopyRight.Text = "©2016  MIT"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 486)
        Me.Controls.Add(Me.LabelCopyRight)
        Me.Controls.Add(Me.OutputGroup)
        Me.Controls.Add(Me.InputGroup)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "UIP-SillyCalc"
        Me.InputGroup.ResumeLayout(False)
        Me.InputGroup.PerformLayout()
        Me.OutputGroup.ResumeLayout(False)
        Me.OutputPanel.ResumeLayout(False)
        Me.OutputPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputGroup As GroupBox
    Friend WithEvents TextBoxA As TextBox
    Friend WithEvents LabelB As Label
    Friend WithEvents LabelA As Label
    Friend WithEvents TextBoxB As TextBox
    Friend WithEvents OutputGroup As GroupBox
    Friend WithEvents OutputPanel As Panel
    Friend WithEvents LabelMod As Label
    Friend WithEvents LabelDiv As Label
    Friend WithEvents LabelRealDiv As Label
    Friend WithEvents LabelMulti As Label
    Friend WithEvents LabelDiff As Label
    Friend WithEvents LabelAggr As Label
    Friend WithEvents TextBoxMod As TextBox
    Friend WithEvents TextBoxDiv As TextBox
    Friend WithEvents TextBoxRDiv As TextBox
    Friend WithEvents TextBoxMul As TextBox
    Friend WithEvents TextBoxSub As TextBox
    Friend WithEvents TextBoxAdd As TextBox
    Friend WithEvents LabelCopyRight As Label
End Class
