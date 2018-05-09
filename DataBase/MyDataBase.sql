create database MyProject

use MyProject

create table Hall(idhall int primary key,typehall varchar(50),idtools int references Tools(idtools),nameformer varchar(50) references Former(nameformer))
create table Tools(idtools int primary key,name varchar(50),nbrtools int,description varchar(50))
create table Former(nameformer varchar(50) primary key,firstnameformer varchar(50),age int,specialisation varchar(50))
