create database AddressBookSystem

----Create table AddressBookSystem
Create table AddressBookSystem(FirstName varchar(50),LastName varchar(50),Address varchar(50),City varchar(50), State varchar(50),Zip varchar(6),PhoneNumber varchar(10),EmailId varchar(50),AddressBookType varchar(50),AddressBookName varchar(50) );

drop table AddressBookSystem

--insert record for table
insert into AddressBookSystem values('Akhil','Umnebadi','Sirugapuram','Kurnool','Andhra Pradesh','518348','8904839805','akhilu5042@gmail.com','Family','UmnebadiAkhil');
select * from AddressBookSystem;

drop table AddressBookSystem