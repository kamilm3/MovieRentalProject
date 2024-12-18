USE project291;

-- Insert test data into Actor
INSERT INTO Actor (firstName, lastName, Gender, DateofBirth) VALUES 
('Robert', 'Downey Jr.', 'Male', '1965-04-04'),
('Scarlett', 'Johansson', 'Female', '1984-11-22'),
('Chris', 'Hemsworth', 'Male', '1983-08-11'),
('Jennifer', 'Lawrence', 'Female', '1990-08-15'),
('Tom', 'Holland', 'Male', '1996-06-01'),
('Chris', 'Evans', 'Male', '1981-06-13'),
('Emma', 'Stone', 'Female', '1988-11-06'),
('Ryan', 'Reynolds', 'Male', '1976-10-23'),
('Jackie', 'Chan', 'Male', '1954-04-07');

-- Insert test data into Movie
INSERT INTO Movie (movieName, MovieType, DistFee, NumCopies) VALUES
('Iron Man', 'Action', 200.00, 50),
('Black Widow', 'Action', 180.00, 40),
('Hunger Games', 'Drama', 150.00, 60),
('Thor', 'Action', 220.00, 45),
('The Grand Budapest Hotel', 'Comedy', 120.00, 35),
('Spider-Man', 'Action', 210.00, 50),
('Avengers: Endgame', 'Action', 250.00, 60),
('La La Land', 'Drama', 160.00, 40),
('Deadpool', 'Action', 230.00, 45), 
('Rumble in the Bronx', 'Action', 100.00, 30),
('Rush Hour', 'Action', 400.00, 25),
('Shanghai Knights', 'Action', 250.00, 40),
('Vanguard', 'Action', 220.00, 15);

-- Insert test data into Customer
INSERT INTO Customer (firstName, lastName, cusAddress, cusCity, cusState, cusZipCode, Email, AccountNumber, AccountCreationDate, CreditCard) VALUES
('John', 'Doe', '123 Elm St', 'Edmonton', 'AB', 'T6V 6W1', 'john.doe@example.com', 1001, GETDATE(), 1234567812345678),
('Jane', 'Smith', '456 Oak St', 'Kelowna', 'BC', 'T6V 6T1', 'jane.smith@example.com', 1002, GETDATE(), 2345678923456789),
('Alice', 'Johnson', '789 Walnut St', 'Calgary', 'AB', 'T6V 3W1', 'alice.johnson@example.com', 1003, GETDATE(), 3456789034567890),
('Bob', 'Brown', '321 Maple St', 'Victoria', 'BC', 'T6V 7O1', 'bob.brown@example.com', 1004, GETDATE(), 4567890145678901),
('Charlie', 'Parker', '567 Elmwood Ave', 'Victoria', 'BC', 'T6V 9U1', 'charlie.parker@example.com', 1005, GETDATE(), 5678901256789012),
('Diana', 'Prince', '123 Paradise Island', 'Edmonton', 'AB', 'T6V 7Y8', 'diana.prince@example.com', 1006, GETDATE(), 6789012367890123),
('Bruce', 'Wayne', '100 Gotham Lane', 'Gotham', 'AB', 'T6V 4E1', 'bruce.wayne@example.com', 1007, GETDATE(), 7890123478901234),
('Clark', 'Kent', '742 Evergreen Terrace', 'Smallville', 'BC', 'T6V G1S', 'clark.kent@example.com', 1008, GETDATE(), 8901234589012345),
('Natasha', 'Romanoff', '22 Black Widow St', 'Springfield', 'ON', 'T6V M1E', 'natasha.romanoff@example.com', 1009, GETDATE(), 9012345690123456);

