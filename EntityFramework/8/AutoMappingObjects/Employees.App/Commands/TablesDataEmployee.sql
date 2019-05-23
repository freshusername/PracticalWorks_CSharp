CREATE TABLE Employees
(
             Id   INT IDENTITY,
             Address NVARCHAR(50) NOT NULL,
             FirstName NVARCHAR(30) NOT NULL,
             LastName NVARCHAR(30) NOT NULL,
             Salary FLOAT NOT NULL,
             Birthday Date NOT NULL,
			 Addres NVARCHAR(50) NOT NULL,
             CONSTRAINT PK_TypeOfCars PRIMARY KEY(Id)
);

CREATE TABLE CarManufacturer
(
             Id        INT IDENTITY,
             Name      NVARCHAR(50) UNIQUE NOT NULL,
             TypeOfCarsId INT NOT NULL,
             CONSTRAINT PK_CarManufacturer PRIMARY KEY(Id),
             CONSTRAINT FK_CarManufacturer_TypeOfCars FOREIGN KEY(TypeOfCarsId) REFERENCES TypeOfCars(Id)
);

CREATE TABLE Cars
(
             Id     INT IDENTITY,
             Name   NVARCHAR(50) NOT NULL,
             Model  NVARCHAR(50)  NOT NULL,
             Transmission  NVARCHAR(50)  NOT NULL,
             GazType  NVARCHAR(50)  NOT NULL,
			 EngineLitres FLOAT NOT NULL,
             CarManufacturerId INT NOT NULL,
             CONSTRAINT PK_Cars PRIMARY KEY(Id),
             CONSTRAINT FK_Cars_CarManufacturer FOREIGN KEY(CarManufacturerId) REFERENCES CarManufacturer(Id)
);
CREATE TABLE Offers
(
             Id     INT IDENTITY,
             Owner NVARCHAR(50),
             Model  NVARCHAR(50)  NOT NULL,
             --DateOfOffer Date,
             GazType  NVARCHAR(50)  NOT NULL,
			 EngineLitres FLOAT NOT NULL,
             CarManufacturerId INT NOT NULL,
             CONSTRAINT PK_Cars PRIMARY KEY(Id),
             CONSTRAINT FK_Cars_CarManufacturer FOREIGN KEY(CarManufacturerId) REFERENCES CarManufacturer(Id)
);


INSERT INTO TypeOfCars
VALUES
(
       'Hatchback'
),
(
       'Sportcar'
),
(
       'Supercar'
),
(
       'Hypercar'
),
(
       'Electric'
);

INSERT INTO CarManufacturer
VALUES
(
       'Audi',
       1
),
(
       'BMW',
       2
),
(
       'Mercedes',
       3
),
(
       'Ford',
       4
),
(
       'VW',
       5
);

INSERT INTO Cars
VALUES
(
       'Audi',
       'A6',
	   'Parktronik',
	   'Diesel',
	   2.5,
       1
),
(
       'BMW',
       'X5',
	   'Automatic',
	   'Diesel',
	   3.0,
       2
),
(
       'Mercedes',
       'AMG',
	   'Mechanic',
	   'Gasoline',
	   5.9,
       3
),
(
       'VW',
       'Arteon',
	   'Automatic',
	   'Diesel',
	   3.5,
       5
),
(
       'Ford',
       'Mustang',
	   'Mechanic',
	   'Diesel',
	   6.0,
       4
);

