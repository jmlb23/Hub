FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/sdk:6.0-alpine  AS build-env
WORKDIR /app

COPY [".", "./"]
RUN dotnet restore Hub.sln
RUN dotnet publish -c Release -o out

FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/aspnet:6.0-alpine
EXPOSE 5000
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5000
COPY --from=build-env /app/out .
RUN chmod +x ./Hub.Api.dll
ENTRYPOINT ["dotnet", "./Hub.Api.dll"]
