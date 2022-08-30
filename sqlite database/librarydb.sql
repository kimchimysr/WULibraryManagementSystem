CREATE TABLE tblBook (
	bookID integer PRIMARY KEY AUTOINCREMENT,
	isbn text,
	dewey text,
	title text,
	author text,
	publisher text,
	publishYear numeric,
	pages text,
	other text,
	qty integer,
	cateID integer,
	dateAdded numeric,
	FOREIGN KEY (cateID) REFERENCES tblBookCategory(cateID)
);

CREATE TABLE tblBookCategory (
	cateID integer PRIMARY KEY AUTOINCREMENT,
	cateName text
);

CREATE TABLE tblUser (
	userID integer PRIMARY KEY AUTOINCREMENT,
	firstName text,
	lastName text,
	gender text,
	dob date,
	addr text,
	tel text,
	email text
	dateAdded numeric
);

CREATE TABLE tblRole (
	roleID integer PRIMARY KEY AUTOINCREMENT,
	roleName text
);

CREATE TABLE tblUserRole (
	userRoleID integer PRIMARY KEY AUTOINCREMENT,
	userID integer,
	roleID integer,
	FOREIGN KEY (userID) REFERENCES tblUser(userID),
	FOREIGN KEY (roleID) REFERENCES tblRole(roleID)
);

CREATE TABLE tblBorrow (
	borrowID integer PRIMARY KEY AUTOINCREMENT,
	bookID integer,
	studentID text,
	userID integer,
	dateLoan numeric,
	dateDue numeric,
	dateReturned numeric,
	overdueFine numeric,
	loanStatusID integer,
	FOREIGN KEY (bookID) REFERENCES tblBook(bookID),
	FOREIGN KEY (studentID) REFERENCES tblBorrower(studentID),
	FOREIGN KEY (userID) REFERENCES tblUser(userID),
	FOREIGN KEY (loanStatusID) REFERENCES tblLoanStatus(loanStatusID)
);

CREATE TABLE tblBorrower (
	studentID text,
	firstName text,
	lastName text,
	gender text,
	year integer,
	major text,
	tel text
);

CREATE TABLE tblLoanStatus (
	loanStatusID integer PRIMARY KEY AUTOINCREMENT,
	loanStatusName text
);