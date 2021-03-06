-- Script Date: 20/03/2018 23:53  - ErikEJ.SqlCeScripting version 3.5.2.75
-- Database information:
-- Locale Identifier: 3082
-- Encryption Mode: 
-- Case Sensitive: False
-- Database: C:\Users\juan\Documents\Visual Studio 2015\Projects\Restaurante\Restaurante\BD\BDRestaurante.sdf
-- ServerVersion: 4.0.8876.1
-- DatabaseSize: 256 KB
-- SpaceAvailable: 3,999 GB
-- Created: 08/02/2018 14:09

-- User Table information:
-- Number of tables: 14
-- Cliente: 18 row(s)
-- Comanda: 5 row(s)
-- Cuenta: 0 row(s)
-- Grupos: 5 row(s)
-- Insumos: 2 row(s)
-- MasterCierreCuenta: 0 row(s)
-- MasterComanda: 7 row(s)
-- MasterInsumos: 14 row(s)
-- Menu: 8 row(s)
-- Mesas: 24 row(s)
-- Mesoneros: 2 row(s)
-- ServicioDomicilio: 0 row(s)
-- Turno: 0 row(s)
-- UnidadMedida: 2 row(s)

CREATE TABLE [UnidadMedida] (
  [IDUnidad] int IDENTITY (3,1)  NOT NULL
, [Descripcion] nvarchar(10)  NOT NULL
);
GO
CREATE TABLE [Turno] (
  [IDTurno] int IDENTITY (1,1)  NOT NULL
, [Apertura] datetime NULL
, [Cerrar] datetime NULL
, [StatusTurno] nvarchar(25)  NULL
, [FondoInicial] numeric(18,2)  NULL
, [FondoFinal] numeric(18,2)  NULL
);
GO
CREATE TABLE [ServicioDomicilio] (
  [IDDomilicilio] int IDENTITY (1,1)  NOT NULL
, [IDCliente] int  NOT NULL
, [Calle] nvarchar(250)  NOT NULL
, [Direccion] nvarchar(250)  NOT NULL
, [NumExterior] nvarchar(250)  NOT NULL
, [NumInterior] nvarchar(250)  NOT NULL
, [Cruzamientos] nvarchar(250)  NOT NULL
, [Cruzamientos2] nvarchar(250)  NOT NULL
, [Colonia] nvarchar(250)  NOT NULL
, [Zona] nvarchar(250)  NOT NULL
, [Referencia] nvarchar(250)  NOT NULL
, [Ciudad] nvarchar(250)  NOT NULL
, [Delegación] nvarchar(250)  NOT NULL
, [Estado] nvarchar(100)  NOT NULL
, [Pais] nvarchar(100)  NOT NULL
, [CP] nvarchar(100)  NULL
);
GO
CREATE TABLE [Mesoneros] (
  [IDMesoneros] int IDENTITY (3,1)  NOT NULL
, [Nombre] nvarchar(100)  NULL
, [Apellido] nvarchar(100)  NULL
);
GO
CREATE TABLE [Mesas] (
  [IDMesas] int IDENTITY (25,1)  NOT NULL
, [NumeroMesa] nvarchar(10)  NOT NULL
, [CantidadPersona] int  NOT NULL
);
GO
CREATE TABLE [Menu] (
  [IDMenu] int IDENTITY (9,1)  NOT NULL
, [IDGrupo] int  NULL
, [Nombre] nvarchar(200)  NULL
, [precio] numeric(18,2)  NULL
);
GO
CREATE TABLE [MasterInsumos] (
  [IDMasterInsumos] int IDENTITY (15,1)  NOT NULL
, [IDInsumos] int  NULL
, [IDMenu] int  NULL
, [Cantidad] numeric(18,2)  NULL
);
GO
CREATE TABLE [MasterComanda] (
  [IDMasterComanda] int IDENTITY (8,1)  NOT NULL
, [IDComanda] int  NULL
, [IDMenu] int  NULL
, [Precio] numeric(18,2)  NULL
);
GO
CREATE TABLE [MasterCierreCuenta] (
  [IDMasterCierreCuenta] int IDENTITY (1,1)  NOT NULL
, [IDCuenta] int  NOT NULL
, [IDCierre] int  NOT NULL
);
GO
CREATE TABLE [Insumos] (
  [IDInsumos] int IDENTITY (3,1)  NOT NULL
, [IDGrupos] int  NOT NULL
, [Descripcion] nvarchar(100)  NOT NULL
, [UnidadMedida] nvarchar(10)  NOT NULL
, [UltimoCosto] numeric(18,2)  NOT NULL
, [CostoPromedio] numeric(18,2)  NOT NULL
, [CostoImpuesto] numeric(18,2)  NOT NULL
, [IVA] numeric(18,2)  NOT NULL
, [Inventariable] nvarchar(2)  NOT NULL
);
GO
CREATE TABLE [Grupos] (
  [IDGrupo] int IDENTITY (6,1)  NOT NULL
, [Descripcion] nvarchar(100)  NULL
);
GO
CREATE TABLE [Cuenta] (
  [IDCuenta] int IDENTITY (1,1)  NOT NULL
, [IDMesas] int  NULL
, [IDMesoneros] int  NULL
, [Reserva] nvarchar(100)  NULL
, [Apertura] datetime NULL
, [Cierre] datetime NULL
, [Orden] int  NULL
, [Folio] int  NULL
, [SubTotal] numeric(18,2)  NULL
, [Total] numeric(18,2)  NULL
, [Descuento] numeric(18,2)  NULL
, [Impuesto] numeric(18,2)  NULL
, [Propina] numeric(18,2)  NULL
, [Status] nvarchar(100)  NULL
, [IDComanda] int  NULL
, [Comisionista] nvarchar(100)  NULL
, [IDCliente] int  NULL
, [Imprimir] bit NULL
, [Cargo] numeric(18,2)  NULL
, [Monedero] numeric(18,2)  NULL
, [IDTurno] int  NULL
, [FormaPago] nvarchar(25)  NULL
);
GO
CREATE TABLE [Comanda] (
  [IDComanda] int IDENTITY (6,1)  NOT NULL
, [IDMesas] int  NULL
, [TotalPrecio] numeric(18,2)  NULL
, [Status] nvarchar(100)  NULL
, [Fecha] datetime NULL
, [IDMesoneros] int  NULL
);
GO
CREATE TABLE [Cliente] (
  [IDCliente] int IDENTITY (19,1)  NOT NULL
, [Nombre] nvarchar(250)  NULL
, [Direccion] nvarchar(250)  NULL
, [Tipo_Facturacion] nvarchar(100)  NULL
, [Estado] nvarchar(100)  NULL
, [Pais] nvarchar(100)  NULL
, [CodPostal] nvarchar(100)  NULL
, [FolioFiscal] nvarchar(100)  NULL
, [rfc] nvarchar(100)  NULL
, [Curp] nvarchar(100)  NULL
, [Giro] nvarchar(100)  NULL
, [Poblacion] nvarchar(100)  NULL
, [Contacto] nvarchar(100)  NULL
, [Telefono1] nvarchar(100)  NULL
, [Telefono2] nvarchar(100)  NULL
, [Telefono3] nvarchar(100)  NULL
, [Telefono4] nvarchar(100)  NULL
, [Telefono5] nvarchar(100)  NULL
);
GO
SET IDENTITY_INSERT [UnidadMedida] ON;
GO
INSERT INTO [UnidadMedida] ([IDUnidad],[Descripcion]) VALUES (
1,N'KG');
GO
INSERT INTO [UnidadMedida] ([IDUnidad],[Descripcion]) VALUES (
2,N'Gr');
GO
SET IDENTITY_INSERT [UnidadMedida] OFF;
GO
SET IDENTITY_INSERT [Turno] OFF;
GO
SET IDENTITY_INSERT [ServicioDomicilio] OFF;
GO
SET IDENTITY_INSERT [Mesoneros] ON;
GO
INSERT INTO [Mesoneros] ([IDMesoneros],[Nombre],[Apellido]) VALUES (
1,N'JUAN',N'VILLARROEL');
GO
INSERT INTO [Mesoneros] ([IDMesoneros],[Nombre],[Apellido]) VALUES (
2,N'CARLOS',N'MAGNO');
GO
SET IDENTITY_INSERT [Mesoneros] OFF;
GO
SET IDENTITY_INSERT [Mesas] ON;
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
1,N'1',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
2,N'2',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
3,N'3',4);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
4,N'4',4);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
5,N'5',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
6,N'6',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
7,N'7',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
8,N'8',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
9,N'9',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
10,N'10',4);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
11,N'11',4);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
12,N'12',4);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
13,N'13',4);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
14,N'14',4);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
15,N'15',8);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
16,N'16',8);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
17,N'17',8);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
18,N'18',8);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
19,N'19',8);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
20,N'20',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
21,N'21',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
22,N'22',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
23,N'23',2);
GO
INSERT INTO [Mesas] ([IDMesas],[NumeroMesa],[CantidadPersona]) VALUES (
24,N'24',2);
GO
SET IDENTITY_INSERT [Mesas] OFF;
GO
SET IDENTITY_INSERT [Menu] ON;
GO
INSERT INTO [Menu] ([IDMenu],[IDGrupo],[Nombre],[precio]) VALUES (
1,1,N'Prueba',12345.25);
GO
INSERT INTO [Menu] ([IDMenu],[IDGrupo],[Nombre],[precio]) VALUES (
2,1,N'Prueba',12345.25);
GO
INSERT INTO [Menu] ([IDMenu],[IDGrupo],[Nombre],[precio]) VALUES (
3,1,N'Prueba',12345.25);
GO
INSERT INTO [Menu] ([IDMenu],[IDGrupo],[Nombre],[precio]) VALUES (
4,1,N'Prueba',12345.25);
GO
INSERT INTO [Menu] ([IDMenu],[IDGrupo],[Nombre],[precio]) VALUES (
5,1,N'Prueba',12345.25);
GO
INSERT INTO [Menu] ([IDMenu],[IDGrupo],[Nombre],[precio]) VALUES (
6,1,N'Prueba',12345.25);
GO
INSERT INTO [Menu] ([IDMenu],[IDGrupo],[Nombre],[precio]) VALUES (
7,1,N'Prueba',12345.25);
GO
INSERT INTO [Menu] ([IDMenu],[IDGrupo],[Nombre],[precio]) VALUES (
8,1,N'Prueba',12345.25);
GO
SET IDENTITY_INSERT [Menu] OFF;
GO
SET IDENTITY_INSERT [MasterInsumos] ON;
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
1,1,1,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
2,1,1,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
3,1,1,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
4,1,1,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
5,1,1,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
6,1,1,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
7,1,1,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
8,1,1,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
9,1,2,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
10,1,2,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
11,1,2,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
12,1,2,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
13,1,3,100.10);
GO
INSERT INTO [MasterInsumos] ([IDMasterInsumos],[IDInsumos],[IDMenu],[Cantidad]) VALUES (
14,1,3,100.10);
GO
SET IDENTITY_INSERT [MasterInsumos] OFF;
GO
SET IDENTITY_INSERT [MasterComanda] ON;
GO
INSERT INTO [MasterComanda] ([IDMasterComanda],[IDComanda],[IDMenu],[Precio]) VALUES (
1,1,1,12345.25);
GO
INSERT INTO [MasterComanda] ([IDMasterComanda],[IDComanda],[IDMenu],[Precio]) VALUES (
2,2,1,12345.25);
GO
INSERT INTO [MasterComanda] ([IDMasterComanda],[IDComanda],[IDMenu],[Precio]) VALUES (
3,3,1,12345.25);
GO
INSERT INTO [MasterComanda] ([IDMasterComanda],[IDComanda],[IDMenu],[Precio]) VALUES (
4,4,1,12345.25);
GO
INSERT INTO [MasterComanda] ([IDMasterComanda],[IDComanda],[IDMenu],[Precio]) VALUES (
5,5,1,12345.25);
GO
INSERT INTO [MasterComanda] ([IDMasterComanda],[IDComanda],[IDMenu],[Precio]) VALUES (
6,1,1,12345.25);
GO
INSERT INTO [MasterComanda] ([IDMasterComanda],[IDComanda],[IDMenu],[Precio]) VALUES (
7,1,2,3000.00);
GO
SET IDENTITY_INSERT [MasterComanda] OFF;
GO
SET IDENTITY_INSERT [MasterCierreCuenta] OFF;
GO
SET IDENTITY_INSERT [Insumos] ON;
GO
INSERT INTO [Insumos] ([IDInsumos],[IDGrupos],[Descripcion],[UnidadMedida],[UltimoCosto],[CostoPromedio],[CostoImpuesto],[IVA],[Inventariable]) VALUES (
1,1,N'pollo dulce',N'KG',25.20,25.20,25.20,25.20,N'Si');
GO
INSERT INTO [Insumos] ([IDInsumos],[IDGrupos],[Descripcion],[UnidadMedida],[UltimoCosto],[CostoPromedio],[CostoImpuesto],[IVA],[Inventariable]) VALUES (
2,4,N'Pescado frito',N'KG',25.20,25.20,25.20,25.20,N'Si');
GO
SET IDENTITY_INSERT [Insumos] OFF;
GO
SET IDENTITY_INSERT [Grupos] ON;
GO
INSERT INTO [Grupos] ([IDGrupo],[Descripcion]) VALUES (
1,N'Mariscos');
GO
INSERT INTO [Grupos] ([IDGrupo],[Descripcion]) VALUES (
2,N'Embutidos');
GO
INSERT INTO [Grupos] ([IDGrupo],[Descripcion]) VALUES (
3,N'Carne');
GO
INSERT INTO [Grupos] ([IDGrupo],[Descripcion]) VALUES (
4,N'Pescado');
GO
INSERT INTO [Grupos] ([IDGrupo],[Descripcion]) VALUES (
5,N'Carne blanda');
GO
SET IDENTITY_INSERT [Grupos] OFF;
GO
SET IDENTITY_INSERT [Cuenta] OFF;
GO
SET IDENTITY_INSERT [Comanda] ON;
GO
INSERT INTO [Comanda] ([IDComanda],[IDMesas],[TotalPrecio],[Status],[Fecha],[IDMesoneros]) VALUES (
1,1,37035.75,N'CERRADA',{ts '2018-03-03 12:15:13.900'},1);
GO
INSERT INTO [Comanda] ([IDComanda],[IDMesas],[TotalPrecio],[Status],[Fecha],[IDMesoneros]) VALUES (
2,1,22500.00,N'CERRADA',{ts '2018-03-03 12:15:33.333'},1);
GO
INSERT INTO [Comanda] ([IDComanda],[IDMesas],[TotalPrecio],[Status],[Fecha],[IDMesoneros]) VALUES (
3,1,22500.00,N'CERRADA',{ts '2018-03-03 12:15:48.480'},1);
GO
INSERT INTO [Comanda] ([IDComanda],[IDMesas],[TotalPrecio],[Status],[Fecha],[IDMesoneros]) VALUES (
4,1,22500.00,N'CERRADA',{ts '2018-03-03 12:15:50.203'},1);
GO
INSERT INTO [Comanda] ([IDComanda],[IDMesas],[TotalPrecio],[Status],[Fecha],[IDMesoneros]) VALUES (
5,1,22500.00,N'CERRADA',{ts '2018-03-03 12:15:51.230'},1);
GO
SET IDENTITY_INSERT [Comanda] OFF;
GO
SET IDENTITY_INSERT [Cliente] ON;
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
1,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
2,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
3,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
4,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
5,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
6,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
7,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
8,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
9,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
10,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
11,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
12,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
13,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
14,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
15,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
16,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
17,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
INSERT INTO [Cliente] ([IDCliente],[Nombre],[Direccion],[Tipo_Facturacion],[Estado],[Pais],[CodPostal],[FolioFiscal],[rfc],[Curp],[Giro],[Poblacion],[Contacto],[Telefono1],[Telefono2],[Telefono3],[Telefono4],[Telefono5]) VALUES (
18,N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN',N'JUAN');
GO
SET IDENTITY_INSERT [Cliente] OFF;
GO
ALTER TABLE [UnidadMedida] ADD CONSTRAINT [PK_UnidadMedida] PRIMARY KEY ([IDUnidad]);
GO
ALTER TABLE [Turno] ADD CONSTRAINT [PK_Turno] PRIMARY KEY ([IDTurno]);
GO
ALTER TABLE [ServicioDomicilio] ADD CONSTRAINT [PK_ServicioDomicilio] PRIMARY KEY ([IDDomilicilio]);
GO
ALTER TABLE [Mesoneros] ADD CONSTRAINT [PK_Mesoneros] PRIMARY KEY ([IDMesoneros]);
GO
ALTER TABLE [Mesas] ADD CONSTRAINT [PK_Mesas] PRIMARY KEY ([IDMesas]);
GO
ALTER TABLE [Menu] ADD CONSTRAINT [PK_Menu] PRIMARY KEY ([IDMenu]);
GO
ALTER TABLE [MasterInsumos] ADD CONSTRAINT [PK_MasterInsumos] PRIMARY KEY ([IDMasterInsumos]);
GO
ALTER TABLE [MasterComanda] ADD CONSTRAINT [PK_MasterComanda] PRIMARY KEY ([IDMasterComanda]);
GO
ALTER TABLE [MasterCierreCuenta] ADD CONSTRAINT [PK_MasterCierreCuenta] PRIMARY KEY ([IDMasterCierreCuenta]);
GO
ALTER TABLE [Insumos] ADD CONSTRAINT [PK_Insumos] PRIMARY KEY ([IDInsumos]);
GO
ALTER TABLE [Grupos] ADD CONSTRAINT [PK_Grupos] PRIMARY KEY ([IDGrupo]);
GO
ALTER TABLE [Cuenta] ADD CONSTRAINT [PK_Cuenta] PRIMARY KEY ([IDCuenta]);
GO
ALTER TABLE [Comanda] ADD CONSTRAINT [PK_Comanda] PRIMARY KEY ([IDComanda]);
GO
ALTER TABLE [Cliente] ADD CONSTRAINT [PK_Cliente] PRIMARY KEY ([IDCliente]);
GO

