# Development Mode
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
FROM mcr.microsoft.com/dotnet/sdk:5.0.103 AS build
WORKDIR /src
COPY ["react-dotnet-example.csproj", "./"]
RUN dotnet restore "./react-dotnet-example.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "react-dotnet-example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "react-dotnet-example.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
EXPOSE 80
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT ["dotnet", "react-dotnet-example.dll"]
