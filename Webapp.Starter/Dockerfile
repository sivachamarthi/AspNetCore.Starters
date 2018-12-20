FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Webapp.Starter/Webapp.Starter.csproj", "Webapp.Starter/"]
RUN dotnet restore "Webapp.Starter/Webapp.Starter.csproj"
COPY . .
WORKDIR "/src/Webapp.Starter"
RUN dotnet build "Webapp.Starter.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Webapp.Starter.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Webapp.Starter.dll"]