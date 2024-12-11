
# Project Name: Third Project

## Key Features

### 1. **Footer Component**
   - Integrated a footer using **ViewComponent** in the shared folder, which is then included in the `_Layout` file.
   - Footer was added with the following code:
     ```html
     <div>
         @await Component.InvokeAsync("Footer")
     </div>
     ```
   - This ensures that the footer is rendered consistently across the entire site.

### 2. **Theme Consistency**
   - Maintained a consistent theme throughout the website to provide a cohesive user experience.
   - Theme includes a uniform color palette, typography, and layout, ensuring that all pages appear visually consistent.

### 3. **Adaptation of Code from Uiverse**
   - The following sections were inspired and adapted from [Uiverse](https://uiverse.io/):
     - **Home Page**: Adapted a quote section from [Selfish Treefrog](https://uiverse.io/sabbircoder07/selfish-treefrog-55) for a visually appealing quote section.
     - **People Page**: Used jQuery tabs and adapted the people cards section from [Tricky Robin](https://uiverse.io/ElSombrero2/tricky-robin-67). Bootstrap modals were used to show more detailed information about each person.
     - **Minors Page**: Adapted the courses section for each minor from [Slippery Baboon](https://uiverse.io/Prince4fff/slippery-baboon-37) and used Bootstrap modals to display additional course details.
     - **Degrees Page**: Implemented an accordion feature for each degree and reused [Slippery Baboon](https://uiverse.io/Prince4fff/slippery-baboon-37) for displaying concentrations within degrees.
     - **Employment Page**: Used [DataTables](https://cdn.datatables.net/) to enhance the coop and professional employment tables. Added a carousel feature for employers and careers sections to create a more dynamic, interactive layout.

### 4. **Advanced UI Components**
   - **Bootstrap Modals**: Used throughout the site to display detailed information without navigating away from the current page. This improves user engagement by offering a seamless browsing experience.
   - **Accordion**: Used on the Degrees page to display different concentrations under each degree in a collapsible format, making the information easy to digest.
   - **DataTables**: Implemented on the Employment page to provide interactive, sortable, and searchable tables for Coop and Professional Employment sections.

### 5. **APIs and Data Retrieval**
   - Implemented all required APIs,and **footer/** to fetch and display data dynamically on various pages.
   - Ensured that the footer is consistently displayed across all pages by adding it to the shared layout file.

### 6. **Bootstrap Carousel for Employers and Careers**
   - The carousel feature on the Employment page rotates through employer profiles and career opportunities, enhancing the user experience by providing interactive, scrollable content.

## Technologies Used

- **Bootstrap**: For responsive layout and UI components like modals, accordions, and carousels.
- **jQuery**: For dynamic functionality like tabs, modals, and interactive behavior.
- **DataTables**: For enhanced, interactive tables on the Employment page.
- **Uiverse**: Used as inspiration for adapting creative, responsive UI components.

## Acknowledgements

- [Uiverse](https://uiverse.io/) for providing the inspirational UI components.
- [DataTables](https://cdn.datatables.net/) for the interactive tables used in the Employment section.
