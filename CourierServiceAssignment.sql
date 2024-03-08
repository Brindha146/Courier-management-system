-- Create User Table
CREATE TABLE Users(
    UserID INT PRIMARY KEY,
    Name VARCHAR(255),
    Email VARCHAR(255) UNIQUE,
    Password VARCHAR(255),
    ContactNumber VARCHAR(20),
    Address VARCHAR(255)
);

-- Insert sample data into User Table
INSERT INTO Users(UserID, Name, Email, Password, ContactNumber, Address)
VALUES 
(1, 'John Doe', 'john@example.com', 'password123', '1234567890', '123 Main St'),
(2, 'Jane Smith', 'jane@example.com', 'letmein', '9876543210', '456 Elm St'),
(3,'Alice Johnson', 'alice@example.com', 'password3', '5551234567', '789 Oak St'),
(4,'Bob Williams', 'bob@example.com', 'password4', '4449876543', '321 Pine St'),
(5,'Michael Brown', 'michael@example.com', 'password5', '2223334444', '567 Maple St'),
(6,'Emily Jones', 'emily@example.com', 'password6', '1115557777', '890 Cedar St'),
(7,'David Davis', 'david@example.com', 'password7', '7778889999', '234 Birch St'),
(8,'Jennifer Wilson', 'jennifer@example.com', 'password8', '6660001111', '678 Walnut St'),
(9,'Richard Martinez', 'richard@example.com', 'password9', '9990001111', '345 Cedar St'),
(10,'Mary Taylor', 'mary@example.com', 'password10', '1112223333', '901 Oak St');


-- Create CourierServices Table
CREATE TABLE CourierServices (
    ServiceID INT PRIMARY KEY,
    ServiceName VARCHAR(100),
    Cost INT
);

-- Insert sample data into CourierServices Table
INSERT INTO CourierServices (ServiceID, ServiceName, Cost)
VALUES 
    (1, 'Standard', 10.00),
    (2, 'Express', 20.00),
    (3, 'Priority Delivery', 30.00);

-- Create Courier Table
CREATE TABLE Courier (
    CourierID INT PRIMARY KEY,
    ServiceID INT,
    SenderName VARCHAR(255),
    SenderAddress VARCHAR(255),
    ReceiverName VARCHAR(255),
    ReceiverAddress VARCHAR(255),
    Weight INT,
    Status VARCHAR(50),
    TrackingNumber VARCHAR(20) UNIQUE,
    DeliveryDate DATE,
    FOREIGN KEY (ServiceID) REFERENCES CourierServices (ServiceID)
);

ALTER TABLE Courier
ADD UserID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID);

UPDATE Courier SET UserID=1 WHERE CourierID=1; 
UPDATE Courier SET UserID=2 WHERE CourierID=2; 
UPDATE Courier SET UserID=3 WHERE CourierID=3; 
UPDATE Courier SET UserID=4 WHERE CourierID=4; 
UPDATE Courier SET UserID=5 WHERE CourierID=5; 
UPDATE Courier SET UserID=6 WHERE CourierID=6; 
UPDATE Courier SET UserID=7 WHERE CourierID=7; 
UPDATE Courier SET UserID=8 WHERE CourierID=8; 
UPDATE Courier SET UserID=9 WHERE CourierID=9; 
UPDATE Courier SET UserID=10 WHERE CourierID=10; 

ALTER TABLE Courier
ADD EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID);

UPDATE Courier SET EmployeeID=1 where CourierID=1;
UPDATE Courier SET EmployeeID=2 where CourierID=2;
UPDATE Courier SET EmployeeID=3 where CourierID=3;
UPDATE Courier SET EmployeeID=4 where CourierID=4;
UPDATE Courier SET EmployeeID=5 where CourierID=5;
UPDATE Courier SET EmployeeID=6 where CourierID=6;
UPDATE Courier SET EmployeeID=7 where CourierID=7;
UPDATE Courier SET EmployeeID=8 where CourierID=8;
UPDATE Courier SET EmployeeID=9 where CourierID=9;
UPDATE Courier SET EmployeeID=10 where CourierID=10;

