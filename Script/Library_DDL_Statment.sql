GO
CREATE DATABASE Library_;
GO

USE Library_;
GO

SET DATEFORMAT DMY;

-----------------------------------------CREACIÓN DE TABLAS-----------------------------------------
-- TABLAS AUXILIARES

CREATE TABLE provincias (
    id_provincia INT,
    provincia VARCHAR(20) NOT NULL,
    CONSTRAINT pk_provincia PRIMARY KEY(id_provincia));

CREATE TABLE sexos (
    id_sexo INT,
    sexo VARCHAR(10) NOT NULL,
    CONSTRAINT pk_sexo PRIMARY KEY(id_sexo));

CREATE TABLE editoriales (
    id_editorial INT,
    editorial VARCHAR(50) NOT NULL,
    CONSTRAINT pk_editorial PRIMARY KEY (id_editorial));

CREATE TABLE categorias (
    id_categoria INT,
    categoria VARCHAR(50) NOT NULL,
    CONSTRAINT pk_categoria PRIMARY KEY (id_categoria));

CREATE TABLE formas_pagos (
    id_forma_pago INT,
    forma_pago VARCHAR(50) NOT NULL,
    CONSTRAINT pk_forma_pago PRIMARY KEY (id_forma_pago));

CREATE TABLE puntuaciones (
    id_puntuacion INT,
    puntuacion INT NOT NULL,
    CONSTRAINT pk_puntuacion PRIMARY KEY (id_puntuacion));

CREATE TABLE estados_envios (
    id_estado_envio INT,
    estado_actual VARCHAR(20) NOT NULL,
    CONSTRAINT pk_estado_envio PRIMARY KEY (id_estado_envio));

CREATE TABLE formas_envios (
    id_forma_envio INT,
    forma_envio VARCHAR(20) NOT NULL,
    CONSTRAINT pk_forma_envio PRIMARY KEY (id_forma_envio));

CREATE TABLE tipos_documentos (
    id_tipo_doc INT,
    tipo VARCHAR(50) NOT NULL,
    CONSTRAINT pk_tipo_doc PRIMARY KEY(id_tipo_doc));

CREATE TABLE profesiones (
    id_profesion INT,
    profesion VARCHAR(50) NOT NULL,
    CONSTRAINT pk_profesion PRIMARY KEY(id_profesion));

CREATE TABLE generos (
    id_genero INT,
    genero VARCHAR(50) NOT NULL,
    CONSTRAINT pk_genero PRIMARY KEY(id_genero));

CREATE TABLE tipos_contactos (
    id_tipo_contacto INT,
    tipo VARCHAR(20) NOT NULL,
    CONSTRAINT pk_tipo_contacto PRIMARY KEY(id_tipo_contacto));

CREATE TABLE financieras (
    id_financiera INT,
    nombre VARCHAR(20) NOT NULL,
    CONSTRAINT pk_financiera PRIMARY KEY(id_financiera));

CREATE TABLE nacionalidades (
    id_nacionalidad INT,
    nacionalidad VARCHAR(20) NOT NULL,
    CONSTRAINT pk_nacionalidad PRIMARY KEY(id_nacionalidad));

-- TABLAS CON FK

CREATE TABLE ciudades (
    id_ciudad INT,
    ciudad VARCHAR(50) NOT NULL,
    id_provincia INT NOT NULL,
    CONSTRAINT pk_ciudad PRIMARY KEY (id_ciudad),
    CONSTRAINT fk_ciudad_provincia FOREIGN KEY(id_provincia) REFERENCES provincias(id_provincia));

CREATE TABLE barrios (
    id_barrio INT,
    barrio VARCHAR(50) NOT NULL,
    id_ciudad INT NOT NULL,
    CONSTRAINT pk_barrio PRIMARY KEY(id_barrio),
    CONSTRAINT fk_ciudad_barrio FOREIGN KEY(id_ciudad) REFERENCES ciudades(id_ciudad));

CREATE TABLE autores (
    id_autor INT,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    biografia VARCHAR(200),
    fecha_nacimiento DATE,
    id_nacionalidad INT NOT NULL,
    id_sexo INT NOT NULL,
    CONSTRAINT pk_autor PRIMARY KEY (id_autor),
    CONSTRAINT fk_autor_nacionalidad FOREIGN KEY(id_nacionalidad) REFERENCES nacionalidades(id_nacionalidad),
    CONSTRAINT fk_autor_sexo FOREIGN KEY(id_sexo) REFERENCES sexos(id_sexo));

