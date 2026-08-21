# Taller 2

# Checklist - Práctico 1: Creación de un Windows Forms
**Materia:** Taller de Programación II  
**Carrera:** Licenciatura en Sistemas de Información (FACENA - UNNE)

---

## 1. Configuración del Proyecto y Formulario
- [X] **Proyecto:** Crear solución/proyecto con el nombre `Practico1`.
- [X] **Formulario:** Nombrar el formulario como `Formulario1`.
- [X] **Título de la ventana (Propiedad `Text`):** Configurar como `"Mi Primer Forms"`.
- [X] **Dimensiones (Propiedad `Size`):** Establecer en `500; 300`.
- [X] **Posición inicial (Propiedad `StartPosition`):** Centrar la aplicación en pantalla (`CenterScreen` / `WindowsDefaultLocation`).

---

## 2. Controles de Interfaz de Usuario (UI)

### Labels
- [X] **`LApellido`**:
  - `Name`: `LApellido`
  - `Text`: `Apellido`
- [X] **`LNombre`**:
  - `Name`: `LNombre`
  - `Text`: `Nombre`

### TextBoxes
- [X] **TextBox 1 (Apellido):** TextBox simple para el ingreso del apellido.
- [X] **TextBox 2 (Nombre):** TextBox simple para el ingreso del nombre.
- [X] **TextBox 3 (Resultado):** TextBox con la propiedad `Multiline` habilitada (`Multiline = True`).

### Botones
- [X] **`BGuardar`**:
  - `Name`: `BGuardar`
  - `Text`: `Guardar`
- [X] **`BEliminar`**:
  - `Name`: `BEliminar`
  - `Text`: `Eliminar`
- [X] **Botón Salir**:
  - `Text`: `Salir`
  - Acceso directo configurado: `Ctrl + S`

---

## 3. Lógica y Eventos

- [X] **Evento Click de `BGuardar`:**
  - Concatenar los valores de los TextBoxes de Apellido y Nombre (`textBox.Text`).
  - Mostrar la cadena concatenada en el TextBox multilínea.
- [X] **Evento Click de `BEliminar`:**
  - Limpiar el contenido del TextBox multilínea mediante el método `textBox.Clear()`.
- [X] **Evento/Acción del Botón Salir:**
  - Cerrar la aplicación utilizando la sentencia `End`.
  - Responder a la combinación de teclas `Ctrl + S`.

## 4. Resultado
<p align="center">
<img width="500" align="center" height="297" alt="image" src="https://github.com/user-attachments/assets/026b52fa-f8aa-47dc-bff1-ad94dc9b263f" />
</p>


https://github.com/user-attachments/assets/07884fc9-6bb7-441b-9ef2-329f762b371c

# Checklist - Práctico 2: Validación de Campos y Tipos de Mensajes MsgBox

---

## 1. Configuración del Proyecto y Formulario
- [X] **Nombre del Proyecto:** `Practico3`
- [X] **Título de la ventana / Formulario (`Text`):** `"Pequeño Formulario"`
- [X] **Guardado final:** Proyecto guardado en carpeta `"Pequeño Formulario"`

---

## 2. Controles de Interfaz de Usuario (UI)

### Labels
- [X] **Label DNI:**
  - `Name`: `LDni`
  - `Text`: `DNI`
- [X] **Label Apellido:**
  - `Name`: `LApellido`
  - `Text`: `Apellido`
- [X] **Label Nombre:**
  - `Name`: `LNombre`
  - `Text`: `Nombre`
- [X] **Label Encabezado NyA:**
  - `Name`: `LNya`
  - `Text`: `Nombre y Apellido:`
- [X] **Label Dinámico Modificar:**
  - `Name`: `LModificar`
  - `Text`: `modificar`
  - `ForeColor`: Color Rojo

### TextBoxes
- [X] **`TDni`:** Caja de texto para ingreso de DNI.
- [X] **`TApellido`:** Caja de texto para ingreso de Apellido.
- [X] **`TNombre`:** Caja de texto para ingreso de Nombre.

