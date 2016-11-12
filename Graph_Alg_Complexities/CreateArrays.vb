Module CreateArrays

    Function CreateRandomArray(ByVal i As Integer)
        Dim RandomArray(i) As Integer
        Dim rand As New Random
        For j = 0 To i
            RandomArray(j) = rand.Next(100)
        Next
        Return RandomArray
    End Function

    Function CreateIncreasingArray2(ByVal i As Integer)
        Dim IncreasingArray(i) As Integer
        Dim rand As New Random
        Dim multiplier As Integer = rand.Next(1, 23)
        For j = 0 To i
            IncreasingArray(j) = j * multiplier
        Next
        Return IncreasingArray
    End Function

    Function CreateDecreasingArray(ByVal i As Integer)
        Dim DecreasingArray(i) As Integer
        Dim rand As New Random
        Dim multiplier As Integer = rand.Next(1, 23)
        For j = 0 To i
            DecreasingArray(j) = (i - j) * multiplier
        Next
        Return DecreasingArray
    End Function

    Function CreateNearlySortedArray(ByVal i As Integer)
        Dim NearlySorted(i) As Integer
        Dim rand As New Random
        Dim multiplier As Integer = rand.Next(1, 15)
        Dim tempVal As Integer = 5
        For j = 0 To i
            NearlySorted(j) = j * multiplier
        Next
        tempVal = NearlySorted(i - 1)
        NearlySorted(i - 1) = NearlySorted(i)
        NearlySorted(i) = tempVal
        Return NearlySorted
    End Function

End Module
