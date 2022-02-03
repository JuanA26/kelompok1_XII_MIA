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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nam1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmplkn = New System.Windows.Forms.Button()
        Me.Kls = New System.Windows.Forms.ComboBox()
        Me.Matpel = New System.Windows.Forms.ComboBox()
        Me.ext2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAmaewa kimi nani?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mata pelajaran :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kelas :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Nam1
        '
        Me.Nam1.Location = New System.Drawing.Point(165, 81)
        Me.Nam1.Name = "Nam1"
        Me.Nam1.Size = New System.Drawing.Size(246, 22)
        Me.Nam1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tmplkn
        '
        Me.tmplkn.Location = New System.Drawing.Point(165, 180)
        Me.tmplkn.Name = "tmplkn"
        Me.tmplkn.Size = New System.Drawing.Size(246, 33)
        Me.tmplkn.TabIndex = 6
        Me.tmplkn.Text = "Tampilkan"
        Me.tmplkn.UseVisualStyleBackColor = True
        '
        'Kls
        '
        Me.Kls.FormattingEnabled = True
        Me.Kls.Items.AddRange(New Object() {"XII MIA", "XII IIS"})
        Me.Kls.Location = New System.Drawing.Point(165, 109)
        Me.Kls.Name = "Kls"
        Me.Kls.Size = New System.Drawing.Size(246, 24)
        Me.Kls.TabIndex = 7
        '
        'Matpel
        '
        Me.Matpel.FormattingEnabled = True
        Me.Matpel.Items.AddRange(New Object() {"MatPem", "MatWaj", "Biologi", "Kimia", "Fisika", "BaKoreak", "Penjas", "Ppkn", "Senbud", "BasIng", "Sasing", "BasIndo"})
        Me.Matpel.Location = New System.Drawing.Point(165, 139)
        Me.Matpel.Name = "Matpel"
        Me.Matpel.Size = New System.Drawing.Size(246, 24)
        Me.Matpel.TabIndex = 8
        '
        'ext2
        '
        Me.ext2.BackColor = System.Drawing.Color.Red
        Me.ext2.Location = New System.Drawing.Point(165, 219)
        Me.ext2.Name = "ext2"
        Me.ext2.Size = New System.Drawing.Size(76, 29)
        Me.ext2.TabIndex = 9
        Me.ext2.Text = "Exit"
        Me.ext2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 361)
        Me.Controls.Add(Me.ext2)
        Me.Controls.Add(Me.Matpel)
        Me.Controls.Add(Me.Kls)
        Me.Controls.Add(Me.tmplkn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Nam1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nam1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tmplkn As System.Windows.Forms.Button
    Friend WithEvents Kls As System.Windows.Forms.ComboBox
    Friend WithEvents Matpel As System.Windows.Forms.ComboBox
    Friend WithEvents ext2 As System.Windows.Forms.Button
End Class
