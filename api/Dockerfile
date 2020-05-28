FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app

COPY . ./
RUN dotnet restore MyApi.sln

RUN dotnet tool install --global dotnet-ef

ENV PATH="/root/.dotnet/tools:${PATH}"

# ENTRYPOINT [ "dotnet", "run", "--project", "MyApi/MyApi.csproj", "--no-restore", "--urls", "http://0.0.0.0:5000" ]