CREATE TABLE clientes (
    cod_cliente INT,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    nro_doc INT NOT NULL,
    contraseña VARCHAR(20) NOT NULL,
    id_tipo_doc INT NOT NULL,
    id_sexo INT NOT NULL,
    id_nacionalidad INT NOT NULL,
    fecha_registro DATETIME NOT NULL,
	fecha_nacimiento DATE,
    CONSTRAINT pk_cliente PRIMARY KEY(cod_cliente),
    CONSTRAINT fk_cliente_tiposdoc FOREIGN KEY(id_tipo_doc) REFERENCES tipos_documentos(id_tipo_doc),
	CONSTRAINT fk_cliente_sexo FOREIGN KEY(id_sexo) REFERENCES sexos(id_sexo),
    CONSTRAINT fk_cliente_nacionalidad FOREIGN KEY(id_nacionalidad) REFERENCES nacionalidades(id_nacionalidad));

CREATE TABLE contactos (
    id_contacto INT,
    contacto VARCHAR(50),
    id_tipo_contacto INT,
    cod_cliente INT,
    CONSTRAINT pk_contacto PRIMARY KEY(id_contacto),
    CONSTRAINT fk_contactos_tipos FOREIGN KEY(id_tipo_contacto) REFERENCES tipos_contactos(id_tipo_contacto),
    CONSTRAINT fk_contactos_clientes FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente));

CREATE TABLE direcciones (
    id_direccion INT,
    calle VARCHAR(50) NOT NULL,
    altura INT NOT NULL,
    piso INT,
    depto VARCHAR(10),
    es_preferida BIT NOT NULL,
    cod_cliente INT NOT NULL,
    id_barrio INT NOT NULL,
    CONSTRAINT pk_direccion PRIMARY KEY(id_direccion),
    CONSTRAINT fk_direcciones_clientes FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente),
    CONSTRAINT fk_direcciones_barrios FOREIGN KEY(id_barrio) REFERENCES barrios(id_barrio));

CREATE TABLE facturas (
    nro_factura INT,
    fecha DATETIME NOT NULL,
    fecha_entrega DATETIME NOT NULL,
    fecha_pago DATETIME NOT NULL,
    cod_cliente INT NOT NULL,
    id_forma_envio INT NOT NULL,
	cp_envio INT NOT NULL,
	costo_envio DECIMAL(10,2)
    CONSTRAINT pk_factura PRIMARY KEY(nro_factura),
    CONSTRAINT fk_facturas_clientes FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente),
    CONSTRAINT fk_facturas_formasenvio FOREIGN KEY(id_forma_envio) REFERENCES formas_envios(id_forma_envio));

CREATE TABLE facturas_formaspago (
    id_factura_pago INT,
    monto_parcial DECIMAL(10,2) NOT NULL,
    id_forma_pago INT NOT NULL,
    nro_factura INT NOT NULL,
    CONSTRAINT pk_facturas_formaspago PRIMARY KEY(id_factura_pago),
    CONSTRAINT fk_facturas_pagos FOREIGN KEY(id_forma_pago) REFERENCES formas_pagos(id_forma_pago),
    CONSTRAINT fk_facturas_factura FOREIGN KEY(nro_factura) REFERENCES facturas(nro_factura));

CREATE TABLE formapagos_clientes (
    id_formapago_cliente INT,
    num_tarjeta INT,
    fecha_vencimiento DATE,
    cvv INT,
    cod_cliente INT NOT NULL,
    id_forma_pago INT NOT NULL,
    id_financiera INT NOT NULL,
    CONSTRAINT pk_formapagos_clientes PRIMARY KEY (id_formapago_cliente),
    CONSTRAINT fk_financieras FOREIGN KEY(id_financiera) REFERENCES financieras(id_financiera),
    CONSTRAINT fk_clientes FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente),
    CONSTRAINT fk_formaspago FOREIGN KEY(id_forma_pago) REFERENCES formas_pagos(id_forma_pago));

CREATE TABLE formasenvios_clientes (
    id_formaenvio_cliente INT,
    es_preferida BIT NOT NULL,
    cod_cliente INT NOT NULL,
    id_forma_envio INT NOT NULL,
    CONSTRAINT pk_formasenvios_clientes PRIMARY KEY(id_formaenvio_cliente),
    CONSTRAINT fk_clientes_formasenvios FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente),
    CONSTRAINT fk_formasenvios_clientes FOREIGN KEY(id_forma_envio) REFERENCES formas_envios(id_forma_envio));

