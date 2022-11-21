#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Billing-API/Billing-API.csproj", "Billing-API/"]
RUN dotnet restore "Billing-API/Billing-API.csproj"
COPY . .
WORKDIR "/src/Billing-API"
RUN dotnet build "Billing-API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Billing-API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Billing-API.dll"]