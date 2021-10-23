USE DemoEntity
GO




-- Kiểm tra đăng nhập : 
CREATE PROCEDURE CheckLogin (@TeacherID INT, @Password NVARCHAR(50))
AS
BEGIN
	SELECT *
	FROM Login
	WHERE Login.TeacherID = @TeacherID AND Login.Password = @Password
END

-- Hiển thị thông tin giáo viên : 
CREATE PROCEDURE TeacherInformation (@TeacherID INT)
AS 
BEGIN 
	SELECT *
	FROM Teacher
END

-- Thay đổi thông tin giáo viên : 
CREATE PROCEDURE ChangeTeacherInformation (@TeacherID INT, @dateOfBirth DATE, @Phone INT, @Address NVARCHAR(100), @Gender NVARCHAR(50), @Email NVARCHAR(100))
AS
BEGIN 
	UPDATE Teacher 
	SET DateOfBirth = @dateOfBirth, Phone = @Phone, Address = @Address, Gender = @Gender, EMAIL = @Email
	WHERE TeacherID = @TeacherID
END

-- Hiển thị danh sách lớp học : 
CREATE PROCEDURE ShowClassInfomation (@TeachID INT) 
AS
BEGIN
		SELECT DISTINCT DK.StudentClass, Subject.SubjectID, Subject.SubjectName, DK.Quantity
		FROM Subject INNER JOIN 
								(
									SELECT DISTINCT Class.StudentClass, Class.Quantity, TeachClass.SubjectID
									FROM Class INNER JOIN TeachClass ON Class.StudentClass = TeachClass.Class
									WHERE TeachClass.TeacherID = @TeachID
								) AS DK 
			 ON Subject.SubjectID = DK.SubjectID
END

EXEC ShowClassInfomation @TeachID = 100001

-- Tìm kiếm lớp học 
CREATE PROCEDURE searchClass(@searchName NVARCHAR(50), @TeachID INT)
AS 
BEGIN 
	SELECT DISTINCT DK.StudentClass, Subject.SubjectID, Subject.SubjectName, DK.Quantity
		FROM Subject INNER JOIN 
								(
									SELECT DISTINCT Class.StudentClass, Class.Quantity, TeachClass.SubjectID
									FROM Class INNER JOIN TeachClass ON Class.StudentClass = TeachClass.Class
									WHERE TeachClass.TeacherID = @TeachID
								) AS DK 
			 ON Subject.SubjectID = DK.SubjectID
		WHERE DK.StudentClass LIKE '%'+@searchName+'%' OR Subject.SubjectID LIKE '%'+@searchName+'%' OR Subject.SubjectName LIKE '%'+@searchName+'%' OR CAST(DK.Quantity AS NVARCHAR(10)) LIKE '%'+@searchName+'%'
END

EXEC searchClass @searchName = '4', @TeachID = 100001

-- Hiển thị danh sách sinh viên : 
CREATE PROCEDURE showStudentList(@StudentClass NVARCHAR(10), @SubjectID NVARCHAR(100))
AS
BEGIN
	SELECT DISTINCT Student.StudentName, Student.StudentID, Student.Gender, Student.EMAIL, Point.Point
	FROM Student INNER JOIN Point ON Student.StudentID = Point.StudentID
	WHERE StudentClass = @StudentClass AND SubjectID = @SubjectID
END

EXEC showStudentList @StudentClass = '01CLC', @SubjectID = 'MH01'

-- Nhập điểm cho sinh viên : 
CREATE PROCEDURE inputStudentPoint (@StudentID INT, @Point FLOAT, @SubjectID NVARCHAR(50))
AS
BEGIN 
	UPDATE Point 
	SET Point.Point = @Point 
	WHERE Point.StudentID = @StudentID AND Point.SubjectID = @SubjectID
END

-- Kiểm tra đăng nhập của sinh viên :
CREATE PROCEDURE checkStudentLogin (@StudentID INT, @Password NVARCHAR(50))
AS
BEGIN 
	SELECT *
	FROM StudentAccount
	WHERE StudentID = @StudentID AND Password = @Password
END

EXEC checkStudentLogin @StudentId = 19110111, @password = '1'
-- Hiển thị điểm trung bình của 1 sinh viên : 
CREATE PROCEDURE AvgPointOfStudent (@StudentID INT)
AS
BEGIN 
	SELECT AVG(Point)
	FROM Point
	WHERE StudentID = @StudentID
END
EXEC AvgPointOfStudent @StudentID = 19110111

-- Hiển thị bảng điểm chi tiết của 1 sinh viên : 
CREATE PROCEDURE showInfoPointOfStudent (@StudentID INT)
AS
BEGIN 
	SELECT DISTINCT Point.SubjectID, Subject.SubjectName, Point.Point
	FROM Point INNER JOIN Subject ON Point.SubjectID = Subject.SubjectID
	WHERE StudentID = @StudentID
END

EXEC showInfoPointOfStudent 19110111

-- Hiển thị thông tin 1 sinh viên : 
CREATE PROCEDURE showStudentInfo (@StudentID INT)
AS
BEGIN 
	SELECT StudentName, StudentID, DateOfBirth, Gender, Address, Email, StudentClass
	FROM Student
	WHERE StudentID = @StudentID
END

--Cập nhật thông tin sinh viên : 
CREATE PROCEDURE updateStudentInfomation (@StudentID INT, @Gender NVARCHAR(50), @Address NVARCHAR(100), @Email NVARCHAR(100))
AS
BEGIN 
	UPDATE Student
	SET Gender = @Gender , Address = @Address, EMAIL = @Email
	WHERE StudentID = @StudentID
END

