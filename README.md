# ClientDBSystem
Small Client Database that adds, stores, deletes and check if that given client is already listed. It also displays a list of all clients registered on that database when
determined button is pressed. 

Error checking explanation:

If you don't input anything in the name field and try to add a client. The process won't allow you to add it, since it is required to have at least a character on the name field.

If you don't change the age field, the client added will have the default age of 0. 

If you try to add characters on the age field, it will only catch the first int elements. For example, if you try to enter "21abc", the system will only process and store "21".

Also, the system only allow clients to have 3 names: a first name, middle name and last name. Therefore, if you try to enter more names, it will only process the first name,
last name, and the second name. 
