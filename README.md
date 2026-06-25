# Máquina de Café - Práctica TDD

Este proyecto consiste en la implementación de una Máquina de Café utilizando la metodología Test-Driven Development (TDD) en C# con NUnit.

## Metodología TDD

### RED
Se escribieron primero los 8 casos de prueba (TC-01 al TC-08) antes de implementar la lógica de la aplicación.

### GREEN
Se desarrolló el código mínimo necesario para que todas las pruebas pasaran correctamente.

### REFACTOR
Se reorganizó y mejoró el código para hacerlo más legible y mantenible, manteniendo todas las pruebas exitosas.

## Casos de Prueba

- TC-01: Insertar monedas.
- TC-02: Seleccionar bebida con saldo suficiente.
- TC-03: Saldo insuficiente.
- TC-04: Devolver cambio.
- TC-05: Bebida no disponible.
- TC-06: Menú de bebidas.
- TC-07: Devolver monedas.
- TC-08: Stock agotado.

## Tecnologías Utilizadas

- C#
- .NET
- NUnit
- Visual Studio Code

## Ejecución de Pruebas

Para ejecutar las pruebas:

```bash
dotnet test
```

## Resultado

Todas las pruebas fueron ejecutadas exitosamente:

- Total: 8
- Exitosas: 8
- Fallidas: 0