-- Nuevas tablas para guardar idiomas

CREATE TABLE idiomas (
    id_idioma INT,
    idioma VARCHAR(50) NOT NULL,
    CONSTRAINT pk_idioma PRIMARY KEY (id_idioma));

CREATE TABLE clientes_idiomas (
    id_cliente_idioma INT,
    cod_cliente INT NOT NULL,
    id_idioma INT NOT NULL,
    es_preferido BIT DEFAULT 0,
    CONSTRAINT pk_cliente_idioma PRIMARY KEY (id_cliente_idioma),
    CONSTRAINT fk_cliente_idioma_cliente FOREIGN KEY (cod_cliente) REFERENCES clientes(cod_cliente),
    CONSTRAINT fk_cliente_idioma_idioma FOREIGN KEY (id_idioma) REFERENCES idiomas(id_idioma));

CREATE TABLE libros (
    cod_libro INT,
    isbn VARCHAR(50) NOT NULL,
    titulo VARCHAR(50) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    descripcion VARCHAR(200),
    stock INT NOT NULL,
	id_editorial INT NOT NULL,
	fecha_lanzamiento date NOT NULL,
	id_idioma int not null
	CONSTRAINT pk_libro PRIMARY KEY (cod_libro),
    CONSTRAINT fk_libros_editoriales FOREIGN KEY(id_editorial) REFERENCES editoriales(id_editorial),
	CONSTRAINT fk_libros_idiomas FOREIGN KEY(id_idioma) REFERENCES idiomas(id_idioma));

CREATE TABLE libros_generos(
 id_libro_genero int NOT NULL IDENTITY(1,1),
 id_libro int NOT NULL,
 id_genero int NOT NULL,
 constraint Pk_libro_genero primary key (id_libro_genero),
 constraint fk_librosgeneros foreign key (id_libro) references Libros (cod_libro),
 constraint fk_generoslibros foreign key (id_genero) references Generos (id_genero));

CREATE TABLE detalle_facturas (
    id_detalle_factura INT,
    cantidad INT NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    recargo DECIMAL(10,2),
    nro_factura INT NOT NULL,
    cod_libro INT NOT NULL,
    CONSTRAINT pk_detalle_fac PRIMARY KEY (id_detalle_factura),
    CONSTRAINT fk_detalle_factura FOREIGN KEY(nro_factura) REFERENCES facturas(nro_factura),
    CONSTRAINT fk_detalle_libro FOREIGN KEY(cod_libro) REFERENCES libros(cod_libro));

CREATE TABLE pedidos (
    nro_pedido INT,
    fecha DATETIME NOT NULL,
    fecha_entrega DATE NOT NULL,
    instrucciones_adicionales VARCHAR(100),
    cod_cliente INT NOT NULL,
    id_forma_envio INT NOT NULL,
    CONSTRAINT pk_nro_pedido PRIMARY KEY (nro_pedido),
    CONSTRAINT fk_pedidos_clientes FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente),
    CONSTRAINT fk_pedidos_formas FOREIGN KEY(id_forma_envio) REFERENCES formas_envios(id_forma_envio));

CREATE TABLE detalle_pedidos (
    id_detalle_pedido INT,
    cantidad INT NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    cod_libro INT NOT NULL,
    nro_pedido INT NOT NULL,
    CONSTRAINT pk_detalle_pedidos PRIMARY KEY (id_detalle_pedido),
    CONSTRAINT fk_detallepedidos_libros FOREIGN KEY(cod_libro) REFERENCES libros(cod_libro),
    CONSTRAINT fk_detallepedidos_pedido FOREIGN KEY(nro_pedido) REFERENCES pedidos(nro_pedido));

CREATE TABLE resenias_libros (
    id_resenia INT,
    comentario VARCHAR(250) NOT NULL,
    fecha_resenia DATETIME NOT NULL,
    cod_libro INT NOT NULL,
    id_puntuacion INT NOT NULL,
    cod_cliente INT NOT NULL,
    CONSTRAINT pk_resenias PRIMARY KEY (id_resenia),
    CONSTRAINT fk_resenias_libros FOREIGN KEY(cod_libro) REFERENCES libros(cod_libro),
    CONSTRAINT fk_resenias_puntuaciones FOREIGN KEY(id_puntuacion) REFERENCES puntuaciones(id_puntuacion),
    CONSTRAINT fk_resenias_clientes FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente));

