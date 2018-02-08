-- Script Date: 08/02/2018 14:10  - ErikEJ.SqlCeScripting version 3.5.2.74
CREATE TABLE [Cliente] (
  [IDCliente] int IDENTITY (1,1)  NOT NULL
, [Nombre] nvarchar(250)  NOT NULL
, [Direccion] nvarchar(250)  NOT NULL
, [Tipo_Facturacion] nvarchar(100)  NOT NULL
, [Estado] nvarchar(100)  NOT NULL
, [Pais] nvarchar(100)  NOT NULL
, [CodPostal] nvarchar(100)  NOT NULL
);
GO
ALTER TABLE [Cliente] ADD CONSTRAINT [PK_Cliente] PRIMARY KEY ([IDCliente]);
GO