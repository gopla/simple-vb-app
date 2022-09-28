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
        Me.no_resi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.package_desc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sender_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sender_address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.receiver_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.receiver_address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.weight = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.TextBox()
        Me.dgv_paket = New System.Windows.Forms.DataGridView()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.label_id = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgv_paket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'no_resi
        '
        Me.no_resi.Location = New System.Drawing.Point(121, 26)
        Me.no_resi.Name = "no_resi"
        Me.no_resi.Size = New System.Drawing.Size(214, 23)
        Me.no_resi.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Resi"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(765, 114)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Tambah"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Deskripsi Paket"
        '
        'package_desc
        '
        Me.package_desc.Location = New System.Drawing.Point(121, 55)
        Me.package_desc.Multiline = True
        Me.package_desc.Name = "package_desc"
        Me.package_desc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.package_desc.Size = New System.Drawing.Size(214, 101)
        Me.package_desc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pengirim"
        '
        'sender_name
        '
        Me.sender_name.Location = New System.Drawing.Point(121, 162)
        Me.sender_name.Name = "sender_name"
        Me.sender_name.Size = New System.Drawing.Size(214, 23)
        Me.sender_name.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Alamat Pengirim"
        '
        'sender_address
        '
        Me.sender_address.Location = New System.Drawing.Point(121, 191)
        Me.sender_address.Name = "sender_address"
        Me.sender_address.Size = New System.Drawing.Size(214, 23)
        Me.sender_address.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(422, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Penerima"
        '
        'receiver_name
        '
        Me.receiver_name.Location = New System.Drawing.Point(523, 21)
        Me.receiver_name.Name = "receiver_name"
        Me.receiver_name.Size = New System.Drawing.Size(214, 23)
        Me.receiver_name.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Alamat Penerima"
        '
        'receiver_address
        '
        Me.receiver_address.Location = New System.Drawing.Point(523, 53)
        Me.receiver_address.Name = "receiver_address"
        Me.receiver_address.Size = New System.Drawing.Size(214, 23)
        Me.receiver_address.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(422, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Berat (kg)"
        '
        'weight
        '
        Me.weight.Location = New System.Drawing.Point(523, 104)
        Me.weight.Name = "weight"
        Me.weight.Size = New System.Drawing.Size(214, 23)
        Me.weight.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Harga"
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(523, 133)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(214, 23)
        Me.price.TabIndex = 15
        '
        'dgv_paket
        '
        Me.dgv_paket.AllowUserToAddRows = False
        Me.dgv_paket.BackgroundColor = System.Drawing.Color.White
        Me.dgv_paket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_paket.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_paket.Location = New System.Drawing.Point(12, 244)
        Me.dgv_paket.Name = "dgv_paket"
        Me.dgv_paket.RowTemplate.Height = 25
        Me.dgv_paket.Size = New System.Drawing.Size(1116, 232)
        Me.dgv_paket.TabIndex = 17
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(765, 85)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 18
        Me.btn_save.Text = "Simpan"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(846, 85)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 19
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(927, 85)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(75, 23)
        Me.btn_del.TabIndex = 20
        Me.btn_del.Text = "Hapus"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(846, 115)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Batal"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Location = New System.Drawing.Point(422, 165)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(41, 15)
        Me.label_id.TabIndex = 22
        Me.label_id.Text = "Label9"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label_id)
        Me.GroupBox1.Controls.Add(Me.package_desc)
        Me.GroupBox1.Controls.Add(Me.no_resi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.sender_name)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.price)
        Me.GroupBox1.Controls.Add(Me.sender_address)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.weight)
        Me.GroupBox1.Controls.Add(Me.receiver_name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.receiver_address)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 231)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_cari)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(765, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 66)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(64, 24)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(293, 23)
        Me.txt_cari.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "No Resi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 486)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv_paket)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_edit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Paket"
        CType(Me.dgv_paket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents no_resi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents package_desc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sender_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sender_address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents receiver_name As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents receiver_address As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents weight As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents price As TextBox
    Friend WithEvents dgv_paket As DataGridView
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents label_id As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents Label9 As Label
End Class
