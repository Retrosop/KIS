object TovarForm: TTovarForm
  Left = 280
  Top = 221
  Width = 1115
  Height = 675
  Caption = 'TovarForm'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Button1: TButton
    Left = 88
    Top = 24
    Width = 321
    Height = 169
    Caption = #1058#1086#1074#1072#1088#1099
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 432
    Top = 24
    Width = 321
    Height = 177
    Caption = #1055#1086#1089#1090#1072#1074#1097#1080#1082#1080
    TabOrder = 1
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 16
    Top = 224
    Width = 321
    Height = 177
    Caption = #1055#1088#1080#1093#1086#1076
    TabOrder = 2
    OnClick = Button2Click
  end
  object Button4: TButton
    Left = 360
    Top = 224
    Width = 329
    Height = 177
    Caption = #1055#1086#1076#1082#1083#1102#1095#1077#1085#1080#1077' '#1082' '#1083#1086#1082#1072#1083#1100#1085#1086#1081' '#1057#1059#1041#1044
    TabOrder = 3
    OnClick = Button4Click
  end
  object Button5: TButton
    Left = 720
    Top = 224
    Width = 305
    Height = 177
    Caption = 'Button5'
    TabOrder = 4
    OnClick = Button5Click
  end
  object MainMenu1: TMainMenu
    Left = 32
    Top = 32
    object N1: TMenuItem
      Caption = #1057#1080#1089#1090#1077#1084#1072
      object N4: TMenuItem
        Caption = #1053#1072#1089#1090#1088#1086#1081#1082#1080
      end
      object N5: TMenuItem
        Caption = #1042#1099#1093#1086#1076
      end
    end
    object N2: TMenuItem
      Caption = #1041#1072#1079#1072' '#1076#1072#1085#1085#1099#1093
      object N6: TMenuItem
        Caption = #1058#1086#1074#1072#1088#1099
        OnClick = N6Click
      end
      object N7: TMenuItem
        Caption = #1055#1086#1089#1090#1072#1074#1097#1080#1082#1080
      end
      object N8: TMenuItem
        Caption = #1055#1088#1080#1093#1086#1076
      end
      object N9: TMenuItem
        Caption = #1047#1072#1087#1088#1086#1089#1099
      end
    end
    object N3: TMenuItem
      Caption = #1057#1087#1088#1072#1074#1082#1072
      object N10: TMenuItem
        Caption = #1054' '#1087#1088#1086#1075#1088#1072#1084#1084#1077
      end
      object N11: TMenuItem
        Caption = #1057#1087#1088#1072#1074#1082#1072
      end
    end
  end
end