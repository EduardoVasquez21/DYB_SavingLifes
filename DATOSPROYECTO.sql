create Database DATOSPROYECTO;

use DATOSPROYECTO;

Create Table Tbl_UserList1(
Id int primary key identity,
NombreDonante varchar(50),
Departamento varchar(50),
Direccion varchar(50),
DUI varchar,
Telefono int,
Edad int,
Sexo varchar(50),
GrupoSanguineo varchar(50),
FechaDonacion varchar(50),
Correo varchar(50),
estatus varchar(50)

);

select * from Tbl_UserList1;