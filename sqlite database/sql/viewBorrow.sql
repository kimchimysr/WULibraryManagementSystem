CREATE VIEW viewBorrowBook AS
SELECT
	br.borrowID,
	b.title,
	br.studentID,
	bw.firstName,
	bw.lastName,
	ls.loanStatusName,
	br.dateLoan,
	br.dateDue,
	br.dateReturned,
	br.overdueFine
FROM tblBorrow AS br,tblBook AS b,tblStudent AS bw,tblLoanStatus AS ls
WHERE br.bookID = b.bookID
AND br.studentID = bw.studentID
AND br.loanStatusID = ls.loanStatusID