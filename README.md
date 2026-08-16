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
**Materia:** Taller de Programación II  
**Carrera:** Licenciatura en Sistemas de Información (FACENA - UNNE)

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

- [ ] **Evento `CheckedChanged` de los RadioButtons:**
  - [ ] Si se selecciona `RBVaron`: mostrar en el `PictureBox` el icono correspondiente a varón.
  - [ ] Si se selecciona `RBMujer`: mostrar en el `PictureBox` el icono correspondiente a mujer.
- [ ] **Evento Click del Botón Salir:**
  - [ ] Cerrar el formulario actual mediante la instrucción `Me.Close()` (o `this.Close();` en C#).

---

## 3. Implementación del Contenedor MDI (`MDIParent`)

- [ ] **Creación del Formulario MDI:**
  - [ ] Agregar un nuevo elemento de tipo **Formulario primario MDI** (`MDIParent1`).
  - [ ] Modificar el título / leyenda (`Text`) a `"Pequeño Sistema"`.
- [ ] **Configuración de Inicio del Proyecto:**
  - [ ] Establecer `MDIParent1` como el **Formulario de inicio** en las propiedades del proyecto.
- [ ] **Menú y Apertura del Formulario Hijo (`MenuStrip`):**
  - [ ] En la opción **Nuevo** del `MenuStrip`, instanciar y hacer referencia al "Pequeño Formulario".
  - [ ] Establecer el formulario contenedor padre: `Formulario.MdiParent = Me` (o `formulario.MdiParent = this;`).
  - [ ] Mostrar el formulario hijo dentro del MDI utilizando el método `.Show()`.
     
## 4. Resultado
<p align="center">
<img width="600" height="591" alt="image" src="https://github.com/user-attachments/assets/da5d1823-a8a8-41cd-a332-c9458a701b8b" />
</p>



https://github.com/user-attachments/assets/9e7427bc-a7e4-4dcb-8ef4-3d60060657db


