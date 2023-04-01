CREATE DATABASE LAB12

CREATE TABLE [dbo].[Employee_Details]
(
[Emp_Id] [int] IDENTITY(1,1) NOT NULL,
[Emp_Name] [nvarchar](50) NOT NULL,
[Emp_City] [nvarchar](50) NOT NULL,
[Emp_Salary] [int] NOT NULL,
CONSTRAINT [PK_Employee_Details] PRIMARY KEY CLUSTERED (
[Emp_Id] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)
ON [PRIMARY]
GO

-------------------
Insert Into Employee_Details Values('Pankaj','Alwar',25000) 
Insert Into Employee_Details Values('Rahul','Jaipur',26000)
Insert Into Employee_Details Values('Rajan','Delhi',27000)
Insert Into Employee_Details Values('Sandeep','Alwar',28000)
Insert Into Employee_Details Values('Sanjeev','Jaipur',32000)
Insert Into Employee_Details Values('Narendra','Alwar',34000)
Insert Into Employee_Details Values('Neeraj','Delhi',29000)
Insert Into Employee_Details Values('Div','Jaipur',25000) 
Insert Into Employee_Details Values('Tanuj','Alwar',22000)
Insert Into Employee_Details Values('Nitin','Jaipur',20000)

--------------------------------
SELECT * FROM Employee_Details

------------------------------
CREATE TABLE Employee_Contact(
Emp_ID int NOT NULL,
MobileNumber nvarchar(50) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee_Contact] WITH CHECK ADD CONSTRAINT [FK_Employee_Contact_Employee_Details] FOREIGN KEY([Emp_Id])
REFERENCES [dbo].[Employee_Details] ([Emp_Id])
GO
ALTER TABLE [dbo].[Employee_Contact] CHECK CONSTRAINT [FK_Employee_Contact_Employee_Details]
GO

--------------------------
Insert Into Employee_Contact Values(1,'9813220191')
Insert Into Employee_Contact Values(2,'9813220192')
Insert Into Employee_Contact Values(3,'9813220193')
Insert Into Employee_Contact Values(4,'9813220194')
Insert Into Employee_Contact Values(5,'9813220195')
Insert Into Employee_Contact Values(6,'9813220196')
Insert Into Employee_Contact Values(7,'9813220197')
Insert Into Employee_Contact Values(8,'9813220198')
Insert Into Employee_Contact Values(9,'9813220199') 
Insert Into Employee_Contact Values(10,'9813220135')
------------------------------
select * from Employee_Contact
--------
Create View Employee_View1 
as  
select * from Employee_Details
---
Create View Employee_View2 
as 
select Emp_Id,Emp_Name,Emp_City from Employee_Details
--
Create View Employee_View3  
as 
select * from Employee_Details where Emp_Id>3
--
Create View Employee_View4
as
select Employee_Details.Emp_Id,Employee_Details.Emp_Name,Employee_Details.Emp_Salary,Employee_Contact.MobileNumber from Employee_Details
Left Outer Join
Employee_Contact
on
Employee_Details .Emp_Id= Employee_Contact.Emp_Id
Where Employee_Details.Emp_Id>2
---
Select * from Employee_View4 
Select Emp_Id,Emp_Name,Emp_Salary from Employee_View4
--
Alter View Employee_View4
as 
select Employee_Details.Emp_Id,Employee_Details.Emp_Name,Employee_Details.Emp_Salary,Employee_Contact.MobileNumber from Employee_Details
Left Outer Join 
Employee_Contact 
on 
Employee_Details .Emp_Id= Employee_Contact.Emp_Id 
Where Employee_Details.Emp_Id>5 and Employee_Details.Emp_City='Alwar'
--
Create View Employee_View5 
as 
Select * from Employee_Details 
--
Alter Table Employee_Details Add MY_sal nvarchar(50)

--
Create View Employee_Details3 
with SCHEMABINDING as 
select Emp_Id,Emp_Name,Emp_Salary,Emp_City from DBO.Employee_Details
--
Create View Employee_Details4 
with Encryption 
as 
select Emp_Id,Emp_Name,Emp_Salary,Emp_City from DBO.Employee_Details
--
Exec sp_helptext 'Employee_Details4'
--
GO 
Create view [dbo].[Employee_Details7] 
as 
select * from Employee_Details 
where Emp_Salary>30000 
GO
--
Insert Into Employee_Details7 values ('ram','mumbai',25000,'Pan')
--
GO 
Create view [dbo].[Employee_Details8]
as 
select * from Employee_Details 
where Emp_Salary>30000 
with Check Option 
GO 
--
Insert Into Employee_Details7 values ('ram','mumbai',35000) 
Update Employee_Details7 set Emp_Name='Raju' where Emp_id=5 
delete from Employee_Details7 where Emp_Id=6 
select * from Employee_Details7
