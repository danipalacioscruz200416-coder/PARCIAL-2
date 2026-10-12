CREATE DATABASE TiendaParcialDB;
GO

USE TiendaParcialDB;
GO

CREATE TABLE Productos (
    id_producto INT IDENTITY(1,1) PRIMARY KEY,
    producto VARCHAR(100) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    precio DECIMAL(18,2) NOT NULL,
    existencia INT NOT NULL
);

USE TiendaParcialDB;
GO

INSERT INTO Productos (producto, categoria, precio, existencia) VALUES 
('Laptop Acer', 'Tecnologia', 750.00, 10),
('Mouse Inalambrico', 'Accesorios', 25.50, 25),
('Teclado Mecanico', 'Accesorios', 45.00, 15);
GO