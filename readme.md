# VFX Challenge Project - How It Works

### How to access the application

- Access https://www.alphavantage.co/support/#api-key to generate an api key

### The Solution

The solution have 2 projects, one is the main (VFXChallenge) and the other is the unit test (VFXChallenge.test).
To execute the application, follow those steps:
- Open the VFXChallenge folder in the Visual Studio
	- Search for the file **Environment.cs** change the value from API_KEY to the generated api key (First Step)
- Execute the application pressing **F5**

### Main Application (VFXChallenge)

#### Login
Filled all the fields inside the login page, if you do not fiiled, those errors will display:
- The ClientId field is required
- The UserId field is required
- The Password field is required
- Password should have at least 5 characters.

#### Home Page
This page will display all the data fetched from the API, case you execute more than 25 times the API an error will display in the screen.

### Unit Test (VFXChallenge.Test)
To execute the unit tests, follow those steps:
- Open the VFXChallenge.Test folder in the Visual Studio
- Right button click in the project, and click in Run Tests
