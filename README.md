# Login and Programming projects
Repository created to share the projects I developed during the 2nd year of my technical computer course with the aim of learning programming logic using the C# language.

## 🔨 Projects functionality

### 01 - Displaying data on screen
This program was developed to introduce students to the C# programming language and consists of displaying the data entered by the user in the text field as an alert message.

### 02 - Simple calculator

### 03 - Final test 1st stage

### 04 - Decision structure exercise

### 05 - Product registration

### 06 - While repetition exercises

### 07 - Show highest salary

### 08 - Method review exercises

### 09 - Final test 2nd stage

### 10 - Decrement exercise

### 11 - Repetition loops exercises

### 12 - Increment and decrement exercise

### 13 - Even number array

### 14 - Drawings in tables

### 15 - Vector sum

### 16 - Vector analysis

### 17 - Matrix filling

### 18 - Matrix exercises

### 19 - Student registration

### 20 - Final test 3rd stage

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