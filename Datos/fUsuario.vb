Imports System.Data.SqlClient
Imports Entidades
Public Class fUsuario
    Inherits ConexionBD

    'Verifica si el usuario existe
    Public Function UsuarioExiste(usuario As String) As Boolean
        conectar()
        cmd = New SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario", cnn)
        cmd.Parameters.AddWithValue("@usuario", usuario)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    ' Verifica si el DNI ya existe
    Public Function DniExiste(dni As String) As Boolean
        conectar()
        cmd = New SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE DNI = @dni", cnn)
        cmd.Parameters.AddWithValue("@dni", dni)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function
    Public Function ValidarUsuario(ByVal validar As EntUsuario) As DataTable
        Try
            conectar()
            cmd = New SqlCommand("ValidarLogin")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Usuario", validar.gUsuario)
            cmd.Parameters.AddWithValue("@Contraseña", validar.gContraseña)

            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
        cnn.Close()
    End Function
    Public Function MostrarUsuario()
        Try
            conectar()
            cmd = New SqlCommand("MostrarUsuarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
        cnn.Close()
    End Function
    Public Function BuscarUsuarios(columna As String, valor As String) As DataTable
        Try
            conectar()
            Dim consulta As String = $"SELECT * FROM Usuarios WHERE {columna} LIKE @valor + '%'"
            Dim cmd As New SqlCommand(consulta, cnn)
            cmd.Parameters.AddWithValue("@valor", valor)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Error en la búsqueda de usuarios: " & ex.Message)
            Return Nothing
        Finally
            cnn.Close()
        End Try
    End Function

    Public Function InsertarUsuario(ByVal insertUser As Entidades.EntUsuario) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("InsertarUsuario", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters

                .AddWithValue("@Nombres", insertUser.gNombres)
                .AddWithValue("@ApellidoPaterno", insertUser.gApellidoPaterno)
                .AddWithValue("@ApellidoMaterno", insertUser.gApellidoMaterno)
                .AddWithValue("@DNI", insertUser.gDNI)
                .AddWithValue("@Sexo", insertUser.gSexo)
                .AddWithValue("@Usuario", insertUser.gUsuario)
                .AddWithValue("@Contraseña", insertUser.gContraseña)
                .AddWithValue("@Rol", insertUser.gRol)
                .AddWithValue("@Area", insertUser.gArea)
                .AddWithValue("@Activo", insertUser.gActivo)
                .AddWithValue("@FechaRegistro", insertUser.gFechaRegistro)

                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        cnn.Close()
    End Function

    Public Function EditarUsuario(ByVal updateUser As Entidades.EntUsuario) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EditarUsuario", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@IdUsuario", updateUser.gIdUsuario)
                .AddWithValue("@Nombres", updateUser.gNombres)
                .AddWithValue("@ApellidoPaterno", updateUser.gApellidoPaterno)
                .AddWithValue("@ApellidoMaterno", updateUser.gApellidoMaterno)
                .AddWithValue("@DNI", updateUser.gDNI)
                .AddWithValue("@Sexo", updateUser.gSexo)
                .AddWithValue("@Usuario", updateUser.gUsuario)
                .AddWithValue("@Contraseña", updateUser.gContraseña)
                .AddWithValue("@Rol", updateUser.gRol)
                .AddWithValue("@Area", updateUser.gArea)
                .AddWithValue("@Activo", updateUser.gActivo)


                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        cnn.Close()
    End Function
    Public Function EliminarUsuario(ByVal deleteUser As Entidades.EntUsuario) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EliminarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUsuario", deleteUser.gIdUsuario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        cnn.Close()
    End Function

End Class
