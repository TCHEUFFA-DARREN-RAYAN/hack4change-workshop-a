# Hack4Change Workshop Client Repository
This is the sample client repository for the first Hack4Change workshop.

# Getting Started
To start working with this client project, do the following:

- Download Node.js with npm from https://nodejs.org/en/download and follow the instructions to install it. This project was created using Node version 22.22.0, but should work with any recent version of Node.
- Copy this folder to a convenient location, ie. a "project" folder.
- From this directory, run the following command in a command line: `npm install`. This will install all of the project's dependencies.
- Use the scripts listed below to run and test the client.

# Scripts
You can run the following commands from a command line in this directory:

- `npm run dev` will run a development server. When you run the command, it'll provide you with a localhost address that you can use to access the client.
- `npm run build` will compile the client and send its output to a `dist` folder. The folder will contain the HTML page and the assets required to run it.
- `npm run test` will run any unit tests that you've implemented. By convention, unit tests are stored alongside the files that they are testing and end with ".spec.ts". The test runner will continue to run and monitor files for changes, so you can leave this running while developing your application in order to automatically re-run tests as you update your code.
- `npm run e2e` will run any end-to-end tests that you've implemented. These tests are stored in the "tests" directory, and will run the full UI application in the browser. You can use this to automatically test any functionality that you've implemented and make sure that it works across all major browsers.
