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
        Me.LBAverageSpeed = New System.Windows.Forms.Label()
        Me.TBAverageSpeed = New System.Windows.Forms.TextBox()
        Me.BTNCalcTravelTime = New System.Windows.Forms.Button()
        Me.LBTravelDistance = New System.Windows.Forms.Label()
        Me.TBTravelDistance = New System.Windows.Forms.TextBox()
        Me.TBTravelTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBAverageSpeed
        '
        Me.LBAverageSpeed.AutoSize = True
        Me.LBAverageSpeed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBAverageSpeed.Location = New System.Drawing.Point(33, 41)
        Me.LBAverageSpeed.Name = "LBAverageSpeed"
        Me.LBAverageSpeed.Size = New System.Drawing.Size(112, 19)
        Me.LBAverageSpeed.TabIndex = 0
        Me.LBAverageSpeed.Text = "Average Speed"
        '
        'TBAverageSpeed
        '
        Me.TBAverageSpeed.Location = New System.Drawing.Point(151, 40)
        Me.TBAverageSpeed.Name = "TBAverageSpeed"
        Me.TBAverageSpeed.Size = New System.Drawing.Size(149, 23)
        Me.TBAverageSpeed.TabIndex = 1
        Me.TBAverageSpeed.Text = "Average speed in km/h"
        '
        'BTNCalcTravelTime
        '
        Me.BTNCalcTravelTime.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNCalcTravelTime.Location = New System.Drawing.Point(87, 184)
        Me.BTNCalcTravelTime.Name = "BTNCalcTravelTime"
        Me.BTNCalcTravelTime.Size = New System.Drawing.Size(157, 42)
        Me.BTNCalcTravelTime.TabIndex = 3
        Me.BTNCalcTravelTime.Text = "Calc Travel Time"
        Me.BTNCalcTravelTime.UseVisualStyleBackColor = True
        '
        'LBTravelDistance
        '
        Me.LBTravelDistance.AutoSize = True
        Me.LBTravelDistance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBTravelDistance.Location = New System.Drawing.Point(33, 84)
        Me.LBTravelDistance.Name = "LBTravelDistance"
        Me.LBTravelDistance.Size = New System.Drawing.Size(110, 19)
        Me.LBTravelDistance.TabIndex = 3
        Me.LBTravelDistance.Text = "Travel Distance"
        '
        'TBTravelDistance
        '
        Me.TBTravelDistance.Location = New System.Drawing.Point(151, 83)
        Me.TBTravelDistance.Name = "TBTravelDistance"
        Me.TBTravelDistance.Size = New System.Drawing.Size(149, 23)
        Me.TBTravelDistance.TabIndex = 2
        Me.TBTravelDistance.Text = "Travel distance in km"
        '
        'TBTravelTime
        '
        Me.TBTravelTime.Location = New System.Drawing.Point(151, 123)
        Me.TBTravelTime.Name = "TBTravelTime"
        Me.TBTravelTime.Size = New System.Drawing.Size(149, 23)
        Me.TBTravelTime.TabIndex = 6
        Me.TBTravelTime.TabStop = False
        Me.TBTravelTime.Text = "Travel time in h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(33, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Travel Time"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.TBTravelTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBTravelDistance)
        Me.Controls.Add(Me.LBTravelDistance)
        Me.Controls.Add(Me.BTNCalcTravelTime)
        Me.Controls.Add(Me.TBAverageSpeed)
        Me.Controls.Add(Me.LBAverageSpeed)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Travel Time Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBAverageSpeed As Label
    Friend WithEvents TBAverageSpeed As TextBox
    Friend WithEvents BTNCalcTravelTime As Button
    Friend WithEvents LBTravelDistance As Label
    Friend WithEvents TBTravelDistance As TextBox
    Friend WithEvents TBTravelTime As TextBox
    Friend WithEvents Label2 As Label
End Class
