# Login and Programming projects
Repository created to share the projects I developed during the 2nd year of my technical computer course with the aim of learning programming logic using the C# language.

## 🔨 Projects functionality

### 01 - Displaying data on screen
The program was developed to introduce students to the C# programming language and consists of displaying the data entered by the user in the text field as an alert message.

### 02 - Simple calculator
Calculator developed with the aim of using the basic operators in the C# language (addition, subtraction, multiplication and division).

### 03 - Final test 1st stage
The application was developed with the aim of testing the knowledge acquired during the first stage of the course and consists of two questions: one to take the user's data, save it in a variable and display it on the screen, and another question to calculate the value of each installment (based on the data provided by the user).

### 04 - Decision structure exercise
The exercise consists of 12 questions to test the student's knowledge of the IF decision structure.

### 05 - Product registration
Program created with the aim of making a simple user registration, just validating some data entered by the user and the tax value from the data entered by the user.

### 06 - While repetition exercises
Project developed with the aim of consolidating the content learned about the WHILE repetition structure.

### 07 - Show highest salary
Application developed with the aim of teaching more about the IF structure. To do this, the user must enter three salaries, and the code will check them and display the highest one.

### 08 - Method review exercises
The program consists of three exercises designed to teach students how to create and use methods in C#.

### 09 - Final test 2nd stage
The final test of the second stage was designed to put into practice the main content learned over the last few months. It consists of two parts: one for static user registration that validates the entered fields, and another to display all the numbers in a sequence specified by the user using a repeat loop.

### 10 - Decrement exercise
Project created to display numbers to the user in descending order using the FOR repetition structure.

### 11 - Repetition loops exercises
Project developed with the aim of consolidating the content learned about the main repetition structures (for, while and do-while).

### 12 - Increment and decrement exercise
Program designed to train more about the IF conditional structure and the WHILE repetition structure, complementing exercise 10.

### 13 - Even number array
Project created to display all the even numbers in an array, with the main objective of training knowledge about vectors and the FOR structure in C#.

### 14 - Drawings in tables
Application developed to create drawings through tables using the FOR structure.

### 15 - Vector sum
Project created in order to train more about array, by summing the values present in its structure.

### 16 - Vector analysis
Program designed to teach the contents of vectors, storing random numbers from a value determined by the user and obtaining some information about the generated structure, such as the largest and smallest value present in it, among other data.

### 17 - Matrix filling
Application created to introduce studies on matrix creation in C#, where the user enters nine values and they make up the structure of this matrix.

### 18 - Matrix exercises
Three-question project developed with the aim of learning more about matrix breeding.

### 19 - Student registration
Student registration program developed with final stage project. Its main objective is to introduce students to the creation of a complete CRUD involving C# and SQL.

### 20 - Final test 3rd stage
The final course test was designed to put into practice the main knowledge acquired during the year, for which two questions were developed: the first was to display drawings in a matrix, and the second consisted of creating a complete CRUD with SQL.

## 💻 Technologies used 
* [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/): programming language
* [.NET Framework](https://learn.microsoft.com/pt-br/dotnet/fundamentals/): platform for developing and running systems and applications

## 🎲 SQL scripts for projects 19 and 20
To run these two projects, you'll need to install [MySQL Workbench](https://dev.mysql.com/doc/workbench/en/) or some other similar program and run the scripts below.

* Student registration
```
create database school;
use school;

create table students (
	id int auto_increment primary key,
	name varchar(200),
	age varchar(50),
	unit varchar(50),
	series varchar(50),
	class varchar(50)
);
```

* Final test 3rd stage
```
create database company;
use company;

create table employees (
	id int auto_increment primary key,
	name varchar(200),
	position varchar(200),
	salary decimal(10,2)
);
```

## 📁 Access and execute project
### 1. Install and configure [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) on your computer
* I recommend watching [this video](https://www.youtube.com/watch?v=KKaDlo1I21Y) to help you
### 2. Clone [this repository](https://github.com/ArturColen/Cotemig-logic-and-programming-works) on your machine
* Create a folder on your computer for this program
* Copy the [URL](https://github.com/ArturColen/Cotemig-logic-and-programming-works.git) from the repository
* Open Visual Studio and click `Clone a repository`
* In the appropriate spaces paste the URL, select where you want to save the project and click the `clone` button
* Wait a while until cloning is complete
### 3. Open the folder of the project you want to test in Visual Studio and click the `Start ▶️` button to run it.