﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        lblMaklumatPelanggan = New Label()
        lblNama = New Label()
        lblNoTel = New Label()
        lblAlamat = New Label()
        lblNegeri = New Label()
        txtNama = New TextBox()
        txtNo = New TextBox()
        txtAlamat = New TextBox()
        comNegeri = New ComboBox()
        rbnLelaki = New RadioButton()
        gbxJantina = New GroupBox()
        rbnPerempuan = New RadioButton()
        gbxKaedahBayaran = New GroupBox()
        rbnCashless = New RadioButton()
        rbnCash = New RadioButton()
        gbxPerisa = New GroupBox()
        cbxPisang = New CheckBox()
        cbxStrawberi = New CheckBox()
        cbxKopi = New CheckBox()
        cbxCoklat = New CheckBox()
        cbxMilo = New CheckBox()
        dtpTarikh = New DateTimePicker()
        lblTarikh = New Label()
        dgvTable = New DataGridView()
        BtnCreate = New Button()
        BtnRead = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        clmBil = New DataGridViewTextBoxColumn()
        clmNama = New DataGridViewTextBoxColumn()
        clmNoTel = New DataGridViewTextBoxColumn()
        gbxJantina.SuspendLayout()
        gbxKaedahBayaran.SuspendLayout()
        gbxPerisa.SuspendLayout()
        CType(dgvTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMaklumatPelanggan
        ' 
        lblMaklumatPelanggan.AutoSize = True
        lblMaklumatPelanggan.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMaklumatPelanggan.Location = New Point(317, 9)
        lblMaklumatPelanggan.Name = "lblMaklumatPelanggan"
        lblMaklumatPelanggan.Size = New Size(252, 30)
        lblMaklumatPelanggan.TabIndex = 0
        lblMaklumatPelanggan.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(45, 82)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(39, 15)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblNoTel
        ' 
        lblNoTel.AutoSize = True
        lblNoTel.Location = New Point(42, 131)
        lblNoTel.Name = "lblNoTel"
        lblNoTel.RightToLeft = RightToLeft.No
        lblNoTel.Size = New Size(42, 15)
        lblNoTel.TabIndex = 2
        lblNoTel.Text = "NO.Tel"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(42, 188)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(45, 15)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "Alamat"
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(42, 235)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(42, 15)
        lblNegeri.TabIndex = 4
        lblNegeri.Text = "Negeri"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(123, 79)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(415, 23)
        txtNama.TabIndex = 7
        ' 
        ' txtNo
        ' 
        txtNo.Location = New Point(123, 128)
        txtNo.Name = "txtNo"
        txtNo.Size = New Size(415, 23)
        txtNo.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(123, 185)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(415, 23)
        txtAlamat.TabIndex = 9
        ' 
        ' comNegeri
        ' 
        comNegeri.FormattingEnabled = True
        comNegeri.Location = New Point(123, 235)
        comNegeri.Name = "comNegeri"
        comNegeri.Size = New Size(121, 23)
        comNegeri.TabIndex = 10
        ' 
        ' rbnLelaki
        ' 
        rbnLelaki.AutoSize = True
        rbnLelaki.Location = New Point(6, 22)
        rbnLelaki.Name = "rbnLelaki"
        rbnLelaki.Size = New Size(55, 19)
        rbnLelaki.TabIndex = 11
        rbnLelaki.TabStop = True
        rbnLelaki.Text = "Lelaki"
        rbnLelaki.UseVisualStyleBackColor = True
        ' 
        ' gbxJantina
        ' 
        gbxJantina.Controls.Add(rbnPerempuan)
        gbxJantina.Controls.Add(rbnLelaki)
        gbxJantina.Location = New Point(45, 303)
        gbxJantina.Name = "gbxJantina"
        gbxJantina.Size = New Size(163, 114)
        gbxJantina.TabIndex = 12
        gbxJantina.TabStop = False
        gbxJantina.Text = "Jantina"
        ' 
        ' rbnPerempuan
        ' 
        rbnPerempuan.AutoSize = True
        rbnPerempuan.Location = New Point(14, 65)
        rbnPerempuan.Name = "rbnPerempuan"
        rbnPerempuan.Size = New Size(86, 19)
        rbnPerempuan.TabIndex = 12
        rbnPerempuan.TabStop = True
        rbnPerempuan.Text = "Perempuan"
        rbnPerempuan.UseVisualStyleBackColor = True
        ' 
        ' gbxKaedahBayaran
        ' 
        gbxKaedahBayaran.Controls.Add(rbnCashless)
        gbxKaedahBayaran.Controls.Add(rbnCash)
        gbxKaedahBayaran.Location = New Point(304, 303)
        gbxKaedahBayaran.Name = "gbxKaedahBayaran"
        gbxKaedahBayaran.Size = New Size(200, 100)
        gbxKaedahBayaran.TabIndex = 13
        gbxKaedahBayaran.TabStop = False
        gbxKaedahBayaran.Text = "Kaedah Bayaran"
        ' 
        ' rbnCashless
        ' 
        rbnCashless.AutoSize = True
        rbnCashless.Location = New Point(17, 64)
        rbnCashless.Name = "rbnCashless"
        rbnCashless.Size = New Size(70, 19)
        rbnCashless.TabIndex = 1
        rbnCashless.TabStop = True
        rbnCashless.Text = "Cashless"
        rbnCashless.UseVisualStyleBackColor = True
        ' 
        ' rbnCash
        ' 
        rbnCash.AutoSize = True
        rbnCash.Location = New Point(17, 33)
        rbnCash.Name = "rbnCash"
        rbnCash.Size = New Size(51, 19)
        rbnCash.TabIndex = 0
        rbnCash.TabStop = True
        rbnCash.Text = "Cash"
        rbnCash.UseVisualStyleBackColor = True
        ' 
        ' gbxPerisa
        ' 
        gbxPerisa.Controls.Add(cbxPisang)
        gbxPerisa.Controls.Add(cbxStrawberi)
        gbxPerisa.Controls.Add(cbxKopi)
        gbxPerisa.Controls.Add(cbxCoklat)
        gbxPerisa.Controls.Add(cbxMilo)
        gbxPerisa.Location = New Point(42, 459)
        gbxPerisa.Name = "gbxPerisa"
        gbxPerisa.Size = New Size(545, 82)
        gbxPerisa.TabIndex = 14
        gbxPerisa.TabStop = False
        gbxPerisa.Text = "Perisa"
        ' 
        ' cbxPisang
        ' 
        cbxPisang.AutoSize = True
        cbxPisang.Location = New Point(369, 39)
        cbxPisang.Name = "cbxPisang"
        cbxPisang.Size = New Size(61, 19)
        cbxPisang.TabIndex = 4
        cbxPisang.Text = "Pisang"
        cbxPisang.UseVisualStyleBackColor = True
        ' 
        ' cbxStrawberi
        ' 
        cbxStrawberi.AutoSize = True
        cbxStrawberi.Location = New Point(262, 39)
        cbxStrawberi.Name = "cbxStrawberi"
        cbxStrawberi.Size = New Size(75, 19)
        cbxStrawberi.TabIndex = 3
        cbxStrawberi.Text = "Strawberi"
        cbxStrawberi.UseVisualStyleBackColor = True
        ' 
        ' cbxKopi
        ' 
        cbxKopi.AutoSize = True
        cbxKopi.Location = New Point(206, 39)
        cbxKopi.Name = "cbxKopi"
        cbxKopi.Size = New Size(50, 19)
        cbxKopi.TabIndex = 2
        cbxKopi.Text = "Kopi"
        cbxKopi.UseVisualStyleBackColor = True
        ' 
        ' cbxCoklat
        ' 
        cbxCoklat.AutoSize = True
        cbxCoklat.Location = New Point(120, 39)
        cbxCoklat.Name = "cbxCoklat"
        cbxCoklat.Size = New Size(60, 19)
        cbxCoklat.TabIndex = 1
        cbxCoklat.Text = "Coklat"
        cbxCoklat.UseVisualStyleBackColor = True
        ' 
        ' cbxMilo
        ' 
        cbxMilo.AutoSize = True
        cbxMilo.Location = New Point(32, 39)
        cbxMilo.Name = "cbxMilo"
        cbxMilo.Size = New Size(50, 19)
        cbxMilo.TabIndex = 0
        cbxMilo.Text = "MIlo"
        cbxMilo.UseVisualStyleBackColor = True
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(838, 76)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(200, 23)
        dtpTarikh.TabIndex = 15
        ' 
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Location = New Point(736, 84)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(38, 15)
        lblTarikh.TabIndex = 16
        lblTarikh.Text = "Tarikh"
        ' 
        ' dgvTable
        ' 
        dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTable.Columns.AddRange(New DataGridViewColumn() {clmBil, clmNama, clmNoTel})
        dgvTable.Location = New Point(707, 166)
        dgvTable.Name = "dgvTable"
        dgvTable.Size = New Size(341, 150)
        dgvTable.TabIndex = 17
        ' 
        ' BtnCreate
        ' 
        BtnCreate.Location = New Point(617, 481)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(71, 36)
        BtnCreate.TabIndex = 18
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Location = New Point(736, 481)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(71, 36)
        BtnRead.TabIndex = 19
        BtnRead.Text = "Read"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(868, 481)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(71, 36)
        BtnUpdate.TabIndex = 20
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(1002, 481)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(71, 36)
        BtnDelete.TabIndex = 21
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' clmBil
        ' 
        clmBil.HeaderText = "Bil"
        clmBil.Name = "clmBil"
        ' 
        ' clmNama
        ' 
        clmNama.HeaderText = "Nama"
        clmNama.Name = "clmNama"
        ' 
        ' clmNoTel
        ' 
        clmNoTel.HeaderText = "No.Tel"
        clmNoTel.Name = "clmNoTel"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1102, 770)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnRead)
        Controls.Add(BtnCreate)
        Controls.Add(dgvTable)
        Controls.Add(lblTarikh)
        Controls.Add(dtpTarikh)
        Controls.Add(gbxPerisa)
        Controls.Add(gbxKaedahBayaran)
        Controls.Add(gbxJantina)
        Controls.Add(comNegeri)
        Controls.Add(txtAlamat)
        Controls.Add(txtNo)
        Controls.Add(txtNama)
        Controls.Add(lblNegeri)
        Controls.Add(lblAlamat)
        Controls.Add(lblNoTel)
        Controls.Add(lblNama)
        Controls.Add(lblMaklumatPelanggan)
        Name = "Form1"
        Text = "Form1"
        gbxJantina.ResumeLayout(False)
        gbxJantina.PerformLayout()
        gbxKaedahBayaran.ResumeLayout(False)
        gbxKaedahBayaran.PerformLayout()
        gbxPerisa.ResumeLayout(False)
        gbxPerisa.PerformLayout()
        CType(dgvTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMaklumatPelanggan As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNoTel As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents comNegeri As ComboBox
    Friend WithEvents rbnLelaki As RadioButton
    Friend WithEvents gbxJantina As GroupBox
    Friend WithEvents rbnPerempuan As RadioButton
    Friend WithEvents gbxKaedahBayaran As GroupBox
    Friend WithEvents rbnCashless As RadioButton
    Friend WithEvents rbnCash As RadioButton
    Friend WithEvents gbxPerisa As GroupBox
    Friend WithEvents cbxPisang As CheckBox
    Friend WithEvents cbxStrawberi As CheckBox
    Friend WithEvents cbxKopi As CheckBox
    Friend WithEvents cbxCoklat As CheckBox
    Friend WithEvents cbxMilo As CheckBox
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dgvTable As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents clmBil As DataGridViewTextBoxColumn
    Friend WithEvents clmNama As DataGridViewTextBoxColumn
    Friend WithEvents clmNoTel As DataGridViewTextBoxColumn

End Class
