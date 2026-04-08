# Mechanic Shop Management System

A desktop application for mechanic shops to manage customers, vehicles, repair orders, labor/parts tracking, and invoicing. Built with Windows Forms and C#.

**Status:** In Development — Core design complete, implementing API integration and authentication.

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
- **Vehicle API Integration** — Auto-populate vehicle details (make, model, year) from VIN using NHTSA public API
- **Authentication** — Login/logout with session management and failed attempt limits

### Planned
- Appointment scheduling
- Inventory management
- Customer portal
- Payment processing
- Reporting dashboard

---

## Technology Stack

| Layer | Technology |
|-------|------------|
| Frontend | Windows Forms (.NET) |
| Language | C# |
| Data Storage | JSON (current) / SQL Server (planned) |
| API | NHTSA Vehicle API (REST, JSON) |
| Authentication | Custom role-based session management |

---

## Architecture Overview
