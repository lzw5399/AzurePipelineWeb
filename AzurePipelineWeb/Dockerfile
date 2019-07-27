FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["AzurePipelineWeb/AzurePipelineWeb.csproj", "AzurePipelineWeb/"]
RUN dotnet restore "AzurePipelineWeb/AzurePipelineWeb.csproj"
COPY . .
WORKDIR "/src/AzurePipelineWeb"
RUN dotnet build "AzurePipelineWeb.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AzurePipelineWeb.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AzurePipelineWeb.dll"]