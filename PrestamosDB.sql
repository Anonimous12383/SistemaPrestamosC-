CREATE DATABASE PrestamosDB;
GO
USE PrestamosDB;
GO

CREATE TABLE Clientes(
    ClienteId INT IDENTITY PRIMARY KEY,
    NombreCompleto VARCHAR(120) NOT NULL,
    Correo VARCHAR(120) NOT NULL,
    Telefono VARCHAR(30) NOT NULL,
    Direccion VARCHAR(200) NOT NULL,
    Garantia VARCHAR(200) NOT NULL,
    SueldoMensual DECIMAL(18,2) NOT NULL
);

CREATE TABLE Prestamos(
    PrestamoId INT IDENTITY PRIMARY KEY,
    ClienteId INT NOT NULL,
    Capital DECIMAL(18,2) NOT NULL,
    PlazoMeses INT NOT NULL,
    TasaAnual DECIMAL(10,4) NOT NULL,
    Cuota DECIMAL(18,2) NOT NULL,
    FechaInicio DATE NOT NULL,
    Estado VARCHAR(20) NOT NULL,
    FOREIGN KEY (ClienteId) REFERENCES Clientes(ClienteId)
);

CREATE TABLE Pagos(
    PagoId INT IDENTITY PRIMARY KEY,
    PrestamoId INT NOT NULL,
    MesNumero INT NOT NULL,
    FechaPago DATE NULL,
    MontoCuota DECIMAL(18,2) NOT NULL,
    InteresPagado DECIMAL(18,2) NOT NULL,
    CapitalPagado DECIMAL(18,2) NOT NULL,
    Mora DECIMAL(18,2) NOT NULL,
    SaldoAnterior DECIMAL(18,2) NOT NULL,
    SaldoNuevo DECIMAL(18,2) NOT NULL,
    Pagado BIT NOT NULL,
    FOREIGN KEY (PrestamoId) REFERENCES Prestamos(PrestamoId)
);

CREATE TABLE Fondo(
    FondoId INT PRIMARY KEY,
    MontoDisponible DECIMAL(18,2) NOT NULL
);

INSERT INTO Fondo(FondoId, MontoDisponible) VALUES(1, 5000000);
