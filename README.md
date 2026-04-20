# Achieve Default Enter / Escape Behavior with Syncfusion ButtonAdv in WPF
In WPF, the standard Button control supports default and cancel keyboard behavior through the IsDefault and IsCancel properties. This allows users to press Enter to trigger the default action and Escape to trigger the cancel action.

However, Syncfusion’s ButtonAdv control does not expose these properties. This sample demonstrates how to replicate the same behavior for ButtonAdv in a clean and non‑invasive way.

## Overview
This example shows how to simulate:

- **Enter key → Default button behavior**
- **Escape key → Cancel button behavior**

by handling the **PreviewKeyDown** event at the Window level and programmatically invoking ButtonAdv click actions.
This approach ensures that keyboard interactions remain consistent with standard WPF Button behavior.

## What This Sample Demonstrates
* How to simulate IsDefault (Enter key) behavior for ButtonAdv
* How to simulate IsCancel (Escape key) behavior for ButtonAdv
* How to handle keyboard input centrally using the Window’s PreviewKeyDown event
* A lightweight solution that does not require subclassing or modifying ButtonAdv
* Invoke the appropriate ButtonAdv action when the user presses Enter or Escape

## Key Benefits
- Maintains familiar keyboard shortcuts for users
- Works seamlessly alongside existing WPF UI designs
- Easily extensible for additional custom keyboard shortcuts

This approach is useful for dialog-style windows and forms where keyboard accessibility and expected WPF interaction behavior are important.
