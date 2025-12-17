--CREATE DATABASE BMS;
--USE BMS;

CREATE TABLE Countries
(
	CountryID INT NOT NULL IDENTITY(1,1),
	CountryName NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_CountryID PRIMARY KEY CLUSTERED(CountryID)
);

CREATE TABLE People
(
	PersonID INT NOT NULL IDENTITY(1,1),
	FirstName NVARCHAR(20) NOT NULL,
	SecondName NVARCHAR(20) NOT NULL,
	ThirdName NVARCHAR(20),
	LastName NVARCHAR(20) NOT NULL,
	Gender BIT NOT NULL,
	NationalNo NVARCHAR(50) NOT NULL,
	Nationality INT NOT NULL,
	[Address] NVARCHAR(MAX) NOT NULL,
	Phone NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50),
	DateOfBirth SMALLDATETIME NOT NULL,
	ImagePath NVARCHAR(100),

	CONSTRAINT PK_PersonID PRIMARY KEY CLUSTERED(PersonID),
	CONSTRAINT FK_Nationality_People FOREIGN KEY(Nationality) REFERENCES Countries(CountryID)
);


CREATE TABLE Users
(
	UserID INT NOT NULL IDENTITY(1,1),
	UserName NVARCHAR(20) NOT NULL,
	[Password] NVARCHAR(20) NOT NULL,
	IsActive BIT NOT NULL,
	PersonID INT NOT NULL,

	CONSTRAINT PK_UserID PRIMARY KEY CLUSTERED(UserID),
	CONSTRAINT FK_PersonID_Users FOREIGN KEY(PersonID) REFERENCES People(PersonID)
);
ALTER TABLE Users ADD CONSTRAINT DF_User_Active DEFAULT 1 FOR IsActive;

CREATE TABLE Authors
(
	AuthorID INT NOT NULL IDENTITY(1,1),
	PersonID INT NOT NULL,
	CreatedByUserID INT NOT NULL,

	CONSTRAINT PK_AuthorID PRIMARY KEY CLUSTERED(AuthorID),
	CONSTRAINT FK_PersonID_Authors FOREIGN KEY(PersonID) REFERENCES People(PersonID),
	CONSTRAINT FK_CreatedByUserID_Authors FOREIGN KEY(CreatedByUserID) REFERENCES Users(UserID)
);

CREATE TABLE Categories
(
	CategoryID INT NOT NULL IDENTITY(1,1),
	CategoryName NVARCHAR(200) NOT NULL,
	IsActive BIT NOT NULL,
	CreatedByUserID INT NOT NULL,

	CONSTRAINT PK_CateryID PRIMARY KEY CLUSTERED(CategoryID),	
	CONSTRAINT FK_CreatedByUserID FOREIGN KEY(CreatedByUserID) REFERENCES Users(UserID)
);
ALTER TABLE Categories ADD CONSTRAINT DF_Category_Active DEFAULT 1 FOR IsActive;

CREATE TABLE Books
(
	BookID INT NOT NULL IDENTITY(1,1),
	Title NVARCHAR(200) NOT NULL,
	ISBN NVARCHAR(200) NOT NULL,
	CateryID INT NOT NULL,
	AdditionalDetials NVARCHAR(MAX),
	PublisherDate SMALLDATETIME NOT NULL,
	ImagePath NVARCHAR(300),
	CreatedByUserID INT NOT NULL,

	CONSTRAINT PK_BookID PRIMARY KEY CLUSTERED(BookID),
	CONSTRAINT FK_CateryID_Books FOREIGN KEY(CateryID) REFERENCES Categories(CategoryID),
	CONSTRAINT FK_CreatedByUserID_Books FOREIGN KEY(CreatedByUserID) REFERENCES Users(UserID)
);
ALTER TABLE Books ADD CONSTRAINT DF_PublisherDate DEFAULT GETDATE() FOR PublisherDate;

