#### How can create database?

- Create docker image `docker run --name codingWiki -e MYSQL_ROOT_PASSWORD=P@ssw0rd -p 3306:3306  -d mysql:latest`
- after connecting on it create database `CREATE DATABASE CodingWiki;`

#### How can connect to database?

1. Use any mysql client to connect to the DB Server. Recommended: Rider's DB Client
2. Rider will ask you for the connection port **3306**, username **root**, password **P@ssw0rd**
3. Create a new Database named `CodingWiki` through the client or run this sql script `CREATE DATABASE CodingWiki`

#### How can I add a new table?

1. Add your table to SherlockMySqlDBContext.cs as a DBSet<>
2. Run `dotnet ef migrations add {MyMigrationName}` to add a new diff
3. To see your changes locally, run `dotnet ef database update`