-----------------------------------------ACTUALIZACIONES-----------------------------------------
-- Crear tabla tracking_envios
CREATE TABLE tracking_envios (
    id_tracking INT PRIMARY KEY,
    nro_pedido INT NOT NULL,
    id_estado_envio INT NOT NULL,
    fecha_estado DATETIME NOT NULL,
    observaciones VARCHAR(200),
    CONSTRAINT fk_tracking_pedido FOREIGN KEY(nro_pedido) REFERENCES pedidos(nro_pedido),
    CONSTRAINT fk_tracking_estado FOREIGN KEY(id_estado_envio) REFERENCES estados_envios(id_estado_envio));

-- Crear tabla preferencias_clientes
CREATE TABLE preferencias_clientes (
    id_preferencia_cliente INT,
    cod_cliente INT NOT NULL,
    id_genero INT NOT NULL,
    suscribe_newsletter BIT DEFAULT 0
	CONSTRAINT pk_preferencia_cliente PRIMARY KEY(id_preferencia_cliente),
    CONSTRAINT fk_preferencia_cliente FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente),
    CONSTRAINT fk_preferencia_genero FOREIGN KEY(id_genero) REFERENCES generos(id_genero));

-- Crear tabla cupones y su asignación a clientes
CREATE TABLE cupones (
    id_cupon INT PRIMARY KEY,
    codigo VARCHAR(20) NOT NULL UNIQUE,
    descripcion VARCHAR(100),
    descuento_porcentaje DECIMAL(10,2),
    descuento_monto DECIMAL(10,2),
    fecha_vencimiento DATE,
    es_activo BIT NOT NULL);

CREATE TABLE cupones_usuarios (
    id_cupon_usuario INT PRIMARY KEY,
    id_cupon INT NOT NULL,
    cod_cliente INT NOT NULL,
    fecha_usado DATETIME,
    CONSTRAINT fk_cupon_cliente FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente),
    CONSTRAINT fk_cupon_uso FOREIGN KEY(id_cupon) REFERENCES cupones(id_cupon));

-- Tabla nueva para libros en lista de deseos
CREATE TABLE listas_deseos (
    cod_cliente INT,
    cod_libro INT,
    fecha_agregado DATETIME,
    CONSTRAINT pk_lista_deseos PRIMARY KEY (cod_cliente, cod_libro),
    CONSTRAINT fk_listas_deseos_libros FOREIGN KEY(cod_libro) REFERENCES libros(cod_libro),
    CONSTRAINT fk_listas_deseos_clientes FOREIGN KEY(cod_cliente) REFERENCES clientes(cod_cliente));

-- Nuevas tablas intermedias
CREATE TABLE libros_categorias (
id_libro_categoria int NOT NULL,
id_libro int NOT NULL, 
id_categoria int NOT NULL,
CONSTRAINT pk_libro_categoria primary key (id_libro_categoria),
CONSTRAINT fk_libros_categoria foreign key (id_libro) references Libros (cod_libro),
CONSTRAINT fk_categorias_libros foreign key (id_categoria) references Categorias (id_categoria));



 CREATE TABLE autores_libros(
id_autor_libro INT IDENTITY(1,1) PRIMARY KEY,
id_libro int NOT NULL,
id_autor int NOT NULL,
constraint fk_librosAutores foreign key (id_libro) references Libros (cod_libro),
constraint fk_autor foreign key (id_autor) references Autores (id_autor));

CREATE TABLE autores_editoriales (
id_autor_editorial int NOT NULL,
id_autor int NOT NULL, 
id_editorial int NOT NULL,
CONSTRAINT pk_autor_editorial primary key (id_autor_editorial),
CONSTRAINT fk_autores_editoriales foreign key (id_autor) references Autores (id_autor),
CONSTRAINT fk_editoriales_autores foreign key (id_editorial) references Editoriales (id_editorial));


CREATE TABLE clientes_profesiones (
id_cliente_profesion int NOT NULL,
id_profesion int NOT NULL,
id_cliente int NOT NuLL,
constraint pk_cliente_profesion primary key (id_cliente_profesion),
constraint fk_profesion_cliente foreign key (id_profesion) references Profesiones (id_profesion),
constraint fk_cliente_profesion foreign key (id_cliente) references Clientes (cod_cliente));
