﻿Public Class DanhsachkhamDTO
#Region "Fields"
    Private strMaDanhSach As String
    Private dateNgayKham As Date
#End Region
#Region "Methods"
    Public Sub New()

    End Sub
    Public Sub New(strMaDanhSach As String, dateNgayKham As Date)
        Me.strMaDanhSach = strMaDanhSach
        Me.dateNgayKham = dateNgayKham
    End Sub

#End Region
#Region "Property"
    Property MaDanhSach() As String
        Get
            Return strMaDanhSach
        End Get
        Set(ByVal Value As String)
            strMaDanhSach = Value
        End Set
    End Property
    Property NgayKham() As Date
        Get
            Return dateNgayKham
        End Get
        Set(ByVal Value As Date)
            dateNgayKham = Value
        End Set
    End Property

#End Region
End Class