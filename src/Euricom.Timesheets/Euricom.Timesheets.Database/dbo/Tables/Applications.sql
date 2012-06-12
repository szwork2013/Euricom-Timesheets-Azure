CREATE TABLE [dbo].[Applications] (
    [ApplicationId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Applications] PRIMARY KEY CLUSTERED ([ApplicationId] ASC)
);

