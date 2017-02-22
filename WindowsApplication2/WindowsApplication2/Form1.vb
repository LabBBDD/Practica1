Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim ec As Ecuacion
        Dim A, B, C As Double
        If Not Double.TryParse(aux1.Text, A) Or Not Double.TryParse(aux1.Text, B) Or Not Double.TryParse(aux3.Text, C) Then
            MsgBox("Formato de datos incorrecto, por favor vuelva a introducir los datos")
            Exit Sub
        End If


        If A = 0 Then
            MsgBox("LO QUE INTENTA RESOLVER NO ES UNA ECUACIÓN DE SEGUNDO GRADO")
        Else
            ec = New Ecuacion(A, B, C)
            ec.Calcular()
            txtRaiz1.ForeColor = Color.Blue
            txtRaiz2.ForeColor = Color.Blue
            If ec.pflag() = 0 Then
                LblTipoRaiz.Text = "La ecuación introducida tiene dos raices reales"
                txtRaiz1.Text = Math.Round(ec.px1, 2).ToString
                txtRaiz2.Text = Math.Round(ec.px2, 2).ToString
            ElseIf ec.pflag() = 1 Then
                LblTipoRaiz.Text = "La ecuación introducida tiene una raiz real doble"
                txtRaiz1.Text = Math.Round(ec.px1, 2).ToString
                txtRaiz2.Clear()
                txtRaiz2.Enabled = False
            ElseIf ec.pflag() = 2 Then
                LblTipoRaiz.Text = "La ecuación introducida tiene dos raices imaginarias"
                txtRaiz1.ForeColor = Color.Red
                txtRaiz2.ForeColor = Color.Red
                txtRaiz1.Text = Math.Round(ec.px1, 2).ToString + " + " + Math.Round(ec.px2, 2).ToString + "i"
                txtRaiz2.Text = Math.Round(ec.px1, 2).ToString + " - " + Math.Round(ec.px2, 2).ToString + "i"
            End If
        End If
        Select Case MsgBox("¿QUIERES RESOLVER OTRA ECUACION?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                limpiar()
            Case MsgBoxResult.No
                Me.Close()

        End Select

    End Sub

    Private Sub limpiar()
        aux1.Text = ""
        aux2.Text = ""
        aux3.Text = ""
        LblTipoRaiz.Text = "Input A, B, and C values"
        txtRaiz1.Text = ""
        txtRaiz2.Text = ""
        txtRaiz2.Enabled = True
    End Sub

End Class

Public Class Ecuacion
    Private ma As Double
    Private mb As Double
    Private mc As Double
    Private mx1 As Double
    Private mx2 As Double
    Private mflag As Integer

    Public Sub New(ByVal A As Double, ByVal B As Double, ByVal C As Double) 'CONSTRUCTOR

        Me.ma = A
        Me.mb = B
        Me.mc = C

    End Sub

    Public Property pa As Double
        Get
            Return Me.ma
        End Get
        Set(value As Double)
            Me.ma = value
        End Set
    End Property

    Public Property pb As Double
        Get
            Return Me.mb
        End Get
        Set(value As Double)
            Me.mb = value
        End Set
    End Property

    Public Property pc As Double
        Get
            Return Me.mc
        End Get
        Set(value As Double)
            Me.mc = value
        End Set
    End Property

    Public Property px1 As Double
        Get
            Return Me.mx1
        End Get
        Set(value As Double)
            Me.mx1 = value
        End Set
    End Property

    Public Property px2 As Double
        Get
            Return Me.mx2
        End Get
        Set(value As Double)
            Me.mx2 = value
        End Set
    End Property

    Public Property pflag As Integer
        Get
            Return Me.mflag
        End Get
        Set(value As Integer)
            Me.mflag = value
        End Set
    End Property

    Public Sub Calcular()
        Dim discriminante As Double
        discriminante = Me.mb * Me.mb - 4 * Me.ma * Me.mc

        If discriminante > 0 Then
            Me.mflag = 0
            Me.mx1 = (-Me.mb + Math.Sqrt(discriminante)) / (2 * Me.ma)
            Me.mx2 = (-Me.mb - Math.Sqrt(discriminante)) / (2 * Me.ma)

        ElseIf discriminante = 0 Then
            Me.mflag = 1
            Me.mx1 = -Me.mb / (2 * Me.ma)

        ElseIf discriminante < 0 Then
            Me.mflag = 2
            discriminante *= -1
            Me.mx1 = -Me.mb / (2 * Me.ma)
            Me.mx2 = (Math.Sqrt(discriminante)) / (2 * Me.ma)
        End If
    End Sub

End Class

