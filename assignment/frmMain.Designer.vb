<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnKH = New System.Windows.Forms.Button()
        Me.btnSanPham = New System.Windows.Forms.Button()
        Me.btnQuanlyKH = New System.Windows.Forms.Button()
        Me.btnXemSP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnKH
        '
        Me.btnKH.BackgroundImage = CType(resources.GetObject("btnKH.BackgroundImage"), System.Drawing.Image)
        Me.btnKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKH.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKH.ForeColor = System.Drawing.SystemColors.Window
        Me.btnKH.Location = New System.Drawing.Point(369, 41)
        Me.btnKH.Name = "btnKH"
        Me.btnKH.Size = New System.Drawing.Size(193, 51)
        Me.btnKH.TabIndex = 1
        Me.btnKH.Text = "Cập Nhật Thông Tin Khách Hàng"
        Me.btnKH.UseVisualStyleBackColor = True
        '
        'btnSanPham
        '
        Me.btnSanPham.BackgroundImage = CType(resources.GetObject("btnSanPham.BackgroundImage"), System.Drawing.Image)
        Me.btnSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSanPham.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSanPham.ForeColor = System.Drawing.Color.Honeydew
        Me.btnSanPham.Location = New System.Drawing.Point(173, 301)
        Me.btnSanPham.Name = "btnSanPham"
        Me.btnSanPham.Size = New System.Drawing.Size(190, 48)
        Me.btnSanPham.TabIndex = 1
        Me.btnSanPham.Text = "Quản Lý Sản Phẩm"
        Me.btnSanPham.UseVisualStyleBackColor = True
        '
        'btnQuanlyKH
        '
        Me.btnQuanlyKH.BackgroundImage = CType(resources.GetObject("btnQuanlyKH.BackgroundImage"), System.Drawing.Image)
        Me.btnQuanlyKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuanlyKH.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuanlyKH.ForeColor = System.Drawing.SystemColors.Window
        Me.btnQuanlyKH.Location = New System.Drawing.Point(170, 41)
        Me.btnQuanlyKH.Name = "btnQuanlyKH"
        Me.btnQuanlyKH.Size = New System.Drawing.Size(193, 51)
        Me.btnQuanlyKH.TabIndex = 1
        Me.btnQuanlyKH.Text = "Quản Lý Khách Hàng"
        Me.btnQuanlyKH.UseVisualStyleBackColor = True
        '
        'btnXemSP
        '
        Me.btnXemSP.BackgroundImage = CType(resources.GetObject("btnXemSP.BackgroundImage"), System.Drawing.Image)
        Me.btnXemSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXemSP.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXemSP.ForeColor = System.Drawing.SystemColors.Window
        Me.btnXemSP.Location = New System.Drawing.Point(369, 299)
        Me.btnXemSP.Name = "btnXemSP"
        Me.btnXemSP.Size = New System.Drawing.Size(193, 50)
        Me.btnXemSP.TabIndex = 1
        Me.btnXemSP.Text = "Xem Sản phẩm"
        Me.btnXemSP.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(715, 402)
        Me.Controls.Add(Me.btnSanPham)
        Me.Controls.Add(Me.btnXemSP)
        Me.Controls.Add(Me.btnQuanlyKH)
        Me.Controls.Add(Me.btnKH)
        Me.Name = "frmMain"
        Me.Text = "Ứng Dụng Điện Toán Đám Mây "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnKH As Button
    Friend WithEvents btnSanPham As Button
    Friend WithEvents btnQuanlyKH As Button
    Friend WithEvents btnXemSP As Button
End Class
