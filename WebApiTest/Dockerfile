FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebApiTest/WebApiTest.csproj", "WebApiTest/"]
COPY ["Home.Core/Home.Core.csproj", "Home.Core/"]
RUN dotnet restore "WebApiTest/WebApiTest.csproj"
COPY . .
WORKDIR "/src/WebApiTest"
RUN dotnet build "WebApiTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApiTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApiTest.dll"]
