# 

## Commands

```c#
dotnet add swagger.csproj package NSwag.AspNetCore
```

```bash
dotnet build
```

```bash
dotnet run
```

`https://localhost:5001/Prime`

`https://localhost:5001/swagger`

`https://localhost:5001/swagger/v1/swagger.json`

```c#
services.AddSwaggerDocument();
```

```c#
app.UseOpenApi();
```

```c#
app.UseSwaggerUi3();
```

```bash
dotnet build
```

```bash
dotnet run
```

```bash
curl -X 'GET' 'https://localhost:5001/Prime' -H 'accept: text/plain'
```

## Additional

```c#
_logger.LogInformation("Example log message2");
```

```bash
dotnet new gitignore
```
