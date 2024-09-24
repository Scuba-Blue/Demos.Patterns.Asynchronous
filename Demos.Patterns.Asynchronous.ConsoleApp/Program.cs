using Demos.Patterns.Asynchronous.ConsoleApp;
using Demos.Patterns.Asynchronous.Demos.Breakfast;
using Demos.Patterns.Asynchronous.Demos.Database;
using Demos.Patterns.Asynchronous.Demos.Links;


//  note: demos 10-50 adapted from MS documentation
//  https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/#final-version

//  need to show calling async code from sync
//  need to show calling sync code from async

var demo10 = DemoRunner.RunSyncDemo<CookBreakfastSync10>();
var demo20 = await DemoRunner.RunAsyncDemo<CookBreakfastAsync20>();
var demo30 = await DemoRunner.RunAsyncDemo<CookBreakfastAsync30>();
var demo40 = await DemoRunner.RunAsyncDemo<CookBreakfastAsync40>();
var demo50 = await DemoRunner.RunAsyncDemo<CookBreakfastAsync50>();
var demo60 = await DemoRunner.RunAsyncDemo<CookBreakfastAsync60>();

//  database access
//var demo1000 = DemoRunner.RunSyncDemo<SpinupDbContext1000>();
//var demo1010 = DemoRunner.RunSyncDemo<ListSyncDatabaseCall1010>();
//var demo1020 = await DemoRunner.RunAsyncDemo<ListDatabaseCallAsync1020>();

//  dependent processes requiring await from something previous.


DemoRunner.RunSyncDemo<UsefulLinksDemo9999>();