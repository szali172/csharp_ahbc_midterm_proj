# csharp_ahbc_midterm_proj
Midterm Project for the C# After Hours Bootcamp

*Link to Midterm Project - https://docs.google.com/document/d/1eJkUO6kITxvUXGIyv6o3hlcZP6BViqUM3w4Wamn1W2k/preview#heading=h.ve9iwzmwy11g

//*********************//

*Specific instructions are for FITNESS CENTER

Write a console application for a fitness center to help manage members and membership options.  At a minimum, this program should include:

A class to hold basic details about Members (this class should eventually have at least 2 child classes) and hold the following details at a minimum:
	*id, name
	*an abstract method void CheckIn(Club club)


A minimum of two child classes that represent a Single Club Member and Multi-Club Members (these members can visit various locations using the same membership). The classes should have the following:
	*Single Club Members: a variable that assigns them to a club. The CheckIn method throws an exception if it’s not their club.
	*Multi-Club Members: a variable that stores their membership points. The CheckIn method adds to their membership points.

A Club class that holds basic details about each fitness club, including at minimum:
	*name, address

Allow users to:
	*Add members (both kinds), remove members or display member information.
	*Check a particular member in at a particular club. (Call the CheckIn method). Display a friendly error message if there is an exception. Don’t let it crash the program.
	*Select a member and generate a bill of fees. Include membership points for Multi-Club Members.

A main class which takes input from the user:
	*Asks a user if they want to select a club
	*Added members should be given the option to select from at least 4 fitness center locations or have the option to be a multi-club member.


Optional enhancements:
	*(Easy/Medium) Allow new members to receive discounts if they sign up during certain time periods, explore the DateTime library for help with date and time.
	*(Medium) Store clubs and members in text files.
	*(Hard) Out Pizza the hut 


