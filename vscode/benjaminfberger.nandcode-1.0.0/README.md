# 1bitatatime Extension (v1.0.0)

Official syntax highlighting extension for the **1bitatatime Language**. This extension adds TextMate grammar rules to provide language support and coloring for 1bitatatime.

## Features

* **Keyword Colouring:** Highlights control statements (`in:` and `out:`).
* **Operator Colouring:** Highlights operators (`!&` and `nand`) and assignments (`=`).
* **Constant Colouring:** Highlights constants (`true`, `false`, `1`, `0`).
* **Comment Dimming:** Single-line comment support (`#`).

## Installation
Copy `1bit.lang-1.0.0` into `.vscode\extensions\`

*Note: If syntax highlighting doesn't immediately appear, restart or reload your VS Code window (`Ctrl + Shift + P` -> `Developer: Reload Window`) after running the command to initialize the grammar.*

## Language Specifications

This extension automatically targets any file ending in the **`.1bit`** extension.

### Example Code (XOR block)
```text
in: x y
w = x !& y
x = x !& w
y = y !& w
x = x !& y
out: x
```

## System Requirements

* **VS Code Version:** `^1.75.0` or higher

## Theme Support
Compatible with standard TextMate scopes (`constant.language`, `keyword.control`, `keyword.operator`, `comment.line`). Works out of the box with default themes such as Dark+, Monokai, and GitHub Dark.
