# Use the official .NET 6 SDK as a base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the necessary files to the container
COPY *.csproj ./
COPY . ./

# Build the application
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Use a smaller runtime image for the final image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

# Set the working directory inside the container
WORKDIR /app

# Copy the built application from the build image
COPY --from=build /app/out ./

# Set the entry point for the application
ENTRYPOINT ["dotnet", "SequenceFinder.dll"]
