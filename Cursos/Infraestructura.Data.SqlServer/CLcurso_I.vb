Imports Dominio.Core.Entidades
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class CLcurso_I
    'Dim miCurso As New Curso



    Dim oDataSet As New DataSet
    Dim oDataApadtere As New SqlDataAdapter
    Dim errorre As String

    Dim oConecion As New Conexion
    Dim oComando As New SqlCommand
    Dim conec As New SqlConnection


    Function listar() As DataSet
        


        oComando.CommandType = CommandType.StoredProcedure
        oComando.CommandText = "_spRead"
        oComando.Connection = oConecion.coneccion
        oDataApadtere.SelectCommand = oComando


        oDataSet.Clear()
        oConecion.coneccion.Open()
        oDataApadtere.Fill(oDataSet, "nombre")
        oConecion.coneccion.Close()



        Return oDataSet

    End Function


    Function Registrar(_nombre As String, _creaditos As Integer) As Boolean
        
        Dim resultado As Boolean = True

        Dim oConecion2 As New Conexion
        Try
            conec = oConecion2.coneccion
            Dim oComand As New SqlCommand
            oComand.CommandType = CommandType.StoredProcedure
            oComand.CommandText = "_spInsert"
            oComand.Connection = conec


            oComand.Parameters.Add(New SqlParameter("@Curso_nombre", SqlDbType.VarChar))
            oComand.Parameters.Add(New SqlParameter("@Curso_creditos", SqlDbType.Int))

            oComand.Parameters("@Curso_nombre").Value = _nombre
            oComand.Parameters("@Curso_creditos").Value = _creaditos
            'MessageBox.Show("nombre =" + _nombre.ToString() + " " + "creaditos =" + _creaditos.ToString())
            conec.Open()
            oComand.ExecuteNonQuery()

            resultado = True
        Catch ex As Exception
            errorre = ex.Message
            MessageBox.Show(errorre.ToString)
            resultado = False
            conec.Close()

        End Try

        Return resultado
    End Function


    Function Editar(_curso_id As Integer, _curso_nombre As String, _curso_creditos As Integer) As Boolean
        Dim res As Boolean = True

        Try
            conec = oConecion.coneccion
            Dim oComand As New SqlCommand
            oComand.CommandType = CommandType.StoredProcedure
            oComand.CommandText = "_spUpdate"
            oComand.Connection = conec


            oComand.Parameters.Add(New SqlParameter("@curso_id", SqlDbType.Int))
            oComand.Parameters.Add(New SqlParameter("@curso_nombre", SqlDbType.VarChar))
            oComand.Parameters.Add(New SqlParameter("@curso_creditos", SqlDbType.Int))

            oComand.Parameters("@curso_id").Value = _curso_id
            oComand.Parameters("@Curso_nombre").Value = _curso_nombre
            oComand.Parameters("@Curso_creditos").Value = _curso_creditos
            'MessageBox.Show("nombre =" + _nombre.ToString() + " " + "creaditos =" + _creaditos.ToString())
            conec.Open()
            oComand.ExecuteNonQuery()

            res = True
        Catch ex As Exception
            errorre = ex.Message
            MessageBox.Show(errorre.ToString)
            res = False
            conec.Close()

        End Try
        Return res

    End Function


    Function Eliminar(_curso_id As Integer) As Boolean
        Dim res As Boolean = True

        Try
            conec = oConecion.coneccion
            Dim oComand As New SqlCommand
            oComand.CommandType = CommandType.StoredProcedure
            oComand.CommandText = "_spDelete"
            oComand.Connection = conec


            oComand.Parameters.Add(New SqlParameter("@curso_id", SqlDbType.Int))
            

            oComand.Parameters("@curso_id").Value = _curso_id
            
            'MessageBox.Show("nombre =" + _nombre.ToString() + " " + "creaditos =" + _creaditos.ToString())
            conec.Open()
            oComand.ExecuteNonQuery()

            res = True
        Catch ex As Exception
            errorre = ex.Message
            MessageBox.Show(errorre.ToString)
            res = False
            conec.Close()

        End Try
        Return res
    End Function

End Class
