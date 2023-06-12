FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copio los archivos
COPY . .

# restauro paquetes
RUN dotnet restore

# compilo
RUN dotnet build --no-restore --configuration Release

# publico
RUN dotnet publish --no-restore --configuration Release --output /app/publish

# creacion de imagen final
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .

# connect db
ENV ConnectionStrings__DefaultConnection="Server=(localdb)\\mssqllocaldb;Database=TarjetaCreditoDB;Trusted_Connection=True;MultipleActiveResultSets=true;"

# Swagger config
ENV ASPNETCORE_ENVIRONMENT="Development"
ENV ASPNETCORE_URLS="http://+:80"
EXPOSE 80

# Falta https config

# ejecutar app
ENTRYPOINT ["dotnet", "BackTarjeta.dll"]
