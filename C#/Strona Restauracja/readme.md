PL:

Mini aplikacja webowa do zamawiania jedzenia, napisana w technologii ASP.NET CORE (C#, SQL, T-SQL, RestAPI, WebAPI, Entity Framework)

Użyte Paczki:
- EntityFrameworkCore
- EntityFrameworkCore.SqlServer
- EntityFrameworkCore.Tools
- Swashbuckle
- NLog
- AutoMapper

Technologia Bazodanowa: SQL
Baza Danych:
Oparta na trzech tabelach (Restaurant, Dish, Adress) miedzy którymi istnieją następujące relacje:
- Restaurant : Dish (Jeden : Wielu)
- Restaurant : Adress (Jeden : Jeden)

Baza danych dodana poprzez ORM Entity Framework (Migracje) do lokalnej bazy danych, po wcześniejszej walidacji opartej na stworzonych modelach. 

Wzorzec Projektowy: Dependency Injection
W projekcie wszystkie potrzebne funkcje takie jak podpięcie bazy danych, dodanie mapowania, obsługa wyjątków błędów Middlawary, czy Dokumentacja API Swagger.

Dokumentacja REST API:

Pobierz wszystkie restauracje:
/get/restaurant

Pobierz dana restauracje:
/get/restaurant/<klucz>

Usuń restauracje:
/delete/restaurant/<klucz>

Przykładowe zapytania

Dla konkretnego miasta
/get/restaurant?city=Kraków

Sortowanie po nazwie
/get/restaurant?sortBy=Name

Stworzenie następujących zapytań do akcji kontrolera odpowiedzialnych wyciąganie danych z bazy lub dodawanie jej: 
- CreateRestaurant (HttpPost)
- GetAll (/)
- GetById (/get/id)
- Update (put/id)
- Delete (/delete/id)


Obsługa wyjątków:
W tym przypadku został skonfigurowany NLog. Dodany obsługa wszelkich błędów związanych z prób usunięcia zasobów serwerowych które nie istnieją, błędów API, ale tez wszelkimi błędami strony.

Mapowanie Modelu DTO:
Stworzenie odpowiednich klas z modelami, podobnych do tych które tworzą baz danych. Mają za zadanie ukryć zasoby nie potrzebne klientowi.


EN:

A mini web application for ordering food written in ASP.NET CORE technology (C #, SQL, T-SQL, RestAPI, WebAPI, Entity Framework)

Used parcels:
- EntityFrameworkCore
- EntityFrameworkCore.SqlServer
- EntityFrameworkCore.Tools
- Swashbuckle
- NLog
- AutoMapper

Database Technology: SQL
Database:
Based on three tables (Restaurant, Dish, Adress) between which there are the following relationships:
- Restaurant: Dish (One: Many)
- Restaurant: Adress (One: One)

Database added via ORM Entity Framework (Migrations) to the local database, after prior validation based on the created models.

Design Pattern: Dependency Injection
All the necessary functions in the project  such as database connection, adding mapping, Middlawary error exception handling, or Swagger API documentation.

REST API documentation:

Download all restaurants:
/ get / restaurant

Download a given restaurant:
/ get / restaurant / <key>

Delete Restaurants:
/ delete / restaurant / <key>

Sample Queries

For a specific city
/ get / restaurant? city = Krakow

Sort by name
/ get / restaurant? sortBy = Name

Creating the following queries to the controller actions responsible for extracting data from the database or adding it:
- CreateRestaurant (HttpPost)
- GetAll (/)
- GetById (/ get / id)
- Update (put / id)
- Delete (/ delete / id)

Exception Handling:
In this case, an NLog has been configured. Added handling of any errors related to attempts to remove server resources that do not exist, API errors, but also any page errors.

DTO Model Mapping:
Create appropriate classes with models similar to those that make up databases. They are designed to hide resources not needed by the client.
