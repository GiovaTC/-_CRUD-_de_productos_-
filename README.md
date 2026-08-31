# -_CRUD-_de_productos_- :.

<img width="1254" height="1254" alt="image" src="https://github.com/user-attachments/assets/48d1c8cd-9050-4478-b51d-a26b8e5f9fcc" />

<img width="2505" height="1076" alt="image" src="https://github.com/user-attachments/assets/5af5701d-fbd3-46ca-b862-e94262e7b03c" />    

<img width="2554" height="1074" alt="image" src="https://github.com/user-attachments/assets/6c5b1b4c-e53c-4499-bfcb-d96881437b8a" />    

<img width="2519" height="1079" alt="image" src="https://github.com/user-attachments/assets/22cf63df-0e33-4e0b-b9d9-1030ba75629c" />    

<img width="2558" height="1079" alt="image" src="https://github.com/user-attachments/assets/5879d1f3-6d4f-4f57-a484-5a986d937186" />    

<img width="2549" height="1079" alt="image" src="https://github.com/user-attachments/assets/b26c7a14-14ba-44a4-9b0c-515f670b8d21" />    
    
```

# 🛒 CRUD de Productos:

Aplicación web **CRUD de Productos** desarrollada con **C# y ASP.NET Core MVC**, utilizando **Entity Framework Core**
para la persistencia de información en una base de datos .

La aplicación permitirá realizar las operaciones básicas de administración de productos:

* ➕ Crear productos
* 📋 Listar productos
* ✏️ Editar productos
* 🗑️ Eliminar productos
* 🔍 Ver detalles de un producto
* 💾 Guardar la información en una base de datos

---

## 🛠️ Tecnologías

El proyecto utilizará las siguientes tecnologías:

* **Visual Studio 2026**
* **C#**
* **ASP.NET Core MVC**
* **Entity Framework Core**
* **SQL Server** o **MySQL**
* **Bootstrap**
* **Razor Views**
* **HTML5**
* **CSS3**

---

## 📁 Estructura del proyecto

La estructura aproximada del proyecto será la siguiente:

```text
CRUDProductos/
│
├── Controllers/
│   └── ProductosController.cs
│
├── Models/
│   └── Producto.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Views/
│   ├── Productos/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Details.cshtml
│   │   └── Delete.cshtml
│   │
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _ValidationScriptsPartial.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
│
├── appsettings.json
├── Program.cs
└── CRUDProductos.csproj
```

---

## 📦 Modelo `Producto`

El modelo `Producto` tendrá inicialmente los siguientes campos:

| Campo         | Tipo      | Descripción                      |
| ------------- | --------- | -------------------------------- |
| `Id`          | `int`     | Identificador único del producto |
| `Nombre`      | `string`  | Nombre del producto              |
| `Descripcion` | `string`  | Descripción del producto         |
| `Precio`      | `decimal` | Precio del producto              |
| `Stock`       | `int`     | Cantidad disponible              |

### Ejemplo del modelo

```csharp
public class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string Descripcion { get; set; } = string.Empty;

    public decimal Precio { get; set; }

    public int Stock { get; set; }
}
```

---

## 🗄️ Base de datos

El proyecto podrá trabajar con cualquiera de las siguientes alternativas:

### Opción 1: SQL Server

Se puede utilizar:

* SQL Server
* SQL Server Express
* SQL Server LocalDB

Esta opción permite trabajar directamente con las herramientas disponibles en el ecosistema de Visual Studio.

### Opción 2: MySQL

También es posible utilizar:

* MySQL 8
* MySQL Workbench
* XAMPP / MariaDB

Esta opción resulta especialmente interesante si ya se tiene experiencia trabajando con proyectos **C# + MySQL**.

---

## ⭐ Recomendación

Para realizar el proyecto paso a paso y facilitar su ejecución en **Visual Studio 2026**, se puede utilizar inicialmente:

```text
ASP.NET Core MVC
        +
C#
        +
Entity Framework Core
        +
