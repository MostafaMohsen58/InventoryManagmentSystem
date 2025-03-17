<!-- Welcome Message -->
<h1 align="center">Welcome to Our Inventory Management System 👋</h1>

<!-- Typing effect for a cool introduction -->
<p align="center">
  <a href="https://git.io/typing-svg">
    <img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&pause=1000&color=F75C7E&center=true&vCenter=true&width=435&lines=Inventory+Management+System;Built+with+.NET+WinForms;Efficient+Product+Tracking" alt="Typing SVG" />
  </a>
</p>

---

### 👋 About the Project

The **Inventory Management System** is a **desktop application** built with **C# and .NET WinForms**. It helps businesses efficiently track products, suppliers, stock levels, and sales transactions. The system supports CRUD operations, reporting, and analytics to make inventory management smooth and efficient.

---

<!-- Tech Stack -->

### 🛠️ Tech Stack

Here are the technologies and tools used in this project:

#### Backend Development

<p align="left">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
  <img src="https://img.shields.io/badge/Entity_Framework_Core-9B30B0?style=for-the-badge&logo=entity-framework&logoColor=white" alt="EF Core" />
  <img src="https://img.shields.io/badge/WinForms-512BD4?style=for-the-badge&logo=windows&logoColor=white" alt="WinForms" />
</p>

#### Database

<p align="left">
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
</p>

#### Tools & Platforms

<p align="left">
  <img src="https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white" alt="Visual Studio" />
  <img src="https://img.shields.io/badge/SQL_Server_Reporting_Services-2568C8?style=for-the-badge&logo=microsoft-sql-server-reporting-services&logoColor=white" alt="SSRS" />
</

---

### 📂 Project Setup

#### 🔹 Step 1: Prerequisites

Make sure you have the following installed:

- .NET SDK (version compatible with the project)
- SQL Server
- Visual Studio
- SQL Server Reporting Services (SSRS) (mandatory, for reporting)

#### 🔹 Step 2: Database Setup

1. Open the project in Visual Studio.
2. Set DAL as startup project
3. Create appSettings.json in DAL solution

```bash
{
  "ConnectionStrings": {
  "DefaultConnection":"Server=YOUR_SERVER;Database=InventoryDB;Trusted_Connection=True;"
  }
}
```

4. Build the solution to ensure all dependencies are correctly installed.
5. Run database migrations using **NuGet Package Manager Console** in Visual Studio:

   ```bash
   Update-Database
   ```

   This will apply any pending migrations and update the database schema.

#### 🔹 Step 4: SSRS Report Setup

1. Install and configure SQL Server Reporting Services (SSRS).
2. Deploy the SSRS reports to the report server.
3. Update the report server URL in the application settings.

#### 🔹 Step 5: Running the Application

1. Set the PL project as the startup project in Visual Studio.
2. Press `Ctrl + F5` to run the application.
3. Login using default credentials:
   - Username: `admin`
   - Password: `123456789`
4. Start managing inventory! 🚀

---

## 📌 ERD (Entity Relationship Diagram)

![Sample Image](https://github.com/MostafaMohsen58/InventoryManagmentSystem/blob/main/images/erd.png)

---

## 📊 Use Case Diagram

![Sample Image](https://github.com/MostafaMohsen58/InventoryManagmentSystem/blob/main/images/use_case.png)

---

### 👤 User Roles & Permissions

| Role    | Permissions                                                        |
| ------- | ------------------------------------------------------------------ |
| Admin   | Manage users, products, suppliers, stock, and sales. View reports. |
| Manager | Manage products, stock. Review sales and reports.                  |
| Staff   | Process sales transactions, add stock, generate receipts.          |

---

## 📷 Screenshots

Here are some screenshots of the application:

### Login Screen

![Login Screen](https://github.com/MostafaMohsen58/InventoryManagmentSystem/blob/main/images/login.png)

### Dashboard

![Dashboard](https://github.com/MostafaMohsen58/InventoryManagmentSystem/blob/main/images/DashBoard_main.png)
![Dashboard](https://github.com/MostafaMohsen58/InventoryManagmentSystem/blob/main/images/dashboard1.png)

### Add new product Dialog

![Add product dialog](https://github.com/MostafaMohsen58/InventoryManagmentSystem/blob/main/images/Product.png)

### Viewing reports

![View Reports](https://github.com/MostafaMohsen58/InventoryManagmentSystem/blob/main/images/report.png)

### Viewing invoices

![View invoices](https://github.com/MostafaMohsen58/InventoryManagmentSystem/blob/main/images/Invoice.png)

---

### 💡 Troubleshooting & FAQs

**❓ 1. Database connection error?**

- ✔ Ensure SQL Server is running and the connection string is correct.

**❓ 2. Application crashes on startup?**

- ✔ Check if all dependencies are installed.

**❓ 3. Reports not generating?**

- ✔ Ensure SQL Server Reporting Services (SSRS) is properly installed.
- ✔ Verify that the report server URL is correctly set in the application.

---

### 📞 Contact

Team Members:

- Reem Atef Abdelkhaleq Heikal: [LinkedIn](http://www.linkedin.com/in/reem-heikal)
- Ahmed Mohamed Ramadan: [LinkedIn](https://www.linkedin.com/in/ahmed-ramadan-28333423a/)
- Mostafa Mohsen Elnahas: [LinkedIn](https://www.linkedin.com/in/mostafa-elnahas/)

Feel free to fork, contribute, or report issues! 😊

---

<p align="center">
  <img src="https://komarev.com/ghpvc/?username=ahmedmoramadan&label=Profile%20Views&color=F75C7E&style=flat" alt="Profile Views" />
</p>
