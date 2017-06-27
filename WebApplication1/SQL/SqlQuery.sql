IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Clientes] (
    [ClienteId] int NOT NULL IDENTITY,
    [CPF] nvarchar(max),
    [NomeCliente] nvarchar(max),
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([ClienteId])
);

GO

CREATE TABLE [Pedidos] (
    [PedidoId] int NOT NULL IDENTITY,
    [DataEntrega] datetime2 NOT NULL,
    [NomeCliente] bigint NOT NULL,
    [NumeroPedido] bigint NOT NULL,
    [ValorTotal] decimal(18, 2) NOT NULL,
    CONSTRAINT [PK_Pedidos] PRIMARY KEY ([PedidoId])
);

GO

CREATE TABLE [Produtos] (
    [ProdutoId] int NOT NULL IDENTITY,
    [Descricao] nvarchar(max),
    [Valor] decimal(18, 2) NOT NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([ProdutoId])
);

GO

CREATE TABLE [ItensPedido] (
    [ItemPedidoId] int NOT NULL IDENTITY,
    [PedidoId] int NOT NULL,
    [ProdutoId] int NOT NULL,
    [Quantidade] int NOT NULL,
    [ValorTotal] decimal(18, 2) NOT NULL,
    CONSTRAINT [PK_ItensPedido] PRIMARY KEY ([ItemPedidoId]),
    CONSTRAINT [FK_ItensPedido_Pedidos_PedidoId] FOREIGN KEY ([PedidoId]) REFERENCES [Pedidos] ([PedidoId]) ON DELETE CASCADE,
    CONSTRAINT [FK_ItensPedido_Produtos_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Produtos] ([ProdutoId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_ItensPedido_PedidoId] ON [ItensPedido] ([PedidoId]);

GO

CREATE INDEX [IX_ItensPedido_ProdutoId] ON [ItensPedido] ([ProdutoId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20170627005224_Inicial', N'1.1.2');

GO

