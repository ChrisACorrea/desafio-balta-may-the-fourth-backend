![balta](https://baltaio.blob.core.windows.net/static/images/dark/balta-logo.svg)

![Logo do App](https://github.com/balta-io/desafio-balta-may-the-fourth-backend/assets/965305/880fab7e-3998-4a0d-98ad-1d6ffc11298b)

## 🎖️ Desafio

**May the Fourth** é a quarta edição dos **Desafios .NET** realizados pelo [balta.io](https://balta.io). Durante esta jornada, fizemos parte do batalhão backend onde unimos forças para entregar um App completo.

## 📱 Projeto

Desenvolvimento de uma API completa, fornecendo recursos como criação, leitura, atualização e exclusão de dados referentes ao universo **Star Wars**.

## Participantes

### 🚀 Capitão

André - [Github](https://github.com/anpecha)

### 💂‍♀️ Batalhão

- Christopher Corrêa - [Github](https://github.com/ChrisACorrea)
- Gabriel Ferreira - [Github](https://github.com/Gabriel-F-13)
- Jonathan Vale - [Github](https://github.com/KennyMack)

## ⚙️ Tecnologias

- C# 12
- .NET 8
- ASP.NET
- Minimal APIs

## 🥋 Skills Desenvolvidas

- Comunicação
- Trabalho em Equipe
- Networking
- Muito conhecimento técnico

## 🛰️ Acesse a aplicação

Através do link abaixo é possível visualizar a aplicação

[May The Fourth API](http://maythefourthapi.azurewebsites.net/swagger/index.html)

## 🧪 Como testar o projeto

### 🐋 Rodando com docker

### Pré-requisitos

1. Tenha o docker instalado e configurado;

#### Iniciando a aplicação

Acesse a pasta <b>src<b> e rode o comando abaixo:

```bash
docker-compose up --build -d
```

A aplicação iniciará o banco de dados (Postgres) e executará o migrate inicial

Após concluir os passos anteriores será possível acessar a api pelo link (`http:\\localhost:8080`) no navegador e consultar as operações disponíveis pelo `swagger`

### 💻 Rodando sem docker

### Pré-requisitos

1. .Net Core SDK instalado;
2. .Net EF tools instalado;
3. Postgresql instaldo e configurado;

#### Populando o banco de dados:

Acesse a pasta <b>src/MayTheFourth/MayTheFourth.Repositories<b> e configure a string de conexão para o banco de dados no arquivo `appsettings.json`

```json
{
  "DefaultConnectionString": "Migrations",
  "ConnectionStrings": {
    "Migrations": "Host=localhost;Port=5432;Database=maythefourth;Username=postgres;Password=postgres"
  }
}
```

Após configurar execute o comando abaixo para aplicar as migrations na base de dados

```bash
{
  dotnet ef database update
}
```

A aplicação irá aplicar as migrações

### Executando a aplicação

Após executar as migrações será possível iniciar a aplicação
acesse a pasta <b>src/MayTheFourth/MayTheFourth.API<b> e configure a string de conexão para o banco de dados no arquivo `appsettings.json`

```json
{
  "DefaultConnectionString": "Prod",
  "ConnectionStrings": {
    "Prod": "Host=localhost;Port=5432;Database=maythefourth;Username=postgres;Password=postgres"
  }
}
```

Após configurar execute o comando abaixo para iniciar a aplicação

```bash
{
  dotnet run environment=production --configuration Release
}
```

Após concluir os passos anteriores será possível acessar a api pelo link (`http:\\localhost:5177`) no navegador e consultar as operações disponíveis pelo `swagger`

# 💜 Participe

Quer participar dos próximos desafios? Junte-se a [maior comunidade .NET do Brasil 🇧🇷 💜](https://balta.io/discord)
