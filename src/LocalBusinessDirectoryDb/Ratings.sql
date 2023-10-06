CREATE TABLE [dbo].[Ratings]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [RelatedTo] VARCHAR(36) NOT NULL, 
    [UserId] INT NOT NULL, 
    [Rating] INT NOT NULL
)
