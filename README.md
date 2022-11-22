# Billing API
## Install dependencies
```
dotnet restore
dotnet build
```
## Database
### DB Location
Previously remember to edit the value "ConnectionString" in appsetings.json
```json
{
    //...
    "ConnectionString":"D:\\"
    //...
}
```
### Create DB and initial records
To create the database and initial records we need to execute the next comandline in the BillinbLibrary folder path:

```
dotnet ef database update
```