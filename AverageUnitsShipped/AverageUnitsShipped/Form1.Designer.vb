<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtInputDisplay = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttAverageUnitsToolTp = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(101, 47)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(39, 23)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDay
        '
        Me.lblDay.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.lblDay.Location = New System.Drawing.Point(252, 52)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(65, 23)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day 1"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(146, 50)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        Me.ttAverageUnitsToolTp.SetToolTip(Me.txtInput, "Input the units shipped for the current day")
        '
        'txtInputDisplay
        '
        Me.txtInputDisplay.Location = New System.Drawing.Point(101, 73)
        Me.txtInputDisplay.Multiline = True
        Me.txtInputDisplay.Name = "txtInputDisplay"
        Me.txtInputDisplay.ReadOnly = True
        Me.txtInputDisplay.Size = New System.Drawing.Size(216, 200)
        Me.txtInputDisplay.TabIndex = 3
        Me.txtInputDisplay.TabStop = False
        Me.ttAverageUnitsToolTp.SetToolTip(Me.txtInputDisplay, "Displays units shipped for each day")
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(101, 280)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(216, 23)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageUnitsToolTp.SetToolTip(Me.lblOutput, "Displays the average units shipped for seven days")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(43, 320)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "Enter"
        Me.ttAverageUnitsToolTp.SetToolTip(Me.btnEnter, "Enters the units shipped for the current day")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(165, 320)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.ttAverageUnitsToolTp.SetToolTip(Me.btnReset, "Resets the program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(287, 320)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.ttAverageUnitsToolTp.SetToolTip(Me.btnExit, "Exits the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(424, 390)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInputDisplay)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnits)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtInputDisplay As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttAverageUnitsToolTp As ToolTip
End Class
