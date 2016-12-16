Module HelperFunctions

    Function CheckSort(ByRef SortedArray() As Int64) As Boolean
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

    Function maxIntLen(ByVal PassedArray() As Int64) As Integer
        Dim maxInt As Integer
        Dim minInt As Integer

        maxInt = PassedArray.Max().ToString.Length
        minInt = Math.Abs(PassedArray.Min()).ToString.Length

        If minInt < maxInt Then
            Return maxInt
        Else
            Return minInt
        End If

    End Function

End Module
