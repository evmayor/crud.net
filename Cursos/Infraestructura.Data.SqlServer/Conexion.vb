Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Conexion


    Function coneccion() As SqlConnection
        Dim oConnecion As New SqlConnection
        oConnecion.ConnectionString = "Data Source=SERVER;Initial Catalog=Ejemplo;User ID=sa;Password=12345678"
        Return oConnecion
    End Function


End Class
