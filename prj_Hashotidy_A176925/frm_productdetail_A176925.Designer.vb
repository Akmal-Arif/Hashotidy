<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_productdetail_A176925
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productdetail_A176925))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_colour = New System.Windows.Forms.TextBox()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.txt_purpose = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_choose = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_colour = New System.Windows.Forms.Label()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.lbl_purpose = New System.Windows.Forms.Label()
        Me.cmb_id = New System.Windows.Forms.ComboBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(13, 13)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(81, 13)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Product's Detail"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(92, 89)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 3
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(92, 112)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 4
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(92, 134)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(100, 20)
        Me.txt_type.TabIndex = 5
        '
        'txt_colour
        '
        Me.txt_colour.Location = New System.Drawing.Point(92, 156)
        Me.txt_colour.Name = "txt_colour"
        Me.txt_colour.Size = New System.Drawing.Size(100, 20)
        Me.txt_colour.TabIndex = 6
        '
        'txt_material
        '
        Me.txt_material.Location = New System.Drawing.Point(92, 179)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(100, 20)
        Me.txt_material.TabIndex = 7
        '
        'txt_purpose
        '
        Me.txt_purpose.Location = New System.Drawing.Point(92, 202)
        Me.txt_purpose.Name = "txt_purpose"
        Me.txt_purpose.Size = New System.Drawing.Size(100, 20)
        Me.txt_purpose.TabIndex = 8
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(198, 38)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(214, 184)
        Me.pic_product.TabIndex = 9
        Me.pic_product.TabStop = False
        '
        'lbl_choose
        '
        Me.lbl_choose.Location = New System.Drawing.Point(13, 38)
        Me.lbl_choose.Name = "lbl_choose"
        Me.lbl_choose.Size = New System.Drawing.Size(73, 26)
        Me.lbl_choose.TabIndex = 10
        Me.lbl_choose.Text = "Choose Your Product ID:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(13, 92)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(38, 13)
        Me.lbl_name.TabIndex = 12
        Me.lbl_name.Text = "Name:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(13, 115)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(57, 13)
        Me.lbl_price.TabIndex = 13
        Me.lbl_price.Text = "Price(RM):"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(13, 137)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(34, 13)
        Me.lbl_type.TabIndex = 14
        Me.lbl_type.Text = "Type:"
        '
        'lbl_colour
        '
        Me.lbl_colour.AutoSize = True
        Me.lbl_colour.Location = New System.Drawing.Point(13, 159)
        Me.lbl_colour.Name = "lbl_colour"
        Me.lbl_colour.Size = New System.Drawing.Size(40, 13)
        Me.lbl_colour.TabIndex = 15
        Me.lbl_colour.Text = "Colour:"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Location = New System.Drawing.Point(13, 182)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(47, 13)
        Me.lbl_material.TabIndex = 16
        Me.lbl_material.Text = "Material:"
        '
        'lbl_purpose
        '
        Me.lbl_purpose.AutoSize = True
        Me.lbl_purpose.Location = New System.Drawing.Point(13, 205)
        Me.lbl_purpose.Name = "lbl_purpose"
        Me.lbl_purpose.Size = New System.Drawing.Size(49, 13)
        Me.lbl_purpose.TabIndex = 17
        Me.lbl_purpose.Text = "Purpose:"
        '
        'cmb_id
        '
        Me.cmb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_id.FormattingEnabled = True
        Me.cmb_id.Location = New System.Drawing.Point(92, 41)
        Me.cmb_id.Name = "cmb_id"
        Me.cmb_id.Size = New System.Drawing.Size(100, 21)
        Me.cmb_id.TabIndex = 18
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(693, 371)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 19
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(693, 400)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 20
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(13, 70)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(61, 13)
        Me.lbl_id.TabIndex = 11
        Me.lbl_id.Text = "Product ID:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(92, 67)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 2
        '
        'frm_productdetail_A176925
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.cmb_id)
        Me.Controls.Add(Me.lbl_purpose)
        Me.Controls.Add(Me.lbl_material)
        Me.Controls.Add(Me.lbl_colour)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_choose)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_purpose)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.txt_colour)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_productdetail_A176925"
        Me.Text = "Product's Detail"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_colour As TextBox
    Friend WithEvents txt_material As TextBox
    Friend WithEvents txt_purpose As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_choose As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_colour As Label
    Friend WithEvents lbl_material As Label
    Friend WithEvents lbl_purpose As Label
    Friend WithEvents cmb_id As ComboBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
End Class
