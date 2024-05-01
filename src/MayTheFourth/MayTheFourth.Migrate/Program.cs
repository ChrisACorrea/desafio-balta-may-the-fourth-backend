using MayTheFourth.Repositories.Context;

Console.WriteLine("Aplicação para migração da base de dados.");

var clearDatabase = false;

switch (args.Length)
{
    case <= 0:
        Console.WriteLine("Informe a ConnectionString");
        return;
    case > 1:
        clearDatabase = args[1].Equals("S", StringComparison.OrdinalIgnoreCase);
        break;
}

if (clearDatabase)
    Console.WriteLine("Os dados da base de dados serão apagados");

Console.WriteLine("Iniciando migração");
var factory = new DatabaseContextFactory();
using var context = factory.CreateDbContext(args);
factory.Migrate(context, clearDatabase);
Console.WriteLine("Migração concluída");