# NET-Core-DevSecOps

I will practice DevSecOps with NET core APIs here.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A code editor like [Visual Studio Code](https://code.visualstudio.com/)
- [Docker](https://www.docker.com/) installed and running

## How to Run the Project

### Using .NET CLI

1. Clone the repository:
    ```bash
    git clone https://github.com/StevenYu0124/NET-Core-DevSecOps.git
    cd NET-Core-DevSecOps/NetCoreApis
    ```

2. Restore the dependencies:
    ```bash
    dotnet restore
    ```

3. Run the project:
    ```bash
    dotnet run
    ```

4. Open your browser and navigate to:
    - Swagger UI: http://localhost:5072/swagger

### Using Docker

1. Clone the repository:
    ```bash
    git clone https://github.com/StevenYu0124/NET-Core-DevSecOps.git
    cd NET-Core-DevSecOps/
    ```

2. Build and run the project using Docker Compose:
    ```bash
    docker compose up --build
    ```