use project291;

-- Insert test data into Actor
INSERT INTO Actor (firstName, lastName, Gender, DateofBirth) VALUES 
('Robert', 'Downey Jr.', 'Male', '1965-04-04'),
('Scarlett', 'Johansson', 'Female', '1984-11-22'),
('Chris', 'Hemsworth', 'Male', '1983-08-11'),
('Jennifer', 'Lawrence', 'Female', '1990-08-15');

-- Insert test data into Movie
INSERT INTO Movie (movieName, MovieType, DistFee, NumCopies) VALUES
('Iron Man', 'Action', 200.00, 50),
('Black Widow', 'Action', 180.00, 40),
('Hunger Games', 'Drama', 150.00, 60),
('Thor', 'Action', 220.00, 45),
('The Grand Budapest Hotel', 'Comedy', 120.00, 35);

-- Insert test data into Customer
INSERT INTO Customer (firstName, lastName, cusAddress, cusCity, cusState, cusZipCode, Email, AccountNumber, AccountCreationDate, CreditCard) VALUES
('John', 'Doe', '123 Elm St', 'Springfield', 'IL', '62704', 'john.doe@example.com', 1001, GETDATE(), 1234567812345678),
('Jane', 'Smith', '456 Oak St', 'Springfield', 'IL', '62704', 'jane.smith@example.com', 1002, GETDATE(), 2345678923456789);

-- Insert test data into Employee
INSERT INTO Employee (SSN, firstName, lastName, empAddress, empCity, empState, empZipCode, StartDate) VALUES
('123-45-6789', 'Emily', 'Blunt', '789 Pine St', 'Springfield', 'IL', '62704', '2015-06-01'),
('987-65-4321', 'Michael', 'Caine', '321 Birch St', 'Springfield', 'IL', '62704', '2010-01-15');

-- Insert test data into UsernamePassword
INSERT INTO UsernamePassword (employeeID, Username, Password) VALUES
(1, 'admin', ENCRYPTBYPASSPHRASE('lemon', 'admin1')),
(2, 'michael', ENCRYPTBYPASSPHRASE('lemon', 'password123')); 

-- Insert test data into PlacedOrder
INSERT INTO PlacedOrder (CheckoutTime, ReturnTime, customerID, movieID, employeeID) VALUES
(GETDATE(), NULL, 1, 1, 1),
(GETDATE(), NULL, 2, 2, 2);

-- Insert test data into CustomerPhone
INSERT INTO CustomerPhone (customerID, PhoneType, Number) VALUES
(1, 'Mobile', '555-123-4567'),
(2, 'Home', '555-987-6543');

-- Insert test data into EmployeePhone
INSERT INTO EmployeePhone (employeeID, PhoneType, Number) VALUES
(1, 'Mobile', '555-112-2334'),
(2, 'Work', '555-223-3445');

-- Insert test data into ActorAppearedIn
INSERT INTO ActorAppearedIn (actorID, movieID) VALUES
(1, 1), -- Robert Downey Jr. in Iron Man
(2, 2), -- Scarlett Johansson in Black Widow
(3, 4), -- Chris Hemsworth in Thor
(4, 3); -- Jennifer Lawrence in Hunger Games

-- Insert test data into MovieQueue
INSERT INTO MovieQueue (customerID, movieID, QueuePosition) VALUES
(1, 3, 1),
(1, 4, 2),
(2, 1, 1);

-- Insert test data into MovieRate
INSERT INTO MovieRate (Rate, MovieOrderID) VALUES
(5, 1),
(4, 2);

-- Insert test data into RateActor
INSERT INTO RateActor (actorID, orderID, actorRating) VALUES
(1, 1, 5),
(2, 2, 4);
