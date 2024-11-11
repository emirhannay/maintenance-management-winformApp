
# Maintenance Management System

A Windows Forms-based Maintenance Management System designed to streamline maintenance operations, improve fault reporting, and enable efficient monitoring of equipment maintenance. This project leverages stored procedures for managing business logic within the database, enhancing efficiency and maintainability.

## Project Overview

This Maintenance Management System addresses key challenges in maintenance processes, including delayed fault notifications, lack of data-driven reporting, and efficient preventive maintenance scheduling.

### Key Features

1. **Fault Reporting and Tracking**
   - Report equipment faults with priority levels and track their progress in real-time.
   - Mark faults as resolved and view maintenance details.

2. **Preventive Maintenance Scheduling**
   - Schedule periodic maintenance tasks to maximize equipment reliability.
   - Receive reminders for upcoming maintenance to support proactive management.

3. **Data Collection and Reporting**
   - Access detailed maintenance and fault history for data-driven insights.
   - Generate reports to support strategic decision-making.

4. **Priority Management**
   - Assign priority levels to reported faults for better resource allocation.
   - Optimize response times for high-priority faults to minimize disruptions.

5. **Recurring Fault Analysis**
   - Identify and analyze recurring issues to pinpoint root causes.
   - Use data insights to implement preventive measures against frequent faults.

6. **Knowledge Retention and Continuity**
   - Maintain a knowledge base of maintenance actions, supporting continuity and skill transfer within the organization.


## Getting Started

### Prerequisites

* **Development Environment**: Visual Studio with Windows Forms support.
* **Database**: SQL Server or another compatible RDBMS that supports stored procedures.

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/emirhannay/maintenance-management-winformApp
   ```

2. **Open the Project in Visual Studio**
   * Open the solution file (`.sln`) in Visual Studio.

3. **Set Up the Database**
   * In SQL Server, create a new database named `MaintenanceManagement`.
   * Run the `maintenance-management-script.sql` file to set up the necessary tables and stored procedures.
   * Update the database connection settings in the application configuration.

4. **Run the Application**
   * Build and run the application in Visual Studio to start the Maintenance Management System.

### Usage

After launching, users can log in according to their roles (Technician or Production Supervisor) to report and track faults, schedule maintenance, and view reports on past maintenance activities.

## Technologies Used

* **Frontend**: Windows Forms (C#)
* **Backend**: SQL Server with stored procedures for business logic

## Contributing

Contributions are welcome! For any major changes, please open an issue to discuss proposed updates or submit a pull request.

---

## License

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.