# Etapa 1 - build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY *.sln ./
COPY TodoPomodoro.API/*.csproj ./TodoPomodoro.API/
COPY TodoPomodoro.Domain/*.csproj ./TodoPomodoro.Domain/
COPY TodoPomodoro.Application/*.csproj ./TodoPomodoro.Application/
COPY TodoPomodoro.Infrastructure/*.csproj ./TodoPomodoro.Infrastructure/

RUN dotnet restore

COPY . .
WORKDIR /src/TodoPomodoro.API
RUN dotnet publish -c Release -o /app/publish

# Etapa 2 - runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TodoPomodoro.API.dll"]
