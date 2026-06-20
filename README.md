# Sistema de Boletería UNED

## Descripción General

Sistema de escritorio desarrollado en **C# .NET 8 WinForms** para la administración y venta de entradas de eventos deportivos.

La aplicación permite gestionar clientes, vendedores, partidos, localidades, disponibilidad de boletos y ventas, aplicando una arquitectura por capas que separa la interfaz de usuario, la lógica de negocio, el acceso a datos y las entidades del dominio.

---

## Objetivos del Proyecto

- Administrar clientes y vendedores.
- Gestionar partidos deportivos.
- Registrar localidades del estadio.
- Asignar localidades disponibles por partido.
- Registrar ventas de entradas.
- Validar disponibilidad antes de vender.
- Calcular automáticamente el total de cada venta.
- Mantener una estructura clara, mantenible y escalable.

---

## Arquitectura General

El sistema está organizado en cuatro capas principales:

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

### Presentación

Contiene los formularios WinForms utilizados por el usuario para registrar, consultar y operar información.

### Lógica de Negocio

Contiene los servicios responsables de validar reglas del sistema, coordinar operaciones y centralizar mensajes.

### Acceso a Datos

Contiene los gestores encargados de registrar, consultar y modificar la información almacenada en memoria.

### Entidades

Contiene las clases del dominio del sistema.

---

## Estructura del Proyecto

```text
SistemaBoleteriaUNED
│
├── Entidades
│   ├── Persona.cs
│   ├── Cliente.cs
│   ├── Vendedor.cs
│   ├── Partido.cs
│   ├── Localidad.cs
│   ├── LocalidadPorPartido.cs
│   └── Venta.cs
│
├── AccesoDatos
│   ├── DatosSistema.cs
│   ├── GestorClientes.cs
│   ├── GestorVendedores.cs
│   ├── GestorPartidos.cs
│   ├── GestorLocalidades.cs
│   ├── GestorLocalidadesPorPartido.cs
│   └── GestorVentas.cs
│
├── LogicaNegocio
│   ├── ServicioCliente.cs
│   ├── ServicioVendedor.cs
│   ├── ServicioPartido.cs
│   ├── ServicioLocalidad.cs
│   ├── ServicioLocalidadPorPartido.cs
│   ├── ServicioVenta.cs
│   └── MensajesError.cs
│
└── Presentacion
    ├── Program.cs
    ├── Principal.cs
    ├── FrmGestiones.cs
    ├── FrmConsultas.cs
    ├── FrmOperaciones.cs
    ├── FrmClientes.cs
    ├── FrmVendedores.cs
    ├── FrmPartidos.cs
    ├── FrmLocalidades.cs
    ├── FrmLocalidadPorPartido.cs
    ├── FrmVentaDeEntradas.cs
    ├── FrmConsultarClientes.cs
    ├── FrmConsultarVendedores.cs
    ├── FrmConsultarPartidos.cs
    ├── FrmConsultarLocalidades.cs
    ├── FrmConsultarLocalidadPorPartido.cs
    └── FrmConsultarVentas.cs
```

---

## Capa de Presentación

La capa de presentación está implementada con **Windows Forms** y contiene los formularios que permiten al usuario interactuar con el sistema.

### Punto de Entrada

#### Program.cs

Archivo principal de inicio de la aplicación.

Responsabilidades:

- Inicializar la aplicación.
- Ejecutar el formulario principal.
- Configurar el entorno inicial de WinForms.

### Menú Principal

#### Principal.cs

Formulario principal del sistema.

Responsabilidades:

- Mostrar el menú principal.
- Permitir la navegación hacia los módulos de gestiones, consultas y operaciones.

---

## Formularios de Navegación

### FrmGestiones.cs

Formulario de navegación para operaciones de registro.

Permite acceder a:

- FrmClientes.cs
- FrmVendedores.cs
- FrmPartidos.cs
- FrmLocalidades.cs
- FrmLocalidadPorPartido.cs

### FrmConsultas.cs

Formulario de navegación para consultas.

Permite acceder a:

- FrmConsultarClientes.cs
- FrmConsultarVendedores.cs
- FrmConsultarPartidos.cs
- FrmConsultarLocalidades.cs
- FrmConsultarLocalidadPorPartido.cs
- FrmConsultarVentas.cs

### FrmOperaciones.cs

