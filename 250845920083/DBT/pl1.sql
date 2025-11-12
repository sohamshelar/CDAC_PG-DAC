-- drop procedure if exists pro1;
-- delimiter $
-- create procedure pro1()
-- BEGIN
-- 	select "Hello World " R1;
-- end $
-- delimiter ;

-- drop procedure if exists pro1;
-- delimiter $
-- create procedure pro1()
-- BEGIN
-- 	select * from dept;
-- end $
-- delimiter ;

-- drop procedure if exists pro1;
-- delimiter $
-- create procedure pro1()
-- BEGIN
-- 	declare x int default 100;
--     declare y int;
--     set y := 200;
--     select x + y;
-- end $
-- delimiter ;

-- drop procedure if exists pro1;
-- delimiter $
-- create procedure pro1(in x int, in y int,out z int)
-- BEGIN
-- 	set z:= x+y;
--     select z;
-- end $
-- delimiter ;

-- drop procedure if exists pro1;
-- delimiter $
-- create procedure pro1(in x int, in y int,out z int, out z1 int,out z2 int  )
-- BEGIN
-- 	set z:= x+y;
--     set z1 := x*y;
--     set z2 := x/y;
--     select z;
--     select z1;
--     select z2;
-- end $
-- delimiter ;

-- drop procedure if exists pro1;
-- delimiter $
-- create procedure pro1()
-- BEGIN
-- 	declare exit handler for sqlexception
--     BEGIN
-- 			ROLLBACK;
--             SELECT 'Transaction FAILED. Rolled back.' AS message;
--             end;
--             Start Transaction Read Write;
--             
--             insert into a1 values(2);
--             insert into a2 values(2);
--             commit;

-- end $
-- delimiter ;    


-- drop procedure if exists pro1;
-- delimiter $ 
-- create procedure pro1()
-- BEGIN
-- 				insert into dept values(82, 'DarkDip', 'Bombay','BOMB@BAY', '01/04/2028');
-- end $
-- delimiter ;

-- drop procedure if exists pro2;
-- delimiter $
-- create procedure pro2(p_dname varchar(20),p_loc varchar(20),p_pwd varchar(20),p_STARTEDON varchar(20))
-- BEGIN 
-- 	declare v_deptno int default 0;
--     select max(deptno)+1 into v_deptno from dept;
--     insert into dept values(v_deptno,upper(p_dname),upper(p_loc),p_pwd, p_STARTEDON);
--     select "Record Inserted" as message;
-- end $
-- delimiter ;

-- drop procedure if exists pro1;
-- delimiter $
-- create procedure pro1(p_deptno int)
-- BEGIN 
-- 	declare flag bool default false;
--     select true into flag from dept where deptno=p_deptno;
--     
--     if flag Then
-- 			delete from dept where deptno= p_deptno;
--             select "Record deleted.." as MSG;
-- 	ELSE
-- 			select "Record not found..." as MSG;
-- 	end if;
-- end $
-- delimiter ;

-- drop procedure if exists pro1;
-- delimiter $
-- create procedure pro1(x int ,y int)
-- BEGIN
-- 	select * from dept limit x,y;
-- end $
-- delimiter ;

drop procedure if exists pro1;
delimiter $
create procedure pro1(p_last_record int)
BEGIN 
	declare v_cnt int default 0;
    select count(*) - p_last_record into v_cnt from dept;
    select * from dept limit v_cnt, p_last_record;
end $
delimiter ;

            
            

