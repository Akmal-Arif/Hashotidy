Public Class frm_productdetail_A176925
    Private Sub frm_productdetail_A176925_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A176925"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_id.DataSource = mydatatable
        cmb_id.DisplayMember = "FLD_PRODUCT_ID"
        refresh_text(cmb_id.Text)
    End Sub
    Private Sub refresh_text(id As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176925 WHERE FLD_PRODUCT_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_colour.Text = mydatatable.Rows(0).Item("FLD_COLOUR")
        txt_material.Text = mydatatable.Rows(0).Item("FLD_MATERIAL")
        txt_purpose.Text = mydatatable.Rows(0).Item("FLD_PURPOSE")
        pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
    End Sub
    Private Sub cmb_id_DropDownClosed(sender As Object, e As EventArgs) Handles cmb_id.DropDownClosed
        refresh_text(cmb_id.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A176925.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

End Class