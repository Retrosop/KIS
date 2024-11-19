program Project1;

uses
  Forms,
  Unit1 in 'Unit1.pas' {TovarForm},
  Unit2 in 'Unit2.pas' {Form2},
  Unit3 in 'Unit3.pas' {PostavForm},
  prihod in 'prihod.pas' {PrihodForm};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TTovarForm, TovarForm);
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TPostavForm, PostavForm);
  Application.CreateForm(TPrihodForm, PrihodForm);
  Application.Run;
end.