-- Insert sample data into Courier Table
INSERT INTO Courier (CourierID, ServiceID, SenderName, SenderAddress, ReceiverName, ReceiverAddress, Weight, Status, TrackingNumber, DeliveryDate)
VALUES 
(1, 1, 'John Doe', '123 Main St', 'Jane Smith', '456 Elm St', 2.5, 'In Transit', 'TN123456789', '2024-03-07'),
(2, 2, 'Alice Johnson', '789 Oak St', 'Bob Brown', '321 Maple St', 1.8, 'Delivered', 'TN987654321', '2024-03-04'),
(3, 3, 'Michael Brown', '567 Maple St', 'Emily Jones', '890 Cedar St', 21.9, 'Delivered', 'TN555666777', '2024-01-03'),
(4, 1, 'David Davis', '234 Birch St', 'Jennifer Wilson', '678 Walnut St', 44.2, 'In Transit', 'TN333444555', '2024-01-04'),
(5, 2, 'Richard Martinez', '345 Cedar St', 'Mary Taylor', '901 Oak St', 2.3, 'Delivered', 'TN888999000', '2024-01-05'),
(6, 3, 'John Doe', '123 Main St', 'Mary Taylor', '901 Oak St', 39.7, 'In Transit', 'TN222333444', '2024-01-06'),
(7, 1, 'Alice Johnson', '789 Oak St', 'Jennifer Wilson', '678 Walnut St', 3.5, 'Delivered', 'TN111222333', '2024-01-07'),
(8, 2, 'Bob Williams', '321 Pine St', 'Emily Jones', '890 Cedar St', 11.3, 'In Transit', 'TN777888999', '2024-01-08'),
(9, 3, 'Michael Brown', '567 Maple St', 'Richard Martinez', '345 Cedar St', 35.1, 'Delivered', 'TN444555666', '2024-01-09'),
(10, 2, 'David Davis', '234 Birch St', 'Alice Johnson', '789 Oak St', 4.5, 'In Transit', 'TN999000111', '2024-01-10');

-- Create Employee Table
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(255),
    Email VARCHAR(255) UNIQUE,
    ContactNumber VARCHAR(20),
    Role VARCHAR(50),
    Salary INT
);

ALTER TABLE Employee
ADD LocationID INT,
    FOREIGN KEY (LocationID) REFERENCES Location(LocationID);

UPDATE Employee SET LocationID=1 where EmployeeID=1;
UPDATE Employee SET LocationID=2 where EmployeeID=2;
UPDATE Employee SET LocationID=3 where EmployeeID=3;
UPDATE Employee SET LocationID=4 where EmployeeID=4;
UPDATE Employee SET LocationID=2 where EmployeeID=5;
UPDATE Employee SET LocationID=4 where EmployeeID=6;
UPDATE Employee SET LocationID=3 where EmployeeID=7;
UPDATE Employee SET LocationID=2 where EmployeeID=8;
UPDATE Employee SET LocationID=1 where EmployeeID=9;
UPDATE Employee SET LocationID=1 where EmployeeID=10;

-- Insert sample data into Employee Table
INSERT INTO Employee (EmployeeID, Name, Email, ContactNumber, Role, Salary)
VALUES 
(1, 'Michael Johnson', 'michael@example.com', '5551234567', 'Manager', 50000.00),
(2, 'Emily Davis', 'emily@example.com', '5559876543', 'Courier', 35000.00),
(3, 'Alice Johnson', 'alice.johnson@company.com', '5551234567', 'Supervisor', 55000.00),
(4, 'Bob Williams', 'bob.williams@company.com', '4449876543', 'Clerk', 45000.00),
(5, 'Michael Brown', 'michael.brown@company.com', '2223334444', 'Manager', 40000.00),
(6, 'Emily Jones', 'emily.jones@company.com', '1115557777', 'Executive', 40000.00),
(7, 'David Davis', 'david.davis@company.com', '7778889999', 'Clerk', 40000.00),
(8, 'Jennifer Wilson', 'jennifer.wilson@company.com', '6660001111', 'Courier', 40000.00),
(9, 'Richard Martinez', 'richard.martinez@company.com', '9990001111', 'Supervisor', 40000.00),
(10, 'Mary Taylor', 'mary.taylor@company.com', '1112223333', 'Courier', 40000.00);

-- Create Location Table
CREATE TABLE Location (
    LocationID INT PRIMARY KEY,
    LocationName VARCHAR(100),
    Address VARCHAR(255)
);

-- Insert sample data into Location Table
INSERT INTO Location (LocationID, LocationName, Address)
VALUES 
(1, 'Office', '123 Business St'),
(2, 'Warehouse', '789 Storage Ave'),
(3, 'Main Office', '176 Averse St'),
(4, 'Office B', '102 Elma St');

