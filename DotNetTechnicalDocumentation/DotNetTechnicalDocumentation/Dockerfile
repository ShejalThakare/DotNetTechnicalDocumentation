FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY ["DotNetTechnicalDocumentation.csproj", "./"]

RUN dotnet restore "DotNetTechnicalDocumentation.csproj"

COPY . .

RUN dotnet publish \
    "DotNetTechnicalDocumentation.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

ENV ASPNETCORE_HTTP_PORTS=8080

EXPOSE 8080

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "DotNetTechnicalDocumentation.dll"]