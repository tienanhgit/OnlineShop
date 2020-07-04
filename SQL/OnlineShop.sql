create database OnlineShop
use OnlineShop
/*Tao bang*/
create table Accounts
(
UserName nvarchar(50),
Password nvarchar(50)
)


alter table Accounts
add constraint Pri_User Primary key(UserName)

insert into Accounts
values('Admin','Admin')

select * from Accounts

--Proceduce
create proc Sp_Accout_Login
@UserName nvarchar(50),
@PassWord nvarchar(50)
as
begin
declare @count int
declare @res bit
select @count=count(*) from Accounts where Accounts.UserName=@UserName and Accounts.Password=@PassWord
if @count>0
set @res=1
else
set @res =0
select @res
end

select *from Accounts
exec Sp_Accout_Login 'admin1' ,'admin'







