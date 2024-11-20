unit prihod;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, DB, mySQLDbTables, ExtCtrls, DBCtrls, Grids, DBGrids, StdCtrls,
  Mask;

type
  TPrihodForm = class(TForm)
    DBGrid1: TDBGrid;
    DBNavigator1: TDBNavigator;
    MySQLDatabase1: TMySQLDatabase;
    MySQLTable1: TMySQLTable;
    DataSource1: TDataSource;
    MySQLTable2: TMySQLTable;
    DataSource2: TDataSource;
    MySQLTable1idprihod: TAutoIncField;
    MySQLTable1idtovar: TIntegerField;
    MySQLTable1datprih: TDateField;
    MySQLTable1kolvo: TIntegerField;
    MySQLTable1idpostav: TIntegerField;
    MySQLTable1namepostav: TStringField;
    MySQLTable3: TMySQLTable;
    MySQLTable1nametovar: TStringField;
    DBEdit1: TDBEdit;
    DBEdit2: TDBEdit;
    DBLookupComboBox1: TDBLookupComboBox;
    DBLookupComboBox2: TDBLookupComboBox;
    DataSource3: TDataSource;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    DBMemo1: TDBMemo;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  PrihodForm: TPrihodForm;

implementation

{$R *.dfm}

end.
