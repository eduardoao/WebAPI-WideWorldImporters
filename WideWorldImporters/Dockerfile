FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["WideWorldImporters.csproj", ""]
RUN dotnet restore "./WideWorldImporters.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "WideWorldImporters.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WideWorldImporters.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WideWorldImporters.dll"]