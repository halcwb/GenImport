USE GenImport


IF (OBJECT_ID('dbo.BST715T_Generieke_samenstellingen') IS NOT NULL)
BEGIN
	DROP TABLE dbo.BST715T_Generieke_samenstellingen
END
GO

IF (OBJECT_ID('dbo.BST750T_Generieke_namen') IS NOT NULL)
BEGIN
	DROP TABLE dbo.BST750T_Generieke_namen
END
GO

SELECT
	btgn.GeneriekeNaamKode_GNK_GNGNK,
	btgn.Generieke_naam_GNGNAM INTO dbo.BST750T_Generieke_namen
FROM GStandDb.dbo.BST750T_Generieke_namen btgn
WHERE NOT btgn.Mutatiekode_MUTKOD = '1'

ALTER TABLE dbo.BST750T_Generieke_namen
ALTER COLUMN GeneriekeNaamKode_GNK_GNGNK varchar(6) NOT NULL


ALTER TABLE dbo.BST750T_Generieke_namen ADD CONSTRAINT PK_BST750T_Generieke_namen PRIMARY KEY (GeneriekeNaamKode_GNK_GNGNK)

SELECT
	*
FROM dbo.BST750T_Generieke_namen

SELECT DISTINCT
	btgs.GSK_code_GSKODE,
	btgs.Volledige_generieke_naam_kode_GNNKPK INTO dbo.BST715T_Generieke_samenstellingen
FROM GStandDb.dbo.BST715T_Generieke_samenstellingen btgs
JOIN BST750T_Generieke_namen btgn ON btgn.GeneriekeNaamKode_GNK_GNGNK = btgs.Volledige_generieke_naam_kode_GNNKPK
WHERE btgs.Mutatiekode_MUTKOD != '1'

ALTER TABLE dbo.BST715T_Generieke_samenstellingen
ALTER COLUMN Volledige_generieke_naam_kode_GNNKPK varchar(6) NOT NULL

ALTER TABLE dbo.BST715T_Generieke_samenstellingen
ALTER COLUMN GSK_code_GSKODE varchar(8) NOT NULL

ALTER TABLE dbo.BST715T_Generieke_samenstellingen WITH CHECK ADD CONSTRAINT PK__BST715T_Generieke_samenstellingen 
PRIMARY KEY (GSK_code_GSKODE, Volledige_generieke_naam_kode_GNNKPK) 

ALTER TABLE dbo.BST715T_Generieke_samenstellingen WITH CHECK ADD CONSTRAINT FK_BST750T_Generieke_namen 
FOREIGN KEY (Volledige_generieke_naam_kode_GNNKPK) REFERENCES dbo.BST750T_Generieke_namen (GeneriekeNaamKode_GNK_GNGNK)

SELECT
	*
FROM dbo.BST715T_Generieke_samenstellingen


IF (OBJECT_ID('dbo.Product') IS NOT NULL)
BEGIN
	DROP TABLE dbo.Product
END
GO

SELECT TOP (100)
	zi.ZI_nummer_ATKODE,
	zi.Artikelnaamnummer_ATNMNR INTO dbo.Product
FROM GStandDb.dbo.BST004T_Artikelen zi
JOIN GStandDb.dbo.BST031T_Handelsproducten bth
	ON bth.HandelsProduktKode_HPK_HPKODE = zi.HandelsProduktKode_HPK_HPKODE
JOIN GStandDb.dbo.BST051T_Voorschrijfpr_geneesmiddel_identific btvgi
	ON btvgi.PRK_code_PRKODE = bth.PRK_code_PRKODE
JOIN GStandDb.dbo.BST711T_Generieke_producten btgp
	ON btvgi.Generiekeproductcode_GPK_GPKODE = btgp.Generiekeproductcode_GPK_GPKODE

SELECT
	*
FROM dbo.Product