Formulario de navegación para procesos operativos.

Permite acceder a:

- FrmVentaDeEntradas.cs
- FrmLocalidadPorPartido.cs

---

## Formularios Específicos de Gestión

Cada formulario de gestión se relaciona con una entidad del dominio y utiliza su servicio correspondiente en la capa de lógica de negocio.

### FrmClientes.cs

Formulario para registrar clientes.

Relaciones principales:

- Usa ServicioCliente.cs.
- Registra objetos Cliente.cs.
- Valida datos requeridos antes del registro.

### FrmVendedores.cs

Formulario para registrar vendedores.

Relaciones principales:

- Usa ServicioVendedor.cs.
- Registra objetos Vendedor.cs.
- Valida datos requeridos antes del registro.

### FrmPartidos.cs

Formulario para registrar partidos.

Relaciones principales:

- Usa ServicioPartido.cs.
- Registra objetos Partido.cs.
- Permite definir si un partido está activo o inactivo.

### FrmLocalidades.cs

Formulario para registrar localidades del estadio.

Relaciones principales:

- Usa ServicioLocalidad.cs.
- Registra objetos Localidad.cs.
- Valida precio e identificador de localidad.

### FrmLocalidadPorPartido.cs

Formulario para asignar localidades disponibles a partidos específicos.

Relaciones principales:

- Usa ServicioLocalidadPorPartido.cs.
- Usa Partido.cs.
- Usa Localidad.cs.
- Crea objetos LocalidadPorPartido.cs.
- Valida que no existan asignaciones duplicadas.
- Valida cantidad disponible.

### FrmVentaDeEntradas.cs

Formulario para registrar ventas de entradas.

Relaciones principales:

- Usa ServicioVenta.cs.
- Usa Cliente.cs.
- Usa Vendedor.cs.
- Usa Partido.cs.
- Usa Localidad.cs.
- Usa LocalidadPorPartido.cs.
- Crea objetos Venta.cs.
- Valida disponibilidad.
- Calcula el total de la venta.
- Actualiza la cantidad disponible.

---

## Formularios Específicos de Consulta

Los formularios de consulta permiten visualizar registros existentes y filtrar información por identificador o atributos relevantes.

### FrmConsultarClientes.cs

Consulta clientes registrados.

Relaciones principales:

- Usa ServicioCliente.cs.
- Muestra información de Cliente.cs.

### FrmConsultarVendedores.cs

Consulta vendedores registrados.

Relaciones principales:

- Usa ServicioVendedor.cs.
- Muestra información de Vendedor.cs.

### FrmConsultarPartidos.cs

Consulta partidos registrados.

Relaciones principales:

- Usa ServicioPartido.cs.
- Muestra información de Partido.cs.

### FrmConsultarLocalidades.cs

Consulta localidades registradas.

Relaciones principales:

- Usa ServicioLocalidad.cs.
- Muestra información de Localidad.cs.

### FrmConsultarLocalidadPorPartido.cs

Consulta asignaciones de localidades por partido.

Relaciones principales:

- Usa ServicioLocalidadPorPartido.cs.
- Muestra información de LocalidadPorPartido.cs.
- Relaciona Partido.cs con Localidad.cs.

### FrmConsultarVentas.cs

Consulta ventas registradas.

Relaciones principales:

- Usa ServicioVenta.cs.
- Muestra información de Venta.cs.
- Muestra cliente, vendedor, partido, localidad, cantidad, fecha y total.

---

## Capa de Lógica de Negocio

La capa de lógica de negocio contiene los servicios responsables de aplicar reglas, validaciones y coordinación entre la presentación, los gestores y las entidades.

---

## Servicios de Negocio

### ServicioCliente.cs

Responsable de administrar la lógica relacionada con clientes.

Relaciones principales:

- Usa GestorClientes.cs.
- Crea y consulta objetos Cliente.cs.
- Valida datos de cliente.

### ServicioVendedor.cs

Responsable de administrar la lógica relacionada con vendedores.

Relaciones principales:

- Usa GestorVendedores.cs.
- Crea y consulta objetos Vendedor.cs.
- Valida datos de vendedor.

### ServicioPartido.cs

Responsable de administrar la lógica relacionada con partidos.

Relaciones principales:

- Usa GestorPartidos.cs.
- Crea y consulta objetos Partido.cs.
- Valida fecha, hora, rival y estado activo.

