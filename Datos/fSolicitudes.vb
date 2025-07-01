Imports System.Data.SqlClient
Imports Entidades
Public Class fSolicitudes
    Inherits ConexionBD
    Public Function MostrarSolicitudes()
        Try
            conectar()
            cmd = New SqlCommand("mostrarSolicitudes")
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
    Public Function MostrarSolicitudesPorRolYArea(ByVal rol As String, Optional ByVal area As String = "") As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarSolicitudesPorRolYArea", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Rol", rol)

            If rol <> "Administrador" Then
                cmd.Parameters.AddWithValue("@Area", area)
            Else
                cmd.Parameters.AddWithValue("@Area", DBNull.Value)
            End If

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Error al mostrar solicitudes: " & ex.Message)
            Return Nothing

        End Try
        cnn.Close()
    End Function
    Public Function MostrarSolicitudesConResultados() As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarSolicitudesConResultados", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MsgBox("Error al mostrar solicitudes con resultados: " & ex.Message)
            Return Nothing

        End Try
        cnn.Close()
    End Function

    Public Function ObtenerSolicitudPorId(ByVal idSolicitud As Integer) As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("ObtenerSolicitudPorId", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdSolicitud", idSolicitud)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Error al obtener solicitud: " & ex.Message)
            Return Nothing

        End Try
        cnn.Close()
    End Function

    Public Function BuscarSolicitudes(columna As String, valor As String) As DataTable
        Try
            conectar()
            Dim consulta As String = $"SELECT * FROM Solicitudes WHERE {columna} LIKE @valor + '%'"
            Dim cmd As New SqlCommand(consulta, cnn)
            cmd.Parameters.AddWithValue("@valor", valor)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Error en búsqueda: " & ex.Message)
            Return Nothing

        End Try
        cnn.Close()
    End Function
    Public Function InsertarSolicitudes(ByVal insertSolicitud As Entidades.EntSolicitudes, ByRef idGenerado As Long) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("InsertarSolicitud", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@IdUsuario", insertSolicitud.gIdUsuario)
                .AddWithValue("@NumSolicitud", insertSolicitud.gNumSolicitud)
                .AddWithValue("@ApellidosNombres", insertSolicitud.gApellidosNombres)
                .AddWithValue("@DNI", insertSolicitud.gDNI)
                .AddWithValue("@Celular", insertSolicitud.gCelular)
                .AddWithValue("@Direccion", insertSolicitud.gDireccion)
                .AddWithValue("@TipoDocumento", insertSolicitud.gTipoDocumento)
                .AddWithValue("@Copias", insertSolicitud.gCopias)
                .AddWithValue("@Estado", insertSolicitud.gEstado)
                .AddWithValue("@FechaRegistro", insertSolicitud.gFechaRegistro)
                .Add("@IdSolicitud", SqlDbType.BigInt).Direction = ParameterDirection.Output

                If cmd.ExecuteNonQuery Then
                    idGenerado = Convert.ToInt64(cmd.Parameters("@IdSolicitud").Value)
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

    Public Function EditarSolicitud(ByVal updateSolicitud As Entidades.EntSolicitudes) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EditarSolicitud", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@IdSolicitud", updateSolicitud.gIdSolicitud)
                .AddWithValue("@ApellidosNombres", updateSolicitud.gApellidosNombres)
                .AddWithValue("@DNI", updateSolicitud.gDNI)
                .AddWithValue("@Direccion", updateSolicitud.gDireccion)
                .AddWithValue("@Celular", updateSolicitud.gCelular)
                .AddWithValue("@TipoDocumento", updateSolicitud.gTipoDocumento)
                .AddWithValue("@Copias", updateSolicitud.gCopias)
                .AddWithValue("@Estado", updateSolicitud.gEstado)

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
    Public Function EliminarSolicitud(ByVal deleteSolicitudes As Entidades.EntSolicitudes) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EliminarSolicitud")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdSolicitud", deleteSolicitudes.gIdusuario)

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
    Public Function InsertarYObtenerIdSolicitud(ByVal insertSolicitud As Entidades.EntSolicitudes) As Integer
        Dim idGenerado As Integer = -1
        Try
            conectar()
            cmd = New SqlCommand("InsertarSolicitud", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@IdUsuario", insertSolicitud.gIdUsuario)
                .AddWithValue("@NumSolicitud", insertSolicitud.gNumSolicitud)
                .AddWithValue("@ApellidosNombres", insertSolicitud.gApellidosNombres)
                .AddWithValue("@DNI", insertSolicitud.gDNI)
                .AddWithValue("@Celular", insertSolicitud.gCelular)
                .AddWithValue("@Direccion", insertSolicitud.gDireccion)
                .AddWithValue("@TipoDocumento", insertSolicitud.gTipoDocumento)
                .AddWithValue("@Copias", insertSolicitud.gCopias)
                .AddWithValue("@Estado", insertSolicitud.gEstado)
                .AddWithValue("@FechaRegistro", insertSolicitud.gFechaRegistro)

                ' Parámetro de salida
                .Add("@IdSolicitud", SqlDbType.Int).Direction = ParameterDirection.Output
            End With

            cmd.ExecuteNonQuery()

            ' Obtener el ID generado
            idGenerado = Convert.ToInt32(cmd.Parameters("@IdSolicitud").Value)

        Catch ex As Exception
            MsgBox("Error al insertar solicitud: " & ex.Message)
        Finally
            cnn.Close()
        End Try

        Return idGenerado
    End Function
End Class
