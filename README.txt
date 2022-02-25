This is how I worked things in this app:

1)I added the entities that were asked by checking the value types from the API.

2)I created a controller named BaseApiController as the base controller of the application 
and gets inherited from every other controller.

3)In the BaseAPIControllerI used the API Key and the API's url to connect my application with Megaventory API 

4)I created the controllers for discount, inventorylocation, product, suppleirclient and tax and 
inserted the values that were asked through HttpPost

5)I haven't found a way to do SalesOrder, things got a bit complicated there. If I had a database 
(probably using an ORM like EF Core), I could use LINQ to include the database relationship between SalesOrder
and SalesOrderDetails. Overall, I'm not sure in which "salesorder" properties, I'm supposed to add the 
discount, inventorylocation, product, suppleirclient and tax ones.

Overall, this is my first time I worked with an external API so I'm a novice on that one. I always 
worked on apps creating my own database, authentication, oauth etc. so that was new to me.