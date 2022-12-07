# Santas wishlist

## Endpoints

This is the list of endpoints needed in this API

### Used by frontend

GET /persons
GET /persons/:name
DELETE /persons
POST /persons


### Not implemented

PATCH /persons

GET /gifts
GET /gifts/:name
DELETE /gifts
POST /gifts
PATCH /gifts

## Additional notes

Person KindnessRating is an int, while the Git KindnessType is an Enum consisting of "Bad", "Average" and "Good". This needs to be transformed in the API.

Bad <= 33%
33% < Average < 66%
67% < Good

## Models
 
### Person
Id string (varchar(32))
Name string (varchar(100))
Country string (varchar(100))
KindnessRange (int)

### Gift
Id string (varchar(32))
Name string (varchar(100))
KindnessTier (int)