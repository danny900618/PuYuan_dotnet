# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /PuYuan

# Copy everything
# COPY . /PuYuan
# Restore as distinct layers
COPY ./PuYuan /PuYuan
RUN dotnet restore

# COPY ./PuYuan /PuYuan
# RUN dotnet tool install --global dotnet-ef
# ENV PATH="$PATH:/root/.dotnet/tools"
# RUN dotnet ef migrations add InitialCreate
# COPY ./PuYuan /PuYuan
# RUN dotnet ef database update
# RUN dotnet ef database update -- --environment Production   
# COPY ./PuYuan /PuYuan
# Build and publish a release

RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /PuYuan
COPY --from=build-env /PuYuan/out .
ENTRYPOINT ["dotnet", "PuYuan.dll"]