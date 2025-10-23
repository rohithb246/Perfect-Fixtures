<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DecorButton = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.KidsButton = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.WardrobeButton = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.ShelfButton = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.DiningButton = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.SofaButton = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.BedsButton = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(27, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1145, 542)
        Me.Panel1.TabIndex = 25
        '
        'DecorButton
        '
        Me.DecorButton.AnimationHoverSpeed = 0.07!
        Me.DecorButton.AnimationSpeed = 0.03!
        Me.DecorButton.BackColor = System.Drawing.Color.Black
        Me.DecorButton.BaseColor = System.Drawing.Color.Transparent
        Me.DecorButton.BorderColor = System.Drawing.Color.Black
        Me.DecorButton.CheckedBaseColor = System.Drawing.Color.Gray
        Me.DecorButton.CheckedBorderColor = System.Drawing.Color.Black
        Me.DecorButton.CheckedForeColor = System.Drawing.Color.White
        Me.DecorButton.CheckedImage = CType(resources.GetObject("DecorButton.CheckedImage"), System.Drawing.Image)
        Me.DecorButton.CheckedLineColor = System.Drawing.Color.DimGray
        Me.DecorButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DecorButton.FocusedColor = System.Drawing.Color.Empty
        Me.DecorButton.Font = New System.Drawing.Font("Mongolian Baiti", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecorButton.ForeColor = System.Drawing.Color.White
        Me.DecorButton.Image = Global.Perfect_Fixtures_Final.My.Resources.Resources.decor
        Me.DecorButton.ImageSize = New System.Drawing.Size(52, 52)
        Me.DecorButton.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DecorButton.Location = New System.Drawing.Point(1000, 13)
        Me.DecorButton.Name = "DecorButton"
        Me.DecorButton.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.DecorButton.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.DecorButton.OnHoverForeColor = System.Drawing.Color.White
        Me.DecorButton.OnHoverImage = Nothing
        Me.DecorButton.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DecorButton.OnPressedColor = System.Drawing.Color.Black
        Me.DecorButton.Size = New System.Drawing.Size(154, 93)
        Me.DecorButton.TabIndex = 24
        Me.DecorButton.Text = "Decor"
        '
        'KidsButton
        '
        Me.KidsButton.AnimationHoverSpeed = 0.07!
        Me.KidsButton.AnimationSpeed = 0.03!
        Me.KidsButton.BackColor = System.Drawing.Color.Black
        Me.KidsButton.BaseColor = System.Drawing.Color.Transparent
        Me.KidsButton.BorderColor = System.Drawing.Color.Black
        Me.KidsButton.CheckedBaseColor = System.Drawing.Color.Gray
        Me.KidsButton.CheckedBorderColor = System.Drawing.Color.Black
        Me.KidsButton.CheckedForeColor = System.Drawing.Color.White
        Me.KidsButton.CheckedImage = CType(resources.GetObject("KidsButton.CheckedImage"), System.Drawing.Image)
        Me.KidsButton.CheckedLineColor = System.Drawing.Color.DimGray
        Me.KidsButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.KidsButton.FocusedColor = System.Drawing.Color.Empty
        Me.KidsButton.Font = New System.Drawing.Font("Mongolian Baiti", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KidsButton.ForeColor = System.Drawing.Color.White
        Me.KidsButton.Image = Global.Perfect_Fixtures_Final.My.Resources.Resources.kids
        Me.KidsButton.ImageSize = New System.Drawing.Size(52, 52)
        Me.KidsButton.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.KidsButton.Location = New System.Drawing.Point(840, 13)
        Me.KidsButton.Name = "KidsButton"
        Me.KidsButton.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.KidsButton.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.KidsButton.OnHoverForeColor = System.Drawing.Color.White
        Me.KidsButton.OnHoverImage = Nothing
        Me.KidsButton.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.KidsButton.OnPressedColor = System.Drawing.Color.Black
        Me.KidsButton.Size = New System.Drawing.Size(154, 93)
        Me.KidsButton.TabIndex = 22
        Me.KidsButton.Text = "Kids"
        '
        'WardrobeButton
        '
        Me.WardrobeButton.AnimationHoverSpeed = 0.07!
        Me.WardrobeButton.AnimationSpeed = 0.03!
        Me.WardrobeButton.BackColor = System.Drawing.Color.Black
        Me.WardrobeButton.BaseColor = System.Drawing.Color.Transparent
        Me.WardrobeButton.BorderColor = System.Drawing.Color.Black
        Me.WardrobeButton.CheckedBaseColor = System.Drawing.Color.Gray
        Me.WardrobeButton.CheckedBorderColor = System.Drawing.Color.Black
        Me.WardrobeButton.CheckedForeColor = System.Drawing.Color.White
        Me.WardrobeButton.CheckedImage = CType(resources.GetObject("WardrobeButton.CheckedImage"), System.Drawing.Image)
        Me.WardrobeButton.CheckedLineColor = System.Drawing.Color.DimGray
        Me.WardrobeButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.WardrobeButton.FocusedColor = System.Drawing.Color.Empty
        Me.WardrobeButton.Font = New System.Drawing.Font("Mongolian Baiti", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WardrobeButton.ForeColor = System.Drawing.Color.White
        Me.WardrobeButton.Image = Global.Perfect_Fixtures_Final.My.Resources.Resources.wardrobe
        Me.WardrobeButton.ImageSize = New System.Drawing.Size(52, 52)
        Me.WardrobeButton.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.WardrobeButton.Location = New System.Drawing.Point(680, 13)
        Me.WardrobeButton.Name = "WardrobeButton"
        Me.WardrobeButton.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.WardrobeButton.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.WardrobeButton.OnHoverForeColor = System.Drawing.Color.White
        Me.WardrobeButton.OnHoverImage = Nothing
        Me.WardrobeButton.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.WardrobeButton.OnPressedColor = System.Drawing.Color.Black
        Me.WardrobeButton.Size = New System.Drawing.Size(154, 93)
        Me.WardrobeButton.TabIndex = 21
        Me.WardrobeButton.Text = "Wardrobes"
        '
        'ShelfButton
        '
        Me.ShelfButton.AnimationHoverSpeed = 0.07!
        Me.ShelfButton.AnimationSpeed = 0.03!
        Me.ShelfButton.BackColor = System.Drawing.Color.Black
        Me.ShelfButton.BaseColor = System.Drawing.Color.Transparent
        Me.ShelfButton.BorderColor = System.Drawing.Color.Black
        Me.ShelfButton.CheckedBaseColor = System.Drawing.Color.Gray
        Me.ShelfButton.CheckedBorderColor = System.Drawing.Color.Black
        Me.ShelfButton.CheckedForeColor = System.Drawing.Color.White
        Me.ShelfButton.CheckedImage = CType(resources.GetObject("ShelfButton.CheckedImage"), System.Drawing.Image)
        Me.ShelfButton.CheckedLineColor = System.Drawing.Color.DimGray
        Me.ShelfButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ShelfButton.FocusedColor = System.Drawing.Color.Empty
        Me.ShelfButton.Font = New System.Drawing.Font("Mongolian Baiti", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShelfButton.ForeColor = System.Drawing.Color.White
        Me.ShelfButton.Image = Global.Perfect_Fixtures_Final.My.Resources.Resources.shelves
        Me.ShelfButton.ImageSize = New System.Drawing.Size(52, 52)
        Me.ShelfButton.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ShelfButton.Location = New System.Drawing.Point(520, 13)
        Me.ShelfButton.Name = "ShelfButton"
        Me.ShelfButton.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.ShelfButton.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.ShelfButton.OnHoverForeColor = System.Drawing.Color.White
        Me.ShelfButton.OnHoverImage = Nothing
        Me.ShelfButton.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ShelfButton.OnPressedColor = System.Drawing.Color.Black
        Me.ShelfButton.Size = New System.Drawing.Size(154, 93)
        Me.ShelfButton.TabIndex = 17
        Me.ShelfButton.Text = "Shelves"
        '
        'DiningButton
        '
        Me.DiningButton.AnimationHoverSpeed = 0.07!
        Me.DiningButton.AnimationSpeed = 0.03!
        Me.DiningButton.BackColor = System.Drawing.Color.Black
        Me.DiningButton.BaseColor = System.Drawing.Color.Transparent
        Me.DiningButton.BorderColor = System.Drawing.Color.Black
        Me.DiningButton.CheckedBaseColor = System.Drawing.Color.Gray
        Me.DiningButton.CheckedBorderColor = System.Drawing.Color.Black
        Me.DiningButton.CheckedForeColor = System.Drawing.Color.White
        Me.DiningButton.CheckedImage = CType(resources.GetObject("DiningButton.CheckedImage"), System.Drawing.Image)
        Me.DiningButton.CheckedLineColor = System.Drawing.Color.DimGray
        Me.DiningButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DiningButton.FocusedColor = System.Drawing.Color.Empty
        Me.DiningButton.Font = New System.Drawing.Font("Mongolian Baiti", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiningButton.ForeColor = System.Drawing.Color.White
        Me.DiningButton.Image = Global.Perfect_Fixtures_Final.My.Resources.Resources.dining
        Me.DiningButton.ImageSize = New System.Drawing.Size(50, 50)
        Me.DiningButton.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DiningButton.Location = New System.Drawing.Point(360, 13)
        Me.DiningButton.Name = "DiningButton"
        Me.DiningButton.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.DiningButton.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.DiningButton.OnHoverForeColor = System.Drawing.Color.White
        Me.DiningButton.OnHoverImage = Nothing
        Me.DiningButton.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DiningButton.OnPressedColor = System.Drawing.Color.Black
        Me.DiningButton.Size = New System.Drawing.Size(154, 93)
        Me.DiningButton.TabIndex = 20
        Me.DiningButton.Text = "Dining"
        '
        'SofaButton
        '
        Me.SofaButton.AnimationHoverSpeed = 0.07!
        Me.SofaButton.AnimationSpeed = 0.03!
        Me.SofaButton.BackColor = System.Drawing.Color.Black
        Me.SofaButton.BaseColor = System.Drawing.Color.Transparent
        Me.SofaButton.BorderColor = System.Drawing.Color.Black
        Me.SofaButton.CheckedBaseColor = System.Drawing.Color.Gray
        Me.SofaButton.CheckedBorderColor = System.Drawing.Color.Black
        Me.SofaButton.CheckedForeColor = System.Drawing.Color.White
        Me.SofaButton.CheckedImage = CType(resources.GetObject("SofaButton.CheckedImage"), System.Drawing.Image)
        Me.SofaButton.CheckedLineColor = System.Drawing.Color.DimGray
        Me.SofaButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SofaButton.FocusedColor = System.Drawing.Color.Empty
        Me.SofaButton.Font = New System.Drawing.Font("Mongolian Baiti", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SofaButton.ForeColor = System.Drawing.Color.White
        Me.SofaButton.Image = Global.Perfect_Fixtures_Final.My.Resources.Resources.sofa2
        Me.SofaButton.ImageSize = New System.Drawing.Size(52, 52)
        Me.SofaButton.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.SofaButton.Location = New System.Drawing.Point(200, 13)
        Me.SofaButton.Name = "SofaButton"
        Me.SofaButton.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.SofaButton.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.SofaButton.OnHoverForeColor = System.Drawing.Color.White
        Me.SofaButton.OnHoverImage = Nothing
        Me.SofaButton.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.SofaButton.OnPressedColor = System.Drawing.Color.Black
        Me.SofaButton.Size = New System.Drawing.Size(154, 93)
        Me.SofaButton.TabIndex = 19
        Me.SofaButton.Text = "Sofa/Chairs"
        '
        'BedsButton
        '
        Me.BedsButton.AnimationHoverSpeed = 0.07!
        Me.BedsButton.AnimationSpeed = 0.03!
        Me.BedsButton.BackColor = System.Drawing.Color.Black
        Me.BedsButton.BaseColor = System.Drawing.Color.Transparent
        Me.BedsButton.BorderColor = System.Drawing.Color.Black
        Me.BedsButton.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BedsButton.CheckedBorderColor = System.Drawing.Color.Black
        Me.BedsButton.CheckedForeColor = System.Drawing.Color.White
        Me.BedsButton.CheckedImage = CType(resources.GetObject("BedsButton.CheckedImage"), System.Drawing.Image)
        Me.BedsButton.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BedsButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BedsButton.FocusedColor = System.Drawing.Color.Empty
        Me.BedsButton.Font = New System.Drawing.Font("Mongolian Baiti", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BedsButton.ForeColor = System.Drawing.Color.White
        Me.BedsButton.Image = Global.Perfect_Fixtures_Final.My.Resources.Resources.bed2
        Me.BedsButton.ImageSize = New System.Drawing.Size(52, 52)
        Me.BedsButton.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BedsButton.Location = New System.Drawing.Point(40, 13)
        Me.BedsButton.Name = "BedsButton"
        Me.BedsButton.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.BedsButton.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.BedsButton.OnHoverForeColor = System.Drawing.Color.White
        Me.BedsButton.OnHoverImage = Nothing
        Me.BedsButton.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BedsButton.OnPressedColor = System.Drawing.Color.Black
        Me.BedsButton.Size = New System.Drawing.Size(154, 93)
        Me.BedsButton.TabIndex = 18
        Me.BedsButton.Text = "Beds"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Perfect_Fixtures_Final.My.Resources.Resources.wood2
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1171, 665)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 680)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DecorButton)
        Me.Controls.Add(Me.KidsButton)
        Me.Controls.Add(Me.WardrobeButton)
        Me.Controls.Add(Me.ShelfButton)
        Me.Controls.Add(Me.DiningButton)
        Me.Controls.Add(Me.SofaButton)
        Me.Controls.Add(Me.BedsButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DecorButton As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents KidsButton As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents WardrobeButton As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents ShelfButton As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents DiningButton As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents SofaButton As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents BedsButton As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents Panel1 As Panel
End Class