### ServicioLocalidad.cs

Responsable de administrar la lógica relacionada con localidades.

Relaciones principales:

- Usa GestorLocalidades.cs.
- Crea y consulta objetos Localidad.cs.
- Valida nombre, precio e identificador.

### ServicioLocalidadPorPartido.cs

Responsable de administrar la asignación de localidades a partidos.

Relaciones principales:

- Usa GestorLocalidadesPorPartido.cs.
- Usa GestorPartidos.cs.
- Usa GestorLocalidades.cs.
- Valida existencia de Partido.cs.
- Valida existencia de Localidad.cs.
- Valida duplicados.
- Crea objetos LocalidadPorPartido.cs.

### ServicioVenta.cs

Servicio de negocio responsable de crear, validar y registrar ventas.

Relaciones:
- Recibe datos desde FrmVentaDeEntradas.cs.
- Crea objetos Venta.cs.
- Valida Cliente.cs.
- Valida Vendedor.cs.
- Valida Partido.cs.
- Valida Localidad.cs.
- Valida LocalidadPorPartido.cs.
- Usa GestorVentas.cs para registrar ventas.
- Usa GestorLocalidadesPorPartido.cs para consultar y actualizar disponibilidad.
- Consulta información desde DatosSistema.cs mediante los gestores.

---

## Relación entre Venta y Lógica de Negocio

La entidad **Venta.cs** pertenece a la capa de entidades y representa la transacción final del sistema.

La clase **ServicioVenta.cs** pertenece a la capa de lógica de negocio y es responsable de crear, validar y registrar objetos de tipo **Venta**.

La venta no debe ser gestionada directamente desde la interfaz ni almacenada sin pasar por el servicio de negocio.

Flujo correcto:

```text
FrmVentaDeEntradas.cs
    ↓
ServicioVenta.cs
    ↓
Venta.cs
    ↓
GestorVentas.cs
    ↓
DatosSistema.cs
```

Relaciones de ServicioVenta.cs:

```text
ServicioVenta.cs
    ├── usa Cliente.cs
    ├── usa Vendedor.cs
    ├── usa Partido.cs
    ├── usa Localidad.cs
    ├── usa LocalidadPorPartido.cs
    ├── crea Venta.cs
    ├── delega en GestorVentas.cs
    └── actualiza disponibilidad mediante GestorLocalidadesPorPartido.cs
```

---

## Mensajes Centralizados

### MensajesError.cs

Clase utilizada para centralizar mensajes de error, validación y confirmación del sistema.

Beneficios:

- Evita duplicación de textos.
- Facilita mantenimiento.
- Mejora consistencia en la interfaz.
- Centraliza mensajes utilizados por servicios y formularios.

---

## Capa de Acceso a Datos

La capa de acceso a datos administra las colecciones del sistema y actúa como intermediaria entre la lógica de negocio y el almacenamiento en memoria.

---

## DatosSistema.cs

Clase estática utilizada como almacenamiento central en memoria.

Responsabilidades:

- Mantener listas compartidas durante la ejecución.
- Permitir persistencia temporal entre formularios.
- Centralizar las colecciones principales del sistema.

Colecciones administradas:

- Clientes
- Vendedores
- Partidos
- Localidades
- LocalidadesPorPartido
- Ventas

---

## Gestores de Datos

### GestorClientes.cs

Responsable de registrar y consultar clientes.

Relaciones principales:

- Lee y escribe en DatosSistema.cs.
- Administra objetos Cliente.cs.

### GestorVendedores.cs

Responsable de registrar y consultar vendedores.

Relaciones principales:

- Lee y escribe en DatosSistema.cs.
- Administra objetos Vendedor.cs.

### GestorPartidos.cs

Responsable de registrar y consultar partidos.

Relaciones principales:

- Lee y escribe en DatosSistema.cs.
- Administra objetos Partido.cs.

### GestorLocalidades.cs

Responsable de registrar y consultar localidades.

Relaciones principales:

- Lee y escribe en DatosSistema.cs.
- Administra objetos Localidad.cs.

### GestorLocalidadesPorPartido.cs

Responsable de registrar y consultar asignaciones de localidades por partido.

Relaciones principales:

