# Projeto_EntityFramework

##Comandos Entity Framework

Comando para instalar a ferramentas para trabalhar com Entity FrameWork
```
dotnet tool install --global dotnet-ef
```
Comando para atualizar as ferramentas
```
dotnet tool update --global dotnet-ef
```

Comando para habilitar a migração
```
enable-migrations
```

Comando para adicionar a migração
```
add-migration <nomeDoBanco_numeroDaMigracao>
```

Comando para atualizar o banco de dados
```
update-database
```

Obs: Toda vez que for adicionar uma tabela ou modificação no banco de dados, tem que adicionar a migração( incluir sempre 1 número a mais do que a ultima migração, ou seja, fazer um `version bump`) e logo em seguida fazer o update no banco de dados.
