
using Single_Responsibility;

Invoice invoice = new Invoice { InvoiceId = 101, Amount = 100m };

InvoicePrinter printer = new InvoicePrinter();

printer.Print(invoice);


Console.WriteLine("Press any key to exit...");
Console.ReadLine();


/*
 * Single Responsibility Principle (SRP): Each class should have 
 * only one reason to change, meaning it handles one specific functionality.
 * 
 * Advantages of the Single Responsibility Principle (SRP)

Enhanced Maintainability: When a class has only one reason to change, modifications or bug fixes are localized, reducing the risk of unintended side effects across the system.
Improved Readability and Clarity: With each class focused on a single functionality, the code becomes more straightforward and easier to understand, making onboarding and collaboration smoother.
Simplified Testing: Isolated responsibilities allow for more targeted unit tests, ensuring each component behaves as expected without complex interdependencies.
Better Reusability: Classes with a singular focus are often easier to reuse in different contexts or projects, promoting modular design.
Reduced Coupling: By separating concerns, the dependencies between classes are minimized, making the system more flexible and easier to modify over time.
 * 
 */

