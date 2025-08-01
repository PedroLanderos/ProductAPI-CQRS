# 📦 Product API - Microservicio de Gestión de Productos

Este microservicio proporciona una API para realizar operaciones CRUD sobre productos. Está diseñado siguiendo los principios de **Clean Architecture** y el patrón **CQRS (Command Query Responsibility Segregation)**, lo que facilita su mantenimiento, escalabilidad e integración en soluciones basadas en microservicios.

---

## 🧱 Arquitectura

El proyecto sigue la estructura de **Clean Architecture**, separando claramente responsabilidades:

```plaintext
ProductApi/
├── Domain/           
├── Application/      
├── Infrastructure/   
└── Presentation/     
```

Además, aplica el patrón **CQRS**, dividiendo:

- 📤 **Commands** → Escritura (Create, Update, Delete)
- 📥 **Queries** → Lectura (Get, List)


---

## 🛠️ Funcionalidades Disponibles

- ✅ Crear productos
- ✅ Obtener un producto por ID
- ✅ Listar todos los productos
- ✅ Editar un producto
- ✅ Eliminar un producto


---



## 🔌 Integración

Este microservicio puede integrarse fácilmente a cualquier sistema mayor basado en microservicios, gracias a su arquitectura desacoplada. Puedes consumirlo vía HTTP REST o exponerlo detrás de un API Gateway.

---

## 🧰 Requisitos

- .NET 8
- EF Core 
- MediatR para CQRS
- AutoMapper 
- FluentValidation 

---

## 🧑‍💻 Cómo Ejecutar

1. Clona el repositorio o cópialo dentro de tu solución principal
2. Restaura los paquetes:

```bash
dotnet restore
```

3. Ejecuta el proyecto:

```bash
dotnet run --project ProductApi.Presentation
```
