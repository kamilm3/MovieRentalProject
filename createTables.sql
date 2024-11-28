use project291;

DROP TABLE IF EXISTS UsernamePassword;
DROP TABLE IF EXISTS MovieQueue;
DROP TABLE IF EXISTS ActorAppearedIn;
DROP TABLE IF EXISTS ActorRating;
DROP TABLE IF EXISTS RateActor;
DROP TABLE IF EXISTS MovieRate;
DROP TABLE IF EXISTS EmployeePhone;
DROP TABLE IF EXISTS CustomerPhone;
DROP TABLE IF EXISTS PlacedOrder;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Movie;
DROP TABLE IF EXISTS Actor;


CREATE TABLE [Actor] (
  [actorID] int identity(1,1),
  [firstName] varchar(50) not null,       	 
  [lastName] varchar(50) not null,
  [Gender] nvarchar(6) not null CHECK ([Gender] IN ('Male','Female')),
  [DateofBirth] date not null,
  PRIMARY KEY ([actorID])
);

CREATE TABLE [Movie] (
  [movieID] int not null identity(1,1),
  [movieName] varchar(50) not null,
  [MovieType] nvarchar(8) not null CHECK ([MovieType] IN('Comedy','Drama','Action','Foreign')),
  [DistFee] decimal(6,2) not null,
  [NumCopies] int not null,
  PRIMARY KEY ([movieID])
);

CREATE TABLE [Customer] (
  [customerID] int identity(1,1),
  [firstName] varchar(50) not null,
  [lastName] varchar(50) not null,
  [cusAddress] varchar(100),
  [cusCity] varchar(50),
  [cusState] varchar(2),
  [cusZipCode] varchar(10),
  [Email] varchar(50) not null,
  [AccountNumber] int not null,
  [AccountCreationDate] date not null default current_timestamp,
  [CreditCard] bigint not null,
  PRIMARY KEY ([customerID])
);

CREATE TABLE [Employee] (
  [employeeID] int identity(1,1),
  [SSN] char(11) not null,
  [firstName] varchar(50) not null,
  [lastName] varchar(50) not null,
  [empAddress] varchar(100),
  [empCity] varchar(50),
  [empState] varchar(2),
  [empZipCode] varchar(10),
  [StartDate] date not null,
  PRIMARY KEY ([employeeID])
);

CREATE TABLE [UsernamePassword] (
  [employeeID] int not null FOREIGN KEY REFERENCES Employee(employeeID),
  [Username] varchar(15) not null,
  [Password] varbinary(MAX) not null,
  PRIMARY KEY ([employeeID])
);

CREATE TABLE [PlacedOrder] (
  [orderID] int identity(1,1),
  [CheckoutTime] datetime not null default(getdate()),  
  [ReturnTime] datetime,
  [customerID] int not null FOREIGN KEY REFERENCES Customer(customerID),
  [movieID] int not null FOREIGN KEY REFERENCES Movie(movieID),
  [employeeID] int not null FOREIGN KEY REFERENCES Employee(employeeID),
  PRIMARY KEY ([orderID])
);
 
CREATE TABLE [CustomerPhone] (
  [customerID] int FOREIGN KEY REFERENCES Customer(customerID),
  [PhoneType] varchar(15) not null,
  [Number] varchar(14) not null,
  PRIMARY KEY ([customerID], [Number])
);

CREATE TABLE [EmployeePhone] (
  [employeeID] int not null FOREIGN KEY REFERENCES Employee(employeeID),
  [PhoneType] varchar(15) not null,
  [Number] varchar(14) not null,
  PRIMARY KEY ([employeeID], [Number])
);

CREATE TABLE [MovieRate] (
  [Rate] int,
  [MovieOrderID] int not null FOREIGN KEY REFERENCES PlacedOrder(orderID),
  PRIMARY KEY ([MovieOrderID])
);

CREATE TABLE [RateActor] (
  [actorID] int not null FOREIGN KEY REFERENCES Actor(actorID),
  [orderID] int not null FOREIGN KEY REFERENCES PlacedOrder(orderID),
  [actorRating] int,
  PRIMARY KEY ([actorID], [orderID])
);

CREATE TABLE [ActorAppearedIn] (
  [actorID] int FOREIGN KEY REFERENCES Actor(actorID),
  [movieID] int FOREIGN KEY REFERENCES Movie(movieID),
 PRIMARY KEY ([actorID], [movieID])
);

CREATE TABLE [MovieQueue] (
  [customerID] int FOREIGN KEY REFERENCES Customer(customerID),
  [movieID] int FOREIGN KEY REFERENCES Movie(movieID),
  [QueuePosition] int
  PRIMARY KEY ([customerID], [movieID])
);
