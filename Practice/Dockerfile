# Use .NET 8.0 SDK as build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 as build-env
WORKDIR /src
COPY . .
RUN dotnet restore "./Practice/Practice.csproj" --disable-parallel
RUN dotnet publish "./Practice/Practice.csproj" -c Release -o /app

# Use .NET 8.0 ASP.NET runtime for the final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 as runtime
WORKDIR /app
COPY --from=build-env /app ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "Practice.dll"]