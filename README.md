# Bus Reserbation System
------------

- download project 
- run update-database on package manger console with ifrastructre project on startup, to run migrations and seed data.
- then run API project that will start with swagger.
- Also this is file with solution called WeakCapTest.postman_collection.json that contain collection to run on postman that have 4 requests that describe our bussiness casse
  - Get frequent 
  - Post that's return already reserved 
  - Post that's to reserve more than capacity return No Capacity
  - Post Reserve that's will success on first time only to reserve seats after that will return already reserved.
--------------------------------------------------------------------------------------------------------------------
After seeding data we have two types of buses (bus1) for short trip (Cairo-Alexandria) and (bus2) for long trip (Cairo-Aswan) each bus have 20 seats 
seats numbers start from A01 to A20.
when reserving a seat there are 3 type of response 
- seat already reserved 
- no capacity in the bus
- Ticket Success with the ticket data
--------------------------------------------------------------------------------------------------------------------
There are APIs:
- Get that is get the most frequent trip booked by each user
  [
        {   
            "email": "user1@gmail.com",
            "frequentBook": "Cairo-Alexandria"
        },
        {
            "email": "user2@gmail.com",
            "frequentBook": "Cairo-Aswan"
        }
    ]
    
 - Post that is resreve a seat for example send to in the body 
       {
          "userEmail":"example@gamil.com",
          "tripRoute":"Cairo-Alexandria", // Cairo-Aswan
          "seats":["A01","A02","A03"]
      }

--------------------------------------------------------------------------------------------------------------------
- This solution is tring to follow Domain-Driven Design (DDD) principles (Onion Architecture) 
  - Infrastructure layer contain EF Core Migration - Repositories.
  - Application Core layer contain Interfaces -enums - services- helpers.
  - UI Layer contains Controllers api. 



