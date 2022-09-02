CREATE TABLE tblBook (
	bookID INTEGER PRIMARY KEY,
	isbn TEXT,
	dewey TEXT,
	title TEXT,
	author TEXT,
	publisher TEXT,
	publishYear TEXT,
	pages TEXT,
	other TEXT,
	qty INTEGER,
	cateID INTEGER,
	dateAdded TEXT,
	FOREIGN KEY (cateID) REFERENCES tblBookCategory(cateID)
);

CREATE TABLE tblBookCategory (
	cateID INTEGER PRIMARY KEY,
	cateName TEXT
);

CREATE TABLE tblUser (
	userID INTEGER PRIMARY KEY,
	username TEXT,
	password TEXT,
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
	roleID INTEGER PRIMARY KEY,
	roleName TEXT
);

CREATE TABLE tblUserRole (
	userRoleID INTEGER PRIMARY KEY,
	userID INTEGER,
	roleID INTEGER,
	FOREIGN KEY (userID) REFERENCES tblUser(userID),
	FOREIGN KEY (roleID) REFERENCES tblRole(roleID)
);

CREATE TABLE tblBorrow (
	borrowID INTEGER PRIMARY KEY,
	bookID INTEGER,
	studentID TEXT,
	userID INTEGER,
	dateLoan TEXT,
	dateDue TEXT,
	dateReturned TEXT,
	overdueFine TEXT,
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
	loanStatusID INTEGER PRIMARY KEY,
	loanStatusName TEXT
);