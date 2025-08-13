
DROP TABLE IF EXISTS [Leje];
DROP TABLE IF EXISTS [Kunde];
DROP TABLE IF EXISTS [Bil];
GO

CREATE TABLE [Kunde] (
    [Id]        INT           NOT NULL,
    [Navn]      NVARCHAR (50) NOT NULL,
    [Telefon]   INT           NOT NULL,
    [VIP]       BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [Kunde] VALUES (1, N'Anne', 12341234, 0)
INSERT INTO [Kunde] VALUES (2, N'Bent', 11223344, 1)
INSERT INTO [Kunde] VALUES (3, N'Carl', 13572468, 0)
INSERT INTO [Kunde] VALUES (4, N'Dina', 86427531, 1)
INSERT INTO [Kunde] VALUES (5, N'Erik', 65544332, 1)


CREATE TABLE [Bil] (
    [Id]            INT           NOT NULL,
    [Nummerplade]   NVARCHAR (50) NOT NULL,
    [Model]         NVARCHAR (50) NOT NULL,
    [PrisPrDag]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [Bil] VALUES (1, N'AX 32109', N'Skoda Octavia', 450)
INSERT INTO [Bil] VALUES (2, N'BK 88662', N'BMW 318i', 550)
INSERT INTO [Bil] VALUES (3, N'CJ 33801', N'Hyundai IONIQ 6', 600)
INSERT INTO [Bil] VALUES (4, N'DE 22519', N'Skoda Fabia', 380)
INSERT INTO [Bil] VALUES (5, N'EQ 40912', N'Peugeot 208', 430)


CREATE TABLE [Leje] (
    [Id]            INT           NOT NULL,
    [KundeId]       INT           NOT NULL,
    [BilId]         INT           NOT NULL,
    [Dato]          DATE          NOT NULL,
    [AntalDage]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_KundeId] FOREIGN KEY ([KundeId]) REFERENCES [Kunde] ([Id]),
    CONSTRAINT [FK_BilId] FOREIGN KEY ([BilId]) REFERENCES [Bil] ([Id])
);

INSERT INTO [Leje] VALUES (1, 1, 2, '2025-02-17', 3)
INSERT INTO [Leje] VALUES (2, 1, 4, '2025-02-22', 4)
INSERT INTO [Leje] VALUES (3, 2, 1, '2025-03-02', 8)
INSERT INTO [Leje] VALUES (4, 3, 2, '2025-02-04', 6)
INSERT INTO [Leje] VALUES (5, 3, 3, '2025-02-11', 6)
INSERT INTO [Leje] VALUES (6, 3, 1, '2025-03-18', 7)
INSERT INTO [Leje] VALUES (7, 5, 2, '2025-03-02', 3)
INSERT INTO [Leje] VALUES (8, 5, 4, '2025-03-21', 3)
