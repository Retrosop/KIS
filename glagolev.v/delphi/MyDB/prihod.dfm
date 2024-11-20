object PrihodForm: TPrihodForm
  Left = 443
  Top = 237
  Width = 1239
  Height = 708
  Caption = 'PrihodForm'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 552
    Top = 24
    Width = 32
    Height = 13
    Caption = 'Label1'
  end
  object Label2: TLabel
    Left = 328
    Top = 24
    Width = 32
    Height = 13
    Caption = 'Label2'
  end
  object Label3: TLabel
    Left = 64
    Top = 32
    Width = 32
    Height = 13
    Caption = 'Label3'
  end
  object Label4: TLabel
    Left = 64
    Top = 64
    Width = 32
    Height = 13
    Caption = 'Label4'
  end
  object DBGrid1: TDBGrid
    Left = 40
    Top = 104
    Width = 929
    Height = 297
    DataSource = DataSource1
    TabOrder = 0
    TitleFont.Charset = DEFAULT_CHARSET
    TitleFont.Color = clWindowText
    TitleFont.Height = -11
    TitleFont.Name = 'MS Sans Serif'
    TitleFont.Style = []
    Columns = <
      item
        Expanded = False
        FieldName = 'idprihod'
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'nametovar'
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'datprih'
        Width = 188
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'kolvo'
        Width = 147
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'namepostav'
        Width = 200
        Visible = True
      end>
  end
  object DBNavigator1: TDBNavigator
    Left = 32
    Top = 600
    Width = 920
    Height = 25
    DataSource = DataSource1
    TabOrder = 1
  end
  object DBEdit1: TDBEdit
    Left = 136
    Top = 24
    Width = 121
    Height = 21
    DataField = 'datprih'
    DataSource = DataSource1
    TabOrder = 2
  end
  object DBEdit2: TDBEdit
    Left = 136
    Top = 56
    Width = 121
    Height = 21
    DataField = 'kolvo'
    DataSource = DataSource1
    TabOrder = 3
  end
  object DBLookupComboBox1: TDBLookupComboBox
    Left = 368
    Top = 16
    Width = 145
    Height = 21
    DataField = 'idtovar'
    DataSource = DataSource1
    KeyField = 'idtovar'
    ListField = 'tovar'
    ListSource = DataSource3
    TabOrder = 4
  end
  object DBLookupComboBox2: TDBLookupComboBox
    Left = 584
    Top = 16
    Width = 145
    Height = 21
    DataField = 'idpostav'
    DataSource = DataSource1
    KeyField = 'idpostav'
    ListField = 'postav'
    ListSource = DataSource2
    TabOrder = 5
  end
  object DBMemo1: TDBMemo
    Left = 40
    Top = 424
    Width = 929
    Height = 89
    DataField = 'nametovar'
    DataSource = DataSource1
    TabOrder = 6
  end
  object MySQLDatabase1: TMySQLDatabase
    Connected = True
    DatabaseName = 'bh35910_kis'
    UserName = 'bh35910_student1711'
    UserPassword = 'pgu2023pgu2023'
    Host = '91.219.194.4'
    ConnectOptions = []
    ConnectionCharacterSet = 'latin1'
    Params.Strings = (
      'Port=3306'
      'TIMEOUT=30'
      'DatabaseName=bh35910_kis'
      'UID=bh35910_student1711'
      'PWD=pgu2023pgu2023'
      'Host=91.219.194.4')
    DatasetOptions = []
    Left = 136
    Top = 368
  end
  object MySQLTable1: TMySQLTable
    Database = MySQLDatabase1
    Active = True
    TableName = 'glagolev_prihod'
    Left = 272
    Top = 368
    object MySQLTable1idprihod: TAutoIncField
      FieldName = 'idprihod'
      Origin = 'glagolev_prihod.idprihod'
    end
    object MySQLTable1idtovar: TIntegerField
      FieldName = 'idtovar'
      Origin = 'glagolev_prihod.idtovar'
    end
    object MySQLTable1datprih: TDateField
      FieldName = 'datprih'
      Origin = 'glagolev_prihod.datprih'
    end
    object MySQLTable1kolvo: TIntegerField
      FieldName = 'kolvo'
      Origin = 'glagolev_prihod.kolvo'
    end
    object MySQLTable1idpostav: TIntegerField
      FieldName = 'idpostav'
      Origin = 'glagolev_prihod.idpostav'
    end
    object MySQLTable1namepostav: TStringField
      FieldKind = fkLookup
      FieldName = 'namepostav'
      LookupDataSet = MySQLTable2
      LookupKeyFields = 'idpostav'
      LookupResultField = 'postav'
      KeyFields = 'idpostav'
      Lookup = True
    end
    object MySQLTable1nametovar: TStringField
      FieldKind = fkLookup
      FieldName = 'nametovar'
      LookupDataSet = MySQLTable3
      LookupKeyFields = 'idtovar'
      LookupResultField = 'tovar'
      KeyFields = 'idtovar'
      Lookup = True
    end
  end
  object DataSource1: TDataSource
    DataSet = MySQLTable1
    Left = 392
    Top = 368
  end
  object MySQLTable2: TMySQLTable
    Database = MySQLDatabase1
    Active = True
    TableName = 'glagolev_postav'
    Left = 688
    Top = 56
  end
  object DataSource2: TDataSource
    DataSet = MySQLTable2
    Left = 624
    Top = 56
  end
  object MySQLTable3: TMySQLTable
    Database = MySQLDatabase1
    Active = True
    TableName = 'glagolev_tovar'
    Left = 448
    Top = 56
  end
  object DataSource3: TDataSource
    DataSet = MySQLTable3
    Left = 392
    Top = 56
  end
end
