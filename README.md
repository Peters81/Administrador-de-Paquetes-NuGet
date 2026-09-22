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

### Características principales

- Permite instalar bibliotecas y funcionalidades adicionales en proyectos .NET.
- Permite administrar las dependencias de un proyecto.
- Permite controlar las versiones de los paquetes utilizados.
- Se integra con Visual Studio y .NET CLI.
- Permite utilizar paquetes provenientes de repositorios públicos y privados.
- Facilita la reutilización de código desarrollado anteriormente.

---

# 2. ¿Cómo se utiliza NuGet?

NuGet se puede utilizar de diferentes maneras dependiendo de la herramienta que se esté utilizando.

En Visual Studio se puede acceder a la opción **Administrar paquetes NuGet**, desde donde es posible buscar, instalar, actualizar o eliminar paquetes de un proyecto.

También se puede utilizar la consola o la **CLI de .NET**, que permite ejecutar comandos desde la terminal.

Por ejemplo, para instalar el paquete `Newtonsoft.Json` se puede utilizar:

```bash
dotnet add package Newtonsoft.Json
```

Al instalar un paquete, este queda registrado como una dependencia del proyecto mediante una referencia en el archivo `.csproj`.

También se puede utilizar el comando:

```bash
dotnet restore
```

para restaurar las dependencias necesarias del proyecto.

Otros comandos que se pueden utilizar para administrar los paquetes son:

```bash
dotnet list package
```

Este comando permite consultar los paquetes instalados en el proyecto.

Para eliminar un paquete se puede utilizar:

```bash
dotnet remove package Newtonsoft.Json
```

### Pasos básicos para utilizar NuGet

1. Crear un proyecto .NET en Visual Studio o mediante la CLI.
2. Buscar el paquete que se necesita.
3. Instalar el paquete utilizando el Administrador de paquetes NuGet o la terminal.
4. Agregar la biblioteca al código cuando sea necesario.
5. Utilizar las funciones proporcionadas por el paquete.
6. Ejecutar el proyecto y comprobar que la funcionalidad agregada funciona correctamente.

---

# 3. Escenarios prácticos

Para demostrar el uso de NuGet se desarrollaron diferentes escenarios prácticos. En cada uno se utiliza un paquete diferente para agregar una funcionalidad específica a un proyecto .NET.

---

## 🟣 3.1 Escenario 1: Conversión de datos a JSON con Newtonsoft.Json

En este escenario se utiliza **Newtonsoft.Json**, una biblioteca que permite trabajar con información en formato JSON.

La finalidad del ejemplo es crear una aplicación Windows Forms donde el usuario pueda ingresar información y, al presionar un botón, los datos sean convertidos a formato JSON.

### Paso 1. Crear el proyecto

Primero se crea un proyecto de tipo **Windows Forms App** en Visual Studio.

En el formulario se agregan los siguientes controles:

- TextBox para ingresar el nombre.
- TextBox para ingresar la edad.
- TextBox para ingresar la carrera.
- Button para convertir los datos.
- Label o TextBox para mostrar el resultado.

**Evidencia del diseño del formulario:**

![Diseño del formulario](Imagenes/escenario1-diseno.png)

### Paso 2. Instalar Newtonsoft.Json

Desde Visual Studio se puede acceder a:

**Proyecto → Administrar paquetes NuGet**

Luego se busca el paquete **Newtonsoft.Json** y se procede con su instalación.

También se puede instalar mediante la terminal utilizando:

```bash
dotnet add package Newtonsoft.Json
```

**Evidencia de instalación del paquete:**

![Instalación de Newtonsoft.Json](Imagenes/instalacion-newtonsoft.png)

### Paso 3. Agregar la biblioteca

Después de instalar el paquete, se agrega la siguiente instrucción al código:

```csharp
using Newtonsoft.Json;
```

Esto permite utilizar las funciones proporcionadas por la biblioteca Newtonsoft.Json.

### Paso 4. Convertir los datos a JSON

En el evento del botón se utiliza el siguiente código:

