Imports DotNetNuke.Entities
Imports DotNetNuke.Entities.Users
Imports DotNetNuke.Entities.Modules
Public Class viewstartupconfig
    Public Function setUserRoll(nowUser As UserInfo) As String

        Dim test As String() = nowUser.Roles

        Dim currRole As String = "-1"

        For Each i As String In test
            Dim roller As String = i.ToString

            If roller = "Administrators" Or roller = "kk_aj_superuser" Then
                currRole = 1
                Exit For
            End If
        Next
        Return currRole
    End Function

    Public Function getcurrentPageView(mid As Integer) As String
        Dim mc = New ModuleController()
        Dim myModule = mc.GetModule(mid)
        Dim title = myModule.Content
        Return title
    End Function
End Class
