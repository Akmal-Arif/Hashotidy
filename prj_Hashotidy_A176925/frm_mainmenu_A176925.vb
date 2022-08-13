Public Class frm_mainmenu_A176925
    Private Sub frm_mainmenu_A176925_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        frm_productlist_A176925.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_OrderList_A176925.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_stafflist_A176925.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customerlist_A176925.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_productdetails_Click(sender As Object, e As EventArgs) Handles btn_productdetails.Click
        frm_productdetail_A176925.Show()
        Me.Hide()
    End Sub
End Class