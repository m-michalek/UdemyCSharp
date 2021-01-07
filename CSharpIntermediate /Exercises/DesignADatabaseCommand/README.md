Now that we have the concept of a DbConnection, let’s work out how to represent a
DbCommand.

Design a class called __DbCommand__ for executing an instruction against the database. A
__DbCommand__ cannot be in a valid state without having a connection. So in the constructor of
this class, pass a __DbConnection__. Don’t forget to cater for the null.

Each __DbCommand__ should also have the instruction to be sent to the database. In case of SQL
Server, this instruction is expressed in T-SQL language. Use a string to represent this instruction.
Again, a command cannot be in a valid state without this instruction. So make sure to receive it
in the constructor and cater for the null reference or an empty string.

Each command should be executable. So we need to create a method called __Execute()__. In this
method, we need a simple implementation as follows:

Open the connection
Run the instruction
Close the connection

Note that here, inside the __DbCommand__, we have a reference to __DbConnection__. Depending on
the type of __DbConnection__ sent at runtime, opening and closing a connection will be different.
For example, if we initialize this __DbCommand__ with a SqlConnection, we will open and close a
connection to a Sql Server database. This is polymorphism. Interestingly, __DbCommand__ doesn’t
care about how a connection is opened or closed. It’s not the responsibility of the __DbCommand__.
All it cares about is to send an instruction to a database.

For running the instruction, simply output it to the Console. In the real-world, SQL Server (or any
other DBMS) provides an API for running an instruction against the database. We don’t need to
worry about it for this exercise.

In the main method, initialize a __DbCommand__ with some string as the instruction and a
__SqlConnection__. Execute the command and see the result on the console.

Then, swap the __SqlConnection__ with an __OracleConnection__  and see polymorphism in action.