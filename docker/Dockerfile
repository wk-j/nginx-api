FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine as build

WORKDIR /app

COPY src/MyApp/MyApp.csproj src/MyApp/

RUN dotnet restore src/MyApp

COPY src/MyApp src/MyApp

RUN dotnet publish src/MyApp \
    -r linux-musl-x64 \
    -c Release \
    -o /out

# runtime
FROM mcr.microsoft.com/dotnet/runtime:5.0-alpine
ENV TZ='Asia/Bangkok'
RUN apk add --no-cache tzdata
WORKDIR /app
COPY --from=build /out .
CMD dotnet MyApp.dll
EXPOSE 80