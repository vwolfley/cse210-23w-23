# Design Activity

## Scripture Memorizer program specification

### Review the Program Specification

1. What does the program do?
2. What user inputs does it have?
3. What output does it produce?
4. How does the program end?

The program can end in one of two ways: Either the user types quit, or all of the words in the scripture have been hidden.

### Determine the classes

1. What are good candidates for classes in this program?
2. What are the primary responsibilities of each class?

Good choices for classes could include something like:

- Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
- Reference - Keeps track of the book, chapter, and verse information.
- Word - Keeps track of a single word and whether it is shown or hidden.

### Define class behaviors
Go through each of your classes and ask:

1. What are the behaviors this class will have in order to fulfill its responsibilities? (In other words, what things should this class do?)

A class for a Scripture, which has the responsibility to keep track of the reference, the text, and to hide the words, might include some behaviors similar to these:

- Hide Words
- Get Rendered Text
- Is Completely Hidden

A class for a Word, which has the responsibility for storing the text of a word and whether it is hidden or not, might include some behaviors similar to these:

- Hide
- Show
- Is Hidden
- Get Rendered Text

### Define class attributes
Go through each of your classes and ask:

1. What attributes does this class need to fulfill its behaviors? (In other words, what variables should this class store?)
2. What are the data types of these member variables?
3. What constructors should each class have?

### Define Constructors
Now that you have defined the classes, including their methods and attributes, the next step is to think about the constructors you will need to create new instances of these classes. Remember that you can create multiple constructors with different parameters to make it easy to work with your classes.

Remember, that constructors help set up the initial state of the object, so you should consider what data is necessary for that initial state.

1. What constructors should each class have?
    - In other words, what parameters should you pass in when creating an object of that type.
2. What other work needs to be done to set up these objects?
    - For example, does the constructor need to run code to perform set up tasks, like creating lists, iterating through variables, etc.

Every member variable should be private. Getters and Setters should be used to access the data.
Getters should not have any parameters and should not prompt the user for anything, but instead, simply return a value.
Setters should accept a single parameter and have a void return type.