Imports MySql.Data.MySqlClient

Module Koneksi
    Dim conn As New MySqlConnection("server=localhost; user=root; password=; database=lajulintasnusa;")
    Public dataReader As MySqlDataReader
    Public myDA As New MySqlDataAdapter
    Public sqlstr As String


    Public Function openConn() As MySqlConnection
        conn.Open()
        Return conn
    End Function

    Public Function closeConn() As MySqlConnection
        conn.Close()
        Return conn
    End Function

End Module
