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
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Clear_Btn = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumOfRuns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.InputSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        Me.Chart1.Size = New System.Drawing.Size(783, 520)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(806, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Number of Runs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " per Array Size:"
        '
        'NumOfRuns
        '
        Me.NumOfRuns.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumOfRuns.Location = New System.Drawing.Point(896, 459)
        Me.NumOfRuns.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NumOfRuns.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumOfRuns.Name = "NumOfRuns"
        Me.NumOfRuns.Size = New System.Drawing.Size(70, 20)
        Me.NumOfRuns.TabIndex = 9
        Me.NumOfRuns.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BubbleSortRadio)
        Me.Panel1.Controls.Add(Me.InsertionSortRadio)
        Me.Panel1.Controls.Add(Me.MedianQuickRadio)
        Me.Panel1.Controls.Add(Me.QuickSortRadio)
        Me.Panel1.Controls.Add(Me.SelectionSortRadio)
        Me.Panel1.Location = New System.Drawing.Point(826, 279)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 124)
        Me.Panel1.TabIndex = 12
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
        Me.Panel2.Location = New System.Drawing.Point(826, 121)
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
        Me.Label2.Location = New System.Drawing.Point(806, 427)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Max Array Size:"
        '
        'InputSize
        '
        Me.InputSize.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.InputSize.Location = New System.Drawing.Point(896, 425)
        Me.InputSize.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.InputSize.Name = "InputSize"
        Me.InputSize.Size = New System.Drawing.Size(70, 20)
        Me.InputSize.TabIndex = 16
        Me.InputSize.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ComparisonsRadio)
        Me.Panel3.Controls.Add(Me.ClockCyclesRadio)
        Me.Panel3.Location = New System.Drawing.Point(826, 220)
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
        Me.AutomatedButton.Location = New System.Drawing.Point(810, 497)
        Me.AutomatedButton.Name = "AutomatedButton"
        Me.AutomatedButton.Size = New System.Drawing.Size(75, 23)
        Me.AutomatedButton.TabIndex = 19
        Me.AutomatedButton.Text = "Automate"
        Me.AutomatedButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(983, 71)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(298, 457)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.WordWrap = False
        '
        'NsqrVisBtn
        '
        Me.NsqrVisBtn.AutoSize = True
        Me.NsqrVisBtn.Location = New System.Drawing.Point(826, 47)
        Me.NsqrVisBtn.Name = "NsqrVisBtn"
        Me.NsqrVisBtn.Size = New System.Drawing.Size(77, 17)
        Me.NsqrVisBtn.TabIndex = 21
        Me.NsqrVisBtn.Text = "n^2 Visible"
        Me.NsqrVisBtn.UseVisualStyleBackColor = True
        '
        'nVisBtn
        '
        Me.nVisBtn.AutoSize = True
        Me.nVisBtn.Location = New System.Drawing.Point(826, 24)
        Me.nVisBtn.Name = "nVisBtn"
        Me.nVisBtn.Size = New System.Drawing.Size(65, 17)
        Me.nVisBtn.TabIndex = 25
        Me.nVisBtn.Text = "n Visible"
        Me.nVisBtn.UseVisualStyleBackColor = True
        '
        'logNVisBtn
        '
        Me.logNVisBtn.AutoSize = True
        Me.logNVisBtn.Location = New System.Drawing.Point(826, 71)
        Me.logNVisBtn.Name = "logNVisBtn"
        Me.logNVisBtn.Size = New System.Drawing.Size(86, 17)
        Me.logNVisBtn.TabIndex = 26
        Me.logNVisBtn.Text = "Log n Visible"
        Me.logNVisBtn.UseVisualStyleBackColor = True
        '
        'NlogNVisBtn
        '
        Me.NlogNVisBtn.AutoSize = True
        Me.NlogNVisBtn.Location = New System.Drawing.Point(826, 95)
        Me.NlogNVisBtn.Name = "NlogNVisBtn"
        Me.NlogNVisBtn.Size = New System.Drawing.Size(91, 17)
        Me.NlogNVisBtn.TabIndex = 28
        Me.NlogNVisBtn.Text = "n log n Visible"
        Me.NlogNVisBtn.UseVisualStyleBackColor = True
        '
        'DisplayBox
        '
        Me.DisplayBox.AutoSize = True
        Me.DisplayBox.Location = New System.Drawing.Point(983, 24)
        Me.DisplayBox.Name = "DisplayBox"
        Me.DisplayBox.Size = New System.Drawing.Size(145, 17)
        Me.DisplayBox.TabIndex = 29
        Me.DisplayBox.Text = "Display Un/Sorted Arrays"
        Me.DisplayBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(980, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Array Display:"
        '
        'Clear_Btn
        '
        Me.Clear_Btn.Location = New System.Drawing.Point(891, 497)
        Me.Clear_Btn.Name = "Clear_Btn"
        Me.Clear_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Btn.TabIndex = 33
        Me.Clear_Btn.Text = "Clear Chart"
        Me.Clear_Btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 543)
        Me.Controls.Add(Me.Clear_Btn)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
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
    Friend WithEvents Clear_Btn As System.Windows.Forms.Button
    Friend WithEvents BubbleSortRadio As System.Windows.Forms.RadioButton

End Class
