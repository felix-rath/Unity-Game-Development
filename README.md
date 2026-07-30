# Unity Game Project

Dieses Repository enthält Ausschnitte meines aktuellen Unity-Spielprojekts, das ich in meiner Freizeit mit C# entwickle.

## Über das Projekt

Bei dem Projekt handelt es sich um ein Roguelike-RPG, bei dem der Fokus auf modularen Spielsystemen und erweiterbaren Mechaniken liegt.

Ich entwickle verschiedene Systeme selbstständig, darunter Spielersteuerung, Fähigkeiten, Inventar, Schaden und Speicherung von Spieldaten.

Das Projekt befindet sich aktuell in der Prototyping-Phase. Der Schwerpunkt liegt auf dem Aufbau einer flexiblen Systemstruktur sowie dem Testen und Erweitern neuer Spielmechaniken.

## Technologien

- C#
- Unity Engine
- Objektorientierte Programmierung
- ScriptableObjects
- Event-basierte Kommunikation
- Unity Input System

## Player System

Ein eigenes System zur Steuerung und Verwaltung des Spielers.

Funktionen:
- Spielerbewegung
- Verarbeitung von Eingaben über das Unity Input System
- Kommunikation zwischen verschiedenen Systemen über Events

## Ability System

Ein modulares Fähigkeitensystem zur Verwaltung verschiedener Fähigkeiten.

Funktionen:
- ScriptableObject-basierte Fähigkeiten
- verschiedene Ability-Typen
- Cast-System
- Cooldowns
- Stat-Modifikatoren
- Erweiterbare Struktur für neue Fähigkeiten

## Inventory System

Ein System zur Verwaltung von Fähigkeiten und Ability-Slots.

Funktionen:
- Verwaltung verschiedener Ability-Slots
- Trennung von Daten und Logik
- Erweiterbare Struktur für neue Inhalte

## Damage System

Ein System zur Berechnung und Verarbeitung von Schaden.

Funktionen:
- Schadensberechnung
- Verwaltung verschiedener Stats und Attribute
- Unterstützung unterschiedlicher Schadensmechaniken
- Erweiterbarkeit für neue Systeme

## Save System

Ein System zur Speicherung und Verwaltung von Spieldaten.

Funktionen:
- Eigene Datenklassen zur Strukturierung von Informationen
- Speichern und Laden von Spieldaten
- Erweiterbare Struktur für weitere Daten

## Projektstatus

Das Projekt befindet sich derzeit in Entwicklung. Neue Systeme werden regelmäßig hinzugefügt und bestehende Funktionen weiter verbessert.
