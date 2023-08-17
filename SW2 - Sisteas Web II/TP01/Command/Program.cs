using Command;

/*
 Dupla:
 Gabriel Ferreira de Souza
 Rian Gustavo Quintanilha de Aquino
*/

/*
 Test.Main();
*/

IWebHost host = new WebHostBuilder().UseKestrel().UseStartup<Startup>().Build();
host.Run();