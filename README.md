# Implementation of a calculator with C#

In the context of this task, I will implement a simple calculator in C#.The focus of this programming task is less on mathematical sophistication than on the knowledge and correct application of object-oriented concepts.You are to implement a simple integer calculator that can adequately perform the four basic arithmetic operations with integers. You will extend and expand the initial version of the calculator step by step.

Create a Calculator programme that can perform the four basic arithmetic operations: addition, subtraction, multiplication and (integer) division. Proceed step by step:

- Implement one (public) method for each of the four basic operations. All methods should take two parameters of the type int and return an int value as the result.
- The input and output for the Calculator programme is to take place via the console. It is sufficient (for the moment) if you select one of the four arithmetic operations each time the programme is executed, execute it, output the result and the programme is then terminated.
  - Use for input: Console.ReadLine()
  - Use for output: Console.WriteLine()

## Extension 1: Internal buffer

Extend your calculator programme by fulfilling the following two requirements. For the implementation of these requirements, it will be necessary to be able to perform several arithmetic operations in succession after starting the programme. For this purpose, it is necessary to repeatedly execute the reading of the operands and the operation, the calculation and the output of the result in a loop.

- The programme should store the result of the last arithmetic operation as an internal status.
- Each arithmetic operation should now optionally be able to be called up with a single parameter. For the execution of this method, use the internally stored intermediate result of the previous arithmetic operation as the first operand (summand or minuend or multiplicand or dividend) and the only parameter of the method call as the second operand (summand or subtrahend or multiplicand or divisor).

## Extension 2: Any number of operands

Your calculator programme is almost ready for the market. With the upcoming extension, you will now make your calculator even more flexible. It should now be possible to execute each of the four basic arithmetic operations with three, four, five or six operands (=parameters). You will quickly realise that with an increasing number of parameters you can no longer use the concept of overloading methods (writing effort and code duplication are too great). Fortunately, however, there is a good solution to this problem with C#: use the keyword paramsum to implement methods with any number of parameters (of the same type). While keeping the previous requirements (especially for the specification of a single parameter), you should now extend your programme so that for each of the four basic arithmetic operations any number of int values can be passed as parameters.

- If only one parameter is passed, the internally stored intermediate result of the previous arithmetic operation is to be used as the first operand.
- With two and more parameters, the intermediate result is ignored for the arithmetic operation (but updated at the end).
  - Addition: Add all summands.
  - Subtraction: Treat the first parameter as a minuend and all other parameters as subtrahends.
  - Multiplication: Treat the first parameter as a multiplicand and all other parameters as multipliers.
  - Division: Treat the first parameter as a dividend and all other parameters as divisors.

## Contributing

This is a personal learning project for me. Please feel free to fork this repo. Pull request to submit more programs.

## Feedback

If you find any bug or have any suggestion, please do file issues. I am graceful for any feedback and will do my best to improve this package.

## License

[MIT](LICENSE) © 2020 Ioannis Christodoulakis
