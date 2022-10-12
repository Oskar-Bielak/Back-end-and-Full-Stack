PL:

Apikacja webowa napisana w technologii ASP.NET CORE (RestAPI, WebAPI, Entity Framework, )


Dokumentacja API:

Dodaj restauracje:

/restaurant/all
/getAll?resourse=restaurant
/restaurant?getAll=true

REST API:

Pobierz wszystkie restauracje:
/get/restaurant

Pobierz dana restauracje:
/get/restaurant/<klucz>

Usuń restauracje:
/delete/restaurant/<klucz>

Przykłądowe zapytania

Dla konkretnego miasta
/get/restaurant?city=Kraków

Sortowanie po nazwie
/get/restaurant?sortBy=Name