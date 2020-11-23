Public Class Form1
    Private Sub BTNCalcTravelTime_Click(sender As Object, e As EventArgs) Handles BTNCalcTravelTime.Click
        'Declarations
        Dim AverageSpeed, TravelDistance, TravelTime As Decimal

        'Get User Inputs
        AverageSpeed = TBAverageSpeed.Text
        TravelDistance = TBTravelDistance.Text

        'Calculate Travel Time
        TravelTime = Math.Round(TravelDistance / AverageSpeed, 1)

        'Output The Travel Time
        TBTravelTime.Text = TravelTime & " h"
    End Sub
End Class
