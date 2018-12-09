Thanks for taking the time to review.

I have attempted to quickly demonstrate my understanding of SOLID principals with my design. Each Class should ideally have one responsibility (i.e. controlling the game, or the rolling of dice, etc). It felt better to me to create a central Game class which would orchestrate what was going on behind the scenes, but I could have also seperated out and not bothered with that class for the tests, it just felt like the game wouldn't sit well together without something pulling the strings.

This is definitely not the finished article, and is relatively hurried, due to the time constraints, the real thing I wanted to get across was the O/C principal. e.g. by being able to swap out the Die for another class, which would actually have a different implementation (Maybe 2 dice? Maybe a special game die which goes up to 8, etc). You may also want to create a TokenFactory class, so that you could create different implementations of the Token (e.g. if you're playing with a child, maybe their move counts for double? This way you could potentially attempt to create a set of difficulty settings). And also, I should be able to do the snakes/ladders concept relatively easily by creating more special squares within the board (e.g. if you land on cell X, then the result of a snake would be you were moved to cell Y). 

I have used SpecFlow to write the tests, purely because the Tech Test was written in such a way, and therefore felt easy to port over. I would normally write Unit Tests against the code too to ensure quality, but felt that this demonstrated what I could do well enough.

There's obviously some code in here which could be moved out to extension methods or other providers, and I went too far on some parts, like the TurnProvider, as I see that this is something which will be implemented later.

If you would like to download and build/run, you should be able to run the tests with MS Test Runner (you may need to install NUnit 3 Test Adapter due to specflow), otherwise you should be good to go.

Let me know if you have any questions.

Thanks,

Phil