**Note: You can Find Screenshots of this project in Screenshot Folder.**

**Introduction about this Project:**
This Project has login, registration, verify email, change password page.
- First you can register by filling up forms.
- Then, You can login using those credentials.
- you can see some features and description in the project while filling the form such as:
        - Password is matching with confirm password or not
        - Remember me and back option
        - Proper redirection to Login and registration page
- forgot password redirects to verify email page.
- if email is registered in the database then it redirects to change Password page else shows Error Message
- You can also use logout feature.

**Requirements to run this program:**
1. Microsoft Visual Studio (.NET 8.0)
2. MSSQL Server

**To run this app:**
1. First install/download Nuget Packages:
   - Microsoft.EntityFrameworkCore
   - Microsoft.EntityFrameworkCore.SqlServer
   - Microsoft.EntityFrameworkCore.Tools
   - Microsoft.AspNetCore.Identity.EntityFrameworkCore

2. You need to create database using identity builder services. You need to edit server name as per your MSSQL Server in appsettings.json
   then, open Nuget Package Manager Console from Tools Window. Then run These command:
   - add-migration "Init"
   - update-database

Now Run the app.