```csharp
var persona = new
{
    Nombre = txtNombre.Text,
    Edad = txtEdad.Text,
    Carrera = txtCarrera.Text
};

string json = JsonConvert.SerializeObject(persona);

respuesta.Text = json;
```

### Explicación del código

Primero se crea un objeto llamado `persona` utilizando la información ingresada por el usuario.

Después se utiliza:

```csharp
JsonConvert.SerializeObject(persona);
```

Esta función permite convertir el objeto en una cadena con formato JSON.

Finalmente, el resultado se muestra en el formulario mediante:

```csharp
respuesta.Text = json;
```

### Ejemplo de datos ingresados

Para realizar la prueba se pueden utilizar los siguientes datos:

- **Nombre:** Cristell
- **Edad:** 20
- **Carrera:** Ingeniería en Sistemas

**Evidencia del formulario ejecutándose:**

![Formulario ejecutándose](Imagenes/escenario1-datos.png)

### Resultado esperado

Al presionar el botón de convertir, se espera obtener un resultado similar al siguiente:

```text
{"Nombre":"Cristell","Edad":"20","Carrera":"Ingeniería en Sistemas"}
```

**Evidencia del resultado:**

![Resultado JSON](Imagenes/escenario1-resultado.png)

### Relación con NuGet

Este escenario demuestra cómo NuGet permite agregar una biblioteca externa al proyecto para utilizar una funcionalidad que no se tuvo que programar desde cero.

En este caso, **Newtonsoft.Json** proporciona las herramientas necesarias para convertir los datos ingresados por el usuario a formato JSON.

---

## 🟣 3.2 Escenario 2: Presentación de fechas con Humanizer

En este escenario se utiliza el paquete **Humanizer** en una aplicación de consola.

Humanizer permite presentar diferentes tipos de información de una manera más fácil de leer. Para este ejemplo se utilizará una fecha y se mostrará de una forma más natural.

### Paso 1. Crear el proyecto

Primero se crea un proyecto de tipo **Console App**.

Después se debe ingresar mediante la terminal a la carpeta donde se encuentra el archivo `.csproj`.

### Paso 2. Instalar Humanizer

Para instalar el paquete se utiliza el siguiente comando:

```bash
dotnet add package Humanizer
```

**Evidencia de la instalación de Humanizer:**

![Instalación de Humanizer](Imagenes/instalacion-humanizer.png)

### Paso 3. Agregar Humanizer al código

Después de instalar el paquete se agrega:

```csharp
using Humanizer;
```

Esto permite utilizar las funciones proporcionadas por Humanizer.

### Paso 4. Crear el ejemplo

Se utiliza el siguiente código:

```csharp
using Humanizer;

DateTime fecha = DateTime.Now.AddDays(-3);

Console.WriteLine("Fecha original:");
Console.WriteLine(fecha);

Console.WriteLine("\nFecha presentada de forma natural:");
Console.WriteLine(fecha.Humanize());
```

### Explicación del código

Primero se obtiene la fecha actual y se le restan tres días mediante:

```csharp
DateTime fecha = DateTime.Now.AddDays(-3);
```

Después se muestra la fecha original.

Finalmente, se utiliza:

```csharp
fecha.Humanize()
```

Esta función pertenece al paquete Humanizer y permite presentar la fecha de una manera más natural.

### Resultado esperado

Al ejecutar el programa se puede obtener un resultado similar a:

```text
Fecha original:
18/09/2026 10:30:00

Fecha presentada de forma natural:
Hace 3 días
```

El texto exacto puede variar dependiendo de la fecha, hora y configuración utilizada al ejecutar el programa.

**Evidencia del resultado en la consola:**

![Resultado de Humanizer](Imagenes/escenario2-resultado.png)

### Relación con NuGet

Este escenario demuestra nuevamente el uso de NuGet para agregar funcionalidades desarrolladas en una biblioteca externa.

En lugar de crear manualmente toda la lógica para presentar una fecha de forma natural, se instala **Humanizer** mediante NuGet y se utiliza su función `Humanize()`.

---

## 🟣 3.3 Escenario 3: Pendiente de agregar

> **Este espacio queda reservado para el tercer escenario.**
>
> La información de este escenario será agregada posteriormente con base en el contenido correspondiente.

