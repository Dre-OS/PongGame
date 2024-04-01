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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(65, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 99)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PONG"
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.White
        Me.PictureBox17.Location = New System.Drawing.Point(187, 43)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(29, 32)
        Me.PictureBox17.TabIndex = 20
        Me.PictureBox17.TabStop = False
        '
        'BtStart
        '
        Me.BtStart.BackColor = System.Drawing.Color.Black
        Me.BtStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtStart.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtStart.ForeColor = System.Drawing.Color.White
        Me.BtStart.Location = New System.Drawing.Point(129, 227)
        Me.BtStart.Name = "BtStart"
        Me.BtStart.Size = New System.Drawing.Size(137, 47)
        Me.BtStart.TabIndex = 21
        Me.BtStart.Text = "START"
        Me.BtStart.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(129, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 47)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(129, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 47)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "ONLINE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(401, 531)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
