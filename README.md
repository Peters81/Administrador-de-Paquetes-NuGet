# Investigación #1 NuGet: Gestor de paquetes para .NET

| Dato | Información |
|---|---|
| Curso | Herramientas de la Programación Aplicada III (.NET) |
| Investigacion | #1 |
| Estudiantes | Cristell Peters, Alisson Lacayo, Greisy Coronado|
| Grupo | 1IL133 |
| Carrera | Ingeniería en Sistemas y Computación |
| Año | 2026 |
| Fecha | 21/09/2026|
| Instructor | Ing. Irina Fong |

---

# NuGet: Gestor de paquetes para .NET

## 1. ¿Qué es NuGet?

NuGet es el gestor de paquetes utilizado en .NET para facilitar la incorporación de bibliotecas y código desarrollado por terceros o por otros proyectos. Su función principal es permitir que un proyecto pueda agregar funcionalidades sin tener que programarlas desde cero.

Los paquetes de NuGet pueden contener código compilado, archivos DLL, metadatos y otros archivos necesarios para utilizar una determinada funcionalidad. Estos paquetes se pueden obtener desde el repositorio público de NuGet y también desde repositorios privados.

NuGet permite administrar las dependencias de un proyecto, controlar las versiones de los paquetes y facilitar su distribución. Además, se encuentra integrado con herramientas como Visual Studio y .NET CLI.

---

## 2. ¿Cómo se utiliza NuGet?

NuGet se puede utilizar de diferentes maneras dependiendo de la herramienta que se esté utilizando.

En Visual Studio se puede acceder a la opción **Administrar paquetes NuGet**, desde donde es posible buscar, instalar, actualizar o eliminar paquetes de un proyecto.

También se puede utilizar la consola o la **CLI de .NET**, que permite ejecutar comandos desde la terminal. Por ejemplo, para instalar el paquete Newtonsoft.Json se puede utilizar:

```bash
dotnet add package Newtonsoft.Json
