FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY Hub.Api/*.csproj Hub.Data/*.csproj Hub.Domain/*.csproj Hub.Infra/*.csproj ./
RUN dotnet restore

COPY Hub.Api Hub.Data Hub.Domain Hub.Infra ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out/Hub.Api .
ENTRYPOINT ["./Hub.Api"]
