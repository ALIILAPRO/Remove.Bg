<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_1
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
        Me.txt_api = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.hideme = New System.Windows.Forms.CheckBox()
        Me.Pfinished = New System.Windows.Forms.PictureBox()
        Me.Poriginal = New System.Windows.Forms.PictureBox()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Pfinished, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_api
        '
        Me.txt_api.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_api.Location = New System.Drawing.Point(74, 8)
        Me.txt_api.Name = "txt_api"
        Me.txt_api.Size = New System.Drawing.Size(394, 22)
        Me.txt_api.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Api Key :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(71, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "[ Note : For Get Api Key See Readme.txt ]"
        '
        'btn_browse
        '
        Me.btn_browse.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(12, 60)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(122, 32)
        Me.btn_browse.TabIndex = 3
        Me.btn_browse.Text = "Browse Picture"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(140, 60)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(122, 32)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Save in"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'hideme
        '
        Me.hideme.AutoSize = True
        Me.hideme.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hideme.Location = New System.Drawing.Point(474, 8)
        Me.hideme.Name = "hideme"
        Me.hideme.Size = New System.Drawing.Size(74, 20)
        Me.hideme.TabIndex = 5
        Me.hideme.Text = "Hide Api"
        Me.hideme.UseVisualStyleBackColor = True
        '
        'Pfinished
        '
        Me.Pfinished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pfinished.Location = New System.Drawing.Point(374, 97)
        Me.Pfinished.Name = "Pfinished"
        Me.Pfinished.Size = New System.Drawing.Size(319, 378)
        Me.Pfinished.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pfinished.TabIndex = 6
        Me.Pfinished.TabStop = False
        '
        'Poriginal
        '
        Me.Poriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Poriginal.Location = New System.Drawing.Point(15, 97)
        Me.Poriginal.Name = "Poriginal"
        Me.Poriginal.Size = New System.Drawing.Size(319, 378)
        Me.Poriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Poriginal.TabIndex = 7
        Me.Poriginal.TabStop = False
        '
        'txtLocal
        '
        Me.txtLocal.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocal.Location = New System.Drawing.Point(268, 60)
        Me.txtLocal.Multiline = True
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(394, 32)
        Me.txtLocal.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(340, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "=>"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(613, 478)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Version 1.0.0"
        '
        'Frm_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 496)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.Pfinished)
        Me.Controls.Add(Me.Poriginal)
        Me.Controls.Add(Me.hideme)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_api)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Background Remover [ By aliilapro]"
        CType(Me.Pfinished, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poriginal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_api As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_browse As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents hideme As CheckBox
    Friend WithEvents Pfinished As PictureBox
    Friend WithEvents Poriginal As PictureBox
    Friend WithEvents txtLocal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
