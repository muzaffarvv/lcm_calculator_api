FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ITask3_Cs.csproj", "./"]
RUN dotnet restore "ITask3_Cs.csproj"
COPY . .
RUN dotnet build "ITask3_Cs.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ITask3_Cs.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ITask3_Cs.dll"]