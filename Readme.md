# Library Manager - App 📚

**LibreStore Manager** es una solución integral de escritorio diseñada para optimizar la administración de inventarios y el análisis de rendimiento comercial en librerías. La aplicación permite un control riguroso de activos (libros, autores, editoriales) y proporciona herramientas avanzadas de inteligencia de negocios para la toma de decisiones.

## ✨ Características Principales

### 🛠️ Gestión Operativa (ABMC)
Módulos completos para el alta, baja, modificación y consulta de entidades principales con filtros dinámicos integrados:
* **Catálogo de Libros:** Control de stock y metadatos detallados.
* **Directorio de Autores:** Gestión biográfica y vinculación de obras.
* **Registro de Editoriales:** Administración de proveedores y sellos.
* **Visualización Detallada:** Botón de inspección profunda para registros específicos en tablas de consulta.
## 🛠️ Especificaciones Técnicas y Arquitectura

Para este proyecto, se implementaron estándares de desarrollo modernos que garantizan escalabilidad y mantenimiento:

* **Arquitectura en Capas:** Separación clara de responsabilidades entre Presentación, Aplicación (Servicios), Dominio e Infraestructura.
* **Patrón de Diseño DTO (Data Transfer Objects):** Implementado para desacoplar las entidades de la base de datos de las capas superiores, asegurando una transferencia de datos eficiente y segura.
* **Diseño de Base de Datos Normalizada:** Modelo relacional optimizado en SQL Server para eliminar redundancias y garantizar la integridad referencial de los datos.
* **Programación Orientada a Interfaces:** Uso de interfaces para definir contratos en la capa de servicios y repositorios, facilitando el testing y la extensibilidad del sistema.
* **Validaciones Robustas:** Motor de validación personalizado en formularios para garantizar que los datos ingresados (fechas, importes, campos obligatorios) cumplan con las reglas de negocio antes de su procesamiento.
### 📊 Análisis de Datos y Business Intelligence
* **Reporte de Ventas Realizadas:** Consultas avanzadas con filtros por rango de fecha, nombre/apellido del cliente, montos mínimos/máximos y medios de pago (Billetera Virtual, Tarjetas, Transferencias).
* **Gestión de Reabastecimiento:** Filtro inteligente por género literario y título para identificar necesidades de stock.
* **Sistema de Recomendaciones:** Algoritmo de filtrado por precio, género y fecha de publicación para sugerencias estratégicas.

## 🚀 Tecnologías Utilizadas
* **Lenguaje:** C# 
* **Framework:** .NET Framework
* **Interfaz:** Windows Forms (WinForms)
* **Base de Datos:** SQL Server
* **Arquitectura:** Diseño en capas (Presentation, Domain, Infrastructure, Application)

## 📸 Vista Previa
![Main Menu](Library_WinForms/Properties/Resources/library_background.png) 
*(Sugerencia: Puedes agregar capturas de pantalla de tus formularios aquí)*

## 🛠️ Instalación y Configuración
1. Clonar el repositorio: 
   `git clone git@github-personal:bosque-juan/Library_WinForms.git`
2. Abrir la solución `Library_WinForms.sln` en Visual Studio.
3. Ejecutar el script SQL adjunto en la carpeta `/Script` para inicializar la base de datos `Library_`.
4. Ajustar la cadena de conexión en el `App.config`.

---
Desarrollado por [Juan Bosque](https://github.com/bosque-juan)

APPLICACIÓN DE ESCRITORIO

TECNOLOGIAS UTILIZADAS WINDOWS FORMS, C#, .NET FRAMEWORK

DESCRIPCIÓN
Esta aplicación cuenta con un menú incial, con una imagen de background
agradable a la vista, con pestañas de navegación para: 
	- Salir de la aplicación.
	- Gestionar altas, bajas, modificaciones y consultas de: 
					- Libros, Editoriales y Autores(pudiendo aplicar filtros de búsqueda en todos los casos).
	                - Agregar, Modifiar y Eliminar registros de Libros, Editoriales y Autores.
	                - Boton de ver para ver en detalle de una fila seleccionada en las tablas de consultas.
    - Analizar Datos 
	                - Sobre ventas realizadas con filtros dinámicos respecto al cliente(nombre/apellido) a la
					  Fecha(rango), medio de pago y un rango de importe de venta
					  para consultas sobre Ventas Realizadas. Ornemiento asc/desc para fecha y monto.
					- Consultar el Stock de libros para ser reabastecidos con filtro por genero y título de libro.
					- Libros Recomendados con filtros por precio, genero literario y  rango de fecha de publicación 
### 🗄️ Modelo de Datos
Se diseñó un esquema relacional normalizado para garantizar la integridad y eficiencia:

![Diagrama de Base de Datos](ruta/a/tu/imagen_diagrama.png)

## 📸 Capturas de Pantalla

### Gestión (ABMC)
Módulos de administración de libros y autores.
![Pantalla de Libros](ruta/imagen_libros.png)

### Análisis y Reportes
Interfaz del reporte de ventas con filtros dinámicos.
![Pantalla de Ventas](ruta/imagen_ventas.png)