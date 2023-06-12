NuGet Package for handling OpenAi Requests

Notes for future: 
- ConfigureAwait should be applied for all asynchronous places, for preventing possibble exceptions linked with synchronizationContext.
- Make Handler class internal!!! Not sealed, we have public abstraction for it!
