Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1

    Dim series1Lines As Boolean = False
    Dim series2Lines As Boolean = False
    Dim series3Lines As Boolean = False
    Dim series4Lines As Boolean = False

    Dim numberOfSeries As Integer = 1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Chart1.Series(0).Name = "n"
        Chart1.Series(0).Color = Color.Black
        Chart1.Series(0).ChartType = SeriesChartType.Spline
        Chart1.Series(0).Enabled = False

        Chart1.Series(1).Name = "n^2"
        Chart1.Series(1).Color = Color.Black
        Chart1.Series(1).ChartType = SeriesChartType.Spline
        Chart1.Series(1).Enabled = False

        Chart1.Series(2).Name = "log n"
        Chart1.Series(2).Color = Color.Black
        Chart1.Series(2).ChartType = SeriesChartType.Spline
        Chart1.Series(2).Enabled = False

        Chart1.Series(3).Name = "n log n"
        Chart1.Series(3).Color = Color.Black
        Chart1.Series(3).ChartType = SeriesChartType.Spline
        Chart1.Series(3).Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandSerBtn.Click
        Dim newSeries As New Series
        Dim rand As New Random

        Chart1.Series.Add(newSeries)
        newSeries.Name = "NewSeries" & numberOfSeries
        For i = 0 To 11
            newSeries.Points.AddXY(i * 10, rand.Next(100) * 1.375234)
        Next
        newSeries.ChartType = SeriesChartType.Spline
        numberOfSeries = numberOfSeries + 1
    End Sub

    'CHANGE IF A SERIES IS ENABLED OR NOT
    Private Sub nVisBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nVisBtn.CheckedChanged
        If nVisBtn.Checked = True Then
            For a = 0 To InputSize.Value
                Chart1.Series(0).Points.AddXY(a, a)
            Next
            Chart1.Series(0).Enabled = True
        ElseIf nVisBtn.Checked = False Then
                Chart1.Series(0).Points.Clear()
            Chart1.Series(0).Enabled = False
        End If
    End Sub

    Private Sub VisibilityBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NsqrVisBtn.CheckedChanged
        If NsqrVisBtn.Checked = True Then
            For a = 0 To InputSize.Value
                Chart1.Series(1).Points.AddXY(a, (a * a))
            Next
            Chart1.Series(1).Enabled = True
        ElseIf NsqrVisBtn.Checked = False Then
            Chart1.Series(1).Points.Clear()
            Chart1.Series(1).Enabled = False
        End If
    End Sub

    Private Sub logNVisBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logNVisBtn.CheckedChanged
        If logNVisBtn.Checked = True Then
            For a = 1 To InputSize.Value
                Chart1.Series(2).Points.AddXY(a, (Math.Log10(a) / Math.Log10(2)))
            Next
            Chart1.Series(2).Enabled = True
        ElseIf logNVisBtn.Checked = False Then
            Chart1.Series(2).Points.Clear()
            Chart1.Series(2).Enabled = False
        End If
    End Sub

    Private Sub NlogNVisBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NlogNVisBtn.CheckedChanged
        If NlogNVisBtn.Checked = True Then
            For a = 1 To InputSize.Value
                Chart1.Series(3).Points.AddXY(a, (a * (Math.Log10(a) / Math.Log10(2))))
            Next
            Chart1.Series(3).Enabled = True
        ElseIf NlogNVisBtn.Checked = False Then
            Chart1.Series(3).Points.Clear()
            Chart1.Series(3).Enabled = False
        End If
    End Sub
    'END CHANGE IF A SERIES IS ENABLED OR NOT
    'END UNNECESSARY CODE. LEFT FOR FUTURE REFERENCE


    'CREATE ARRAYS
    Private Function CreateRandomArray(ByVal i As Integer)
        Dim RandomArray(i) As Integer
        Dim rand As New Random
        For j = 0 To i
            RandomArray(j) = rand.Next(100)
        Next
        Return RandomArray
    End Function

    Private Function CreateIncreasingArray2(ByVal i As Integer)
        Dim IncreasingArray(i) As Integer
        Dim rand As New Random
        Dim multiplier As Integer = rand.Next(1, 17)
        For j = 0 To i
            IncreasingArray(j) = j * multiplier
        Next
        Return IncreasingArray
    End Function

    Private Function CreateDecreasingArray(ByVal i As Integer)
        Dim DecreasingArray(i) As Integer
        Dim rand As New Random
        Dim multiplier As Integer = rand.Next(1, 19)
        For j = 0 To i
            DecreasingArray(j) = (i - j) * multiplier
        Next
        Return DecreasingArray
    End Function

    Private Function CreateNearlySortedArray(ByVal i As Integer)
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
    'END CREATE ARRAYS


    'SORTING ALGORITHMS COUNTING COMPARES
    Private Function SSComparisons(ByRef PassedArray() As Integer)
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

    Private Function InsertionComparisons(ByRef PassedArray() As Integer)
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
    Dim QuickComps As Integer
    Private Sub QuickComparisons(ByVal PassedArray() As Integer, ByRef l As Integer, ByRef r As Integer)
        Dim s As Integer
        If l < r Then
            s = Partition1(PassedArray, l, r)
            QuickComparisons(PassedArray, l, s - 1)
            QuickComparisons(PassedArray, s + 1, r)
        End If
    End Sub
    'Partition2 correctly sorts an array
    Private Function Partition1(ByVal subArray() As Integer, ByRef l As Integer, ByRef r As Integer)
        Dim p As Integer = subArray(l)
        Dim i As Integer = l
        Dim j As Integer = r + 1
        Dim tempValue As Integer = 0

        Do Until i >= j
            i = i + 1
            Do Until subArray(i) >= p Or i = r
                QuickComps = QuickComps + 1
                i = i + 1
            Loop
            j = j - 1
            Do Until subArray(j) <= p
                QuickComps = QuickComps + 1
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

    'MEDIAN OF 3 QUICKSORT
    Private Sub MedianOfThreeComparisons(ByVal PassedArray() As Integer, ByRef l As Integer, ByRef r As Integer)
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
    'END OF MEDIAN OF 3 QUICKSORT

    'BUBBLE SORT'
    Private Function BubbleComparisons(ByRef PassedArray() As Integer)
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
    'END OF BUBBLE SORT'
    'END SORTING ALGORITHMS COUNTING COMPARES

    'SORTING ALGORITHMS COUNTING TICKS
    Private Function SSTicks(ByRef PassedArray() As Integer)
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
            MsgBox("ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

    Private Function InsertionTicks(ByRef PassedArray() As Integer)
        Dim newArray() As Integer = {-9999}
        Dim a As Integer = UBound(newArray)
        Dim tempArray(UBound(PassedArray)) As Integer
        Dim v As Integer
        Dim j As Integer
        Dim StartTicks As Long
        Dim EndTicks As Long

        'Create a newArray with sentinel
        ReDim Preserve newArray(0 To UBound(PassedArray) + 1)
        For r = 0 To UBound(PassedArray)
            newArray(r + 1) = PassedArray(r)
        Next

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
            MsgBox("ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function

    Private Sub QuickTicks(ByVal PassedArray() As Integer, ByRef l As Integer, ByRef r As Integer)
        Dim s As Integer

        If l < r Then
            s = Partition2(PassedArray, l, r)
            QuickTicks(PassedArray, l, s - 1)
            QuickTicks(PassedArray, s + 1, r)
        End If
    End Sub

    Private Function Partition2(ByVal subArray() As Integer, ByRef l As Integer, ByRef r As Integer)
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

    Private Sub MedianQuickTicks(ByVal PassedArray() As Integer, ByVal l As Integer, ByRef r As Integer)
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

    Private Function BubbleTicks(ByRef PassedArray() As Integer)
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
            MsgBox("ERROR: Array was NOT sorted properly")
            Return 0
        End If
    End Function
    'END SORTING ALGORITHMS COUNTING TICKS


    'CHECK SORTED ARRAYS
    Private Function CheckSort(ByRef SortedArray() As Integer)
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
    'END CHECK SORTED ARRAYS

    Private Sub AutomatedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutomatedButton.Click
        'Dim AvgResult As Double
        Dim tempArray() As Integer
        Dim x As Integer = InputSize.Value 'Size of array to be created
        Dim y As Integer = NumOfRuns.Value 'Number of times to run the test. Be sure to change size of ResultsArray if value of y is changed.
        Dim SortTrend(x) As Integer
        Dim ResultsArray(y) As Integer 'Will hold the results for multiple runs of a single array size
        Dim newSeries As New Series
        Dim ClockArrayMult As Integer = 100
        Dim temp As Integer
        Dim sTick As Long
        Dim eTick As Long
        Dim elapsedTicks1 As Long
        Dim elapsedTicks2 As Long
        TextBox1.Clear()

        If ClockCyclesRadio.Checked = True Then
            SortTrend(0) = 0
            'SortTrend(1) = 0
            For j = 1 To x
                temp = (j * ClockArrayMult) - 1
                'sTick = Environment.TickCount
                elapsedTicks1 = Date.Now.Ticks
                For k = 0 To y
                    If IncArrayRadio.Checked Then
                        tempArray = CreateIncreasingArray2(temp)
                        ResultsArray(k) = NextStep(tempArray)
                    ElseIf DecArrayRadio.Checked = True Then
                        tempArray = CreateDecreasingArray(temp)
                        ResultsArray(k) = NextStep(tempArray)
                    ElseIf NearlySortedRadio.Checked = True Then
                        tempArray = CreateNearlySortedArray(temp)
                        ResultsArray(k) = NextStep(tempArray)
                    ElseIf RandomRadio.Checked = True Then
                        tempArray = CreateRandomArray(temp)
                        ResultsArray(k) = NextStep(tempArray)
                    End If
                Next
                elapsedTicks2 = Date.Now.Ticks
                'eTick = Environment.TickCount
                SortTrend(j) = (elapsedTicks2 - elapsedTicks1) / (y + 1)
                'SortTrend(j) = ResultsArray.Average
            Next
        ElseIf ComparisonsRadio.Checked Then
            SortTrend(0) = 0
            SortTrend(1) = 0
            For h = 2 To x
                For i = 0 To y
                    If IncArrayRadio.Checked = True Then
                        tempArray = CreateIncreasingArray2(h - 1)
                        ResultsArray(i) = NextStep(tempArray)
                    ElseIf DecArrayRadio.Checked = True Then
                        tempArray = CreateDecreasingArray(h - 1)
                        ResultsArray(i) = NextStep(tempArray)
                    ElseIf NearlySortedRadio.Checked = True Then
                        tempArray = CreateNearlySortedArray(h - 1)
                        ResultsArray(i) = NextStep(tempArray)
                    ElseIf RandomRadio.Checked = True Then
                        tempArray = CreateRandomArray(h - 1)
                        ResultsArray(i) = NextStep(tempArray)
                    End If
                Next
                SortTrend(h) = ResultsArray.Average
            Next
        End If

        Chart1.Series.Add(newSeries)
        If SelectionSortRadio.Checked Then
            newSeries.Name = "Selection Sort " & numberOfSeries
        ElseIf QuickSortRadio.Checked Then
            newSeries.Name = "Quicksort " & numberOfSeries
        ElseIf MedianQuickRadio.Checked Then
            newSeries.Name = "Median of 3 " & numberOfSeries
        ElseIf InsertionSortRadio.Checked Then
            newSeries.Name = "Insertion Sort " & numberOfSeries
        ElseIf BubbleSortRadio.Checked Then
            newSeries.Name = "Bubble Sort" & numberOfSeries
        End If

        numberOfSeries = numberOfSeries + 1
        For s = 0 To x
            newSeries.Points.AddXY(s, SortTrend(s))
        Next
        newSeries.ChartType = SeriesChartType.Spline
    End Sub

    Private Sub PrintUnsortedArray(ByRef refArray1() As Integer)
        TextBox1.AppendText("Unsorted array: ")
        For q = 0 To UBound(refArray1)
            TextBox1.AppendText(refArray1(q) & ", ")
        Next
        TextBox1.AppendText(vbNewLine)
    End Sub

    Private Sub PrintSortedArray(ByRef refArray1() As Integer)
        TextBox1.AppendText("Sorted array: ")
        For q = 0 To UBound(refArray1)
            TextBox1.AppendText(refArray1(q) & ", ")
        Next
        TextBox1.AppendText(vbNewLine)
    End Sub

    Private Function NextStep(ByRef refArray() As Integer)
        Dim tempResult As Integer = 0
        Dim startTick As Long
        Dim endTick As Long

        If ComparisonsRadio.Checked Then
            If SelectionSortRadio.Checked Then
                Return SSComparisons(refArray)
            ElseIf InsertionSortRadio.Checked = True Then
                Return InsertionComparisons(refArray)
            ElseIf QuickSortRadio.Checked Then
                If DisplayBox.Checked Then
                    PrintUnsortedArray(refArray)
                End If
                QuickComps = 0
                QuickComparisons(refArray, 0, UBound(refArray))
                If DisplayBox.Checked Then
                    PrintSortedArray(refArray)
                End If
                If CheckSort(refArray) Then
                    Return QuickComps
                Else
                    MsgBox("ERROR: Array was not sorted")
                    Return 0
                End If
            ElseIf MedianQuickRadio.Checked Then
                If DisplayBox.Checked Then
                    PrintUnsortedArray(refArray)
                End If
                QuickComps = 0
                MedianOfThreeComparisons(refArray, 0, UBound(refArray))
                If DisplayBox.Checked Then
                    PrintSortedArray(refArray)
                End If
                If CheckSort(refArray) Then
                    Return QuickComps
                Else
                    MsgBox("ERROR: Array was not sorted")
                    Return 0
                End If
            ElseIf BubbleSortRadio.Checked Then
                Return BubbleComparisons(refArray)
            End If
        ElseIf ClockCyclesRadio.Checked = True Then
            If SelectionSortRadio.Checked Then
                Return SSTicks(refArray)
            ElseIf InsertionSortRadio.Checked Then
                Return InsertionTicks(refArray)
            ElseIf QuickSortRadio.Checked Then
                If DisplayBox.Checked Then
                    PrintUnsortedArray(refArray)
                End If
                'startTick = Environment.TickCount
                QuickTicks(refArray, 0, UBound(refArray))
                'endTick = Environment.TickCount
                If CheckSort(refArray) Then
                    Return (endTick - startTick)
                Else
                    MsgBox("ERROR: Array was not sorted")
                    Return 0
                End If
            ElseIf MedianQuickRadio.Checked Then
                If DisplayBox.Checked Then
                    PrintUnsortedArray(refArray)
                End If
                'startTick = Environment.TickCount
                MedianQuickTicks(refArray, 0, UBound(refArray))
                'endTick = Environment.TickCount
                If CheckSort(refArray) Then
                    Return (endTick - startTick)
                Else
                    MsgBox("ERROR: Array was not sorted")
                    Return 0
                End If
            ElseIf BubbleSortRadio.Checked Then
                Return BubbleTicks(refArray)
            End If
        End If
        MsgBox("ERROR: A sorting alogrithm was not selected!")
        Return 0
    End Function

    Private Sub Clear_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Btn.Click
        nVisBtn.Checked = "False"
        NsqrVisBtn.Checked = "False"
        logNVisBtn.Checked = "False"
        NlogNVisBtn.Checked = "False"
        'TextBox1.AppendText("Chart1 series count : " & Chart1.Series.Count)
        'TextBox1.AppendText(vbNewLine)
        For i = 5 To Chart1.Series.Count
            Chart1.Series.RemoveAt(Chart1.Series.Count - 1)
            numberOfSeries = numberOfSeries - 1
        Next
    End Sub

End Class
