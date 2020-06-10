USE uni;

CREATE TABLE students
(
studentId INT PRIMARY KEY AUTO_INCREMENT,
studentName VARCHAR(20) NOT NULL,
studentSurname VARCHAR(20) NOT NULL,
studentCourse INT NOT NULL
);

DROP TABLE students;

INSERT INTO students(studentName,studentSurname,studentCourse)
VALUES("Janis","Garais",1),
("Janis","Priedens",1),("Inara","Cauna",2),("Kristine","Lapina",2),
("Kristaps","Liepins",3),("Janis","Natre",3);

SELECT  studentName,StudentSurname,StudentCourse
FROM students;

SELECT StudentName,StudentSurname
FROM students
WHERE studentName = "Janis";

SELECT studentName
FROM students
WHERE studentCourse = 1 OR 2;



