Imports System.Data.OleDb
Public Class Form1
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim LokasiDB As String
    Sub Koneksi()
        LokasiDB = "Provider = Microsoft.Jet.OleDB.4.0;Data Source=dbgaji.mdb"
        conn = New OleDbConnection(LokasiDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub Tombol(ByVal Nilai As Boolean)
        btnBaru.Enabled = Nilai
        btnSimpan.Enabled = Not Nilai
        btnEdit.Enabled = Nilai
        btnHapus.Enabled = Nilai
        btnBatal.Enabled = Not Nilai
        btnTutup.Enabled = Nilai
    End Sub

    Sub TampilData()
        Koneksi()
        da = New OleDbDataAdapter("select * from gaji", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "gaji")
        DataGridView1.DataSource = (ds.Tables("gaji"))
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 70
        DataGridView1.Columns(2).Width = 70
        DataGridView1.Columns(3).Width = 70
        DataGridView1.Columns(4).Width = 80
        DataGridView1.Columns(5).Width = 80
        DataGridView1.Columns(6).Width = 80
        DataGridView1.Columns(7).Width = 80
        DataGridView1.Columns(8).Width = 80
        'Format Mata Uang
        DataGridView1.Columns(4).DefaultCellStyle.Format = "Rp ###,###"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "Rp ###,###"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "Rp ###,###"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "Rp ###,###"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "Rp ###,###"
    End Sub

    Sub Matikan(ByVal Nilai As Boolean)
        txtNik.Enabled = Nilai
        dtpTanggal.Enabled = Nilai
        txtNama.Enabled = Nilai
        cbJabatan.Enabled = Nilai
        txtGajiPokok.Enabled = Nilai
        txtTujangan.Enabled = Nilai
        txtJamsostek.Enabled = Nilai
        txtPotongan.Enabled = Nilai
        txtGajiBersih.Enabled = Nilai
    End Sub

    Sub Kosongkan()
        txtNik.Text = ""
        dtpTanggal.CustomFormat = " "
        txtNama.Text = ""
        cbJabatan.Text = ""
        txtGajiPokok.Text = 0
        txtTujangan.Text = 0
        txtJamsostek.Text = 0
        txtPotongan.Text = 0
        txtGajiBersih.Text = 0
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
        Call Matikan(False)
        Call Kosongkan()
        Call Tombol(True)
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        End
    End Sub

    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        Call Matikan(True)
        txtNik.Focus()
        Call Tombol(False)
    End Sub

    Private Sub cbJabatan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbJabatan.SelectedIndexChanged
        Select Case cbJabatan.Text
            Case "DIREKTUR"
                txtGajiPokok.Text = 7000000
                txtTujangan.Text = 3000000
                txtJamsostek.Text = (Val(txtGajiPokok.Text)) / 100 * (2)
            Case "KABAG"
                txtGajiPokok.Text = 5700000
                txtTujangan.Text = 800000
                txtJamsostek.Text = (Val(txtGajiPokok.Text)) / 100 * (2)
            Case "STAFF"
                txtGajiPokok.Text = 3000000
                txtTujangan.Text = 500000
                txtJamsostek.Text = (Val(txtGajiPokok.Text)) / 100 * (2)
            Case "ADMIN"
                txtGajiPokok.Text = 2800000
                txtTujangan.Text = 500000
                txtJamsostek.Text = (Val(txtGajiPokok.Text)) / 100 * (2)
            Case "SATPAM"
                txtGajiPokok.Text = 2500000
                txtTujangan.Text = 500000
                txtJamsostek.Text = (Val(txtGajiPokok.Text)) / 100 * (2)
        End Select
    End Sub

    Private Sub dtpTanggal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTanggal.ValueChanged
        dtpTanggal.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub txtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call TampilData()
        Call Matikan(False)
        Call Kosongkan()
        Call Tombol(True)
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Call Koneksi()
        cmd = New OleDb.OleDbCommand("select * from gaji where nik='" & _
                                     txtNik.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Koneksi()
            Dim simpan As String
            simpan = "insert into gaji values('" & txtNik.Text & "','" & _
                dtpTanggal.Text & "','" & txtNama.Text & "','" & _
                cbJabatan.Text & "'," & txtGajiPokok.Text & "," & _
                txtTujangan.Text & "," & txtJamsostek.Text & "," & _
                txtPotongan.Text & "," & txtGajiBersih.Text & ")"
            cmd = New OleDb.OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil disimpan")
            Call TampilData()
            Call Matikan(False)
            Call Kosongkan()
            Call Tombol(True)
        Else
            MsgBox("Data sudah ada")
        End If
    End Sub

    Private Sub txtPotongan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPotongan.TextChanged
        txtGajiBersih.Text = (Val(txtGajiPokok.Text) + Val(txtTujangan.Text) - (Val(txtJamsostek.Text) + Val(txtPotongan.Text)))
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtNik.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        dtpTanggal.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtNama.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        cbJabatan.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txtGajiPokok.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txtTujangan.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        txtJamsostek.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        txtPotongan.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        txtGajiBersih.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Koneksi()
        Dim strHapus As String
        strHapus = "delete from gaji where nik ='" & txtNik.Text & "'"
        cmd = New OleDb.OleDbCommand(strHapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil dihapus")
        Call TampilData()
        Call Matikan(False)
        Call Kosongkan()
        Call Tombol(True)
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Matikan(True)
        txtNik.Enabled = False
        dtpTanggal.Focus()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Koneksi()
        Dim strUbah As String
        strUbah = "update gaji set " & _
                "tanggal = '" & dtpTanggal.Text & "', " & _
                "nama = '" & txtNama.Text & "', " & _
                "jabatan = '" & cbJabatan.Text & "', " & _
                "gapok = " & txtGajiPokok.Text & ", " & _
                "tunjangan = " & txtTujangan.Text & ", " & _
                "jamsostek = " & txtJamsostek.Text & ", " & _
                "potongan = " & txtPotongan.Text & ", " & _
                "gaber = " & txtGajiBersih.Text & " " & _
                "where nik ='" & txtNik.Text & "'"
        cmd = New OleDb.OleDbCommand(strUbah, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil diubah")
        Call TampilData()
        Call Matikan(False)
        Call Kosongkan()
        Call Tombol(True)
    End Sub

    Private Sub btnBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlank.Click
        txtNik.Text = ""
        dtpTanggal.CustomFormat = " "
        dtpTanggal.Format = DateTimePickerFormat.Custom
        txtNama.Text = ""
        cbJabatan.SelectedIndex = -1
        txtGajiPokok.Text = 0
        txtTujangan.Text = 0
        txtJamsostek.Text = 0
        txtPotongan.Text = 0
        txtGajiBersih.Text = 0
    End Sub
End Class
