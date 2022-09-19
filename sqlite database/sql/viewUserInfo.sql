CREATE VIEW viewUserInfo AS
SELECT 
	u.userID,
	u.username,
	u.isActive,
	r.roleName,
	u.firstName,
	u.lastName,
	u.gender,
	u.dob,
	u.addr,
	u.tel,
	u.email,
	u.dateAdded
FROM tblUser AS u, tblRole AS r, tblUserRole AS ur
WHERE u.userID = ur.userID AND r.roleID = ur.roleID