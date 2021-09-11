/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


INSERT INTO Color VALUES('RED');
INSERT INTO Color VALUES('ORANGE');
INSERT INTO Color VALUES('YELLOW');
INSERT INTO Color VALUES('GREEN');
INSERT INTO Color VALUES('BLUE');
INSERT INTO Color VALUES('INDIGO');
INSERT INTO Color VALUES('VIOLET');

INSERT INTO Size VALUES('XS');
INSERT INTO Size VALUES('S');
INSERT INTO Size VALUES('M');
INSERT INTO Size VALUES('L');
INSERT INTO Size VALUES('XL');
INSERT INTO Size VALUES('XXL');
INSERT INTO Size VALUES('XXXL');

INSERT INTO Fabric VALUES('WOOL');
INSERT INTO Fabric VALUES('COTTON');
INSERT INTO Fabric VALUES('POLYESTER');
INSERT INTO Fabric VALUES('RAYON');
INSERT INTO Fabric VALUES('LINEN');
INSERT INTO Fabric VALUES('CASHMERE');
INSERT INTO Fabric VALUES('SILK');