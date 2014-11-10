

insert into mch.dbo.reporte(nombre, vista, descripcion, definicion, datasource)
values('Reporte por comunidad','v_Reporte_comunidad','Ver los detalles de cobro por cada comunidad','ReporteComunidad.rdlc','MCHDataSet9_v_Reporte_comunidad')

declare @idReporteComunidad int
select @idReporteComunidad = idReporte from mch.dbo.reporte where nombre = 'Reporte por comunidad'

insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Nombre de persona','Nombre','Nombre de la persona',1,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Codigo','Codigo','Codigo de una persona',1,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Lectura anterior','Lectura_anterior','Lectura anterior',2,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Lectura actual','Lectura_actual','Lectura actual',2,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Total de consumo','Total_de_consumo','Total de consumo',2,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Precio por KW','Precio_KW','Precio por KW',2,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Total','Total','Total',2,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Cuota fija','Cuota_fija','Cuota fija',2,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Cuota alumbrado publico','Alumbrado_publico','Alumbrado publico',2,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('IVA','IVA','IVA',2,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Total a pagar','Total_a_pagar','Total a pagar',2,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('Fecha de pago','Fecha_de_pago','Fecha de pago',1,@idReporteComunidad)
insert into mch.dbo.camporeporte(nombre, nombrecampo, descripcion, idtipo, idreporte) values('comunidad','comunidad','Nombre de la comunidad',1,@idReporteComunidad)

