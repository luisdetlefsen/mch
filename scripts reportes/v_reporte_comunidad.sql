USE [mch]
GO

/****** Object:  View [dbo].[v_Reporte_comunidad]    Script Date: 11/05/2014 13:36:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[v_Reporte_comunidad]
AS


select a.Nombre
	, a.[Código] as [Codigo]
	, a.[Lectura anterior] as [Lectura_anterior]
	, a.[Lectura actual] as [Lectura_actual]
	, [lectura actual] - [lectura anterior] as [Total_de_consumo]
	, 'Q. ' + cast([Precio de KW] as varchar(20)) as [Precio_KW]
	, ([lectura actual] - [lectura anterior])*[Precio de KW] as [Total]
	, 'Q. ' + cast([Cuota fija]  as varchar(20)) as [Cuota_fija]
	, '' as [Alumbrado_publico]
	, '' as [IVA] 
	, 'Q. ' + cast([Cuota fija] + ([lectura actual] - [lectura anterior])*[Precio de KW] as varchar(20))  as [Total_a_pagar] 
	, '' as [Fecha_de_pago]
	, [comunidad] 
from (
	select persona.Nombre
		, codigo as [Código]
		, (select top 1 /*Asegurarse que se ha hecho una sola lectura en un mes*/ lectura from lectura l where l.id_contrato = c.ID_Contrato order by fecha_lectura asc ) as [Lectura anterior]
		, (select top 1 /*Asegurarse que se ha hecho una sola lectura en un mes*/ lectura from lectura l where l.id_contrato = c.ID_Contrato order by fecha_lectura desc) as [Lectura actual]
		, (select param_cuota_kw from tipo_servicio, contador where contador.ID_Contador = c.ID_Contador and contador.tipo_servicio = tipo_servicio.no_tipo_servicio) as [Precio de KW]
		, (select param_cuota_fija from tipo_servicio, contador where contador.ID_Contador = c.ID_Contador and contador.tipo_servicio = tipo_servicio.no_tipo_servicio) as [Cuota fija]	
		, comunidad.nombre as [comunidad] 
	from persona, contrato c, comunidad
	where persona.id_persona = c.id_persona
	and persona.id_comunidad = comunidad.id_comunidad		
)a
where [Lectura actual] is not null


GO


