- C#-klass xmlWorker för separation of concerns från programlogik. För skalbarhet om fler metoder eller funktionalitet skulle behövas i framtiden för XML-hantering.

- Programlogik med instantiering av xmlWorker-klass, förvaring av värden i variabler för större flexbilitet.

- LINQ query för filtrering på element-tag, på element-id samt hämtande av elements värde med det eftersökta íd:t och taggen.

- Felhantering med nullable reference i LINQ samt hämtande av värde (för att sätta hela uttrycken till null vid trigger). 

- Sista felhantering och kontroll av nullvärde när xmlWorker-metoden anropas med fallback output i konsollen.