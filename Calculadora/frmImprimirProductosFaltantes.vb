﻿Public Class frmImprimirProductosFaltantes
    Private Sub frmImprimirProductosFaltantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirProductosFaltantes' Puede moverla o quitarla según sea necesario.
        Me.ImprimirProductosFaltantesTableAdapter.FillImprimirProductosFaltantes(Me.bd_sigacDataSet.ImprimirProductosFaltantes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class