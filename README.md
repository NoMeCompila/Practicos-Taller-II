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
- [X] **Nombre del Proyecto:** `Practico3`[cite: 3]
- [X] **Título de la ventana / Formulario (`Text`):** `"Pequeño Formulario"`[cite: 3]
- [X] **Guardado final:** Proyecto guardado en carpeta `"Pequeño Formulario"`[cite: 3]

---

## 2. Controles de Interfaz de Usuario (UI)

### Labels
- [X] **Label DNI:**
  - `Name`: `LDni`[cite: 3]
  - `Text`: `DNI`[cite: 3]
- [X] **Label Apellido:**
  - `Name`: `LApellido`[cite: 3]
  - `Text`: `Apellido`[cite: 3]
- [X] **Label Nombre:**
  - `Name`: `LNombre`[cite: 3]
  - `Text`: `Nombre`[cite: 3]
- [X] **Label Encabezado NyA:**
  - `Name`: `LNya`[cite: 3]
  - `Text`: `Nombre y Apellido:`[cite: 3]
- [X] **Label Dinámico Modificar:**
  - `Name`: `LModificar`[cite: 3]
  - `Text`: `modificar`[cite: 3]
  - `ForeColor`: Color Rojo[cite: 3]

### TextBoxes
- [X] **`TDni`:** Caja de texto para ingreso de DNI[cite: 3].
- [X] **`TApellido`:** Caja de texto para ingreso de Apellido[cite: 3].
- [X] **`TNombre`:** Caja de texto para ingreso de Nombre[cite: 3].

### Botones
- [X] **Botón Guardar:**
  - `Name`: `BGuardar` (o `TGuardar`)[cite: 3]
  - `Text`: `Guardar`[cite: 3]
- [X] **Botón Eliminar:**
  - `Name`: `BEliminar` (o `TEliminar`)[cite: 3]
  - `Text`: `Eliminar`[cite: 3]

---

## 3. Validaciones de Entrada (KeyPress)
- [X] **Validación `TDni`:** Permitir exclusivamente el ingreso de caracteres numéricos[cite: 3].
- [X] **Validación `TApellido`:** Permitir exclusivamente el ingreso de letras[cite: 3].
- [X] **Validación `TNombre`:** Permitir exclusivamente el ingreso de letras[cite: 3].

---

## 4. Lógica y Eventos

### Botón Guardar (`BGuardar`)
- [X] **Validación de campos incompletos:**
  - Verificar si algún campo está vacío mediante `If` con operador lógico `Or` / `||`[cite: 3].
  - Si falta algún campo, mostrar **MsgBox Crítico / Error** con título `"Error"` y mensaje `"Debe Completar todos los campos"`[cite: 3].
- [X] **Flujo de inserción (Campos completos):**
  - Actualizar el texto del label `LModificar` con el nombre y apellido ingresados[cite: 3].
  - Asignar el resultado del mensaje a una variable `ask` (`MsgBoxResult` / `DialogResult`)[cite: 3].
  - Mostrar **MsgBox de Consulta** con botones Sí/No, título `"Confirmar Insercion"`, mensaje `"Seguro que desea insertar un nuevo Cliente?"` y el **foco por defecto en "SI"**[cite: 3].
  - Si se selecciona **"SI"**: Mostrar **MsgBox de Información** con título `"Guardar"` y mensaje `"El Cliente: [Nombre Apellido] se insertó correctamente"`[cite: 3].

### Botón Eliminar (`BEliminar`)
- [X] **Confirmación de advertencia:**
  - Mostrar **MsgBox de Exclamación / Advertencia** con botones Sí/No, título `"Confirmar Eliminación"`, mensaje `"Está apunto de eliminar el Cliente: [Nombre Apellido]"` y el **foco por defecto en "NO"**[cite: 3].
- [X] **Acciones de respuesta:**
  - Si se selecciona **"NO"**: No realizar ninguna acción[cite: 3].
  - Si se selecciona **"SI"**:
    - Mostrar **MsgBox de Información** con título `"Eliminar"` y mensaje `"El Cliente: [Nombre Apellido] se eliminó correctamente"`[cite: 3].
    - Limpiar todos los campos de texto (`TDni.Clear()`, `TApellido.Clear()`, `TNombre.Clear()`)[cite: 3].
    - Limpiar / reestablecer el label `LModificar`[cite: 3].