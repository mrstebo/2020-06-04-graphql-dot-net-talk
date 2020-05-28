using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApi.Data.Migrations
{
    public partial class AddDescriptionsToBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1L,
                column: "Description",
                value: "<div><p>Even bad code can function. But if code isn’t clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn’t have to be that way. Noted software expert Robert C. Martin presents a revolutionary paradigm with Clean Code: A Handbook of Agile Software Craftsmanship . Martin has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code “on the fly” into a book that will instill within you the values of a software craftsman and make you a better programmer—but only if you work at it. What kind of work will you be doing? You’ll be reading code—lots of code. And you will be challenged to think about what’s right about that code, and what’s wrong with it. More importantly, you will be challenged to reassess your professional values and your commitment to your craft. Clean Code is divided into three parts. The first describes the principles, patterns, and practices of writing clean code. The second part consists of several case studies of increasing complexity. Each case study is an exercise in cleaning up code—of transforming a code base that has some problems into one that is sound and efficient. The third part is the payoff: a single chapter containing a list of heuristics and “smells” gathered while creating the case studies. The result is a knowledge base that describes the way we think when we write, read, and clean code. Readers will come away from this book understanding How to tell the difference between good and bad code How to write good code and how to transform bad code into good code How to create good names, good functions, good objects, and good classes How to format code for maximum readability How to implement complete error handling without obscuring code logic How to unit test and practice test-driven development This book is a must for any developer, software engineer, project manager, team lead, or systems analyst with an interest in producing better code.</p></div>");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2L,
                column: "Description",
                value: "<div><p>Building upon the success of best-sellers <i>The Clean Coder </i>and <i>Clean Code</i>, legendary software craftsman Robert C. \"Uncle Bob\" Martin shows how to bring greater professionalism and discipline to application architecture and design.</p> <p>&nbsp;</p> <p>As with his other books, Martin's <i><b>Clean Architecture</b></i> doesn't merely present multiple choices and options, and say \"use your best judgment\": it tells you what choices to make, and why those choices are critical to your success. Martin offers direct, no-nonsense answers to key architecture and design questions like:</p> <ul> <li> <div>What are the best high level structures for different kinds of applications, including web, database, thick-client, console, and embedded apps?</div> </li><li> <div>What are the core principles of software architecture?</div> </li><li> <div>What is the role of the architect, and what is he/she really trying to achieve?</div> </li><li> <div>What are the core principles of software design?</div> </li><li> <div>How do designs and architectures go wrong, and what can you do about it?</div> </li><li> <div>What are the disciplines and practices of professional architects and designers?</div></li></ul> <p><b><i>Clean Architecture</i></b> is essential reading for every software architect, systems analyst, system designer, and software manager -- and for any programmer who aspires to these roles or is impacted by their work.</p></div>");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3L,
                column: "Description",
                value: "<div><div>Twenty years after the Agile Manifesto was first presented, the legendary Robert C. Martin (Uncle Bob) reintroduces agile values and principles for a new generation of software developers. In this eagerly awaited book, the best-selling author of&nbsp;<i>The Clean Coder</i>&nbsp;shows how to bring unprecedented levels of professionalism and discipline to agile development–and thereby write far more effective, successful software.</div><div><br></div><div>As with his other books, Martin's&nbsp;<b><i>Clean Agile: Back to Basics</i></b>&nbsp;doesn't merely present multiple choices and options, and say \"use your best judgment\"; it tells you what choices to make and why those choices are critical to your success. Writing in the agile context, Martin offers direct, no-nonsense answers to crucial questions:</div><div><ul> <li>How and why did agile begin? </li><li>What are the costs and benefits of agile? </li><li>What are the most effective practices of agile development? </li><li>How should an agile team be organized? </li><li>What roles do programmers, testers, and managers play in an agile team? </li><li>What is the role of the Agile Coach? </li><li>What about agile for large projects? </li><li>What kinds of projects benefit from agile?</li></ul></div><div><b><i>Clean Agile: Back to Basics</i></b>&nbsp;is essential reading for programmers, managers, testers, project managers, and every software professional called upon to lead or participate in an agile project.</div></div>");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 4L,
                column: "Description",
                value: "<div><p>Rust 2018, Rust's first major milestone since version 1.0, brings more advancement in the Rust language. The Rust Programming Cookbook is a practical guide to help you overcome challenges when writing Rust code.</p><p>This Rust book covers recipes for configuring Rust for different environments and architectural designs, and provides solutions to practical problems. It will also take you through Rust's core concepts, enabling you to create efficient, high-performance applications that use features such as zero-cost abstractions and improved memory management. As you progress, you'll delve into more advanced topics, including channels and actors, for building scalable, production-grade applications, and even get to grips with error handling, macros, and modularization to write maintainable code. You will then learn how to overcome common roadblocks when using Rust for systems programming, IoT, web development, and network programming. Finally, you'll discover what Rust 2018 has to offer for embedded programmers. </p><p>By the end of the book, you'll have learned how to build fast and safe applications and services using Rust.</p></div>");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 5L,
                column: "Description",
                value: "<div>Move into iOS development by getting a firm grasp of its fundamentals, including the Xcode 10 IDE, Cocoa Touch, and the latest version of Apple's acclaimed programming language, Swift 5. With this thoroughly updated guide, you'll learn the Swift language, understand Apple's Xcode development tools, and discover the Cocoa framework. Explore Swift's object-oriented concepts Become familiar with built-in Swift types Dive deep into Swift objects, protocols, and generics Tour the lifecycle of an Xcode project Learn how nibs are loaded Understand Cocoa's event-driven design Communicate with C and Objective-C Once you master the fundamentals, you'll be ready to tackle the details of iOS app development with author Matt Neuburg's companion guide, Programming iOS 13.</div>");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 6L,
                column: "Description",
                value: "<div><b> <p>The Complete Guide to Writing Maintainable, Manageable, Pleasing, and Powerful Object-Oriented Applications</p> </b> <p>&nbsp;</p> <p>Object-oriented programming languages exist to help you create beautiful, straightforward applications that are easy to change and simple to extend. Unfortunately, the world is awash with object-oriented (OO) applications that are difficult to understand and expensive to change. <i> <b>Practical Object-Oriented Design, Second Edition,</b> </i> immerses you in an OO mindset and teaches you powerful, real-world, object-oriented design techniques with simple and practical examples.</p> <p>&nbsp;</p> <p>Sandi Metz demonstrates how to build new applications that can “survive success” and repair existing applications that have become impossible to change. Each technique is illustrated with extended examples in the easy-to-understand Ruby programming language, all downloadable from the companion website, poodr.com. Fully updated for Ruby 2.5, this guide shows how to</p> <ul> <li>Decide what belongs in a single class</li> <li>Avoid entangling objects that should be kept separate</li> <li>Define flexible interfaces among objects</li> <li>Reduce programming overhead costs with duck typing</li> <li>Successfully apply inheritance</li> <li>Build objects via composition</li> </ul> <p>Whatever your previous object-oriented experience, this concise guide will help you achieve the superior outcomes you’re looking for.</p> <p> <br> </p> <p> <i>Register your book for convenient access to downloads, updates, and/or corrections as they become available. See inside book for details.</i> </p></div>");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 7L,
                column: "Description",
                value: "<div><p><b>Learn the fundamentals, practical applications, and latest features of C# 8.0 and .NET Core 3.0 from expert teacher Mark J. Price.</b></p><h4>Key Features</h4><ul><li>Build modern, cross-platform applications with .NET Core 3.0</li><li>Get up to speed with C#, and up to date with all the latest features of C# 8.0</li><li>Start creating professional web applications with ASP.NET Core 3.0</li></ul><h4>Book Description</h4><p>In C# 8.0 and .NET Core 3.0 – Modern Cross-Platform Development, Fourth Edition, expert teacher Mark J. Price gives you everything you need to start programming C# applications.</p><p>This latest edition uses the popular Visual Studio Code editor to work across all major operating systems. It is fully updated and expanded with new chapters on Content Management Systems (CMS) and machine learning with ML.NET.</p><p>The book covers all the topics you need. Part 1 teaches the fundamentals of C#, including object-oriented programming, and new C# 8.0 features such as nullable reference types, simplified switch pattern matching, and default interface methods. Part 2 covers the .NET Standard APIs, such as managing and querying data, monitoring and improving performance, working with the filesystem, async streams, serialization, and encryption. Part 3 provides examples of cross-platform applications you can build and deploy, such as web apps using ASP.NET Core or mobile apps using Xamarin.Forms. The book introduces three technologies for building Windows desktop applications including Windows Forms, Windows Presentation Foundation (WPF), and Universal Windows Platform (UWP) apps, as well as web applications, web services, and mobile apps.</p><h4>What you will learn</h4><ul><li>Build cross-platform applications for Windows, macOS, Linux, iOS, and Android</li><li>Explore application development with C# 8.0 and .NET Core 3.0</li><li>Explore ASP.NET Core 3.0 and create professional web applications</li><li>Learn object-oriented programming and C# multitasking</li><li>Query and manipulate data using LINQ</li><li>Use Entity Framework Core and work with relational databases</li><li>Discover Windows app development using the Universal Windows Platform and XAML</li><li>Build mobile applications for iOS and Android using Xamarin.Forms</li></ul><h4>Who this book is for</h4><p>Readers with some prior programming experience or with a science, technology, engineering, or mathematics (STEM) background, who want to gain a solid foundation with C# 8.0 and .NET Core 3.0.</p> <h4>Table of Contents</h4><ol><li>Hello, C#! Welcome, .NET!</li><li>Speaking C#</li><li>Controlling Flow and Converting Types</li><li>Writing, Debugging, and Testing Functions</li><li>Building Your Own Types with Object-Oriented Programming</li><li>Implementing Interfaces and Inheriting Classes</li><li>Understanding and Packaging .NET Types</li><li>Working with Common .NET Types</li><li>Working with Files, Streams, and Serialization</li><li>Protecting Your Data and Applications</li><li>Working with Databases Using Entity Framework Core</li><li>Querying and Manipulating Data Using LINQ</li><li>Improving Performance and Scalability Using Multitasking</li><li>Practical Applications of C# and .NET</li><li>Building Websites Using ASP.NET Core Razor Pages</li><li>Building Websites Using the Model-View-Controller Pattern</li><li>Building Websites Using a Content Management System</li><li>Building and Consuming Web Services</li><li>Building Intelligent Apps Using Machine Learning</li><li>Building Windows Desktop Apps</li><li>Building Cross-Platform Mobile Apps Using Xamarin.Forms</li><li>Appendix (Bonus Chapter)</li></ol></div>");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 8L,
                column: "Description",
                value: "<div>Five years after this sleeper hit took on the world of IT and flipped it on it's head, the 3rd edition of The Phoenix Project continues to guide IT in the DevOps revolution. In this newly updated and expanded edition of the bestselling The Phoenix Project, co-author Gene Kim includes new research, a new foreword, and a sneak peek at the next project from Gene Kim and Jez Humble. Bill, an IT manager at Parts Unlimited, has been tasked with taking on a project critical to the future of the business, code named Phoenix Project. But the project is massively over budget and behind schedule. The CEO demands Bill must fix the mess in ninety days or else Bill's entire department will be outsourced. With the help of a prospective board member and his mysterious philosophy of The Three Ways, Bill starts to see that IT work has more in common with a manufacturing plant work than he ever imagined. With the clock ticking, Bill must organize work flow streamline interdepartmental communications, and effectively serve the other business functions at Parts Unlimited. In a fast-paced and entertaining style, three luminaries of the DevOps movement deliver a story that anyone who works in IT will recognize. Readers will not only learn how to improve their own IT organizations, they'll never view IT the same way again.</div>");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 9L,
                column: "Description",
                value: "<div>The Phoenix Project wowed over a half-million readers. Now comes the Wall Street Journal Bestselling The Unicorn Project! \"The Unicorn Project is amazing, and I loved it 100 times more than The Phoenix Project...\"--FERNANDO CORNAGO, Senior Director Platform Engineering, Adidas \"Gene Kim does a masterful job of showing how... the efforts of many create lasting business advantages for all.\"--DR. STEVEN SPEAR, author of The High-Velocity Edge, Sr. Lecturer at MIT, and principal of HVE LLC. \"The Unicorn Project is so clever, so good, so crazy enlightening!\"--CORNELIA DAVIS, Vice President Of Technology at Pivotal Software, Inc., Author of Cloud Native Patterns This highly anticipated follow-up to the bestselling title The Phoenix Project takes another look at Parts Unlimited, this time from the perspective of software development. In The Unicorn Project, we follow Maxine, a senior lead developer and architect, as she is exiled to the Phoenix Project, to the horror of her friends and colleagues, as punishment for contributing to a payroll outage. She tries to survive in what feels like a heartless and uncaring bureaucracy and to work within a system where no one can get anything done without endless committees, paperwork, and approvals. One day, she is approached by a ragtag bunch of misfits who say they want to overthrow the existing order, to liberate developers, to bring joy back to technology work, and to enable the business to win in a time of digital disruption. To her surprise, she finds herself drawn ever further into this movement, eventually becoming one of the leaders of the Rebellion, which puts her in the crosshairs of some familiar and very dangerous enemies. The Age of Software is here, and another mass extinction event looms--this is a story about rebel developers and business leaders working together, racing against time to innovate, survive, and thrive in a time of unprecedented uncertainty...and opportunity. \"The Unicorn Project provides insanely useful insights on how to improve your technology business.\"--DOMINICA DEGRANDIS, author of Making Work Visible and Director of Digital Transformation at Tasktop ------ \"My goal in writing The Unicorn Project was to explore and reveal the necessary but invisible structures required to make developers(and all engineers) productive, and reveal the devastating effects of technical debt and complexity.I hope this book can create common ground for technology and business leaders to leave the past behind, and co - create a better future together.\"--Gene Kim, November 2019</div>");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 10L,
                column: "Description",
                value: "<div>For decades, technology leaders have struggled to balance agility, reliability, and security, and the consequences of failure have never been greater. The effective management of technology is critical for business competitiveness. High-performing organizations are 2.5 times more likely to exceed profitability, market share, and productivity goals. The DevOps Handbook shows leaders how to create the cultural norms and the technical practices necessary to maximize organizational learning, increase employee satisfaction, and win in the marketplace.</div>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 4L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 5L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 6L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 7L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 8L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 9L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 10L,
                column: "Description",
                value: null);
        }
    }
}
