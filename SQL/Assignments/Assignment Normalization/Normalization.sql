Use AssignmentDB
 
--1NF
create table ClientRental_1NF (
    ClientNo VARCHAR(10),
    cName VARCHAR(50),
    propertyNo VARCHAR(10),
    pAddress VARCHAR(100),
    rentStart DATE,
    rentFinish DATE,
    rent DECIMAL(10, 2),
    ownerNo VARCHAR(10),
    oName VARCHAR(50),
    PRIMARY KEY (ClientNo, propertyNo, rentStart, rentFinish)
);
 
insert into ClientRental_1NF values
('CR76', 'Tony Shaw', 'PG4', '6 Lawrence St, Glasgow', '2000-07-01', '2001-08-31', 350, 'CO40', 'Tina Murphy'),
('CR76', 'Tony Shaw', 'PG4', '6 Lawrence St, Glasgow', '1999-09-01', '2000-01-10', 350, 'CO40', 'Tina Murphy'),
('C093', 'Aline Stewart', 'PG16', '5 Novar Dr, Glasgow', '2002-09-01', '2002-11-01', 450, 'CR76', 'John Kay'),
('C093', 'Tony Shaw', 'PG16', '5 Novar Dr, Glasgow', '2002-11-01', '2003-08-01', 450, 'CR76', 'John Kay'),
('C093', 'Tony Shaw', 'PG4', '6 Lawrence St, Glasgow', '2000-10-10', '2001-12-01', 370, 'CR76', 'John Kay');
 
select * from ClientRental_1NF;
 
--2NF
create table Client_2NF (
    ClientNo VARCHAR(10) PRIMARY KEY,
    cName VARCHAR(50)
);
 
insert into Client_2NF values
('CR76', 'Tony Shaw'),
('C093', 'Aline Stewart');
 
create table Property_2NF (
    propertyNo VARCHAR(10) PRIMARY KEY,
    pAddress VARCHAR(100),
    ownerNo VARCHAR(10)
);
 
insert into Property_2NF values
('PG4', '6 Lawrence St, Glasgow', 'CO40'),
('PG16', '5 Novar Dr, Glasgow', 'CR76');
 
create table Owner_2NF (
    ownerNo VARCHAR(10) PRIMARY KEY,
    oName VARCHAR(50)
);
 
insert into Owner_2NF values
('CO40', 'Tina Murphy'),
('CR76', 'John Kay');
 
select * from Client_2NF;
select * from Property_2NF;
select * from Owner_2NF;
 
--3NF
create table Rental_3NF (
    ClientNo VARCHAR(10),
    propertyNo VARCHAR(10),
    rentStart DATE,
    rentFinish DATE,
    rent DECIMAL(10, 2),
    PRIMARY KEY (ClientNo, propertyNo, rentStart, rentFinish),
    FOREIGN KEY (ClientNo) REFERENCES Client_2NF(ClientNo),
    FOREIGN KEY (propertyNo) REFERENCES Property_2NF(propertyNo)
);
 
insert into Rental_3NF values
('CR76', 'PG4', '2000-07-01', '2001-08-31', 350.00),
('CR76', 'PG4', '1999-09-01', '2000-01-10', 350.00),
('C093', 'PG16', '2002-09-01', '2002-11-01', 450.00),
('C093', 'PG16', '2002-11-01', '2003-08-01', 450.00),
('C093', 'PG4', '2000-10-10', '2001-12-01', 370.00);
 
SELECT * FROM Rental_3NF;
 
 