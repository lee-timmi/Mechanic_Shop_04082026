# Mechanic Shop Management System

A desktop application for mechanic shops to manage customers, vehicles, repair orders, labor/parts tracking, and mechanic assignments. Built with Windows Forms and C#, backed by a Microsoft Access database.

**Status:** Core functionality complete. SOLID refactor applied.

---

## Team

| Feature Area | Developer |
|---|---|
| Customer Management | Thimmy |
| Vehicle Management | Thimmy |
| Repair Order System | Thimmy |
| Database Integration | Thimmy |
| VIN Lookup API | Thimmy |
| Mechanic Management | Edwin |
| Repair Order History | Edwin |
| Authentication System | Edwin |

---

## User Flow

### Getting Started
Log in with your credentials. Before creating repair orders, add at least one mechanic via **Mechanics** on the dashboard.

### Adding a Customer and Vehicle
1. Go to **Customers** → fill in the customer's details → click **Add Customer**
2. Select the customer from the list → click **Manage Vehicles**
3. Enter the VIN and click **Lookup VIN** to auto-fill the vehicle details, then click **Add Vehicle**

### Creating a Repair Order
1. Go to **Customers** → select a customer → click **New Repair Order**
2. Select the vehicle, set the status, and enter the customer complaint
3. Add labor and parts using the quick buttons or custom entry — assign a mechanic to each labor item when prompted
4. Click **Submit** to save

### Viewing and Editing Orders
Go to **Repair History** to search and filter all orders. Select an order to view, edit, or delete it. Rows are color-coded by status — yellow (Pending), blue (In Progress), green (Completed).

### Managing Mechanics
Go to **Mechanics** to add, edit, or delete mechanics. Mechanics added here appear as options when assigning labor on a repair order.

---

## Features

### Customer Management (Thimmy)
- Full CRUD operations with ListView interface
- Add, edit, delete customers
- Search customers by name, phone, or email
- Real-time validation and error handling
- Customer selection enables "Manage Vehicles" and "New Repair Order" buttons

### Vehicle Management (Thimmy)
- Full vehicle management within a single form — add, edit, delete
- Vehicles linked to a specific customer, loaded automatically when the form opens
- VIN Lookup API Integration (NHTSA)
  - Enter 17-character VIN → Click "Lookup" → Auto-fills Make, Model, Year
  - Error handling for invalid VINs, network issues, and missing data
  - Test VIN: `1HGCM82633A123456` (returns: HONDA, ACCORD, 2003)
- Current mileage tracked per vehicle
- License plate stored and displayed

### Repair Order System (Thimmy)
- Create and manage repair orders for customer vehicles
- Auto-generated order numbers (RO-YYYY-XXXX format)
- Customer and vehicle dropdowns (vehicle list auto-filters by selected customer)
- Current mileage auto-loads when vehicle is selected
- Status tracking: Pending, In Progress, Completed, Invoiced
- Customer complaint field (Long Text — no character limit)
- Automatic cost calculation (labor total, parts total, grand total)
- **Quick-add buttons for common services:**
  - Labor: Oil Change, Brake Pad Replacement, Tire Rotation, Engine Diagnostic
  - Parts: Oil Filter, Air Filter
- Custom labor and parts items via input dialogs
- Mechanic assignment per labor line item (prompt appears on all labor adds)
- Remove items from grids with safety checks
- View (read-only) and Edit modes controlled via `RepairOrderFormMode` enum

### Repair Order History (Edwin)
- View all repair orders in a searchable, filterable grid
- Filter by customer name, vehicle, status, or date range
- Color-coded rows by repair status:
  - 🟡 Pending — yellow
  - 🔵 In Progress — blue
  - 🟢 Completed — green
- View details (read-only) or edit existing repair orders
- Delete repair orders with confirmation (cascades to labor and parts)
- Record count display

### Mechanic Management (Edwin)
- Full CRUD operations for shop mechanics
- Fields: First Name, Last Name, Specialty, Hourly Rate, Phone
- Search mechanics by name
- ListView display with all fields
- Mechanics available for assignment when adding labor to repair orders

### Authentication System (Edwin)
- Login form with username/password validation
- User roles: Admin, Staff, Mechanic
- Session management via `UserSession` static class
- Failed login attempt limit (3 attempts)
- Role-based menu visibility on main dashboard

