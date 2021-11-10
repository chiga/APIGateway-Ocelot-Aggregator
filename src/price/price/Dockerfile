#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/price/price/price.csproj", "src/price/price/"]
RUN dotnet restore "src/price/price/price.csproj"
COPY . .
WORKDIR "/src/src/price/price"
RUN dotnet build "price.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "price.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "price.dll"]