# PersonAddressApp

A small C# desktop sample application demonstrating the same person-and-address workflow in both **WinForms** and **WPF**.

The project was originally built on **.NET 7** and explores how shared application logic can be reused across different desktop UI frameworks while keeping the user interaction model similar.

## What this project demonstrates

- A basic person and address management workflow
- Two desktop UI implementations:
  - WinForms
  - WPF
- Shared business/data logic outside the UI layer
- Export support for structured data such as JSON and CSV
- Differences in binding and UI interaction between WinForms and WPF

## Project structure

- **WinForms application**  
  Original desktop implementation for adding and viewing people and their addresses.

- **WPF application**  
  A later implementation that adapts the same workflow to a WPF UI model.

- **Shared libraries**  
  Logic moved out of UI event handlers into reusable library code where possible.

## Current features

- Add and view people
- Add one or more addresses per person
- Support for multiple address types
- Export data to JSON and CSV

## Technical notes

This project began as a learning exercise and evolved into a comparison of two desktop application approaches in the .NET ecosystem. It highlights some of the practical differences between WinForms and WPF, especially around event handling, data binding, and UI composition.

## Potential future improvements

- Edit/update support for people and addresses
- Persistent storage through database or API integration
- Import/load workflows for JSON or CSV
- Improved model identity and sorting support
- Retargeting from .NET 7 to a supported framework version