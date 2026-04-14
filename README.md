# Mechanic Shop Management System

A desktop application for mechanic shops to manage customers, vehicles, repair orders, labor/parts tracking, and invoicing. Built with Windows Forms and C#.

**Status:** Core functionality complete — VIN lookup, authentication, repair orders, and database integration.

---

## Features

### Completed (Thimmy)
- **VIN Lookup API Integration** — Auto-populate vehicle make, model, and year from NHTSA database
  - Enter 17-character VIN → Click "Lookup" → Fields auto-fill
  - Error handling for invalid VINs, network issues, and missing data
  - Test VIN: `1HGCM82633A123456` (returns: HONDA, ACCORD, 2003)
- **Complete Repair Order System**
  - Create, edit, and view repair orders
  - Add labor line items (description, hours, hourly rate)
  - Add parts line items (part name, quantity, unit cost)
  - Automatic cost calculation (labor total, parts total, grand total)
  - Status tracking: Pending, In Progress, Completed, Invoiced
  - Customer complaint field
- **Repair Order Search** — Filter by customer name, date range, and status
- **Main Form Dashboard** — Navigation menu with role-based access
- **Customer Management** — Full CRUD operations with ListView interface
  - Add, edit, delete customers
  - Search customers by name, phone, or email
  - ListView display with Name, Phone, Email columns
  - Real-time validation and error handling
- **Vehicle Management** — Add, edit vehicles with VIN lookup
- **Database Integration** — Microsoft Access backend with full CRUD operations
  - `DBHelper.cs` with GetAllCustomers, AddCustomer, UpdateCustomer, DeleteCustomer
  - Parameterized queries for SQL injection protection
  - Customers table with proper schema

### Completed (Edwin)
- Login form with username/password validation
- Hardcoded admin credentials for testing
- Clear and Exit functionality
- Session management with UserSession helper

### Authentication System
- User roles: Admin, Staff, Mechanic
- Session management with `UserSession` static class
- Failed login attempt limit (3 attempts)
- Role-based menu visibility
- Login flow with while-loop for logout → login cycle

### In Progress
- **VIN Lookup API Integration** — Auto-populate vehicle details from NHTSA database
- **Vehicle Management** — Add, edit vehicles with VIN lookup
- **Repair Order System** — Labor/parts tracking and cost calculation

### Planned
- Invoice generation
- Appointment scheduling
- Inventory management
- Customer portal
- Reporting dashboard

---

## API Integration

### Endpoint Used
- GET https://vpic.nhtsa.dot.gov/api/vehicles/DecodeVinValues/{VIN}?format=json

### How It Works
1. User enters a 17-character VIN in the Vehicle Form
2. Clicks "Lookup VIN" button
3. Application sends GET request to NHTSA API
4. JSON response is parsed to extract Make, Model, and Year
5. Form fields are automatically populated

### Example Response
```json
{
  "Results": [
    {
      "Make": "HONDA",
      "Model": "ACCORD",
      "ModelYear": "2003"
    }
  ]
}