### Database Integration (Thimmy)
- Microsoft Access backend (`.accdb`)
- Repository pattern — each table has its own dedicated repository class
- `DBHelper` acts as a facade delegating to individual repositories
- Transaction support for repair order saves and updates
- Parameterized queries with explicit `OleDbType` on all parameters
- Proper Access multi-JOIN syntax with parentheses
- Relationships: Customers → Vehicles → RepairOrders → LaborLineItems / PartsLineItems → Mechanics

---

## Architecture

This project follows SOLID principles. Forms delegate to service and repository classes rather than handling business logic or database access directly.

### Repositories (`Helper/`)
Each repository handles one table only:

| Class | Responsibility |
|---|---|
| `BaseRepository` | Shared connection string setup |
| `CustomerRepository` | Customer CRUD |
| `VehicleRepository` | Vehicle CRUD |
| `RepairOrderRepository` | Repair order CRUD, search, order number |
| `LaborRepository` | Labor line item reads |
| `PartsRepository` | Parts line item reads |
| `DBHelper` | Facade — delegates to all repositories |

### Services (`Services/`)
Each service handles business logic for one domain:

| Class | Responsibility |
|---|---|
| `RepairOrderService` | Generate order numbers, save, update, filter |
| `CustomerService` | Customer search and CRUD delegation |
| `VehicleService` | Vehicle CRUD and customer name lookup |
| `LaborServices` | Mechanic prompting, grid projection, mechanic name lookup |
| `PartsServices` | Parts grid projection |
| `CostCalculator` | Labor total, parts total, grand total calculation |
| `MechanicService` | Mechanic CRUD and search |
| `VehicleApiService` | NHTSA VIN lookup API calls |
| `UserSession` | Session state management |

---

## Project Structure

```
MechanicShop/
├── Classes/
│   ├── Customer.cs
│   ├── Vehicle.cs
│   ├── RepairOrder.cs
│   ├── LaborLineItem.cs
│   ├── PartsLineItem.cs
│   ├── Mechanic.cs
│   └── User.cs
├── Forms/
│   ├── frmMain.cs                  — Dashboard / navigation
│   ├── frmLogin.cs                 — Authentication
│   ├── frmCustomer.cs              — Customer management
│   ├── frmVehicle.cs               — Vehicle management (add, edit, delete)
│   ├── frmRepairOrder.cs           — Create / edit repair orders
│   ├── frmRepairOrderHistory.cs    — Repair order history, search, and filtering
│   └── frmMechanic.cs              — Mechanic management
├── Helper/
│   ├── BaseRepository.cs           — Shared connection string
│   ├── CustomerRepository.cs       — Customer data access
│   ├── VehicleRepository.cs        — Vehicle data access
│   ├── RepairOrderRepository.cs    — Repair order data access
│   ├── LaborRepository.cs          — Labor line item data access
│   ├── PartsRepository.cs          — Parts line item data access
│   └── DBHelper.cs                 — Facade delegating to repositories
├── Services/
│   ├── RepairOrderService.cs       — Repair order business logic
│   ├── CustomerService.cs          — Customer business logic
│   ├── VehicleService.cs           — Vehicle business logic
│   ├── LaborServices.cs            — Labor business logic
│   ├── PartsServices.cs            — Parts business logic
│   ├── CostCalculator.cs           — Cost calculation
│   ├── MechanicService.cs          — Mechanic data access and search
│   ├── VehicleApiService.cs        — NHTSA VIN lookup
│   └── UserSession.cs              — Session state
└── MechanicShopDB.accdb            — Access database
```

---

## Database

The `MechanicShopDB.accdb` file is included in the repository. Place it in the project output directory (`bin/Debug/`) before running the application. The table structure is documented below for reference.

---

## VIN Lookup API

**Endpoint:** `GET https://vpic.nhtsa.dot.gov/api/vehicles/DecodeVinValues/{VIN}?format=json`

1. Enter a 17-character VIN in the Vehicle form
2. Click "Lookup VIN"
3. Make, Model, and Year are parsed from the JSON response and auto-filled
4. If the lookup fails, fields unlock for manual entry

**Test VIN:** `1HGCM82633A123456` → HONDA / ACCORD / 2003

---

## Requirements

- Windows OS
- .NET Framework 4.8
- Microsoft Access Database Engine (ACE OLEDB 12.0)
  - Download: [Microsoft Access Database Engine 2016](https://www.microsoft.com/en-us/download/details.aspx?id=54920)
- Visual Studio 2019 or later

---

## Known Limitations

- Authentication uses hardcoded credentials for testing
- `IsActive` field exists on the Mechanics table but is not yet used in the UI
