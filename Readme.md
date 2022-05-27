
# CS + EF + PGSQL (Container)

1. DB running from local Docker Image



# Docker

0.1. `dotnet publish -c Release` (from dockerFile)
1. `docker build -t cspgsql -f Dockerfile .`
2. `docker create -p 8080:80 --name cspgsql-container cspgsql`

3. `Docker ps -a`
4. `Docker start cspgsql-container`

# Docker Secrets

1. `docker swarm init`
2. `docker secret init`
3. `echo "cenas" | docker secret create key1 -`