-- Create Payment Table
CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY,
    CourierID INT,
    LocationID INT,
    Amount DECIMAL(10, 2),
    PaymentDate DATE,
    FOREIGN KEY (CourierID) REFERENCES Courier(CourierID),
    FOREIGN KEY (LocationID) REFERENCES Location(LocationID)
);

ALTER TABLE Payment
ADD EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID);

UPDATE Payment SET EmployeeID=1 where PaymentID=1;
UPDATE Payment SET EmployeeID=2 where PaymentID=2;
UPDATE Payment SET EmployeeID=3 where PaymentID=3;
UPDATE Payment SET EmployeeID=4 where PaymentID=4;
UPDATE Payment SET EmployeeID=5 where PaymentID=5;
UPDATE Payment SET EmployeeID=6 where PaymentID=6;
UPDATE Payment SET EmployeeID=7 where PaymentID=7;
UPDATE Payment SET EmployeeID=8 where PaymentID=8;
UPDATE Payment SET EmployeeID=9 where PaymentID=9;
UPDATE Payment SET EmployeeID=10 where PaymentID=10;

-- Insert sample data into Payment Table
INSERT INTO Payment (PaymentID, CourierID, LocationID, Amount, PaymentDate)
VALUES 
(1, 1, 2, 12.50, '2024-03-05'),
(2, 2, 1, 15.75, '2024-03-04'),
(3, 3, 3, 35.00, '2024-01-13'),
(4, 4, 4, 45.00, '2024-01-14'),
(5, 5, 3, 55.00, '2024-01-15'),
(6, 6, 1, 65.00, '2024-01-16'),
(7, 7, 2, 75.00, '2024-01-17'),
(8, 8, 3, 85.00, '2024-01-18'),
(9, 9, 1, 95.00, '2024-01-19'),
(10, 10, 4, 105.00, '2024-01-20');

--Solve the following queries in the Schema that you have created above  

--1. List all customers:  
SELECT * FROM Users;

--2. List all orders for a specific customer: 
SELECT * FROM Courier WHERE SenderName='John Doe' or ReceiverName='John Doe';

--3. List all couriers:  
SELECT * FROM Courier;

--4. List all packages for a specific order(Courier):  
SELECT * FROM Courier Where CourierID = '2';

--5. List all deliveries for a specific courier:
SELECT * FROM Courier Where CourierID = '1';

--6. List all undelivered packages:  
SELECT * FROM Courier where Status!='Delivered';

--7. List all packages that are scheduled for delivery today: 
SELECT * FROM Courier where DeliveryDate = CONVERT(DATE, GETDATE());

--8. List all packages with a specific status:  
SELECT * FROM Courier where Status = 'Delivered';

--9. Calculate the total number of packages for each courier. 
select CourierID, COUNT(*) as TotalPackages from Courier group by CourierID;

--10. Find the average delivery time for each courier
SELECT c.CourierID, AVG(DATEDIFF(day,c.DeliveryDate,p.PaymentDate)) AS AvgDeliveryTime
FROM Courier c
JOIN Payment p ON c.CourierID = p.CourierID
GROUP BY c.CourierID;

--11. List all packages with a specific weight range: 
select * from Courier where Weight between 2 and 3;

--12. Retrieve employees whose names contain 'John'
select * from Employee where Name like '%John%';

--13. Retrieve all courier records with payments greater than $50.  
select * from Payment where Amount>50;



--Task 3: GroupBy, Aggregate Functions, Having, Order By, where  

--14. Find the total number of couriers handled by each employee. 
select EmployeeID, COUNT(*) as TotalCouriersHandled from Employee group by EmployeeID;

--15. Calculate the total revenue generated by each location  
select LocationID, SUM(Amount) as TotalRevenueGenerated from Payment group by LocationID;

--16. Find the total number of couriers delivered to each location.  
select LocationID, COUNT(*) as TotalCouriersDelivered from Location group by LocationID;

--17. Find the courier with the highest average delivery time:
SELECT TOP 1 c.CourierID, AVG(DATEDIFF(day, c.DeliveryDate, GETDATE())) AS AvgDeliveryTime
FROM Courier c
GROUP BY c.CourierID, c.SenderName, c.ReceiverName
ORDER BY AvgDeliveryTime DESC;

--18. Find Locations with Total Payments Less Than a Certain Amount  
select LocationID, SUM(Amount) as TotalPayments from Payment group by LocationID having SUM(Amount)<600;

