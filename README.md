# How to 


# Design Decisions

## DTO Structure
I've set this up using abstraction to share properties and logic in the base class Content

Content
-> Movie
-> Audiobook
-> Series
-> Music Album

I added an Enum in order to simplify the logic between the different Views, service and db.


## DB Design Intent
The design plan was to setup a Table Per Hierarchy approach using Entity Framework Core (EF Core), this is default behaviour in EF Core and reduces the logic required in the access Service. 

I chose EF Core as its generally the most common ORM in ASP.NET, with easy support for C# objects allowing for minimal time spent on DB setup.

We have the common non base class property Duration_mins between Movie and Audiobook, this has been specifically stated in the context to be shared.

Sample seed data was generated via LLM, parsed into the DBContext upon model creation

## Migrations
The initial migration was set up via "dotnet ef migrations add InitialCreate" through the terminal, to quickly set up the basic db and table via EF core.
