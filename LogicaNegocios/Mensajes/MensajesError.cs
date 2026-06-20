namespace Boleteria.LogicaNegocio.Mensajes
{
    public static class MensajesError
    {
        // Generales
        public const string IdFormatoInvalido =
            "El Id ingresado debe ser numérico.";

        public const string CamposObligatorios =
            "Debe completar todos los campos obligatorios.";

        public const string SinEspacioDisponible =
            "No hay espacio disponible para registrar más elementos.";

        public const string CantidadFormatoInvalido =
            "La cantidad debe ser numérica.";

        public const string ValorBusquedaNumericoInvalido =
            "El valor de búsqueda debe ser numérico para este criterio.";

        public const string ValorBusquedaActivoInvalido =
            "Valor Invalido, para buscar por activo use: Activo, Inactivo, True, False, 1 o 0.";

        // Localidades
        public const string LocalidadIdDuplicado =
            "El identificador de la localidad ya se encuentra registrado.";

        public const string LocalidadNoEncontrada =
            "No existe una localidad con el Id ingresado.";

        public const string LocalidadNoSeleccionada =
           "Debe seleccionar una localidad.";

        public const string NombreLocalidadObligatorio =
            "El nombre de la localidad es obligatorio.";

        public const string DatosInvalidos =
            "El Id y el precio deben tener un formato numérico válido.";

        public const string PrecioInvalido =
            "El precio debe ser mayor a cero.";

        // Partidos
        public const string PartidoIdDuplicado =
            "El identificador del partido ya se encuentra registrado.";

        public const string PartidoNoEncontrado =
            "No existe un partido con el Id ingresado.";

        public const string RivalObligatorio =
            "El rival es obligatorio.";

        public const string HoraObligatoria =
            "La hora es obligatoria.";

        public const string PartidoInactivo =
            "El partido seleccionado no se encuentra activo.";

        public const string PartidoPasado =
            "No se pueden vender entradas para partidos con fecha anterior al día actual.";

        public const string PartidoNoSeleccionado =
            "Debe seleccionar un partido.";

        // Clientes
        public const string ClienteIdDuplicado =
            "El identificador del cliente ya se encuentra registrado.";

        public const string ClienteNoEncontrado =
            "El cliente seleccionado no existe.";

        public const string ClienteNoSeleccionado =
           "Debe seleccionar un cliente.";

        public const string ClienteInactivo =
            "El cliente seleccionado no se encuentra activo.";

        public const string IdentificacionClienteDuplicada =
            "La identificación del cliente ya se encuentra registrada.";

        public const string FechaRegistroInvalida =
            "La fecha de registro no puede ser mayor al día actual.";

        // Vendedores
        public const string VendedorIdDuplicado =
            "El identificador del vendedor ya se encuentra registrado.";

        public const string VendedorNoEncontrado =
            "El vendedor seleccionado no existe.";

        public const string VendedorNoSeleccionado =
           "Debe seleccionar un vendedor.";

        public const string IdentificacionVendedorDuplicada =
            "La identificación del vendedor ya se encuentra registrada.";

        public const string IdentificacionInvalida =
            "La identificación debe ser un número mayor a cero.";

        public const string FechaNacimientoInvalida =
            "La fecha de nacimiento no puede ser mayor o igual al día actual.";

        public const string VendedorMenorEdad =
            "El vendedor debe ser mayor de edad.";

        public const string FechaIngresoInvalida =
            "La fecha de ingreso no es válida.";

        // Localidades por Partido
        public const string AsociacionDuplicada =
            "La localidad seleccionada ya fue asociada a este partido.";

        public const string CantidadDisponibleInvalida =
            "La cantidad disponible debe ser numerica y mayor a cero.";

        public const string LocalidadNoAsociada =
            "La localidad seleccionada no está asociada al partido indicado.";

        // Ventas
        public const string VentaIdDuplicado =
            "El identificador de la venta ya se encuentra registrado.";

        public const string VentaNoEncontrada =
            "No existe una venta con el Id ingresado.";

        public const string CantidadVentaInvalida =
            "La cantidad de entradas debe ser mayor a cero.";

        public const string SinDisponibilidad =
            "No existe disponibilidad suficiente para realizar la venta.";

        public const string FechaMayorAHoy =
            "La fecha de venta no puede ser mayor al día actual.";

        public const string DatosDeVentaInvalidos =
            "El Id y la cantidad deben tener un formato numérico válido.";
    }
}