--19. Calculate Total Payments per Location (same as 15) 
select LocationID, SUM(Amount) as TotalPayment from Payment group by LocationID;

--20. Retrieve couriers who have received payments totaling more than $1000 in a specific location (LocationID = X): 
select CourierID from Payment where LocationID = 1 group by CourierID having SUM(Amount) > 10;

--21. Retrieve couriers who have received payments totaling more than $1000 after a certain date (PaymentDate > 'YYYY-MM-DD'):
select CourierID from Payment where PaymentDate > '2024-01-20' group by CourierID having SUM(Amount) > 1000;

--22. Retrieve locations where the total amount received is more than $5000 before a certain date (PaymentDate < 'YYYY-MM-DD')  
select LocationID from Payment where PaymentDate < '2024-01-29' group by LocationID having SUM(Amount) > 5000;



--Task 4: Inner Join,Full Outer Join, Cross Join, Left Outer Join,Right Outer Join  

--23. Retrieve Payments with Courier Information  
select p.PaymentID, p.Amount
from Payment p
INNER JOIN Courier c on p.CourierID = c.CourierID;

--24. Retrieve Payments with Location Information  
select p.PaymentID, p.Amount, p.PaymentDate, l.LocationID, l.LocationName, l.Address
from Payment p
INNER JOIN Location l on p.LocationID = l.LocationID;

--25. Retrieve Payments with Courier and Location Information  
select p.PaymentID, p.Amount, p.PaymentDate, 
c.CourierID, c.SenderName,
l.LocationID, l.LocationName, l.Address
from Payment p
INNER JOIN Courier c on p.CourierID = c.CourierID
INNER JOIN Location l on p.LocationID = l.LocationID;

--26. List all payments with courier details 
SELECT p.PaymentID, p.Amount, p.PaymentDate, c.CourierID, c.SenderName, c.SenderAddress, c.ReceiverName, c.ReceiverAddress, c.Weight, c.Status, c.TrackingNumber, c.DeliveryDate
FROM Payment p
INNER JOIN Courier c ON p.CourierID = c.CourierID;

--27. Total payments received for each courier 
select c.CourierID, c.SenderName, c.ReceiverName, SUM(p.Amount) as TotalAmountReceived
from Payment p
RIGHT JOIN Courier c on p.CourierID = c.CourierID
group by c.CourierID, c.SenderName, c.ReceiverName;

--28. List payments made on a specific date  
select *
from Payment
where PaymentDate = '2024-02-29';

--29. Get Courier Information for Each Payment  
SELECT p.PaymentID, p.Amount, p.PaymentDate, c.*
FROM Payment p
INNER JOIN Courier c ON p.CourierID = c.CourierID;

--30. Get Payment Details with Location  
SELECT p.*, l.*
FROM Payment p
INNER JOIN Location l ON p.LocationID = l.LocationID;

--31. Calculating Total Payments for Each Courier  
SELECT c.CourierID, c.SenderName, c.ReceiverName, SUM(p.Amount) AS TotalPayments
FROM Courier c
LEFT JOIN Payment p ON c.CourierID = p.CourierID
GROUP BY c.CourierID, c.SenderName, c.ReceiverName;

--32. List Payments Within a Date Range 
SELECT *
FROM Payment
WHERE PaymentDate BETWEEN '2024-01-01' AND '2024-02-29';

--33. Retrieve a list of all users and their corresponding courier records, including cases where there are no matches on either side 
SELECT u.UserID,u.Name,c.CourierID,c.SenderName,c.ReceiverName
FROM Users u
FULL OUTER JOIN Courier c ON u.Name = c.SenderName OR u.Name = c.ReceiverName;

--34. Retrieve a list of all couriers and their corresponding services, including cases where there are no matches on either side 
SELECT c.*, cs.*
FROM Courier c
FULL OUTER JOIN CourierServices cs ON c.ServiceID = cs.ServiceID;

--35. Retrieve a list of all employees and their corresponding payments, including cases where there are no matches on either side 
SELECT e.EmployeeID, e.Name, p.Amount 
FROM Employee e 
FULL OUTER JOIN Payment p ON p.EmployeeID = e.EmployeeID;

--36. List all users and all courier services, showing all possible combinations.  
SELECT u.*, cs.*
FROM Users u
CROSS JOIN CourierServices cs;

