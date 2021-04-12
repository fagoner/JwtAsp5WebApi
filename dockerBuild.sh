docker rmi -f jwtaspwebapi5:dev || true
docker build -t jwtaspwebapi5:dev . || true
docker rmi $(docker images -f "dangling=true" -q) || true