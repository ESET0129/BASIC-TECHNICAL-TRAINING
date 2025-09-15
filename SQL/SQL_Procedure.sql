--creating procedure
Create Procedure detail

--adding after dropping
--@dept_id char
--@emp_id int;
as begin 
	declare @salary int;
--select * from employee3 where dept_id=@dept_id
select salary = @salary from employee3 
--where emp_id=@emp_id;

if @salary > 15000
	print 'high salary employee';
else if @salary >= 10000
	print 'good salary employee'
else 
	print 'work well'

end
-- removing procedure 
-- drop precedure procedure_name
--exec detail @dept_id = 3
exec detail salary ;
--execute procedure name

drop procedure detail



--TRIGGERS

--CREATE TRIGGER TR_UPD_LOCATIONS on location
--for UPDATE
--NOT for reflection
--as

--BEGIN
--	insert inito locationlist 
--	select location 

CREATE TRIGGER trg_After_Insert_book
on bookss
--for UPDATE
--NOT for reflection
after insert
as

BEGIN

--	insert into bookss 
	
	print 'new book has been added'
end;

