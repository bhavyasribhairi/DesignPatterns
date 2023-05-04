// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");

AbstractRemoteControll absremoteCtrl= new SamsuiRemoteControl(new Sansui());

absremoteCtrl.SetChannel(2);
AbstractRemoteControll asbremoteCtrl = new SonyRemoteControl(new Sony());
asbremoteCtrl.SetChannel(3);
