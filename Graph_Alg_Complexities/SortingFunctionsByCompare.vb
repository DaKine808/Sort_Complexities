Module SortingFunctionsByCompare

    'SORTING ALGORITHMS COUNTING COMPARES
    Function SSComparisons(ByRef PassedArray() As Integer)
        Dim ArrayToSort() As Integer = PassedArray
        Dim lastElement As Integer = UBound(ArrayToSort)
        Dim min As Integer
        Dim comparisons As Integer = 0
        Dim swaps As Integer = 0
        Dim tempInt As Integer

        'Sort ArrayToSort()
        For i = 0 To lastElement - 1
            min = i
            For j = i + 1 To lastElement
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

    Function InsertionComparisons(ByRef PassedArray() As Integer)
        Dim newArray() As Integer = {-9999}
        Dim a As Integer = UBound(newArray)
        Dim tempArray(UBound(PassedArray)) As Integer
        Dim v As Integer
        Dim j As Integer
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
    Function Partition1(ByVal subArray() As Integer, ByRef l As Integer, ByRef r As Integer, ByRef counter As Integer)
        Dim p As Integer = subArray(l)
        Dim i As Integer = l
        Dim j As Integer = r + 1
        Dim tempValue As Integer = 0

        Do Until i >= j
            i = i + 1
            Do Until subArray(i) >= p Or i = r
                counter = counter + 1
                'QuickComps = QuickComps + 1
                i = i + 1
            Loop
            j = j - 1
            Do Until subArray(j) <= p
                counter = counter + 1
                'QuickComps = QuickComps + 1
                j = j - 1
            Loop
            tempValue = subArray(i)
            subArray(i) = subArray(j)
            subArray(j) = tempValue
        Loop

        tempValue = subArray(i)
        subArray(i) = subArray(j)
        subArray(j) = tempValue

        tempValue = subArray(l)
        subArray(l) = subArray(j)
        subArray(j) = tempValue

        Return j
    End Function

    Function QuickComparisons(ByVal PassedArray() As Integer, ByRef l As Integer, ByRef r As Integer) As Integer
        Dim s As Integer = 0
        Dim counter As Integer = 0
        If l < r Then
            s = Partition1(PassedArray, l, r, counter)
            counter = counter + QuickComparisons(PassedArray, l, s - 1)
            counter = counter + QuickComparisons(PassedArray, s + 1, r)
        End If
        Return counter
    End Function

    Function MedianOfThreeComparisons(ByVal PassedArray() As Integer, ByRef l As Integer, ByRef r As Integer) As Integer
        Dim tempL As Integer = l
        Dim midIndex As Integer = Math.Ceiling((l + r) / 2)
        Dim tempR As Integer = r
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim z As Integer = 0
        Dim median As Integer = 0
        Dim tempVal As Integer = 0
        Dim counter As Integer = 0
        Dim s As Integer = 0

        If l < r Then
            x = PassedArray(l)
            y = PassedArray(midIndex)
            z = PassedArray(r)
            If x < y < z Then
                median = midIndex
            ElseIf x < z < y Then
                median = tempR
            ElseIf y < x < z Then
                median = tempL
            ElseIf y < z < x Then
                Median = tempR
            ElseIf z < y < x Then
                median = midIndex
            ElseIf z < x < y Then
                median = tempL
            End If

            tempVal = PassedArray(tempL)
            PassedArray(tempL) = PassedArray(median)
            PassedArray(median) = tempVal

            s = Partition1(PassedArray, l, r, counter)
            counter = counter + MedianOfThreeComparisons(PassedArray, l, s - 1)
            counter = counter + MedianOfThreeComparisons(PassedArray, s + 1, r)
        End If
        Return counter
    End Function

    Function BubbleComparisons(ByRef PassedArray() As Integer) As Integer
        Dim ArrayToSort() As Integer = PassedArray
        Dim swaps As Integer = 1
        Dim comparisons As Integer = 0
        Dim lastElement As Integer = UBound(PassedArray)
        Dim temp As Integer
        While (swaps > 0)
            swaps = 0
            For i = 0 To lastElement - 1
                comparisons += 1
                If ArrayToSort(i) > ArrayToSort(i + 1) Then
                    'comparisons += 1
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

    Function MergesortComps(ByRef PassedArray() As Integer) As Integer
        Dim aIndex As Integer = 0,
            bIndex As Integer = 0,
            cIndex As Integer = 0,
            counter As Integer = 0

        If PassedArray.Length > 1 Then
            Dim bEndIndex As Integer = Math.Floor(PassedArray.Length / 2) - 1,
                cEndIndex As Integer = Math.Ceiling(PassedArray.Length / 2) - 1
            Dim ArrayB(bEndIndex) As Integer 'If PassedArray were 99, bEndIndex would be 48, so ArrayB = [0-48]
            Dim ArrayC(cEndIndex) As Integer 'If PassedArray were 99, cEndIndex would be 49, so ArrayC = [0-49]

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

    Function MergesortCompsMerge(ByRef ArrayA() As Integer, ByRef ArrayB() As Integer, ByRef ArrayC() As Integer) As Integer
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
