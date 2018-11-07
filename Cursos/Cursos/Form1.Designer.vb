<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV_CURSO = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GB_NUEVO = New System.Windows.Forms.GroupBox()
        Me.nud_CreditosCurso = New System.Windows.Forms.NumericUpDown()
        Me.txt_nombreCurso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGV_CURSO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GB_NUEVO.SuspendLayout()
        CType(Me.nud_CreditosCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_CURSO
        '
        Me.DGV_CURSO.AllowUserToAddRows = False
        Me.DGV_CURSO.AllowUserToDeleteRows = False
        Me.DGV_CURSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CURSO.Location = New System.Drawing.Point(12, 199)
        Me.DGV_CURSO.Name = "DGV_CURSO"
        Me.DGV_CURSO.ReadOnly = True
        Me.DGV_CURSO.Size = New System.Drawing.Size(622, 264)
        Me.DGV_CURSO.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(662, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'GB_NUEVO
        '
        Me.GB_NUEVO.Controls.Add(Me.btn_Editar)
        Me.GB_NUEVO.Controls.Add(Me.nud_CreditosCurso)
        Me.GB_NUEVO.Controls.Add(Me.txt_nombreCurso)
        Me.GB_NUEVO.Controls.Add(Me.Label2)
        Me.GB_NUEVO.Controls.Add(Me.Label1)
        Me.GB_NUEVO.Controls.Add(Me.btn_Guardar)
        Me.GB_NUEVO.Controls.Add(Me.btn_cancelar)
        Me.GB_NUEVO.Location = New System.Drawing.Point(12, 27)
        Me.GB_NUEVO.Name = "GB_NUEVO"
        Me.GB_NUEVO.Size = New System.Drawing.Size(622, 166)
        Me.GB_NUEVO.TabIndex = 2
        Me.GB_NUEVO.TabStop = False
        Me.GB_NUEVO.Text = "Nuevo Curso"
        '
        'nud_CreditosCurso
        '
        Me.nud_CreditosCurso.Location = New System.Drawing.Point(11, 125)
        Me.nud_CreditosCurso.Name = "nud_CreditosCurso"
        Me.nud_CreditosCurso.Size = New System.Drawing.Size(76, 20)
        Me.nud_CreditosCurso.TabIndex = 4
        '
        'txt_nombreCurso
        '
        Me.txt_nombreCurso.Location = New System.Drawing.Point(11, 59)
        Me.txt_nombreCurso.Name = "txt_nombreCurso"
        Me.txt_nombreCurso.Size = New System.Drawing.Size(232, 20)
        Me.txt_nombreCurso.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Creditos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Curso"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.Location = New System.Drawing.Point(375, 85)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(111, 50)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Khaki
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(375, 19)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(111, 50)
        Me.btn_cancelar.TabIndex = 0
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(67, 25)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(550, 27)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 13)
        Me.lbl_id.TabIndex = 3
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Location = New System.Drawing.Point(247, 85)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(111, 50)
        Me.btn_Editar.TabIndex = 5
        Me.btn_Editar.Text = "Editar"
        Me.btn_Editar.UseVisualStyleBackColor = False
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(86, 25)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 486)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.GB_NUEVO)
        Me.Controls.Add(Me.DGV_CURSO)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV_CURSO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GB_NUEVO.ResumeLayout(False)
        Me.GB_NUEVO.PerformLayout()
        CType(Me.nud_CreditosCurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_CURSO As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GB_NUEVO As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nud_CreditosCurso As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_nombreCurso As System.Windows.Forms.TextBox
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
