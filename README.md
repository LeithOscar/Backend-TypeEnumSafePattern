# Type Enum Safe Pattern
TypeEnumSafePattern

The enum type in C# is really handy. Developers can quickly set up a set of domain-specific keywords that are treated as constants within their application. It provides a better method of defining and using magic strings or numbers. They can be used in switch statements, producing clean, readable code.


However, they have their bad part, because the enums are just numbers. There are many times where the developer wants to display the list of these enum, in a list UI, adding complexity to obtain the resources or finally to use magic strings

# Foro Class
Through the constructor we can initialize the "Forum" with a name as an argument, then this will be created with an "Open" State.
There is a "ChangeState" methods where the user can modify the current state of this. This method is overwritten where you can see the reflection using #Enum or Sealed Class

Also, you can see on tests solutions where not give error and allows us to introduce invalid characters <code> ForoTets.cs </code>

<code> foro.ChangeState((ForoState)3); </code> obviously, the test give me an error.
