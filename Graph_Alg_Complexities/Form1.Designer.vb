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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumOfRuns = New System.Windows.Forms.NumericUpDown()
        Me.ArrayPanel = New System.Windows.Forms.Panel()
        Me.RandomRadio = New System.Windows.Forms.RadioButton()
        Me.NearlySortedRadio = New System.Windows.Forms.RadioButton()
        Me.DecArrayRadio = New System.Windows.Forms.RadioButton()
        Me.IncArrayRadio = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InputSize = New System.Windows.Forms.NumericUpDown()
        Me.MetricPanel = New System.Windows.Forms.Panel()
        Me.ClockRadio = New System.Windows.Forms.RadioButton()
        Me.CompsRadio = New System.Windows.Forms.RadioButton()
        Me.DispResBox = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NsqrVisBtn = New System.Windows.Forms.CheckBox()
        Me.nVisBtn = New System.Windows.Forms.CheckBox()
        Me.logNVisBtn = New System.Windows.Forms.CheckBox()
        Me.NlogNVisBtn = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Clear_Btn = New System.Windows.Forms.Button()
        Me.LineMultiplier = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SortProgress = New System.Windows.Forms.ProgressBar()
        Me.BeginSorting = New System.Windows.Forms.Button()
        Me.SortList = New System.Windows.Forms.CheckedListBox()
        Me.DisplayBox = New System.Windows.Forms.CheckBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumOfRuns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArrayPanel.SuspendLayout()
        CType(Me.InputSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetricPanel.SuspendLayout()
        CType(Me.LineMultiplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.AxisX.MajorGrid.IntervalOffset = 0.0R
        ChartArea1.AxisX.Minimum = 0.0R
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Legend = "Legend1"
        Series4.Name = "Series4"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(783, 557)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(983, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Number of Runs:"
        '
        'NumOfRuns
        '
        Me.NumOfRuns.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumOfRuns.Location = New System.Drawing.Point(1073, 40)
        Me.NumOfRuns.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.NumOfRuns.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumOfRuns.Name = "NumOfRuns"
        Me.NumOfRuns.Size = New System.Drawing.Size(120, 20)
        Me.NumOfRuns.TabIndex = 21
        Me.NumOfRuns.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'ArrayPanel
        '
        Me.ArrayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ArrayPanel.Controls.Add(Me.RandomRadio)
        Me.ArrayPanel.Controls.Add(Me.NearlySortedRadio)
        Me.ArrayPanel.Controls.Add(Me.DecArrayRadio)
        Me.ArrayPanel.Controls.Add(Me.IncArrayRadio)
        Me.ArrayPanel.Location = New System.Drawing.Point(825, 176)
        Me.ArrayPanel.Name = "ArrayPanel"
        Me.ArrayPanel.Size = New System.Drawing.Size(125, 93)
        Me.ArrayPanel.TabIndex = 100
        '
        'RandomRadio
        '
        Me.RandomRadio.AutoSize = True
        Me.RandomRadio.Location = New System.Drawing.Point(14, 72)
        Me.RandomRadio.Name = "RandomRadio"
        Me.RandomRadio.Size = New System.Drawing.Size(65, 17)
        Me.RandomRadio.TabIndex = 9
        Me.RandomRadio.Text = "Random"
        Me.RandomRadio.UseVisualStyleBackColor = True
        '
        'NearlySortedRadio
        '
        Me.NearlySortedRadio.AutoSize = True
        Me.NearlySortedRadio.Location = New System.Drawing.Point(14, 49)
        Me.NearlySortedRadio.Name = "NearlySortedRadio"
        Me.NearlySortedRadio.Size = New System.Drawing.Size(89, 17)
        Me.NearlySortedRadio.TabIndex = 8
        Me.NearlySortedRadio.Text = "Nearly Sorted"
        Me.NearlySortedRadio.UseVisualStyleBackColor = True
        '
        'DecArrayRadio
        '
        Me.DecArrayRadio.AutoSize = True
        Me.DecArrayRadio.Location = New System.Drawing.Point(14, 26)
        Me.DecArrayRadio.Name = "DecArrayRadio"
        Me.DecArrayRadio.Size = New System.Drawing.Size(106, 17)
        Me.DecArrayRadio.TabIndex = 7
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
        Me.IncArrayRadio.TabIndex = 6
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
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Max Array Size:"
        '
        'InputSize
        '
        Me.InputSize.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.InputSize.Location = New System.Drawing.Point(1073, 12)
        Me.InputSize.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.InputSize.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.InputSize.Name = "InputSize"
        Me.InputSize.Size = New System.Drawing.Size(120, 20)
        Me.InputSize.TabIndex = 20
        Me.InputSize.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'MetricPanel
        '
        Me.MetricPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetricPanel.Controls.Add(Me.ClockRadio)
        Me.MetricPanel.Controls.Add(Me.CompsRadio)
        Me.MetricPanel.Controls.Add(Me.DispResBox)
        Me.MetricPanel.Location = New System.Drawing.Point(825, 285)
        Me.MetricPanel.Name = "MetricPanel"
        Me.MetricPanel.Size = New System.Drawing.Size(125, 81)
        Me.MetricPanel.TabIndex = 101
        Me.MetricPanel.TabStop = True
        '
        'ClockRadio
        '
        Me.ClockRadio.AutoSize = True
        Me.ClockRadio.Enabled = False
        Me.ClockRadio.Location = New System.Drawing.Point(14, 52)
        Me.ClockRadio.Name = "ClockRadio"
        Me.ClockRadio.Size = New System.Drawing.Size(86, 17)
        Me.ClockRadio.TabIndex = 2
        Me.ClockRadio.Text = "Clock Cycles"
        Me.ClockRadio.UseVisualStyleBackColor = True
        '
        'CompsRadio
        '
        Me.CompsRadio.AutoSize = True
        Me.CompsRadio.Enabled = False
        Me.CompsRadio.Location = New System.Drawing.Point(14, 28)
        Me.CompsRadio.Name = "CompsRadio"
        Me.CompsRadio.Size = New System.Drawing.Size(85, 17)
        Me.CompsRadio.TabIndex = 1
        Me.CompsRadio.Text = "Comparisons"
        Me.CompsRadio.UseVisualStyleBackColor = True
        '
        'DispResBox
        '
        Me.DispResBox.AutoSize = True
        Me.DispResBox.Location = New System.Drawing.Point(14, 4)
        Me.DispResBox.Name = "DispResBox"
        Me.DispResBox.Size = New System.Drawing.Size(98, 17)
        Me.DispResBox.TabIndex = 0
        Me.DispResBox.Text = "Display Results"
        Me.DispResBox.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(983, 87)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(298, 182)
        Me.TextBox1.TabIndex = 107
        '
        'NsqrVisBtn
        '
        Me.NsqrVisBtn.AutoSize = True
        Me.NsqrVisBtn.Location = New System.Drawing.Point(825, 79)
        Me.NsqrVisBtn.Name = "NsqrVisBtn"
        Me.NsqrVisBtn.Size = New System.Drawing.Size(77, 17)
        Me.NsqrVisBtn.TabIndex = 4
        Me.NsqrVisBtn.Text = "n^2 Visible"
        Me.NsqrVisBtn.UseVisualStyleBackColor = True
        '
        'nVisBtn
        '
        Me.nVisBtn.AutoSize = True
        Me.nVisBtn.Location = New System.Drawing.Point(825, 33)
        Me.nVisBtn.Name = "nVisBtn"
        Me.nVisBtn.Size = New System.Drawing.Size(65, 17)
        Me.nVisBtn.TabIndex = 2
        Me.nVisBtn.Text = "n Visible"
        Me.nVisBtn.UseVisualStyleBackColor = True
        '
        'logNVisBtn
        '
        Me.logNVisBtn.AutoSize = True
        Me.logNVisBtn.Location = New System.Drawing.Point(825, 10)
        Me.logNVisBtn.Name = "logNVisBtn"
        Me.logNVisBtn.Size = New System.Drawing.Size(86, 17)
        Me.logNVisBtn.TabIndex = 1
        Me.logNVisBtn.Text = "Log n Visible"
        Me.logNVisBtn.UseVisualStyleBackColor = True
        '
        'NlogNVisBtn
        '
        Me.NlogNVisBtn.AutoSize = True
        Me.NlogNVisBtn.Location = New System.Drawing.Point(825, 56)
        Me.NlogNVisBtn.Name = "NlogNVisBtn"
        Me.NlogNVisBtn.Size = New System.Drawing.Size(91, 17)
        Me.NlogNVisBtn.TabIndex = 3
        Me.NlogNVisBtn.Text = "n log n Visible"
        Me.NlogNVisBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(986, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Array Display:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1199, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Per Array Size"
        '
        'Clear_Btn
        '
        Me.Clear_Btn.Location = New System.Drawing.Point(983, 362)
        Me.Clear_Btn.Name = "Clear_Btn"
        Me.Clear_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Btn.TabIndex = 24
        Me.Clear_Btn.Text = "Clear Chart"
        Me.Clear_Btn.UseVisualStyleBackColor = True
        '
        'LineMultiplier
        '
        Me.LineMultiplier.DecimalPlaces = 5
        Me.LineMultiplier.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.LineMultiplier.Location = New System.Drawing.Point(817, 119)
        Me.LineMultiplier.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.LineMultiplier.Minimum = New Decimal(New Integer() {25, 0, 0, 327680})
        Me.LineMultiplier.Name = "LineMultiplier"
        Me.LineMultiplier.Size = New System.Drawing.Size(56, 20)
        Me.LineMultiplier.TabIndex = 5
        Me.LineMultiplier.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(879, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Line Multiplier"
        '
        'SortProgress
        '
        Me.SortProgress.Location = New System.Drawing.Point(983, 285)
        Me.SortProgress.Name = "SortProgress"
        Me.SortProgress.Size = New System.Drawing.Size(100, 23)
        Me.SortProgress.Step = 1
        Me.SortProgress.TabIndex = 37
        Me.SortProgress.Value = 2
        '
        'BeginSorting
        '
        Me.BeginSorting.Location = New System.Drawing.Point(983, 333)
        Me.BeginSorting.Name = "BeginSorting"
        Me.BeginSorting.Size = New System.Drawing.Size(75, 23)
        Me.BeginSorting.TabIndex = 109
        Me.BeginSorting.Text = "Run"
        Me.BeginSorting.UseVisualStyleBackColor = True
        '
        'SortList
        '
        Me.SortList.CheckOnClick = True
        Me.SortList.FormattingEnabled = True
        Me.SortList.Items.AddRange(New Object() {"Selection Sort", "Quick Sort", "Median-of-3", "Insertion Sort", "Bubble Sort", "Merge Sort", "Bucket Sort", "VB Sort"})
        Me.SortList.Location = New System.Drawing.Point(825, 391)
        Me.SortList.Name = "SortList"
        Me.SortList.Size = New System.Drawing.Size(125, 124)
        Me.SortList.TabIndex = 102
        '
        'DisplayBox
        '
        Me.DisplayBox.AutoSize = True
        Me.DisplayBox.Location = New System.Drawing.Point(1106, 291)
        Me.DisplayBox.Name = "DisplayBox"
        Me.DisplayBox.Size = New System.Drawing.Size(145, 17)
        Me.DisplayBox.TabIndex = 22
        Me.DisplayBox.Text = "Display Un/Sorted Arrays"
        Me.DisplayBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 581)
        Me.Controls.Add(Me.SortList)
        Me.Controls.Add(Me.BeginSorting)
        Me.Controls.Add(Me.SortProgress)
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
        Me.Controls.Add(Me.MetricPanel)
        Me.Controls.Add(Me.InputSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ArrayPanel)
        Me.Controls.Add(Me.NumOfRuns)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Form1"
        Me.Text = "VBgraphing"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumOfRuns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArrayPanel.ResumeLayout(False)
        Me.ArrayPanel.PerformLayout()
        CType(Me.InputSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetricPanel.ResumeLayout(False)
        Me.MetricPanel.PerformLayout()
        CType(Me.LineMultiplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumOfRuns As System.Windows.Forms.NumericUpDown
    Friend WithEvents ArrayPanel As System.Windows.Forms.Panel
    Friend WithEvents RandomRadio As System.Windows.Forms.RadioButton
    Friend WithEvents NearlySortedRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DecArrayRadio As System.Windows.Forms.RadioButton
    Friend WithEvents IncArrayRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InputSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents MetricPanel As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NsqrVisBtn As System.Windows.Forms.CheckBox
    Friend WithEvents nVisBtn As System.Windows.Forms.CheckBox
    Friend WithEvents logNVisBtn As System.Windows.Forms.CheckBox
    Friend WithEvents NlogNVisBtn As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Clear_Btn As System.Windows.Forms.Button
    Friend WithEvents LineMultiplier As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SortProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents BeginSorting As System.Windows.Forms.Button
    Friend WithEvents SortList As System.Windows.Forms.CheckedListBox
    Friend WithEvents DisplayBox As System.Windows.Forms.CheckBox
    Friend WithEvents ClockRadio As System.Windows.Forms.RadioButton
    Friend WithEvents CompsRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DispResBox As System.Windows.Forms.CheckBox

End Class
