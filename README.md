# Probability Calculator

A full-stack application built with ASP.NET Core (Web API) and React (Vite).

## 🛠 Prerequisites
- .NET 8.0 or 9.0 SDK
- Node.js (v20 or higher)
- Visual Studio 2022 

## 🚀 How to Run

### Step 1: Start the Backend
1. Open `APICode/ProbabilityCalculator.sln` in Visual Studio.
2. Ensure the project is set to run on `https://localhost:7063`.
3. Press **F5** to start the API (Swagger will open).

### Step 2: Start the Frontend
1. Open a terminal in the `ReactCode/` folder.
2. Run `npm install` to install dependencies.
3. Run `npm run dev`.
4. Open your browser to the URL shown in the terminal.

**Usage:** Enter two probabilities (e.g., 0.5 and 0.5) and click Calculate.

- **APICode:** Uses a Service-Repository architecture and configured cors to accept api call from react.
- **Frontend:** Built with React/Vite using Axios and a configured proxy to avoid CORS issues.