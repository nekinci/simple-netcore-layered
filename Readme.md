
# DotNet Core Layered Architecture Example ##

  

## For test:

  
  

Login to the site below: (required Dockerhub account)

    https://labs.play-with-docker.com/

  

then clone this project via github:

    git clone https://github.com/nekinci/netcore-layered-api

  

then change directory:

    cd netcore-layered-api

  

then build&start project with docker:

    docker build -t myTest:0.1 .

  
  

## Project Structure

**Core** : Common Interfaces and Objects
**DataAccess**: Data Access Framework and Repository Pattern Implementations. Repository pattern depentend on (e.g. EF Core, NHibernate ..)  Entity Framework Core for this project.
**Entities:** Project DTO and Entities
**Business:** Project Business Logics and Services dependent on DataAccessLayer.
**WebAPI:** API Http Endpoints. Depentend on Business Layer.