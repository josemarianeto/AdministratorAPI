FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AdministratorAPI/AdministratorAPI.csproj", "AdministratorAPI/"]
RUN dotnet restore "AdministratorAPI/AdministratorAPI.csproj"
COPY . .
WORKDIR "/src/AdministratorAPI"
RUN dotnet build "AdministratorAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdministratorAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdministratorAPI.dll"]
