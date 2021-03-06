
# DotNet Core Layered Architecture Example ##

  

## For test:

  
  

Login to the site below: (required Dockerhub account)

    https://labs.play-with-docker.com/

  

then clone this project via github:

    git clone https://github.com/nekinci/simple-netcore-layered.git

  

then change directory:

    cd simple-netcore-layered

  

then build&start project with docker:

    docker build -t mytest:0.1 .
    docker run -it -p 80:80 mytest:0.1
Click on the 80 port that appears, then go to the / employees link
For example: http: //generatedurl.com /employees

  
  

## Project Structure

**Core** : Common Interfaces and Objects
**DataAccess**: Data Access Framework and Repository Pattern Implementations. Repository pattern depentend on (e.g. EF Core, NHibernate ..)  Entity Framework Core for this project.
**Entities:** Project DTO and Entities
**Business:** Project Business Logics and Services dependent on DataAccessLayer.
**WebAPI:** API Http Endpoints. Depentend on Business Layer.
