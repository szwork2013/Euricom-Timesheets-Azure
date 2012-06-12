# Working together: Euricom-Timesheets-Azure

## Technology stack

- ASP.NET MVC 4 RC (Hosted as a Azure Web Site)
- ASP.NET WebAPI RC
- EF 5.0 RC
- SQL Azure
- Twitter bootstrap
- Knockout.js 2.1.0
- Deployment via continuous integration with TFS Online Preview

## Installation

- Visual Studio 2012
- Azure SDK 1.7

## Day 1

### Slot 1

- Add timesheet datamodel to database

Timesheet
- Name: firstname and lastname
- Month
- Days (date, code, customer, remarks)

### Slot 2

- Build UI
- Get days through Web API

### Slot 3

- Add method to Web API to post timesheet
- Modify UI to support post
