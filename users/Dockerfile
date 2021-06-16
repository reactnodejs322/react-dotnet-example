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
# # https://hub.docker.com/_/microsoft-dotnet
# FROM mcr.microsoft.com/dotnet/sdk:5.0.103 AS build
# WORKDIR /build

# # RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
# # RUN apt-get install -y nodejs

# # copy csproj and restore as distinct layers
# COPY ./*.csproj .
# RUN dotnet restore

# # copy everything else and build app
# COPY . .
# WORKDIR /build
# RUN dotnet publish -c release -o published --no-cache

# # final stage/image
# FROM mcr.microsoft.com/dotnet/aspnet:5.0
# WORKDIR /app
# COPY --from=build /build/published ./
# ENTRYPOINT ["dotnet", "react-dotnet-example.dll"]
