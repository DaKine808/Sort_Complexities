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

        'PrintSortedArray(ArrayToSort)
        'TextBox1.AppendText("Comparisons " & comparisons & vbNewLine)
        'TextBox1.AppendText("Swaps " & swaps & vbNewLine)
        'Check that ArrayToSort() is sorted properly
        If CheckSort(ArrayToSort) = True Then
            Return comparisons
        Else
            MsgBox("ERROR: Array was NOT sorted properly")
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
        For r = 0 To UBound(PassedArray)
            newArray(r + 1) = PassedArray(r)
        Next

        'Used to check contents of newArray()
        'For q = 0 To UBound(newArray)
        '    TextBox1.AppendText(newArray(q) & ", ")
        'Next
        'TextBox1.AppendText(" -> ")

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

        'Used to check contents of tempArray()
        'For r = 0 To UBound(PassedArray)
        '    TextBox1.AppendText(tempArray(r) & ", ")
        'Next
        'TextBox1.AppendText(vbNewLine)

        'Check that newArray is sorted correctly
        If CheckSort(tempArray) = True Then
            Return comparisons
        Else
            MsgBox("ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

    'QUICKSORT
    Function QuickComparisons(ByVal PassedArray() As Integer, ByRef l As Integer, ByRef r As Integer) As Integer
        Dim s As Integer
        Dim counter As Integer = 0
        If l < r Then
            s = Partition1(PassedArray, l, r, counter)
            counter = counter + QuickComparisons(PassedArray, l, s - 1)
            counter = counter + QuickComparisons(PassedArray, s + 1, r)
        End If
        Return counter
    End Function

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
    'END QUICKSORT

    Sub MedianOfThreeComparisons(ByVal PassedArray() As Integer, ByRef l As Integer, ByRef r As Integer)
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

            s = Partition1(PassedArray, l, r)
            QuickComparisons(PassedArray, l, s - 1)
            QuickComparisons(PassedArray, s + 1, r)
        End If
    End Sub

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
            MsgBox("ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

    Function CheckSort(ByRef SortedArray() As Integer) As Boolean
        Dim a As Integer = UBound(SortedArray) - 1
        For i = 0 To a
            If SortedArray(i) > SortedArray(i + 1) Then
                Return False
            Else
                Continue For
            End If
        Next
        Return True
    End Function
End Module
