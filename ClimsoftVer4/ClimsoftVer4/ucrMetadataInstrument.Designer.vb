﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrMetadataInstrument
    Inherits ClimsoftVer4.ucrTableEntry

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrTextBoxtInstrumentName = New ClimsoftVer4.ucrTextBox()
        Me.lblInstruments = New System.Windows.Forms.Label()
        Me.grpCommand2 = New System.Windows.Forms.GroupBox()
        Me.cmdAddNewInstrument = New System.Windows.Forms.Button()
        Me.cmdViewInstrument = New System.Windows.Forms.Button()
        Me.cmdDeleteInstrument = New System.Windows.Forms.Button()
        Me.cmdUpdateInstrument = New System.Windows.Forms.Button()
        Me.cmdSaveInstrument = New System.Windows.Forms.Button()
        Me.ucrNavigationInstrument = New ClimsoftVer4.ucrNavigation()
        Me.cmdInstrument = New System.Windows.Forms.Button()
        Me.lblInstrumentPic = New System.Windows.Forms.Label()
        Me.picInstrument = New System.Windows.Forms.PictureBox()
        Me.ucrTextBoxImageFile = New ClimsoftVer4.ucrTextBox()
        Me.ucrTextBoxHeight = New ClimsoftVer4.ucrTextBox()
        Me.ucrTextBoxUncertainity = New ClimsoftVer4.ucrTextBox()
        Me.ucrTextBoxManufacturer = New ClimsoftVer4.ucrTextBox()
        Me.ucrTextBoxModel = New ClimsoftVer4.ucrTextBox()
        Me.ucrTextBoxSerialNumber = New ClimsoftVer4.ucrTextBox()
        Me.ucrStationSelector = New ClimsoftVer4.ucrStationSelector()
        Me.ucrTextBoxAbbrevation = New ClimsoftVer4.ucrTextBox()
        Me.ucrDataLinkInstrumentID = New ClimsoftVer4.ucrDataLinkCombobox()
        Me.lblImageFile = New System.Windows.Forms.Label()
        Me.lbStationID = New System.Windows.Forms.Label()
        Me.lblInstalledAt = New System.Windows.Forms.Label()
        Me.lblDeinstallationDate = New System.Windows.Forms.Label()
        Me.lblIinstallationDate = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.lblInstrumentAbbreviation = New System.Windows.Forms.Label()
        Me.lblUncertainity = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblInstrumentName = New System.Windows.Forms.Label()
        Me.lblInstrumentID = New System.Windows.Forms.Label()
        Me.ucrDatePickerInstallation = New ClimsoftVer4.ucrDatePicker()
        Me.ucrDatePickerDeinstallation = New ClimsoftVer4.ucrDatePicker()
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCommand2.SuspendLayout()
        CType(Me.picInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrTextBoxtInstrumentName
        '
        Me.ucrTextBoxtInstrumentName.FieldName = "instrumentName"
        Me.ucrTextBoxtInstrumentName.Location = New System.Drawing.Point(132, 75)
        Me.ucrTextBoxtInstrumentName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrTextBoxtInstrumentName.Name = "ucrTextBoxtInstrumentName"
        Me.ucrTextBoxtInstrumentName.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxtInstrumentName.TabIndex = 96
        Me.ucrTextBoxtInstrumentName.Tag = "instrumentName"
        Me.ucrTextBoxtInstrumentName.TextboxValue = ""
        '
        'lblInstruments
        '
        Me.lblInstruments.AutoSize = True
        Me.lblInstruments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruments.Location = New System.Drawing.Point(301, 11)
        Me.lblInstruments.Name = "lblInstruments"
        Me.lblInstruments.Size = New System.Drawing.Size(75, 15)
        Me.lblInstruments.TabIndex = 95
        Me.lblInstruments.Text = "Instrument"
        '
        'grpCommand2
        '
        Me.grpCommand2.Controls.Add(Me.cmdAddNewInstrument)
        Me.grpCommand2.Controls.Add(Me.cmdViewInstrument)
        Me.grpCommand2.Controls.Add(Me.cmdDeleteInstrument)
        Me.grpCommand2.Controls.Add(Me.cmdUpdateInstrument)
        Me.grpCommand2.Controls.Add(Me.cmdSaveInstrument)
        Me.grpCommand2.Location = New System.Drawing.Point(3, 404)
        Me.grpCommand2.Name = "grpCommand2"
        Me.grpCommand2.Size = New System.Drawing.Size(670, 31)
        Me.grpCommand2.TabIndex = 94
        Me.grpCommand2.TabStop = False
        '
        'cmdAddNewInstrument
        '
        Me.cmdAddNewInstrument.Location = New System.Drawing.Point(95, 4)
        Me.cmdAddNewInstrument.Name = "cmdAddNewInstrument"
        Me.cmdAddNewInstrument.Size = New System.Drawing.Size(81, 27)
        Me.cmdAddNewInstrument.TabIndex = 12
        Me.cmdAddNewInstrument.Text = "AddNew"
        Me.cmdAddNewInstrument.UseVisualStyleBackColor = True
        '
        'cmdViewInstrument
        '
        Me.cmdViewInstrument.Location = New System.Drawing.Point(583, 6)
        Me.cmdViewInstrument.Name = "cmdViewInstrument"
        Me.cmdViewInstrument.Size = New System.Drawing.Size(81, 25)
        Me.cmdViewInstrument.TabIndex = 16
        Me.cmdViewInstrument.Text = "View"
        Me.cmdViewInstrument.UseVisualStyleBackColor = True
        '
        'cmdDeleteInstrument
        '
        Me.cmdDeleteInstrument.Location = New System.Drawing.Point(461, 5)
        Me.cmdDeleteInstrument.Name = "cmdDeleteInstrument"
        Me.cmdDeleteInstrument.Size = New System.Drawing.Size(81, 25)
        Me.cmdDeleteInstrument.TabIndex = 15
        Me.cmdDeleteInstrument.Text = "Delete"
        Me.cmdDeleteInstrument.UseVisualStyleBackColor = True
        '
        'cmdUpdateInstrument
        '
        Me.cmdUpdateInstrument.Location = New System.Drawing.Point(339, 5)
        Me.cmdUpdateInstrument.Name = "cmdUpdateInstrument"
        Me.cmdUpdateInstrument.Size = New System.Drawing.Size(81, 25)
        Me.cmdUpdateInstrument.TabIndex = 14
        Me.cmdUpdateInstrument.Text = "Update"
        Me.cmdUpdateInstrument.UseVisualStyleBackColor = True
        '
        'cmdSaveInstrument
        '
        Me.cmdSaveInstrument.Location = New System.Drawing.Point(217, 5)
        Me.cmdSaveInstrument.Name = "cmdSaveInstrument"
        Me.cmdSaveInstrument.Size = New System.Drawing.Size(81, 25)
        Me.cmdSaveInstrument.TabIndex = 13
        Me.cmdSaveInstrument.Text = "Save"
        Me.cmdSaveInstrument.UseVisualStyleBackColor = True
        '
        'ucrNavigationInstrument
        '
        Me.ucrNavigationInstrument.Location = New System.Drawing.Point(170, 444)
        Me.ucrNavigationInstrument.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNavigationInstrument.Name = "ucrNavigationInstrument"
        Me.ucrNavigationInstrument.Size = New System.Drawing.Size(336, 25)
        Me.ucrNavigationInstrument.TabIndex = 93
        '
        'cmdInstrument
        '
        Me.cmdInstrument.Location = New System.Drawing.Point(441, 358)
        Me.cmdInstrument.Name = "cmdInstrument"
        Me.cmdInstrument.Size = New System.Drawing.Size(47, 29)
        Me.cmdInstrument.TabIndex = 92
        Me.cmdInstrument.Text = "Open"
        Me.cmdInstrument.UseVisualStyleBackColor = True
        '
        'lblInstrumentPic
        '
        Me.lblInstrumentPic.AutoSize = True
        Me.lblInstrumentPic.Location = New System.Drawing.Point(487, 336)
        Me.lblInstrumentPic.Name = "lblInstrumentPic"
        Me.lblInstrumentPic.Size = New System.Drawing.Size(92, 13)
        Me.lblInstrumentPic.TabIndex = 91
        Me.lblInstrumentPic.Text = "Instrument Picture"
        '
        'picInstrument
        '
        Me.picInstrument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picInstrument.Location = New System.Drawing.Point(370, 46)
        Me.picInstrument.Name = "picInstrument"
        Me.picInstrument.Size = New System.Drawing.Size(288, 291)
        Me.picInstrument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInstrument.TabIndex = 90
        Me.picInstrument.TabStop = False
        '
        'ucrTextBoxImageFile
        '
        Me.ucrTextBoxImageFile.FieldName = "instrumentPicture"
        Me.ucrTextBoxImageFile.Location = New System.Drawing.Point(132, 362)
        Me.ucrTextBoxImageFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrTextBoxImageFile.Name = "ucrTextBoxImageFile"
        Me.ucrTextBoxImageFile.Size = New System.Drawing.Size(301, 20)
        Me.ucrTextBoxImageFile.TabIndex = 89
        Me.ucrTextBoxImageFile.Tag = "instrumentPicture"
        Me.ucrTextBoxImageFile.TextboxValue = ""
        '
        'ucrTextBoxHeight
        '
        Me.ucrTextBoxHeight.FieldName = "height"
        Me.ucrTextBoxHeight.Location = New System.Drawing.Point(132, 334)
        Me.ucrTextBoxHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrTextBoxHeight.Name = "ucrTextBoxHeight"
        Me.ucrTextBoxHeight.Size = New System.Drawing.Size(51, 20)
        Me.ucrTextBoxHeight.TabIndex = 88
        Me.ucrTextBoxHeight.Tag = "height"
        Me.ucrTextBoxHeight.TextboxValue = ""
        '
        'ucrTextBoxUncertainity
        '
        Me.ucrTextBoxUncertainity.FieldName = "instrumentUncertainty"
        Me.ucrTextBoxUncertainity.Location = New System.Drawing.Point(132, 250)
        Me.ucrTextBoxUncertainity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrTextBoxUncertainity.Name = "ucrTextBoxUncertainity"
        Me.ucrTextBoxUncertainity.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxUncertainity.TabIndex = 83
        Me.ucrTextBoxUncertainity.Tag = "instrumentUncertainty"
        Me.ucrTextBoxUncertainity.TextboxValue = ""
        '
        'ucrTextBoxManufacturer
        '
        Me.ucrTextBoxManufacturer.FieldName = "manufacturer"
        Me.ucrTextBoxManufacturer.Location = New System.Drawing.Point(132, 222)
        Me.ucrTextBoxManufacturer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrTextBoxManufacturer.Name = "ucrTextBoxManufacturer"
        Me.ucrTextBoxManufacturer.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxManufacturer.TabIndex = 82
        Me.ucrTextBoxManufacturer.Tag = "manufacturer"
        Me.ucrTextBoxManufacturer.TextboxValue = ""
        '
        'ucrTextBoxModel
        '
        Me.ucrTextBoxModel.FieldName = "model"
        Me.ucrTextBoxModel.Location = New System.Drawing.Point(132, 194)
        Me.ucrTextBoxModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrTextBoxModel.Name = "ucrTextBoxModel"
        Me.ucrTextBoxModel.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxModel.TabIndex = 81
        Me.ucrTextBoxModel.Tag = "model"
        Me.ucrTextBoxModel.TextboxValue = ""
        '
        'ucrTextBoxSerialNumber
        '
        Me.ucrTextBoxSerialNumber.FieldName = "serialNumber"
        Me.ucrTextBoxSerialNumber.Location = New System.Drawing.Point(132, 166)
        Me.ucrTextBoxSerialNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrTextBoxSerialNumber.Name = "ucrTextBoxSerialNumber"
        Me.ucrTextBoxSerialNumber.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxSerialNumber.TabIndex = 80
        Me.ucrTextBoxSerialNumber.Tag = "serialNumber"
        Me.ucrTextBoxSerialNumber.TextboxValue = ""
        '
        'ucrStationSelector
        '
        Me.ucrStationSelector.FieldName = "installedAt"
        Me.ucrStationSelector.Location = New System.Drawing.Point(132, 138)
        Me.ucrStationSelector.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrStationSelector.Name = "ucrStationSelector"
        Me.ucrStationSelector.Size = New System.Drawing.Size(139, 24)
        Me.ucrStationSelector.TabIndex = 79
        Me.ucrStationSelector.Tag = "installedAt"
        '
        'ucrTextBoxAbbrevation
        '
        Me.ucrTextBoxAbbrevation.FieldName = "abbreviation"
        Me.ucrTextBoxAbbrevation.Location = New System.Drawing.Point(132, 108)
        Me.ucrTextBoxAbbrevation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrTextBoxAbbrevation.Name = "ucrTextBoxAbbrevation"
        Me.ucrTextBoxAbbrevation.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxAbbrevation.TabIndex = 78
        Me.ucrTextBoxAbbrevation.Tag = "abbreviation"
        Me.ucrTextBoxAbbrevation.TextboxValue = ""
        '
        'ucrDataLinkInstrumentID
        '
        Me.ucrDataLinkInstrumentID.FieldName = "instrumentId"
        Me.ucrDataLinkInstrumentID.Location = New System.Drawing.Point(132, 46)
        Me.ucrDataLinkInstrumentID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrDataLinkInstrumentID.Name = "ucrDataLinkInstrumentID"
        Me.ucrDataLinkInstrumentID.Size = New System.Drawing.Size(139, 21)
        Me.ucrDataLinkInstrumentID.TabIndex = 76
        Me.ucrDataLinkInstrumentID.Tag = "instrumentId"
        '
        'lblImageFile
        '
        Me.lblImageFile.AutoSize = True
        Me.lblImageFile.Location = New System.Drawing.Point(28, 362)
        Me.lblImageFile.Name = "lblImageFile"
        Me.lblImageFile.Size = New System.Drawing.Size(55, 13)
        Me.lblImageFile.TabIndex = 75
        Me.lblImageFile.Text = "Image File"
        '
        'lbStationID
        '
        Me.lbStationID.AutoSize = True
        Me.lbStationID.Location = New System.Drawing.Point(29, 138)
        Me.lbStationID.Name = "lbStationID"
        Me.lbStationID.Size = New System.Drawing.Size(54, 13)
        Me.lbStationID.TabIndex = 74
        Me.lbStationID.Text = "Station ID"
        '
        'lblInstalledAt
        '
        Me.lblInstalledAt.AutoSize = True
        Me.lblInstalledAt.Location = New System.Drawing.Point(28, 334)
        Me.lblInstalledAt.Name = "lblInstalledAt"
        Me.lblInstalledAt.Size = New System.Drawing.Size(38, 13)
        Me.lblInstalledAt.TabIndex = 73
        Me.lblInstalledAt.Text = "Height"
        '
        'lblDeinstallationDate
        '
        Me.lblDeinstallationDate.AutoSize = True
        Me.lblDeinstallationDate.Location = New System.Drawing.Point(28, 306)
        Me.lblDeinstallationDate.Name = "lblDeinstallationDate"
        Me.lblDeinstallationDate.Size = New System.Drawing.Size(96, 13)
        Me.lblDeinstallationDate.TabIndex = 72
        Me.lblDeinstallationDate.Text = "Deinstallation Date"
        '
        'lblIinstallationDate
        '
        Me.lblIinstallationDate.AutoSize = True
        Me.lblIinstallationDate.Location = New System.Drawing.Point(29, 278)
        Me.lblIinstallationDate.Name = "lblIinstallationDate"
        Me.lblIinstallationDate.Size = New System.Drawing.Size(83, 13)
        Me.lblIinstallationDate.TabIndex = 71
        Me.lblIinstallationDate.Text = "Installation Date"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(29, 194)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(36, 13)
        Me.lblModel.TabIndex = 68
        Me.lblModel.Text = "Model"
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.Location = New System.Drawing.Point(29, 166)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblSerialNumber.TabIndex = 67
        Me.lblSerialNumber.Text = "Serial Number"
        '
        'lblInstrumentAbbreviation
        '
        Me.lblInstrumentAbbreviation.AutoSize = True
        Me.lblInstrumentAbbreviation.Location = New System.Drawing.Point(29, 110)
        Me.lblInstrumentAbbreviation.Name = "lblInstrumentAbbreviation"
        Me.lblInstrumentAbbreviation.Size = New System.Drawing.Size(66, 13)
        Me.lblInstrumentAbbreviation.TabIndex = 66
        Me.lblInstrumentAbbreviation.Text = "Abbreviation"
        '
        'lblUncertainity
        '
        Me.lblUncertainity.AutoSize = True
        Me.lblUncertainity.Location = New System.Drawing.Point(29, 250)
        Me.lblUncertainity.Name = "lblUncertainity"
        Me.lblUncertainity.Size = New System.Drawing.Size(63, 13)
        Me.lblUncertainity.TabIndex = 70
        Me.lblUncertainity.Text = "Uncertainity"
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(29, 222)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(70, 13)
        Me.lblManufacturer.TabIndex = 69
        Me.lblManufacturer.Text = "Manufacturer"
        '
        'lblInstrumentName
        '
        Me.lblInstrumentName.AutoSize = True
        Me.lblInstrumentName.Location = New System.Drawing.Point(29, 82)
        Me.lblInstrumentName.Name = "lblInstrumentName"
        Me.lblInstrumentName.Size = New System.Drawing.Size(35, 13)
        Me.lblInstrumentName.TabIndex = 65
        Me.lblInstrumentName.Text = "Name"
        '
        'lblInstrumentID
        '
        Me.lblInstrumentID.AutoSize = True
        Me.lblInstrumentID.Location = New System.Drawing.Point(29, 54)
        Me.lblInstrumentID.Name = "lblInstrumentID"
        Me.lblInstrumentID.Size = New System.Drawing.Size(70, 13)
        Me.lblInstrumentID.TabIndex = 64
        Me.lblInstrumentID.Text = "Instrument ID"
        '
        'ucrDatePickerInstallation
        '
        Me.ucrDatePickerInstallation.FieldName = "installationDatetime"
        Me.ucrDatePickerInstallation.Location = New System.Drawing.Point(132, 278)
        Me.ucrDatePickerInstallation.Name = "ucrDatePickerInstallation"
        Me.ucrDatePickerInstallation.Size = New System.Drawing.Size(139, 23)
        Me.ucrDatePickerInstallation.TabIndex = 97
        Me.ucrDatePickerInstallation.Tag = "installationDatetime"
        '
        'ucrDatePickerDeinstallation
        '
        Me.ucrDatePickerDeinstallation.FieldName = "deinstallationDatetime"
        Me.ucrDatePickerDeinstallation.Location = New System.Drawing.Point(130, 303)
        Me.ucrDatePickerDeinstallation.Name = "ucrDatePickerDeinstallation"
        Me.ucrDatePickerDeinstallation.Size = New System.Drawing.Size(141, 23)
        Me.ucrDatePickerDeinstallation.TabIndex = 98
        Me.ucrDatePickerDeinstallation.Tag = "deinstallationDatetime"
        '
        'ucrMetadataInstrument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrDatePickerDeinstallation)
        Me.Controls.Add(Me.ucrDatePickerInstallation)
        Me.Controls.Add(Me.ucrTextBoxtInstrumentName)
        Me.Controls.Add(Me.lblInstruments)
        Me.Controls.Add(Me.grpCommand2)
        Me.Controls.Add(Me.ucrNavigationInstrument)
        Me.Controls.Add(Me.cmdInstrument)
        Me.Controls.Add(Me.lblInstrumentPic)
        Me.Controls.Add(Me.picInstrument)
        Me.Controls.Add(Me.ucrTextBoxImageFile)
        Me.Controls.Add(Me.ucrTextBoxHeight)
        Me.Controls.Add(Me.ucrTextBoxUncertainity)
        Me.Controls.Add(Me.ucrTextBoxManufacturer)
        Me.Controls.Add(Me.ucrTextBoxModel)
        Me.Controls.Add(Me.ucrTextBoxSerialNumber)
        Me.Controls.Add(Me.ucrStationSelector)
        Me.Controls.Add(Me.ucrTextBoxAbbrevation)
        Me.Controls.Add(Me.ucrDataLinkInstrumentID)
        Me.Controls.Add(Me.lblImageFile)
        Me.Controls.Add(Me.lbStationID)
        Me.Controls.Add(Me.lblInstalledAt)
        Me.Controls.Add(Me.lblDeinstallationDate)
        Me.Controls.Add(Me.lblIinstallationDate)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblSerialNumber)
        Me.Controls.Add(Me.lblInstrumentAbbreviation)
        Me.Controls.Add(Me.lblUncertainity)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Controls.Add(Me.lblInstrumentName)
        Me.Controls.Add(Me.lblInstrumentID)
        Me.Name = "ucrMetadataInstrument"
        Me.Size = New System.Drawing.Size(676, 478)
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCommand2.ResumeLayout(False)
        CType(Me.picInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblImageFile As Label
    Friend WithEvents lbStationID As Label
    Friend WithEvents lblInstalledAt As Label
    Friend WithEvents lblDeinstallationDate As Label
    Friend WithEvents lblIinstallationDate As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblSerialNumber As Label
    Friend WithEvents lblInstrumentAbbreviation As Label
    Friend WithEvents lblUncertainity As Label
    Friend WithEvents lblManufacturer As Label
    Friend WithEvents lblInstrumentName As Label
    Friend WithEvents lblInstrumentID As Label
    Friend WithEvents ucrDataLinkInstrumentID As ucrDataLinkCombobox
    Friend WithEvents ucrTextBoxAbbrevation As ucrTextBox
    Friend WithEvents ucrStationSelector As ucrStationSelector
    Friend WithEvents ucrTextBoxSerialNumber As ucrTextBox
    Friend WithEvents ucrTextBoxModel As ucrTextBox
    Friend WithEvents ucrTextBoxManufacturer As ucrTextBox
    Friend WithEvents ucrTextBoxUncertainity As ucrTextBox
    Friend WithEvents ucrTextBoxHeight As ucrTextBox
    Friend WithEvents ucrTextBoxImageFile As ucrTextBox
    Friend WithEvents lblInstrumentPic As Label
    Friend WithEvents picInstrument As PictureBox
    Friend WithEvents cmdInstrument As Button
    Friend WithEvents ucrNavigationInstrument As ucrNavigation
    Friend WithEvents cmdAddNewInstrument As Button
    Friend WithEvents cmdDeleteInstrument As Button
    Friend WithEvents cmdUpdateInstrument As Button
    Friend WithEvents cmdSaveInstrument As Button
    Friend WithEvents grpCommand2 As GroupBox
    Friend WithEvents cmdViewInstrument As Button
    Friend WithEvents lblInstruments As Label
    Friend WithEvents ucrTextBoxtInstrumentName As ucrTextBox
    Friend WithEvents ucrDatePickerInstallation As ucrDatePicker
    Friend WithEvents ucrDatePickerDeinstallation As ucrDatePicker
End Class