-- Insert test data into Employee
INSERT INTO Employee (SSN, firstName, lastName, empAddress, empCity, empState, empZipCode, StartDate) VALUES
('123-45-6789', 'Emily', 'Blunt', '789 Pine St', 'Springfield', 'AB', 'T6V 8W1', '2015-06-01'),
('987-65-4321', 'Michael', 'Caine', '321 Birch St', 'Springfield', 'AB', 'T6V 6F1', '2010-01-15'),
('333-22-1111', 'Anna', 'Kendrick', '456 Cedar St', 'Edmonton', 'AB', 'T6V 3F1', '2020-07-01'),
('444-33-2222', 'Leonardo', 'DiCaprio', '123 Spruce St', 'Edmonton', 'AB', 'T6V 3D2', '2018-09-10');

-- Insert test data into UsernamePassword
INSERT INTO UsernamePassword (employeeID, Username, Password) VALUES
(1, 'admin', ENCRYPTBYPASSPHRASE('lemon', 'admin1')),
(2, 'michael', ENCRYPTBYPASSPHRASE('lemon', 'password123')),
(3, 'anna', ENCRYPTBYPASSPHRASE('lemon', 'anna123')),
(4, 'leo', ENCRYPTBYPASSPHRASE('lemon', 'leo123'));

-- Insert test data into PlacedOrder
INSERT INTO PlacedOrder (CheckoutTime, ReturnTime, customerID, movieID, employeeID) VALUES
(GETDATE(), NULL, 1, 1, 1),
(GETDATE(), NULL, 2, 2, 2),
(GETDATE(), NULL, 1, 5, 1),
(GETDATE(), NULL, 3, 6, 2),
(GETDATE(), NULL, 4, 7, 1),
(GETDATE(), NULL, 2, 8, 4),
(GETDATE(), NULL, 5, 1, 1), 
(GETDATE(), NULL, 6, 2, 2), 
(GETDATE(), NULL, 7, 4, 1), 
(GETDATE(), NULL, 8, 6, 4),
(GETDATE(), NULL, 9, 7, 1), 
(GETDATE(), NULL, 5, 9, 2), 
(GETDATE(), NULL, 6, 6, 3), 
(GETDATE(), NULL, 7, 7, 4); 

-- Insert test data into CustomerPhone
INSERT INTO CustomerPhone (customerID, PhoneType, Number) VALUES
(1, 'Mobile', '555-123-4567'),
(2, 'Home', '555-987-6543'),
(3, 'Mobile', '555-333-4444'),
(4, 'Home', '555-444-6666'),
(5, 'Mobile', '555-123-7777'),
(6, 'Home', '555-987-8888'),
(7, 'Mobile', '555-333-9999'),
(8, 'Home', '555-444-0000'),
(9, 'Mobile', '555-123-1111');

-- Insert test data into EmployeePhone
INSERT INTO EmployeePhone (employeeID, PhoneType, Number) VALUES
(1, 'Mobile', '555-112-2334'),
(2, 'Work', '555-223-3445'),
(3, 'Mobile', '555-335-7777'),
(4, 'Work', '555-447-8899');

-- Insert test data into ActorAppearedIn
INSERT INTO ActorAppearedIn (actorID, movieID) VALUES
(1, 1),
(2, 2),
(3, 4),
(4, 3),
(5, 6),
(6, 7),
(7, 8),
(8, 9),
(9, 10),
(9, 11),
(9, 12),
(9, 13);


-- Insert test data into MovieQueue
INSERT INTO MovieQueue (customerID, movieID, QueuePosition) VALUES
(1, 3, 1),
(1, 4, 2),
(1, 6, 3),
(2, 1, 1),
(2, 5, 2),
(3, 6, 1),
(4, 7, 2),
(4, 8, 3),
(4, 9, 4);


-- Insert test data into MovieRate
INSERT INTO MovieRate (Rate, MovieOrderID) VALUES
(5, 1),
(4, 2),
(5, 3),
(4, 4);

-- Insert test data into RateActor
INSERT INTO RateActor (actorID, orderID, actorRating) VALUES
(1, 1, 5),
(2, 2, 4),
(5, 3, 5),
(6, 4, 4);

