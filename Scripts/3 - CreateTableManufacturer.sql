USE [VehicleManagement]
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Manufacturer' and xtype='U')
	BEGIN
		CREATE TABLE Manufacturers (
			ManufacturerId INT PRIMARY KEY IDENTITY (1, 1),
			IsActive BIT NOT NULL,
			RegisterDate DATETIME NOT NULL,
			[Name] NVARCHAR(MAX) NOT NULL
		)
	END
GO

INSERT INTO [Manufacturers] ([IsActive], [RegisterDate], [Name])  VALUES
 (1, GETDATE(), 'Volkswagen')
,(1, GETDATE(), 'Toyota')
,(1, GETDATE(), 'Renault')
,(1, GETDATE(), 'Nissan')
,(1, GETDATE(), 'Mitsubishi')
,(1, GETDATE(), 'General Motors')
,(1, GETDATE(), 'Hyundai')
,(1, GETDATE(), 'Ford')
,(1, GETDATE(), 'Honda')
,(1, GETDATE(), 'Fiat')