--37. List all employees and all locations, showing all possible combinations:  
SELECT e.*, l.*
FROM Employee e
CROSS JOIN Location l;

--38. Retrieve a list of couriers and their corresponding sender information (if available) 
SELECT c.*, u.Name AS SenderName, u.Address AS SenderAddress
FROM Courier c
LEFT JOIN Users u ON c.SenderName = u.Name WHERE u.Name IS NOT NULL;

--39. Retrieve a list of couriers and their corresponding receiver information (if available):
SELECT c.*, u.Name AS ReceiverName, u.Address AS ReceiverAddress
FROM Courier c
LEFT JOIN Users u ON c.ReceiverName = u.Name WHERE u.Name IS NOT NULL;

--40. Retrieve a list of couriers along with the courier service details (if available): 
SELECT c.*, cs.*
FROM Courier c
LEFT JOIN CourierServices cs ON c.ServiceID = cs.ServiceID;

--41. Retrieve a list of employees and the number of couriers assigned to each employee: 
SELECT e.Name, Count(c.CourierID)
FROM Employee e 
JOIN Location l ON e.LocationID = l.LocationID 
JOIN Courier c ON c.ReceiverAddress = l.LocationName;

--42. Retrieve a list of locations and the total payment amount received at each location:  
SELECT l.LocationID, l.LocationName, SUM(p.Amount) AS TotalPaymentAmount
FROM Location l
LEFT JOIN Payment p ON l.LocationID = p.LocationID
GROUP BY l.LocationID, l.LocationName;

--43. Retrieve all couriers sent by the same sender (based on SenderName).  
SELECT c1.*, c2.*
FROM Courier c1
JOIN Courier c2 ON c1.SenderName = c2.SenderName AND c1.CourierID <> c2.CourierID;

--44. List all employees who share the same role.  
SELECT DISTINCT e1.*, e2.*
FROM Employee e1
JOIN Employee e2 ON e1.Role = e2.Role AND e1.EmployeeID <> e2.EmployeeID;

--45. Retrieve all payments made for couriers sent from the same location.  
SELECT p.*, c.*
FROM Payment p
JOIN Courier c ON p.CourierID = c.CourierID
JOIN Location l on c.SenderAddress = l.Address;

--46. Retrieve all couriers sent from the same location (based on SenderAddress).
SELECT c1.*, c2.*
FROM Courier c1
JOIN Courier c2 ON c1.SenderAddress = c2.SenderAddress AND c1.CourierID <> c2.CourierID;

--47. List employees and the number of couriers they have delivered:
SELECT e.EmployeeID, e.Name, COUNT(c.CourierID) AS NumOfDeliveries
FROM Employee e
LEFT JOIN Courier c ON e.EmployeeID = c.EmployeeID
GROUP BY e.EmployeeID, e.Name;

--48. Find couriers that were paid an amount greater than the cost of their respective courier services  
SELECT c.*, p.*
FROM Courier c
JOIN Payment p ON c.CourierID = p.CourierID
JOIN CourierServices cs ON c.ServiceID = cs.ServiceID
WHERE p.Amount > cs.Cost;



--Scope: Inner Queries, Non Equi Joins, Equi joins,Exist,Any,All  

--49. Find couriers that have a weight greater than the average weight of all couriers  
SELECT *
FROM Courier
WHERE Weight > (SELECT AVG(Weight) FROM Courier);

--50. Find the names of all employees who have a salary greater than the average salary: 
SELECT Name
FROM Employee
WHERE Salary > (SELECT AVG(Salary) FROM Employee);

--51. Find the total cost of all courier services where the cost is less than the maximum cost 
SELECT SUM(Cost) as TotalCost
FROM CourierServices
WHERE Cost < (SELECT MAX(Cost) FROM CourierServices);

--52. Find all couriers that have been paid for  
SELECT *
FROM Courier
WHERE CourierId IN (SELECT CourierId FROM Payment WHERE PaymentDate IS NOT NULL);

--53. Find the locations where the maximum payment amount was made 
SELECT * 
FROM Location
WHERE LocationID IN (SELECT LocationID FROM Payment WHERE Amount = (SELECT MAX(Amount) FROM Payment));

--54. Find all couriers whose weight is greater than the weight of all couriers sent by a specific sender (e.g., 'SenderName'): 
SELECT *
FROM Courier c
WHERE Weight > ALL (SELECT Weight FROM Courier  WHERE SenderName = 'John Doe')
