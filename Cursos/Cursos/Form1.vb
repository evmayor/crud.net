
Imports Infraestructura.Data.SqlServer
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_dgv()
        dise()
        limpiar()
    End Sub

    Sub cargar_dgv()
        Dim mi_curso_i As New CLcurso_I
        DGV_CURSO.DataSource = mi_curso_i.listar
        DGV_CURSO.DataMember = "nombre"
        DGV_CURSO.Location = New Point(10, 30)
    End Sub

    Sub dise()
        GB_NUEVO.Visible = False
    End Sub

    Sub eventos()
        limpiar()

        DGV_CURSO.Visible = True
        GB_NUEVO.Visible = False
        DGV_CURSO.Location = New Point(10, 30)
        DGV_CURSO.Size = New Size(492, 305)
    End Sub


    Sub ejecutar_guardar()
        Dim mi_curso_i As New CLcurso_I
        Dim nombre As String = txt_nombreCurso.Text
        Dim creaditos As Integer = nud_CreditosCurso.Value
        mi_curso_i.Registrar(nombre, creaditos)
        cargar_dgv()
    End Sub

    Sub ejecutar_editar()
        Dim mi_curso_i As New CLcurso_I
        Dim id As Integer = lbl_id.Text
        Dim nombre As String = txt_nombreCurso.Text
        Dim creaditos As Integer = nud_CreditosCurso.Value
        mi_curso_i.Editar(id, nombre, creaditos)
        cargar_dgv()
    End Sub

    Sub ejecutar_eliminar()
        Dim mi_curso_i As New CLcurso_I
        Dim id As Integer = lbl_id.Text
        Dim nombre As String = txt_nombreCurso.Text
        Dim creaditos As Integer = nud_CreditosCurso.Value
        mi_curso_i.Eliminar(id)
        cargar_dgv()
    End Sub

    Sub limpiar()
        txt_nombreCurso.Text = ""
        nud_CreditosCurso.Value = 0
    End Sub
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        btn_Editar.Visible = False
        btn_Guardar.Visible = True
        GB_NUEVO.Visible = True
        DGV_CURSO.Visible = False
        lbl_id.Text = ""
        limpiar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        lbl_id.Text = ""
        eventos()
        limpiar()
    End Sub




    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click

        ejecutar_guardar()
        eventos()
        limpiar()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        GB_NUEVO.Visible = True
        DGV_CURSO.Visible = False

        txt_nombreCurso.Text = DGV_CURSO("curso_nombre", DGV_CURSO.CurrentRow.Index).Value.ToString
        nud_CreditosCurso.Value = DGV_CURSO("curso_creditos", DGV_CURSO.CurrentRow.Index).Value
        lbl_id.Text = DGV_CURSO("curso_id", DGV_CURSO.CurrentRow.Index).Value.ToString
        GB_NUEVO.Text = "Editar Curso"

        btn_Guardar.Visible = False
        btn_Editar.Visible = True
        btn_Editar.Location = New Point(375, 85)

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click

        ejecutar_editar()
        eventos()
        limpiar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        Dim nomb As String = DGV_CURSO("curso_nombre", DGV_CURSO.CurrentRow.Index).Value.ToString
        Dim cre As Integer = DGV_CURSO("curso_creditos", DGV_CURSO.CurrentRow.Index).Value
        lbl_id.Text = DGV_CURSO("curso_id", DGV_CURSO.CurrentRow.Index).Value.ToString
        Dim mensaje As String = "Estas seguro de eliminar el curso " + nomb
        Dim result As Integer = MessageBox.Show(mensaje, "ADVERTENCIA", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("NADA SE ELIMINO")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("NADA SE ELIMINO")
        ElseIf result = DialogResult.Yes Then
            ejecutar_eliminar()
            MessageBox.Show("REGISTRO ELIMINADO")
        End If
        limpiar()
    End Sub
End Class
