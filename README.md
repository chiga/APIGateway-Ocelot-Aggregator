# APIGateway-Ocelot-Aggregator
APIGateway example using Ocelot and Aggregator and Docker compose

## To use with docker, follow this steps:
  1. Open your Windows Terminal and type:
```  
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d
```

  2. Just open the Postman or the browser and type:
```
http://localhost:7000/books/3872339b-5556-4c94-b7ca-2cc8abde32d8/details
http://localhost:7000/books/3872339b-5556-4c94-b7ca-2cc8abde32d8/price

http://localhost:7000/books/3872339b-5556-4c94-b7ca-2cc8abde32d8/aggregated-details
```

The port of API Gateways is 7000.

    
