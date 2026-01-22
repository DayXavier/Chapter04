
//TimesTable(7,255);

#region Writing a function that returns a value

ConfigureConsole();

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"you must pay {taxToPay:C} in tax.");

// Alternatively, call the fuction in the interpolated string.
// WriteLine($"You must pay {CalculateTax{amount: 149, twoLetterRegionCode: "FR"):C} in tax.");

#endregion

#region cardinal to ordinal function

//RunCardinalToOrdinal();

#endregion 

#region Calculating factorials with recursion

//RunFactorial();

#endregion

#region Using lambdas in function implementations 

//RunFibImperative();
RunFibFunctional();
#endregion