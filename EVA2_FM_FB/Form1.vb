Imports MySql.Data.MySqlClient

Public Class Form1
    Public conexion As MySqlConnection

    Public comunasDiccionario As New Dictionary(Of String, Integer)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
        LlenarComunas()
    End Sub

    Public Sub Conectar()
        Try
            conexion = New MySqlConnection("server=localhost; database=persona; user id=root; password=;")
            conexion.Open()
            MessageBox.Show("Conexión exitosa a MySQL")
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
        End Try
    End Sub


    Private Sub LlenarComunas()
        Try
            comunasDiccionario.Clear()
            cmbComunas.Items.Clear()

            Dim query As String = "SELECT ComunaID, NombreComuna FROM comuna"
            Dim cmd As New MySqlCommand(query, conexion)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim id As Integer = Convert.ToInt32(reader("ComunaID"))
                Dim nombre As String = reader("NombreComuna").ToString()


                comunasDiccionario(nombre) = id


                cmbComunas.Items.Add(nombre)
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar las comunas: " & ex.Message)
        End Try
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim rut As String = txtRut.Text.Trim()

        If String.IsNullOrEmpty(rut) Then
            MessageBox.Show("Por favor ingrese un RUT válido.")
            Return
        End If

        Try

            Dim query As String = "SELECT * FROM personas WHERE RUT = @RUT"
            Dim cmd As New MySqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@RUT", rut)


            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then

                txtNombres.Text = reader("Nombre").ToString()
                txtApellidos.Text = reader("Apellido").ToString()

                If reader("Sexo").ToString() = "M" Then
                    rbMasculino.Checked = True
                ElseIf reader("Sexo").ToString() = "F" Then
                    rbFemenino.Checked = True
                End If


                For Each item In cmbComunas.Items
                    If item.ComunaID.ToString() = reader("Comuna").ToString() Then
                        cmbComunas.SelectedItem = item
                        Exit For
                    End If
                Next

                txtCiudad.Text = reader("Ciudad").ToString()
                txtObservacion.Text = reader("Observacion").ToString()
            Else
                MessageBox.Show("No se encontró ninguna persona con ese RUT.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Conectar()

        Dim rut As String = txtRut.Text.Trim()
        Dim nombre As String = txtNombres.Text.Trim()
        Dim apellido As String = txtApellidos.Text.Trim()
        Dim sexo As String = If(rbMasculino.Checked, "M", If(rbFemenino.Checked, "F", ""))
        Dim ciudad As String = txtCiudad.Text.Trim()
        Dim observacion As String = txtObservacion.Text.Trim()

        If cmbComunas.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor seleccione una comuna.")
            Return
        End If

        Dim nombreComuna As String = cmbComunas.SelectedItem.ToString()
        Dim comunaID As Integer = comunasDiccionario(nombreComuna)

        Try
            Dim query As String = "INSERT INTO persona (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                                  "VALUES (@RUT, @Nombre, @Apellido, @Sexo, @Comuna, @Ciudad, @Observacion)"
            Dim cmd As New MySqlCommand(query, conexion)

            cmd.Parameters.AddWithValue("@RUT", rut)
            cmd.Parameters.AddWithValue("@Nombre", nombre)
            cmd.Parameters.AddWithValue("@Apellido", apellido)
            cmd.Parameters.AddWithValue("@Sexo", sexo)
            cmd.Parameters.AddWithValue("@Comuna", comunaID)
            cmd.Parameters.AddWithValue("@Ciudad", ciudad)
            cmd.Parameters.AddWithValue("@Observacion", observacion)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Datos guardados correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub


End Class
