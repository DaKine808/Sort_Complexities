Module CreateArrays

    Dim rand As New Random

    Function CreateRandomArray(ByVal i As Integer) As Array
        Dim RandomArray(i) As Int64
        For j = 0 To i
            RandomArray(j) = rand.Next(Int32.MinValue, Int32.MaxValue)
        Next
        Return RandomArray
    End Function

    Function CreateIncreasingArray2(ByVal i As Integer)
        Dim IncreasingArray(i) As Int64
        Dim multiplier As Integer = rand.Next(999)
        For j = 0 To i
            IncreasingArray(j) = j * multiplier
        Next
        Return IncreasingArray
    End Function

    Function CreateDecreasingArray(ByVal i As Integer)
        Dim DecreasingArray(i) As Int64
        Dim multiplier As Integer = rand.Next(999)
        For j = 0 To i
            DecreasingArray(j) = (i - j) * multiplier
        Next
        Return DecreasingArray
    End Function

    Function CreateNearlySortedArray(ByVal i As Integer)
        Dim NearlySorted(i) As Int64
        Dim multiplier As Integer = rand.Next(999)
        Dim tempVal As Integer = 5
        For j = 0 To i
            NearlySorted(j) = j * multiplier
        Next

        If (i > 1) Then
            'use multiplier to store a random index
            multiplier = rand.Next(1, i)
        Else
            multiplier = 1
        End If
        tempVal = NearlySorted(multiplier)
        NearlySorted(multiplier - 1) = NearlySorted(multiplier)
        NearlySorted(multiplier) = tempVal

        Return NearlySorted
    End Function

End Module
