<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_A176925
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_A176925))
        Me.btn_products = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_productdetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_products
        '
        Me.btn_products.Location = New System.Drawing.Point(12, 12)
        Me.btn_products.Name = "btn_products"
        Me.btn_products.Size = New System.Drawing.Size(146, 23)
        Me.btn_products.TabIndex = 1
        Me.btn_products.Text = "List Of Products"
        Me.btn_products.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Location = New System.Drawing.Point(12, 41)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(146, 23)
        Me.btn_order.TabIndex = 2
        Me.btn_order.Text = "Order History"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_staff
        '
        Me.btn_staff.Location = New System.Drawing.Point(12, 70)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(146, 23)
        Me.btn_staff.TabIndex = 3
        Me.btn_staff.Text = "Staff Employed"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.Location = New System.Drawing.Point(12, 99)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(146, 23)
        Me.btn_customer.TabIndex = 4
        Me.btn_customer.Text = "Customer History"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(723, 403)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(65, 35)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_productdetails
        '
        Me.btn_productdetails.Location = New System.Drawing.Point(13, 129)
        Me.btn_productdetails.Name = "btn_productdetails"
        Me.btn_productdetails.Size = New System.Drawing.Size(145, 23)
        Me.btn_productdetails.TabIndex = 6
        Me.btn_productdetails.Text = "Product Details"
        Me.btn_productdetails.UseVisualStyleBackColor = True
        '
        'frm_mainmenu_A176925
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.prj_Hashotidy_A176925.My.Resources.Resources.backimg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_productdetails)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_products)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_mainmenu_A176925"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_products As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_productdetails As Button
End Class