### Descripción

Pendiente de agregar.

### Paquete utilizado

Pendiente de agregar.

### Código utilizado

Pendiente de agregar.

### Explicación

Pendiente de agregar.

### Resultado esperado

Pendiente de agregar.

**Evidencia del escenario 3:**

![Resultado del escenario 3](Imagenes/escenario3-resultado.png)

### Relación con NuGet

Pendiente de agregar.

---

# 4. Comparación de los escenarios

| Aspecto | Escenario 1 | Escenario 2 | Escenario 3 |
|---|---|---|---|
| Paquete utilizado | Newtonsoft.Json | Humanizer | Pendiente |
| Tipo de proyecto | Windows Forms | Console App | Pendiente |
| Función principal | Convertir datos a JSON | Presentar fechas de forma natural | Pendiente |
| Instalación | NuGet | NuGet | Pendiente |
| Función utilizada | `SerializeObject()` | `Humanize()` | Pendiente |
| Resultado | Información en formato JSON | Fecha presentada de forma natural | Pendiente |

Los escenarios permiten demostrar diferentes formas de utilizar paquetes de NuGet dentro de proyectos desarrollados con .NET.

---

# 5. Evidencias del trabajo

Para demostrar el desarrollo de los escenarios se incluirán capturas de pantalla de las diferentes etapas realizadas.

### Escenario 1 — Newtonsoft.Json

- Instalación del paquete Newtonsoft.Json.
- Diseño del formulario Windows Forms.
- Datos ingresados por el usuario.
- Resultado de la conversión a JSON.

### Escenario 2 — Humanizer

- Instalación del paquete Humanizer.
- Código utilizado en `Program.cs`.
- Resultado mostrado en la consola.

### Escenario 3

- Instalación del paquete utilizado.
- Código del escenario.
- Ejecución del programa.
- Resultado obtenido.

---

# 6. Documentación

En la carpeta `Documentacion` se incluirán los archivos relacionados con la investigación escrita.

Los archivos serán:

- Informe de la investigación en formato Word.
- Informe de la investigación en formato PDF.

La documentación contiene la información teórica sobre NuGet, su utilización y los escenarios prácticos desarrollados.

### Archivos de documentación

- `Documentacion/Informe_NuGet.docx`
- `Documentacion/Informe_NuGet.pdf`

---

# 7. Presentación

En la carpeta `Presentacion` se incluirá la presentación utilizada para explicar la investigación sobre NuGet.

La presentación contiene los puntos principales del tema, incluyendo:

- ¿Qué es NuGet?
- ¿Cómo se utiliza?
- Principales características.
- Escenario con Newtonsoft.Json.
- Escenario con Humanizer.
- Escenario 3.
- Evidencias de los escenarios.
- Conclusiones.

### Archivo de presentación

`Presentacion/Presentacion_NuGet.pptx`

---

# 8. Conclusión

NuGet es una herramienta que facilita el desarrollo de aplicaciones en .NET porque permite agregar bibliotecas y funcionalidades ya creadas a los proyectos. También permite administrar las dependencias y las versiones de los paquetes utilizados.

Mediante los escenarios realizados se pudo observar su funcionamiento de manera práctica. En el primer escenario se utilizó **Newtonsoft.Json** para convertir información ingresada por el usuario a formato JSON. En el segundo escenario se utilizó **Humanizer** para presentar una fecha de una forma más natural.

El tercer escenario permitirá complementar la investigación mostrando otra forma de utilizar un paquete de NuGet dentro de un proyecto .NET.

De esta manera, los ejemplos permiten comprender cómo NuGet puede ser utilizado para incorporar diferentes funcionalidades a un proyecto sin tener que desarrollar todas las herramientas desde cero.

---

# Recursos incluidos

- Documentación de la investigación.
- Presentación sobre NuGet.
- Código fuente del escenario con Newtonsoft.Json.
- Código fuente del escenario con Humanizer.
- Código fuente del escenario 3.
- Capturas de pantalla de las pruebas realizadas.
- Paquetes NuGet utilizados en los escenarios.
