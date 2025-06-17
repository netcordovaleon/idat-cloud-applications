FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src/aspnetapp

COPY *.sln .
COPY idat.domain/*.csproj ./idat.domain/
COPY idat.entities/*.csproj ./idat.entities/
COPY idat.services/*.csproj ./idat.services/
COPY idat.host/*.csproj ./idat.host/
COPY idat.shared/*.csproj ./idat.shared/

RUN dotnet restore
COPY . .

RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "idat.host.dll"]