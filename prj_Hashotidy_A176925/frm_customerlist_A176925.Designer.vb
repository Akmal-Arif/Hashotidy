<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerlist_A176925
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customerlist_A176925))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(364, 31)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(70, 13)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Customer List"
        '
        'grd_customer
        '
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(39, 47)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.Size = New System.Drawing.Size(729, 318)
        Me.grd_customer.TabIndex = 1
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(693, 371)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(693, 400)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_customerlist_A176925
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.prj_Hashotidy_A176925.My.Resources.Resources.backimg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_customerlist_A176925"
        Me.Text = "Customer List"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
End Class