CREATE TABLE BookCopies
(
	BookCopyID INT NOT NULL IDENTITY(1,1),
	BookID INT NOT NULL,
	BookCopyName NVARCHAR(50) NOT NULL,
	IsActive BIT NOT NULL,

	CONSTRAINT PK_BookCopyID PRIMARY KEY CLUSTERED(BookCopyID),
	CONSTRAINT FK_BookID_BookCopies FOREIGN KEY(BookID) REFERENCES Books(BookID)
);
ALTER TABLE BookCopies ADD CONSTRAINT DF_BookCopy_Active DEFAULT 1 FOR IsActive;
--ALTER TABLE BookCopies ADD BookCopyName NVARCHAR(50) NOT NULL;
CREATE TABLE Books_Authors
(
	BAID INT NOT NULL IDENTITY(1,1),
	AuthorID INT NOT NULL,
	BookID INT NOT NULL,
	CreatedDate SMALLDATETIME NOT NULL,

	CONSTRAINT PK_BAID PRIMARY KEY CLUSTERED(BAID),
	CONSTRAINT FK_AuthorID_Books_Authors FOREIGN KEY(AuthorID) REFERENCES Authors(AuthorID),
	CONSTRAINT FK_BookID_Books_Authors FOREIGN KEY(BookID) REFERENCES Books(BookID)
);
ALTER TABLE Books_Authors ADD CONSTRAINT DF_CreatedDate DEFAULT GETDATE() FOR CreatedDate;

CREATE TABLE Reservations
(
	ReservationID INT NOT NULL IDENTITY(1,1),
	PersonID INT NOT NULL,
	BookCopyID INT NOT NULL,
	ReservationDate SMALLDATETIME NOT NULL,
	CreatedByUserID INT NOT NULL,
	ReservationStatus BIT NOT NULL,
	ReleaseReservationDate SMALLDATETIME,
	ReleasedByUserID INT,

	CONSTRAINT PK_ReservationID PRIMARY KEY CLUSTERED(ReservationID),
	CONSTRAINT FK_PersonID_Reservations FOREIGN KEY(PersonID) REFERENCES People(PersonID),
	CONSTRAINT FK_BookCopyID_Reservations FOREIGN KEY(BookCopyID) REFERENCES BookCopies(BookCopyID),
	CONSTRAINT FK_CreatedByUserID_Reservations FOREIGN KEY(CreatedByUserID) REFERENCES Users(UserID),
	CONSTRAINT FK_ReleasedByUserID_Reservations FOREIGN KEY(ReleasedByUserID) REFERENCES Users(UserID)
);
ALTER TABLE Reservations ADD CONSTRAINT DF_ReservationStatus DEFAULT 0 FOR ReservationStatus;
ALTER TABLE Reservations ADD CONSTRAINT DF_ReservationDate DEFAULT GETDATE() FOR ReservationDate;

CREATE TABLE Settings
(
	SettingID INT NOT NULL IDENTITY(1,1),
	DefualtDaysToBorrow INT NOT NULL,
	DefualtPriecPreDay DECIMAL NOT NULL,

	CONSTRAINT PK_SettingID PRIMARY KEY CLUSTERED(SettingID)
);
ALTER TABLE Settings ADD CONSTRAINT DF_DefualtDaysToBorrow DEFAULT 3 FOR DefualtDaysToBorrow;
ALTER TABLE Settings ADD CONSTRAINT DF_DefualtPriecPreDay DEFAULT 100 FOR DefualtPriecPreDay;


CREATE TABLE Borrowing
(
	BorrowID INT NOT NULL IDENTITY(1,1),
	BookCopyID INT NOT NULL,
	PersonID INT NOT NULL,
	BorrowingDate SMALLDATETIME NOT NULL,
	CreatedByUserID INT NOT NULL,
	DueDate SMALLDATETIME NOT NULL,
	ActualReturnDate SMALLDATETIME,
	IsActive BIT NOT NULL,
	ReleasedByUserID INT,

	CONSTRAINT PK_BorrowID PRIMARY KEY CLUSTERED(BorrowID),
	CONSTRAINT FK_BookCopyID_Borrowing FOREIGN KEY(BookCopyID) REFERENCES BookCopies(BookCopyID),
	CONSTRAINT FK_PersonID_Borrowing FOREIGN KEY(PersonID) REFERENCES People(PersonID),
	CONSTRAINT FK_CreatedByUserID_Borrowing FOREIGN KEY(CreatedByUserID) REFERENCES Users(UserID),
	CONSTRAINT FK_ReleasedByUserID_Borrowing FOREIGN KEY(ReleasedByUserID) REFERENCES Users(UserID)
);
ALTER TABLE Borrowing ADD CONSTRAINT DF_BorrowingDate DEFAULT GETDATE() FOR BorrowingDate;
ALTER TABLE Borrowing ADD CONSTRAINT DF_Borrow_Active DEFAULT 0 FOR IsActive;


