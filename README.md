For DB connection:
docker run --name codingWiki -e MYSQL_ROOT_PASSWORD=P@ssw0rd -p 3306:3306  -d mysql:latest
then connect onit by name: root for local host
CREATE DATABASE CodingWiki;

1. Use any mysql client to connect to the DB Server. Recommended: Rider's DB Client
2. Rider will ask you for the connection port **3306**, username **root**, password **P@ssw0rd**
3. Create a new Database named `CodingWiki` through the client or run this sql script `CREATE DATABASE CodingWiki`
