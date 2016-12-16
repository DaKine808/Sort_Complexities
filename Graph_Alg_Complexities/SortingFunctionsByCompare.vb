Module SortingFunctionsByCompare

    'SORTING ALGORITHMS COUNTING COMPARES
    Function SSComparisons(ByRef PassedArray() As Int64)
        Dim ArrayToSort() As Int64 = PassedArray
        Dim lastIndex As Integer = UBound(ArrayToSort)
        Dim min As Integer 'Stores an index
        Dim comparisons As Integer = 0
        Dim swaps As Integer = 0
        Dim tempInt As Int64

        'Sort ArrayToSort()
        For i = 0 To lastIndex - 1
            min = i
            For j = i + 1 To lastIndex
                comparisons = comparisons + 1
                If ArrayToSort(j) < ArrayToSort(min) Then
                    min = j
                End If
            Next
            If Not i = min Then
                swaps = swaps + 1
                tempInt = ArrayToSort(i)
                ArrayToSort(i) = ArrayToSort(min)
                ArrayToSort(min) = tempInt
            End If
        Next

        If CheckSort(ArrayToSort) = True Then
            Return comparisons
        Else
            MsgBox("SSComparisons ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

    Function InsertionComparisons(ByRef PassedArray() As Int64)
        Dim newArray() As Int64 = {-9999}
        Dim tempArray(UBound(PassedArray)) As Int64
        Dim v As Int64
        Dim j As Integer 'Stores an index so it doesn't need to be Int64
        Dim comparisons As Integer = 0

        'Create a newArray with sentinel
        ReDim Preserve newArray(0 To UBound(PassedArray) + 1)
        PassedArray.CopyTo(newArray, 1)

        'Sort newArray
        For i = 1 To UBound(newArray)
            v = newArray(i)
            j = i - 1
            comparisons = comparisons + 1
            While Not (newArray(j) = -9999) And newArray(j) > v
                comparisons = comparisons + 1
                newArray(j + 1) = newArray(j)
                j = j - 1
            End While
            newArray(j + 1) = v
        Next

        'Copy all but the sentinel of newArray() to tempArray()
        Array.Copy(newArray, 1, tempArray, 0, UBound(newArray))

        'Check that newArray is sorted correctly
        If CheckSort(tempArray) = True Then
            Return comparisons
        Else
            MsgBox("InsertionComparisons ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function
   
    'Partition1 is used for both Quicksort and Median-of-3 sort
    Function Partition1(ByVal subArray() As Int64, ByRef leftIndex As Integer, ByRef rightIndex As Integer, ByRef counter As Integer)
        Dim p As Int64 = subArray(leftIndex)
        Dim i As Integer = leftIndex,
            j As Integer = rightIndex + 1,
            tempValue As Integer = 0

        Do Until i >= j
            i = i + 1
            Do Until subArray(i) >= p Or i = rightIndex
                counter = counter + 1
                i = i + 1
            Loop
            j = j - 1
            Do Until subArray(j) <= p
                counter = counter + 1
                j = j - 1
            Loop
            tempValue = subArray(i)
            subArray(i) = subArray(j)
            subArray(j) = tempValue
        Loop

        tempValue = subArray(i)
        subArray(i) = subArray(j)
        subArray(j) = tempValue

        tempValue = subArray(leftIndex)
        subArray(leftIndex) = subArray(j)
        subArray(j) = tempValue

        Return j
    End Function

    Function QuickComparisons(ByVal PassedArray() As Int64, ByRef l As Integer, ByRef r As Integer) As Integer
        Dim s As Integer = 0 'Stores an index so it doesn't need to be Int64
        Dim counter As Integer = 0
        If l < r Then
            s = Partition1(PassedArray, l, r, counter)
            counter = counter + QuickComparisons(PassedArray, l, s - 1)
            counter = counter + QuickComparisons(PassedArray, s + 1, r)
        End If
        Return counter
    End Function

    Function MedianOfThreeComparisons(ByVal PassedArray() As Int64, ByRef leftIndex As Integer, ByRef rightIndex As Integer) As Integer
        Dim midIndex As Integer = Math.Ceiling((leftIndex + rightIndex) / 2)
        Dim x As Int64 = 0,
            y As Int64 = 0,
            z As Int64 = 0
        Dim median As Integer = 0,
            tempVal As Integer = 0,
            counter As Integer = 0,
            s As Integer = 0

        If leftIndex < rightIndex Then
            Dim tempArray(3) As Int64
            x = PassedArray(leftIndex)
            y = PassedArray(midIndex)
            z = PassedArray(rightIndex)

            tempArray(0) = x
            tempArray(1) = y
            tempArray(2) = z
            Array.Sort(tempArray)
            If x = tempArray(1) Then
                median = leftIndex
            ElseIf y = tempArray(1) Then
                median = midIndex
            Else
                median = rightIndex
            End If

            tempVal = PassedArray(leftIndex)
            PassedArray(leftIndex) = PassedArray(median)
            PassedArray(median) = tempVal

            s = Partition1(PassedArray, leftIndex, rightIndex, counter)
            counter = counter + MedianOfThreeComparisons(PassedArray, leftIndex, s - 1)
            counter = counter + MedianOfThreeComparisons(PassedArray, s + 1, rightIndex)
        End If
        Return counter
    End Function

    Function BubbleComparisons(ByRef PassedArray() As Int64) As Integer
        Dim ArrayToSort() As Int64 = PassedArray
        Dim swaps As Integer = 1
        Dim comparisons As Integer = 0
        Dim lastElement As Integer = UBound(PassedArray)
        Dim temp As Int64
        While (swaps > 0)
            swaps = 0
            For i = 0 To lastElement - 1
                comparisons = comparisons + 1
                If ArrayToSort(i) > ArrayToSort(i + 1) Then
                    'comparisons = comparisons + 1
                    temp = ArrayToSort(i + 1)
                    ArrayToSort(i + 1) = ArrayToSort(i)
                    ArrayToSort(i) = temp
                    swaps += 1
                End If
            Next
        End While
        If CheckSort(ArrayToSort) = True Then
            Return comparisons
        Else
            MsgBox("BubbleComparisons ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

    Function MergesortComps(ByRef PassedArray() As Int64) As Integer
        Dim aIndex As Integer = 0,
            bIndex As Integer = 0,
            cIndex As Integer = 0,
            counter As Integer = 0

        If PassedArray.Length > 1 Then
            Dim bEndIndex As Integer = Math.Floor(PassedArray.Length / 2) - 1,
                cEndIndex As Integer = Math.Ceiling(PassedArray.Length / 2) - 1
            Dim ArrayB(bEndIndex) As Int64 'If PassedArray were 99, bEndIndex would be 48, so ArrayB = [0-48]
            Dim ArrayC(cEndIndex) As Int64 'If PassedArray were 99, cEndIndex would be 49, so ArrayC = [0-49]

            'copy a[0-48] to b[0-48]
            For bIndex = 0 To bEndIndex
                ArrayB(bIndex) = PassedArray(aIndex)
                aIndex = aIndex + 1
            Next

            'copy a[49-99] to c[0-49]
            For cIndex = 0 To cEndIndex
                ArrayC(cIndex) = PassedArray(aIndex)
                aIndex = aIndex + 1
            Next

            counter = counter + MergesortComps(ArrayB)
            counter = counter + MergesortComps(ArrayC)
            counter = counter + MergesortCompsMerge(PassedArray, ArrayB, ArrayC)

            'Else
            'Return counter
        End If
        Return counter
    End Function

    Function MergesortCompsMerge(ByRef ArrayA() As Int64, ByRef ArrayB() As Int64, ByRef ArrayC() As Int64) As Integer
        Dim aIndex As Integer = 0,
            bIndex As Integer = 0,
            cIndex As Integer = 0,
            counter As Integer = 0
        Dim aEnd = ArrayA.Length,
            bEnd = ArrayB.Length,
            cEnd = ArrayC.Length

        While bIndex < bEnd And cIndex < cEnd
            counter = counter + 1
            If ArrayB(bIndex) <= ArrayC(cIndex) Then
                ArrayA(aIndex) = ArrayB(bIndex)
                bIndex = bIndex + 1
            Else
                ArrayA(aIndex) = ArrayC(cIndex)
                cIndex = cIndex + 1
            End If
            aIndex = aIndex + 1
        End While

        'One of the arrays is empty so just copy the remaining elements of the
        'unempty array into ArrayA. Dont keep count because there are no
        'comparisons being made.
        If bIndex = bEnd Then
            While cIndex < cEnd
                ArrayA(aIndex) = ArrayC(cIndex)
                cIndex = cIndex + 1
                aIndex = aIndex + 1
            End While
        Else
            While bIndex < bEnd
                ArrayA(aIndex) = ArrayB(bIndex)
                bIndex = bIndex + 1
                aIndex = aIndex + 1
            End While
        End If
        Return counter
    End Function

    'BucketSort

End Module
