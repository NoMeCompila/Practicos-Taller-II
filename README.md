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

