CREATE TABLE [dbo].[UsersInRoles]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
	[UserId] UNIQUEIDENTIFIER NOT NULL, 
    [RoleId] INT NOT NULL, 
    CONSTRAINT [FK_UsersInRoles_ToRoles] FOREIGN KEY ([RoleId]) REFERENCES [Roles]([Id]), 
    CONSTRAINT [FK_UsersInRoles_ToUsers] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id]),
	PRIMARY KEY ([Id])
)
