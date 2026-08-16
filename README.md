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


  # Checklist - Práctico 2: Validación de Campos y Tipos de Mensajes MsgBox

  ## 1. Configuración del Proyecto y Formulario
- [X] **Nombre del Proyecto:** `Practico3` (o guardado en carpeta `Pequeño Formulario`).
- [X] **Nombre del Formulario / Título (`Text`):** `"Pequeño Formulario"`.
---
## 2. Controles de Interfaz de Usuario (UI)

### Labels
- [X] **`LDni`**:
  - `Name`: `LDni`
  - `Text`: `DNI`
- [X] **`LApellido`**:
  - `Name`: `LApellido`
  - `Text`: `Apellido`
- [X] **`LNombre`**:
  - `Name`: `LNombre`
  - `Text`: `Nombre`
- [X] **`LNya`**:
  - `Name`: `LNya`
  - `Text`: `Nombre y Apellido:`
- [X] **`LModificar`**:
  - `Name`: `LModificar`
  - `Text`: `modificar`
  - `ForeColor`: Color Rojo

### TextBoxes
- [X] **`TDni`**: `Name` = `TDni`
- [X] **`TApellido`**: `Name` = `TApellido`
- [X] **`TNombre`**: `Name` = `TNombre`

### Botones
- [X] **Botón Guardar:**
  - `Name`: `BGuardar` (o `TGuardar`)
  - `Text`: `Guardar`
- [X] **Botón Eliminar:**
  - `Name`: `BEliminar` (o `TEliminar`)
  - `Text`: `Eliminar`

---

## 3. Validaciones de Entrada (KeyPress)
- [X] **Validación `TDni`:** Permitir únicamente el ingreso de caracteres numéricos (y teclas de control como Backspace).
- [X] **Validación `TApellido`:** Permitir únicamente el ingreso de letras (y teclas de control/espacio).
- [X] **Validación `TNombre`:** Permitir únicamente el ingreso de letras (y teclas de control/espacio).

---

## 4. Lógica y Eventos

### Botón Guardar (`BGuardar`)
- [X] **Validación de Campos Vacíos:**
  - Evaluar si algún campo (`TDni`, `TApellido`, `TNombre`) está vacío mediante `If` con operador lógico `Or` / `||`.
  - Si falta completar algún campo:
    - Mostrar **MsgBox Crítico / Error** con título `"Error"` y mensaje `"Debe Completar todos los campos"`.
- [X] **Confirmación de Inserción (Campos Completos):**
  - Actualizar el label `LModificar` con el nombre y apellido ingresados.
  - Declarar variable `ask` (`MsgBoxResult` / `DialogResult`).
  - Mostrar **MsgBox de Consulta / Question** (Sí/No) con título `"Confirmar Insercion"`, mensaje `"Seguro que desea insertar un nuevo Cliente?"` y el **foco por defecto en "SI"**.
  - Si el usuario selecciona **"SI"**:
    - Mostrar **MsgBox de Información** con título `"Guardar"` y mensaje `"El Cliente: [Nombre Apellido] se insertó correctamente"`.