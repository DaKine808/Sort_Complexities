Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1

    'Dim series1Lines As Boolean = False
    'Dim series2Lines As Boolean = False
    'Dim series3Lines As Boolean = False
    'Dim series4Lines As Boolean = False

    Dim numberOfSeries As Integer = 1
    Dim timeMultiplier As Integer = 1 'Because counting clock cycles causes weird results, when counting them you must
    'adjust how large each array size is. By trial and error, 100 seems to be a good modifier.

    'MAIN FUNCTIONS
    Private Sub AutomatedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutomatedButton.Click
        'Dim AvgResult As Double
        Dim tempArray() As Integer
        Dim x As Integer = InputSize.Value 'Max size of array to be created
        Dim y As Integer = NumOfRuns.Value 'Number of times to run the test. Be sure to change size of ResultsArray if value of y is changed.
        Dim SortTrend(x) As Double 'Will hold the averages that will be plotted.
        Dim ResultsArray(y) As Integer 'Will hold the results for multiple runs of a single array size, which is then added and stored in SortTrend.
        Dim newSeries As New Series
        Dim ClockArrayMult As Integer = 10
        Dim temp As Integer
        TextBox1.Clear()

        If ClockCyclesRadio.Checked = True Then
            SortTrend(0) = 0
            SortTrend(1) = 0
            For j = 1 To x
                temp = (j * ClockArrayMult) - 1
                For k = 0 To y
                    If IncArrayRadio.Checked Then
                        tempArray = CreateIncreasingArray2(temp)
                    ElseIf DecArrayRadio.Checked = True Then
                        tempArray = CreateDecreasingArray(temp)
                    ElseIf NearlySortedRadio.Checked = True Then
                        tempArray = CreateNearlySortedArray(temp)
                    ElseIf RandomRadio.Checked = True Then
                        tempArray = CreateRandomArray(temp)
                    End If
                    ResultsArray(k) = NextStep(tempArray)
                Next
                SortTrend(j) = ResultsArray.Average
            Next
        ElseIf ComparisonsRadio.Checked Then
            SortTrend(0) = 0
            SortTrend(1) = 0
            For h = 2 To x
                For i = 0 To y
                    If IncArrayRadio.Checked = True Then
                        tempArray = CreateIncreasingArray2(h - 1)
                    ElseIf DecArrayRadio.Checked = True Then
                        tempArray = CreateDecreasingArray(h - 1)
                    ElseIf NearlySortedRadio.Checked = True Then
                        tempArray = CreateNearlySortedArray(h - 1)
                    ElseIf RandomRadio.Checked = True Then
                        tempArray = CreateRandomArray(h - 1)
                    End If
                    ResultsArray(i) = NextStep(tempArray)
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
        ElseIf MergeSortRadio.Checked Then
            newSeries.Name = "Merge Sort" & numberOfSeries
        ElseIf VBRadio.Checked Then
            newSeries.Name = "VB Sort" & numberOfSeries
        Else
            newSeries.Name = "Series" & numberOfSeries
        End If

        numberOfSeries = numberOfSeries + 1
        For s = 0 To x
            newSeries.Points.AddXY(s, SortTrend(s))
        Next
        newSeries.ChartType = SeriesChartType.Spline
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
                tempResult = QuickComparisons(refArray, 0, UBound(refArray))
                If DisplayBox.Checked Then
                    PrintSortedArray(refArray)
                End If
                If CheckSort.CheckSort(refArray) Then
                    Return tempResult
                Else
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
                If CheckSort.CheckSort(refArray) Then
                    Return QuickComps
                Else
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
                startTick = Environment.TickCount
                QuickTicks(refArray, 0, UBound(refArray))
                endTick = Environment.TickCount
                If CheckSort.CheckSort(refArray) Then
                    Return (endTick - startTick)
                Else
                    Return 0
                End If
            ElseIf MedianQuickRadio.Checked Then
                If DisplayBox.Checked Then
                    PrintUnsortedArray(refArray)
                End If
                startTick = Environment.TickCount
                MedianQuickTicks(refArray, 0, UBound(refArray))
                endTick = Environment.TickCount
                If CheckSort.CheckSort(refArray) Then
                    Return (endTick - startTick)
                Else
                    Return 0
                End If
            ElseIf BubbleSortRadio.Checked Then
                Return BubbleTicks(refArray)
            ElseIf MergeSortRadio.Checked Then
                If DisplayBox.Checked Then
                    PrintUnsortedArray(refArray)
                End If
                startTick = Environment.TickCount
                MergeTicks(refArray)
                endTick = Environment.TickCount
                If DisplayBox.Checked Then
                    PrintSortedArray(refArray)
                End If
                If CheckSort.CheckSort(refArray) Then
                    Return (endTick - startTick)
                Else
                    Return 0
                End If
            ElseIf VBRadio.Checked Then
                startTick = Environment.TickCount
                Array.Sort(refArray)
                endTick = Environment.TickCount
                Return (endTick - startTick)
            ElseIf BucketSortRadio.Checked Then
                Return BucketSort(refArray)
            End If
        End If

        MsgBox("ERROR: A sorting alogrithm was not selected!")
        Return 0
    End Function
    'END MAIN FUNCTIONS

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

    'CHANGE IF A SERIES IS ENABLED OR NOT
    Private Sub nVisBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nVisBtn.CheckedChanged
        If nVisBtn.Checked = True Then
            For a = 0 To InputSize.Value
                Chart1.Series(0).Points.AddXY(a, a * LineMultiplier.Value)
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
                Chart1.Series(1).Points.AddXY(a, (a * a) * LineMultiplier.Value)
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
                Chart1.Series(2).Points.AddXY(a, (Math.Log10(a) / Math.Log10(2)) * LineMultiplier.Value)
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
                Chart1.Series(3).Points.AddXY(a, (a * (Math.Log10(a) / Math.Log10(2))) * LineMultiplier.Value)
            Next
            Chart1.Series(3).Enabled = True
        ElseIf NlogNVisBtn.Checked = False Then
            Chart1.Series(3).Points.Clear()
            Chart1.Series(3).Enabled = False
        End If
    End Sub
    'END CHANGE IF A SERIES IS ENABLED OR NOT

   

    'PRINT ARRAYS
    Private Sub PrintArray(ByRef refArray1() As Integer)
        For q = 0 To UBound(refArray1)
            TextBox1.AppendText(refArray1(q) & ", ")
        Next
        TextBox1.AppendText(vbNewLine)
    End Sub

    Private Sub PrintUnsortedArray(ByRef refArray1() As Integer)
        TextBox1.AppendText("Unsorted array: ")
        PrintArray(refArray1)
    End Sub

    Private Sub PrintSortedArray(ByRef refArray1() As Integer)
        TextBox1.AppendText("Sorted array: ")
        PrintArray(refArray1)
    End Sub
    'END PRINT ARRAYS

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

    Private Sub Rand_Series_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandSerBtn.Click
        Dim newSeries As New Series
        Dim rand As New Random

        Chart1.Series.Add(newSeries)
        newSeries.Name = "NewSeries" & numberOfSeries
        For i = 0 To InputSize.Value
            newSeries.Points.AddXY(i, rand.Next(100) * 1.375234)
        Next
        newSeries.ChartType = SeriesChartType.Spline
        numberOfSeries = numberOfSeries + 1
    End Sub

    Private Sub LineMultiplier_ValueChanged(sender As System.Object, e As System.EventArgs) Handles LineMultiplier.ValueChanged
        If nVisBtn.Checked = True Then
            nVisBtn.Checked = False
            nVisBtn.Checked = True
        End If
        If NsqrVisBtn.Checked = True Then
            NsqrVisBtn.Checked = False
            NsqrVisBtn.Checked = True
        End If
        If logNVisBtn.Checked = True Then
            logNVisBtn.Checked = False
            logNVisBtn.Checked = True
        End If
        If NlogNVisBtn.Checked = True Then
            NlogNVisBtn.Checked = False
            NlogNVisBtn.Checked = True
        End If
    End Sub

    Private Sub MergeSortRadio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles MergeSortRadio.CheckedChanged
        If MergeSortRadio.Checked = True Then
            ClockCyclesRadio.Checked = True
            ComparisonsRadio.Enabled = False
        Else
            ComparisonsRadio.Enabled = True
        End If
    End Sub

    Private Sub BucketSortRadio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BucketSortRadio.CheckedChanged
        If BucketSortRadio.Checked = True Then
            ClockCyclesRadio.Checked = True
            ComparisonsRadio.Enabled = False
        Else
            ComparisonsRadio.Enabled = True
        End If
    End Sub

    Private Sub VBRadio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles VBRadio.CheckedChanged
        If VBRadio.Checked = True Then
            ClockCyclesRadio.Checked = True
            ComparisonsRadio.Enabled = False
        Else
            ComparisonsRadio.Enabled = True
        End If
    End Sub
End Class
