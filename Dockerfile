FROM mcr.microsoft.com/dotnet/core/sdk:3.0 as build

WORKDIR /app

COPY . .

RUN dotnet publish -c Release -o ./publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0

WORKDIR /app

COPY --from=build ./app/publish .

EXPOSE 80

CMD ["dotnet", "WebAPI.dll"]