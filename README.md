# Service Feedback Tracker

Overview
Service Feedback Tracker is a CRM-based system designed to streamline the process of capturing customer feedback and converting it into actionable support tickets. It automates ticket creation, tracks issue resolution, and ensures customers are notified when their problems are resolved.


##  Problem Statement

Organizations often struggle to manage customer feedback efficiently. Manual handling can lead to missed issues, delayed responses, and poor customer satisfaction. This project solves that by automating the feedback-to-resolution lifecycle.


##  Features

* Capture and store customer feedback
* Automatic support ticket creation from feedback
* Ticket lifecycle management (Open → In Progress → Resolved → Closed)
* Email notification to customers upon ticket closure
* Integration of plugins and workflows for automation
* Linked feedback and ticket tracking system

---

##  Tech Stack

Microsoft Dynamics 365 CRM  
- Dataverse (for data storage)  
- C# (Plugin Development)  
- .NET Framework  
- Power Platform (Workflows / Process Automation)  
- JavaScript (Client-side scripting / Web Resources)  
- Plugin Registration Tool
- Power Automate

---

##  Workflow Logic

1. User submits feedback through the system
2. If the feedback indicates an issue, a support ticket is automatically created
3. Ticket is assigned to a responsible team/member
4. Ticket status is updated as work progresses
5. Once marked as **Closed**, the system sends a notification to the customer
6. Feedback and ticket remain linked for tracking and reference

---

## 📁 Project Structure

```
Service-Feedback-Tracker/
│
├── Plugins/          # C# plugin code
├── Workflows/        # CRM workflow documentation
├── WebResources/     # JavaScript files
├── Docs/             # Screenshots and diagrams
└── README.md
```

---

## 📸 Screenshots

<img width="1912" height="818" alt="image" src="https://github.com/user-attachments/assets/7c98b4a9-44f4-4b55-bc1e-5aaa90a79523" />


## ⚙️ How to Use

1. Import the solution into Dynamics 365
2. Configure entities and relationships
3. Register the plugins
4. Activate workflows
5. Test the feedback-to-ticket automation

---

## 🔮 Future Improvements

* AI-based ticket prioritization
* Automated ticket assignment
* Dashboard for analytics and reporting
---

## 👩‍💻 Author

Developed by Disha Bora

---

## 📄 License

This project is for educational and demonstration purposes.
