# Smartphone Project

A simple .NET console application demonstrating object-oriented programming concepts using smartphones as the main abstraction.

## Overview

This project models a basic smartphone system with an abstract base class and two concrete implementations: Nokia and iPhone. The goal is to showcase inheritance, abstraction, and polymorphism in C#.

## Features

- Abstract `Smartphone` class with common properties and methods.
- Concrete `Nokia` and `Iphone` classes, each with their own implementation of app installation.
- Demonstrates method overriding and encapsulation.
- Simple console output to simulate smartphone actions.

## Structure

```
/Models
  - Smartphone.cs
  - Nokia.cs
  - Iphone.cs
Program.cs
README.md
```

## Usage

1. Clone this repository.
2. Open the project in Visual Studio or VS Code.
3. Build and run the project using the .NET CLI or your IDE.

Example output:
```
Ligando...
Recebendo ligação...
Ligando...
Recebendo ligação...
Instalando o aplicativo WhatsApp no Nokia.
Aplicativo WhatsApp instalado com sucesso no Nokia.
Instalando o aplicativo Instagram no iPhone.
Aplicativo Instagram instalado com sucesso no iPhone.
Nokia - Modelo: Nokia 3310, IMEI: 123456789012345, Memória: 64, Número: 123456789
iPhone - Modelo: iPhone 12, IMEI: 987654321098765, Memória: 128, Número: 987654321
```

## Requirements

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) or higher

## Author

Senhoril

## License

This project is