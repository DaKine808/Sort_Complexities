Module HelperFunctions

    Function calcAverage(ByRef passedArray(,,) As Int64, ByRef sortIndex As Integer, ByRef metric As Integer) As Double
        Dim total As Int64 = 0
        For run = 0 To UBound(passedArray, 3)
            total = total + passedArray(sortIndex, metric, run)
        Next
        Return total / (UBound(passedArray, 3) + 1)
    End Function

    Function verify(ByRef sortedArray() As Int64, time As Long, sortName As String) As Long
        If CheckSort(sortedArray) = True Then
            Return time
        Else
            MsgBox(sortName & " ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

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
