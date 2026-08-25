-- ============================================================
-- CRUD PRODUCTOS
-- Datos de prueba
-- ============================================================

-- Seleccionar la base de datos
USE crud_productos;

-- ============================================================
-- INSERTAR 7 PRODUCTOS
-- ============================================================

INSERT INTO productos
    (Nombre, Descripcion, Precio, Stock)
VALUES
    (
        'Laptop Lenovo IdeaPad',
        'Laptop Lenovo con procesador Intel Core i5, 8 GB de RAM y SSD de 512 GB',
        2450000.00,
        15
    ),
    (
        'Mouse Logitech MX Master',
        'Mouse inalámbrico ergonómico para oficina y productividad',
        285000.00,
        25
    ),
    (
        'Teclado Mecánico Redragon',
        'Teclado mecánico RGB con switches para gaming',
        320000.00,
        8
    ),
    (
        'Monitor Samsung 24"',
        'Monitor LED Full HD de 24 pulgadas con conexión HDMI',
        780000.00,
        12
    ),
    (
        'Disco SSD Kingston 1TB',
        'Unidad de almacenamiento SSD de 1 TB SATA III',
        390000.00,
        20
    ),
    (
        'Memoria RAM Kingston 16GB',
        'Memoria RAM DDR4 de 16 GB para computador de escritorio',
        245000.00,
        5
    ),
    (
        'Audífonos Sony WH-1000XM5',
        'Audífonos inalámbricos con cancelación de ruido',
        1450000.00,
        0
    );

-- ============================================================
-- CONSULTAR LOS REGISTROS
-- ============================================================

SELECT
    Id,
    Nombre,
    Descripcion,
    Precio,
    Stock
FROM productos
ORDER BY Id;