### Botones
- [X] **Botón Guardar:**
  - `Name`: `BGuardar` (o `TGuardar`)
  - `Text`: `Guardar`
- [X] **Botón Eliminar:**
  - `Name`: `BEliminar` (o `TEliminar`)
  - `Text`: `Eliminar`

---

## 3. Validaciones de Entrada (KeyPress)
- [X] **Validación `TDni`:** Permitir exclusivamente el ingreso de caracteres numéricos.
- [X] **Validación `TApellido`:** Permitir exclusivamente el ingreso de letras
- [X] **Validación `TNombre`:** Permitir exclusivamente el ingreso de letras.

---

## 4. Lógica y Eventos

### Botón Guardar (`BGuardar`)
- [X] **Validación de campos incompletos:**
  - Verificar si algún campo está vacío mediante `If` con operador lógico `Or` / `||`.
  - Si falta algún campo, mostrar **MsgBox Crítico / Error** con título `"Error"` y mensaje `"Debe Completar todos los campos"`.
- [X] **Flujo de inserción (Campos completos):**
  - Actualizar el texto del label `LModificar` con el nombre y apellido ingresados.
  - Asignar el resultado del mensaje a una variable `ask` (`MsgBoxResult` / `DialogResult`).
  - Mostrar **MsgBox de Consulta** con botones Sí/No, título `"Confirmar Insercion"`, mensaje `"Seguro que desea insertar un nuevo Cliente?"` y el **foco por defecto en "SI"**.
  - Si se selecciona **"SI"**: Mostrar **MsgBox de Información** con título `"Guardar"` y mensaje `"El Cliente: [Nombre Apellido] se insertó correctamente"`.

### Botón Eliminar (`BEliminar`)
- [X] **Confirmación de advertencia:**
  - Mostrar **MsgBox de Exclamación / Advertencia** con botones Sí/No, título `"Confirmar Eliminación"`, mensaje `"Está apunto de eliminar el Cliente: [Nombre Apellido]"` y el **foco por defecto en "NO"**.
- [X] **Acciones de respuesta:**
  - Si se selecciona **"NO"**: No realizar ninguna acción.
  - Si se selecciona **"SI"**:
    - Mostrar **MsgBox de Información** con título `"Eliminar"` y mensaje `"El Cliente: [Nombre Apellido] se eliminó correctamente"`.
    - Limpiar todos los campos de texto (`TDni.Clear()`, `TApellido.Clear()`, `TNombre.Clear()`).
    - Limpiar / reestablecer el label `LModificar`.

## 5. Resultado
<p align="center">
  <img width="350" height="395" alt="image" src="https://github.com/user-attachments/assets/50be26f6-6d60-495c-bbd5-8c1050a42849" />
<p align="center">



https://github.com/user-attachments/assets/d11db64e-9a10-464b-a03b-861716345efa


   
# Checklist - Práctico 3: Formulario MDI Parent y Estilo al Pequeño Formulario
---

## 1. Modificaciones en el "Pequeño Formulario"

### Nuevos Controles de Entrada y Etiquetas
- [X] **Encabezados y Etiquetas:**
  - [X] Agregar Label con el texto `"Nuevo Cliente"`.
  - [X] Actualizar/agregar Labels: `*DNI`, `*Apellido`, `*Nombre`.
  - [X] Agregar Label `Telefono` y su correspondiente `TextBox`.
- [X] **Tarjetas de Crédito (`CheckBox`):**
  - [X] Agregar Label con el texto `"Tarjeta de creditos:"`.
  - [X] CheckBox 1: `Text` = `"Naranja"`.
  - [X] CheckBox 2: `Text` = `"Visa"`.
  - [X] CheckBox 3: `Text` = `"Mastercard"`.

### Selección de Género e Imagen (`PictureBox` & `RadioButton`)
- [X] **`PictureBox`:**
  - [X] Agregar un control `PictureBox` (inicialmente vacío).
