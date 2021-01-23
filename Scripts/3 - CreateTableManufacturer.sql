USE [VehicleManagement]
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Manufacturer' and xtype='U')
	BEGIN
		CREATE TABLE Manufacturers (
			ManufacturerId INT PRIMARY KEY IDENTITY (1, 1),
			IsActive BIT DEFAULT(1) NOT NULL,
			RegisterDate DATETIME DEFAULT(GETDATE()) NOT NULL,
			[Name] NVARCHAR(MAX) NOT NULL
		)
	END
GO

INSERT INTO [Manufacturers] ([Name])  VALUES
 ('Volkswagen')
,('Toyota')
,('Renault')
,('Nissan')
,('Mitsubishi')
,('General Motors')
,('Hyundai')
,('Ford')
,('Honda')
,('Fiat')
