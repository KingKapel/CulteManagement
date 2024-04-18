<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laic
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Titre_label = New System.Windows.Forms.Label()
        Me.Nom_label = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.dateculte_label = New System.Windows.Forms.Label()
        Me.dateculte = New System.Windows.Forms.DateTimePicker()
        Me.datenais = New System.Windows.Forms.DateTimePicker()
        Me.datenais_label = New System.Windows.Forms.Label()
        Me.sexe_label = New System.Windows.Forms.Label()
        Me.sexe = New System.Windows.Forms.ComboBox()
        Me.telephone = New System.Windows.Forms.TextBox()
        Me.tel_label = New System.Windows.Forms.Label()
        Me.adress = New System.Windows.Forms.TextBox()
        Me.adress_label = New System.Windows.Forms.Label()
        Me.poste = New System.Windows.Forms.TextBox()
        Me.poste_label = New System.Windows.Forms.Label()
        Me.Enregistrer_btn = New System.Windows.Forms.Button()
        Me.Modifier_btn = New System.Windows.Forms.Button()
        Me.Supprimer_btn = New System.Windows.Forms.Button()
        Me.Effacer_btn = New System.Windows.Forms.Button()
        Me.LaicView = New System.Windows.Forms.DataGridView()
        Me.MembreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CultedbDataSet = New CulteManagement.cultedbDataSet()
        Me.MembreTableAdapter = New CulteManagement.cultedbDataSetTableAdapters.membreTableAdapter()
        Me.IdmembreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateculteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatenaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LaicView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CultedbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titre_label
        '
        Me.Titre_label.AutoSize = True
        Me.Titre_label.Font = New System.Drawing.Font("Lucida Bright", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre_label.ForeColor = System.Drawing.Color.LawnGreen
        Me.Titre_label.Location = New System.Drawing.Point(225, 22)
        Me.Titre_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre_label.Name = "Titre_label"
        Me.Titre_label.Size = New System.Drawing.Size(571, 55)
        Me.Titre_label.TabIndex = 0
        Me.Titre_label.Text = "CULTE MANAGEMENT"
        '
        'Nom_label
        '
        Me.Nom_label.AutoSize = True
        Me.Nom_label.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_label.ForeColor = System.Drawing.Color.White
        Me.Nom_label.Location = New System.Drawing.Point(319, 138)
        Me.Nom_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Nom_label.Name = "Nom_label"
        Me.Nom_label.Size = New System.Drawing.Size(123, 19)
        Me.Nom_label.TabIndex = 1
        Me.Nom_label.Text = "Nom complet :"
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(324, 164)
        Me.nom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nom.Multiline = True
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(324, 22)
        Me.nom.TabIndex = 2
        '
        'dateculte_label
        '
        Me.dateculte_label.AutoSize = True
        Me.dateculte_label.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateculte_label.ForeColor = System.Drawing.Color.White
        Me.dateculte_label.Location = New System.Drawing.Point(16, 138)
        Me.dateculte_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dateculte_label.Name = "dateculte_label"
        Me.dateculte_label.Size = New System.Drawing.Size(121, 19)
        Me.dateculte_label.TabIndex = 3
        Me.dateculte_label.Text = "Date de culte :"
        '
        'dateculte
        '
        Me.dateculte.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateculte.Location = New System.Drawing.Point(16, 164)
        Me.dateculte.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dateculte.Name = "dateculte"
        Me.dateculte.Size = New System.Drawing.Size(252, 23)
        Me.dateculte.TabIndex = 4
        '
        'datenais
        '
        Me.datenais.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datenais.Location = New System.Drawing.Point(701, 164)
        Me.datenais.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.datenais.Name = "datenais"
        Me.datenais.Size = New System.Drawing.Size(252, 23)
        Me.datenais.TabIndex = 6
        '
        'datenais_label
        '
        Me.datenais_label.AutoSize = True
        Me.datenais_label.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datenais_label.ForeColor = System.Drawing.Color.White
        Me.datenais_label.Location = New System.Drawing.Point(701, 138)
        Me.datenais_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.datenais_label.Name = "datenais_label"
        Me.datenais_label.Size = New System.Drawing.Size(157, 19)
        Me.datenais_label.TabIndex = 5
        Me.datenais_label.Text = "Date de naissance:"
        '
        'sexe_label
        '
        Me.sexe_label.AutoSize = True
        Me.sexe_label.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexe_label.ForeColor = System.Drawing.Color.White
        Me.sexe_label.Location = New System.Drawing.Point(1060, 138)
        Me.sexe_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sexe_label.Name = "sexe_label"
        Me.sexe_label.Size = New System.Drawing.Size(54, 19)
        Me.sexe_label.TabIndex = 7
        Me.sexe_label.Text = "Sexe :"
        '
        'sexe
        '
        Me.sexe.AutoCompleteCustomSource.AddRange(New String() {"-choix-", "M", "F"})
        Me.sexe.FormattingEnabled = True
        Me.sexe.Items.AddRange(New Object() {"-choix-", "M", "F"})
        Me.sexe.Location = New System.Drawing.Point(1024, 163)
        Me.sexe.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.sexe.Name = "sexe"
        Me.sexe.Size = New System.Drawing.Size(156, 23)
        Me.sexe.TabIndex = 8
        '
        'telephone
        '
        Me.telephone.Location = New System.Drawing.Point(21, 238)
        Me.telephone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.telephone.Multiline = True
        Me.telephone.Name = "telephone"
        Me.telephone.Size = New System.Drawing.Size(247, 22)
        Me.telephone.TabIndex = 10
        '
        'tel_label
        '
        Me.tel_label.AutoSize = True
        Me.tel_label.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel_label.ForeColor = System.Drawing.Color.White
        Me.tel_label.Location = New System.Drawing.Point(16, 212)
        Me.tel_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tel_label.Name = "tel_label"
        Me.tel_label.Size = New System.Drawing.Size(101, 19)
        Me.tel_label.TabIndex = 9
        Me.tel_label.Text = "Téléphone :"
        '
        'adress
        '
        Me.adress.Location = New System.Drawing.Point(303, 238)
        Me.adress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.adress.Multiline = True
        Me.adress.Name = "adress"
        Me.adress.Size = New System.Drawing.Size(513, 22)
        Me.adress.TabIndex = 12
        '
        'adress_label
        '
        Me.adress_label.AutoSize = True
        Me.adress_label.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adress_label.ForeColor = System.Drawing.Color.White
        Me.adress_label.Location = New System.Drawing.Point(297, 212)
        Me.adress_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adress_label.Name = "adress_label"
        Me.adress_label.Size = New System.Drawing.Size(81, 19)
        Me.adress_label.TabIndex = 11
        Me.adress_label.Text = "Adresse :"
        '
        'poste
        '
        Me.poste.Location = New System.Drawing.Point(856, 238)
        Me.poste.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.poste.Multiline = True
        Me.poste.Name = "poste"
        Me.poste.Size = New System.Drawing.Size(324, 22)
        Me.poste.TabIndex = 14
        '
        'poste_label
        '
        Me.poste_label.AutoSize = True
        Me.poste_label.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poste_label.ForeColor = System.Drawing.Color.White
        Me.poste_label.Location = New System.Drawing.Point(851, 212)
        Me.poste_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.poste_label.Name = "poste_label"
        Me.poste_label.Size = New System.Drawing.Size(120, 19)
        Me.poste_label.TabIndex = 13
        Me.poste_label.Text = "Poste occupé :"
        '
        'Enregistrer_btn
        '
        Me.Enregistrer_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enregistrer_btn.Location = New System.Drawing.Point(425, 282)
        Me.Enregistrer_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Enregistrer_btn.Name = "Enregistrer_btn"
        Me.Enregistrer_btn.Size = New System.Drawing.Size(183, 44)
        Me.Enregistrer_btn.TabIndex = 15
        Me.Enregistrer_btn.Text = "Enregistrer"
        Me.Enregistrer_btn.UseVisualStyleBackColor = True
        '
        'Modifier_btn
        '
        Me.Modifier_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modifier_btn.Location = New System.Drawing.Point(616, 282)
        Me.Modifier_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Modifier_btn.Name = "Modifier_btn"
        Me.Modifier_btn.Size = New System.Drawing.Size(183, 44)
        Me.Modifier_btn.TabIndex = 16
        Me.Modifier_btn.Text = "Modifier"
        Me.Modifier_btn.UseVisualStyleBackColor = True
        '
        'Supprimer_btn
        '
        Me.Supprimer_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supprimer_btn.Location = New System.Drawing.Point(807, 282)
        Me.Supprimer_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Supprimer_btn.Name = "Supprimer_btn"
        Me.Supprimer_btn.Size = New System.Drawing.Size(183, 44)
        Me.Supprimer_btn.TabIndex = 17
        Me.Supprimer_btn.Text = "Supprimer"
        Me.Supprimer_btn.UseVisualStyleBackColor = True
        '
        'Effacer_btn
        '
        Me.Effacer_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Effacer_btn.Location = New System.Drawing.Point(997, 282)
        Me.Effacer_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Effacer_btn.Name = "Effacer_btn"
        Me.Effacer_btn.Size = New System.Drawing.Size(183, 44)
        Me.Effacer_btn.TabIndex = 18
        Me.Effacer_btn.Text = "Effacer"
        Me.Effacer_btn.UseVisualStyleBackColor = True
        '
        'LaicView
        '
        Me.LaicView.AutoGenerateColumns = False
        Me.LaicView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaicView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmembreDataGridViewTextBoxColumn, Me.DateculteDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.DatenaisDataGridViewTextBoxColumn, Me.SexeDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.AdressDataGridViewTextBoxColumn, Me.PosteDataGridViewTextBoxColumn})
        Me.LaicView.DataSource = Me.MembreBindingSource
        Me.LaicView.Location = New System.Drawing.Point(212, 414)
        Me.LaicView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LaicView.Name = "LaicView"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LaicView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LaicView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.LaicView.Size = New System.Drawing.Size(842, 169)
        Me.LaicView.TabIndex = 19
        '
        'MembreBindingSource
        '
        Me.MembreBindingSource.DataMember = "membre"
        Me.MembreBindingSource.DataSource = Me.CultedbDataSet
        '
        'CultedbDataSet
        '
        Me.CultedbDataSet.DataSetName = "cultedbDataSet"
        Me.CultedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembreTableAdapter
        '
        Me.MembreTableAdapter.ClearBeforeFill = True
        '
        'IdmembreDataGridViewTextBoxColumn
        '
        Me.IdmembreDataGridViewTextBoxColumn.DataPropertyName = "id_membre"
        Me.IdmembreDataGridViewTextBoxColumn.HeaderText = "id_membre"
        Me.IdmembreDataGridViewTextBoxColumn.Name = "IdmembreDataGridViewTextBoxColumn"
        Me.IdmembreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateculteDataGridViewTextBoxColumn
        '
        Me.DateculteDataGridViewTextBoxColumn.DataPropertyName = "dateculte"
        Me.DateculteDataGridViewTextBoxColumn.HeaderText = "dateculte"
        Me.DateculteDataGridViewTextBoxColumn.Name = "DateculteDataGridViewTextBoxColumn"
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        '
        'DatenaisDataGridViewTextBoxColumn
        '
        Me.DatenaisDataGridViewTextBoxColumn.DataPropertyName = "datenais"
        Me.DatenaisDataGridViewTextBoxColumn.HeaderText = "datenais"
        Me.DatenaisDataGridViewTextBoxColumn.Name = "DatenaisDataGridViewTextBoxColumn"
        '
        'SexeDataGridViewTextBoxColumn
        '
        Me.SexeDataGridViewTextBoxColumn.DataPropertyName = "sexe"
        Me.SexeDataGridViewTextBoxColumn.HeaderText = "sexe"
        Me.SexeDataGridViewTextBoxColumn.Name = "SexeDataGridViewTextBoxColumn"
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        '
        'AdressDataGridViewTextBoxColumn
        '
        Me.AdressDataGridViewTextBoxColumn.DataPropertyName = "adress"
        Me.AdressDataGridViewTextBoxColumn.HeaderText = "adress"
        Me.AdressDataGridViewTextBoxColumn.Name = "AdressDataGridViewTextBoxColumn"
        '
        'PosteDataGridViewTextBoxColumn
        '
        Me.PosteDataGridViewTextBoxColumn.DataPropertyName = "poste"
        Me.PosteDataGridViewTextBoxColumn.HeaderText = "poste"
        Me.PosteDataGridViewTextBoxColumn.Name = "PosteDataGridViewTextBoxColumn"
        '
        'Laic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1223, 660)
        Me.Controls.Add(Me.LaicView)
        Me.Controls.Add(Me.Effacer_btn)
        Me.Controls.Add(Me.Supprimer_btn)
        Me.Controls.Add(Me.Modifier_btn)
        Me.Controls.Add(Me.Enregistrer_btn)
        Me.Controls.Add(Me.poste)
        Me.Controls.Add(Me.poste_label)
        Me.Controls.Add(Me.adress)
        Me.Controls.Add(Me.adress_label)
        Me.Controls.Add(Me.telephone)
        Me.Controls.Add(Me.tel_label)
        Me.Controls.Add(Me.sexe)
        Me.Controls.Add(Me.sexe_label)
        Me.Controls.Add(Me.datenais)
        Me.Controls.Add(Me.datenais_label)
        Me.Controls.Add(Me.dateculte)
        Me.Controls.Add(Me.dateculte_label)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Nom_label)
        Me.Controls.Add(Me.Titre_label)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Laic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Culte management"
        CType(Me.LaicView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CultedbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titre_label As Label
    Friend WithEvents Nom_label As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents dateculte_label As Label
    Friend WithEvents dateculte As DateTimePicker
    Friend WithEvents datenais As DateTimePicker
    Friend WithEvents datenais_label As Label
    Friend WithEvents sexe_label As Label
    Friend WithEvents sexe As ComboBox
    Friend WithEvents telephone As TextBox
    Friend WithEvents tel_label As Label
    Friend WithEvents adress As TextBox
    Friend WithEvents adress_label As Label
    Friend WithEvents poste As TextBox
    Friend WithEvents poste_label As Label
    Friend WithEvents Enregistrer_btn As Button
    Friend WithEvents Modifier_btn As Button
    Friend WithEvents Supprimer_btn As Button
    Friend WithEvents Effacer_btn As Button
    Friend WithEvents LaicView As DataGridView
    Friend WithEvents CultedbDataSet As cultedbDataSet
    Friend WithEvents MembreBindingSource As BindingSource
    Friend WithEvents MembreTableAdapter As cultedbDataSetTableAdapters.membreTableAdapter
    Friend WithEvents IdmembreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateculteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatenaisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PosteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
