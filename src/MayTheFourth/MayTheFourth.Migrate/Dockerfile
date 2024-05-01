FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MayTheFourth.Migrate/MayTheFourth.Migrate.csproj", "MayTheFourth.Migrate/"]
COPY ["MayTheFourth.Repositories/MayTheFourth.Repositories.csproj", "MayTheFourth.Repositories/"]
COPY ["MayTheFourth.Entities/MayTheFourth.Entities.csproj", "MayTheFourth.Entities/"]
COPY ["MayTheFourth.Utils/MayTheFourth.Utils.csproj", "MayTheFourth.Utils/"]
RUN dotnet restore "MayTheFourth.Migrate/MayTheFourth.Migrate.csproj"
COPY . .
WORKDIR "/src/MayTheFourth.Migrate"
RUN dotnet build "MayTheFourth.Migrate.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "MayTheFourth.Migrate.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MayTheFourth.Migrate.dll"]
