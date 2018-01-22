# jkulubya.UG.PhoneNumberParser

A little .NET Standard 2.0 utility to parse Ugandan phone numbers. Built with [Sprache](https://github.com/sprache/Sprache).

## Installation
```
dotnet add package jkulubya.UG.PhoneNumbers --version 0.0.1 
```

## Usage
```
using jkulubya.UG;

// skipped for brevity

var input = "0772000111";

var result = PhoneNumberParser.Parse(input);

/*
* Console.WriteLine(result.CountryCode);
* > 256
*
* Console.WriteLine(result.LocalPortion);
* > 772000111
*
* Console.WriteLine(result.ToString());
* > 256772000111
*/
```

## License
MIT License