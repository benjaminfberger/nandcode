# nandcode language documentation

The language is evaluated sequentially line-by-line. All lines following a `#` are treated as comments.

### keywords
- **`in:`** declares variables as inputs at the top of the file.
- **`out:`** declares variables as outputs at the bottom of the file.
- **`=`** assigns a value to a variable.
- **`!&`** or **`nand`** evaluates bitwise nand logic: `!(A & B)`.

### constants
`true` and `1` are interchangable. 

`false` and `0` are interchangable. 

### example: swap values x and y ([examples/swap.nand](examples/swap.nand))

```text
in: x y
temp = x
x = y
y = temp
out: x y
```
Check out more [examples](/examples/examples.md). 
## compiling

To compile a source file using the nand transpiler, run
```bash
./nand swap.nand

# Expected output
success[nc000]: compiled binary: swap.exe
```

### running the generated binary
The compiler will create a binary. Execute it by passing space separated binary values (`1` or `0`) corresponding to your `in:` variables:

```bash
# Running with inputs x=1, y=0
./swap 1 0

# Expected Console Output:
output: 0 1
```

## hardware constraints
Everything runs inside a single 64-bit register in the CPU.

Bits 0 and 1 in the virtual ram are reserved for the language. 

A maximum of 62 variables can be declared in total. 

## errors

### fatal errors
`error [nc001]: no arguments given`
 - **cause**: nand compiler run with no source filepath
 - **fix**: pass a valid source as a argument for nand compiler

`error [nc002]: gcc not installed`
 - **cause**: path to gcc compiler could not be found
 - **fix**: ensure gcc is installed by running `gcc --version` in the folder you intend to compile from

`error [nc003]: gcc failed to compile`
- **cause**: nand compiler successfully created the intermediate c code, but gcc could not compile it
- **fix**: pray your code works next time

`error [nc101]: not enough inputs`
- **cause**: not enough inputs passed into compiled binary
- **fix**: pass the correct number of inputs into the compiled program, specified by the number of variables after `in:`, on the first line of your program

`error [nc102]: code must end with out:`
- **cause**: `out:` keyword not present in your program
- **fix**: add `out:` to the last line of your program

`error [nc103]: source empty`
- **cause**: pass empty source file to nand compiler 
- **cause**: pass source file that does not contain `in:`
- **fix**: ensure your program is not empty and contains `in:` at the start of your program

`error [nc201]: out of memory`
- **cause**: exceed 62 assignable variable limit
- **fix**: try to recycle your variables by resetting their values with `myVariable = 0`

`error [nc202]: variable undefined`
- **cause**: using an undefined varible as an operand
- **fix**: define variables before using them as operands

### non-fatal errors (warnings)

`warn [nc401]: source does not end in .nand`
- **cause**: source file does not end in `.nand`
- **fix**: rename your source file to end in `.nand`

`warn [nc402]: program contains no inputs`
- **cause**: no variables declared as inputs in the `in:` block of your program
- **fix**: declare inputs in the `in:` block of your program

`warn [nc403]: program contains no outputs`
- **cause**: no variables declared as outputs in the `out:` block of your program
- **fix**: declare outputs in the `out` block of your program