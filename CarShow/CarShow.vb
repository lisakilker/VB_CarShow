Public Class frmCarShow
    Public Shared _intSizeOfArray As Integer = 10
    Private _strCarName(_intSizeOfArray) As String
    Private _intCarValue(_intSizeOfArray) As Integer
    Private _decTotalValue As Decimal

    Private Sub frmCarShow_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strLocationOfFile As String = "E:\cars.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim intFillValues As Integer
        Dim strFileError As String = "That file cannot be found"

        If IO.File.Exists(strLocationOfFile) Then
            objReader = IO.File.OpenText(strLocationOfFile)

            Do While objReader.Peek <> -1
                _strCarName(intCount) = objReader.ReadLine()
                _intCarValue(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()

            For intFill = 0 To (_strCarName.Length - 1)
                Array.Sort(_strCarName)
                lstDisplay.Items.Add(_strCarName(intFill))
                lblTotalCarsInShow.Text = "Total Cars in Show: " & _strCarName.Length.ToString
            Next

            For intFillValues = 0 To (_intCarValue.Length - 1)
                _decTotalValue += (_intCarValue(intFillValues))
                lblTotalValueOfCars.Text = "Total Value of Cars: " & _decTotalValue.ToString("C0")
            Next
        Else
            MsgBox(strFileError, , "File Error")
            Close()
        End If

        lstDisplay.Visible = True
    End Sub
    Private Sub btnComputeInventory_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnComputeInventory.Click

        MakeObjectsVisible()
        
    End Sub
    Private Sub MakeObjectsVisible()
        lblTotalCarsInShow.Visible = True
        lblTotalValueOfCars.Visible = True
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lblTotalCarsInShow.Visible = False
        lblTotalValueOfCars.Visible = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

End Class




