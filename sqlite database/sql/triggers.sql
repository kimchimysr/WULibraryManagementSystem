DROP TRIGGER [IF EXISTS] log_borrow_after_update;
CREATE TRIGGER log_borrow_after_update
	AFTER UPDATE ON tblBorrow
	WHEN old.loanStatusID <> new.loanStatusID
	OR old.borrowID <> new.borrowID
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'UPDATE',
		'Status Changed',
		'BorrowID: ' || old.borrowID,
		'Book Loan',
		DATETIME('NOW')
	);
    DELETE FROM tblBook WHERE bookID NOT IN 
(SELECT bookID FROM tblBook ORDER BY bookID DESC LIMIT 100);
END;

DROP TRIGGER [IF EXISTS] log_borrow_after_insert;
CREATE TRIGGER log_borrow_after_insert
	AFTER INSERT ON tblBorrow
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'INSERT',
		'New Record',
		'BorrowID: ' || NEW.borrowID,
		'Book Loan',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

DROP TRIGGER [IF EXISTS] log_borrow_after_delete;
CREATE TRIGGER log_borrow_after_delete
	AFTER INSERT ON tblBorrow
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'DELETE',
		'Existed Record',
		'BorrowID: ' || OLD.borrowID,
		'Book Loan',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

CREATE TRIGGER log_user_after_delete
	AFTER DELETE ON tblUser
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'DELETE',
		'Existed Record',
		'UserID: ' || OLD.userID,
		'Users',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

CREATE TRIGGER log_user_after_update
	AFTER UPDATE ON tblUser
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'UPDATE',
		'Editing Record',
		'UserID: ' || OLD.userID,
		'Users',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

CREATE TRIGGER log_user_after_insert
	AFTER INSERT ON tblUser
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'INSERT',
		'New Record',
		'UserID: ' || OLD.userID,
		'Users',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

CREATE TRIGGER log_student_after_delete
	AFTER DELETE ON tblStudent
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'DELETE',
		'Existed Record',
		'StudentID: ' || OLD.studentID,
		'Students',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

CREATE TRIGGER log_student_after_update
	AFTER UPDATE ON tblStudent
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'UPDATE',
		'Editing Record',
		'StudentID: ' || OLD.studentID,
		'Students',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

CREATE TRIGGER log_student_after_insert
	AFTER INSERT ON tblStudent
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'INSERT',
		'New Record',
		'StudentID: ' || OLD.studentID,
		'Students',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

CREATE TRIGGER log_book_after_delete
	AFTER DELETE ON tblBook
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'DELETE',
		'Existed Record',
		'BookID: ' || OLD.bookID,
		'Books',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

CREATE TRIGGER log_book_after_update
	AFTER UPDATE ON tblBook
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'UPDATE',
		'Editing Record',
		'BookID: ' || OLD.bookID,
		'Books',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;

CREATE TRIGGER log_book_after_insert
	AFTER INSERT ON tblBook
BEGIN
	INSERT INTO tblLog(
		operation,
		detail,
		target,
		targetTable,
		timestamp
	)
VALUES
	(
		'INSERT',
		'New Record',
		'BookID: ' || OLD.bookID,
		'Books',
		DATETIME('NOW')
	);
DELETE FROM tblLog WHERE logID NOT IN 
	(SELECT logID FROM tblLog ORDER BY logID DESC LIMIT 100);
END;