Module HelperFunctions

    Function CheckSort(ByRef SortedArray() As Integer) As Boolean
        Dim a As Integer = UBound(SortedArray) - 1
        For i = 0 To a
            If SortedArray(i) > SortedArray(i + 1) Then
                MsgBox("ERROR: Array was not sorted")
                Return False
            Else
                Continue For
            End If
        Next
        Return True
    End Function

    Function maxIntLen(ByVal PassedArray() As Integer) As Integer
        Dim maxLength As Integer
        Dim len As Integer
        Dim i As Integer
        For i = 0 To UBound(PassedArray)
            If PassedArray(i) = 0 Then
                len = 1
            Else
                len = Math.Floor(Math.Log10(Math.Abs(PassedArray(i))))
            End If

            If len > maxLength Then
                maxLength = len
            End If
        Next
        Return maxLength
    End Function

End Module
