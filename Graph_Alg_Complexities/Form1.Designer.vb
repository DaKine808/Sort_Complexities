<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RandSerBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumOfRuns = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BucketSortRadio = New System.Windows.Forms.RadioButton()
        Me.VBSortRadio = New System.Windows.Forms.RadioButton()
        Me.MergeSortRadio = New System.Windows.Forms.RadioButton()
        Me.BubbleSortRadio = New System.Windows.Forms.RadioButton()
        Me.InsertionSortRadio = New System.Windows.Forms.RadioButton()
        Me.MedianQuickRadio = New System.Windows.Forms.RadioButton()
        Me.QuickSortRadio = New System.Windows.Forms.RadioButton()
        Me.SelectionSortRadio = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RandomRadio = New System.Windows.Forms.RadioButton()
        Me.NearlySortedRadio = New System.Windows.Forms.RadioButton()
        Me.DecArrayRadio = New System.Windows.Forms.RadioButton()
        Me.IncArrayRadio = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InputSize = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComparisonsRadio = New System.Windows.Forms.RadioButton()
        Me.ClockCyclesRadio = New System.Windows.Forms.RadioButton()
        Me.AutomatedButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NsqrVisBtn = New System.Windows.Forms.CheckBox()
        Me.nVisBtn = New System.Windows.Forms.CheckBox()
        Me.logNVisBtn = New System.Windows.Forms.CheckBox()
        Me.NlogNVisBtn = New System.Windows.Forms.CheckBox()
        Me.DisplayBox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Clear_Btn = New System.Windows.Forms.Button()
        Me.LineMultiplier = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.VBSortCheckBox = New System.Windows.Forms.CheckBox()
        Me.BucketSortCheckBox = New System.Windows.Forms.CheckBox()
        Me.MergeSortCheckBox = New System.Windows.Forms.CheckBox()
        Me.BubbleSortCheckBox = New System.Windows.Forms.CheckBox()
        Me.InsertionSortCheckBox = New System.Windows.Forms.CheckBox()
        Me.MedianOf3CheckBox = New System.Windows.Forms.CheckBox()
        Me.QuickSortCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectionSortCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumOfRuns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.InputSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.LineMultiplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea3.AxisX.MajorGrid.IntervalOffset = 0.0R
        ChartArea3.AxisX.Minimum = 0.0R
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series10.Legend = "Legend1"
        Series10.Name = "Series2"
        Series11.ChartArea = "ChartArea1"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series11.Legend = "Legend1"
        Series11.Name = "Series3"
        Series12.ChartArea = "ChartArea1"
        Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series12.Legend = "Legend1"
        Series12.Name = "Series4"
        Me.Chart1.Series.Add(Series9)
        Me.Chart1.Series.Add(Series10)
        Me.Chart1.Series.Add(Series11)
        Me.Chart1.Series.Add(Series12)
        Me.Chart1.Size = New System.Drawing.Size(783, 557)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'RandSerBtn
        '
        Me.RandSerBtn.Location = New System.Drawing.Point(975, 497)
        Me.RandSerBtn.Name = "RandSerBtn"
        Me.RandSerBtn.Size = New System.Drawing.Size(95, 23)
        Me.RandSerBtn.TabIndex = 5
        Me.RandSerBtn.Text = "Add Rand Series"
        Me.RandSerBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(983, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Number of Runs:"
        '
        'NumOfRuns
        '
        Me.NumOfRuns.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumOfRuns.Location = New System.Drawing.Point(1073, 40)
        Me.NumOfRuns.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NumOfRuns.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumOfRuns.Name = "NumOfRuns"
        Me.NumOfRuns.Size = New System.Drawing.Size(120, 20)
        Me.NumOfRuns.TabIndex = 9
        Me.NumOfRuns.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BucketSortRadio)
        Me.Panel1.Controls.Add(Me.VBSortRadio)
        Me.Panel1.Controls.Add(Me.MergeSortRadio)
        Me.Panel1.Controls.Add(Me.BubbleSortRadio)
        Me.Panel1.Controls.Add(Me.InsertionSortRadio)
        Me.Panel1.Controls.Add(Me.MedianQuickRadio)
        Me.Panel1.Controls.Add(Me.QuickSortRadio)
        Me.Panel1.Controls.Add(Me.SelectionSortRadio)
        Me.Panel1.Location = New System.Drawing.Point(1127, 353)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 192)
        Me.Panel1.TabIndex = 12
        '
        'BucketSortRadio
        '
        Me.BucketSortRadio.AutoSize = True
        Me.BucketSortRadio.Location = New System.Drawing.Point(14, 147)
        Me.BucketSortRadio.Name = "BucketSortRadio"
        Me.BucketSortRadio.Size = New System.Drawing.Size(81, 17)
        Me.BucketSortRadio.TabIndex = 7
        Me.BucketSortRadio.Text = "Bucket Sort"
        Me.BucketSortRadio.UseVisualStyleBackColor = True
        '
        'VBSortRadio
        '
        Me.VBSortRadio.AutoSize = True
        Me.VBSortRadio.Location = New System.Drawing.Point(14, 170)
        Me.VBSortRadio.Name = "VBSortRadio"
        Me.VBSortRadio.Size = New System.Drawing.Size(61, 17)
        Me.VBSortRadio.TabIndex = 6
        Me.VBSortRadio.Text = "VB Sort"
        Me.VBSortRadio.UseVisualStyleBackColor = True
        '
        'MergeSortRadio
        '
        Me.MergeSortRadio.AutoSize = True
        Me.MergeSortRadio.Location = New System.Drawing.Point(14, 124)
        Me.MergeSortRadio.Name = "MergeSortRadio"
        Me.MergeSortRadio.Size = New System.Drawing.Size(77, 17)
        Me.MergeSortRadio.TabIndex = 5
        Me.MergeSortRadio.TabStop = True
        Me.MergeSortRadio.Text = "Merge Sort"
        Me.MergeSortRadio.UseVisualStyleBackColor = True
        '
        'BubbleSortRadio
        '
        Me.BubbleSortRadio.AutoSize = True
        Me.BubbleSortRadio.Location = New System.Drawing.Point(14, 100)
        Me.BubbleSortRadio.Name = "BubbleSortRadio"
        Me.BubbleSortRadio.Size = New System.Drawing.Size(80, 17)
        Me.BubbleSortRadio.TabIndex = 4
        Me.BubbleSortRadio.TabStop = True
        Me.BubbleSortRadio.Text = "Bubble Sort"
        Me.BubbleSortRadio.UseVisualStyleBackColor = True
        '
        'InsertionSortRadio
        '
        Me.InsertionSortRadio.AutoSize = True
        Me.InsertionSortRadio.Location = New System.Drawing.Point(14, 76)
        Me.InsertionSortRadio.Name = "InsertionSortRadio"
        Me.InsertionSortRadio.Size = New System.Drawing.Size(87, 17)
        Me.InsertionSortRadio.TabIndex = 3
        Me.InsertionSortRadio.Text = "Insertion Sort"
        Me.InsertionSortRadio.UseVisualStyleBackColor = True
        '
        'MedianQuickRadio
        '
        Me.MedianQuickRadio.AutoSize = True
        Me.MedianQuickRadio.Location = New System.Drawing.Point(14, 52)
        Me.MedianQuickRadio.Name = "MedianQuickRadio"
        Me.MedianQuickRadio.Size = New System.Drawing.Size(81, 17)
        Me.MedianQuickRadio.TabIndex = 2
        Me.MedianQuickRadio.Text = "Median-of-3"
        Me.MedianQuickRadio.UseVisualStyleBackColor = True
        '
        'QuickSortRadio
        '
        Me.QuickSortRadio.AutoSize = True
        Me.QuickSortRadio.Location = New System.Drawing.Point(14, 29)
        Me.QuickSortRadio.Name = "QuickSortRadio"
        Me.QuickSortRadio.Size = New System.Drawing.Size(75, 17)
        Me.QuickSortRadio.TabIndex = 1
        Me.QuickSortRadio.Text = "Quick Sort"
        Me.QuickSortRadio.UseVisualStyleBackColor = True
        '
        'SelectionSortRadio
        '
        Me.SelectionSortRadio.AutoSize = True
        Me.SelectionSortRadio.Checked = True
        Me.SelectionSortRadio.Location = New System.Drawing.Point(14, 6)
        Me.SelectionSortRadio.Name = "SelectionSortRadio"
        Me.SelectionSortRadio.Size = New System.Drawing.Size(91, 17)
        Me.SelectionSortRadio.TabIndex = 0
        Me.SelectionSortRadio.TabStop = True
        Me.SelectionSortRadio.Text = "Selection Sort"
        Me.SelectionSortRadio.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RandomRadio)
        Me.Panel2.Controls.Add(Me.NearlySortedRadio)
        Me.Panel2.Controls.Add(Me.DecArrayRadio)
        Me.Panel2.Controls.Add(Me.IncArrayRadio)
        Me.Panel2.Location = New System.Drawing.Point(825, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(125, 93)
        Me.Panel2.TabIndex = 14
        '
        'RandomRadio
        '
        Me.RandomRadio.AutoSize = True
        Me.RandomRadio.Location = New System.Drawing.Point(14, 72)
        Me.RandomRadio.Name = "RandomRadio"
        Me.RandomRadio.Size = New System.Drawing.Size(65, 17)
        Me.RandomRadio.TabIndex = 3
        Me.RandomRadio.Text = "Random"
        Me.RandomRadio.UseVisualStyleBackColor = True
        '
        'NearlySortedRadio
        '
        Me.NearlySortedRadio.AutoSize = True
        Me.NearlySortedRadio.Location = New System.Drawing.Point(14, 49)
        Me.NearlySortedRadio.Name = "NearlySortedRadio"
        Me.NearlySortedRadio.Size = New System.Drawing.Size(89, 17)
        Me.NearlySortedRadio.TabIndex = 2
        Me.NearlySortedRadio.Text = "Nearly Sorted"
        Me.NearlySortedRadio.UseVisualStyleBackColor = True
        '
        'DecArrayRadio
        '
        Me.DecArrayRadio.AutoSize = True
        Me.DecArrayRadio.Location = New System.Drawing.Point(14, 26)
        Me.DecArrayRadio.Name = "DecArrayRadio"
        Me.DecArrayRadio.Size = New System.Drawing.Size(106, 17)
        Me.DecArrayRadio.TabIndex = 1
        Me.DecArrayRadio.Text = "Decreasing Array"
        Me.DecArrayRadio.UseVisualStyleBackColor = True
        '
        'IncArrayRadio
        '
        Me.IncArrayRadio.AutoSize = True
        Me.IncArrayRadio.Checked = True
        Me.IncArrayRadio.Location = New System.Drawing.Point(14, 3)
        Me.IncArrayRadio.Name = "IncArrayRadio"
        Me.IncArrayRadio.Size = New System.Drawing.Size(101, 17)
        Me.IncArrayRadio.TabIndex = 0
        Me.IncArrayRadio.TabStop = True
        Me.IncArrayRadio.Text = "Increasing Array"
        Me.IncArrayRadio.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(983, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Max Array Size:"
        '
        'InputSize
        '
        Me.InputSize.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.InputSize.Location = New System.Drawing.Point(1073, 12)
        Me.InputSize.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.InputSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.InputSize.Name = "InputSize"
        Me.InputSize.Size = New System.Drawing.Size(120, 20)
        Me.InputSize.TabIndex = 16
        Me.InputSize.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ComparisonsRadio)
        Me.Panel3.Controls.Add(Me.ClockCyclesRadio)
        Me.Panel3.Location = New System.Drawing.Point(825, 225)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(125, 53)
        Me.Panel3.TabIndex = 17
        '
        'ComparisonsRadio
        '
        Me.ComparisonsRadio.AutoSize = True
        Me.ComparisonsRadio.Checked = True
        Me.ComparisonsRadio.Location = New System.Drawing.Point(14, 3)
        Me.ComparisonsRadio.Name = "ComparisonsRadio"
        Me.ComparisonsRadio.Size = New System.Drawing.Size(85, 17)
        Me.ComparisonsRadio.TabIndex = 1
        Me.ComparisonsRadio.TabStop = True
        Me.ComparisonsRadio.Text = "Comparisons"
        Me.ComparisonsRadio.UseVisualStyleBackColor = True
        '
        'ClockCyclesRadio
        '
        Me.ClockCyclesRadio.AutoSize = True
        Me.ClockCyclesRadio.Location = New System.Drawing.Point(14, 26)
        Me.ClockCyclesRadio.Name = "ClockCyclesRadio"
        Me.ClockCyclesRadio.Size = New System.Drawing.Size(86, 17)
        Me.ClockCyclesRadio.TabIndex = 0
        Me.ClockCyclesRadio.Text = "Clock Cycles"
        Me.ClockCyclesRadio.UseVisualStyleBackColor = True
        '
        'AutomatedButton
        '
        Me.AutomatedButton.Location = New System.Drawing.Point(804, 497)
        Me.AutomatedButton.Name = "AutomatedButton"
        Me.AutomatedButton.Size = New System.Drawing.Size(75, 23)
        Me.AutomatedButton.TabIndex = 19
        Me.AutomatedButton.Text = "Automate"
        Me.AutomatedButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(983, 87)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(298, 182)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.WordWrap = False
        '
        'NsqrVisBtn
        '
        Me.NsqrVisBtn.AutoSize = True
        Me.NsqrVisBtn.Location = New System.Drawing.Point(825, 79)
        Me.NsqrVisBtn.Name = "NsqrVisBtn"
        Me.NsqrVisBtn.Size = New System.Drawing.Size(77, 17)
        Me.NsqrVisBtn.TabIndex = 21
        Me.NsqrVisBtn.Text = "n^2 Visible"
        Me.NsqrVisBtn.UseVisualStyleBackColor = True
        '
        'nVisBtn
        '
        Me.nVisBtn.AutoSize = True
        Me.nVisBtn.Location = New System.Drawing.Point(825, 33)
        Me.nVisBtn.Name = "nVisBtn"
        Me.nVisBtn.Size = New System.Drawing.Size(65, 17)
        Me.nVisBtn.TabIndex = 25
        Me.nVisBtn.Text = "n Visible"
        Me.nVisBtn.UseVisualStyleBackColor = True
        '
        'logNVisBtn
        '
        Me.logNVisBtn.AutoSize = True
        Me.logNVisBtn.Location = New System.Drawing.Point(825, 10)
        Me.logNVisBtn.Name = "logNVisBtn"
        Me.logNVisBtn.Size = New System.Drawing.Size(86, 17)
        Me.logNVisBtn.TabIndex = 26
        Me.logNVisBtn.Text = "Log n Visible"
        Me.logNVisBtn.UseVisualStyleBackColor = True
        '
        'NlogNVisBtn
        '
        Me.NlogNVisBtn.AutoSize = True
        Me.NlogNVisBtn.Location = New System.Drawing.Point(825, 56)
        Me.NlogNVisBtn.Name = "NlogNVisBtn"
        Me.NlogNVisBtn.Size = New System.Drawing.Size(91, 17)
        Me.NlogNVisBtn.TabIndex = 28
        Me.NlogNVisBtn.Text = "n log n Visible"
        Me.NlogNVisBtn.UseVisualStyleBackColor = True
        '
        'DisplayBox
        '
        Me.DisplayBox.AutoSize = True
        Me.DisplayBox.Location = New System.Drawing.Point(1106, 291)
        Me.DisplayBox.Name = "DisplayBox"
        Me.DisplayBox.Size = New System.Drawing.Size(145, 17)
        Me.DisplayBox.TabIndex = 29
        Me.DisplayBox.Text = "Display Un/Sorted Arrays"
        Me.DisplayBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(986, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Array Display:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1199, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Per Array Size"
        '
        'Clear_Btn
        '
        Me.Clear_Btn.Location = New System.Drawing.Point(890, 497)
        Me.Clear_Btn.Name = "Clear_Btn"
        Me.Clear_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Btn.TabIndex = 33
        Me.Clear_Btn.Text = "Clear Chart"
        Me.Clear_Btn.UseVisualStyleBackColor = True
        '
        'LineMultiplier
        '
        Me.LineMultiplier.DecimalPlaces = 4
        Me.LineMultiplier.Increment = New Decimal(New Integer() {25, 0, 0, 262144})
        Me.LineMultiplier.Location = New System.Drawing.Point(825, 103)
        Me.LineMultiplier.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.LineMultiplier.Minimum = New Decimal(New Integer() {25, 0, 0, 262144})
        Me.LineMultiplier.Name = "LineMultiplier"
        Me.LineMultiplier.Size = New System.Drawing.Size(56, 20)
        Me.LineMultiplier.TabIndex = 34
        Me.LineMultiplier.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(887, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Line Multiplier"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.VBSortCheckBox)
        Me.Panel4.Controls.Add(Me.BucketSortCheckBox)
        Me.Panel4.Controls.Add(Me.MergeSortCheckBox)
        Me.Panel4.Controls.Add(Me.BubbleSortCheckBox)
        Me.Panel4.Controls.Add(Me.InsertionSortCheckBox)
        Me.Panel4.Controls.Add(Me.MedianOf3CheckBox)
        Me.Panel4.Controls.Add(Me.QuickSortCheckBox)
        Me.Panel4.Controls.Add(Me.SelectionSortCheckBox)
        Me.Panel4.Location = New System.Drawing.Point(826, 284)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(124, 192)
        Me.Panel4.TabIndex = 36
        '
        'VBSortCheckBox
        '
        Me.VBSortCheckBox.AutoSize = True
        Me.VBSortCheckBox.Location = New System.Drawing.Point(13, 171)
        Me.VBSortCheckBox.Name = "VBSortCheckBox"
        Me.VBSortCheckBox.Size = New System.Drawing.Size(62, 17)
        Me.VBSortCheckBox.TabIndex = 7
        Me.VBSortCheckBox.Text = "VB Sort"
        Me.VBSortCheckBox.UseVisualStyleBackColor = True
        '
        'BucketSortCheckBox
        '
        Me.BucketSortCheckBox.AutoSize = True
        Me.BucketSortCheckBox.Location = New System.Drawing.Point(13, 148)
        Me.BucketSortCheckBox.Name = "BucketSortCheckBox"
        Me.BucketSortCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.BucketSortCheckBox.TabIndex = 6
        Me.BucketSortCheckBox.Text = "Bucket Sort"
        Me.BucketSortCheckBox.UseVisualStyleBackColor = True
        '
        'MergeSortCheckBox
        '
        Me.MergeSortCheckBox.AutoSize = True
        Me.MergeSortCheckBox.Location = New System.Drawing.Point(13, 125)
        Me.MergeSortCheckBox.Name = "MergeSortCheckBox"
        Me.MergeSortCheckBox.Size = New System.Drawing.Size(78, 17)
        Me.MergeSortCheckBox.TabIndex = 5
        Me.MergeSortCheckBox.Text = "Merge Sort"
        Me.MergeSortCheckBox.UseVisualStyleBackColor = True
        '
        'BubbleSortCheckBox
        '
        Me.BubbleSortCheckBox.AutoSize = True
        Me.BubbleSortCheckBox.Location = New System.Drawing.Point(13, 101)
        Me.BubbleSortCheckBox.Name = "BubbleSortCheckBox"
        Me.BubbleSortCheckBox.Size = New System.Drawing.Size(81, 17)
        Me.BubbleSortCheckBox.TabIndex = 4
        Me.BubbleSortCheckBox.Text = "Bubble Sort"
        Me.BubbleSortCheckBox.UseVisualStyleBackColor = True
        '
        'InsertionSortCheckBox
        '
        Me.InsertionSortCheckBox.AutoSize = True
        Me.InsertionSortCheckBox.Location = New System.Drawing.Point(12, 77)
        Me.InsertionSortCheckBox.Name = "InsertionSortCheckBox"
        Me.InsertionSortCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.InsertionSortCheckBox.TabIndex = 3
        Me.InsertionSortCheckBox.Text = "Insertion Sort"
        Me.InsertionSortCheckBox.UseVisualStyleBackColor = True
        '
        'MedianOf3CheckBox
        '
        Me.MedianOf3CheckBox.AutoSize = True
        Me.MedianOf3CheckBox.Location = New System.Drawing.Point(12, 53)
        Me.MedianOf3CheckBox.Name = "MedianOf3CheckBox"
        Me.MedianOf3CheckBox.Size = New System.Drawing.Size(82, 17)
        Me.MedianOf3CheckBox.TabIndex = 2
        Me.MedianOf3CheckBox.Text = "Median-of-3"
        Me.MedianOf3CheckBox.UseVisualStyleBackColor = True
        '
        'QuickSortCheckBox
        '
        Me.QuickSortCheckBox.AutoSize = True
        Me.QuickSortCheckBox.Location = New System.Drawing.Point(12, 29)
        Me.QuickSortCheckBox.Name = "QuickSortCheckBox"
        Me.QuickSortCheckBox.Size = New System.Drawing.Size(76, 17)
        Me.QuickSortCheckBox.TabIndex = 1
        Me.QuickSortCheckBox.Text = "Quick Sort"
        Me.QuickSortCheckBox.UseVisualStyleBackColor = True
        '
        'SelectionSortCheckBox
        '
        Me.SelectionSortCheckBox.AutoSize = True
        Me.SelectionSortCheckBox.Location = New System.Drawing.Point(13, 6)
        Me.SelectionSortCheckBox.Name = "SelectionSortCheckBox"
        Me.SelectionSortCheckBox.Size = New System.Drawing.Size(92, 17)
        Me.SelectionSortCheckBox.TabIndex = 0
        Me.SelectionSortCheckBox.Text = "Selection Sort"
        Me.SelectionSortCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 581)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LineMultiplier)
        Me.Controls.Add(Me.Clear_Btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DisplayBox)
        Me.Controls.Add(Me.NlogNVisBtn)
        Me.Controls.Add(Me.logNVisBtn)
        Me.Controls.Add(Me.nVisBtn)
        Me.Controls.Add(Me.NsqrVisBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AutomatedButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.InputSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NumOfRuns)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RandSerBtn)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Form1"
        Me.Text = "VBgraphing"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumOfRuns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.InputSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.LineMultiplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents RandSerBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumOfRuns As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents InsertionSortRadio As System.Windows.Forms.RadioButton
    Friend WithEvents MedianQuickRadio As System.Windows.Forms.RadioButton
    Friend WithEvents QuickSortRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SelectionSortRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RandomRadio As System.Windows.Forms.RadioButton
    Friend WithEvents NearlySortedRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DecArrayRadio As System.Windows.Forms.RadioButton
    Friend WithEvents IncArrayRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InputSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ComparisonsRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ClockCyclesRadio As System.Windows.Forms.RadioButton
    Friend WithEvents AutomatedButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NsqrVisBtn As System.Windows.Forms.CheckBox
    Friend WithEvents nVisBtn As System.Windows.Forms.CheckBox
    Friend WithEvents logNVisBtn As System.Windows.Forms.CheckBox
    Friend WithEvents NlogNVisBtn As System.Windows.Forms.CheckBox
    Friend WithEvents DisplayBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Clear_Btn As System.Windows.Forms.Button
    Friend WithEvents BubbleSortRadio As System.Windows.Forms.RadioButton
    Friend WithEvents LineMultiplier As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MergeSortRadio As System.Windows.Forms.RadioButton
    Friend WithEvents VBSortRadio As System.Windows.Forms.RadioButton
    Friend WithEvents BucketSortRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents VBSortCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BucketSortCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MergeSortCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BubbleSortCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents InsertionSortCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MedianOf3CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QuickSortCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SelectionSortCheckBox As System.Windows.Forms.CheckBox

End Class
