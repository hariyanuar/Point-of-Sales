Public Class Form1
    Dim total_value = 0
    Dim subtotal_value = 0
    Dim pajak_value = 0
    Dim kembali_value = 0
    Dim bayar_value = 0
    Dim struk As String
    Public Structure produk
        Dim nama As String
        Dim harga As Integer
        Dim kode As String
        Dim description As String
        Dim kuantitas As Short
        Dim subtotal As Integer
        Dim tax As Integer
        Dim total As Integer
    End Structure

    Public product(3) As produk

    Private Sub Buat_Struk()
        struk = "               Point of Sales            " + vbCrLf +
                "-----------------------------------------" + vbCrLf +
                "No     Nama" + vbCrLf
        For i As Integer = 0 To Me.tabel_barang.DisplayedRowCount(True) - 1
            struk += Convert.ToString(tabel_barang(0, i).Value) + ".       " + Convert.ToString(tabel_barang(2, i).Value)
            struk += vbCrLf + "          Jumlah       : "
            struk += Convert.ToString(tabel_barang(3, i).Value)
            struk += vbCrLf + "          Harga         : "
            struk += Convert.ToString(tabel_barang(4, i).Value)
            struk += vbCrLf + "          Subtotal    : "
            struk += Convert.ToString(tabel_barang(5, i).Value)
            struk += vbCrLf + "          Pajak          : "
            struk += Convert.ToString(tabel_barang(6, i).Value) + vbCrLf
        Next
        struk += "-----------------------------------------" + vbCrLf
        struk += "Subtotal      : " + Me.subtotal.Text + vbCrLf +
                 "Pajak            : " + Me.pajak.Text + vbCrLf +
                 "Total             : " + Me.total.Text + vbCrLf +
                 "Bayar            : " + Me.bayar.Text + vbCrLf +
                 "Kembali        : " + Me.kembali.Text

        struk += vbCrLf + "-----------------------------------------" + vbCrLf + "Copyright 2018 Hari Erick Karina         "
    End Sub

    Private Function Compose(i As String)
        Dim b = i.Length - 1
        For a As Integer = 1 To i.Length - 1
            If a Mod 3 = 0 Then
                i = i.Insert(b, ",")
            End If
            b -= 1
        Next
        Return "Rp" + i
    End Function

    Private Function Object_Get_Index(kode As String)
        For i As Integer = 0 To 2
            If product(i).kode = kode Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub Tambah_Produk(ByVal kode As String)
        For i As Integer = 0 To 2
            Dim data As ArrayList = New ArrayList
            If product(i).kode = kode Then
                If Not product(i).kuantitas = 0 Then
                    product(i).kuantitas += Convert.ToInt16(jumlah_barang.Text)
                    Dim rows
                    For b As Integer = 0 To tabel_barang.DisplayedRowCount(True) - 1
                        If tabel_barang.Rows(b).Cells(1).Value = kode_barang.Text Then
                            rows = b
                            Exit For
                        End If
                    Next
                    tabel_barang.Rows(rows).Cells(3).Value = product(i).kuantitas
                    product(i).subtotal = product(i).harga * product(i).kuantitas
                    tabel_barang.Rows(rows).Cells(5).Value = Compose(product(i).subtotal)
                    product(i).tax = product(i).subtotal * 10 / 100
                    tabel_barang.Rows(rows).Cells(6).Value = Compose(product(i).tax)
                    product(i).total = product(i).subtotal + product(i).tax
                    tabel_barang.Rows(rows).Cells(7).Value = Compose(product(i).total)
                    kode_barang.Text = ""
                    jumlah_barang.Text = ""
                    Exit Sub
                Else
                    product(i).kuantitas = Convert.ToInt16(jumlah_barang.Text)
                    data.Add(tabel_barang.DisplayedRowCount(False) + 1)
                    data.Add(product(i).kode)
                    data.Add(product(i).nama)
                    data.Add(product(i).kuantitas)
                    data.Add(Compose(product(i).harga))
                    product(i).subtotal = product(i).harga * product(i).kuantitas
                    data.Add(Compose(product(i).subtotal))
                    product(i).tax = product(i).subtotal * 10 / 100
                    data.Add(Compose(product(i).tax))
                    product(i).total = product(i).subtotal + product(i).tax
                    data.Add(Compose(product(i).total))
                    tabel_barang.Rows.Add(data.ToArray())
                    kode_barang.Text = ""
                    jumlah_barang.Text = ""
                    Exit Sub
                End If
            End If
        Next
        MsgBox("Tidak ditemukan barang dengan kode " + kode)
    End Sub

    Private Sub Hapus_Produk()
        Dim kode As String = tabel_barang.Rows(Convert.ToInt32(tabel_barang.CurrentCell.RowIndex)).Cells(1).Value
        Dim index As Integer = tabel_barang.CurrentCell.RowIndex
        For i As Integer = 0 To 2
            If product(i).kode = kode Then
                Reset_Produk(i)
                Exit For
            End If
        Next
        Refresh()
        tabel_barang.Rows.RemoveAt(index)
        For i As Integer = 0 To (tabel_barang.DisplayedRowCount(True) - 1)
            tabel_barang(0, i).Value = i + 1
        Next
        kembali_value = bayar_value - total_value
        Me.kembali.Text = Compose(kembali_value)
        Me.kembali_kecil.Text = Compose(kembali_value)
    End Sub

    Private Sub Reset_Produk(i As Integer)
        product(i).kuantitas = 0
        product(i).subtotal = 0
        product(i).tax = 0
        product(i).total = 0
    End Sub

    Private Sub Refresh()
        total_value = 0
        pajak_value = 0
        subtotal_value = 0
        For i As Integer = 0 To tabel_barang.DisplayedRowCount(True) - 1
            Dim b
            b = Object_Get_Index(tabel_barang(1, i).Value)
            product(b).subtotal = product(b).harga * product(b).kuantitas
            product(b).tax = product(b).subtotal * 10 / 100
            product(b).total = product(b).subtotal + product(b).tax
            total_value += product(b).total
            pajak_value += product(b).tax
            subtotal_value += product(b).subtotal
        Next
        Me.total.Text = Compose(total_value)
        Me.total_kecil.Text = Compose(total_value)
        Me.subtotal.Text = Compose(subtotal_value)
        Me.pajak.Text = Compose(pajak_value)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        product(0).nama = "Laptop"
        product(0).harga = 12000000
        product(0).kode = "1"
        product(0).description = "Intel Core i9-9900k, RTX 2080Ti, RAM 64GB 3200 mHz, 5TB Hardisk, 2TB SSD."
        product(0).kuantitas = 0

        product(1).nama = "Celana Dalam"
        product(1).harga = 25000
        product(1).kode = "2"
        product(1).description = "Intel Core i9-9900k, RTX 2080Ti, RAM 64GB 3200 mHz, 5TB Hardisk, 2TB SSD."
        product(1).kuantitas = 0

        product(2).nama = "Mousepad"
        product(2).harga = 300000
        product(2).kode = "3"
        product(2).description = "Intel Core i9-9900k, RTX 2080Ti, RAM 64GB 3200 mHz, 5TB Hardisk, 2TB SSD."
        product(2).kuantitas = 0
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Tambah_Produk(kode_barang.Text)
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        If Not tabel_barang.DisplayedRowCount(True) = 0 Then
            Hapus_Produk()
        End If
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        End
    End Sub

    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        If Not bayar.Text = "Rp0" Or Not Convert.ToInt64(Get_Only_Numbers(bayar.Text)) < Convert.ToInt64(Get_Only_Numbers(total.Text)) Then
            kembali_value = bayar_value - total_value
            Me.kembali.Text = Compose(Convert.ToString(kembali_value))
            Me.kembali_kecil.Text = Compose(Convert.ToString(kembali_value))
        Else
            MsgBox("Jumlah bayar harus diisi!")
        End If

    End Sub

    Private Sub tabel_barang_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_barang.CellValueChanged
        Refresh()
    End Sub

    Private Sub tabel_barang_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles tabel_barang.RowStateChanged
        Refresh()
    End Sub



    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim kuantiti As Integer = 0, index
        If Not IsNothing(tabel_barang.CurrentCell) Then
            kuantiti = InputBox("Kuantitas : ", Convert.ToString(tabel_barang(2, Convert.ToInt16(tabel_barang.CurrentCell.RowIndex)).Value))
            index = Convert.ToInt16(Object_Get_Index(tabel_barang(1, tabel_barang.CurrentCell.RowIndex).Value))
            If Not kuantiti = 0 Then
                product(index).kuantitas = kuantiti
                Refresh()
                kembali_value = bayar_value - total_value
                kembali.Text = Compose(kembali_value)
                kembali_kecil.Text = Compose(kembali_value)
            End If
            tabel_barang.Rows(tabel_barang.CurrentCell.RowIndex).Cells(3).Value = product(index).kuantitas
            tabel_barang.Rows(tabel_barang.CurrentCell.RowIndex).Cells(5).Value = Compose(product(index).subtotal)
            tabel_barang.Rows(tabel_barang.CurrentCell.RowIndex).Cells(6).Value = Compose(product(index).tax)
            tabel_barang.Rows(tabel_barang.CurrentCell.RowIndex).Cells(7).Value = Compose(product(index).total)
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        tabel_barang.Rows.Clear()
        bayar.Text = "Rp0"
        bayar_kecil.Text = "Rp0"
        kembali.Text = "Rp0"
        kembali_kecil.Text = "Rp0"
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S Then
            Tambah_Produk(kode_barang.Text)
        End If
    End Sub

    Private Sub cetak_Click(sender As Object, e As EventArgs) Handles cetak.Click
        If Not tabel_barang.DisplayedRowCount(True) = 0 And total.Text = "Rp0" And bayar.Text = "Rp0" And kembali.Text = "Rp0" Then
            MsgBox("Pengisian data kurang lengkap!")
        Else
            Buat_Struk()
            MsgBox(struk,, "Struk")
        End If
    End Sub

    Private Function Get_Only_Numbers(i As String)
        Dim a As String
        For b As Integer = 0 To i.Length - 1
            If Convert.ToInt16(i(b)) > 47 And Convert.ToInt16(i(b)) <= 57 Then
                a += i(b)
            End If
        Next
        Return a
    End Function

    Private Sub bayar_TextChanged(sender As Object, e As EventArgs) Handles bayar.TextChanged
        If Me.bayar.Text.Length < 28 Then
            bayar_value = Convert.ToInt64(Get_Only_Numbers(Me.bayar.Text))
            Me.bayar.Text = Compose(bayar_value)
            Me.bayar_kecil.Text = Compose(bayar_value)
            Me.bayar.SelectionStart = Me.bayar.Text.Length
        End If
    End Sub

    Private Sub bayar_KeyDown(sender As Object, e As KeyEventArgs) Handles bayar.KeyDown
        If e.KeyCode = Keys.Back And Me.bayar.Text.Length > 3 Then
            bayar_value = Convert.ToInt64(Convert.ToString(bayar_value / 10))
        End If
    End Sub
End Class
