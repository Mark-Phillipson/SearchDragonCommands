Module Module1
    Private Declare Function GetForegroundWindow Lib "user32" () _
            As Long
    Private Declare Function GetWindowText Lib "user32" _
        Alias "GetWindowTextA" (ByVal hwnd As Long, _
           ByVal lpString As String, ByVal cch As Long) As Long

End Module
