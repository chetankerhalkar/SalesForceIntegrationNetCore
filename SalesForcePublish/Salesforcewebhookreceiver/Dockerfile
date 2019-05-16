FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 54656
EXPOSE 44382

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Salesforcewebhookreceiver/Salesforcewebhookreceiver.csproj", "Salesforcewebhookreceiver/"]
RUN dotnet restore "Salesforcewebhookreceiver/Salesforcewebhookreceiver.csproj"
COPY . .
WORKDIR "/src/Salesforcewebhookreceiver"
RUN dotnet build "Salesforcewebhookreceiver.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Salesforcewebhookreceiver.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Salesforcewebhookreceiver.dll"]