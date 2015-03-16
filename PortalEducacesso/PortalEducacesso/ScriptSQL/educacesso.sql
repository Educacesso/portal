create database educacesso
use educacesso

create table curso(
cdCurso int identity primary key NOT NULL,
nmCurso varchar(100) NOT NULL,
dsCurso varchar(255),
ctCurso varchar(100) NOT NULL)

select * from curso