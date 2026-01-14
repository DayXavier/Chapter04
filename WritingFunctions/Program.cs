
//TimesTable(7,255);

#region Writing a function that returns a value

ConfigureConsole(culture: "fr-FR");

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"you must pay {taxToPay:C} in tax.");

// Alternatively, call the fuction in the interpolated string.
// WriteLine($"You must pay {CalculateTax{amount: 149, twoLetterRegionCode: "FR"):C} in tax.");

#endregion