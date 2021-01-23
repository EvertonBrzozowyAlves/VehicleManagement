USE [VehicleManagement]
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Vehicles' and xtype='U')
	BEGIN
		CREATE TABLE Vehicles (
			VehicleId INT PRIMARY KEY IDENTITY (1, 1),
			IsActive BIT DEFAULT(1) NOT NULL,
			RegisterDate DATETIME DEFAULT(GETDATE()) NOT NULL,
			Plate NVARCHAR(7) NOT NULL,
			Model NVARCHAR(MAX) NOT NULL,
			ManufacturerId INT NOT NULL
		)
	END
GO

INSERT INTO [Vehicles](ManufacturerId, Plate, Model) VALUES 
 (1,	'AAA0A00',	'T-Cross')
,(1,	'AAA0A01',	'Gol')
,(1,	'AAA0A02',	'Polo')
,(1,	'AAA0A04',	'Virtus')
,(1,	'AAA0A05',	'Fox')
,(2,	'AAA0A06',	'Yaris')
,(2,	'AAA0A07',	'Corolla')
,(2,	'AAA0A08',	'Hilux')
,(2,	'AAA0A09',	'RAV4')
,(2,	'AAA0A10',	'Etios')
,(3,	'AAA0A11',	'Logan')
,(3,	'AAA0A12',	'Sandero')
,(3,	'AAA0A13',	'Stepway')
,(3,	'AAA0A14',	'Kwid')
,(3,	'AAA0A15',	'Fluence')
,(4,	'AAA0A16',	'Kicks')
,(4,	'AAA0A17',	'Titan')
,(4,	'AAA0A18',	'Versa')
,(4,	'AAA0A19',	'Tiida')
,(4,	'AAA0A20',	'Maxima')
,(5,	'AAA0A21',	'Lancer')
,(5,	'AAA0A22',	'Outlander')
,(5,	'AAA0A23',	'Eclipse')
,(5,	'AAA0A24',	'Pajero')
,(5,	'AAA0A25',	'Asx')
,(6,	'AAA0A26',	'Onix')
,(6,	'AAA0A27',	'Cruze')
,(6,	'AAA0A28',	'Spin')
,(6,	'AAA0A29',	'Tracker')
,(6,	'AAA0A30',	'TrailBlazer')
,(7,	'AAA0A31',	'HB20')
,(7,	'AAA0A32',	'I30')
,(7,	'AAA0A33',	'Creta')
,(7,	'AAA0A34',	'Elantra')
,(7,	'AAA0A35',	'Tucson')
,(8,	'AAA0A36',	'Ka')
,(8,	'AAA0A37',	'Fusion')
,(8,	'AAA0A38',	'Focus')
,(8,	'AAA0A39',	'Fiesta')
,(8,	'AAA0A40',	'Ecosport')
,(9,	'AAA0A41',	'Civic')
,(9,	'AAA0A42',	'City')
,(9,	'AAA0A43',	'WRV')
,(9,	'AAA0A44',	'Fit')
,(9,	'AAA0A45',	'HRV')
,(10,	'AAA0A41',	'Uno')
,(10,	'AAA0A42',	'Palio')
,(10,	'AAA0A43',	'Stilo')
,(10,	'AAA0A44',	'Chronos')
,(10,	'AAA0A45',	'Bravo')