CREATE TABLE Fines
(
	FineID INT NOT NULL IDENTITY(1,1),
	PersonID INT NOT NULL,
	BorrowID INT NOT NULL,
	FineAmount DECIMAL NOT NULL,
	CreatedByUserID INT NOT NULL,

	CONSTRAINT PK_FineID PRIMARY KEY CLUSTERED(FineID),
	CONSTRAINT FK_PersonID_Fines FOREIGN KEY(PersonID) REFERENCES People(PersonID),
	CONSTRAINT FK_CreatedByUserID_Fines FOREIGN KEY(CreatedByUserID) REFERENCES Users(UserID),
	CONSTRAINT FK_BorrowID_Fines FOREIGN KEY(BorrowID) REFERENCES Borrowing(BorrowID)
);


------------- Insert Countries
INSERT Countries (CountryName) VALUES (N'Afghanistan')
INSERT Countries (CountryName) VALUES (N'Albania')
INSERT Countries (CountryName) VALUES (N'Algeria')
INSERT Countries (CountryName) VALUES (N'Andorra')
INSERT Countries (CountryName) VALUES (N'Anla')
INSERT Countries (CountryName) VALUES (N'Antigua and Barbuda')
INSERT Countries (CountryName) VALUES (N'Argentina')
INSERT Countries (CountryName) VALUES (N'Armenia')
INSERT Countries (CountryName) VALUES (N'Austria')
INSERT Countries (CountryName) VALUES (N'Azerbaijan')
INSERT Countries (CountryName) VALUES (N'Bahrain')
INSERT Countries (CountryName) VALUES (N'Bangladesh')
INSERT Countries (CountryName) VALUES (N'Barbados')
INSERT Countries (CountryName) VALUES (N'Belarus')
INSERT Countries (CountryName) VALUES (N'Belgium')
INSERT Countries (CountryName) VALUES (N'Belize')
INSERT Countries (CountryName) VALUES (N'Benin')
INSERT Countries (CountryName) VALUES (N'Bhutan')
INSERT Countries (CountryName) VALUES (N'Bolivia')
INSERT Countries (CountryName) VALUES (N'Bosnia and Herzevina')
INSERT Countries (CountryName) VALUES (N'Botswana')
INSERT Countries (CountryName) VALUES (N'Brazil')
INSERT Countries (CountryName) VALUES (N'Brunei')
INSERT Countries (CountryName) VALUES (N'Bulgaria')
INSERT Countries (CountryName) VALUES (N'Burkina Faso')
INSERT Countries (CountryName) VALUES (N'Burundi')
INSERT Countries (CountryName) VALUES (N'Cabo Verde')
INSERT Countries (CountryName) VALUES (N'Cambodia')
INSERT Countries (CountryName) VALUES (N'Cameroon')
INSERT Countries (CountryName) VALUES (N'Canada')
INSERT Countries (CountryName) VALUES (N'Central African Republic')
INSERT Countries (CountryName) VALUES (N'Chad')
INSERT Countries (CountryName) VALUES (N'Channel Islands')
INSERT Countries (CountryName) VALUES (N'Chile')
INSERT Countries (CountryName) VALUES (N'China')
INSERT Countries (CountryName) VALUES (N'Colombia')
INSERT Countries (CountryName) VALUES (N'Comoros')
INSERT Countries (CountryName) VALUES (N'Con')
INSERT Countries (CountryName) VALUES (N'Costa Rica')
INSERT Countries (CountryName) VALUES (N'Côte d''Ivoire')
INSERT Countries (CountryName) VALUES (N'Croatia')
INSERT Countries (CountryName) VALUES (N'Cuba')
INSERT Countries (CountryName) VALUES (N'Cyprus')
INSERT Countries (CountryName) VALUES (N'Czech Republic')
INSERT Countries (CountryName) VALUES (N'Denmark')
INSERT Countries (CountryName) VALUES (N'Djibouti')
INSERT Countries (CountryName) VALUES (N'Dominica')
INSERT Countries (CountryName) VALUES (N'Dominican Republic')
INSERT Countries (CountryName) VALUES (N'DR Con')
INSERT Countries (CountryName) VALUES (N'Ecuador')
INSERT Countries (CountryName) VALUES (N'Egypt')
INSERT Countries (CountryName) VALUES (N'El Salvador')
INSERT Countries (CountryName) VALUES (N'Equatorial Guinea')
INSERT Countries (CountryName) VALUES (N'Eritrea')
INSERT Countries (CountryName) VALUES (N'Estonia')
INSERT Countries (CountryName) VALUES (N'Eswatini')
INSERT Countries (CountryName) VALUES (N'Ethiopia')
INSERT Countries (CountryName) VALUES (N'Faeroe Islands')
INSERT Countries (CountryName) VALUES (N'Finland')
INSERT Countries (CountryName) VALUES (N'France')
INSERT Countries (CountryName) VALUES (N'French Guiana')
INSERT Countries (CountryName) VALUES (N'Gabon')
INSERT Countries (CountryName) VALUES (N'Gambia')
INSERT Countries (CountryName) VALUES (N'Georgia')
INSERT Countries (CountryName) VALUES (N'Germany')
INSERT Countries (CountryName) VALUES (N'Ghana')
INSERT Countries (CountryName) VALUES (N'Gibraltar')
INSERT Countries (CountryName) VALUES (N'Greece')
INSERT Countries (CountryName) VALUES (N'Grenada')
INSERT Countries (CountryName) VALUES (N'Guatemala')
INSERT Countries (CountryName) VALUES (N'Guinea')
INSERT Countries (CountryName) VALUES (N'Guinea-Bissau')
INSERT Countries (CountryName) VALUES (N'Guyana')
INSERT Countries (CountryName) VALUES (N'Haiti')
INSERT Countries (CountryName) VALUES (N'Holy See')
INSERT Countries (CountryName) VALUES (N'Honduras')
INSERT Countries (CountryName) VALUES (N'Hong Kong')
INSERT Countries (CountryName) VALUES (N'Hungary')
INSERT Countries (CountryName) VALUES (N'Iceland')
INSERT Countries (CountryName) VALUES (N'India')
INSERT Countries (CountryName) VALUES (N'Indonesia')
INSERT Countries (CountryName) VALUES (N'Iran')
INSERT Countries (CountryName) VALUES (N'Iraq')
INSERT Countries (CountryName) VALUES (N'Ireland')
INSERT Countries (CountryName) VALUES (N'Isle of Man')
INSERT Countries (CountryName) VALUES (N'Israel')
INSERT Countries (CountryName) VALUES (N'Italy')
INSERT Countries (CountryName) VALUES (N'Jamaica')
INSERT Countries (CountryName) VALUES (N'Japan')
INSERT Countries (CountryName) VALUES (N'Jordan')
INSERT Countries (CountryName) VALUES (N'Kazakhstan')
INSERT Countries (CountryName) VALUES (N'Kenya')
INSERT Countries (CountryName) VALUES (N'Kuwait')
INSERT Countries (CountryName) VALUES (N'Kyrgyzstan')
INSERT Countries (CountryName) VALUES (N'Laos')
INSERT Countries (CountryName) VALUES (N'Latvia')
INSERT Countries (CountryName) VALUES (N'Lebanon')
INSERT Countries (CountryName) VALUES (N'Lesotho')
INSERT Countries (CountryName) VALUES (N'Liberia')
INSERT Countries (CountryName) VALUES ( N'Libya')
INSERT Countries (CountryName) VALUES ( N'Liechtenstein')
INSERT Countries (CountryName) VALUES ( N'Lithuania')
INSERT Countries (CountryName) VALUES ( N'Luxembourg')
INSERT Countries (CountryName) VALUES ( N'Macao')
INSERT Countries (CountryName) VALUES ( N'Madagascar')
INSERT Countries (CountryName) VALUES ( N'Malawi')
INSERT Countries (CountryName) VALUES ( N'Malaysia')
INSERT Countries (CountryName) VALUES ( N'Maldives')
INSERT Countries (CountryName) VALUES ( N'Mali')
INSERT Countries (CountryName) VALUES ( N'Malta')
INSERT Countries (CountryName) VALUES ( N'Mauritania')
INSERT Countries (CountryName) VALUES ( N'Mauritius')
INSERT Countries (CountryName) VALUES ( N'Mayotte')
INSERT Countries (CountryName) VALUES ( N'Mexico')
INSERT Countries (CountryName) VALUES ( N'Moldova')
INSERT Countries (CountryName) VALUES ( N'Monaco')
INSERT Countries (CountryName) VALUES ( N'Monlia')
INSERT Countries (CountryName) VALUES ( N'Montenegro')
INSERT Countries (CountryName) VALUES ( N'Morocco')
INSERT Countries (CountryName) VALUES ( N'Mozambique')
INSERT Countries (CountryName) VALUES ( N'Myanmar')
INSERT Countries (CountryName) VALUES ( N'Namibia')
INSERT Countries (CountryName) VALUES ( N'Nepal')
INSERT Countries (CountryName) VALUES ( N'Netherlands')
INSERT Countries (CountryName) VALUES ( N'Nicaragua')
INSERT Countries (CountryName) VALUES ( N'Niger')
INSERT Countries (CountryName) VALUES ( N'Nigeria')
INSERT Countries (CountryName) VALUES ( N'North Korea')
INSERT Countries (CountryName) VALUES ( N'North Macedonia')
INSERT Countries (CountryName) VALUES ( N'Norway')
INSERT Countries (CountryName) VALUES ( N'Oman')
INSERT Countries (CountryName) VALUES ( N'Pakistan')
INSERT Countries (CountryName) VALUES ( N'Panama')
INSERT Countries (CountryName) VALUES ( N'Paraguay')
INSERT Countries (CountryName) VALUES ( N'Peru')
INSERT Countries (CountryName) VALUES ( N'Philippines')
INSERT Countries (CountryName) VALUES ( N'Poland')
INSERT Countries (CountryName) VALUES ( N'Portugal')
INSERT Countries (CountryName) VALUES ( N'Qatar')
INSERT Countries (CountryName) VALUES ( N'Réunion')
INSERT Countries (CountryName) VALUES ( N'Romania')
INSERT Countries (CountryName) VALUES ( N'Russia')
INSERT Countries (CountryName) VALUES ( N'Rwanda')
INSERT Countries (CountryName) VALUES ( N'Saint Helena')
INSERT Countries (CountryName) VALUES ( N'Saint Kitts and Nevis')
INSERT Countries (CountryName) VALUES ( N'Saint Lucia')
INSERT Countries (CountryName) VALUES ( N'Saint Vincent and the Grenadines')
INSERT Countries (CountryName) VALUES ( N'San Marino')
INSERT Countries (CountryName) VALUES ( N'Sao Tome & Principe')
INSERT Countries (CountryName) VALUES ( N'Saudi Arabia')
INSERT Countries (CountryName) VALUES ( N'Senegal')
INSERT Countries (CountryName) VALUES ( N'Serbia')
INSERT Countries (CountryName) VALUES ( N'Seychelles')
INSERT Countries (CountryName) VALUES ( N'Sierra Leone')
INSERT Countries (CountryName) VALUES ( N'Singapore')
INSERT Countries (CountryName) VALUES ( N'Slovakia')
INSERT Countries (CountryName) VALUES ( N'Slovenia')
INSERT Countries (CountryName) VALUES ( N'Somalia')
INSERT Countries (CountryName) VALUES ( N'South Africa')
INSERT Countries (CountryName) VALUES ( N'South Korea')
INSERT Countries (CountryName) VALUES ( N'South Sudan')
INSERT Countries (CountryName) VALUES ( N'Spain')
INSERT Countries (CountryName) VALUES ( N'Sri Lanka')
INSERT Countries (CountryName) VALUES ( N'State of Palestine')
INSERT Countries (CountryName) VALUES ( N'Sudan')
INSERT Countries (CountryName) VALUES ( N'Suriname')
INSERT Countries (CountryName) VALUES ( N'Sweden')
INSERT Countries (CountryName) VALUES ( N'Switzerland')
INSERT Countries (CountryName) VALUES ( N'Syria')
INSERT Countries (CountryName) VALUES ( N'Taiwan')
INSERT Countries (CountryName) VALUES ( N'Tajikistan')
INSERT Countries (CountryName) VALUES ( N'Tanzania')
INSERT Countries (CountryName) VALUES ( N'Thailand')
INSERT Countries (CountryName) VALUES ( N'The Bahamas')
INSERT Countries (CountryName) VALUES ( N'Timor-Leste')
INSERT Countries (CountryName) VALUES ( N'To')
INSERT Countries (CountryName) VALUES ( N'Trinidad and Toba')
INSERT Countries (CountryName) VALUES ( N'Tunisia')
INSERT Countries (CountryName) VALUES ( N'Turkey')
INSERT Countries (CountryName) VALUES ( N'Turkmenistan')
INSERT Countries (CountryName) VALUES ( N'Uganda')
INSERT Countries (CountryName) VALUES ( N'Ukraine')
INSERT Countries (CountryName) VALUES ( N'United Arab Emirates')
INSERT Countries (CountryName) VALUES ( N'United Kingdom')
INSERT Countries (CountryName) VALUES ( N'United States')
INSERT Countries (CountryName) VALUES ( N'Uruguay')
INSERT Countries (CountryName) VALUES ( N'Uzbekistan')
INSERT Countries (CountryName) VALUES ( N'Venezuela')
INSERT Countries (CountryName) VALUES ( N'Vietnam')
INSERT Countries (CountryName) VALUES ( N'Western Sahara')
INSERT Countries (CountryName) VALUES ( N'Yemen')
INSERT Countries (CountryName) VALUES ( N'Zambia')
INSERT Countries (CountryName) VALUES ( N'Zimbabwe')