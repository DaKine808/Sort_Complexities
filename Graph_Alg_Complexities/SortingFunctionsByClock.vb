Module SortingFunctionsByClock

    'SORTING ALGORITHMS COUNTING TICKS
    Function SSTicks(ByRef PassedArray() As Integer) As Long
        Dim ArrayToSort() As Integer = PassedArray
        Dim lastElement As Integer = UBound(ArrayToSort)
        Dim min As Integer
        Dim comparisons As Integer = 0
        Dim tempInt As Integer
        Dim StartTicks As Long
        Dim EndTicks As Long

        'Sort(ArrayToSort())
        StartTicks = Environment.TickCount
        For i = 0 To lastElement - 1
            min = i
            For j = i + 1 To lastElement
                If ArrayToSort(j) < ArrayToSort(min) Then
                    min = j
                End If
            Next
            tempInt = ArrayToSort(i)
            ArrayToSort(i) = ArrayToSort(min)
            ArrayToSort(min) = tempInt
        Next
        EndTicks = Environment.TickCount

        'Check that ArrayToSort() is sorted properly
        If CheckSort(ArrayToSort) = True Then
            Return (EndTicks - StartTicks)
        Else
            MsgBox("SSTicks ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

    Function InsertionTicks(ByRef PassedArray() As Integer) As Long
        Dim newArray() As Integer = {-9999}
        Dim a As Integer = UBound(newArray)
        Dim tempArray(UBound(PassedArray)) As Integer
        Dim v As Integer
        Dim j As Integer
        Dim StartTicks As Long
        Dim EndTicks As Long

        'Create a newArray with sentinel
        ReDim Preserve newArray(0 To UBound(PassedArray) + 1)
        PassedArray.CopyTo(newArray, 1)

        'Sort newArray
        StartTicks = Environment.TickCount
        For i = 1 To UBound(newArray)
            v = newArray(i)
            j = i - 1
            While Not (newArray(j) = -9999) And newArray(j) > v
                newArray(j + 1) = newArray(j)
                j = j - 1
            End While
            newArray(j + 1) = v
        Next
        EndTicks = Environment.TickCount

        'Copy all but the sentinel of newArray() to tempArray()
        Array.Copy(newArray, 1, tempArray, 0, UBound(newArray))

        'Check that newArray is sorted correctly
        If CheckSort(tempArray) = True Then
            Return (EndTicks - StartTicks)
        Else
            MsgBox("InsertionTicks ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

    'Partition2 is used for both Quicksort and Median-of-3 sort
    Function Partition2(ByVal subArray() As Integer, ByRef l As Integer, ByRef r As Integer)
        Dim p As Integer = subArray(l)
        Dim i As Integer = l
        Dim j As Integer = r + 1
        Dim tempValue As Integer = 0

        Do Until i >= j
            i = i + 1
            Do Until subArray(i) >= p Or i = r
                i = i + 1
            Loop
            j = j - 1
            Do Until subArray(j) <= p
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

    Sub QuickTicks(ByVal PassedArray() As Integer, ByRef l As Integer, ByRef r As Integer)
        Dim s As Integer

        If l < r Then
            s = Partition2(PassedArray, l, r)
            QuickTicks(PassedArray, l, s - 1)
            QuickTicks(PassedArray, s + 1, r)
        End If
    End Sub

    Sub MedianQuickTicks(ByVal PassedArray() As Integer, ByVal l As Integer, ByRef r As Integer)
        Dim a As Integer = l
        Dim b As Integer = Math.Ceiling((l + r) / 2)
        Dim c As Integer = r
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim Median As Integer
        Dim tempVal As Integer
        Dim s As Integer

        If l < r Then
            x = PassedArray(l)
            y = PassedArray(b)
            z = PassedArray(r)
            If x < y < z Then
                Median = b
            ElseIf x < z < y Then
                Median = c
            ElseIf y < x < z Then
                Median = a
            ElseIf y < z < x Then
                Median = c
            ElseIf z < y < x Then
                Median = b
            ElseIf z < x < y Then
                Median = a
            End If

            tempVal = PassedArray(a)
            PassedArray(a) = PassedArray(Median)
            PassedArray(Median) = tempVal

            s = Partition2(PassedArray, l, r)
            MedianQuickTicks(PassedArray, l, s - 1)
            MedianQuickTicks(PassedArray, s + 1, r)
        End If
    End Sub

    Function BubbleTicks(ByRef PassedArray() As Integer) As Long
        Dim ArrayToSort() As Integer = PassedArray
        Dim swaps As Integer = 1
        Dim lastElement As Integer = UBound(PassedArray)
        Dim temp As Integer
        Dim StartTicks As Long
        Dim EndTicks As Long

        StartTicks = Environment.TickCount
        While (swaps > 0)
            swaps = 0
            For i = 0 To lastElement - 1
                If ArrayToSort(i) > ArrayToSort(i + 1) Then
                    temp = ArrayToSort(i + 1)
                    ArrayToSort(i + 1) = ArrayToSort(i)
                    ArrayToSort(i) = temp
                    swaps += 1
                End If
            Next
        End While
        EndTicks = Environment.TickCount

        If CheckSort(ArrayToSort) = True Then
            Return (EndTicks - StartTicks)
        Else
            MsgBox("BubbleTicks ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

    Sub MergesortTicks(ByRef PassedArray() As Integer)
        Dim aIndex As Integer = 0,
            bIndex As Integer = 0,
            cIndex As Integer = 0

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

            MergesortTicks(ArrayB)
            MergesortTicks(ArrayC)
            MergesortTicksMerge(PassedArray, ArrayB, ArrayC)

        Else
            Return
        End If

    End Sub

    Sub MergesortTicksMerge(ByRef ArrayA() As Integer, ByRef ArrayB() As Integer, ByRef ArrayC() As Integer)
        Dim aIndex As Integer = 0,
            bIndex As Integer = 0,
            cIndex As Integer = 0
        Dim aEnd = ArrayA.Length,
            bEnd = ArrayB.Length,
            cEnd = ArrayC.Length

        While bIndex < bEnd And cIndex < cEnd
            If ArrayB(bIndex) <= ArrayC(cIndex) Then
                ArrayA(aIndex) = ArrayB(bIndex)
                bIndex = bIndex + 1
            Else
                ArrayA(aIndex) = ArrayC(cIndex)
                cIndex = cIndex + 1
            End If
            aIndex = aIndex + 1
        End While

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

    Function BucketSort(ByRef PassedArray() As Integer) As Long
        Dim buckets(9) As List(Of Integer)

        Dim tempIndex As Integer,
            arrayIndex As Integer,
            bucketIndex As Integer

        Dim maxLen = maxIntLen(PassedArray)
        Dim exp As Integer
        Dim digit As Integer = 1
        Dim temp As Integer = 0
        Dim valAtIndex As Integer = 0
        Dim startTick As Long,
            endTick As Long

        buckets.Initialize()
        For i As Integer = 0 To 9
            buckets(i) = New List(Of Integer)
        Next

        startTick = Environment.TickCount

        For exp = 0 To maxLen
            'Put numbers into respective buckets
            For arrayIndex = 0 To UBound(PassedArray)
                valAtIndex = PassedArray(arrayIndex)
                temp = Int(valAtIndex / digit) Mod 10
                buckets(temp).Add(valAtIndex)
            Next
            arrayIndex = 0
            'Put bucket contents back into array
            For bucketIndex = 0 To UBound(buckets)
                tempIndex = buckets(bucketIndex).Count
                buckets(bucketIndex).ToArray.CopyTo(PassedArray, arrayIndex)
                arrayIndex = arrayIndex + tempIndex
                tempIndex = 0
                buckets(bucketIndex).RemoveRange(0, buckets(bucketIndex).Count)
            Next
            digit = digit * 10
        Next

        endTick = Environment.TickCount

        If CheckSort(PassedArray) Then
            Return (endTick - startTick)
        Else
            MsgBox("BucketSortTicks ERROR: Array was not sorted")
            Return 0
        End If
    End Function

    'END SORTING ALGORITHMS COUNTING TICKS


End Module
