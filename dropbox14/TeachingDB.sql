USE master;

IF DB_ID(N'TeachingDB') IS NOT NULL DROP DATABASE TeachingDB;
CREATE DATABASE TeachingDB;
GO

USE TeachingDB;
GO
CREATE TABLE instructor
(
		instructorId					INT										NOT NULL				IDENTITY,
		instructorName			NVARCHAR(100)			NOT NULL,
		instructorOffice			NCHAR(7)						NOT NULL,
		CONSTRAINT pk_instructor		PRIMARY KEY (instructorId)
);
CREATE TABLE course
(
		courseId						INT										NOT NULL				IDENTITY,
		courseTitle					NCHAR(50)						NOT NULL,
		instructorId					INT										NOT NULL,
		CONSTRAINT pk_course			PRIMARY KEY (courseId),
		CONSTRAINT fk_course_instructor		FOREIGN KEY (instructorId)
				REFERENCES instructor(instructorId)
);

INSERT INTO  instructor ( instructorName, instructorOffice) VALUES   ('Madison Morgan', 'Room 3');
INSERT INTO  instructor (instructorName, instructorOffice) VALUES    ('Mark Chambers', 'Room 1');
INSERT INTO  instructor (instructorName, instructorOffice) VALUES    ('Jillian Chambers', 'Room 2');

INSERT INTO course (courseTitle, instructorId) VALUES ('CISS 365 Project Management ', 1);

INSERT INTO course (courseTitle, instructorId) VALUES ('CISS 311 Advanced Agile ',2 );
INSERT INTO course (courseTitle, instructorId) VALUES ('CISS 238 JAVA Programming ', 2);

INSERT INTO course (courseTitle, instructorId) VALUES ('CISS 402 Advanced Database ', 3);
INSERT INTO course (courseTitle, instructorId) VALUES ('CISS 301 Operating Sys for Business ', 3);
INSERT INTO course (courseTitle, instructorId) VALUES ('CISS 302 Data Communications ', 3);


SELECT * FROM course;
SELECT * FROM instructor;