- [X] **RadioButtons de Género:**
  - [X] `RBVaron`: `Name` = `RBVaron`, `Text` = `"Varon"`.
  - [X] `RBMujer`: `Name` = `RBMujer`, `Text` = `"Mujer"`.
  - [X] Habilitar la propiedad `Checked` (`True`) en uno de los dos RadioButtons para que aparezca tildado por defecto.

### Estilo de Botones
- [X] **Botones Guardar, Eliminar y Salir:**
  - [X] Asignar imagen a cada botón mediante la propiedad `Image`.
  - [X] Configurar la alineación de la imagen usando la propiedad `ImageAlign`.
  - [X] Modificar la alineación del texto del botón con la propiedad `TextAlign`.
  - [X] Agregar el nuevo botón **`Salir`**.

---

## 2. Lógica y Eventos en el Pequeño Formulario

- [X] **Evento `CheckedChanged` de los RadioButtons:**
  - [X] Si se selecciona `RBVaron`: mostrar en el `PictureBox` el icono correspondiente a varón.
  - [X] Si se selecciona `RBMujer`: mostrar en el `PictureBox` el icono correspondiente a mujer.
- [X] **Evento Click del Botón Salir:**
  - [X] Cerrar el formulario actual mediante la instrucción `Me.Close()` (o `this.Close();` en C#).

---

## 3. Implementación del Contenedor MDI (`MDIParent`)

- [X] **Creación del Formulario MDI:**
  - [X] Agregar un nuevo elemento de tipo **Formulario primario MDI** (`MDIParent1`).
  - [X] Modificar el título / leyenda (`Text`) a `"Pequeño Sistema"`.
- [X] **Configuración de Inicio del Proyecto:**
  - [X] Establecer `MDIParent1` como el **Formulario de inicio** en las propiedades del proyecto.
- [X] **Menú y Apertura del Formulario Hijo (`MenuStrip`):**
  - [X] En la opción **Nuevo** del `MenuStrip`, instanciar y hacer referencia al "Pequeño Formulario".
  - [X] Establecer el formulario contenedor padre: `Formulario.MdiParent = Me` (o `formulario.MdiParent = this;`).
  - [X] Mostrar el formulario hijo dentro del MDI utilizando el método `.Show()`.
     
## 4. Resultado
<p align="center">
<img width="600" height="591" alt="image" src="https://github.com/user-attachments/assets/da5d1823-a8a8-41cd-a332-c9458a701b8b" />
</p>



https://github.com/user-attachments/assets/9e7427bc-a7e4-4dcb-8ef4-3d60060657db


# Checklist - Práctico 4: Utilización de DataGrid con Imágenes
**Materia:** Taller de Programación II[cite: 7]  
**Carrera:** Licenciatura en Sistemas de Información (FACENA - UNNE)[cite: 7]

---

## 1. Configuración del Formulario y Recursos del Proyecto
- [x] **Título del Formulario (`Text`):** `"Formulario con Grid"`
- [x] **Fondo del Formulario (`BackgroundImage`):** Imagen `cuadros negros-734708.png`
- [x] **Panel de Entrada:**
  - [x] Formato de letra / Fuente: `Papyrus`
  - [x] Tamaño de fuente: `16`
  - [x] Color de texto / fuente (`ForeColor`): Blanco
  - [x] Imagen de fondo (`BackgroundImage`): `images.jpg`
- [x] **Estructura de Archivos:**
  - [x] Carpeta `Fotos` creada en el directorio de salida del proyecto: `\bin\Debug\Fotos`
- [x] **Diálogos del Sistema:**
  - [x] Componente `OpenFileDialog` agregado al formulario
  - [x] Filtro de extensiones para imágenes (`.jpg`, `.bmp`, `.png`) configurado en el `OpenFileDialog`

---

## 2. Controles de Entrada de Datos e Interfaz

### TextBoxes y Formato Estandarizado
- [x] **Nombre (`TxtNombre`):** Configurado para convertir automáticamente la primera letra en mayúscula y el resto en minúscula
- [x] **Apellido (`TxtApellido`):** Configurado para convertir automáticamente la primera letra en mayúscula y el resto en minúscula
- [x] **Saldo (`TxtSaldo`):** Campo de texto para ingreso de montos/saldos
- [x] **Ruta de Foto (`TxtFoto`):** Campo de texto para visualizar la ruta destino del archivo de imagen seleccionado

### Fecha, Selección de Género y Avatar
- [x] **Fecha de Nacimiento (`DateTimePicker`):** Formato corto configurado (`Format = Short`)
- [x] **RadioButtons de Sexo:**
  - [x] Opción Hombre (`Hombre`)
  - [x] Opción Mujer (`Mujer`)
- [x] **PictureBox (`Avatar`):**
  - [x] Imagen de fondo por defecto configurada (`avatar.jpg`)

### Botones
- [x] **Botón Foto:**
  - [x] Abre el cuadro de diálogo `OpenFileDialog`
  - [x] Despliega la imagen seleccionada en el `PictureBox`
  - [x] Asigna la ruta de destino al campo `TxtFoto`
- [x] **Botón Guardar / Agregar:**
  - [x] Imagen de ícono: Disco/Flappy Disk (`Image`)
  - [x] Alineación de la imagen: Izquierda (`ImageAlign = MiddleLeft`)
  - [x] Alineación del texto: Derecha (`TextAlign = MiddleRight`)

---

## 3. Configuración y Estilo del DataGridView

- [x] **Estructura de Columnas:**
  - [x] Columna `Apellido` (Texto)
  - [x] Columna `Nombre` (Texto)
  - [x] Columna `Fecha Nacimiento` (Texto / Fecha)
  - [x] Columna `Sexo` (Texto)
  - [x] Columna `Eliminar` (Columna de tipo Botón `DataGridViewButtonColumn`)
  - [x] Columna `Saldo` (Texto / Numérico)
  - [x] Columna `Foto` (Columna de imagen `DataGridViewImageColumn` con `ImageLayout = Stretch`)
  - [x] Columna `Ruta` (Texto con el path del archivo copiado)
- [x] **Estilos Tipográficos:**
  - [x] Fuente personalizada asignada de forma independiente a la columna **Nombre**
  - [x] Fuente personalizada asignada de forma independiente a la columna **Apellido**

---

## 4. Lógica, Validaciones y Eventos

- [x] **Guardar / Insertar Registro:**
  - [x] Guardar en la columna Sexo la leyenda correspondiente al `RadioButton` seleccionado (`Hombre` / `Mujer`)
  - [x] Incorporar automáticamente la imagen del avatar/foto cargada a la celda de la columna `Foto`
  - [x] Copiar físicamente la imagen seleccionada hacia la carpeta `\bin\Debug\Fotos\`
- [x] **Formato Condicional por Saldo:**
  - [x] Evaluar si el `Saldo` ingresado es menor a `$50`
  - [x] Aplicar color de fondo rojo a toda la fila cuando el saldo sea `< 50`
- [x] **Sincronización al Seleccionar Registro (DataGrid -> Formulario):**
  - [x] Seleccionar automáticamente el `RadioButton` (`Hombre`/`Mujer`) según el valor del campo Sexo de la fila activa
- [x] **Eliminación de Filas (`CellContentClick`):**
  - [x] Detectar el clic sobre el botón de la celda de la columna `Eliminar`
  - [x] Desplegar ventana de confirmación (`MsgBox`) consultando si realmente desea eliminar el registro
  - [x] Eliminar la fila del `DataGridView` solo tras recibir confirmación afirmativa del usuario

## 5. Resultado
<p align="center">
<img width="1034" height="624" alt="image" src="https://github.com/user-attachments/assets/ccc24886-e867-45c1-87df-38366110a381" />  
</p>


https://github.com/user-attachments/assets/148e349b-2f6c-4626-9c24-6f97d7e96587


