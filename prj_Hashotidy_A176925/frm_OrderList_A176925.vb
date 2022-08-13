Public Class frm_OrderList_A176925
    Private Sub frm_OrderList_A176925_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		refresh_grid()
	End Sub

	Private Sub refresh_grid()
		'Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_Hashotidy_A176925.accdb;Persist Security Info=False;"
		Dim mysql As String = "SELECT * FROM TBL_ORDER_A176925"
		Dim mydatatable As New DataTable
		Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
		myreader.Fill(mydatatable)
		grd_order.DataSource = mydatatable
	End Sub
	Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
		frm_mainmenu_A176925.Show()
		Me.Hide()
	End Sub

	Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
		End
	End Sub
End Class