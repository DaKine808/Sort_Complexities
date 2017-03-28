Module SortingFunctionsByCompare

    'SORTING ALGORITHMS COUNTING COMPARES
    Function SSComparisons(ByVal passedArray() As Int64, ByRef comparisons As Integer) As Long
        Dim lastIndex As Integer = UBound(passedArray)
        Dim min As Integer 'Stores an index
        Dim swaps As Integer = 0
        Dim tempInt As Int64
        Dim startTicks,
            endTicks,
            totalTime As Long

        Dim arrayCopy(UBound(passedArray)) As Int64

        passedArray.CopyTo(arrayCopy, 0)

        'Sort ArrayToSort()
        'startTicks = DateTime.UtcNow.Ticks
        startTicks = Environment.TickCount
        For i = 0 To lastIndex - 1
            min = i
            For j = i + 1 To lastIndex
                comparisons = comparisons + 1
                If arrayCopy(j) < arrayCopy(min) Then
                    min = j
                End If
            Next
            If Not i = min Then
                swaps = swaps + 1
                tempInt = arrayCopy(i)
                arrayCopy(i) = arrayCopy(min)
                arrayCopy(min) = tempInt
            End If
        Next
        'endTicks = DateTime.UtcNow.Ticks
        endTicks = Environment.TickCount
        totalTime = endTicks - startTicks

        Return verify(arrayCopy, totalTime, "SSComparisons")
    End Function

    Function InsertionComparisons(ByVal passedArray() As Int64, ByRef comparisons As Integer) As Long
        'Create a newArray with sentinel
        Dim newArray(UBound(passedArray) + 1) As Int64
        newArray(0) = Int64.MinValue
        passedArray.CopyTo(newArray, 1)
        Dim v As Int64
        Dim j As Integer 'Stores an index so it doesn't need to be Int64
        Dim startTicks,
            endTicks,
            totalTime As Long

        startTicks = Environment.TickCount
        'Sort newArray
        For i = 1 To UBound(newArray)
            v = newArray(i)
            j = i - 1
            comparisons = comparisons + 1
            While Not (newArray(j) = Int64.MinValue) And newArray(j) > v
                comparisons = comparisons + 1
                newArray(j + 1) = newArray(j)
                j = j - 1
            End While
            newArray(j + 1) = v
        Next
        endTicks = Environment.TickCount
        totalTime = endTicks - startTicks

        'Copy all but the sentinel of newArray() to tempArray()
        Array.Copy(newArray, 1, newArray, 0, UBound(newArray))
        ReDim Preserve newArray(UBound(newArray) - 1)

        Return verify(newArray, totalTime, "InsertionComparisons")
    End Function
   
    'Partition1 is used for both Quicksort and Median-of-3 sort
    Function Partition1(ByVal subArray() As Int64, ByRef leftIndex As Integer, ByRef rightIndex As Integer, ByRef comparisons As Integer)
        Dim p As Int64 = subArray(leftIndex)
        Dim i As Integer = leftIndex,
            j As Integer = rightIndex + 1,
            tempValue As Integer = 0

        Do Until i >= j
            i = i + 1
            Do Until subArray(i) >= p Or i = rightIndex
                comparisons = comparisons + 1
                i = i + 1
            Loop
            j = j - 1
            Do Until subArray(j) <= p
                comparisons = comparisons + 1
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

    Function QuickSortWrapper(ByVal passedArray() As Int64, ByRef comparisons As Integer) As Long
        Dim startTicks,
            endTicks,
            totalTime As Long
        Dim arrayCopy(UBound(passedArray)) As Int64

        passedArray.CopyTo(arrayCopy, 0)

        startTicks = Environment.TickCount
        QuickComparisons(arrayCopy, 0, UBound(arrayCopy), comparisons)
        endTicks = Environment.TickCount
        totalTime = endTicks - startTicks

        Return verify(arrayCopy, totalTime, "QuickSort")
    End Function

    Sub QuickComparisons(ByRef passedArray() As Int64, ByRef leftIndex As Integer, ByRef rightIndex As Integer, ByRef comparisons As Integer)
        Dim s As Integer = 0 'Stores an index so it doesn't need to be Int64
        If leftIndex < rightIndex Then
            s = Partition1(passedArray, leftIndex, rightIndex, comparisons)
            QuickComparisons(passedArray, leftIndex, s - 1, comparisons)
            QuickComparisons(passedArray, s + 1, rightIndex, comparisons)
        End If
    End Sub

    Function MedianOfThreeWrapper(ByVal passedArray() As Int64, ByRef comparisons As Integer) As Long
        Dim startTicks,
            endTicks,
            totalTime As Long

        Dim arrayCopy(UBound(passedArray)) As Int64

        passedArray.CopyTo(arrayCopy, 0)

        startTicks = Environment.TickCount
        MedianOfThreeComparisons(arrayCopy, 0, UBound(arrayCopy), comparisons)
        endTicks = Environment.TickCount
        totalTime = endTicks - startTicks

        Return verify(arrayCopy, totalTime, "Median-of-3")
    End Function

    Sub MedianOfThreeComparisons(ByRef passedArray() As Int64, ByRef leftIndex As Integer, ByRef rightIndex As Integer, ByRef comparisons As Integer)
        If leftIndex < rightIndex Then
            Dim midIndex As Integer = Math.Ceiling((leftIndex + rightIndex) / 2)
            Dim x As Int64 = passedArray(leftIndex),
                y As Int64 = passedArray(midIndex),
                z As Int64 = passedArray(rightIndex)
            Dim median As Integer = 0,
                tempVal As Int64 = 0,
                s As Integer = 0
            Dim tempArray(3) As Int64

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

            tempVal = passedArray(leftIndex)
            passedArray(leftIndex) = passedArray(median)
            passedArray(median) = tempVal

            s = Partition1(passedArray, leftIndex, rightIndex, comparisons)
            MedianOfThreeComparisons(passedArray, leftIndex, s - 1, comparisons)
            MedianOfThreeComparisons(passedArray, s + 1, rightIndex, comparisons)
        End If
    End Sub

    Function BubbleComparisons(ByVal passedArray() As Int64, ByRef comparisons As Integer) As Long
        Dim swaps As Integer = 1
        Dim lastElement As Integer = UBound(passedArray)
        Dim temp As Int64
        Dim startTicks,
            endTicks,
            totalTime As Long

        Dim arrayCopy(UBound(passedArray)) As Int64

        passedArray.CopyTo(arrayCopy, 0)

        startTicks = Environment.TickCount
        While (swaps > 0)
            swaps = 0
            For i = 0 To lastElement - 1
                comparisons = comparisons + 1
                If arrayCopy(i) > arrayCopy(i + 1) Then
                    temp = arrayCopy(i + 1)
                    arrayCopy(i + 1) = arrayCopy(i)
                    arrayCopy(i) = temp
                    swaps += 1
                End If
            Next
        End While
        endTicks = Environment.TickCount
        totalTime = endTicks - startTicks

        Return verify(arrayCopy, totalTime, "BubbleComparisons")
    End Function

    Function MergeSortWrapper(ByVal passedArray() As Int64, ByRef comparisons As Integer) As Long
        Dim startTick,
            endTick,
            totalTime As Long

        Dim arrayCopy(UBound(passedArray)) As Int64

        passedArray.CopyTo(arrayCopy, 0)

        startTick = Environment.TickCount
        MergesortComps(arrayCopy, comparisons)
        endTick = Environment.TickCount
        totalTime = endTick - startTick

        Return verify(arrayCopy, totalTime, "MergeSort")
    End Function

    Sub MergesortComps(ByRef passedArray() As Int64, ByRef comparisons As Integer)
        If passedArray.Length > 1 Then
            Dim bEndIndex As Integer = (passedArray.Length \ 2) - 1,
                cEndIndex As Integer

            'if the length is even
            If passedArray.Length Mod 2 = 0 Then
                cEndIndex = bEndIndex
            Else
                cEndIndex = bEndIndex + 1
            End If

            Dim ArrayB(bEndIndex) As Int64 'If PassedArray.length were 99 (0-98), bEndIndex would be 48, so ArrayB is (0-48)
            Dim ArrayC(cEndIndex) As Int64 'If PassedArray.length were 99 (0-98), cEndIndex would be 49, so ArrayC is (0-49)

            'copy a[0-48] to b[0-48]
            Array.Copy(passedArray, 0, ArrayB, 0, UBound(ArrayB))

            'copy a[49-99] to c[0-49]
            Array.Copy(passedArray, ArrayB.Length, ArrayC, 0, UBound(ArrayC))

            MergesortComps(ArrayB, comparisons)
            MergesortComps(ArrayC, comparisons)
            MergesortCompsMerge(passedArray, ArrayB, ArrayC, comparisons)
        End If
    End Sub

    Sub MergesortCompsMerge(ByRef ArrayA() As Int64, ByRef ArrayB() As Int64, ByRef ArrayC() As Int64, ByRef comparisons As Integer)
        Dim aIndex As Integer = 0,
            bIndex As Integer = 0,
            cIndex As Integer = 0

        Dim aEnd = ArrayA.Length,
            bEnd = ArrayB.Length,
            cEnd = ArrayC.Length

        While bIndex < bEnd And cIndex < cEnd
            comparisons = comparisons + 1
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
    End Sub

    'Bucketsort only works with positive numbers at the moment
    Function BucketSortComp(ByVal passedArray() As Int64, ByRef comparisons As Integer) As Long
        Dim buckets(9) As List(Of Int64)

        Dim tempIndex As Integer,
            arrayIndex As Integer,
            bucketIndex As Integer

        Dim maxLen As Integer = maxIntLen(passedArray)
        Dim exp As Integer
        Dim digit As Int64 = 1
        Dim temp As Int64 = 0
        Dim valAtIndex As Int64 = 0
        Dim startTick,
            endTick,
            totalTime As Long

        Dim arrayCopy(UBound(passedArray)) As Int64

        passedArray.CopyTo(arrayCopy, 0)

        buckets.Initialize()
        For i As Integer = 0 To 9
            buckets(i) = New List(Of Int64)
        Next

        startTick = Environment.TickCount

        For exp = 0 To maxLen
            'Put numbers into respective buckets
            For arrayIndex = 0 To UBound(arrayCopy)
                valAtIndex = arrayCopy(arrayIndex)
                temp = (valAtIndex \ digit) Mod 10
                buckets(temp).Add(valAtIndex)
            Next
            arrayIndex = 0
            'Put bucket contents back into array
            For bucketIndex = 0 To UBound(buckets)
                tempIndex = buckets(bucketIndex).Count
                buckets(bucketIndex).ToArray.CopyTo(arrayCopy, arrayIndex)
                arrayIndex = arrayIndex + tempIndex
                tempIndex = 0
                buckets(bucketIndex).RemoveRange(0, buckets(bucketIndex).Count)
            Next
            digit = digit * 10
        Next

        endTick = Environment.TickCount
        totalTime = endTick - startTick

        Return verify(arrayCopy, totalTime, "BucketSortTicks")
    End Function

    Function VBSortComps(ByVal passedArray() As Int64, ByRef comparisons As Integer) As Long
        Dim startTick,
            endTick,
            totalTime As Long

        Dim arrayCopy(UBound(passedArray)) As Int64

        passedArray.CopyTo(arrayCopy, 0)

        startTick = Environment.TickCount
        Array.Sort(arrayCopy)
        endTick = Environment.TickCount
        totalTime = endTick - startTick

        Return verify(arrayCopy, totalTime, "VBSort")
    End Function
End Module
