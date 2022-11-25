# Billing API
## Install dependencies
```
dotnet restore
dotnet build
```
## Database
### DB Location
Copy the file `./Extras/billing.db` inside the path `C://`, if you want to change the location remember to edit the value "ConnectionString" in appsetings.json
```json
{
    //...
    "ConnectionString":"C:\\"
    //...
}
```
### Run Test
To run unit test you need to run the command below:

```
dotnet test
```
### Run API
To run the API you need to run the command below:
```
dotnet run
```
### Publish for production
To publish for production you need to run the command below:
```
dotnet publish -c Release
```