# 📚 LINQ Library Explorer  

A simple WPF application I built to explore and demonstrate how **LINQ queries** can make data filtering and manipulation easier in C#.  
This project was part of my **self-learning journey**, helping me understand how LINQ works and how it can simplify everyday programming tasks.  

---

## 🚀 Features  
In this app, I implemented an interactive library explorer where I can:  
- Filter books by:
  - **Author**
  - **Genre**
  - **Price range**
- Apply multiple LINQ-based operations such as:
  - **Top 5 Expensive Books**
  - **Top 5 Modern Books**
  - **Average Book Price**
  - **Group Books by Author**

---

## Technologies Used  
- **C#**  
- **WPF (Windows Presentation Foundation)**  
- **LINQ (Language Integrated Query)**  

---

## What I Learned  
Through this project, I learned how to use **LINQ** to:  
- Dynamically query and filter data based on user input  
- Combine multiple LINQ methods (`Where`, `OrderByDescending`, `Take`, `Average`, `GroupBy`)  
- Display query results interactively in a WPF interface  
- Simplify complex filtering logic into clean, readable code  

All the data in this project is **template data stored in in-memory lists** (`List<T>`).  
I created sample data for `Authors`, `Genres`, and `Books` to simulate a small library database — which helped me practice LINQ operations without using any external data source.  

---

## Purpose of the Project  
I built this project as a **self-learning exercise** to strengthen my understanding of:  
- LINQ query syntax and method chaining  
- How LINQ integrates with C# object collections  
- Building flexible filters and interactive queries in a WPF desktop app  

It really helped me see how powerful LINQ can be in simplifying data manipulation and making C# code more expressive.  

---

## 📸 Screenshots  

### Example 1  
<img width="783" height="492" alt="image" src="https://github.com/user-attachments/assets/6aeb9991-ff99-48b7-812a-afb307023f13" />
  
In this example, I selected William Shakespeare as the author, set the price range between 0 and 20, and chose the “Top 5 Expensive Books” operation.  
The app used LINQ to instantly display the most expensive books within that range.  

---

### Example 2  
<img width="779" height="493" alt="image" src="https://github.com/user-attachments/assets/083e2ec3-5b6b-466c-bbd8-7cda45c48b3e" />
 
Here, I selected Agatha Christie as the author, set the price range between 0 and 100, and applied the “Top 5 Modern” operation.  
LINQ filtered and sorted the data to show her five most recently published books within the selected price range.  

---
