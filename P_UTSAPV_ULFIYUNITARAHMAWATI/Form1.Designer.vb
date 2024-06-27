<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGajiBersih = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPotongan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJamsostek = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTujangan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGajiPokok = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbJabatan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNik = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.btnBlank = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(414, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(379, 36)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "FORM GAJI KARYAWAN"
        '
        'txtGajiBersih
        '
        Me.txtGajiBersih.Location = New System.Drawing.Point(656, 235)
        Me.txtGajiBersih.Name = "txtGajiBersih"
        Me.txtGajiBersih.Size = New System.Drawing.Size(308, 26)
        Me.txtGajiBersih.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(528, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Gaji Bersih"
        '
        'txtPotongan
        '
        Me.txtPotongan.Location = New System.Drawing.Point(656, 196)
        Me.txtPotongan.Name = "txtPotongan"
        Me.txtPotongan.Size = New System.Drawing.Size(308, 26)
        Me.txtPotongan.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(528, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Potongan"
        '
        'txtJamsostek
        '
        Me.txtJamsostek.Location = New System.Drawing.Point(656, 150)
        Me.txtJamsostek.Name = "txtJamsostek"
        Me.txtJamsostek.Size = New System.Drawing.Size(308, 26)
        Me.txtJamsostek.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(528, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Jamsostek"
        '
        'txtTujangan
        '
        Me.txtTujangan.Location = New System.Drawing.Point(656, 105)
        Me.txtTujangan.Name = "txtTujangan"
        Me.txtTujangan.Size = New System.Drawing.Size(308, 26)
        Me.txtTujangan.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(528, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Tunjangan"
        '
        'txtGajiPokok
        '
        Me.txtGajiPokok.Location = New System.Drawing.Point(184, 241)
        Me.txtGajiPokok.Name = "txtGajiPokok"
        Me.txtGajiPokok.Size = New System.Drawing.Size(310, 26)
        Me.txtGajiPokok.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Gaji Pokok"
        '
        'cbJabatan
        '
        Me.cbJabatan.FormattingEnabled = True
        Me.cbJabatan.Items.AddRange(New Object() {"DIREKTUR", "KABAG", "STAFF", "ADMIN", "SATPAM"})
        Me.cbJabatan.Location = New System.Drawing.Point(186, 191)
        Me.cbJabatan.Name = "cbJabatan"
        Me.cbJabatan.Size = New System.Drawing.Size(310, 28)
        Me.cbJabatan.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Jabatan"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(186, 149)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(310, 26)
        Me.txtNama.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nama Karyawan"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggal.Location = New System.Drawing.Point(186, 103)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(308, 26)
        Me.dtpTanggal.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tanggal"
        '
        'txtNik
        '
        Me.txtNik.Location = New System.Drawing.Point(184, 57)
        Me.txtNik.Name = "txtNik"
        Me.txtNik.Size = New System.Drawing.Size(209, 26)
        Me.txtNik.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nomor Induk"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(769, 290)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(178, 44)
        Me.btnBatal.TabIndex = 41
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(585, 290)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(178, 44)
        Me.btnHapus.TabIndex = 40
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(401, 290)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(178, 44)
        Me.btnEdit.TabIndex = 39
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(217, 290)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(178, 44)
        Me.btnSimpan.TabIndex = 35
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBaru
        '
        Me.btnBaru.Location = New System.Drawing.Point(33, 290)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(178, 44)
        Me.btnBaru.TabIndex = 32
        Me.btnBaru.Text = "BARU"
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'btnBlank
        '
        Me.btnBlank.Location = New System.Drawing.Point(953, 51)
        Me.btnBlank.Name = "btnBlank"
        Me.btnBlank.Size = New System.Drawing.Size(178, 44)
        Me.btnBlank.TabIndex = 43
        Me.btnBlank.Text = "BLANKFORM"
        Me.btnBlank.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(953, 290)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(178, 44)
        Me.btnTutup.TabIndex = 42
        Me.btnTutup.Text = "TUTUP"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 349)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1110, 263)
        Me.DataGridView1.TabIndex = 44
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 641)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtGajiBersih)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPotongan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtJamsostek)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTujangan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGajiPokok)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbJabatan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNik)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.btnBlank)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form Gaji Karyawan Ulfi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGajiBersih As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPotongan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtJamsostek As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTujangan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGajiPokok As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNik As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBaru As System.Windows.Forms.Button
    Friend WithEvents btnBlank As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
