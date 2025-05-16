# Etapa 1 - build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY *.sln ./
COPY TimeBinder.WebAPI/*.csproj ./TimeBinder.WebAPI/
COPY TimeBinder.Domain/*.csproj ./TimeBinder.Domain/
COPY TimeBinder.Application/*.csproj ./TimeBinder.Application/
COPY TimeBinder.Infrastructure.MongoDB/*.csproj ./TimeBinder.Infrastructure.MongoDB/

RUN dotnet restore

COPY . .
WORKDIR /src/TimeBinder.WebAPI
RUN dotnet publish -c Release -o /app/publish

# Etapa 2 - runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TimeBinder.WebAPI.dll"]
