CREATE DATABASE ADMI
USE ADMI
CREATE TABLE ADMINISTRACION(
USEER VARCHAR(25) PRIMARY KEY NOT NULL,
CONTRASEŅA VARCHAR(25),
ROL VARCHAR(25),
NOMBRE VARCHAR(25),
APELLIDO VARCHAR(25),
DPI INT NOT NULL
)
INSERT ADMINISTRACION VALUES
(
'Sebss10','Sebas123','Administrador', 'Sebastian', 'Hernandez', 12893893
)
INSERT ADMINISTRACION VALUES
(
'Lilipapitas','Lili123','Administrador', 'Lili', 'Lopez', 21893893
)
INSERT ADMINISTRACION VALUES
(
'Rodriguti8','Rodri10','Usuario', 'Rodrigo', 'Gutierrez', 311893893
)

INSERT ADMINISTRACION VALUES
(
'Jaredguti','Jaredg','Usuario', 'Jared', 'Gutierrez', 411893893
)

INSERT ADMINISTRACION VALUES
(
'Brunis17','Bruno123','Secretaria', 'Bruno', 'Hernandez', 512893893
)




