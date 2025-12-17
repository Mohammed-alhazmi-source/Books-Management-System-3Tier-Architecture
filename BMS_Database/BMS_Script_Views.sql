CREATE VIEW People_View AS
SELECT 
	P.PersonID,
	CONCAT(P.FirstName, ' ', P.SecondName, ' ', ISNULL(P.ThirdName,''), ' ', P.LastName) AS FullName,
	CASE
		WHEN P.Gender = 0 THEN 'Male'
		WHEN P.Gender = 1 THEN 'Female'
		ELSE 'Unknow'
	END AS Gender,
	P.NationalNo,
	C.CountryName AS Nationality,
	P.DateOfBirth,
	P.Phone,
	P.Email
FROM People P
JOIN Countries C
ON P.Nationality = C.CountryID;
-----------------------------


CREATE VIEW Users_View AS
SELECT 
U.UserID, U.PersonID, 
CONCAT(P.FirstName, ' ', P.SecondName, ' ', ISNULL(P.ThirdName,''),' ', P.LastName) AS FullName,
U.UserName,
U.IsActive
FROM Users U
JOIN People P
ON U.PersonID = P.PersonID;

-------------------------------------

CREATE VIEW Authors_View AS
SELECT 
A.AuthorID, A.PersonID,
P.NationalNo, CONCAT(P.FirstName, ' ', P.SecondName, ' ', (ISNULL(P.ThirdName,'')),' ', P.LastName) AS FullName,
C.CountryName AS Nationality,
CASE 
	WHEN P.Gender = 0 THEN 'Male'
	WHEN P.Gender = 1 THEN 'Female'
	ELSE 'Unknow'
END AS Gender
FROM Authors A
JOIN People P
ON A.PersonID = P.PersonID
JOIN Countries C
ON P.Nationality = C.CountryID;

-------------------------------

CREATE VIEW Books_View AS
SELECT 
	B.BookID, 
	B.Title, 
	B.ISBN, 
	C.CategoryName, 
	B.PublisherDate,
	P.NationalNo,
	CONCAT(P.FirstName, ' ', P.SecondName, ' ', (ISNULL(P.ThirdName,'')), ' ', P.LastName) AS AuthorName
FROM Books B
JOIN Categories C
ON B.CategoryID = C.CategoryID
JOIN Books_Authors BA
ON B.BookID = BA.BookID
JOIN Authors A
ON A.AuthorID = BA.AuthorID
JOIN People P
ON A.PersonID = P.PersonID;

--------------------

CREATE VIEW Borrowing_View AS
SELECT 
	Bor.BorrowID, 
	B.BookID,
	B.Title AS BookName,
	Bor.BookCopyID,
	CONCAT(P.FirstName, ' ', P.SecondName, ' ', (ISNULL(P.ThirdName,'')),P.LastName) AS BorrowedName,
	Bor.BorrowingDate,
	Bor.DueDate,
	Bor.ActualReturnDate,
	Bor.IsActive
FROM Borrowing Bor
JOIN BookCopies BC
ON Bor.BookCopyID = BC.BookCopyID
JOIN Books B
ON BC.BookID = B.BookID
JOIN People P
ON Bor.PersonID = P.PersonID;
-------------------------------------

CREATE VIEW Reservations_View AS
SELECT 
	R.ReservationID,
	R.PersonID,
	CONCAT(P.FirstName, ' ', P.SecondName, ' ', (ISNULL(P.ThirdName,'')),P.LastName) AS FullName,
	B.Title AS BookName,
	R.BookCopyID,
	R.ReservationDate,
	R.ReleaseReservationDate,
	R.ReservationStatus
FROM Reservations R
JOIN People P
ON R.PersonID = P.PersonID
JOIN BookCopies BC
ON R.BookCopyID = BC.BookCopyID
JOIN Books B
ON BC.BookID = B.BookID;

----------------------------------------

CREATE VIEW Fines_View AS
SELECT 
	F.FineID,
	F.PersonID,
	CONCAT(P.FirstName, ' ', P.SecondName, ' ', (ISNULL(P.ThirdName,'')), P.LastName) AS FullName,
	F.BorrowID,
	B.Title AS BookName,
	Bor.BookCopyID,
	F.FineAmount
FROM Fines F
JOIN People P
ON F.PersonID = P.PersonID
JOIN Borrowing Bor
ON F.BorrowID = Bor.BorrowID
JOIN BookCopies BC
ON Bor.BookCopyID = BC.BookCopyID
JOIN Books B
ON BC.BookID = B.BookID;