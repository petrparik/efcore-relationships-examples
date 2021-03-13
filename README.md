# Entity Framework Core 5 relationships examples

This repo contains simple examples of relationships between the entities in your domain.



## One to Many

OneToMany directory contains Customer and Order classes.

One customer can have many Orders, one Order belongs to only one customer.

An order cannot exist without a customer.


## One to Many Standalone

OneToManyStandalone directory contains Post and Category classes.

One category contains many posts. One post belongs to only one category.

Difference between the previous example and this one is that category can exists without any posts.



## One to One

OneToOne directory contains Employee and PhoneExtension classes.

One employee can have only one phone extension assigned and one phone extension can be assigned to one employee only.


## Many to Many

ManyToMany directory contains Course and Student classes.

One course is attended by many students, one student can attend many courses.

Note that in Entity Framework Core 5 it is extremely easy to model this situation - just add a collection to each.



## Many to Many with Payload

ManyToManyWithPayload directory contains Person, Position and PersonPosition classes.

Sometimes it is necessary to track additional information for the many to many relationships. 

In this example, one person can have more positions, one position can have more persons. Compared to the previous example, we need to know stand and end date of this relationship.


