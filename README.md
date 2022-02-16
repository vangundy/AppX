# AppX
This is an ASP.NET Core Blazor WebAssembly hosted app secured with Azure Active Directory B2C.  It demonstrates an AAD B2C sign out issue.
When users sign out they are automatically signed in when they return to the app.  They should be prompted to enter their credentials instead.

*Reference*

* https://docs.microsoft.com/en-us/aspnet/core/blazor/security/webassembly/hosted-with-azure-active-directory-b2c?view=aspnetcore-5.0
* https://docs.microsoft.com/en-us/azure/active-directory-b2c/session-behavior?pivots=b2c-custom-policy#sign-out
