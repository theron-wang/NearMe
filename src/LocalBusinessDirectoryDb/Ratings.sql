CREATE TABLE [dbo].[Ratings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [RelatedTo] VARCHAR(36) NOT NULL, 
    [UserId] INT NOT NULL, 
    [Rating] INT NOT NULL
)
