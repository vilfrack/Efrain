-- Script Date: 08/02/2018 14:14  - ErikEJ.SqlCeScripting version 3.5.2.74
CREATE TABLE [EnvioDomicilio] (
  [IDDomicilio] int IDENTITY (1,1)  NOT NULL
, [IDCliente] int  NOT NULL
, [Calle] nvarchar(250)  NOT NULL
, [Direccion] nvarchar(250)  NOT NULL
, [Contacto] nvarchar(250)  NOT NULL
, [Telefono] nvarchar(250)  NOT NULL
, [NumExterior] nvarchar(10)  NOT NULL
, [NumInterior] nvarchar(10)  NOT NULL
, [CodPostal] nvarchar(10)  NOT NULL
, [Cruzamientos] nvarchar(100)  NOT NULL
, [Referencia] nvarchar(250)  NOT NULL
, [Ciudad] nvarchar(250)  NOT NULL
, [Delegacion] nvarchar(250)  NOT NULL
, [Estado] nvarchar(250)  NOT NULL
, [Pais] nvarchar(100)  NOT NULL
);
GO
ALTER TABLE [EnvioDomicilio] ADD CONSTRAINT [PK_EnvioDomicilio] PRIMARY KEY ([IDDomicilio]);
GO