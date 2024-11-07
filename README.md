README.md for Full-Stack Contacts Management Application
Contacts Management Application
This project is a full-stack application that allows users to manage contacts. The application uses Angular (v13+) for the frontend and .NET Core (v6+) for the backend. The data is stored in a local JSON file, simulating a mock database. The application supports basic CRUD (Create, Read, Update, Delete) operations and includes validation for the contact fields. The backend has global error handling, and the frontend uses Reactive Forms with Bootstrap for styling.

Table of Contents
Features
Technologies Used
Backend Setup
Frontend Setup
How to Run
Design Decisions
Testing
Scalability Considerations
Code Structure
Features
CRUD Operations: Create, Read, Update, and Delete contacts.
Validation: Enforces unique IDs, valid email format, and required fields for first name, last name, and email.
User Feedback: Provides detailed feedback for each operation (success or failure).
Bootstrap UI: Responsive, clean, and user-friendly UI built with Bootstrap.
RxJS for State Management: Handles data flow and operations with RxJS observables.
Error Handling: Backend returns appropriate error responses for failed operations.
Technologies Used
Frontend:
Angular (v13+)
RxJS (for state management)
Bootstrap (for styling)
Angular Reactive Forms (for form handling)
Backend:
.NET Core 6+
ASP.NET Core Web API
Local JSON file as a mock database
Backend Setup
Clone the repository:

cd contact-manager
Navigate to the Backend Folder:

Ensure you are in the ContactManagerAPI folder:

bash
Copy code
cd ContactManagerAPI
Restore Dependencies:

Run the following command to restore the NuGet packages:

bash
Copy code
dotnet restore
Run the Backend API:

To run the backend locally, use the following command:

bash
Copy code
dotnet run
The backend will run on https://localhost:5001.

API Endpoints:

GET /api/contacts: Retrieve all contacts.
GET /api/contacts/{id}: Retrieve a contact by ID.
POST /api/contacts: Add a new contact.
PUT /api/contacts/{id}: Update an existing contact.
DELETE /api/contacts/{id}: Delete a contact.
Frontend Setup
Navigate to the Frontend Folder:

Ensure you are in the contact-manager folder:

bash
Copy code
cd contact-manager
Install Dependencies:

Install the necessary dependencies using npm:

bash
Copy code
npm install
Start the Frontend:

Run the Angular frontend:

bash
Copy code
ng serve
The application will be available at http://localhost:4200.

How to Run the Application
Ensure the Backend is Running:

First, run the .NET Core Web API backend as described in the backend setup.

Run the Frontend:

In a new terminal window, navigate to the frontend directory and run the Angular application.

bash
Copy code
ng serve
Open the Application:

Open your browser and navigate to http://localhost:4200 to interact with the application.

Design Decisions
Frontend:

The Reactive Forms module was used for form validation and handling. This ensures easy and scalable management of form controls and validation.
RxJS is used to manage asynchronous operations and state updates in the frontend, making the app more scalable and responsive to changes.
Bootstrap was used for UI components and styling, allowing for a clean, responsive design.
Backend:

The API uses a mock JSON file as a simple database to store contacts. Each contact has an auto-incrementing ID.
Global Error Handling is implemented to ensure the frontend receives appropriate error responses for invalid or failed operations.
Validation:

Frontend Validation: The frontend validates form fields (First Name, Last Name, and Email) using Angular’s built-in validators.
Backend Validation: The backend ensures that contact IDs are unique and that required fields are present.
Testing
Unit Tests:
Unit tests are written for both frontend and backend components using their respective testing frameworks (Jasmine/Karma for Angular and xUnit for .NET Core).
Integration Tests:
Integration tests cover the main workflows, such as adding a new contact and deleting an existing one.
Scalability Considerations
Frontend:

The use of RxJS allows the frontend to scale with a large number of contacts. It enables the app to handle asynchronous data fetching, updating, and rendering efficiently.
If pagination, sorting, or filtering is added, the Angular frontend can be easily extended to handle large datasets without degrading performance.
Backend:

The current design relies on a local JSON file, which is a simple solution for mock data. However, as the number of contacts grows, this approach can become inefficient.
Future scalability could involve integrating a database (e.g., SQL Server, MongoDB) and adding caching layers to handle larger data volumes more efficiently.
Code Structure
Backend (ContactManagerAPI):
Controllers: Contains all CRUD operations for contacts (ContactsController.cs).
Models: Defines the structure of the contact (Contact.cs).
Data: Simulated data storage using a JSON file.
Frontend (contact-manager):
Components:

contact-list: Displays the list of contacts in a table.
contact-form: A form to add or update contacts.
Services:

contact.service.ts: Handles API calls for CRUD operations.
Models:

contact.model.ts: Defines the structure of the contact used in both the frontend and backend.
Extra Challenges (Optional)
Search: Implement a search feature to filter contacts based on name or email.
Sorting: Allow sorting of contacts by name or email.
Pagination: Add pagination to handle large contact lists.
Final Notes
Ensure you have both the frontend and backend running simultaneously to interact with the application.
The code is structured to be easily extendable. For example, adding additional fields to the contact model or changing the data storage method will not require major architectural changes.
This project can be extended further to include features like user authentication, role-based access, or the use of a real database.
