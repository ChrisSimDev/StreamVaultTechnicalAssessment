# How to run
This should execute from standard F5, the ".vscode" should provide you with the default launch required


# Design Decisions

## DTO Structure
I've set this up using abstraction to share properties and logic in the base class Content.

Content
-> Movie
-> Audiobook
-> Series
-> Music Album

I added an Enum in order to simplify the logic between the different Views, service and db.


## DB Design Intent
The design plan was to setup a Table Per Hierarchy approach using Entity Framework Core (EF Core), this is default behaviour in EF Core and reduces the logic required in the access Service. 

I chose EF Core as its generally the most common ORM in ASP.NET, with easy support for C# objects allowing for minimal time spent on DB setup.

We have the common non base class property Duration_mins between Movie and Audiobook, this has been specifically stated in the context to be shared to reduce db size.

Sample seed data was generated via LLM, parsed into the DBContext upon model creation


## Migrations
The initial migration was set up via "dotnet ef migrations add InitialCreate" through the terminal, to quickly set up the basic db and table via EF core.

## Data Access service
I've used a simple service layer to interact with the db with no caching. This minimises complexity for the application.

## UI
I went for an approach of passing search query parameters and the id through the urls for the Index page and Content page respectively.
This meant that for ui that would have to change based upon these parameters, e.g. the content list table, can update via a refresh only.
This avoids having to handle script sections of the html that would be more difficult to follow

# What I'd do next time
If this was going to production I would seek more information on the original premise. Does it make sense for all of the content types to be grouped together?
e.g. focusing on the customer journey is the movie and series likely to overlap heavily with music and audiobook.

It would be worth considering based upon the scale of the system whether a Table per Concrete Class (TPC) approach is more suitable.
The current system is effective where the admin team are likely to need to inspect different content types simulateously. 
A TPC approach here would be excessive due to the required UNIONs in the query having to merge multiple tables.
If the admin team would be happy looking one content at a time, we could reduce the number of rows to query over

My system assumes a small number of entries and as such doesnt worry about limiting the number of items returned from the DB.
In an actual production system this would be required as to not cause the UI to break.

I would include additional filtering options with specific options available depending on content type selection.
I could also include multi select approachs on the content type list, i.e. filter to just movies and series

Currently the db connection is hard coded locally, it would be better to setup with environment variables to allow for a db running in a cloud container (e.g. RDS in AWS)