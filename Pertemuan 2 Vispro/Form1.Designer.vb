<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtNama = New TextBox()
        lblNama = New Label()
        lblNim = New Label()
        txtNim = New TextBox()
        lblKom = New Label()
        txtKom = New TextBox()
        btnTampilkan = New Button()
        btnHapus = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(214, 96)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(196, 27)
        txtNama.TabIndex = 0
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(138, 103)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama :"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(141, 145)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(44, 20)
        lblNim.TabIndex = 3
        lblNim.Text = "Nim :"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(214, 138)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(196, 27)
        txtNim.TabIndex = 2
        ' 
        ' lblKom
        ' 
        lblKom.AutoSize = True
        lblKom.Location = New Point(138, 189)
        lblKom.Name = "lblKom"
        lblKom.Size = New Size(47, 20)
        lblKom.TabIndex = 5
        lblKom.Text = "Kom :"
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(214, 182)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(196, 27)
        txtKom.TabIndex = 4
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(139, 240)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(94, 29)
        btnTampilkan.TabIndex = 6
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(316, 240)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(233, 292)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(566, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnTampilkan)
        Controls.Add(lblKom)
        Controls.Add(txtKom)
        Controls.Add(lblNim)
        Controls.Add(txtNim)
        Controls.Add(lblNama)
        Controls.Add(txtNama)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblKom As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button

End Class
