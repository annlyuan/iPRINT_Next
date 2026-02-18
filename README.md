# iPRINT protein-protein interactions database (C#/.NET & Blazor)

High-performance bioinformatics network retrieval system built with C#/.NET 10 & Blazor. Featuring sub-second processing for 110k+ protein interactions and dynamic subnetwork visualization.

<p align="center">
  <img src="Screen Recording 2026-02-18 at 01.32.49.gif" width="800" alt="iPRINT Project Demonstration">
</p>
**Hi! Reload the page to restart the illustration.**

## Technical Implementation

This project is built using professional software engineering practices to ensure high performance and maintainability in a bioinformatics context.

### **C#/.NET Core Features**

* **Modern .NET 10 Architecture**: Leverages the latest **.NET 10 runtime** for superior computational performance and a lean project structure.
* **High-Performance Data Processing**: 
    * Optimized `NetworkService` using **LINQ** and memory-efficient collections.
    * Sub-second retrieval and filtering of **110,000+ interaction records** (Human/Mouse) in real-time.
* **Blazor Component-Based UI**: 
    * Built a modular, responsive frontend using **Blazor Interactive Server** mode.
    * Achieved seamless UI updates and state management without the overhead of full page reloads.
* **Service-Oriented Design (DI)**: 
    * Implemented **Dependency Injection** to decouple core bioinformatics logic from the UI layer.
    * Ensures code testability, maintainability, and scalability for future feature sets.
* **Asynchronous Programming**: 
    * Extensively utilized **Async/Await** patterns for non-blocking data operations.
    * Provides a smooth user experience during heavy computations and large-scale graph rendering.
* **JavaScript Interoperability (JS Interop)**: 
    * Built a robust bridge between **C# and Cytoscape.js**.
    * Enables complex biological network visualization through secure and efficient data marshaling.

---

### **Bioinformatics Logic**

* **Induced Subgraph Algorithm**: Dynamic extraction of local connectivity patterns among queried gene neighbors.
* **Species-Aware Normalization**: Automated symbol casing logic for multi-species data integrity (e.g., Human vs. Mouse capitalization).
* **Edge Classification**: Integrated visual encoding for disease-specific (AD) vs. Wild-type (WT) interaction labels.

# iPRINT - Integrated Protein Interaction Network Tool
**Developed by Dr.Yuan Liu (CubeY studio)**

iPRINT is a high-performance, web-based bioinformatics platform designed for the rapid retrieval and visualization of Protein-Protein Interaction (PPI) networks. Built on the cutting-edge **C#/.NET 10** and **Blazor** framework, it provides researchers with a seamless experience for exploring complex biological networks in both Human and Mouse species.

---

##  Key Features

- **High-Performance Engine**: Optimized to handle large-scale datasets (110,000+ interactions for Human, 80,000+ for Mouse) with sub-second response times.
- **Multi-Gene Query Support**: Simultaneously search for multiple gene symbols to explore entire pathways or co-expression modules.
- **Induced Subgraph Analysis**: Toggle "Subnetwork Interactions" to automatically extract and visualize hidden connections among the neighbors of your query genes.
- **Dynamic Visualization**: Interactive network graphs powered by **Cytoscape.js**, featuring:
  - Role-based node coloring (Deep Red for queries, Light Purple for neighbors).
  - Species-aware symbol rendering (e.g., proper casing for Mouse symbols like *Negr1*).
  - Categorized edge styles (Shared, AD-specific, WT-specific) for Mouse data.
- **Data Portability**: Integrated one-click CSV export for downstream bioinformatics analysis (e.g., functional enrichment).
- **Clean UI/UX**: Professional, English-language interface with localized support for various comma delimiters.

---

##  Tech Stack

- **Backend**: .NET 10 (C#)
- **Frontend**: Blazor Interactive Server Mode
- **Visualization**: Cytoscape.js
- **Data Parsing**: CsvHelper
- **Styling**: Bootstrap 5 & Custom CSS
- **Mascot**: CubeY "Little Green" 

---

##  Project Structure

- **iPRINT.Core**: The "Engine" layer. Contains the data models (`Interaction.cs`) and core logic for CSV processing and graph algorithms (`NetworkService.cs`).
- **iPRINT.Web**: The "Interface" layer. Contains the Blazor components, UI layouts, and JavaScript interop for network rendering.

---

##  Getting Started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Installation & Execution
1. Unzip the package.
2. Open your terminal in the `iPRINT_Next` directory.
3. Run the following command:
   ```bash
   dotnet run --project iPRINT.Web
4. Open your browser and navigate to http://localhost:5000 (or the port specified in the console).

## About the Data
The current version of iPRINT utilizes customized PPI datasets for:

Human: Comprehensive human (HEK293T cell) interactome.

Mouse: Alzheimer's Disease (AD) vs. Wild Type (WT) specific protein networks.

© 2026 CubeY Studio (Dr. Yuan Liu). Empowering bioinformatics through elegant engineering. annlyuan323@gmail.com
