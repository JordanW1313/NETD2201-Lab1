'Turns Strict variable typing on
Option Strict On
Public Class frmAverageUnitsShipped
    Dim days(6) As Integer              'Declares an integer array called days with 7 elements
    Dim currentElement As Integer = 0   'Declares an integer variable called currentElement
    Dim runningTotal As Integer         'Declares an integer variable called runningTotal
    Dim averageValue As Double          'Declares a Double variable called averageValue

    ''' <summary>
    ''' When the user clicks enter if it is not at the 7th element of the array the the value
    ''' in the entry text box is validated and added to the array and the display text box and running total.
    ''' If it is the last element in the array then the entry is added to the list and running total.
    ''' The entry text box and enter button are diabled and average is then calculated and outputed in a 
    ''' string to the output label. If the value is ever invalid a message box is shown and the focus is
    ''' set back to the entry text box for correction.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnEnterClick(sender As Object, e As EventArgs) Handles btnEnter.Click
        'If the currentElement variable is less than 7 the following code block runs
        If currentElement < 7 Then
            'If the value in the input text box is a whole number it is assigned to the current element of the days
            'array and the following code block runs.
            If Integer.TryParse(txtInput.Text, days(currentElement)) Then
                'If the input value is in the valid range the following code block runs
                If days(currentElement) >= 0 And days(currentElement) <= 5000 Then
                    'The value of the text input box is appeneded to the input display text box and a new line is added
                    txtInputDisplay.AppendText(days(currentElement) & Environment.NewLine)
                    'The value of the text input is added to te running total
                    runningTotal += days(currentElement)
                    'The current element is incremented by one
                    currentElement = currentElement + 1
                    'The day label is set to the value of the current element plus one
                    lblDay.Text = "Day " & (currentElement + 1)
                    'The input text box is set to a blank string
                    txtInput.Text = ""
                    'The focus is set back to the input text box
                    txtInput.Focus()

                    'If the current element equals 7 the following code runs
                    If currentElement = 7 Then
                        'The day lable is set to Day 7
                        lblDay.Text = "Day 7"
                        'The text input text box is disabled
                        txtInput.ReadOnly = True
                        'the enter button is disabled
                        btnEnter.Enabled = False
                        'The average is calculated from the running total
                        averageValue = runningTotal / 7
                        'The output message is displayed to the output label
                        lblOutput.Text = "Average per day:" & CStr(Math.Round(averageValue, 2))
                    End If
                    'If the input value is not in the valid range the following code block is run
                Else
                    'A message box is diplayed with the message "Units shipped must be between 0 and 5000"
                    MessageBox.Show("Units shipped must be between 0 and 5000")
                    'The focus is set back to the input text box for correction
                    txtInput.Focus()
                End If
                'If the input value is not a whole number then the following code block is run
            Else
                'A message box is displayed with the message "Must be a whole numeric value"
                MessageBox.Show("Must be a whole numeric value")
                'The focus is set back to the input text box for correction
                txtInput.Focus()
            End If
        End If
    End Sub

    ''' <summary>
    ''' This event handler sets all the labels and variables back to their defualt state when the reset button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnResetClick(sender As Object, e As EventArgs) Handles btnReset.Click
        'A for each statement that goes through and sets the value for each element of the days array to 0
        For Each day As Integer In days
            'Sets the current element's value to 0
            day = 0
        Next
        'Sets the currentElement variable back to 0
        currentElement = 0
        'Sets the runningTotal Variable to 0
        runningTotal = 0
        'Clears the input display text bos
        txtInputDisplay.Clear()
        'Sets the output label to a blank string
        lblOutput.Text = ""
        'Sets the day label back to Day 1
        lblDay.Text = "Day 1"
        'Enables the input text box
        txtInput.ReadOnly = False
        'Enables the enter button
        btnEnter.Enabled = True
        'Sets the focus to the input text box
        txtInput.Focus()
    End Sub

    ''' <summary>
    ''' This event handler exits the program when the exit button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnExitClick(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the program
        Application.Exit()
    End Sub
End Class
