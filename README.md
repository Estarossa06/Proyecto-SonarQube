# Clean CSV Architecture - C#

Este proyecto implementa la lectura de archivos CSV utilizando principios de la Arquitectura Limpia en C#. Además, se realiza análisis de calidad de código mediante SonarQube.

# Arquitectura

El sistema está organizado en tres capas principales:

- **CapaPresentacion (UI):**
  Interfaz de usuario desarrollada en Windows Forms. Permite cargar archivos CSV y visualizar los datos.

- **CapaNegocio (BLL):**
  Contiene la lógica del sistema. Se implementa una interfaz (`ICSVService`) para aplicar inversión de dependencias.

- **CapaDatos (DAL):**
  Encargada de la lectura del archivo CSV y conversión a DataTable.

# Principios de la Arquitectura Limpia aplicados

- Separación de responsabilidades
- Inversión de dependencias
- Uso de interfaces
- Bajo acoplamiento entre capas
- Código mantenible y escalable

# Funcionalidades

- Cargar archivos CSV
- Visualizar datos en un DataGridView
- Validación de archivo vacío
- Manejo de errores

# Tecnologías utilizadas

- C#
- .NET (Windows Forms)
- SonarQube
- GitHub

# Análisis con SonarQube

Se utilizó SonarQube para evaluar la calidad del código, identificando:

- Code Smells
- Posibles errores
- Mejores prácticas no aplicadas

Posteriormente se realizaron mejoras como:

- Implementación de interfaces
- Validaciones de entrada
- Manejo de excepciones

# Ejecución del proyecto

1. Abrir la solución:
- CleanCSV.sln
2. Establecer como proyecto de inicio:
- CapaPresentacion
2. Establecer como proyecto de inicio:
- CapaPresentacion
4. Cargar un archivo CSV desde la interfaz

# Estructura del proyecto

CleanCSVArchitecture/
 CapaDatos/
 apaNegocio/
 CapaPresentacion/
 CleanCSV.sln
 README.md

# Conclusión

La implementación de Clean Architecture permitió separar correctamente las responsabilidades del sistema, 
reduciendo el acoplamiento entre capas y facilitando la mantenibilidad del código.
El uso de interfaces y la organización por capas permitió que la aplicación sea más escalable y adaptable a futuros cambios. 
Además, el análisis con SonarQube ayudó a identificar problemas de calidad que fueron corregidos mediante la refactorización del código.
Este enfoque mejora la calidad general del software y facilita su evolución en el tiempo.

