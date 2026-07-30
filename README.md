# Unity Game Project

Dieses Repository enthält Ausschnitte meines aktuellen Unity-Spielprojekts, das ich in meiner Freizeit mit C# entwickle.

## Über das Projekt

Bei dem Projekt handelt es sich um ein Roguelike-RPG, bei dem der Fokus auf modularen Spielsystemen und erweiterbaren Mechaniken liegt.

Ich entwickle verschiedene Systeme selbstständig, darunter Spielersteuerung, Fähigkeiten, Inventar, Schaden, visuelle Effekte und Speicherung von Spieldaten.

Das Projekt befindet sich aktuell in der Prototyping-Phase. Der Schwerpunkt liegt auf dem Aufbau einer flexiblen Systemstruktur sowie dem Testen und Erweitern neuer Spielmechaniken.

## Technologien

- C#
- Unity Engine
- Objektorientierte Programmierung
- ScriptableObjects
- Event-basierte Kommunikation
- Unity Input System

## Implementierte Systeme

### Player System

System zur Steuerung und Verwaltung des Spielers.

Funktionen:
- Spielerbewegung
- Verarbeitung von Eingaben über das Unity Input System
- Kommunikation zwischen verschiedenen Systemen über Events

### Ability System

Modulares Fähigkeitensystem zur Verwaltung verschiedener Fähigkeiten.

Funktionen:
- ScriptableObject-basierte Fähigkeiten
- Verschiedene Ability-Typen
- Cast-System
- Cooldowns
- Stat-Modifikatoren
- Erweiterbare Struktur für neue Fähigkeiten

### Inventory System

System zur Verwaltung von Fähigkeiten und Ability-Slots.

Funktionen:
- Verwaltung verschiedener Ability-Slots
- Trennung von Daten und Logik
- Erweiterbare Struktur für neue Inhalte

### Damage System

System zur Berechnung und Verarbeitung von Schaden.

Funktionen:
- Schadensberechnung
- Verwaltung verschiedener Stats und Attribute
- Unterstützung unterschiedlicher Schadensmechaniken
- Erweiterbare Struktur für neue Systeme

### VFX System

System zur Verwaltung und Steuerung visueller Effekte.

Funktionen:
- Auslösen verschiedener visueller Effekte
- Verknüpfung von Effekten mit Spielmechaniken
- Strukturierte Verwaltung von VFX-Elementen

### Save System

System zur Speicherung und Verwaltung von Spieldaten.

Funktionen:
- Eigene Datenklassen zur Strukturierung von Informationen
- Speichern und Laden von Spieldaten
- Erweiterbare Struktur für weitere Daten

## Projektstatus

Das Projekt befindet sich aktuell in Entwicklung. Neue Systeme werden hinzugefügt und bestehende Funktionen kontinuierlich erweitert und verbessert.
