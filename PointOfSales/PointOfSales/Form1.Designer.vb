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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.kode_barang = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.bayar = New System.Windows.Forms.TextBox()
        Me.kembali = New System.Windows.Forms.TextBox()
        Me.tambah = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.jumlah_barang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.TextBox()
        Me.bayar_kecil = New System.Windows.Forms.TextBox()
        Me.total_kecil = New System.Windows.Forms.TextBox()
        Me.pajak = New System.Windows.Forms.TextBox()
        Me.kembali_kecil = New System.Windows.Forms.TextBox()
        Me.hapus = New System.Windows.Forms.Button()
        Me.keluar = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.cetak = New System.Windows.Forms.Button()
        Me.tabel_barang = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hitung = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.tabel_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(525, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(496, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kembali :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(518, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Bayar :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kode Barang :"
        '
        'kode_barang
        '
        Me.kode_barang.Location = New System.Drawing.Point(10, 149)
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.Size = New System.Drawing.Size(248, 20)
        Me.kode_barang.TabIndex = 10
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.Azure
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.SystemColors.MenuText
        Me.total.Location = New System.Drawing.Point(592, 11)
        Me.total.Multiline = True
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Size = New System.Drawing.Size(518, 75)
        Me.total.TabIndex = 11
        Me.total.Text = "Rp0"
        '
        'bayar
        '
        Me.bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bayar.Location = New System.Drawing.Point(592, 92)
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(517, 31)
        Me.bayar.TabIndex = 12
        Me.bayar.Text = "Rp0"
        '
        'kembali
        '
        Me.kembali.BackColor = System.Drawing.Color.Azure
        Me.kembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kembali.Location = New System.Drawing.Point(591, 129)
        Me.kembali.Multiline = True
        Me.kembali.Name = "kembali"
        Me.kembali.ReadOnly = True
        Me.kembali.Size = New System.Drawing.Size(518, 40)
        Me.kembali.TabIndex = 13
        Me.kembali.Text = "Rp0"
        '
        'tambah
        '
        Me.tambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambah.ForeColor = System.Drawing.Color.White
        Me.tambah.Location = New System.Drawing.Point(389, 129)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(79, 40)
        Me.tambah.TabIndex = 14
        Me.tambah.Text = "Tambah (F1)"
        Me.tambah.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.ForeColor = System.Drawing.Color.White
        Me.edit.Location = New System.Drawing.Point(474, 495)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(79, 40)
        Me.edit.TabIndex = 15
        Me.edit.Text = "Edit (F3)"
        Me.edit.UseVisualStyleBackColor = False
        '
        'jumlah_barang
        '
        Me.jumlah_barang.Location = New System.Drawing.Point(264, 149)
        Me.jumlah_barang.Name = "jumlah_barang"
        Me.jumlah_barang.Size = New System.Drawing.Size(119, 20)
        Me.jumlah_barang.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(261, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Jumlah Barang :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 449)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Subtotal :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 527)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Bayar :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 501)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 556)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Kembali :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 475)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Pajak :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'subtotal
        '
        Me.subtotal.BackColor = System.Drawing.Color.Azure
        Me.subtotal.Location = New System.Drawing.Point(86, 449)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Size = New System.Drawing.Size(218, 20)
        Me.subtotal.TabIndex = 23
        Me.subtotal.Text = "Rp0"
        '
        'bayar_kecil
        '
        Me.bayar_kecil.BackColor = System.Drawing.Color.Azure
        Me.bayar_kecil.Location = New System.Drawing.Point(86, 527)
        Me.bayar_kecil.Name = "bayar_kecil"
        Me.bayar_kecil.ReadOnly = True
        Me.bayar_kecil.Size = New System.Drawing.Size(218, 20)
        Me.bayar_kecil.TabIndex = 24
        Me.bayar_kecil.Text = "Rp0"
        '
        'total_kecil
        '
        Me.total_kecil.BackColor = System.Drawing.Color.Azure
        Me.total_kecil.Location = New System.Drawing.Point(86, 501)
        Me.total_kecil.Name = "total_kecil"
        Me.total_kecil.ReadOnly = True
        Me.total_kecil.Size = New System.Drawing.Size(218, 20)
        Me.total_kecil.TabIndex = 25
        Me.total_kecil.Text = "Rp0"
        '
        'pajak
        '
        Me.pajak.BackColor = System.Drawing.Color.Azure
        Me.pajak.Location = New System.Drawing.Point(86, 475)
        Me.pajak.Name = "pajak"
        Me.pajak.ReadOnly = True
        Me.pajak.Size = New System.Drawing.Size(218, 20)
        Me.pajak.TabIndex = 26
        Me.pajak.Text = "Rp0"
        '
        'kembali_kecil
        '
        Me.kembali_kecil.BackColor = System.Drawing.Color.Azure
        Me.kembali_kecil.Location = New System.Drawing.Point(86, 556)
        Me.kembali_kecil.Name = "kembali_kecil"
        Me.kembali_kecil.ReadOnly = True
        Me.kembali_kecil.Size = New System.Drawing.Size(218, 20)
        Me.kembali_kecil.TabIndex = 27
        Me.kembali_kecil.Text = "Rp0"
        '
        'hapus
        '
        Me.hapus.BackColor = System.Drawing.Color.White
        Me.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.hapus.Location = New System.Drawing.Point(474, 449)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(79, 40)
        Me.hapus.TabIndex = 28
        Me.hapus.Text = "Hapus (F2)"
        Me.hapus.UseVisualStyleBackColor = False
        '
        'keluar
        '
        Me.keluar.BackColor = System.Drawing.Color.Aqua
        Me.keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluar.ForeColor = System.Drawing.Color.Black
        Me.keluar.Location = New System.Drawing.Point(389, 541)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(164, 32)
        Me.keluar.TabIndex = 29
        Me.keluar.Text = "Keluar (F9)"
        Me.keluar.UseVisualStyleBackColor = False
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.White
        Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.reset.Location = New System.Drawing.Point(389, 495)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(79, 40)
        Me.reset.TabIndex = 30
        Me.reset.Text = "Reset (F5)"
        Me.reset.UseVisualStyleBackColor = False
        '
        'cetak
        '
        Me.cetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.cetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cetak.ForeColor = System.Drawing.Color.White
        Me.cetak.Location = New System.Drawing.Point(559, 449)
        Me.cetak.Name = "cetak"
        Me.cetak.Size = New System.Drawing.Size(550, 127)
        Me.cetak.TabIndex = 31
        Me.cetak.Text = "CETAK MASBRO (F7)"
        Me.cetak.UseVisualStyleBackColor = False
        '
        'tabel_barang
        '
        Me.tabel_barang.AllowUserToAddRows = False
        Me.tabel_barang.AllowUserToDeleteRows = False
        Me.tabel_barang.AllowUserToResizeColumns = False
        Me.tabel_barang.AllowUserToResizeRows = False
        Me.tabel_barang.BackgroundColor = System.Drawing.Color.White
        Me.tabel_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tabel_barang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column5, Me.Column7, Me.Column8, Me.Column9})
        Me.tabel_barang.Location = New System.Drawing.Point(10, 174)
        Me.tabel_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.tabel_barang.Name = "tabel_barang"
        Me.tabel_barang.ReadOnly = True
        Me.tabel_barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabel_barang.Size = New System.Drawing.Size(1099, 270)
        Me.tabel_barang.TabIndex = 32
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 40
        '
        'Column6
        '
        Me.Column6.Frozen = True
        Me.Column6.HeaderText = "Kode"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 200
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Nama"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "Jumlah"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.Frozen = True
        Me.Column5.HeaderText = "Harga"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column5.Width = 150
        '
        'Column7
        '
        Me.Column7.Frozen = True
        Me.Column7.HeaderText = "Subtotal"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.Frozen = True
        Me.Column8.HeaderText = "Pajak"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column9
        '
        Me.Column9.Frozen = True
        Me.Column9.HeaderText = "Total"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column9.Width = 150
        '
        'hitung
        '
        Me.hitung.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.hitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hitung.ForeColor = System.Drawing.Color.White
        Me.hitung.Location = New System.Drawing.Point(389, 449)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(79, 40)
        Me.hitung.TabIndex = 33
        Me.hitung.Text = "Hitung (F4)"
        Me.hitung.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(10, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 98)
        Me.Panel1.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(182, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 30)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "P o S"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1123, 598)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.tabel_barang)
        Me.Controls.Add(Me.cetak)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.kembali_kecil)
        Me.Controls.Add(Me.pajak)
        Me.Controls.Add(Me.total_kecil)
        Me.Controls.Add(Me.bayar_kecil)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.jumlah_barang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.bayar)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.kode_barang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Point of Sales"
        CType(Me.tabel_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents kode_barang As TextBox
    Friend WithEvents bayar As TextBox
    Friend WithEvents kembali As TextBox
    Friend WithEvents tambah As Button
    Friend WithEvents edit As Button
    Friend WithEvents jumlah_barang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents subtotal As TextBox
    Friend WithEvents bayar_kecil As TextBox
    Friend WithEvents total_kecil As TextBox
    Friend WithEvents pajak As TextBox
    Friend WithEvents kembali_kecil As TextBox
    Friend WithEvents hapus As Button
    Friend WithEvents keluar As Button
    Friend WithEvents reset As Button
    Friend WithEvents cetak As Button
    Friend WithEvents tabel_barang As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents hitung As Button
    Protected Friend WithEvents total As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
End Class
