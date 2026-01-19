# PaymentSolution

Proyecto de ejemplo orientado a **Domain-Driven Design (DDD)** con **CQRS**, **MediatR**, **Event Bus** y **Clean Architecture**, desarrollado en **.NET 8**.

---

## 🚀 Arquitectura del Proyecto

El proyecto está organizado siguiendo buenas prácticas de Clean Architecture:

PaymentSolution/
├── Payment.API → Capa de presentación (Controllers, Program.cs)
├── Payment.Application → Casos de uso, CQRS, DTOs, Handlers
├── Payment.Domain → Entidades, Interfaces, Eventos de Dominio
└── Payment.Infrastructure → Repositorios, Persistencia, EventBus

yaml
Copiar código

---

## 📦 Tecnologías Usadas

- .NET 8
- C# 12
- CQRS
- MediatR (para Commands y Queries)
- Event Bus In-Memory
- Repository Pattern
- Clean Architecture
- Swagger para pruebas

---

## ✨ Características

- **Crear Ordenes** usando Commands
- **Consultar Ordenes** usando Queries
- **Publicar eventos de dominio**
- **Event Handler** para procesar lógica adicional
- **Event Bus In-Memory**
- **Persistencia InMemory**
- Separación estricta entre **Read/Write Models**

---

## 📂 Principales Componentes

| Capa | Responsabilidad |
|---|---|
| `Domain` | Entidades, contratos y eventos |
| `Application` | CQRS (Commands + Queries) y Handlers |
| `Infrastructure` | Implementaciones de repositorios y event bus |
| `API` | Exposición HTTP y Swagger |

---

## 🧪 Cómo Ejecutar el Proyecto

1. Clonar el repositorio:


git clone https://github.com/smartinezpelaez/PaymentSolution.git
Abrir la solución en Visual Studio 2022 o VS Code

Establecer Payment.API como proyecto de inicio

Ejecutar el proyecto con:

Copiar código
dotnet run --project Payment.API
Abrir Swagger en el navegador:

Copiar código
https://localhost:5001/swagger
🔍 Ejemplos de Uso (Swagger)
➕ Crear una Orden
POST /orders

Body:

json
Copiar código
{
  "product": "TV",
  "amount": 1200
}
Respuesta:

json
Copiar código
"e3a2e42f-1373-4c30-8018-21c5b30a5231"
📦 Obtener una Orden
GET /orders/{id}

Respuesta:

json
Copiar código
{
  "id": "e3a2e42f-1373-4c30-8018-21c5b30a5231",
  "product": "TV",
  "amount": 1200
}
📌 Notas Técnicas Importantes
MediatR maneja la comunicación interna entre Commands y Handlers

El Event Bus permite ejecutar lógica adicional sin acoplar el dominio

Los Handlers son independientes entre sí

La persistencia actualmente es In-Memory, ideal para demos

📄 Licencia
Este proyecto se encuentra bajo licencia MIT.

👤 Autor
Creado por Steven Martínez ✨
Ingeniero de Sistemas

markdown
Copiar código

---


