FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["MicroservicesSolution/MicroservicesSolution.csproj", "MicroservicesSolution/"]

RUN dotnet restore "MicroservicesSolution/MicroservicesSolution.csproj"
COPY . .
WORKDIR "/src/MicroservicesSolution"
RUN dotnet build "MicroservicesSolution.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroservicesSolution.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroservicesSolution.dll"]