- Lee y escribe en DatosSistema.cs.
- Administra objetos LocalidadPorPartido.cs.
- Relaciona Partido.cs y Localidad.cs.

### GestorVentas.cs

Responsable de registrar y consultar ventas.

Relaciones principales:

- Lee y escribe en DatosSistema.cs.
- Administra objetos Venta.cs.

---

## Capa de Entidades

La capa de entidades contiene las clases que representan el dominio del sistema.

---

## Entidades del Sistema

La capa Entidades contiene las clases de dominio principales. Cada entidad debe representarse como una clase separada dentro del diagrama.

### Persona.cs

Clase base para personas del sistema.

Relaciones:
- Cliente.cs hereda de Persona.cs.
- Vendedor.cs hereda de Persona.cs.

### Cliente.cs

Entidad que representa al comprador de entradas.

Relaciones:
- Hereda de Persona.cs.
- Es referenciada por Venta.cs.
- Es creada y consultada mediante ServicioCliente.cs.
- Es almacenada por GestorClientes.cs.

### Vendedor.cs

Entidad que representa al vendedor que registra la venta.

Relaciones:
- Hereda de Persona.cs.
- Es referenciada por Venta.cs.
- Es creada y consultada mediante ServicioVendedor.cs.
- Es almacenada por GestorVendedores.cs.

### Partido.cs

Entidad que representa un partido deportivo.

Relaciones:
- Es referenciada por LocalidadPorPartido.cs.
- Es referenciada por Venta.cs.
- Es creada y consultada mediante ServicioPartido.cs.
- Es almacenada por GestorPartidos.cs.

### Localidad.cs

Entidad que representa una zona del estadio.

Relaciones:
- Es referenciada por LocalidadPorPartido.cs.
- Es referenciada por Venta.cs.
- Es creada y consultada mediante ServicioLocalidad.cs.
- Es almacenada por GestorLocalidades.cs.

### LocalidadPorPartido.cs

Entidad de relación entre Partido.cs y Localidad.cs.

Relaciones:
- Contiene una referencia a Partido.cs.
- Contiene una referencia a Localidad.cs.
- Es utilizada por ServicioLocalidadPorPartido.cs.
- Es utilizada por ServicioVenta.cs para validar disponibilidad.
- Es almacenada por GestorLocalidadesPorPartido.cs.
- Es referenciada por Venta.cs.

### Venta.cs

Entidad que representa la transacción final.

Relaciones:
- Contiene una referencia a Cliente.cs.
- Contiene una referencia a Vendedor.cs.
- Contiene una referencia a Partido.cs.
- Contiene una referencia a Localidad.cs.
- Contiene una referencia a LocalidadPorPartido.cs.
- Es creada por ServicioVenta.cs.
- Es almacenada por GestorVentas.cs.

## Mapa Explícito de Relaciones entre Capas

### Cliente.cs
- Usado por FrmClientes.cs.
- Usado por FrmConsultarClientes.cs.
- Creado y validado por ServicioCliente.cs.
- Registrado y consultado por GestorClientes.cs.
- Almacenado en DatosSistema.cs.
- Referenciado por Venta.cs.
- Validado por ServicioVenta.cs.

### Vendedor.cs
- Usado por FrmVendedores.cs.
- Usado por FrmConsultarVendedores.cs.
- Creado y validado por ServicioVendedor.cs.
- Registrado y consultado por GestorVendedores.cs.
- Almacenado en DatosSistema.cs.
- Referenciado por Venta.cs.
- Validado por ServicioVenta.cs.

### Partido.cs
- Usado por FrmPartidos.cs.
- Usado por FrmConsultarPartidos.cs.
- Creado y validado por ServicioPartido.cs.
- Registrado y consultado por GestorPartidos.cs.
- Almacenado en DatosSistema.cs.
- Referenciado por LocalidadPorPartido.cs.
- Referenciado por Venta.cs.
- Validado por ServicioVenta.cs.

### Localidad.cs
- Usado por FrmLocalidades.cs.
- Usado por FrmConsultarLocalidades.cs.
- Creado y validado por ServicioLocalidad.cs.
- Registrado y consultado por GestorLocalidades.cs.
- Almacenado en DatosSistema.cs.
- Referenciado por LocalidadPorPartido.cs.
- Referenciado por Venta.cs.
- Validado por ServicioVenta.cs.

