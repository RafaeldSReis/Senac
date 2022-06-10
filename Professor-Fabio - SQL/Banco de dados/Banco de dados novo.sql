
use AdventureWorks2019



select *
from HumanResources.Employee;



create view employee as
select *
from HumanResources.Employee;



select * from employee;
//



create view employeeDepartmentHistory as
select *
from HumanResources.Employee;



create view Department as
select *
from HumanResources.Department;



create view shift as
select *
from HumanResources.Shift;



create view JobCandidate as
select *
from HumanResources.JobCandidate;



create view EmployeePayHistory as
select *
from HumanResources.EmployeePayHistory;



--Exercicios
--1- Selecione os campos loguin e Gender
select LoginID Gender
from employee;



--2- Selecione os campos Name e GroupName da tabela Department.
select Name, Groupname
from Department;



--3- Selecione os campos Name, Startine e EndTime da tabela Shift.
select Name, StartTime, EndTime
from shift;



--4- Selecione os campos Rete e o mesmo campo com o valor triplcado da tabela EmployeePayHistory
select Rate,Rate*3 as Taixa
from EmployeePayHistory;



--5-Faça uma pesquisa que monte a seguinte frase 'O fúncionario do cargo X foi Contratado no dia Y' obs:Subistitua carga X por Jobtitle e dia Y HiriDate.
select Concat('O fúncionario do cargo', JobTitle ,'Foi contratado no dia', HireDate ) as "Cargo e data de contratação"
from employee;



--6- Faça uma pesuisa que mostre o campo Gender da tabela Employee sem Repetição
select Distinct (Gender)
from employee;



--7- Selecione os campos Jobtitle e BirhDate que tenham o organizationLevel igual a 3 da tabela Employee.
select JobTitle, BirthDate, OrganizationLevel
from employee;



--8- Selecione os campos que tenham o campo GroupName igual a "Sales and Marketing" da tabela Department.
select Name
from Department
where GroupName = 'Sales and Marketing';



--9- Selecione todas das Rates que foram maiores que 100,00 da tabela em EmployeePayHistory.
select Rate
from EmployeePayHistory
where Rate > 100;



--10- selecione todas da Rates que forem entre 50 e 200 da tabela EmployeePayHistory.
select Rate
from EmployeePayHistory
where Rate between 50 and 200;



--11- Selecione todos os dados dos JobCanditadeID 3 e 7 da tabela jobcanditade.
select *
from JobCandidate
where JobCandidateID between 3 and 7;

--12- Selecione todos os dados da tabela employee ordenados pela birthdate.
SELECT * FROM employee ORDER BY BirthDate;

--13- Selecione todos os dados da tabela department ordenados pelos campos groupname e name.
SELECT * FROM department ORDER BY GroupName,Name

--14- Faça uma pesquisa que mostre quantos funcionarios tem na empresa
SELECT COUNT(*) FROM Employee;

--15- Faça uma pesquisa que mostre a media de rate paga.
SELECT avg(Rate) FROM employeepayhistory;

--16- Faça uma pesquisa que mostre a soma total de rate pega.
SELECT SUM(Rate) FROM employeepayhistory;

--17- Faça uma pesquisa que mostre quantos funcionarios trabalham em cada turno da empresa
SELECT ShiftID,COUNT(StartDate) FROM employeedepartmenthistory GROUP BY shiftID;

--18- Faça uma pesquisa que mostre a soma de taxas pagas para cada businessentityID ordenando pela soma dessas taxas.
SELECT BusinessEntityID,SUM(Rate) FROM employeepayhistory GROUP BY BusinessEntityID ORDER BY SUM(Rate);

--19- Faça uma pesquisa que mostre a soma de taxas pagas para cada businessentityID com IDs maiores que 10, exclurindo as somas
-- menores que 20,00 e ordenando pela soma dessas taxas.
SELECT BusinessEntityID,SUM(Rate) FROM employeepayhistory WHERE BusinessEntityID > 10 GROUP BY BusinessEntityID HAVING SUM(Rate) > 20 ORDER BY SUM(Rate);

--21- Faça uma pesquisa que mostre o LoginID de cada empregado juntamente com a taxa paga para cada um deles.
SELECT e.LoginID, h.Rate FROM employee e JOIN employeepayhistory h on e.BusinessEntityID = h.BusinessEntityID;

--22- Faça uma pesquisa que mostre a loginID de cada empregado, o nome do departamento que trabalha e o nome seu turno.
SELECT e.LoginID, d.Name, s.Name FROM employee e JOIN employeedepartmenthistory eh on e.BusinessEntityID = eh.BusinessEntityID JOIN department d
ON d.DepartmentID = eh.DepartmentID JOIN shift s ON s.ShiftID = eh.ShiftID;;


