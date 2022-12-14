Imports DevExpress.XtraPivotGrid
Imports System.Drawing
Imports System.Windows.Forms

Namespace PivotCustomDraw

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ' This line of code is generated by Data Source Configuration Wizard
            ' Fill the ExcelDataSource
            excelDataSource1.Fill()
        End Sub

        Private Sub pivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As PivotCustomDrawCellEventArgs)
            Dim r As Rectangle
            ' Paints Row Grand Totals.
            If e.RowValueType = PivotGridValueType.GrandTotal Then
                Dim brushFillTotals As Brush
                brushFillTotals = e.GraphicsCache.GetSolidBrush(ColorTranslator.FromHtml("#0099cc"))
                r = e.Bounds
                e.GraphicsCache.FillRectangle(brushFillTotals, e.Bounds)
                r.Inflate(-4, -4)
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font, Brushes.White, r, e.Appearance.GetStringFormat())
                e.Handled = True
                Return
            End If

            ' Paints the data cells.
            Dim brushFill As Brush
            r = e.Bounds
            If e.Focused Then
                ' Initializes the brush used to paint the focused cell.
                brushFill = e.GraphicsCache.GetSolidBrush(Color.White)
            ElseIf e.Selected Then
                ' Initializes the brush used to paint selected cells.
                brushFill = e.GraphicsCache.GetSolidBrush(ColorTranslator.FromHtml("#b6e7eb"))
            Else
                ' Initializes the brush used to paint data cells.
                brushFill = e.GraphicsCache.GetSolidBrush(ColorTranslator.FromHtml("#ecfbf8"))
            End If

            e.GraphicsCache.DrawRectangle(Pens.DimGray, r)
            r.Inflate(-1, -1)
            e.GraphicsCache.FillRectangle(brushFill, r)
            If e.Focused Then
                r.Inflate(-1, -1)
                e.GraphicsCache.DrawRectangle(e.GraphicsCache.GetPen(ColorTranslator.FromHtml("#f05b41"), 3), r)
            End If

            r.Inflate(-4, -4)
            e.Appearance.DrawString(e.GraphicsCache, e.DisplayText, r)
            e.Handled = True
        End Sub
    End Class
End Namespace
