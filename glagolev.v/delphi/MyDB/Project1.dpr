program Project1;

uses
  Forms,
  Unit1 in 'Unit1.pas' {TovarForm},
  Unit2 in 'Unit2.pas' {Form2},
  Unit3 in 'Unit3.pas' {PostavForm},
  prihod in 'prihod.pas' {PrihodForm},
  Unit4 in 'Unit4.pas' {Form4},
  Unit5 in '..\..\..\..\Olga\CIRCIE-7\MyBD1\Unit5.pas' {Form5};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TTovarForm, TovarForm);
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TPostavForm, PostavForm);
  Application.CreateForm(TPrihodForm, PrihodForm);
  Application.CreateForm(TForm4, Form4);
  Application.CreateForm(TForm5, Form5);
  Application.Run;
end.