### LocalidadPorPartido.cs
- Usado por FrmLocalidadPorPartido.cs.
- Usado por FrmConsultarLocalidadPorPartido.cs.
- Creado y validado por ServicioLocalidadPorPartido.cs.
- Registrado y consultado por GestorLocalidadesPorPartido.cs.
- Almacenado en DatosSistema.cs.
- Referenciado por Venta.cs.
- Consultado y actualizado por ServicioVenta.cs para validar disponibilidad.

### Venta.cs
- Usado por FrmVentaDeEntradas.cs.
- Usado por FrmConsultarVentas.cs.
- Creado por ServicioVenta.cs.
- Validado por ServicioVenta.cs.
- Registrado y consultado por GestorVentas.cs.
- Almacenado en DatosSistema.cs.
- Contiene referencias a Cliente.cs, Vendedor.cs, Partido.cs, Localidad.cs y LocalidadPorPartido.cs.

## Flujo General de Navegación

```text
Program.cs
    ↓
Principal.cs
    ↓
FrmGestiones.cs / FrmConsultas.cs / FrmOperaciones.cs
    ↓
Formularios específicos
    ↓
Servicios de negocio
    ↓
Gestores de datos
    ↓
DatosSistema.cs
```

---

## Flujo de Registro de Cliente

```text
FrmClientes.cs
    ↓
ServicioCliente.cs
    ↓
GestorClientes.cs
    ↓
DatosSistema.cs
    ↓
Cliente.cs
```

---

## Flujo de Registro de Partido

```text
FrmPartidos.cs
    ↓
ServicioPartido.cs
    ↓
GestorPartidos.cs
    ↓
DatosSistema.cs
    ↓
Partido.cs
```

---

## Flujo de Asignación de Localidad por Partido

```text
FrmLocalidadPorPartido.cs
    ↓
ServicioLocalidadPorPartido.cs
    ↓
GestorPartidos.cs
    ↓
GestorLocalidades.cs
    ↓
GestorLocalidadesPorPartido.cs
    ↓
DatosSistema.cs
    ↓
LocalidadPorPartido.cs
```

---

## Flujo de Venta de Entradas

```text
FrmVentaDeEntradas.cs
    ↓
ServicioVenta.cs
    ↓
Validar Cliente.cs
    ↓
Validar Vendedor.cs
    ↓
Validar Partido.cs
    ↓
Validar Localidad.cs
    ↓
Validar LocalidadPorPartido.cs
    ↓
Calcular Total
    ↓
Crear Venta.cs
    ↓
GestorVentas.cs
    ↓
Actualizar CantidadDisponible
    ↓
DatosSistema.cs
```

---

## Características UX/UI

- Navegación consistente entre formularios.
- Botón de retorno al menú principal.
- Cierre controlado de formularios.
- Mensajes claros para el usuario.
- Combos con formato `Id - Nombre`.
- Grids de consulta con filtros.
- Búsqueda por identificador.
- Búsqueda por atributos.
- Scroll horizontal en consultas extensas.
- Ajuste automático de columnas.

---

## Validaciones Principales

El sistema realiza validaciones como:

- Campos requeridos.
- Identificadores numéricos.
- Existencia previa de entidades.
- Duplicados.
- Partidos activos.
- Localidades disponibles.
- Cantidad de entradas mayor a cero.
- Stock suficiente antes de registrar una venta.
- Cálculo correcto del total.

---

## Tecnologías Utilizadas

- C#
- .NET 8
- Windows Forms
- Programación Orientada a Objetos
- Persistencia en memoria

---

## Principios de Diseño Aplicados

- Arquitectura por capas.
- Separación de responsabilidades.
- Encapsulamiento.
- Reutilización de código.
- Centralización de mensajes.
- Persistencia compartida mediante clase estática.
- Validación en capa de negocio.
- Interfaz separada de la lógica del sistema.

---

## Mejoras Futuras

- Persistencia en SQL Server.
- Implementación de patrón Repository.
- Inyección de dependencias.
- Exportación de reportes a Excel o PDF.
- Pruebas unitarias automatizadas.
- Control de usuarios y roles.
- Manejo de logs.
- Migración a arquitectura MVC o MVVM.
- API REST para integración con otros sistemas.

---

Proyecto académico desarrollado utilizando **C# .NET 8 WinForms** para la gestión de boletería deportiva.