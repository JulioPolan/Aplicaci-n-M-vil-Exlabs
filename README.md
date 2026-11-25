# Aplicación Móvil Exlabs

Aplicación móvil desarrollada en **.NET 10.0** y **.NET MAUI (Multi-platform App UI)** con C# y XAML, enfocada exclusivamente en la plataforma **Android**.

## Tecnologías y Versiones

* **SDK / Framework:** .NET 10.0 / .NET MAUI (`net10.0`)
* **Compilación XAML:** XAML Source Generation (`SourceGen`)
* **Plataforma Objetivo:** Android (`net10.0-android` — API 21 en adelante / Android Lollipop 5.0+)
* **Paquetes NuGet:**
  * `Microsoft.Maui.Controls` (`$(MauiVersion)`)
  * `Microsoft.Extensions.Logging.Debug` (`10.0.0`)



## Estructura del Proyecto

```text
Aplicación-Móvil-Exlabs/
├── .gitignore                  # Exclusión de archivos temporales y compilaciones (bin, obj, .vs)
├── Exlabs.csproj               # Configuración de TargetFrameworks, metadatos y paquetes NuGet
├── MauiProgram.cs              # Punto de entrada, registro de fuentes y configuración de servicios
├── App.xaml / App.xaml.cs      # Recursos globales (Colors/Styles) y ciclo de vida de la ventana
├── AppShell.xaml / .cs         # Estructura principal de navegación (Shell)
├── MainPage.xaml / .cs         # Pantalla principal e interacción inicial
├── Platforms/
│   └── Android/                # Configuración nativa de Android (AndroidManifest.xml, MainActivity.cs)
├── Properties/
│   └── launchSettings.json     # Perfiles de ejecución y depuración
└── Resources/                  # Recursos compartidos (AppIcon, Splash, Fonts, Images, Styles, Raw)
```
## Instalación y Obtención de Dependencias

Para preparar el entorno de desarrollo y descargar todas las dependencias necesarias del proyecto, sigue estos pasos en orden:

1. **Clonar el repositorio y posicionarse en la rama principal**
   ```bash
   git clone https://github.com/JulioPolan/Aplicaci-n-M-vil-Exlabs.git
   cd Aplicaci-n-M-vil-Exlabs
   git checkout Main
   ```
2. **Instalar el workload de .NET MAUI para Android (en caso de no tenerlo activo)**
   ```bash
   dotnet workload install maui-android
   ```
3. **Restaurar los paquetes NuGet del proyecto**
   ```bash
   dotnet restore Exlabs.csproj
   ```
   
## Instrucciones de Ejecución (Android)

Asegúrate de tener un Emulador Android iniciado (API 21 o superior) o un dispositivo físico conectado con la Depuración USB activada.

### Desde Visual Studio 2022 / 2026:

1. Abre Exlabs.csproj (o la solución .sln).

2. Selecciona el emulador o dispositivo físico Android en la barra superior y presiona F5.

### Desde la Terminal (.NET CLI):
  ```bash
  dotnet build Exlabs.csproj -t:Run -f net10.0-android
  ```
