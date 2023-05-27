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
        ComboBox1 = New ComboBox()
        txtnama = New TextBox()
        Label1 = New Label()
        txttotal = New TextBox()
        txtjumlah = New TextBox()
        txtharga = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        proses = New Button()
        bersih = New Button()
        tutup = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(146, 83)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(146, 125)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(121, 23)
        txtnama.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 2
        Label1.Text = "Kode Barang    :"
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(146, 269)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(121, 23)
        txttotal.TabIndex = 3
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(146, 217)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(121, 23)
        txtjumlah.TabIndex = 4
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(146, 171)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(121, 23)
        txtharga.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nama Barang   :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(52, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 7
        Label3.Text = "Harga Barang   :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(52, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 8
        Label4.Text = "Jumlah Barang :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(52, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 15)
        Label5.TabIndex = 9
        Label5.Text = "Total Harga      :"
        ' 
        ' proses
        ' 
        proses.Location = New Point(50, 333)
        proses.Name = "proses"
        proses.Size = New Size(75, 23)
        proses.TabIndex = 10
        proses.Text = "Proses"
        proses.UseVisualStyleBackColor = True
        ' 
        ' bersih
        ' 
        bersih.Location = New Point(131, 333)
        bersih.Name = "bersih"
        bersih.Size = New Size(75, 23)
        bersih.TabIndex = 11
        bersih.Text = "Bersih"
        bersih.UseVisualStyleBackColor = True
        ' 
        ' tutup
        ' 
        tutup.Location = New Point(260, 333)
        tutup.Name = "tutup"
        tutup.Size = New Size(75, 23)
        tutup.TabIndex = 12
        tutup.Text = "Tutup"
        tutup.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(365, 374)
        Controls.Add(tutup)
        Controls.Add(bersih)
        Controls.Add(proses)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtharga)
        Controls.Add(txtjumlah)
        Controls.Add(txttotal)
        Controls.Add(Label1)
        Controls.Add(txtnama)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents proses As Button
    Friend WithEvents bersih As Button
    Friend WithEvents tutup As Button
End Class
