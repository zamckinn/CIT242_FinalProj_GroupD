drop table if exists Users;
drop table if exists Tasks;
drop table if exists Scoreboard;

create table Users (
UserID integer primary key,
LastName nvarchar (20) NOT NULL ,
FirstName nvarchar (10) NOT NULL ,
Pass nvarchar(10) not null,
UserName nvarchar(10) not null,
Email nvarchar(20) not null,
DoB datetime null,
Score integer not null
);

create table Tasks (
TaskID integer primary key,
Description nvarchar(200) not null,
StartDate datetime not null,
EndDate datetime not null,
Completed boolean not null,
UserID integer not null,
Constraint Tasks_UserID_fk foreign key (UserID) references Users(UserID)
);

create table Scoreboard(
ScoreID integer primary key,
User nvarchar(30) not null,
Score integer not null,
Constraint Scoreboard_Score_fk foreign key (Score) references Users(Score)
);

insert into Users values(1,'Doe','John','PA$$WORD','JohnDoe123','jdoe@email.com','05/12/1977',100);
insert into Users values(2,'Doe','Jane','pAss_word','JaneDoe456','jadoe@email.com','09/04/1976',150);
insert into Users values(3,'Jett','Nathaniel','wordPa$$','Njett789','njett@email.com','11/12/1999',50);
insert into Users values(4,'McKinney','Zachary','u$ername','Zmckinn123','zamckinn@email.com','06/20/1998',25);
insert into Users values(5,'Tshikunga','Glody','pa$$name','Glotsh456','glotsh@email.com','01/17/1997',55);


insert into Tasks values(1,'Finish Homework','05/20/2023','05/25/2023',false,1);
insert into Tasks values(2,'Clean room','06/01/2023','06/29/2023',false,1);
insert into Tasks values(3,'Earn Driver"s Liscense','01/05/23','05/20/2023',true,1);
insert into Tasks values(4,'Sell old car','07/23/2023','08/01/2023',false,1);
insert into Tasks values(5,'Buy new Oven','12/12/2023','12/20/23',false,2);
insert into Tasks values(6,'Clean room','03/23/2023','04/25/2023',false,2);
insert into Tasks values(7,'Clean kitchen','04/25/2023','05/06/2023',false,2);
insert into Tasks values(8,'Mow lawn','01/10/2023','01/11/2023',true,2);
insert into Tasks values(9,'Buy new dishes','05/05/2023','05/13/2023',false,3);
insert into Tasks values(10,'Send mom flowers','05/01/2023','05/14/2023',false,3);
insert into Tasks values(11,'Finish final project','04/13/2023','04/22/2023',false,3);
insert into Tasks values(12,'Send important email','01/12/2023','01/13/2023',true,3);
insert into Tasks values(13,'Go on a run','01/02/2023','01/09/2023',true,4);
insert into Tasks values(14,'Clean room','01/22/2023','02/22/2023',false,4);
insert into Tasks values(15,'Change oil','02/23/2023','02/25/2023',false,4);
insert into Tasks values(16,'Call mom','05/22/2023','05/26/2023',false,4);
insert into Tasks values(17,'Report issue with database','10/10/2023','10/22/2023',false,5);
insert into Tasks values(18,'Send report to management','09/11/2023','09/23/2023',false,5);
insert into Tasks values(19,'Write project wrapup','04/11/2023','04/21/2023',false,5);
insert into Tasks values(20,'Plan vacation','03/13/2023','04/15/2023',false,5);

insert into Scoreboard values(1,'John Doe',100);
insert into Scoreboard values(2,'Jane Doe',150);
insert into Scoreboard values(3,'Nathaniel Jett',50);
insert into Scoreboard values(4,'Zachary McKinney',25);
insert into Scoreboard values(5,'Glody Tshikunga',55);
