--part a tests 
select 12, (12/3) - 2 'fuel'

select 14, (14/3) - 2 'fuel'

select 1969, (1969/3) - 2 'fuel' 

select 100756, (100756/3) - 2 'fuel'

--part a 
select sum((mass / 3) - 2) 'fuel' 
 from Day1 (nolock) 


--part b tests

select dbo.CalcFuel(14) 

select dbo.CalcFuel(1969)

select dbo.CalcFuel(100756)



--part b 

--5183653
select sum(dbo.CalcFuel(Mass)) 'fuel'
 from Day1 (nolock) 

