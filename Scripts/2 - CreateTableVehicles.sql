USE [VehicleManagement]
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Vehicles' and xtype='U')
	BEGIN
		CREATE TABLE Vehicles (
			Id INT PRIMARY KEY IDENTITY (1, 1),
			Active BIT NOT NULL,
			RegisterDate DATETIME NOT NULL,
			Plate NVARCHAR(7) NOT NULL,
			Model NVARCHAR(MAX) NOT NULL,
			ManufacturerId INT NOT NULL
		)
	END

INSERT INTO [Vehicles](ManufacturerId, Plate, RegisterDate, Active, Model) VALUES 
 (1, 'AAA0A00', GETDATE(), 1, 'T-Cross')
,(1, 'AAA0A01', GETDATE(), 1, 'Gol')
,(1, 'AAA0A02', GETDATE(), 1, 'Polo')
,(1, 'AAA0A04', GETDATE(), 1, 'Virtus')
,(1, 'AAA0A05', GETDATE(), 1, 'Fox')
,(2, 'AAA0A06', GETDATE(), 1, 'Yaris')
,(2, 'AAA0A07', GETDATE(), 1, 'Corolla')
,(2, 'AAA0A08', GETDATE(), 1, 'Hilux')
,(2, 'AAA0A09', GETDATE(), 1, 'RAV4')
,(2, 'AAA0A10', GETDATE(), 1, 'Etios')
,(3, 'AAA0A11', GETDATE(), 1, 'Logan')
,(3, 'AAA0A12', GETDATE(), 1, 'Sandero')
,(3, 'AAA0A13', GETDATE(), 1, 'Stepway')
,(3, 'AAA0A14', GETDATE(), 1, 'Kwid')
,(3, 'AAA0A15', GETDATE(), 1, 'Fluence')
,(4, 'AAA0A16', GETDATE(), 1, 'Kicks')
,(4, 'AAA0A17', GETDATE(), 1, 'Titan')
,(4, 'AAA0A18', GETDATE(), 1, 'Versa')
,(4, 'AAA0A19', GETDATE(), 1, 'Tiida')
,(4, 'AAA0A20', GETDATE(), 1, 'Maxima')
,(5, 'AAA0A21', GETDATE(), 1, 'Lancer')
,(5, 'AAA0A22', GETDATE(), 1, 'Outlander')
,(5, 'AAA0A23', GETDATE(), 1, 'Eclipse')
,(5, 'AAA0A24', GETDATE(), 1, 'Pajero')
,(5, 'AAA0A25', GETDATE(), 1, 'Asx')
,(6, 'AAA0A26', GETDATE(), 1, 'Onix')
,(6, 'AAA0A27', GETDATE(), 1, 'Cruze')
,(6, 'AAA0A28', GETDATE(), 1, 'Spin')
,(6, 'AAA0A29', GETDATE(), 1, 'Tracker')
,(6, 'AAA0A30', GETDATE(), 1, 'TrailBlazer')
,(7, 'AAA0A31', GETDATE(), 1, 'HB20')
,(7, 'AAA0A32', GETDATE(), 1, 'I30')
,(7, 'AAA0A33', GETDATE(), 1, 'Creta')
,(7, 'AAA0A34', GETDATE(), 1, 'Elantra')
,(7, 'AAA0A35', GETDATE(), 1, 'Tucson')
,(8, 'AAA0A36', GETDATE(), 1, 'Ka')
,(8, 'AAA0A37', GETDATE(), 1, 'Fusion')
,(8, 'AAA0A38', GETDATE(), 1, 'Focus')
,(8, 'AAA0A39', GETDATE(), 1, 'Fiesta')
,(8, 'AAA0A40', GETDATE(), 1, 'Ecosport')
,(9, 'AAA0A41', GETDATE(), 1, 'Civic')
,(9, 'AAA0A42', GETDATE(), 1, 'City')
,(9, 'AAA0A43', GETDATE(), 1, 'WRV')
,(9, 'AAA0A44', GETDATE(), 1, 'Fit')
,(9, 'AAA0A45', GETDATE(), 1, 'HRV')
,(10, 'AAA0A41',GETDATE(), 1,  'Uno')
,(10, 'AAA0A42',GETDATE(), 1,  'Palio')
,(10, 'AAA0A43',GETDATE(), 1,  'Stilo')
,(10, 'AAA0A44',GETDATE(), 1,  'Chronos')
,(10, 'AAA0A45',GETDATE(), 1,  'Bravo')