CREATE TABLE [dbo].[product]
(
	[Id] INT NOT NULL  IDENTITY(1,1) PRIMARY KEY, 
    [product_name] VARCHAR(50) NOT NULL, 
    [product_price] INT NOT NULL, 
    [product_quantity] INT NOT NULL, 
    [product_mfc_date] DATE NULL, 
    [product_exp_date] DATE NULL 
)
