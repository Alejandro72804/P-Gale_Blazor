# 🐹 P-Gale — ¡Pégale al Topo!

Un juego de **¡Pégale al Topo!** (*Whack-A-Mole*) desarrollado con **Blazor WebAssembly** como práctica del framework de .NET 8.

---

## 🎮 Descripción del Juego

**P-Gale** es un juego de habilidad y reflejos. Aparecerá un topo en una de las casillas del tablero cada segundo, y tu objetivo es hacerle clic antes de que se mueva. ¡Tienes 30 segundos para acumular la mayor cantidad de puntos posible!

### Reglas
- El tablero es una cuadrícula de **3×3** (9 casillas en total).
- Un **topo** aparece de forma aleatoria en una casilla cada segundo.
- Haz clic sobre el topo para **ganar 1 punto**.
- El juego dura **30 segundos**.
- Al terminar el tiempo, aparece el mensaje **"EL JUEGO TERMINÓ"**.

---

## 🛠️ Tecnologías Utilizadas

| Tecnología | Versión |
|---|---|
| [Blazor WebAssembly](https://learn.microsoft.com/aspnet/core/blazor/) | .NET 8 |
| Microsoft.AspNetCore.Components.WebAssembly | 8.0.10 |
| Bootstrap (CSS) | Incluido vía CDN |

El proyecto no requiere base de datos ni servidor back-end; corre completamente en el navegador gracias a Blazor WebAssembly.

---

## 📂 Estructura del Proyecto

```
P-Gale_Blazor/
├── App.razor                  # Componente raíz y enrutamiento
├── Program.cs                 # Punto de entrada de la aplicación
├── _Imports.razor             # Importaciones globales de Razor
├── Juego.csproj               # Archivo de proyecto .NET
│
├── Componentes/
│   └── Cuadrado.razor         # Componente de cada casilla del tablero
│
├── Layout/
│   ├── MainLayout.razor       # Estructura principal de la página
│   └── NavMenu.razor          # Menú de navegación
│
├── Modelos/
│   └── ModeloCuadrado.cs      # Modelo de datos de una casilla
│
├── Pages/
│   ├── Inicio.razor           # Página principal (UI del juego)
│   └── Inicio.cs              # Lógica del juego (code-behind)
│
└── wwwroot/
    ├── index.html             # Punto de entrada HTML
    ├── css/app.css            # Estilos de la aplicación
    └── Img/mole.jpg           # Imagen del topo
```

---

## ⚙️ Requisitos Previos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8)
- Un navegador moderno (Chrome, Edge, Firefox, etc.)

---

## 🚀 Cómo Ejecutar el Proyecto

1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/Alejandro72804/P-Gale_Blazor.git
   cd P-Gale_Blazor
   ```

2. **Restaurar dependencias y ejecutar:**
   ```bash
   dotnet run
   ```

3. **Abrir en el navegador:**
   - HTTP: `http://localhost:5015`
   - HTTPS: `https://localhost:7028`

---

## 🧩 Componentes Principales

### `ModeloCuadrado.cs`
Modelo de datos de cada casilla. Contiene:
- `Id` — identificador de la casilla (0 a 8).
- `IsShow` — cuando es `true`, aplica la clase CSS `mole` para mostrar la imagen del topo.
- `Style` — clase CSS activa en la casilla.

### `Cuadrado.razor`
Componente visual de una casilla. Escucha el evento `onmouseup` y ejecuta el callback `Click` pasado desde la página principal.

### `Inicio.cs` / `Inicio.razor`
Página principal del juego. Gestiona:
- El tablero de 9 casillas.
- El temporizador de 30 segundos.
- La puntuación del jugador.
- La aparición aleatoria del topo cada segundo mediante un bucle asíncrono.

---

## 📸 Vista General

```
┌─────────────────────────┐
│   ¡Pegale al Topo! 🐹   │
│   Puntos: 0  Tiempo: 30 │
├───────┬───────┬─────────┤
│       │  🐹   │         │
├───────┼───────┼─────────┤
│       │       │         │
├───────┼───────┼─────────┤
│       │       │         │
└───────┴───────┴─────────┘
```

---

## 📝 Notas

Este proyecto fue creado con fines de **práctica personal** para aprender y explorar las capacidades de **Blazor WebAssembly**. No está pensado para producción.

---

## 📄 Licencia

Proyecto de práctica — sin licencia definida.
