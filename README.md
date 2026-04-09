# Mechanic Shop Management System

A desktop application for mechanic shops to manage customers, vehicles, repair orders, labor/parts tracking, and invoicing. Built with Windows Forms and C#.

**Status:** In Development — VIN lookup API complete, authentication in progress.

---

## Features

### Current (Design Phase)
- Customer & vehicle management
- Repair order lifecycle (create, update, close)
- Labor and parts line items with automatic cost calculation
- Mechanic assignment and performance tracking
- Service type templates for quick data entry
- Role-based access (Service Advisor, Mechanic, Shop Owner)

### In Progress
- **Authentication** — Login form complete (Edwin). Next: roles, session, attempt limits.

### Planned
- Appointment scheduling
- Inventory management
- Customer portal
- Payment processing
- Reporting dashboard

---
### Completed (Thimmy)
- **VIN Lookup API Integration** — Auto-populate vehicle make, model, and year from NHTSA database
  - Enter 17-character VIN → Click "Lookup" → Fields auto-fill
  - Error handling for invalid VINs, network issues, and missing data
  - Test VIN: `1HGCM82633A123456` (returns: HONDA, ACCORD, 2003)

---

### Completed (Edwin)
- Login form with username/password validation
- Hardcoded admin credentials for testing
- Clear and Exit functionality

### Needs Improvement
- [ ] User roles (Admin, Staff, Mechanic)
- [ ] Session state management
- [ ] Failed login attempt limits
- [ ] Role-based access control
- [ ] Database user storage (currently hardcoded)

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
