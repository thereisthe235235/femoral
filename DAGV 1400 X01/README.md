Read all instructions carefully. Not following instructions will result in you not earning the score you want on this assignment.

# Learning Outcomes
In completing this project, you will learn the following:
1.	Write a simple program that uses these features:
o	Statements 
o	Expressions
o	Basic data types (int, float, string)
o	Convert strings to int or float
o	Keyboard input
o	Printing to console
   - use f-strings when printing values

# Structure
* Code file: `yondu.py`

# Problem
Yondu Udonta and his crew arrive at the Iron Lotus after several weeks of plundering various places around the galaxy. The crew has been in space for nearly six months and they are ready for a night of celebration. Yondu doesn't want to divvy up the plunder just yet, so he gives each crew member other than himself and Peter Quill 3 units and sends them off to the Iron Lotus. (We're keeping the units simple for purposes of the problem, even though 1 standard galactic unit is about $2.33.) After the crew has gone, he and Peter count what's left and decide how to split it up among the crew. Yondu takes 13% of the total. He then gives Peter 11% of what's left. The next morning, Yondu divides the remaining amount evenly among all of the crew, including Yondu and Quill. The crew does not know that Yondu and Quill have already taken a cut.

The problem is to compute how many units each person gets. Round your answers at each step to 2 decimal places.

It should ask a user for two pieces of information:

- How many units the pirates came into port with, and
- How many pirates are on the ship, including Yondu and Quill

The program should then split the units and print out

- Yondu's share
- Peter's share
- The Crew share

# Key Program Requirements and Rubrics
While you might observe that certain rubrics are being automatically graded, please note that these scores will not be transferred to Canvas until your instructor or TA comprehensively reviews the entire project and manually assigns grades after the deadline ends.

#### Automatically-graded scoring (85 points)
1. (35) Results of the various amounts to be calculated are correct to 2 decimal places.
1. (35) The program works correctly for different numbers of crew and units, not just the example run.
1. (5) Input prompts match what is shown in the example run exactly. For example `How many pirates:`
1. (5) Output strings for each amount match the output shown in the example run exactly. For example `Yondu's share: ` followed by the amount.
1. (5) Values are rounded to 2 decimal places.
 
####  Manually graded scoring (15 points)
1. (5) All variable names and the code follows Python snake case or camelcase.
1. (5) Pay attention to whitespace, punctuation and wording in your prompts and output.
1. (5) f-strings for units should be formatted to 2 decimal places for display.

# Example Run
Here's an example interaction showing user input and output:

```markdown
How many pirates:
20
How many units:
1000

Yondu's share: 159.60
Peter's share: 127.15
Crew's share: 36.62
```

Count the 3 coins each crew took for shore leave as part of their total share.


# Strategies For Success

1. Solve the problem using pencil and paper first. Good programmers figured out how to solve a problem before they write the code. This first step is best done collaboratively with another student or in a study group. Once the discussion turns to Python specifics and actually writing code, you must write your own code, not share someone else's.
1. Store a copy of your file on Google Drive, Box, or another private cloud repository where you can retrieve it if needed.
1. Good programmers use a strategy called **stepwise refinement** to write code
    a. Write a simple working version of the program as a first cut-for example, write a program that calculates a percentage of an amount.
    b. Run the program and fix any errors.
    c. Edit the program to add new capabilities.
    d. Test the code with the new changes.
    e. Go back to step b) until done.
1. Start on the project **well before the due date** so you have time to deal with problems and questions that arise. You need time to succeed.
1. Before you submit the final version, verify that it is **complete** and test with different inputs to make sure it is **correct**.

## Frequently Asked Questions
Q: Is there starter code for this project?
A: No, but your code file must be named `yondu.py`.

Q: How do I round to 2 decimal places?
A: Use the built-in `round` function.

Q: When I add up all the amounts from the example run, the total does not add up to 2000. What's wrong?
A: There are 3 possibilities: 1) Your basic calculations are wrong somewhere; 2) You did not round correctly; 3) Your results are suffering from rounding errors. The 3rd thing is common when we deal with floating point numbers on digital computers--don't worry about it for now as long as you did 1 and 2 correctly.
