CREATE DATABASE SistemaVendas;
GO

USE SistemaVendas;
GO

CREATE TABLE tb_categoria (
    ID_CATEGORIA INT IDENTITY(1,1) PRIMARY KEY,
    NM_CATEGORIA NVARCHAR(100) NOT NULL
);

INSERT INTO tb_categoria (NM_CATEGORIA)
VALUES 
('Eletrônicos'),
('Informática'),
('Acessórios');

select * from tb_categoria;