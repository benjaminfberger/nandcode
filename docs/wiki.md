# Nandcode

**Nandcode** was made by Benjamin F. Berger in 2026. It explores the absolute limits of computational minimalism by using NAND as its sole logical operation. Every logical gate, variable mutation, and hardware component is built entirely by chaining and reusing variables with this single primitive. The runtime enforces a strict 64-bit virtual hardware environment mapped entirely within a single physical CPU register, requiring zero RAM allocation overhead during active execution layers. Every program in nandcode runs in O(N) time and O(1) space. The language is evaluated sequentially line-by-line. All lines following a `#` are treated as comments.

## Keywords
- **`in:`** declares variables as inputs at the top of the file.
- **`out:`** declares variables as outputs at the bottom of the file.
- **`=`** assigns a value to a variable.
- **`!&`** or **`nand`** evaluates bitwise nand logic: `!(A & B)`.

## Constants
`true` and `1` are interchangable.

`false` and `0` are interchangable.

## Constraints
Everything runs inside a single 64-bit register in the CPU.

Bits 0 and 1 in the virtual ram are reserved for the language.

A maximum of 62 variables can be declared in total.

## Examples
### Swap values x and y
```
in: x y
temp = x
x = y
y = temp
out: x y
```

### x XOR y
```
in: x y
w = x !& y
x = x !& w
y = y !& w
x = x !& y
out: x
```

### x OR y
```
in: x y
x = x !& x
y = y !& y
x = x !& y
out: x
```

### x AND y
```
in: x y
x = x !& y
x = x !& x
out: x
```

### NOT x
```
in: x
x = x !& x
out: x
```

# Errors
## Fatal Errors
`error [no arguments given`
- **cause**: nand compiler run with no source filepath
- **fix**: pass a valid source as a argument for nand compiler

`error [nc002](nc001]:): gcc not installed`
- **cause**: path to gcc compiler could not be found
- **fix**: ensure gcc is installed by running `gcc --version` in the folder you intend to compile from

`error [gcc failed to compile`
- **cause**: nand compiler successfully created the intermediate c code, but gcc could not compile it
- **fix**: pray your code works next time

`error [nc101](nc003]:): not enough inputs`
- **cause**: not enough inputs passed into compiled binary
- **fix**: pass the correct number of inputs into the compiled program, specified by the number of variables after `in:`, on the first line of your program

`error [code must end with out:`
- **cause**: `out:` keyword not present in your program
- **fix**: add `out:` to the last line of your program

`error [nc103](nc102]:): source empty`
- **cause**: pass empty source file to nand compiler
- **cause**: pass source file that does not contain `in:`
- **fix**: ensure your program is not empty and contains `in:` at the start of your program

`error [out of memory`
- **cause**: exceed 62 assignable variable limit
- **fix**: try to recycle your variables by resetting their values with `myVariable = 0`

`error [nc202](nc201]:): variable undefined`
- **cause**: using an undefined varible as an operand
- **fix**: define variables before using them as operands

## Non-Fatal Errors (Warnings)
`warn [source does not end in .nand`
- **cause**: source file does not end in `.nand`
- **fix**: rename your source file to end in `.nand`

`warn [nc402](nc401]:): program contains no inputs`
- **cause**: no variables declared as inputs in the `in:` block of your program
- **fix**: declare inputs in the `in:` block of your program

`warn [program contains no outputs`
- **cause**: no variables declared as outputs in the `out:` block of your program
- **fix**: declare outputs in the `out` block of your program

*Note: This is a copy of the wiki page at [esolangs.org](https://esolangs.org/wiki/Nandcode)*
