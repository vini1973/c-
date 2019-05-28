CREATE TABLE [dbo].[Table]
(
	[ContactID] INT NOT NULL , 
    [Name] VARCHAR(50) NULL, 
    [Email] NCHAR(10) NULL, 
    [Endereco] NCHAR(10) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([ContactID])
)
