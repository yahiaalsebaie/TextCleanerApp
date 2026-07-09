
# TextCleanerApp - Line Removal Tool

A lightweight, efficient Windows Forms application designed to clean, filter, and sanitize bulk text data. By matching text against a user-defined blacklist, the tool eliminates repetitive signatures, copyrights, watermarks, or unwanted entries instantly.

<img width="1536" height="732" alt="Screenshot 2026-07-09 054407" src="https://github.com/user-attachments/assets/6af3bcfb-01c8-4c04-90e4-c700985842a3" />

---

## 💡 Core Concept
The application processes data by comparing two inputs: the **Main Text** and the **Removal List**. It parses the text line-by-line, matching and dropping any line found in the exclusion list.

To ensure precision, the filtering mechanism is completely immune to accidental trailing/leading whitespaces and letter-case discrepancies.

---

## 🎯 Practical Use Cases & Examples

### 1. Cleaning Transcripts & Educational Materials (Copyright Removal)
When copying automated lecture transcripts or online articles, repetitive headers, footers, and copyright notices often pollute the text.
* **Main Text:**
```text
  ProgrammingAdvices.com
  Copyright © 2024
  
  Introduction
  The HTML <sub> and <sup> tags are used to display text.
  
  ProgrammingAdvices.com
  Copyright © 2024

```

- **Remove List:**


```Plaintext
ProgrammingAdvices.com
Copyright © 2024
```
- **Result:**

```Plaintext
Introduction
The HTML <sub> and <sup> tags are used to display text.
```

### 2. Filtering Data Lists (Emails & Phone Numbers)
Perfect for marketers or database administrators looking to scrub a massive lead list against an internal "Do Not Contact" (DNC) list or employee directory.
* **Main Text:** Bulk client list containing 10,000 entries.
* **Remove List:** Internal blacklist of restricted emails.
* **Result:** A targeted, sanitized marketing list.

### 3. Cleaning Scraped PDF Text
Copying content from PDFs frequently introduces artifacts such as repetitive page numbers, running headers, or static section titles (e.g., *Page 1*, *Chapter 1*). Dropping these into the removal field purges them globally.

### 4. Negative Keyword Sorting
Allows digital marketers to quickly filter out unrelated or negative keywords from massive search-term extraction lists before deploying ad campaigns.

---

## 🛠️ How to Use (User Guide)

1. **Input Main Text:** Click `Paste` to quickly load your source text directly from the system clipboard into the **Main** box.
2. **Define Exclusions:** Paste or type the exact lines you want to discard into the **Remove** box.
3. **Execute:** Click `Remove`. The sanitized text outputs instantly into the **Result** box.
4. **Monitor Volume:** Live counters dynamically update at the bottom of each field, providing instant feedback on exactly how many lines were discarded.
5. **Extract Result:** Click `Copy` to send your clean text straight back to the clipboard.

---

## ⚙️ Technical Blueprint (For Developers)

* **Stack:** C# | .NET Windows Forms
* **Performance Architecture:** * Leveraging a `HashSet<string>` lookup for the exclusion criteria ensures an $O(1)$ time complexity lookup per line. This protects UI responsiveness and system memory when handling files with large line counts.
  * Robust normalization logic wraps inputs through a `.Trim().ToLower()` layer inside the pipeline, preventing missed flags due to invisible string formatting disparities.
