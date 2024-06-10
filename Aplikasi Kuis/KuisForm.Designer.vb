<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KuisForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.opsiC = New System.Windows.Forms.RadioButton()
        Me.opsiB = New System.Windows.Forms.RadioButton()
        Me.opsiA = New System.Windows.Forms.RadioButton()
        Me.labIndex = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.boxPertanyaan = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSelesai)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.opsiC)
        Me.GroupBox1.Controls.Add(Me.opsiB)
        Me.GroupBox1.Controls.Add(Me.opsiA)
        Me.GroupBox1.Controls.Add(Me.labIndex)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.boxPertanyaan)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 694)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kuis"
        '
        'btnSelesai
        '
        Me.btnSelesai.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelesai.Enabled = False
        Me.btnSelesai.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSelesai.Location = New System.Drawing.Point(685, 209)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(146, 44)
        Me.btnSelesai.TabIndex = 10
        Me.btnSelesai.Text = "Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = False
        Me.btnSelesai.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Red
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.Location = New System.Drawing.Point(750, 34)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(78, 36)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Batal"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'opsiC
        '
        Me.opsiC.AutoSize = True
        Me.opsiC.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.opsiC.Location = New System.Drawing.Point(96, 592)
        Me.opsiC.Name = "opsiC"
        Me.opsiC.Size = New System.Drawing.Size(137, 32)
        Me.opsiC.TabIndex = 8
        Me.opsiC.TabStop = True
        Me.opsiC.Text = "RadioButton3"
        Me.opsiC.UseVisualStyleBackColor = True
        '
        'opsiB
        '
        Me.opsiB.AutoSize = True
        Me.opsiB.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.opsiB.Location = New System.Drawing.Point(92, 482)
        Me.opsiB.Name = "opsiB"
        Me.opsiB.Size = New System.Drawing.Size(137, 32)
        Me.opsiB.TabIndex = 7
        Me.opsiB.TabStop = True
        Me.opsiB.Text = "RadioButton2"
        Me.opsiB.UseVisualStyleBackColor = True
        '
        'opsiA
        '
        Me.opsiA.AutoSize = True
        Me.opsiA.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.opsiA.Location = New System.Drawing.Point(96, 377)
        Me.opsiA.Name = "opsiA"
        Me.opsiA.Size = New System.Drawing.Size(133, 32)
        Me.opsiA.TabIndex = 6
        Me.opsiA.TabStop = True
        Me.opsiA.Text = "RadioButton1"
        Me.opsiA.UseVisualStyleBackColor = True
        '
        'labIndex
        '
        Me.labIndex.AutoSize = True
        Me.labIndex.Font = New System.Drawing.Font("Poppins Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labIndex.Location = New System.Drawing.Point(326, 46)
        Me.labIndex.Name = "labIndex"
        Me.labIndex.Size = New System.Drawing.Size(58, 39)
        Me.labIndex.TabIndex = 1
        Me.labIndex.Text = "1/10"
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(39, 587)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(54, 42)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "C"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(39, 477)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(54, 42)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "B"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(39, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 42)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "A"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'boxPertanyaan
        '
        Me.boxPertanyaan.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.boxPertanyaan.Location = New System.Drawing.Point(39, 122)
        Me.boxPertanyaan.Name = "boxPertanyaan"
        Me.boxPertanyaan.ReadOnly = True
        Me.boxPertanyaan.Size = New System.Drawing.Size(640, 242)
        Me.boxPertanyaan.TabIndex = 2
        Me.boxPertanyaan.Text = ""
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(533, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Selanjutnya"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(39, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sebelumnya"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KuisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 718)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "KuisForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KuisForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents boxPertanyaan As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents labIndex As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents opsiC As RadioButton
    Friend WithEvents opsiB As RadioButton
    Friend WithEvents opsiA As RadioButton
    Friend WithEvents btnSelesai As Button
End Class
