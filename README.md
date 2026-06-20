# Sistema de Boletería UNED

## Descripción General

Sistema de escritorio desarrollado en **C# .NET 8 WinForms** para la administración y venta de entradas de eventos deportivos.

La aplicación permite gestionar clientes, vendedores, partidos, localidades, disponibilidad de boletos y ventas, implementando una arquitectura por capas que separa claramente la interfaz de usuario, la lógica de negocio, el acceso a datos y las entidades del dominio.

---

# Objetivos del Proyecto

* Administrar clientes y vendedores.
* Gestionar partidos deportivos.
* Gestionar localidades y disponibilidad.
* Registrar ventas de entradas.
* Aplicar validaciones de negocio centralizadas.
* Mantener una arquitectura escalable y mantenible.

---

# Arquitectura

```text
┌─────────────────────────┐
│      Presentación       │
├─────────────────────────┤
│    Lógica de Negocio    │
├─────────────────────────┤
│      Acceso a Datos     │
├─────────────────────────┤
│        Entidades        │
└─────────────────────────┘
```

---

# Estructura del Proyecto

```text
SistemaBoleteriaUNED
│
├── Entidades
│   ├── Persona
│   ├── Cliente
│   ├── Vendedor
│   ├── Partido
│   ├── Localidad
│   ├── LocalidadPorPartido
│   └── Venta
│
├── AccesoDatos
│   ├── DatosSistema
│   ├── GestorClientes
│   ├── GestorVendedores
│   ├── GestorPartidos
│   ├── GestorLocalidades
│   ├── GestorLocalidadesPorPartido
│   └── GestorVentas
│
├── LogicaNegocio
│   ├── Servicios
│   └── Mensajes
│
└── Presentacion
    ├── Gestiones
    ├── Consultas
    └── Operaciones
```

---

# Modelo de Dominio

## Persona

Clase base para las entidades que representan personas.

### Propiedades

* Id
* Identificacion
* Nombre
* Apellido
* FechaNacimiento

## Cliente

Hereda de Persona.

### Propiedades Adicionales

* FechaRegistro
* Activo

## Vendedor

Hereda de Persona.

### Propiedades Adicionales

* FechaIngreso

## Partido

Representa un evento deportivo.

### Propiedades

* IdPartido
* Rival
* Fecha
* Hora
* Activo

## Localidad

Representa una zona del estadio.

### Propiedades

* IdLocalidad
* NombreLocalidad
* Precio

## LocalidadPorPartido

Asocia una localidad con un partido específico.

### Propiedades

* Partido
* Localidad
* CantidadDisponible

## Venta

Representa una transacción de venta.

### Propiedades

* IdVenta
* Cliente
* Vendedor
* Partido
* Localidad
* LocalidadPorPartido
* Cantidad
* FechaVenta
* Total

---

# Acceso a Datos

## DatosSistema

Clase estática responsable de almacenar toda la información del sistema en memoria durante la ejecución de la aplicación.

### Colecciones

* Clientes
* Vendedores
* Partidos
* Localidades
* LocalidadesPorPartido
* Ventas

## Gestores

Cada entidad posee un gestor especializado para administrar las operaciones CRUD y consultas.

### Gestores Implementados

* GestorClientes
* GestorVendedores
* GestorPartidos
* GestorLocalidades
* GestorLocalidadesPorPartido
* GestorVentas

---

# Lógica de Negocio

La capa de negocio encapsula las reglas y validaciones del sistema.

## Servicios

* ServicioCliente
* ServicioVendedor
* ServicioPartido
* ServicioLocalidad
* ServicioLocalidadPorPartido
* ServicioVenta

## Responsabilidades Principales

### ServicioLocalidadPorPartido

* Validar existencia de Partido.
* Validar existencia de Localidad.
* Evitar duplicados.

### ServicioVenta

* Validar disponibilidad.
* Calcular total.
* Registrar venta.
* Actualizar inventario disponible.

---

# Mensajes Centralizados

La aplicación utiliza clases de mensajes centralizados para:

* Mensajes de éxito.
* Mensajes de error.
* Confirmaciones.
* Validaciones.

Esto facilita el mantenimiento y evita duplicación de textos.

---

# Interfaz de Usuario

## Gestiones

Formularios utilizados para registrar información.

### Formularios

* FrmClientes
* FrmVendedores
* FrmPartidos
* FrmLocalidades
* FrmLocalidadPorPartido

## Consultas

Formularios utilizados para visualizar y buscar información.

### Características

* Carga automática de datos.
* Búsqueda por identificador.
* Búsqueda por atributos.
* Scroll horizontal.
* Ajuste automático de columnas.

### Formularios

* FrmConsultarClientes
* FrmConsultarVendedores
* FrmConsultarPartidos
* FrmConsultarLocalidades
* FrmConsultarLocalidadPorPartido
* FrmConsultarVentas

## Operaciones

### FrmVentaDeEntradas

Permite:

1. Seleccionar cliente.
2. Seleccionar vendedor.
3. Seleccionar partido.
4. Seleccionar localidad.
5. Validar disponibilidad.
6. Calcular total.
7. Registrar venta.
8. Actualizar existencias.

---

# Flujo de Venta

```text
Cliente
    ↓
Seleccionar Partido
    ↓
Seleccionar Localidad
    ↓
Validar Disponibilidad
    ↓
Calcular Total
    ↓
Registrar Venta
    ↓
Actualizar Existencias
```

---

# Características UX/UI

* Navegación consistente entre formularios.
* Botón de retorno al menú principal.
* Mensajes claros para el usuario.
* Combos con formato "Id - Nombre".
* Consultas con filtros de búsqueda.
* Visualización optimizada de tablas.

---

# Tecnologías Utilizadas

* C#
* .NET 8
* Windows Forms
* Programación Orientada a Objetos

---

# Principios de Diseño

* Arquitectura por capas.
* Separación de responsabilidades.
* Encapsulamiento.
* Reutilización de código.
* Centralización de mensajes.
* Persistencia compartida mediante DatosSistema.

---

# Mejoras Futuras

* Persistencia en SQL Server.
* Patrón Repository.
* Inyección de Dependencias.
* Exportación a Excel y PDF.
* Pruebas unitarias.
* API REST.
* Control de usuarios y roles.

---

# Autor

**Norvin Martinez**
QA Engineer | Software Developer

Proyecto académico desarrollado utilizando C# .NET 8 WinForms para la gestión de boletería deportiva.
