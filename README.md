Sure, here's a README template for your Hotel Kanno-teki application:

---

# Hotel Kanno-teki

Hotel Kanno-teki is a test/sample application that manages hotel reservations in a hotel chain.

## Functionalities

### Guest

- **Dashboard**: Allows guests to book reservations. Disabled if there is already a pre-existing reservation.
- **Create Reservation (1)**: Select a room, check-in and check-out dates (up to 14 days), and the number of guests.
- **Create Reservation (2)**: Fill out the booking guest's details.
- **Create Reservation (3)**: Select payment mode and payment details.

### Staff/Employee

- **Dashboard**: Allows users to choose between windows: guests, rooms, reservations, and transaction/payment history. Provides live statistics in the UI.
- **Guest Window**: Update guest details and remove guests from the hotel database.
- **Rooms Window**: Add rooms with room image preview, update room details, and remove rooms from the hotel database.
- **Reservations Window**: View reservation details and manage check-in/check-out processes.

### Admin

- **Dashboard**: Allows admin to choose between windows: accounts, rooms, and reservations. Provides live statistics in the UI.
- **Accounts Window**: Manage guest and staff accounts, including insertion, updating, and deletion. View staff's own details.
- **Rooms Window**: View room details and search/filter specific rooms.
- **Reservations Window**: View reservations details and search/filter specific reservations.

## Database

This system includes an SQL Server database that needs to be restored if using this repository on another PC. The application utilizes an entity data model (EDMx) to connect to the database, and uses DBContext, SQL Views, and SQL Stored Procedures to provide the application its functionalities involving the system's database. The database consists of the following tables:

- User Account
- Roles
- Guest Information
- Staff Information
- Room Information
- Reservation Information
- Payment Information

## Upcoming Features

- Payment/Transaction history for Staff
- Guest Information for Admin's Accounts Window
- More data grid view filters

## Installation

1. Clone this repository to your local machine.
2. Restore the SQL Server database.
3. Configure the database connection in the application.
4. Build and run the application.

## Contributing

Contributions are welcome! If you have any ideas, improvements, or bug fixes, feel free to open an issue or submit a pull request.

## License

[Include information about the project's license here.]

---

Feel free to customize this template to fit your specific project's details and requirements!
