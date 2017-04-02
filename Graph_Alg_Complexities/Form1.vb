Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Delegate Function mySort(ByVal passedArray() As Int64, ByRef comparisons As Integer) As Long

    Dim sortDict As New Dictionary(Of String, mySort) From
            {{"Selection Sort", AddressOf SSComparisons},
             {"Quick Sort", AddressOf QuickSortWrapper},
             {"Median Of 3", AddressOf MedianOfThreeWrapper},
             {"Insertion Sort", AddressOf InsertionComparisons},
             {"Bubble Sort", AddressOf BubbleComparisons},
             {"Merge Sort", AddressOf MergeSortWrapper},
             {"Bucket Sort", AddressOf BucketSortComp},
             {"VisualBasic Sort", AddressOf VBSortComps}
            }

    Dim numberOfSeries As Integer = 10

    'Because counting clock cycles causes weird results below a certain threshold,
    'when counting them I adjust how many runs of each array size there will be 
    '(Currently affects counting comparisons as well). From trial and error 10 seems 
    'to be a good modifier.
    Dim timeMultiplier As Integer = 1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ClearDataTip.SetToolTip(Clear_Btn, "This deletes the data from the last Run. If results were written to a file then they must be deleted manually.")

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

    'MAIN FUNCTION
    Private Sub BeginSorting_Click(sender As System.Object, e As System.EventArgs) Handles BeginSorting.Click
        Dim numberOfSorts As Integer = SortList.CheckedIndices.Count()
        Dim totalSorts As Integer = SortList.Items.Count()

        If numberOfSorts = 0 Then
            MsgBox("Error: You didn't select at least 1 sort.")
            Return
        End If

        TextBox1.Clear()
        Dim time As Integer = 0,
            comps As Integer = 1
        'tempArray is used to store the "unsorted" array that is used by all the sort functions selected
        Dim tempArray() As Int64
        'averages will store the average results of all 8 sorts for both time(0) and comparisons(1)
        'once done, averages will be written to a file
        Dim averages(totalSorts - 1, 1, InputSize.Value) As Double
        averages.Initialize()
        'results will temporarily hold the results of all 8 sorts for both time(0) and comparisons(1) before
        'they are averaged and stored in the averages array
        Dim results(totalSorts - 1, 1, NumOfRuns.Value * timeMultiplier) As Int64
        results.Initialize()
        Dim comparisons As Integer = 0
        Dim arrayType As Func(Of Integer, Array)
        Dim arrayTypeName As String
        getArrayType(arrayType, arrayTypeName)

        SortProgress.Maximum = InputSize.Value
        SortProgress.Value = 2

        For arraySize = 1 To InputSize.Value
            results.Initialize()
            For run = 0 To NumOfRuns.Value * timeMultiplier
                'Generate the array to be used by all of the selected sorts
                tempArray = arrayType(arraySize)
                'Run the "unsorted" array through all of the selected sorts
                For Each sortIndex In SortList.CheckedIndices
                    comparisons = 0
                    results(sortIndex, time, run) = sortDict.ElementAt(sortIndex).Value(tempArray, comparisons)
                    results(sortIndex, comps, run) = comparisons
                Next
            Next
            'Now that all of the runs for an arraysize are done
            'calculate the averages and store them in the averages array
            For Each index In SortList.CheckedIndices
                averages(index, time, arraySize) = calcAverage(results, index, time)
                averages(index, comps, arraySize) = calcAverage(results, index, comps)
            Next
            SortProgress.PerformStep()
        Next

        If WriteToFile.Checked Then
            'Make sure the file I'm trying to write to doesn't already exist.
            'Delete file if it already exists.
            Dim fileName As String
            fileName = TryToCreateFile(arrayTypeName)

            'Now that all sorting is done store the averages in a file
            WriteResultsToFile(averages, fileName)
        End If


        'Remove any previous series that may have been added in a previous run
        Clear_Btn.PerformClick()

        'Now convert averages to series to display in the chart
        For Each index In SortList.CheckedIndices
            addResultSeries(index, averages, sortDict.ElementAt(index).Key, time, "time")
            addResultSeries(index, averages, sortDict.ElementAt(index).Key, comps, "comps")
        Next

        If DispResBox.Checked = True Then
            If CompsRadio.Checked = True Then
                DisplayResultsFor("comps")
            ElseIf ClockRadio.Checked = True Then
                DisplayResultsFor("time")
            End If
        End If

    End Sub
    'END MAIN FUNCTION

    Private Function TryToCreateFile(ByVal arrayTypeName As String) As String
        Dim currentDir As String = My.Computer.FileSystem.CurrentDirectory
        TextBox1.AppendText("Writing file to directory: " & vbNewLine & currentDir & vbNewLine & vbNewLine)
        Dim fileName As String = currentDir & "\Sorting_Results(" & arrayTypeName & ").csv"
        If My.Computer.FileSystem.FileExists(fileName) Then
            MsgBox(fileName & " already exists. Sending it to the recycle bin.")
            My.Computer.FileSystem.DeleteFile(fileName, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If
        Return fileName
    End Function

    Private Sub WriteResultsToFile(ByRef averages(,,) As Double, ByVal fileName As String)
        Dim time = 0,
            comps = 1
        TextBox1.AppendText("Results written to file: " & vbNewLine)
        For Each index In SortList.CheckedIndices
            My.Computer.FileSystem.WriteAllText(fileName, sortDict.ElementAt(index).Key & "(Time),", True)
            For arraySize = 0 To InputSize.Value
                My.Computer.FileSystem.WriteAllText(fileName, averages(index, time, arraySize).ToString & ",", True)
            Next
            TextBox1.AppendText(sortDict.ElementAt(index).Key & "(Time)" & vbNewLine)
            My.Computer.FileSystem.WriteAllText(fileName, vbNewLine, True)
            My.Computer.FileSystem.WriteAllText(fileName, sortDict.ElementAt(index).Key & "(Comps),", True)
            For arraySize = 0 To InputSize.Value
                My.Computer.FileSystem.WriteAllText(fileName, averages(index, comps, arraySize).ToString & ",", True)
            Next
            TextBox1.AppendText(sortDict.ElementAt(index).Key & "(Comps)" & vbNewLine)
            My.Computer.FileSystem.WriteAllText(fileName, vbNewLine, True)
        Next
        TextBox1.AppendText(vbNewLine & "Done writing the results to file.")
    End Sub

    Private Sub getArrayType(ByRef arrayType As Func(Of Integer, Array), ByRef arrayTypeName As String)
        If IncArrayRadio.Checked = True Then
            arrayTypeName = "Increasing_Array"
            arrayType = AddressOf CreateIncreasingArray
        ElseIf DecArrayRadio.Checked = True Then
            arrayTypeName = "Decreasing_Array"
            arrayType = AddressOf CreateDecreasingArray
        ElseIf NearlySortedRadio.Checked = True Then
            arrayTypeName = "Nearly_Sorted_Array"
            arrayType = AddressOf CreateNearlySortedArray
        Else
            arrayTypeName = "Random_Array"
            arrayType = AddressOf CreateRandomArray
        End If
    End Sub

    Private Sub addResultSeries(ByVal index As Integer, ByRef averages(,,) As Double, ByVal sortName As String, ByVal resultType As Integer, ByVal resTypeString As String)
        Dim tempSeries As Series
        tempSeries = New Series
        tempSeries.ChartType = SeriesChartType.Spline
        tempSeries.Name = sortName & "(" & resTypeString & ")"
        For arraySize = 0 To InputSize.Value
            tempSeries.Points.AddXY(arraySize, averages(index, resultType, arraySize))
        Next
        Chart1.Series.Add(tempSeries)
        numberOfSeries = numberOfSeries + 1
        Chart1.Series(tempSeries.Name).Enabled = False
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
    Private Sub PrintArray(ByRef refArray1() As Int64)
        For q = 0 To UBound(refArray1)
            TextBox1.AppendText(refArray1(q) & ", ")
        Next
        TextBox1.AppendText(vbNewLine)
    End Sub

    Private Sub PrintUnsortedArray(ByRef refArray1() As Int64)
        TextBox1.AppendText("Unsorted array: ")
        PrintArray(refArray1)
    End Sub

    Private Sub PrintSortedArray(ByRef refArray1() As Int64)
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

    Private Sub InputSize_ValueChanged(sender As System.Object, e As System.EventArgs) Handles InputSize.ValueChanged
        UpdateLines()
    End Sub

    Private Sub LineMultiplier_ValueChanged(sender As System.Object, e As System.EventArgs) Handles LineMultiplier.ValueChanged
        UpdateLines()
    End Sub

    Private Sub UpdateLines()
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

    Private Sub DisplayResultsFor(ByVal resTypeName As String)
        For Each line As Series In Chart1.Series
            If line.Name.Contains(resTypeName) Then
                line.Enabled = True
            Else
                line.Enabled = False
            End If
        Next
        'Currently used to get the chart area to correctly change scale when switching between 
        '   viewing the graphs of comparison and time
        nVisBtn.Checked = True
        nVisBtn.Checked = False
    End Sub

    Private Sub DispResBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles DispResBox.CheckedChanged
        If DispResBox.Checked = True Then
            CompsRadio.Enabled = True
            ClockRadio.Enabled = True
            If CompsRadio.Checked = True Then
                DisplayResultsFor("comps")
            ElseIf ClockRadio.Checked = True Then
                DisplayResultsFor("time")
            End If
        Else
            CompsRadio.Enabled = False
            ClockRadio.Enabled = False
        End If
    End Sub

    Private Sub CompsRadio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CompsRadio.CheckedChanged
        If CompsRadio.Checked = True Then
            DisplayResultsFor("comps")
        End If
    End Sub

    Private Sub ClockRadio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ClockRadio.CheckedChanged
        If ClockRadio.Checked = True Then
            DisplayResultsFor("time")
        End If
    End Sub
End Class
