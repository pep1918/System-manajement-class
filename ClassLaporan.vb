Imports System.IO
Imports System.Windows.Forms
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ClassLaporan

    ' --- KONFIGURASI KOP SURAT (Ganti Sesuai Sekolah Anda) ---
    Private Const NAMA_SEKOLAH As String = "SMK TEKNOLOGI MAJU JAYA"
    Private Const ALAMAT_SEKOLAH As String = "Jl. Pendidikan No. 123, Surabaya, Jawa Timur" & vbCrLf & "Telp: (031) 555-1234 | Email: admin@sekolah.sch.id"
    Private Const NAMA_KEPSEK As String = "Dr. H. Budi Santoso, M.Pd"
    Private Const NIP_KEPSEK As String = "NIP. 19800101 200012 1 001"

    ' ==============================================================
    ' FUNGSI UTAMA: DIPANGGIL DARI FORM LAIN
    ' ==============================================================
    Public Sub CetakLaporan(dgv As DataGridView, judulLaporan As String, namaFileOutput As String)
        ' 1. Validasi Data
        If dgv.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk dicetak!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' 2. Dialog Simpan File
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files|*.pdf"
        sfd.FileName = namaFileOutput & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss")

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                ' 3. Setup Dokumen A4 Landscape
                Dim doc As New Document(PageSize.A4.Rotate(), 20, 20, 30, 30)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                ' 4. Panggil Sub-Fungsi Penyusun
                BuatKopSurat(doc)
                BuatJudul(doc, judulLaporan)
                BuatTabelOtomatis(doc, dgv)
                BuatTandaTangan(doc)

                doc.Close()

                ' 5. Buka File Otomatis
                MessageBox.Show("Laporan berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Process.Start(sfd.FileName)

            Catch ex As Exception
                MessageBox.Show("Gagal mencetak PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ==============================================================
    ' SUB-ROUTINE: MEMBUAT KOP SURAT
    ' ==============================================================
    Private Sub BuatKopSurat(doc As Document)
        Dim tblKop As New PdfPTable(2)
        tblKop.WidthPercentage = 100
        tblKop.SetWidths(New Single() {1.5F, 8.5F})

        ' A. Logo
        Dim pathLogo As String = Application.StartupPath & "\logo.png"
        Dim cellLogo As PdfPCell
        If File.Exists(pathLogo) Then
            Dim img As Image = Image.GetInstance(pathLogo)
            cellLogo = New PdfPCell(img, True)
            cellLogo.Padding = 5
        Else
            cellLogo = New PdfPCell(New Phrase("LOGO"))
        End If
        cellLogo.Border = Rectangle.NO_BORDER
        cellLogo.HorizontalAlignment = Element.ALIGN_CENTER
        cellLogo.VerticalAlignment = Element.ALIGN_MIDDLE
        tblKop.AddCell(cellLogo)

        ' B. Teks Sekolah
        Dim fontHeader As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
        Dim fontAlamat As Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)

        Dim pNama As New Paragraph(NAMA_SEKOLAH, fontHeader)
        pNama.Alignment = Element.ALIGN_CENTER

        Dim pAlamat As New Paragraph(ALAMAT_SEKOLAH, fontAlamat)
        pAlamat.Alignment = Element.ALIGN_CENTER

        Dim cellTeks As New PdfPCell()
        cellTeks.Border = Rectangle.NO_BORDER
        cellTeks.AddElement(pNama)
        cellTeks.AddElement(pAlamat)
        cellTeks.VerticalAlignment = Element.ALIGN_MIDDLE
        tblKop.AddCell(cellTeks)

        doc.Add(tblKop)

        ' C. Garis
        Dim line As New Paragraph(New Chunk(New iTextSharp.text.pdf.draw.LineSeparator(2.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, -5)))
        doc.Add(line)
        doc.Add(New Paragraph(" ")) ' Spasi
    End Sub

    ' ==============================================================
    ' SUB-ROUTINE: JUDUL LAPORAN
    ' ==============================================================
    Private Sub BuatJudul(doc As Document, judul As String)
        Dim fontJudul As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)
        Dim p As New Paragraph(judul.ToUpper(), fontJudul)
        p.Alignment = Element.ALIGN_CENTER
        p.SpacingAfter = 15
        doc.Add(p)
    End Sub

    ' ==============================================================
    ' SUB-ROUTINE: TABEL OTOMATIS (DARI DATAGRIDVIEW)
    ' ==============================================================
    Private Sub BuatTabelOtomatis(doc As Document, dgv As DataGridView)
        ' Hitung kolom yg visible saja (ID biasanya disembunyikan)
        Dim colCount As Integer = 0
        For Each col As DataGridViewColumn In dgv.Columns
            If col.Visible Then colCount += 1
        Next

        ' Tambah 1 kolom untuk Nomor Urut
        Dim table As New PdfPTable(colCount + 1)
        table.WidthPercentage = 100

        ' Font Tabel
        Dim fHeader As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9)
        Dim fIsi As Font = FontFactory.GetFont(FontFactory.HELVETICA, 8)

        ' --- HEADER ---
        ' Kolom No
        Dim cellNo As New PdfPCell(New Phrase("No", fHeader))
        cellNo.BackgroundColor = BaseColor.LIGHT_GRAY
        cellNo.HorizontalAlignment = Element.ALIGN_CENTER
        cellNo.Padding = 5
        table.AddCell(cellNo)

        ' Kolom Grid
        For Each col As DataGridViewColumn In dgv.Columns
            If col.Visible Then
                Dim cell As New PdfPCell(New Phrase(col.HeaderText, fHeader))
                cell.BackgroundColor = BaseColor.LIGHT_GRAY
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                cell.Padding = 5
                table.AddCell(cell)
            End If
        Next

        ' --- ISI DATA ---
        Dim noUrut As Integer = 1
        For Each row As DataGridViewRow In dgv.Rows
            ' Isi No
            Dim cellUrut As New PdfPCell(New Phrase(noUrut.ToString(), fIsi))
            cellUrut.HorizontalAlignment = Element.ALIGN_CENTER
            table.AddCell(cellUrut)

            ' Isi Grid
            For Each cell As DataGridViewCell In row.Cells
                If dgv.Columns(cell.ColumnIndex).Visible Then
                    Dim isi As String = If(cell.Value Is Nothing, "", cell.Value.ToString())

                    ' Format Tanggal
                    If TypeOf cell.Value Is Date Then
                        isi = Convert.ToDateTime(cell.Value).ToString("dd-MM-yyyy")
                    End If

                    Dim pdfCell As New PdfPCell(New Phrase(isi, fIsi))
                    pdfCell.Padding = 3
                    table.AddCell(pdfCell)
                End If
            Next
            noUrut += 1
        Next

        doc.Add(table)
    End Sub

    ' ==============================================================
    ' SUB-ROUTINE: TANDA TANGAN
    ' ==============================================================
    Private Sub BuatTandaTangan(doc As Document)
        doc.Add(New Paragraph(" ")) ' Spasi ke bawah

        Dim tbl As New PdfPTable(3)
        tbl.WidthPercentage = 100
        tbl.SetWidths(New Single() {4, 4, 4})

        ' Kosong kiri tengah
        Dim cEmpty As New PdfPCell(New Phrase(""))
        cEmpty.Border = Rectangle.NO_BORDER
        tbl.AddCell(cEmpty)
        tbl.AddCell(cEmpty)

        ' Kanan
        Dim tgl As String = "Surabaya, " & DateTime.Now.ToString("dd MMMM yyyy")
        Dim fontTTD As Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)

        Dim p As New Paragraph(tgl & vbCrLf & "Kepala Sekolah," & vbCrLf & vbCrLf & vbCrLf & vbCrLf & NAMA_KEPSEK & vbCrLf & NIP_KEPSEK, fontTTD)
        p.Alignment = Element.ALIGN_CENTER

        Dim cTTD As New PdfPCell(p)
        cTTD.Border = Rectangle.NO_BORDER
        cTTD.HorizontalAlignment = Element.ALIGN_CENTER

        tbl.AddCell(cTTD)
        doc.Add(tbl)
    End Sub

End Class