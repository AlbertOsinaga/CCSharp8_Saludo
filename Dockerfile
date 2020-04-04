FROM mcr.microsoft.com/dotnet/core/sdk:3.1
COPY Consola app
WORKDIR /app

CMD [ "dotnet", "run" ]