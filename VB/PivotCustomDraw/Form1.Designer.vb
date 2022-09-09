Namespace PivotCustomDraw

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PivotCustomDraw.Form1))
            Dim fieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim excelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim excelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.excelDataSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.pivotGridField4})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(800, 450)
            Me.pivotGridControl1.TabIndex = 0
            AddHandler Me.pivotGridControl1.CustomDrawCell, New DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(AddressOf Me.pivotGridControl1_CustomDrawCell)
            ' 
            ' excelDataSource1
            ' 
            Me.excelDataSource1.FileName = "Data\Sales.xlsx"
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
            fieldInfo1.Name = "Category"
            fieldInfo1.OriginalName = "Category"
            fieldInfo1.Type = GetType(String)
            fieldInfo2.Name = "Product"
            fieldInfo2.OriginalName = "Product"
            fieldInfo2.Type = GetType(String)
            fieldInfo3.Name = "State"
            fieldInfo3.OriginalName = "State"
            fieldInfo3.Type = GetType(String)
            fieldInfo4.Name = "UnitsSoldYTD (Sum)"
            fieldInfo4.OriginalName = "UnitsSoldYTD (Sum)"
            fieldInfo4.Selected = False
            fieldInfo4.Type = GetType(Double)
            fieldInfo5.Name = "UnitsSoldYTDTarget (Sum)"
            fieldInfo5.OriginalName = "UnitsSoldYTDTarget (Sum)"
            fieldInfo5.Selected = False
            fieldInfo5.Type = GetType(Double)
            fieldInfo6.Name = "RevenueQTD (Sum)"
            fieldInfo6.OriginalName = "RevenueQTD (Sum)"
            fieldInfo6.Selected = False
            fieldInfo6.Type = GetType(Double)
            fieldInfo7.Name = "RevenueQTDTarget (Sum)"
            fieldInfo7.OriginalName = "RevenueQTDTarget (Sum)"
            fieldInfo7.Selected = False
            fieldInfo7.Type = GetType(Double)
            fieldInfo8.Name = "RevenueYTD (Sum)"
            fieldInfo8.OriginalName = "RevenueYTD (Sum)"
            fieldInfo8.Type = GetType(Double)
            fieldInfo9.Name = "RevenueYTDTarget (Sum)"
            fieldInfo9.OriginalName = "RevenueYTDTarget (Sum)"
            fieldInfo9.Selected = False
            fieldInfo9.Type = GetType(Double)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9})
            excelWorksheetSettings1.CellRange = Nothing
            excelWorksheetSettings1.WorksheetIndex = Nothing
            excelWorksheetSettings1.WorksheetName = "Sheet1"
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1
            Me.excelDataSource1.SourceOptions = excelSourceOptions1
            ' 
            ' pivotGridField1
            ' 
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pivotGridField1.AreaIndex = 0
            Me.pivotGridField1.Caption = "Category"
            dataSourceColumnBinding1.ColumnName = "Category"
            Me.pivotGridField1.DataBinding = dataSourceColumnBinding1
            Me.pivotGridField1.Name = "pivotGridField1"
            ' 
            ' pivotGridField2
            ' 
            Me.pivotGridField2.AreaIndex = 0
            Me.pivotGridField2.Caption = "Product"
            dataSourceColumnBinding2.ColumnName = "Product"
            Me.pivotGridField2.DataBinding = dataSourceColumnBinding2
            Me.pivotGridField2.Name = "pivotGridField2"
            ' 
            ' pivotGridField3
            ' 
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField3.AreaIndex = 0
            Me.pivotGridField3.Caption = "State"
            dataSourceColumnBinding3.ColumnName = "State"
            Me.pivotGridField3.DataBinding = dataSourceColumnBinding3
            Me.pivotGridField3.Name = "pivotGridField3"
            ' 
            ' pivotGridField4
            ' 
            Me.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField4.AreaIndex = 0
            Me.pivotGridField4.Caption = "Revenue YTD (Sum)"
            Me.pivotGridField4.CellFormat.FormatString = "c0"
            Me.pivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            dataSourceColumnBinding4.ColumnName = "RevenueYTD (Sum)"
            Me.pivotGridField4.DataBinding = dataSourceColumnBinding4
            Me.pivotGridField4.Name = "pivotGridField4"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource

        Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
