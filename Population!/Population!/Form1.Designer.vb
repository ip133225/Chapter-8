<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Population
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
        Me.btnPredict = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtBoxIncrease = New System.Windows.Forms.TextBox()
        Me.lstPopulation = New System.Windows.Forms.ListBox()
        Me.cboStartingNumber = New System.Windows.Forms.ComboBox()
        Me.cboDaysToMultiply = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnPredict
        '
        Me.btnPredict.Location = New System.Drawing.Point(12, 222)
        Me.btnPredict.Name = "btnPredict"
        Me.btnPredict.Size = New System.Drawing.Size(75, 23)
        Me.btnPredict.TabIndex = 0
        Me.btnPredict.Text = "Predict"
        Me.btnPredict.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(130, 222)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtBoxIncrease
        '
        Me.txtBoxIncrease.Location = New System.Drawing.Point(12, 71)
        Me.txtBoxIncrease.Name = "txtBoxIncrease"
        Me.txtBoxIncrease.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxIncrease.TabIndex = 5
        '
        'lstPopulation
        '
        Me.lstPopulation.FormattingEnabled = True
        Me.lstPopulation.Location = New System.Drawing.Point(152, 12)
        Me.lstPopulation.Name = "lstPopulation"
        Me.lstPopulation.Size = New System.Drawing.Size(160, 199)
        Me.lstPopulation.TabIndex = 8
        '
        'cboStartingNumber
        '
        Me.cboStartingNumber.FormattingEnabled = True
        Me.cboStartingNumber.Location = New System.Drawing.Point(12, 30)
        Me.cboStartingNumber.Name = "cboStartingNumber"
        Me.cboStartingNumber.Size = New System.Drawing.Size(121, 21)
        Me.cboStartingNumber.TabIndex = 9
        '
        'cboDaysToMultiply
        '
        Me.cboDaysToMultiply.FormattingEnabled = True
        Me.cboDaysToMultiply.Location = New System.Drawing.Point(12, 106)
        Me.cboDaysToMultiply.Name = "cboDaysToMultiply"
        Me.cboDaysToMultiply.Size = New System.Drawing.Size(121, 21)
        Me.cboDaysToMultiply.TabIndex = 10
        '
        'Population
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 262)
        Me.Controls.Add(Me.cboDaysToMultiply)
        Me.Controls.Add(Me.cboStartingNumber)
        Me.Controls.Add(Me.lstPopulation)
        Me.Controls.Add(Me.txtBoxIncrease)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPredict)
        Me.Name = "Population"
        Me.Text = "Population"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPredict As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtBoxIncrease As System.Windows.Forms.TextBox
    Friend WithEvents lstPopulation As System.Windows.Forms.ListBox
    Friend WithEvents cboStartingNumber As System.Windows.Forms.ComboBox
    Friend WithEvents cboDaysToMultiply As System.Windows.Forms.ComboBox

End Class
