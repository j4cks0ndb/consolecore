## Console Core

dotnet new console -n GameTOP #Cria projeto 
dotnet new classlib -n GameTOP.Lib #Cria projeto Lib
dotnet new sln -n GameTOP #Cria solução
dotnet add .\GameTOP\GameTOP.csproj reference .\GameTOP.Lib\GameTOP.Lib.csproj #Adiciona referencia do prj Lib 
dotnet sln GameTOP.sln add .\GameTOP\GameTOP.csproj .\GameTOP.Lib\GameTOP.Lib.csproj #Adiciona projetos na solução
dotnet run #Executa aplicação
dotnet run --project .\GameTOP\GameTOP.csproj #Executa aplicação
dotnet watch run #Executa a aplicação e fica monitorando alteração em arquivos e reinicia a aplicação caso algum arquivo seja modificado e salvo