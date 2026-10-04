# nandcode (v1.0.0)

This language explores the absolute limits of computational minimalism by using NAND as its sole logical operation. Every logical gate, variable mutation, and hardware component is built entirely by chaining and reusing variables with this single primitive.

This repository has the transpiler, vscode syntax highligher and documentation.

The runtime enforces a strict **64-bit virtual hardware environment** mapped entirely within a single physical CPU register, requiring zero RAM allocation overhead during active execution layers.

Every program in nandcode runs in O(N) time and O(1) space. 

## repository structure

- `src/`: source code
- `tests/`: unit tests
- `examples/`: example code
- `vscode/benjaminfberger.nandcode-1.0.0`: vscode syntax highlighting extension
- `docs/`: documentation on hardware contraints and language structure
- `misc/`: old c code

## examples

### example: swap values x and y ([examples/swap.nand](/examples/swap.nand))

```text
in: x y
temp = x
x = y
y = temp
out: x y
```

### example: x xor y ([examples/xor.nand](/examples/xor.nand))

```text
in: x y
w = x !& y
x = x !& w
y = y !& w
x = x !& y
out: x
```
Check out more [examples](/examples/examples.md). 

## compiling

To compile a source file using the nand transpiler, run
```bash
./nand swap.nand

# Expected output
success[1b000]: compiled binary: swap.exe
```

### running the generated binary
The compiler will create a binary. Execute it by passing space separated binary values (`1` or `0`) corresponding to your `in:` variables:

```bash
# Running with inputs x=1, y=0
./swap 1 0

# Expected Console Output:
output: 0 1
```

For comprehensive information on errors or warnings, or if you just want to learn more, refer to the [documentation](/docs/docs.md) or read the [wiki](https://esolangs.org/wiki/Nandcode).
