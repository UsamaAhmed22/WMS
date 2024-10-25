CREATE TABLE userlogin
(
UserID INT Identity(1,1) Primary key,
Username varchar(16) not null,
UserPassword varchar(16) not null,
UserRole varchar(16) not null
)

insert into userlogin values ('Ahsan Tariq' , 'Ahsan@123' , 'WMSManager')
insert into userlogin values ('Muneeb Tariq' , 'Muneeb@123' , 'O&PManager')
insert into userlogin values ('Arsalan Gul' , 'Arsalan@123' , 'R&PManager')
insert into userlogin values ('Wasif Nadeem' , 'Wasif@123' , 'SecurityManager')
insert into userlogin values ('Ahmed Alam' , 'Ahmed@123' , 'DockManager')

Select * from userlogin