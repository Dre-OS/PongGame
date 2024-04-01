<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.BtStart = New System.Windows.Forms.Button()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(107, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PONG"
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.White
        Me.PictureBox17.Location = New System.Drawing.Point(184, 141)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(29, 32)
        Me.PictureBox17.TabIndex = 20
        Me.PictureBox17.TabStop = False
        '
        'BtStart
        '
        Me.BtStart.BackColor = System.Drawing.Color.Black
        Me.BtStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtStart.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtStart.ForeColor = System.Drawing.Color.White
        Me.BtStart.Location = New System.Drawing.Point(80, 231)
        Me.BtStart.Name = "BtStart"
        Me.BtStart.Size = New System.Drawing.Size(238, 71)
        Me.BtStart.TabIndex = 21
        Me.BtStart.Text = "START"
        Me.BtStart.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(400, 556)
        Me.Controls.Add(Me.BtStart)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents BtStart As Button
End Class