SQL Server LocalDB
```

Con esta configuración será posible desarrollar y probar todas las operaciones CRUD desde el navegador.

---

## 🌐 Acceso a la aplicación

Una vez ejecutado el proyecto, se podrá acceder a la sección de productos mediante una dirección similar a:

```text
https://localhost:xxxx/Productos
```

o:

```text
http://localhost:xxxx/Productos
```

El número de puerto (`xxxx`) dependerá de la configuración generada por Visual Studio.

---

## 🔄 Operaciones CRUD

La aplicación contará con las siguientes operaciones:

### ➕ Crear

Permite registrar un nuevo producto proporcionando:

* Nombre
* Descripción
* Precio
* Stock

### 📋 Listar

Muestra todos los productos registrados en la base de datos.

### 🔍 Detalles

Permite consultar la información completa de un producto.

### ✏️ Editar

Permite modificar la información de un producto existente.

### 🗑️ Eliminar

Permite eliminar un producto de la base de datos.

---

## 🧩 Componentes principales

El proyecto estará compuesto por los siguientes elementos:

### 1. Modelo

Archivo:

```text
Models/Producto.cs
```

Representará la entidad `Producto`.

### 2. Contexto de Entity Framework Core

Archivo:

```text
Data/ApplicationDbContext.cs
```

Será responsable de establecer la comunicación entre la aplicación y la base de datos.

### 3. Controlador

Archivo:

```text
Controllers/ProductosController.cs
```

Gestionará las operaciones CRUD:

```text
Index
Create
Details
Edit
Delete
```

### 4. Vistas Razor

Las vistas estarán ubicadas en:

```text
Views/Productos/
```

Y serán:

```text
Index.cshtml
Create.cshtml
Details.cshtml
Edit.cshtml
Delete.cshtml
```

### 5. Configuración

La cadena de conexión se almacenará en:

```text
appsettings.json
```

---

## 📚 Desarrollo del proyecto

El proyecto completo se puede construir paso a paso siguiendo este orden:

1. Crear el proyecto en Visual Studio 2026.
2. Seleccionar **ASP.NET Core Web App (Model-View-Controller)**.
3. Configurar el proyecto con **C#**.
4. Instalar los paquetes NuGet necesarios.
5. Crear el modelo `Producto`.
6. Crear `ApplicationDbContext`.
7. Configurar la conexión con la base de datos.
8. Crear la migración de Entity Framework Core.
9. Crear la base de datos.
10. Crear `ProductosController`.
11. Crear las vistas Razor.
12. Integrar Bootstrap.
13. Ejecutar la aplicación.
14. Probar las operaciones CRUD.

---

## 📦 Paquetes NuGet

Para Entity Framework Core se necesitarán los paquetes correspondientes al proveedor de base de datos seleccionado.

Para **SQL Server**, por ejemplo:

```text
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

Para **MySQL** se utilizará el proveedor compatible con Entity Framework Core correspondiente a la versión del proyecto.

---

## 🗂️ Migraciones

Una vez configurado `ApplicationDbContext`, se podrán crear las migraciones de Entity Framework Core.

Ejemplo:

```powershell
Add-Migration InitialCreate
```

Posteriormente:

```powershell
Update-Database
```

Esto permitirá crear las tablas correspondientes en la base de datos.

---

## 🧪 Prueba del CRUD

Una vez iniciada la aplicación, se podrá acceder a:

```text
/Productos
```

Desde allí será posible:

```text
┌───────────────────────────────┐
│       LISTADO PRODUCTOS       │
├───────────────────────────────┤
│ ID │ Nombre │ Precio │ Stock  │
├───────────────────────────────┤
│ 1  │ Laptop │ 2500000│   10   │
│ 2  │ Mouse  │   80000│   25   │
└───────────────────────────────┘

[Crear producto]
[Ver] [Editar] [Eliminar]
```

---

## 🚀 Proyecto completo

El proyecto completo puede generarse **archivo por archivo**, incluyendo:

1. Creación del proyecto en Visual Studio 2026.
2. Instalación de paquetes NuGet.
3. Modelo `Producto`.
4. `ApplicationDbContext`.
5. Configuración de la base de datos.
6. `ProductosController`.
7. Vista `Index.cshtml`.
8. Vista `Create.cshtml`.
9. Vista `Edit.cshtml`.
10. Vista `Details.cshtml`.
11. Vista `Delete.cshtml`.
12. `Program.cs`.
13. `appsettings.json`.
14. Configuración de Bootstrap.
15. Migraciones de Entity Framework Core.
16. Script SQL para la base de datos, si se utiliza MySQL.
17. Instrucciones para ejecutar el proyecto.
18. Instrucciones para probar todas las operaciones CRUD.

---

## ⭐ Recomendación final

Para este proyecto se recomienda utilizar:

```text
Visual Studio 2026
        │
        ▼
C# / ASP.NET Core MVC
        │
        ▼
Entity Framework Core
        │
        ▼
MySQL
        │
        ▼
CRUD de Productos
```

La opción **MySQL** resulta conveniente para continuar con la experiencia adquirida en proyectos anteriores utilizando esta base de datos.

---

## 📌 Resultado esperado

Al finalizar el proyecto se tendrá una aplicación web funcional que permitirá administrar productos mediante una interfaz gráfica:

```text
                 CRUD PRODUCTOS
                       │
        ┌──────────────┼──────────────┐
        ▼              ▼              ▼
      CREAR          LISTAR          BUSCAR
        │              │              │
        └──────────────┼──────────────┘
                       ▼
                    EDITAR
                       │
                       ▼
                   ELIMINAR
                       │
                       ▼
                  BASE DE DATOS
```

**Tecnologías principales:**

```text
C#
ASP.NET Core MVC
Entity Framework Core
MySQL
Bootstrap
Visual Studio 2026
```
:. . / .
