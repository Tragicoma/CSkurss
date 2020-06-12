CREATE TABLE departments
(
departmentId INT PRIMARY KEY AUTO_INCREMENT,
departmentName VARCHAR(30) NOT NULL
);

INSERT INTO departments(departmentName)
VALUES("Engineering"),
("HR"),
("Marketing");

ALTER TABLE employees
ADD departmentID INT NOT NULL;

ALTER TABLE employees
ADD FOREIGN KEY (departmentID) REFERENCES departments(departmentID);

SELECT * FROM employees;

SELECT employees.employeeName, employees.employeeLastName, 
departments.departmentName
FROM employees, departments
WHERE employees.departmentID = departments.departmentID;

CREATE TABLE jobs(
jobID INT PRIMARY KEY AUTO_INCREMENT,
jobTitle VARCHAR(100) NOT NULL,
minSalary INT NOT NULL,
maxSalary INT NOT NULL
); 

INSERT INTO jobs(jobTitle,minSalary,maxSalary)
VALUES ("Software engineer", 700,2500),("Talent Acquisition Specialist",600,1500),
("Marketing Guru",700,2000);

ALTER TABLE employees
ADD jobID INT NOT NULL;

ALTER TABLE employees
ADD FOREIGN KEY (jobID)
REFERENCES jobs(jobID);

ALTER TABLE employees
ADD salary  INT NOT NULL;

DROP TABLE employees;
DROP TABLE departments;
DROP TABLE salary;
DROP TABLE jobs;

SELECT employees.employeeName, employees.employeeLastName, 
jobs.jobTitle
FROM employees,jobs
WHERE employees.jobID = jobs.jobID;

SELECT AVG(salary)
FROM employees;



SELECT employees.employeeName,employees.employeeLastName,jobs.jobTitle
FROM employees,jobs
WHERE employees.jobID = 1 = jobs.jobID;
