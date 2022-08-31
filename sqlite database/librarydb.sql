CREATE TABLE tblBook (
	bookID INTEGER PRIMARY KEY AUTOINCREMENT,
	isbn TEXT,
	dewey TEXT,
	title TEXT,
	author TEXT,
	publisher TEXT,
	publishYear INTEGER,
	pages TEXT,
	other TEXT,
	qty INTEGER
	cateID INTEGER
	dateAdded TEXT,
	FOREIGN KEY (cateID) REFERENCES tblBookCategory(cateID)
);

CREATE TABLE tblBookCategory (
	cateID INTEGER PRIMARY KEY AUTOINCREMENT,
	cateName TEXT
);

CREATE TABLE tblUser (
	userID INTEGER PRIMARY KEY AUTOINCREMENT,
	firstName TEXT,
	lastName TEXT,
	gender TEXT,
	dob TEXT,
	addr TEXT,
	tel TEXT,
	email TEXT,
	dateAdded TEXT
);

CREATE TABLE tblRole (
	roleID INTEGER PRIMARY KEY AUTOINCREMENT,
	roleName TEXT
);

CREATE TABLE tblUserRole (
	userRoleID INTEGER PRIMARY KEY AUTOINCREMENT,
	userID INTEGER,
	roleID INTEGER,
	FOREIGN KEY (userID) REFERENCES tblUser(userID),
	FOREIGN KEY (roleID) REFERENCES tblRole(roleID)
);

CREATE TABLE tblBorrow (
	borrowID INTEGER,
	bookID INTEGER,
	studentID TEXT,
	userID INTEGER,
	dateLoan TEXT,
	dateDue	TEXT,
	dateReturned TEXT,
	overdueFine INTEGER,
	loanStatusID INTEGER,
	FOREIGN KEY (bookID) REFERENCES tblBook(bookID),
	FOREIGN KEY (studentID) REFERENCES tblBorrower(studentID),
	FOREIGN KEY (userID) REFERENCES tblUser(userID),
	FOREIGN KEY (loanStatusID) REFERENCES tblLoanStatus(loanStatusID)
);

CREATE TABLE tblBorrower (
	studentID TEXT,
	firstName TEXT,
	lastName TEXT,
	gender TEXT,
	year INTEGER,
	major TEXT,
	tel TEXT
);

CREATE TABLE tblLoanStatus (
	loanStatusID INTEGER PRIMARY KEY AUTOINCREMENT,
	loanStatusName TEXT
);