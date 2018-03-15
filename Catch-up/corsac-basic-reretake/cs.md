# Tasks
## 1-3. Complete the following tasks:
- [Multiplication table](multiplicationtable/MultiplicationTable.cs)
- [Crashes](crashes/Crashes.cs)
- [Fish Tank](fishtank/FishTank.cs)

### Acceptance criteria
The application is accepted if:
- The solution works according to specification [1p each]
- The solution follows [styleguide](https://github.com/greenfox-academy/teaching-materials/blob/master/styleguide/cs.md) [1p]
- Has the correct loops, methods, filters [1p each]
- The code is clean, without unnecessary repetition, and with descriptive names [1p each]
- You commit frequently with descriptive commit messages [1p]

## 4. Question time! [4p]

### List the three most frequently used access modifiers. [2p]

#### Your answer:
* public
* private
* protected


### What are we use them for? [2p]

#### Your answer:
When the scope of a class or struct member is marked public, it will become accessible by basically all methods inside and outside the same namespace, as well as the children of the class the member is located in.

When the scope of a class or struct member is marked private, it is absolutely the opposite: it will be accessible only within the class the member belongs to. To access it, or to modify it (like assign a new value to it) the use of get and set methods is required.

When the scope of a class or struct member is protected, it will be accessible either within the class itself, and in any class derived from it. 

