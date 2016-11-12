Module CheckSort

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

End Module
