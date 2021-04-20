# BlazorProjectTemplate-
Template for Blazor Web Application that performs data binding and performs CRUD function
This blazor project runs on c# and razor file formats.
The blazor project is built on .NET Core 5.0 and Visual Studio Code. It can also be opened using Visual Studio Community Edition 2015 and above. 
Required Libraries to run Blazor Application: .NET Core 5.0, 

1. Run dotnet watch to run the blazor application.
2. Go to your web browser of choice: https://localhost:5000



Blazor is a .NET web framework using C#/Razor and HTML that runs in the browser with WebAssembly.

Contributions are always welcome! Please take a look at the contribution guidelines pages first. Thanks to all contributors, you're awesome and wouldn't be possible without you!

If you need to search on this list you can try this great website: Awesome Blazor Browser. Thanks @jsakamoto for this! Source code stars last commit.

ASP.NET Core Community Standup: "ASP.NET Core updates in .NET 6" (April 20, 2021).


There are a lot of exciting new features for ASP.NET Core developers in .NET 6! Come hear all about it from Daniel Roth, and ask your questions live in the chat.
Featuring: Daniel Roth.
live.dot.net.
Contents
Introduction
General
Sample Projects
Tutorials
Libraries & Extensions
Videos
Articles
Podcasts
Presentations slides
Tooling
Books
E-Books
Courses
Community
Other Languages
Introduction
What is Blazor?
Blazor is a .NET web framework to build client web apps with C#.

Blazor lets you build interactive web UIs using C# instead of JavaScript. Blazor apps are composed of reusable web UI components implemented using C#, HTML, and CSS. Both client and server code is written in C#, allowing you to share code and libraries. More information on the official Blazor website.

Get started
To get started with Blazor, follow the instructions in the Blazor Get Started documentation.

General
ASP.NET Blog's archives - Archives of the ASP.NET blog about Blazor.
Blazor - Official website of Blazor, from Microsoft.
Blazor courses on Microsoft Learn - Blazor courses on Microsoft Learn.
Blazor-Dev gallery on .NET Foundation - Daily builds of the 'dev' branch of Blazor.
Blazor Extensions - Curated extensions for Microsoft ASP.Net Core Blazor.
Blazor University - Unofficial documentation website.
Demo - Official basic demo website.
Documentation - Official documentation, by Microsoft.
eShopOnBlazor - GitHub stars last commit Migration of a traditional ASP.NET Web Forms app to Blazor, sample by Microsoft Architecture.
FAQ - FAQ.
GitHub repository - GitHub stars last commit The official Blazor repository (which is the ASP.NET Core repository).
'Hello World' sample - 'Hello World' sample.
Introduction to ASP.NET Core - Introduction to ASP.NET Core.
Workshop - GitHub stars last commit Build a complete Blazor app and learn about the various Blazor framework features along the way.
Blazor WebAssembly performance best practices - ASP.NET Core Blazor WebAssembly performance best practices, by Pranav Krishnamoorthy and Steve Sanderson.
themesof.net - .NET 6 planning process.
Sample Projects
Authentication
BlazorBoilerplate - stars last commit Real World Admin Dashboard / Starter kit with IdentityServer4 Material Design. Demo.
BlazorWithIdentity - stars last commit A sample project showcasing a Blazor app using EF Core with Identity authentication.
Authentication with client-side Blazor - stars last commit Authentication with client-side Blazor using WebAPI and ASP.NET Core Identity. Blog post.
TheIdServer - stars last commit OpenID/Connect server base on IdentityServer4.
Blazor and Identity Server - stars last commit This project demonstrates how to secure a Blazor WebAssembly application with a standalone Identity Server instance and use it to acquire a token for a protected API.
BlazorAuthenticationSample - stars last commit A sample showing some of the ASP.NET Core Blazor authentication features (also some testing...).
Blazor-WASM-Identity-gRPC - stars last commit Blazor WASM, IdentityServer4 & gRPC with roles authorization.
BlazorGraphApi - stars last commit Blazor Server App with AD Authentication, that calls the MS Graph API on-behalf of the signed-in user using Microsoft.Identity.Web.
Blorc.OpenIdConnect - last commit The right way to use OpenID Connect on Blazor.
Blazor-WASM-AzureAD-gRPC - last commit Blazor WASM, Azure AD, REST & gRPC.
Blazor-WASM-Auth0-gRPC - last commit Blazor WASM, Auth0, REST & gRPC.
Blazor WebAssembly and Azure Active Directory - last commit Blazor WebAssembly application secured with Azure Active Directory. This source code is related to an article on Medium: Securing a Blazor WebAssembly application with Azure Active Directory.
Blazor Authentication Extension for Azure Static Web Apps - last commit Blazor Authentication Extension for Azure Static Web Apps.
Quiz manager secured by Auth0 - last commit This repository contains a Blazor WebAssembly application implementing a simple Quiz manager secured by Auth0. The implementation details are described in the following article: Securing Blazor WebAssembly Apps.
Blazor-WASM-Identity-gRPC-Alexa - last commit Blazor WASM, IdentityServer4 , gRPC with roles authorization & Alexa Skill Backend.
Cloud
BlazorFile2Azure - stars last commit Upload a file from Blazor WebAssembly to Azure Blob Storage.
Blazor WASM Deployment - last commit Sample repo for showing Actions to deploy a Blazor app to Azure services.
Blazor.JobBoard - last commit Blazor WebAssembly based jobboard application deployed to Azure Storage Static Site. Demo.
EventGrid Viewer Blazor - stars last commit Blazor Server app that displays EventGrid messages in realtime & allows the ability to secure the app using Azure AD, KeyVault & Managed Identities.
CMS
Blogifier - GitHub stars GitHub stars ASP.NET Core Blogging application with Blazor Admin Dashboard. Demo.
eShopOnBlazor - GitHub stars last commit Migration of a traditional ASP.NET Web Forms app to Blazor.
RapidCMS - stars last commit A code-first, extensible Blazor app that generates a CMS for your own database.
JHipster.NET stars last commit JHipster is a well-known platform for generating modern application in java world. JHipster provides a blueprints system that allows to override the default behavior of the generator. JHipster.NET is a blueprint that overrides the back-end part, originally generated in spring boot, by back-end in asp.net core. For the front-end all the common language can be used (angular, react), including Blazor.
BlazorForum - stars Last commit Forum application built with Blazor.
BlazorShop - stars Last commit Simple shop application built with Blazor WebAssembly.
Atlas - stars Last commit A forum software built with ASP.NET Core Blazor WebAssembly.
Gitter - GitHub stars GitHub stars A Blazor Gitter client.
AcBlog - stars Last commit A blogging PWA that can be hosted as a full static website or as a server-prerender dynamic website. GitHub Pages Demo.
BlazingOrchard - stars Last commit Blazing Orchard is a modular application framework that turns your Blazor project into a CMS-powered Blazor application by leveraging Orchard Core as a decoupled backend/CMS server using its REST & GraphQL APIs.
BlazorGhost - Last commit A Blazor frontend for Ghost blogs.
BlazorWPBlog - last commit Wordpress blog with Blazor.
Games
AsteroidsWasm - stars last commit Collection of .NET 5 C# applications consuming a single .NET Standard project running in: Blazor Client (WebAssembly), Blazor Server, Electron (via Blazor Server), WPF, WinForms, Xamarin. Demo.
Trains.NET - stars last commit 2D game built with .NET and C#.
Flappy Blazor Bird - stars last-commit Blazor Flappy Bird's port. [Wasm Demo] | [Multiplayer Demo].
DiabloBlazor - stars last commit Blazor port of DiabloWeb, making it a double WebAssembly app: a WebAssembly (C#) PWA hosting a WebAssembly (C++) game. Demo.
BlazorGames - stars last commit This project is a Blazor WebAssembly project where we design, model, implement, and play common board and card games. This website is deployed here: blazorgames.net.
BlazorPong - last commit - Pong in Blazor server model and Wasm model using SignalR Core. Server Demo. Wasm Demo.
BlazorConnectFour - last commit Classic childhood game ConnectFour in Blazor.
Memory Game Wasm/PWA - last commit Simple Memory game with PWA support. Demo.
BlazorGame - last commit BlazorGame is a small proof-of-concept project to investigate the feasability of Blazor-based C# game development.
Lights out Blazor - last commit Clone based on the 1995 game Lights Out by Tiger Electronics Demo.
Minesweeper - last commit Minesweeper using C# and Blazor WebAssembly.
TicTacToe - last commit Tic Tac Toe game using blazor webassembly. Here is a Demo and a Blog post.
ZXSpectrum - last commit ZX Spectrum emulator running on Blazor WebAssembly. Demo.
BlazorDungeon - last commit - Multiuser dungeon game. Text based graphics. Up to 5 simultaneous players. Demo.
Flappy Bird last commit A Blazor WebAssembly implementation of Flappy Bird.
BlazorWordGame last commit Online Multiplayer Word Game With Blazor and SignalR on .NetCore.
Blazorships - last commit Battleship implementation built with Blazor and SignalR.
TetrisBlazor - last commit Online Game With Blazor and SignalR on .NetCore. Demo.
Hybrid
Blazor + Electron - Host Razor Components inside an Electron shell. This allows for modern, high-performance cross-platform desktop apps built with .NET and web technologies.
Blazor + WebWindow - WebWindow is like Electron, but without bundling Node.js or Chromium, and without most of the APIs. WebWindow source code. Blazor + WebWindow sample here.
BlazorMobile - stars last-commit Create full C# driven hybrid-apps for iOS, Android, UWP & Desktop with Blazor.
BlazorWebView - stars last-commit A BlazorWebView "Control" that is easily embedded in (Native) UI frameworks.
BlazorGrpc - GitHub stars GitHub stars Sample project that demonstrates how you can use the power of Blazor, ASP.NET Core, and gRPC to create a web application which can communicate with a backend that uses gRPC.
Blazor + Sitecore - GitHub stars GitHub stars Example of dynamic pages and routes with SiteCore and Helix.
Try F# on WebAssembly - stars GitHub stars The F# compiler running in WebAssembly with Bolero.
BlazorPoint - stars last commit Sample App to help you get started with hosting Blazor on SharePoint Pages, completely Client Side.
gRPC-Web - stars last commit Sample about gRPC-Web and Blazor WebAssembly.
desktoploveblazorweb - stars last-commit desktoploveblazorweb is a cross platform desktop application template(mobile support in the future) by pure Blazor Server Side, which work by use in process asp.net server + in process OS WebView component, which is better that mobilebinding for desktop as it's just use asp.net core api which will not has any comptiable problem(asp.net always works and webview always works, no trick).
Blazor + Umbraco Heartcore - Last commit Example of using Umbraco Heartcore with Blazor.
BlazorGrpcWebCodeFirst - last commit Sample project that demonstrates how you can use gRPC-Web with Blazor WebAssembly hosted on ASP.NET Core. Publish and consume your services without having to create .proto files - with the code-first approach.
SignalR CLR - last commit This is a simple example of using SignalR and Blazor WebAssembly together to eliminate the need for any JavaScript when handling server event's. Blog post about this sample.
Serverless StreamR - last commit A serverless port of StreamR powered by Blazor WebAssembly and Azure.
TonClientBlazor - last commit Free TON network client. Demo.
Blazor Server Firestore Integration last commit Source code of the article Building Real-Time Applications with Blazor Server and Firestore.
Blazorade Teams - last commit A Blazor component library that is designed to be used when building applications for Microsoft Teams. Be sure to also check out the initial announcement for Blazorade Teams.
GraphQL in ASP.NET Core using HotChocolate - last commit GraphQL in ASP.NET Core using HotChocolate. Source code of this tutorial: Consuming GraphQL API In ASP.NET Core.
IoT
PresenceLight - stars last commit PresenceLight is a solution to broadcast your various statuses to a Phillips Hue or LIFX light bulb. Some statuses you can broadcast are: your availability in Microsoft Teams, your current Windows 10 theme, and a theme or color of your choosing. Blog post. Demo video.
Logging
Logging.Samples - last-commit Samples for .NET Core and ASP.NET Core logging using various logger frameworks.
Machine Learning
Scalable sentiment analysis - stars last-commit A sample ables to make sentiment analysis prediction/detection of what the user is writing in a very UI interactive app (Blazor based) in the client side and running an ML.NET model (Sentiment analysis based on binary-classification) in the server side.
optimizer.ml - stars last-commit A "server-less" general purpose optimization suite for algorithm parameters. Also provides offline optimization of Quantconnect Lean trading algorithms. Demo (https://optimizer.ml).
Baseball Machine Learning Workbench - stars last-commit A web application that showcases performing what-if analysis using in-memory Machine Learning models. Live demo.
PropertyPrices - last-commit A blazor front-end site that provides analysis and ensemble learning predictions (through SharpLearning) of property prices in the UK. Demo (https://propertyprices.org.uk).
BlazorML5 - last-commit ML5 Machine Learning for Blazor with JSInterop mechanism.
BlazorChifoumi - last-commit Exploring machine learning with a Chifoumi game.
Mobile
Mobile Blazor Bindings - Experimental Mobile Blazor Bindings - Build native mobile apps with Blazor.
ToDos
Minimal ToDo by David Fowler - stars last commit Minimal ToDo backend API implementation by David Fowler from Microsoft.
Bolero.TodoMVC - GitHub stars GitHub stars A TodoMVC clone using Bolero.
Others
Flight Finder - stars last commit Flight Finder.
Oqtane Framework - GitHub stars GitHub stars Modular Application Framework for Blazor.
CarChecker - GitHub stars GitHub stars This is a sample application for Blazor by Steve Sanderson which was presented at Build 2020. You can view the on-demand walk-through for this on Channel 9: Modern Web UI with Blazor WebAssembly. This is a great sample which has a lot of Blazor + ASP.NET integrations such as: client-side debugging with Visual Studio, authentication / authorization, input validation, data integration/sync, Blazor components, code sharing, JavaScript interop, localization / internationalization, Progressive Web App (PWA) and more.
LinqToTwitter Blazor sample - stars last commit LINQ Provider for the Twitter API (Twitter Library).
BlazorFileReader - GitHub stars GitHub stars Read-only File streams in Blazor. Demo.
eShopOnBlazor - GitHub stars last commit Migration of a traditional ASP.NET Web Forms app to Blazor.
Toss.Blazor - stars last commit Twitter-like web application using Blazor.
BlazorChatSample - stars last commit Blazor chat demo using SignalR JS client with interop.
BlazorCRUD - GitHub stars GitHub stars Sample line of business application that illustrates key features of Blazor. Demo.
Blazor contacts - stars last commit A project template for OData API, IdentityServer4 auth, and server-side Blazor.
Money - stars last commit A money manager implemented using CQRS+ES. Demo.
CleanArchitecture - stars last commit Clean Architecture Template for Blazor WebAssembly Built with MudBlazor Components.
Blazor Weather - stars last commit A Blazor Weather sample app that shows the current weather for your current location and a collection of pinned locations. Demonstrated at .NET Conf 2019 by Daniel Roth. Demo.
Return - GitHub stars GitHub stars Realtime retrospective tool built in ASP.NET Core and Blazor.
NethereumBlazor - GitHub stars GitHub stars Ethereum blockchain explorer and simple wallet.
Runny - GitHub stars GitHub stars Prototype of running roslyn in the browser via Blazor. Demo.
BlazorDynamicList - GitHub stars GitHub stars Dynamic component binding for a generic list. Demo.
BlazorServerTree - GitHub stars GitHub stars A simple Server-Side Blazor sample app to deal with hierarchical data.
WebSocketPage - stars last-commit Web Socket in Blazor. demo.
BlazorPages - stars last-commit A sample client-side Blazor app showcasing automatic deployment to GitHub Pages via Azure Pipelines.
C# Minifer last-commit A client-side Blazor application demonstrating live minification of C# code using the C# Minifier library. Demo.
Planning Poker – Last commit An app to play Planning Poker for distributed teams. The app is implemented using Blazor and shows how to switch between client-side and server-side mode with a configuration change. Demo.
Gjallarhorn - Last commit Compare packages on different NuGet-sources. Demonstrating Client-Side Blazor MVVM-style.
C# Regex Tester online - Last commit Online tool for verify .Net regex syntax. (Demo).
C# Regex Online tool - Last commit Online tool for verify .Net regex syntax, see splits list, table etc. (Demo).
Blazor Tour of Heroes - Blazor Tour of Heroes, using Blazor-State(State Management architecture utilizing the MediatR pipeline) for the Redux style state.
Blazor.Console - last commit A simple component to mock CLI for ASP.NET Core 3.0 Blazor applications to execute some custom commands for an application.
Cognitive Studio - last commit PWA enabled app used to showcase what Cognitive Services can do, built-in client-side Blazor. Demo.
Blazor Wake-on-LAN - Last commit Wake-on-LAN app for local networks. Blazor Server + EF Core + DI + CI.
BlazorOCR - Last commit A Blazor WebAssembly application for reading receipts.
Dcidr - Last commit Blazor WebAssembly decision-making app with PWA (offline), localstorage, and Excel export. Demo.
BlazorParallax - Last commit Simple Parallax Page sample with Blazor Server.
GTAVehicles - last commit Sample app to manage GTA vehicles. Demo.
BlazingWaffles - last commit A Blazor app that wraps Waffle Generator. The generator outputs readable gibberish that can be used in place of Lorum Ipsum. Demo.
Poker Odds Pro Calculator - last commit Responsive poker odds calculator using blazor WebAssembly and pure C#. Demo.
Cærostris - last commit A Blazor Spotify client.
Blazor Chat - last commit A sample project that demonstrates using a Singleton class to communicate to all subscribers. Site is also live at https://blazorchat.com.
Nethereum Playground - last commit Compile and run Nethereum snippets on the browser. You can run it here: http://playground.nethereum.com/.
BlazorAnimate - last commit A simple example of animating text along a path using Blazor Canvas Extensions. Demo.
Realtime chat app with WebAssembly - last commit Real-time chat application with SignalR, .NET and Blazor/WebAssembly.
BlazorContrib - last commit Experiment of a Blazor renderer for Markdig, a Markdown component.
BlazeReport - last commit A minimal example of a Blazor App with NUnit, Selenium, SpecFlow and ExtentReports.
BlazorConduit - last commit The RealWorld example app written using Blazor. Demo.
Send an Sms - last commit This demo shows how to send an Sms with Blazor using the Vonage SMS API.
Ray Tracer - last commit Simple ray tracer in Blazor.
Blazor Web Camera Application Example - last commit Here is a fun example of using camera in the ASP.NET Core Blazor WebAssembly application. Complete description of how it was created on this blog's post Using a web camera with fun filters in your ASP.NET Core Blazor WebAssembly application.
BlazorPowerHour - last commit The Blazor Power Hour show index, by Ed Charbeneau.
BlazorMoonPhase - last commit Moon Phase Sighting app using Blazor WebAssembly, by Lohith GN. Demo.
BlazorTemplates - last commit A collection of blazor templates, designed for common use cases for new projects.
Pattern Maker - last commit C# code transformation demo that uses Roslyn and Monaco Editor. Demo, Demo2.
Modulight - last commit A light modular framework aimed to be low intrusive based on dependency injection for Blazor. Support lazy loading and prerendering for javascript, css stylesheets, and assemblies. Built with the new features introduced in .NET 5 such as WebAssembly Lazy Loading and Javascript Isolation.
TypinExamples - last commit A sample project that demonstrates the usage of Typin framework with a Blazor SPA application (Xterm.js and custom web workers implementation in C# to emulate terminal experience in browser). Live demo.
Unofficial eShopOnContainers - last commit Unofficial Blazor WebAssembly client for eShopOnContainers.
Tutorials
Blazor workshop - GitHub stars Blazor app building workshop by .NET Foundation, Blazzing Pizza.
Tetris in Blazor - March, 2021 - Part 1, Part 2, Part 3. Source code stars last commit.
Setting dynamic metadata for Blazor Web Assembly - March 23, 2021 - This post shows how HTML header meta data can be dynamically updated or changed for a Blazor Web assembly application routes hosted in ASP.NET Core. This can be usually for changing how URL link previews are displayed when sharing links. Source code stars last commit.
How to use gRPC-Web with Blazor WebAssembly on App Service - March 15, 2021 - How to use gRPC-Web with Blazor WebAssembly on App Service.
How to deploy Blazor WebAssembly to Cloudflare - March 14, 2021 - How to deploy Blazor WebAssembly to Cloudflare. Source code stars last commit.
Overriding components in Blazor - February 27, 2021 - If you use a component library in your project, you might want to override a component somewhere deep down in the component hierarchy without having to override the whole hierarchy.
Build a Blazor 'Copy to Clipboard' component with a Markdown editor - February 18, 2021 - Let's build a 'Copy to Clipboard' component, where we can copy Markdown content to the clipboard.
Blazor on Desktop - February 17, 2021 - This post explores how to make Blazor web apps run on Desktop.
Using source generators to generate a menu component in a Blazor app - February 16, 2021 - Using source generators to generate a menu component in a Blazor app.
The tablet app – part 1 - February 12, 2021 - Making an espresso machine smart, with .NET and Mobile Blazor Bindings.
Download Files from Azure with .NET Core Web API and Blazor WebAssembly - February 9, 2021 - In this article, we are going to learn how to download files from Azure using ASP.NET Core Web API as the server-side project and Blazor WebAssembly as the client-side. This article is a continuation of a previous one where we learned about uploading files to Azure. In that article, we also created Azure storage, so if you don’t have one created, you can do it following the instructions from the mentioned article. Source code stars last commit.
Using source generators to find all routable components in a Blazor WebAssembly app - February 9, 2021 - The previous post described a way to find all the "routable" components in a Blazor app using reflection. This post shows an alternative approach using a source generator.
Custom Xamarin Controls with Blazor Mobile Bindings - February 8, 2021 - Blazor Mobile Bindings is exciting, but also encourages reusability. We take a look as how to wrap custom Xamarin.Forms UI as Blazor components.
Create a Blazor Server app that uses the Microsoft identity platform for authentication - October 2020 - Tutorial by Microsoft. Blazor Server provides support for hosting Razor components on the server in an ASP.NET Core app. In this tutorial, you learn how to implement authentication and retrieve data from Microsoft Graph in a Blazor Server app with the Microsoft identity platform.
Consuming GraphQL API In ASP.NET Core - January, 2021 - Consuming GraphQL API In ASP.NET Core: Part 1, Part2. Source code stars last commit.
Prerending a Blazor WebAssembly app to static files, without an ASP.NET Core host app - January 26, 2021 - This post describes how you can prerender all the pages in a Blazor WebAssembly app, without requiring a host app. That means you can still host your Blazor WebAssembly as static files using GitHub Pages or Netlify, without requiring a backend server. Source code stars last commit.
Authentication in Blazor WebAssembly Hosted Applications - January 22, 2021 - Authentication in Blazor WebAssembly Hosted Applications, by Code Maze. Source code stars last commit.
Blast Off with Blazor: Build a search-as-you-type box - January 14, 2021 - This post shows how to build a quick search box that filters our images.
Boids in your Browser with Blazor - January 8, 2021 - How to model graphics in C# and render them on a HTML Canvas with JavaScript. Source code stars last commit.
Blazor WebAssembly I18n from Start to Finish - January 7, 2021 - Blazor is a strong C#-based framework from Microsoft that allows us to create an interactive, client-side web user interface (UI) using .NET. In this tutorial, we will explore how to implement internationalization (i18n) in a Blazor WebAssembly app.
Pre-render Blazor WebAssembly at build time to optimize for search engines - January 3, 2021 - Pre-render Blazor WebAssembly at build time to optimize for search engines.
Run Blazor in a Docker container with Visual Studio Code Remote Development - December 15, 2020 - Run Blazor in a Docker container with Visual Studio Code Remote Development.
Using multiple APIs in Blazor with Azure AD Authentication - December 14, 2020 - The post shows how to create a Blazor application which is hosted in an ASP.NET Core application and provides a public API which uses multiple downstream APIs. Both the Blazor client and the Blazor API are protected by Azure AD authentication. The Blazor UI Client is protected like any single page application. This is a public client which cannot keep a secret. Source code stars last commit.
Create a Blazor Server app that uses the Microsoft identity platform for authentication - October 2020 - Tutorial by Microsoft. Blazor Server provides support for hosting Razor components on the server in an ASP.NET Core app. In this tutorial, you learn how to implement authentication and retrieve data from Microsoft Graph in a Blazor Server app with the Microsoft identity platform.
Building a Blazor farm animal soundboard - October 2020 - Building a Blazor farm animal soundboard, by JetBrains. Source code stars last commit.
Tour of Heroes in Blazor Wasm Playlist - August 2020 - Using .Net 5 and Blazor WASM to create the Tour of Heroes app with the addition of how to create Unit Tests with bUnit. This tutorial counts 9 videos on YouTube.
Yahtzee in Blazor WebAssembly - August 2020 - Tutorial by Exception Not Found. Part 1: the C# model. Source code stars last commit.
Build a video portal with Blazor - August 2020 - Website contains videos about building a video portal with Blazor.
Online Multiplayer Word Game With Blazor and SignalR on .NetCore - August 8, 2020 - Let's build a simple online multiplayer word game with Blazor using SignalR for realtime communication between two players. All the words will keep in MongoDB and it will supports multi-platforms with .Net Core. Source code stars last commit.
Build a Blazor WebAssembly line of business app - June, 2020 - Build a Blazor WebAssembly line of business app. Part 1. Part 2. Part 3. Part 4. Source code stars last commit.
Simple RPG with .NET and Azure technologies - Follow along with the Simple RPG tutorials as we learn new areas of .NET and Azure technologies focused around Blazor client applications and Azure Functions for web service backends. Source code: https://dev.azure.com/d20Tek/SimpleRPG/_git/simple-rpg-game.
Create a 2D game with Blazor - July 2020 - Part 1: Intro. Part 2: Canvas initialization. Part 3: Sprite rendering. Part 4: Moving a sprite. Source code stars last-commit.
Build Tic Tac Toe game with Blazor WebAssembly - July 2020 - Build Tic Tac Toe game with Blazor WebAssembly. Source code stars last-commit. Demo.
Create a small blog in Blazor - June, 2020 - Create a small blog in Blazor, by RoundTheCode. Part 1: Create application in Visual Studio. Part 2: Entity Framework integration. Part 3: Build Entity Framework queries. Part 4: Build Category and Page Razor Components.
Custom Authentication in Blazor WebAssembly – Detailed Tutorial - June 12, 2020 - In this next part of the Blazor Blog Series, Let’s learn about implementing Custom Authentication in Blazor WebAssembly Project (Blazor.Learner). We will cover some core concepts that can get you familiar with how authentication works in Blazor Applications. Source code stars last-commit.
Blazor CRUD with Entity Framework Core – Detailed Tutorial - June 4, 2020 - Building a CRUD Application is like the Hello World for Intermediate Developers. It helps you understand the most common operations of any particular stack. In this tutorial, let’s build a Client-side Blazor CRUD Application that uses Entity Framework Core as it’s Data Access Layer. Source code stars last-commit.
Creating Outlook Calendar Client from scratch - May, 2020 - In this course you'll see how to develop a calendar application from scratch (design, structing and logic) then make it integrated with Microsoft Outlook so our events on the calendar being synced with Outlook. Source code stars last-commit.
PlannerApp full client-side project with Blazor WebAssembly - March 2020 - Video tutorial that covers how to build a full client-side application using Blazor WebAssembly, The back-end is already done and hosted on Azure so we will take advantage of that to teach you how to develop full application from scratch. Source code.
Build an Authenticated Web App in C# with Blazor - March, 2020 - Build an Authenticated Web App in C# with Blazor and octa.com service.
Building an Application with Blazorade Bootstrap - February 17, 2020 - Building an Application with Blazorade Bootstrap. Part 3. Part 2. Part 1. Source code.
Creating a step-by-step end-to-end database Client-Side (WebAssembly) Blazor application - February 15, 2020 - This post covers how a list of Weather forecasts can be added to the database by each user. A user will only have the ability to see their own forecasts.
Getting started with Blorc.PatternFly - January 7, 2020 - Getting started with Blorc.PatternFly. What is Blorc.PatternFly? Standing for Blazor, Orc, and PatternFly, Blorc.PatternFly is a library with the ultimate goal of wrapping all PatternFly components and making them available as Blazor components. Source code.
Archives - 2019, 2018.
Libraries & Extensions
Reusable components like buttons, inputs, grids and more.

Component bundles
Ant Design Blazor - GitHub stars last commit A set of enterprise-class UI components based on Ant Design and Blazor. (Docs as Demo).
MatBlazor - GitHub stars last commit Material Design components for Blazor. (Demo).
Blazorise - GitHub stars last commit Components for Blazor with support for Bootstrap, Bulma, AntDesign and Material CSS. (Bootstrap Demo), (Bulma Demo), (AntDesign Demo), (Material Demo).
BlazorStrap - GitHub stars last commit Material Design components for Blazor. Bootstrap 4 components for Blazor (Demo).
Element-Blazor - GitHub stars last commit A blazor component library using Element UI. API imitates Element, CSS directly uses Element's style, HTML structure directly uses Element's HTML structure. Blazor WebAssembly Version demo. Blazor WebAssembly Version PWA Mode demo.
Radzen.Blazor - GitHub stars last commit Native UI components for Blazor. DataGrid, DataList, Tabs, Dialog and more. (Demo).
BlazorFluentUI - stars last commit Simple port of FluenUI/Office Fabric React components and style to Blazor. Client-side demo (WebAssembly). Server-side demo (SignalR).
Skclusive.Material.Components - GitHub stars last commit Material Design components for Blazor (Dashboard Demo), (Components).
ComponentOne Blazor UI Components - External link. A fast datagrid, listview, input and other native Blazor components for server and client-side apps.
DevExpress Blazor UI Components - stars last commit A set of native UI Blazor components (including a Data Grid, Pivot Grid, Scheduler, and Charts) for both Blazor server-side and Blazor client-side platforms.
BlazorWebFormsComponents - stars last commit A collection of Blazor components that emulate the web forms components of the same name.
BootstrapBalzor - stars last commit Reusable bootstrap components for Blazor. (Docs as Demo).
MudBlazor - stars last commit MudBlazor is an ambitious Material Design component framework for Blazor with an emphasis on ease of use and clear structure. It is perfect for .NET developers who want to rapidly build web applications without having to struggle with CSS and Javascript. MudBlazor, being written entirely in C#, empowers them to adapt, fix or extend the framework and the multitude of examples in the documentation makes learning MudBlazor very easy. Documentation. Demo.
Syncfusion Blazor UI Components - GitHub stars last commit The most comprehensive native Blazor component library including Data Grid, Charts, Scheduler, Diagram and Document Editor components. (Demo).
ADMINLTE - stars last commit ADMINLTE for Blazor is a collection of reusable components, with which you can easily develop digital services as a designer or developer. Think of buttons, form elements and page templates. This project adapts ADMINLTE 3 so the components can be used from dotnet core Blazor.
LoreSoft.Blazor.Controls - stars last commit Auto-complete (Typeahead) textbox with local and remote data source, for both Client-side and Server-Side Blazor. Also has DateTimePicker and ToggleSwitch. Demo.
Material.Blazor - stars last commit An alternative Material Theme Razor Component Library. Material.Blazor focuses sharply on giving you pure markup from Google's material-components-web - we don't try to sit between you and your use of Google's CSS and SASS because they do it better than we ever could. We also have some cool "plus" components. See our demo and comprehensive documentation.
MComponents - stars last commit Open Source MIT Blazor Components: Grid, Select, Wizard etc.
PanoramicData Blazor UI Components - stars last commit An open source library of Blazor components including Table, Tree, ToolBar and FileExplorer. Demo.
Telerik UI for Blazor - External link (telerik.com). A native set of UI components for Blazor, including grid, charting, and calendar components.
Start Blazoring - A Blazor starter template built using Blazorise. It offers a myriad of features such as user registration, login, password reset, two factor; user management, roles, permissioning; background workers, logging, caching, email templates, localization and many more.
jQWidgets Blazor UI Components - last commit Feature-complete UI components including DataGrid, Scheduler, Charting, Pivot and more. Website.
Smart UI for Blazor - last commit Component library for Blazor including Grid, Kanban, Gantt, Chart, Docking, Pivot and more. Website.
Individual components
API
Canvas - stars last commit HTML5 Canvas API implementation for Microsoft Blazor.
Head Element Helper - stars last commit <Title> and <Meta> components for changing the document titile and meta elements, with server-side prerendering support for SEO/OGP. (Demo).
BrowserInterop - GitHub stars last commit This library provides access to browser API in a Blazor App.
Blazor.Canvas - GitHub stars last commit Wrapper library around the HTML canvas API written in C# (no JS dependency) (Demo).
Sve-Blazor-InfiniteScroll - last commit Simplistic implementation of an infinite scroll component for Blazor.
BlazorGooglePay - last commit Blazor wrapper around Js Google Pay, library based on BrowserInterop.
BlazorDependencies - last commit Js library that helps maitain dependencies of one Razor Class Library to another one without manually adding scripts and css-styles for each library.
Charts
ChartJs.Blazor - GitHub stars last commit Brings ChartJs charts to Blazor.
Blazor-Charts - GitHub stars last commit SVG charts for Blazor.
GG.Net Data Visualization - last commit Interactive and flexible charts for Blazor Web Apps. Taking its inspiration from the highly popular ggpplot2 R package, GG.Net provides natively rich features for your Data Analysis Workflow. Build publication quality charts with just a few lines of code. Website.
Blazor-Sparkline - last commit Sparkline Charts for Blazor using Fonts.
Blazor-ApexCharts - last commit Blazor wrapper for ApexCharts. Demo.
Plotly.Blazor - last commit Brings the charting library plotly.js with over 40 chart types to Blazor (Demo).
CSS
BlazorStyled - stars last commit CSS in Blazor Components (Demo).
BlazorSize - stars last commit BlazorSize is a JavaScript interop library for Blazor that is used to detect the Browser's current size, change in size, and test media queries.
BlazorAnimation - stars last commit A Blazor component based on animate.css to easly animate your content. Demo.
Flexor - last commit Highly configurable components which let you take full advantage of Flexbox CSS.(Demo).
BlazorCss - last commit CSS Helper for BlazorStyled which provides auto complete CSS styles.
BlazorCssGrid - last commit Css Helper for defining Grid SPA layouts in BlazorStyled.
Datagrids / tables
Grid.Blazor - stars last commit Grid component with CRUD forms for Blazor and ASP.NET MVC, supporting filtering, sorting, searching, paging, subgrids and others (Demo).
Blazor.FlexGrid - stars last commit GridView component for Blazor.
Sve-Blazor-DataTable - stars last commit Blazor DataTable component with support for client/server side paging, filtering and sorting, build on top of bootstrap 4.
Table.Net - last commit Interactive and flexible Data Tables for Blazor Web Apps.
BlazorTable - stars last commit A Table Control for Blazor with sorting, paging, filtering and more (Demo).
WpfGridLayout.Blazor - last commit Provide a simple way to create a grid layout like WPF in Blazor.
Date & time
NodaTimePicker - GitHub stars last commit A Date/Time picker component library for Blazor using NodaTime. Demo.
BlazorDateRangePicker - stars last commit A date range picker component library for Blazor. Demo.
FlatpickrBlazor - last commit Flatpickr Blazor interop.Demo.
Maps
BlazorGoogleMaps - GitHub stars last commit Blazor interop for GoogleMap library.
Markdowns
RazorComponents.Markdown - last commit A razor component for Markdown rendering which supports LaTeX, Mermaid diagram, code highlighting and extensions based on Markdig.
Blazor Markdown - last_commit A Blazor Markdown component that enables you to include Markdown files in your server-side Blazor apps.
Modal, Toast & Notifications
Blazored.Modal - GitHub stars last commit A JavaScript free modal library for Blazor and Razor Components applications.
Blazored.Toast - GitHub stars last commit A JavaScript free toast library for Blazor and Razor Component applications.
Sotsera.Blazor.Toaster - GitHub stars last commit A Blazor port of Toastr.js. Demo.
Tabs
BlazorXTabs - last commit An extended tabs component library providing various tab features for Blazor.
Testing
bUnit - a testing library for Blazor components - stars last commit A testing library for Blazor Components. You can easily define components under test in C# or Razor syntax and verify outcome using semantic HTML diffing/comparison logic. You can easily interact with and inspect components, trigger event handlers, provide cascading values, inject services, mock IJsRuntime, and perform snapshot testing.
Others
Stl.Fusion - GitHub stars last commit .NET Core and Blazor library that attempts to dramatically improve the way we implement real-time and high-load services by introducing a novel kind of "computed observables" - immutable, thread-safe, and most importantly, almost invisible for developers. Samples. Overview.
BlazorContextMenu - GitHub stars last commit A context menu component for Blazor (Demo).
BlazorInputFile - GitHub stars last commit A file input component for Blazor applications, by Steve Sanderson.
Blazored.Typeahead - GitHub stars last commit Auto-complete textbox with local and remote data source, for both Client-side and Server-Side Blazor.
Blazor-DragDrop - stars last commit Easy-to-use Drag and Drop library for Blazor.
Blazored.Menu - stars last commit A JavaScript free menu library for Blazor and Razor Components applications.
Blazor LoadingBar - GitHub stars last commit Loading bar UI for Client-Side Blazor application.
Z.Blazor.Diagrams - stars last commit A fully customizable and extensible all-purpose diagrams library for Blazor, inspired by the popular react-diagrams library, with many additions. Demo.
Excubo.Blazor.Diagrams - stars last commit Interactive diagram component (flowcharts, UML, BPMN, ...), customizable and extensible according to user needs (node types, styles). Demo.
BlazorDownloadFile - stars last commit Blazor download files to the browser from c# without any JavaScript library or dependency.
Blazor.SignaturePad - stars last commit A Blazor component library that utilizes Szymon Nowak's javascript library Signature Pad to implement smooth signature drawing on a HTML5 canvas.
Blorc.PatternFly - stars last commit Blazor wrappers for PatternFly. To view the latest develop branch in action, visit the demo app.
BlazorTransitionableRoute - stars last commit Allows current and previous route to exist enabling transition animations of UI/UX design systems.
Blazor-Dom-Confetti - last commit Celebrate success with dom 🎉confetti🎉 on Blazor projects. Two versions, dom-confetti wrapper and native blazor 100% JS free.
TwitterShareButton - last commit A Tweet Button component for Blazor.
Blazor.LoadingIndicator - last commit Simple to use loading indicator helper library.
BlazorTypography - last commit A powerful toolkit for building websites with beautiful design (Demo).
Razor.SweetAlert2 - last commit Blazor component implementing the popular SweetAlert2 JavaScript Library.
Blazor.SpinKit - last commit Blazor components for SpinKit spinners.
Localized Data Annotations Validator - last commit The data annotations validator for Blazor to localize validation error messages. (Demo).
LiquidTechnologies.Blazor.ModalDialog - last commit Turns Blazor components into Modal Dialogs, allows values to be returned from the dialogs (var result = await ShowDialogAsync(...)), includes simple MessageBox and data capture dialogs (for Blazor Client & Server).
BlazorMonaco - last commit Blazor component for Microsoft's Monaco Editor which powers Visual Studio Code. (Demo).
BlazorContentEditable - last commit Provides contenteditable functionality for Blazor. (Demo).
Blazor.Grids - last commit Component library for CSS grids with extra features, such as moving and resizing interactively. Create your own dashboard with ease. (Demo).
Blazor.TreeViews - last commit Component library for tree views. (Demo).
DnetOverlay - last commit Agular CDK Overlay implementation for Blazor.
GEmojiSharp.Blazor - last commit GitHub Emoji for Blazor (Demo).
Texnomic.Blazor.hCaptcha - last commit hCaptcha Component for Server-Side Blazor.
BlazorDialog - last commit Dialog component as a service for Blazor. Demo.
BlazorWheelZoom - last commit Zoom and move image with Blazor using mouse wheel and mouse drag - minimal javascript. Demo.
AdvancedBlazorSelect2 - last commit Simple wrapper for Select2 with full support of databases and custom web APIs.
BlazorSliders - last commit Create multiple panels separated by sliding splitters.
BlazorTypewriter - last commit A typewriter effect for Blazor.
Tools & Utilities
Libraries and extensions for state management, cookies, local storage and other specific tools.

Blazor-Redux - GitHub stars last commit Connecting a Redux state store with Blazor.
Fluxor - GitHub stars last commit Zero boilerplate Flux/Redux library for DotNet. Formerly Blazor-Fluxor GitHub stars.
SignalR - GitHub stars last commit SignalR Core implementation for Blazor. It uses the JavaScript client.
Blazored.LocalStorage - GitHub stars last commit A library to provide access to local storage in Blazor applications.
Storage - GitHub stars last commit HTML5 Storage API implementation for Microsoft Blazor.
Blazor-State - GitHub stars last commit Manage client side state in Blazor using MediatR pipeline.
bUnit - a testing library for Blazor components - GitHub stars last commit A testing library for Blazor Components. You can easily define components under test in C# or Razor syntax and verify outcome using semantic HTML diffing/comparison logic. You can easily interact with and inspect components, trigger event handlers, provide cascading values, inject services, mock IJsRuntime, and perform snapshot testing.
Logging - GitHub stars last commit Microsoft Extension Logging implementation for Blazor.
BlazorStorage - GitHub stars last commit Local and session storage support for Blazor.
Blazor.Auth0 - stars last commit The library for using Auth0 in Blazor applications.
TextCopy - GitHub stars last commit A cross platform package to copy text to and from the clipboard. Supports Blazor via the Clipboard Browser API.
CssBuilder - GitHub stars last commit CssBuilder is a Builder pattern for CSS classes to be used with Razor Components.
Notifications - GitHub stars last commit HTML5 Notifications API implementation for Microsoft Blazor.
Blazor.Polyfill - GitHub stars last commit Polyfills for Blazor (for Internet Explorer 11 support and some other browsers).
Blazor I18n/Localization Text - stars last commit Localizing contents text in Blazor (Demo).
BlazorGoogleMaps - stars last commit Blazor interop for GoogleMap library.
Blazor.Geolocation - stars last commit Blazor interop for browser Geolocation APIs.
BlazorSignalR - GitHub stars last commit SignalR Core .NET client library for Blazor. It uses the C# client.
MvvmBlazor - stars last commit BlazorMVVM is a small framework for building Blazor and BlazorServerside apps. With it's simple to use MVVM pattern you can boost up your development speed while minimizing the hazzle to just make it work.
Blazored.Localisation - stars last commit A library to provide localisation in client-side Blazor applications.
EmbeddedBlazorContent - GitHub stars last commit Library to load embedded content files (js and css) from Blazor libraries in server-side Blazor mode.
Cortex.Net - GitHub stars last commit State management like MobX for .NET and Blazor. Documentation.
Blazor Analytics - Blazor extensions for Analytics.
BlazorWorker - stars last commit Library for creating DotNet Web Worker threads/multithreading in Blazor. Live demo.
Blazor PDF - stars last-commit Generate de PDF document with iTextSharp from a Blazor Server App.
Blazor SVG Helper - stars last commit Create SVG elements with children (circle, rectangle, image, text, and others) and render with RenderTreeBuilder.
Blazor.Payments - stars last commit Blazor Web Agent port of the Web Payment API standard developed by W3C.
BlazorRouter - stars last commit BlazorRouter is an awesome router inspired by react-router, providing declarative routing for Blazor.
DataJuggler.Blazor.FileUpload - stars last commit Wrapper for Steve Sanderson's BlazorFileInput component.
BlazorPrettyCode - Blazor Code Component for documentation sites. Demo.
Blazor.EventAggregator - Lightweight Event Aggregator for Blazor (Razor Components).
Blazor Gamepad - Provides gamepad API access for Blazor.
Blazor Hotkeys - A library to provide configuration-centric keyboard shortcuts for Blazor.
BlazorRealm - Redux state management for Blazor.
Blazor.LocalFiles - Open files in your browser and load into Blazor.
Blazor.SpeechSynthesis - last commit A library to provide Speech Synthesis API access for Blazor.
Blazor BarCode – A barcode library for Blazor using barcode fonts.
BlazorState.Redux - last commit Develop Blazor apps with Redux.
BlazorLeaflet - last commit BlazorLeaflet is a wrapper offering easy-to-use Blazor components that expose the Leaflet API in C#.
Howler.Blazor - last commit A Blazor JSInterop wrapper for Howler.js, an audio library.
jsMind.Blazor - last commit A Blazor JSInterop wrapper for jsMind, a MindMapping tool.
Blazor Highcharts - last commit A port of the popular Highcharts library. Demo.
Blazor.LazyStyleSheet - last commit Lazy loading for CSS style sheets.
Blazor.ScriptInjection - stars last commit Smart script tags in Blazor components, ideal for lazy loading of javascript files.
DnetIndexedDb - last commit Blazor Library for IndexedDB DOM API.
BlazorIndexedDbJs - last commit BlazorIndexedDbJs is a wrapper arround IndexedDB DOM API, supports Blazor WASM and Server.
PkcsExtensions.Blazor - last commit A library to provide crypto and digital signature functionality for Blazor WebAssembly and light WebCrypto interop.
Blazor-Color-Picker - last commit Opens a palette with the Material colors for Blazor application.
Blazor_EmojiFilePicker - last commit Bootstrap Text-Input with Smiley- and File-Support for Blazor.
Blazor Library Asset Helper - last commit A VISX extension that can list all JS and CSS assets from Nuget package razor libraries you are using in your Blazor app. It will generate all the <script> and <link> tags for your HTML page for you to copy/paste. Available on the Visual Studio Marketplace.
Blazm.Bluetooth - last commit A Blazor library for connecting to devices using Bluetooth.
BlazorApplicationInsights - last commit Application Insights for Blazor web applications.
BracketShow.BlazorNavigationManagerExtensions - last commit Simple set of extensions for the Navigation Manager to simplify its usage for things we are likely to do in most of our Blazor applications.
BlazorX.NavigationState - last commit BlazorX.NavigationState provides a set of utilities that allow you to observe and bind query strings directly to Blazor components.
Blazor Printing - last-commit Print and save PDF documents with a native print dialog in a Blazor Server or client Application.
Others
Blazor Extensions Home - GitHub stars Home for Blazor Extensions.
Bolero - GitHub stars last commit Blazor for F# with hot reloaded templates, type-safe endpoints and routing, remoting, and much more.
BlazorMobile - GitHub stars last commit Launch Blazor as a mobile application on iOS, Android & UWP.
NObservable - GitHub stars last commit MobX-like observables and component instrumentation.
BlazorFabric - GitHub stars last commit Blazor port of Microsoft UI Fabric with fluent design. (Demo).
Blazor-Dashboard - stars last commit Admin Dashboard Template Theme for Blazor.
BlazorEmbedLibrary - GitHub stars last commit Provides Blazor-style embedded static content files for Razor Components projects.
BlazorWebView - GitHub stars last commit Blazor WebView control for WPF, Android, macOS, iOS. Run Blazor on .NET Core and Mono natively inside a Webview. Documentation.
WebSocketHelper - stars last commit Helper for Web Socket in Blazor.
BlazorLazyLoading - GitHub stars last commit Production ready lazy loading implementation. Full lazy loading support for WASM and Server (pages, components, dlls) with abstractions to implement modularization if you wish (custom endpoints, custom manifests, etc).
BlazorLazyLoad - stars last commit BlazorLazyLoad is a implementation of assembly lazy load feature in Blazor WASM application on both page and component level.
SpotifyService - stars last commit A high-level Spotify API library for Blazor WebAssembly projects that enables Spotify playback in the browser, manages OAuth 2.0 authorization, provides easy access to the Spotify Web API and uses IndexedDB caching.
Bionic - An Ionic CLI clone for Blazor projects.
BlazorFileSaver - Blazor Component wrapper for FileSaver.js (Demo).
Blazor.DynamicJavascriptRuntime.Evaluator - Execute dynamic object expressions as Javascript in Blazor client-side apps.
Blazor.AdaptiveCards - Adaptive Cards for Blazor. Documentation.
EventHorizon Blazor TypeScript Interop Generator - last commit This project takes in a TypeScript type definition file and creates a .NET Core project that will work with the provided Interop abstraction project.
Generators.Blazor - last commit Generators.Blazor is a source generator for improving performance in Blazor. The project also contains analyzers to detect common issues in Blazor apps.
Videos
WebAPI vs gRPC in Blazor Train - duration April 16, 2021 - Carl Franklin shows you how to use gRPC in your Blazor apps as an alternative to a more common API layer. You can download all files atblazortrain.com.
ASP.NET Community Standup - Exploring Oqtane with Shaun Walker - duration April 13, 2021 - In this edition of the Blazor community standup, we sit down with Shaun Walker to discuss all things Oqtane. Community links.
Blazor WebAssembly : Cookie Expiration & API Authorization - duration April 7, 2021 - This video shows how you can set authentication properties for cookie authentication. You can set it's IsPersistent to keep the cookie alive even after the browser is closed. You can also set it's ExpiredUtc property to set expiry date for your cookies.
Deploying Blazor WebAssembly to GitHub Pages - duration March 30, 2021 - The .NET Docs Show - Deploying Blazor WebAssembly to GitHub Pages. What's better than Blazor? How about Blazor and a free place to host your Blazor app? In this episode, community member Niels Swimberghe shows the panel how to deploy Blazor apps to GitHub Pages.
Testing Blazor Apps & Components - March 26, 2021 - Blazor Train, episode 43: Testing Blazor Apps & Components.
Steve Sanderson at the NDC Manchester 2021 - March 25, 2021 - Blazor in 2021: .NET 5, .NET 6 and beyond.
Blazor WebAssembly : Creating Chat Application Using SignalR - duration March 25, 2021 - Blazor WebAssembly : Creating Chat Application Using SignalR.
Introduction to Dynamic Components in Blazor - duration March 22, 2021 - This video shows how you can use one of the most interesting features in Blazor w/ .NET 6.0 preview which is Dynamic Components. Dynamic Components can help you load content from multiple components dynamically in Blazor without too much hassle. Source code stars last commit.
Building a Blazor WebAssembly chat using SignalR - March 8, 2021 - duration Building a Blazor WebAssembly chat using SignalR, by Coding After Work.
Multiple Panels with Sliding Splitters - March 5, 2021 - Blazor Train, episode 40: Multiple Panels with Sliding Splitters.
Blazor Power Hour: Empty State Components - March 3, 2021 - duration Blazor Power Hour: Empty State Components, with Ed Charbeneau.
Blazor WebAssembly : JavaScript Isolation - duration March 1, 2021 - Blazor WebAssembly : JavaScript Isolation, by Curious Drive. This video is about how you can isolate JavaScript files in Blazor applications. With JavaScript isolation you can load your JavaScript files only when needed. Source code stars last commit.
Blazor StateHasChanged: Preview 6 DynamicComponent - February 26, 2021 - duration Blazor StateHasChanged: Preview 6 DynamicComponent, with Ed Charbeneau.
.NET Conf 2021 - Focus on Windows: Building .NET Hybrid Apps with Blazor - February 25, 2021 - .NET Conf: Focus on Windows, session "Building .NET Hybrid Apps with Blazor", by Daniel Roth.
.NET Conf 2021 - Focus on Windows: Real-Time Desktop Apps with Azure SignalR Service - February 25, 2021 - .NET Conf: Focus on Windows, session "Real-Time Desktop Apps with Azure SignalR Service".
.NET Conf 2021 - Focus on Windows - duration February 25, 2021 - .NET Conf: Focus on Windows is a free, one-day livestream event that features speakers from the community and Microsoft teams working on Windows desktop apps and making them fantastic on the latest .NET 5. Learn why and how to upgrade WPF and Windows Forms apps to .NET 5, see Visual Studio tooling improvements, learn how to leverage cloud services from your client apps, and a whole lot more. You'll also see what the future of native device development with .NET will look like in .NET 6. Full schedule: dotnetconf.net.
Blazor Power Hour: Blazor Layout Components - February 22, 2021 - duration Blazor Power Hour: Blazor Layout Components, with Ed Charbeneau.
Blazor WebAssembly : Virtualize Component - duration February 22, 2021 - Blazor WebAssembly : Virtualize Component, by Curious Drive. This video shows how you can use Virtualize component and load thousands of records in efficient way. We will first check how it actually works then we will map to a web API which gets records which are visible to the users.
Blazor Train: Options for Mobile Apps - duration February 19, 2021 - Carl Franklin welcomes back Microsoft’s Dan Roth to discuss options for building mobile apps with Blazor.
Test Driving the Blazing Pizza Workshop - duration February 10, 2021 - Test Driving the Blazing Pizza Workshop, episode 3, by Egil Hansen.
Advanced Blazor experiences with Carl Franklin - duration February 10, 2021 - Advanced Blazor experiences with Carl Franklin, by Coding After Work. Carl Franklin will share a bit more advanced scenarios like using SignalR together with Blazor for cross user communication and data synchronization.
ASP.NET Community Standup - A Blazor Conversation with Chris Sainty - duration February 9, 2021 - In this standup, we chat with Blazor aficionado and open source community member Chris Sainty about Blazor, his open source work, and more.
Just Coding - Blazor Game - February 4, 2021 - duration Just Coding - Blazor Game, by The Sixth Figure dev.
Blazor Power Hour: FAQ show #1 - duration February 3, 2021 - Blazor Power Hour: FAQ show 1, with ed Charbeneau.
Blazor Train: Ask the Engineer - January 29, 2021 - Carl Franklin answers your questions and solves your Blazor puzzlers.
BlazQ (Learn to code) - January 29, 2021 - duration Develop a quiz application with Blazor.
.NET Frontend day 2021 - January 28, 2021 - duration .NET Frontend Day 2021 sessions.
Blazor Train: Progressive Web Applications - duration January 15, 2021 - Carl Franklin shows you how to create a Blazor PWA and how to configure it for offline access and cached content.
.NET Community Standup: Meet the Blazor Team - duration January 12, 2021 - "Meet the Blazor Team"'s .NET Community Standup. Meet the people behind the code! Join us for a fun livestream with members of the Blazor team.
KlipTok update, next steps with C#, Blazor and Azure - duration December 29, 2020 - KlipTok update, next steps with C#, Blazor and Azure.
Mobile Web App Layout with Blazor - duration December 27, 2020 - Mobile Web App Layout with Blazor.
Security fixes, Performance Tuning, Blazor and Azure - duration December 22, 2020 - Security fixes, Performance Tuning, Blazor and Azure.
Blazor Train: Synchronicity 5.0 - December 18, 2020 - Carl Franklin shows how to develop both a Blazor Server and Blazor Wasm project simultaneously using .NET 5.
Blazor vs React/Angular - duration December 11, 2020 - Debate about Blazor vs React/Angular, featuring Michael Washington on The Growth Mindset Show.
Blazor Power Hour: Front End Tools and CSS - duration December 9, 2020 - Blazor Power Hour: Front End Tools and CSS, with Ed Charbeneau.
ASP.NET Community Standup - Material Design in Blazor with Material.Blazor - duration December 8, 2020 - We sit with Simon Ziegler and Mark Stega of Material.Blazor to discuss the project, Material.Blazor, a Material design component library for Blazor. ASP.NET Community Standup. Url list.
Blazor Train: Using SignalR for cross-user Communication - duration December 4, 2020 - Carl Franklin shows you how to seamlessly add SignalR to any Blazor app.
Developing interactive websites with C# using Blazor with Jimmy Engstrom - duration November 26, 2020 - Creating an interactive website today takes a lot of effort. You need to know a bunch of frameworks, languages and tools like Angular, React, JavaScript, Web pack, NPM, Bower, the list is long. What if there is a way to develop interactive websites without having to learn all these things? What if there is a way to develop in only one language, in C#? What if there is a way to do all that without using any Web Browser plugin? In this session Jimmy will show you what he believes to be the future of web development, Blazor. He will show how to get started and also share some of the new things in .NET5 so there be will be something for everybody. Also available on Twitch.
How to Create RDLC Report in Blazor - duration November 24, 2020 - This video is about how to Create RDLC Report in Blazor Server application, how to use RDLC (.rdlc) report in Blazor.
Blazor Train: Adding Azure AD B2C to an existing app - duration November 20, 2020 - Carl Franklin welcomes back Joel Hulen to demystify Azure AD B2C.
Blazor: .NET 5 JavaScript interop modules revisited - duration November 20, 2020 - Blazor: .NET 5 JavaScript interop modules revisited, by Ed Charbeneau.
Blazor: .NET 5 JavaScript interop modules - duration November 20, 2020 - Blazor: .NET 5 JavaScript interop modules, by Ed Charbeneau.
ASP.NET Community Standup - Unit Testing Blazor with bUnit - duration November 17, 2020 - On this month's Blazor Community Spotlight, we'll be talking to Egil Hansen about unit testing Blazor components with bUnit.
Migrating a Windows Forms App to Blazor: The Amazing and True Story of GIFBot - duration November 13, 2020 - In this talk, I will discuss the migration steps undertaken to go from a complex Desktop application to a robust ASP.NET-backed website with a Blazor front-end. The talk will highlight the ease at which I was able to translate functionality as a developer with very outdated web development skills.
Blazor Train: Basic Authentication and Authorization in Blazor Web Assembly - duration November 13, 2020 - Carl shows you how to use ASP.NET Core Identity for basic authentication and authorization in a Blazor WebAssembly app.
Blazor Stability Testing Tools for Bullet Proof Applications - duration November 13, 2020 - .NET in the browser may sound like Blazor's strength, however the story of Blazor testing may just be its biggest potential upside. In this session we'll discuss what makes Blazor an ideal candidate for: Unit Testing, Integration Testing, and Automated System Testing. With Jon Galloway.
Building Real-time Applications with Blazor and GraphQL - duration November 12, 2020 - Come see how Blazor and GraphQL combined will revolutionize how we build rich SPA applications with .NET. .NET Conf 2020, Day #3.
Application State in Blazor Apps - duration November 12, 2020 - Carl shows you the benefits of keeping application data outside components and pages, how to do cross-component change notifications, and how to persist that AppState to localstorage. .NET Conf 2020, Day #3.
From Web Forms to Blazor - Introducing the Blazor Web Forms Components - duration November 12, 2020 - There are millions of ASP.NET Web Forms applications out there. How do you migrate them to .NET Core? With Blazor of course! In this talk, learn about the easy steps you can take to successfully migrate your application to Blazor with the BlazorWebFormComponents. .NET Conf 2020, Day #3.
Components in Blazor - duration November 12, 2020 - Blazor is the blazing word in the Microsoft Tech stack at the moment because you can run C# on the client. In this session, I will talk about what Razor components are, talk about their lifecycle, event handling, and how to pass information between Blazor Components. .NET Conf 2020, Day #3.
Trailblazor: Building Dynamic Applications with Blazor - duration November 12, 2020 - Underpinning Blazor's ability to create interactive web UIs using C# instead of JavaScript is a robust component model which offers exciting new opportunities for developers to create dynamic web applications. In this session we will explore a modular application framework for Blazor called Oqtane. .NET Conf 2020, Day #3.
Microfrontends with Blazor: Welcome to the Party! - duration November 12, 2020 - In this talk, microfrontends expert Florian Rappl introduces an established architecture for a creating modular frontend applications. He will show how this architecture can be implemented together with Blazor to create dynamic user experiences. .NET Conf 2020, Day #3.
Getting Started With Blazor - duration November 12, 2020 - In this session, we will introduce the core concepts for Blazor development, both client and server side. Then we will dive in to a Blazor Web Assembly example and look at how we can build rich client side apps in C#. .NET Conf 2020, Day #3.
Blazor: Client Side vs. Server Side: Hands on Development and Deployment - duration November 11, 2020 - We will look at the main differences between Client Side Blazor, and Server Side Blazor. We will discuss situations and scenarios in which one should be favored over the other. We will develop a small app & deploy it twice on Azure: As a Client Side Blazor App, and as a Server Side Blazor App. .NET Conf 2020, Day #2.
Migrating a Windows Forms App to Blazor: The Amazing and True Story of GIFBot - duration November 11, 2020 - In this talk, I will discuss the migration steps undertaken to go from a complex Desktop application to a robust ASP.NET-backed website with a Blazor front-end. The talk will highlight the ease at which I was able to translate functionality as a developer with very outdated web development skills. .NET Conf 2020, Day #2.
Modern Web Development with Blazor & .NET 5 - duration November 10, 2020 - Blazor isn't just for new apps! Blazor in .NET 5 is integrated seamlessly with ASP.NET Core to enable modern full stack web development with .NET. In this session we'll show you how you can use Blazor and ASP.NET Core together to add rich client-side interactivity to both new and existing apps. You'll learn how to use Blazor components from your existing MVC views and Razor Pages, handle server-side prerendering, setup authentication & authorization, improve load time performance, and then deploy your app into production. .NET Conf 2020, Day #1.
A talk for trailblazers: Blazor in .NET 5 - duration November 10, 2020 - Wondering what's in store for Blazor in .NET 5? Wonder no more! This talk features the latest and greatest features to arrive in Blazor as part of .NET 5. From improved APIs for working with the browser to CSS isolation to a variety of performance improvements, you'll leave this presentation with rundown of everything you'll be able to do in the latest version of Blazor. .NET Conf 2020, Day #1.
.NET Conf 2020: Day 1, full video - duration November 10, 2020 - Full video of the first day of the .NET Conf 2020.
Blazor + Xamarin == WHOA! - duration November 5, 2020 - Xamarin Community Standup - Blazor + Xamarin == WHOA! with Eilon Lipton. Join the Xamarin Team as they discuss the latest and greatest for Xamarin. This week we sit down with Eilon Lipton to discuss the latest in the Mobile Blazor Bindings.
Blazor Train: Basic Authentication and Authorization - November 02, 2020 - Carl shows you how to use ASP.NET Core Identity for basic authentication and authorization using a SQL Server.
.NET 5 Migrating NuGet Packages - duration October 31, 2020 - .NET 5 Migrating NuGet Packages, by Ed Charbeneau.
Blazor & Comet for Native Mobile Apps - duration October 26, 2020 - Sam Basu from Telerik joins the panel to show us how to use Blazor and Comet in native mobile apps.
Run EF Core queries on SQL Server from Blazor WebAssembly - duration October 26, 2020 - Session of the Atlanta .Net User Group by Jeremy Likness, "Run Entity Framework Core queries on SQL Server from Blazor WebAssembly".
Blazor Train: MVVM Part 2 - duration October 26, 2020 - Carl shows more advanced MVVM patterns in Blazor.
Game Platform Development - Component Library and Deployment Scripts - duration October 24, 2020 - Game Platform Development - Component Library and Deployment Scripts. Topics: C#, .NET Core, Blazor, Docker, Kubernetes.
DevReach Day 1: Blazor - duration October 19, 2020 - Ed Charbeneau wants to break free from JavaScript! Join him as he chats with and builds a magic Blazor app with industry experts like Daniel Roth, Jeremy Likness and Chris Sainty. Remember, live pair-coding means there will be laughter, the presenters themselves might get stumped and there will be ample opportunity for you to engage! DevReach's website.
Game Platform Development - Component Library and Deployment Scripts - Part 2 - duration October 19, 2020 - Game Platform Development - Component Library and Deployment Scripts. Topics: C#, .NET Core, Blazor, Docker, Kubernetes. Part 1.
Game Platform Development - Component Library and Deployment Scripts - Part 1 - duration October 19, 2020 - Game Platform Development - Component Library and Deployment Scripts. Topics: C#, .NET Core, Blazor, Docker, Kubernetes. Part 2.
.NET 5 migration pains - duration October 16, 2020 - .NET 5 migration pains, by Ed Charbeneau.
ASP.NET Core Series: PWA's with Blazor - duration October 15, 2020 - Progressive Web Applications (PWA) use modern browser APIs and capabilities to behave like a desktop app. Since Blazor WebAssembly is a standards-based client-side web app platform, developers have the ability to leverage these browser APIs and create PWAs using .NET. In this episode, Jeremy is joined by Dan Roth to discuss the built in support for building PWAs with Blazor and show us a few demos of how get started.
On .NET Live - Diving into Azure Static Web Apps - duration October 15, 2020 - Azure Static Web Apps allows you to develop modern web applications that automatically publish from changes made in GitHub. You can build your frontends in your framework of choice and back them powerful APIs based on Azure Functions. In this session, Anthony Chu joins us to talk about this new service and what it means for .NET Developers building Blazor applications.
Blazor WebAssembly : Twitter Authentication/Login - duration October 12, 2020 - Blazor WebAssembly : Twitter Authentication/Login, by Curious Drive.
Setup Your Blazor Wasm and ASP.NET Core Web API in Azure Devops: Dev To Azure - Part 1 - duration October 12, 2020 - Setup Your Blazor Wasm and ASP.NET Core Web API in Azure Devops: Dev To Azure - Part 1. Article.
Blazor Train: Daniel Roth on .NET 5 Blazor - October 9, 2020 - Carl welcomes back Daniel Roth to demo what's new in .NET 5 Blazor.
Blazor: Our first impressions with Andrew Lock - October 9, 2020 - Blazor: Our first impressions with Andrew Lock, by Loosely Coupled Show. Are you on the Blazor train? Some of us are hesitant with scars from the past, even though they might not be warranted.
Telerik Reporting and Testing R3 2020 Release - duration October 5, 2020 - Tech Is Evolving, and so Are Telerik & Kendo UI with R3 2020: Telerik Reporting & Test Studio Dev Edition Fully Integrate with All Suites, including Blazor.
Blazor Train: Adding Blazor to an Existing MVC Application - duration October 2, 2020 - Carl welcomes Brian MacKay who shows you how to add Blazor pages and components to an existing MVC app.
Game Platform Development - Planning for Alpha Release - duration September 29, 2020 - Game Platform Development by CAhorn - Planning for Alpha Release.
Blazor WebAssembly : Authentication State - duration September 26, 2020 - Blazor WebAssembly : Authentication State, by Curious Drive. Source code stars last commit.
Blazor vs. MVC - duration September 25, 2020 - Blazor vs. MVC, by Ed Charbeneau.
GameDev - Bugs and Docker - duration September 22, 2020 - GameDev - Bugs and Docker by CAhorn.
Blazor MVVM the "logical" choice - duration September 18, 2020 - Blazor MVVM the "logical" choice, by Ed Charbeneau.
Blazor Train: WebForms to Blazor with Jeff Fritz - duration September 11, 2020 - Carl welcomes Microsoft’s Jeff Fritz to give hope to WebForms developers who want to move to Blazor.
Blazor BlazingCoffee and Markdown - duration September 11, 2020 - Blazor BlazingCoffee and Markdown, by Ed Charbeneau.
Testing Blazor Apps - duration September 4, 2020 - Testing Blazor Apps, by Ed Charbeneau.
Blazor WebAssembly : Custom Authentication - duration September 3, 2020 - Blazor WebAssembly : Custom Authentication, by Curious Drive.
iJS London: Blazor WebAssembly - duration September 2, 2020 - Blazor WebAssembly by Rainer Stropek at the International JavaScript Conference. This is an introduction to Blazor WebAssembly. Here the source code of the Starship traveler demo mentionned in the talk stars last commit.
Rendering an Orchard Core Markdown Blog Post with Blazor WebAssembly - duration August 30, 2020 - Rendering an Orchard Core Markdown Blog Post with Blazor WebAssembly.
Testing Blazor Apps - duration August 29, 2020 - Testing Blazor Apps by Ed Charbeneau, about xUnit, bUnit, Telerik Test Studio and more.
Preparing a Blazor Lightning Talk - duration August 29, 2020 - Preparing a Blazor Lightning Talk, by Csharpfritz.
Write OnClick Events in C# using Blazor and Eliminate JavaScript - duration August 25, 2020 - JavaScript can be eliminated for implementing an OnClick event and many other HTML event attributes. With Blazor, we go ahead and write an OnClick event in C# without the need for JavaScript.
Blazor Train: Data Access - duration August 24, 2020 - Carl brings together an API layer, a generic data manager, and EF Core to create a complete solution.
The .NET Docs Show - .NET open-source projects - duration August 24, 2020 - Chat with Isaac Levin (@isaacrlevin) about some exciting .NET open source projects he's been working on. By The .NET Docs show. Article on Dev.to about this episode.
Blazor Game Client + Working on GUI System - duration August 23, 2020 - Blazor Game Client + Working on GUI System.
How to Create Services in Client Side Apps - duration August 21, 2020 - We are upgrading our Blazor App Tour Of Heroes with Services! This will allow the components to keep state even when we navigate away along with creating some reusable code for our apis. If you like this video please subscribe and let me know you would like to see more. Based of Tour of Heroes section 4.
Let's Build Flappy Bird - duration August 18, 2020 - Let's Build Flappy Bird with Blazor WebAssembly. Source code stars last commit.
Blazor WebAssembly, Azure AD B2C and Azure SDKs with Jon Gallant - duration August 11, 2020 - Blazor WebAssembly, Azure AD B2C and Azure SDKs with Jon Gallant.
Blazor Train: Modal Dialogs with Chris Sainty - August 7, 2020 - Carl welcomes Chris Sainty back to BlazorTrain to show Blazored.Modal, his OSS Modal Dialog component.
Live game development - duration August 4, 2020 - Lets focus on the Blazor Game Client, migrating of Module Implementations and Client Asset Builders.
Live game development - duration August 1, 2020 - Migrating old TypeScript Client to a Blazor Client. Now with more BabylonJS Interop API.
Live game development - duration July 31, 2020 - Live game development.
Blazor WebAssembly : Open-source Project - EP10 - duration July 29, 2020 - Let's make the BlazingChat app Open-Source and walk through rest of MVVM code for Contacts and Settings page, by Curious Drive.
Blazor localization content - duration July 24, 2020 - Ed Charbeneau added localization to a Blazor application.
Blazor Train: Creating a Generic Data Manager - duration July 24, 2020 - In this episode of BlazorTrain, Carl welcomes App vNext contractor Mateus de Carvalho. They show how to use the repository pattern to create two generic data managers: one for an in-memory store, and one for an Entity Framework dbContext.
Blazor Server with Azure AD authentication and MS Graph - duration July 24, 2020 - For this week's stream, we decided to play with the latest hot topic in the .NET ecosystem, i.e Blazor. JP and me build a Blazor Server web app with .NET Core and then we add Azure AD authentication to enable users to login in the app with the new Microsoft.Identity.Web. In the end, we added a call to MS Graph to retrieve some messages. video on YouTube. video on Twitch.
GameDev - Blazor with BabylonJS (Web Rendering) - duration July 23, 2020 - GameDev - Blazor with BabylonJS (Web Rendering).
Blazor with BabylonJS (Web Rendering) Source Code Generation - duration July 21, 2020 - GameDev - Blazor with BabylonJS (Web Rendering) Source Code Generation.
Carl Franklin's Blazor Train: Creating an API Layer - duration July 20, 2020 - Carl shows you how to create APIs and access them from Blazor applications. Topics include CORS, and advanced JSON issues.
Visual Studio Remote Office Hours - Blazor and ASP.NET - duration July 16, 2020 - Visual Studio Remote Office Hours - Blazor and ASP.NET, with Daniel Roth and Mads Kristensen. What is Blazor and what should I use it for? Dan Roth is here with answers and insights to share.
Common Data Services (CDS) and .NET - duration July 16, 2020 - From console to mobile to web apps to services, learn how to use the Common Data Service when building .NET apps. This will be a demo heavy session that include Azure Functions, using it in mobile apps written in Xamarin, and web apps written with Blazor.
.NET Virtual User Group - Blazor + Xamarin Code Sharing - duration July 15, 2020 - In this session Lachlan will be focusing on an approach to allow Models, ViewModels and Services to be shared across a Xamarin Forms App(for Android, iOS, UWP, etc.) and Blazor Web Assembly, with just a thin layer on top for user interface and platform specifics in each UI Framework.
Blazor Wasm Localization and Globalization - duration July 10, 2020 - Blazor Wasm Localization and Globalization, by Ed Charbeneau.
An accessibility audit of .NET Blazor with Chris DeMars - duration July 9, 2020 - An accessibility audit of .NET Blazor with Chris DeMars, on The .NET Docs Show.
Blazor & Electron.NET Managing Application Windows - duration July 9, 2020 - This video covers how to create a new windows and manage the window properties, retrieve windows and set the full screen mode.
FAST Framework - duration July 7, 2020 - ASP.NET Community Standup: FAST Framework. Check out how to use the new FAST Web Components with .NET and Blazor. Guests: Daniel Roth, Steve Sanderson and Rob Eisenberg.
Blazor WebAssembly : Using HttpClient in MVVM - duration July 6, 2020 - Blazor WebAssembly : Using HttpClient in MVVM, by Curious Drive. This video is about how to use IHttpClientFactory in a Blazor WebAssembly application.
Blazor WebAssembly : Dependency Injection - duration July 3, 2020 - Blazor WebAssembly : Dependency Injection, by Curious Drive.
Blazor Web Bluetooth - duration July 1, 2020 - In this video Jimmy Engström demonstratres how to use Blazor and web bluetooth to controls a bluetooth robot.
Blazor Train: Blazor Component Life Cycle - duration June 26, 2020 - Blazor Train: Blazor Component Life Cycle. What is a Blazor Component? How long does it live? How can we hook it to make sure our app behaves properly? This episode of Blazor Train covers all about the component life cycle.
Blazing into Summer with Ed Charbeneau - duration June 25, 2020 - Blazing into Summer with Ed Charbeneau, by The DOT.NET Docs Show.
GameDev - Blazor with BabylonJS (Web Rendering) - duration June 25, 2020 - Live development of a game with Blazor WebAssembly and BabylonJS.
ASP.NET Community Standup: Entity Framework Core in Blazor - duration June 24, 2020 - ASP.NET Community Standup: EF Core in Blazor.
ASP.NET Community Standup: Blazor Mobile Bindings - duration June 23, 2020 - ASP.NET Community Standup: Blazor Mobile Bindings, with Eilon Lipton.
State of .NET Blazor with Markus Egger - duration June 23, 2020 - State of .NET Blazor with Markus Egger.
Blazor Day 2020: Building a PWA (Progressive Web App) with Blazor WebAssembly - duration June 18, 2020 - Building a PWA (Progressive Web App) with Blazor WebAssembly, by Vivien Fabing at Blazor Day 2020.
Blazor Day 2020: Getting started with Blazor and Clean Code principles - duration June 18, 2020 - Getting started with Blazor and Clean Code principles, by Bruno Barrette at Blazor Day 2020.
Blazor Day 2020: Authentication and Authorization in Blazor - duration June 18, 2020 - Authentication and Authorization in Blazor, by Marco De Sanctis at Blazor Day 2020.
Blazor Day 2020: Building Desktop Apps for Windows, Mac & Linux with Blazor & Electron - duration June 18, 2020 - Building Desktop Apps for Windows, Mac & Linux with Blazor & Electron, by Ahmad Mozaffar at Blazor Day 2020.
Blazor Day 2020: Create a cross-platform application with Blazor & BlazorMobile - duration June 18, 2020 - Create a cross-platform application with Blazor & BlazorMobile, by Guillaume Zahra at Blazor Day 2020.
Blazor Day 2020: Forms & Validation in Blazor - duration June 18, 2020 - Forms & Validation in Blazor, by Chris Sainty at Blazor Day 2020.
Blazor Day 2020: Razor: Into the Razor-Verse - duration June 18, 2020 - Razor: Into the Razor-Verse, by Ed Charbeneau at Blazor Day 2020.
Blazor Day 2020: Create An Optical Character Reader Using Blazor And Azure Computer Vision - duration June 18, 2020 - Create An Optical Character Reader Using Blazor And Azure Computer Vision, by Ankit Sharma at Blazor Day 2020.
Blazor Day 2020: Secrets of a Blazor Component Artisan - duration June 18, 2020 - Secrets of a Blazor Component Artisan, by Ed Charbeneau at Blazor Day 2020.
Blazor Day 2020: Bringing .NET to the Web and Beyond - duration June 18, 2020 - Blazor: Bringing .NET to the Web and Beyond, by Dan Roth at Blazor Day 2020.
Modern Web UI with Blazor WebAssembly - duration June 11, 2020 - Modern Web UI with Blazor WebAssembly by Steve Sanderson at the NDC Oslo 2020. Client-side web development has long been the sole domain of JavaScript. WebAssembly is changing that by opening up the web to the full ecosystem of languages, frameworks, and tools. ASP.NET Blazor is all about building modern web applications be that on the server or the client. In this session I'll show you how to build beautiful and interactive client-side web UI, all with C# instead of JavaScript.
Blazor Chat Guided Tour - duration June 11, 2020 - This video demonstrates using a singleton class, shows the ValidationComponent and ProgressBar that are part of DataJuggler.Blazor.Components.
Blazor WebAssembly : Entity Framework Core - EP06 - duration June 10, 2020 - Blazor WebAssembly : Entity Framework Core - EP06, by Curious Drive. In this episode, he shows how you can integrate Entity Framework Core in a Blazor WebAssembly application.
Blazor Twitch Bot Examples for GitHub - duration June 9, 2020 - Blazor Twitch Bot Examples for GitHub. Source code stars last commit.
Blazor WebAssembly : Debugging in VS Code, Chrome and Visual Studio - duration June 5, 2020 - Blazor WebAssembly : Debugging in VS Code, Chrome and Visual Studio, by Curious Drive. In this episode, he shows how you can debug your Blazor WebAssembly application using VS Code, Chrome or Visual Studio. He goes through all the files and the settings that you need to do before you debug your apps.
Blazor Beyond the Browser - June 3, 2020 - Blazor Beyond the Browser, with Ed Charbeneau and Daniel Roth.
Blazor In-Depth: Full-Stack C# with Telerik UI for Blazor and Entity Framework - duration June 2, 2020 - Blazor In-Depth: Full-Stack C# with Telerik UI for Blazor and Entity Framework.
Blazor: A Guided Tour with Ed Charbeneau - June 1, 2020 - Blazor: A Guided Tour with Ed Charbeneau. Part 1, Part 2, Part 3.
Blazor WebAssembly : Routing | NavigationManager, AdditionalAssemblies - duration May 31, 2020 - Blazor WebAssembly : Routing | NavigationManager, AdditionalAssemblies, by Curious Drive. In this episode, he shows how navigate between pages in Blazor WebAssembly. He also talks about passing parameters across pages. In the end, he dives diving little deeper to show how you can add Razor Component assemblies to your Router navigate to pages which are into Third Party Components.
Blazor, Menus, the conclusion of May is for Macs with some !coffee - duration May 31, 2020 - Blazor, Menus, the conclusion of May is for Macs with some !coffee.
Working with Pages and Components - duration May 30, 2020 - Working with Pages and Components, by Ed Charbeneau.
Learn Studio Session: Build a WebAssembly app with Blazor & VS Code - duration May 27, 2020 - Join us for this guided online Microsoft Learn workshop. Learn how to setup your development environment and build your first WebAssembly app with Blazor, VS Code and C#.
Learn Studio Session: Build a WebAssembly app with Blazor & VS Code - duration May 27, 2020 - Join us for this guided online Microsoft Learn workshop. Learn how to setup your development environment and build your first WebAssembly app with Blazor, VS Code and C#.
Modern Web UI with Blazor WebAssembly - duration May 26, 2020 - Modern web development is here with Blazor! Be productive building beautiful interactive UI with .NET and C# that runs on any device via WebAssembly. PWAs, authentication, debugging, +more.
Blazor WebAssembly 3.2 Release Party! - duration May 26, 2020 - ASP.NET Community Standup - Blazor WebAssembly 3.2 Release Party!
Blazor Train: A talk with Steve Sanderson and David Fowler - duration May 26, 2020 - Blazor Train, episode 5: In this episode Carl talks to the creators of Blazor, Steve Sanderson and David Fowler.
Blazor Train: Synchronicity - Develop Server and WASM Apps Simultaneously - duration May 26, 2020 - Blazor Train, episode 4: On this episode of Blazor Train I’ll show you how you can develop a Blazor WASM app AND a Blazor SERVER app -- at the same time -- from a single code base, and why you’d want to do that in the first place.
Blazor Train: WebAssembly - duration May 26, 2020 - Blazor Train, episode 3: On this episode of Blazor Train, we’ll dive into WebAssembly. What is it? Is it secure? How does it work? What browsers support it? What languages can compile to it? Can it only run in the browser? And we’ll answer the question: Is Blazor Wasm the next Silverlight?
Blazor Train: Server vs WASM - duration May 26, 2020 - Blazor Train, episode 2: Server vs WASM, by Carl Franklin. In this episode of Blazor Train, he compares the two hosting models: Blazor Server and Blazor WebAssembly. He creates an app using each model, and watch the network traffic in the browser. He talks about the maximum number of concurrent clients a Blazor Server app can handle, and how to scale it to meet demands. Most importantly, he weighs the pros and cons of each hosting model, so you can start thinking about which is appropriate for your next application.
Blazor Train: Introducing Blazor - duration May 26, 2020 - Blazor Train, episode 1: Introducing Blazor, by Carl Franklin. In this episode of Blazor Train, he takes a first look at Microsoft Blazor - its history, how it evolved as a product and became part of ASP.NET Core. He looks at how the Blazor component model simplifies common tasks like binding and event handling. He writes a simple demo to illustrate the power of Blazor and how it will make you a more productive web developer.
Blazor WebAssembly : Project Structure/Template - duration May 25, 2020 - Blazor WebAssembly : Project Structure/Template, by Curious Drive. In this episode, he's going through the project structure for Blazor WebAssembly applications. Why do need we need Client, Server and Shared project when we get started. How you can run them separately? all sort of questions he have answered in this video.
Modern Web UI with Blazor WebAssembly - duration May 25, 2020 - Modern web development is here with Blazor! Be productive building beautiful interactive UI with .NET and C# that runs on any device via WebAssembly. PWAs, authentication, debugging, +more.
Office hours, building a full stack Blazor app - duration May 23, 2020 - Office hours, building a full stack Blazor app, by Ed Charbeneau.
Modern Web UI with Blazor WebAssembly - duration May 19, 2020 - Modern web development is here with Blazor! Be productive building beautiful interactive UI with .NET and C# that runs on any device via WebAssembly. PWAs, authentication, debugging and more. Video by Steve Sanderson from Microsoft.
Blazor WASM authentication - duration May 8, 2020 - Blazor WASM authentication, by Ed Charbeneau.
Blazor Tutorial : Deploy to Azure App Services - May 5, 2020 - Blazor Tutorial : Deploy to Azure App Services, by Curious Drive.
Blazor StateHasChanged: E-book samples, code-behind, and office hours - May 1, 2020 - Blazor StateHasChanged: E-book samples, code-behind, and office hours.
Trains.NET - Lets pretend to be designers - April 22, 2020 - Building a 2D game with .NET and C#, let's draw things with Blazor. Trains.NET's Source code.
Trains.NET - From SkiaSharp to HTML Canvas, and hopefully published to a website somewhere - April 15, 2020 - Building a 2D game with .NET and C#, let's draw things with Blazor. Trains.NET's Source code.
Trains.NET - Let's draw things with Blazor - April 10, 2020 - Building a 2D game with .NET and C#, let's draw things with Blazor. Trains.NET's Source code.
Trains.NET - Experimenting with Blazor - April 8, 2020 - Building a 2D game with .NET and C#, experimenting with Blazor. Trains.NET's Source code.
Carl Franklin's Blazor Desk Show with Dan Roth - duration March 26, 2020 - Video of Carl Franklin (from .NET Rocks!) about architecture best practices, how to make and consume generic components, how to call JavaScript to enhance your apps, and how to implement authentication and authorization. This video also covers how to monitor the traffic going back and forth between the browser and the server, measure your app's memory footprint, and how to optimize it. It also introduces some exciting Blazor controls including a data grid and appointment scheduling component.
Quarantined Coding! with Ed Charbeneau - March 26, 2020 - Ed Charbeneau about Blazor for CodeItLive.
Create a Blazor Server App and Add Syncfusion Blazor Components - March 24, 2020 - Learn to create a new Blazor Server App and add Blazor Components of Syncfusion to it using Visual Studio 2019 and Visual Studio Code.
Minimal March - Linux and Blazor. PRs, Finishing the FormView, C#, HTML, and !coffee - March 22, 2020 - Minimal March - Linux and Blazor. PRs, Finishing the FormView, C#, HTML, and !coffee, by Csharpfritz.
Blazor StateHasChanged: Hot take on hot questions - March 20, 2020 - Blazor StateHasChanged: Hot take on hot questions, by Ed Charbeneau.
Minimal March - Linux and Blazor. PRs, Finishing the FormView, C#, HTML, and !coffee - March 20, 2020 - Minimal March - Linux and Blazor. PRs, Finishing the FormView, C#, HTML, and !coffee, by Csharpfritz.
Minimal March - Linux and Blazor. PRs, Finishing the FormView, C#, HTML, and !coffee - March 19, 2020 - Minimal March - Linux and Blazor. PRs, Finishing the FormView, C#, HTML, and !coffee, by Csharpfritz.
Minimal March - Linux and Blazor. PRs, Finishing the FormView, C#, HTML, and !coffee - March 18, 2020 - Minimal March - Linux and Blazor. PRs, Finishing the FormView, C#, HTML, and !coffee, by Csharpfritz.
Building Chat App using Blazor WebAssembly - March 6, 2020 - Building Chat App using Blazor WebAssembly, day 10 by Curious Drive.
Blazor Tutorial : Event Handling - duration March 4, 2020 - Episode about event handling by Curious Drive.
Build your first Blazor app with Carl Franklin - duration March 3, 2020 - Build your first Blazor app with Carl Franklin, by DevExpress.
Archives - 2020, 2019, 2018, 2017.
Articles
ASP.NET Core updates in .NET 6 Preview 3 - April 8, 2021 - .NET 6 Preview 3 is now available and includes many great new improvements to ASP.NET Core.
Excluding Files from PWA Asset Cache - March 24, 2021 - This article shows how to exclude a files from the Progressive Web Application asset cache.
AWS Previews Deployment Tool for .NET Web Apps, Blazor WebAssembly - March 19, 2021 - Amazon Web Services (AWS) announced a developer preview to ease the process of deploying .NET web apps on the cloud platform, which has become more complex with the advent of tech like Docker and serverless joining the ever-growing .NET ecosystem.
Display a Docker Build Version - March 19, 2021 - This article shows one way to show the Build or Application version, passing it down through a Docker build.
The path to .NET 5 and Blazor WebAssembly with some fun sprinkled in - March 17, 2021 - The path to .NET 5 and Blazor WebAssembly with some fun sprinkled in.
.NET 5 Blazor Powers 'Rock, Paper, Scissors, Lizard, Spock' Game - March 17, 2021 - .NET 5 Blazor Powers 'Rock, Paper, Scissors, Lizard, Spock' Game. Source code stars last commit.
.NET 6 Preview 2 Boosts Razor/Blazor in ASP.NET Core - March 12, 2021 - Razor and Blazor received some dev attention in the second preview of Microsoft's .NET 6 landmark release, coming in November to wrap up formerly disparate .NET components into one cross-platform, open source framework for just about any kind of application.
ASP.NET Core updates in .NET 6 Preview 2 - March 11, 2021 - .NET 6 Preview 2 is now available and includes many great new improvements to ASP.NET Core.
Securing Blazor Web Assembly using cookies - March 8, 2021 - Securing Blazor Web Assembly using cookies. Source code stars last commit.
ASP.NET Core docs: What's new for February 1, 2021 - February 28, 2021 - March 3, 2021 - Welcome to what's new in the ASP.NET Core docs from February 1, 2021 through February 28, 2021. This article lists some of the major changes to docs during this period.
Razor Pages has Components too don't you know - March 2, 2021 - Razor Pages has Components too don't you know.
Blazor hosting models - mind map - February 26, 2021 - Blazor hosting models - mind map update after .NET 6 preview 1 announcement by Konrad Kokosa on Twitter.
Blazor Layout Components - February 22, 2021 - Blazor Layout Components, by Ed Charbeneau.
ASP.NET Core updates in .NET 6 Preview 1 - February 17, 2021 - ASP.NET Core updates in .NET 6 Preview 1.
Announcing .NET 6 Preview 1 - February 17, 2021 - Announcing .NET 6 Preview 1.
Blazor on Desktop - February 17, 2021 - Blazor on Desktop. This article explores how to make Blazor web apps run on Desktop.
Blazor Component Testing - February 16, 2021 - Blazor Component Testing, by Ed Charbeneau.
Blash: Twitter Dashboard Using Blazor Wasm, Web API, SignalR & Twitter API (Part 1) - February 5, 2021 - Blash: Twitter Dashboard Using Blazor Wasm, Web API, SignalR & Twitter API (Part 1), by Round The Code.
.NET 6 Desktop Dev Options: WPF, WinForms, UWP, .NET MAUI, Blazor ... - February 3, 2021 - .NET 6 Desktop Dev Options: WPF, WinForms, UWP, .NET MAUI, Blazor ...
Improvements to the new Razor editor in Visual Studio - January 26, 2021 - Improvements to the new Razor editor in Visual Studio, by Daniel Roth from Microsoft.
Signed HTTP Exchanges: A path for Blazor WebAssembly instant runtime loading - January 26, 2021 - This article explores Signed HTTP Exchanges, which may help when loading the .NET runtime in Blazor WebAssembly apps.
Enabling prerendering for Blazor WebAssembly apps - January 19, 2021 - This post describes the steps to enable server-prerendering for a Blazor WebAssembly application. This post serves as an introduction to some more interesting prerendering approaches I'll be looking at in future posts. Source code stars last commit.
How Blazor performs against other Frameworks - January 18, 2021 - How Blazor performs against other Frameworks, by David Grace for Telerik.
Blackjack in Blazor Part 1 - Rules and Modeling the Game - January 2021, 18 - Blackjack in Blazor Part 1 - Rules and Modeling the Game, on Exception Not Found.
Persisting your users preferences using Blazor and Local Storage - January 14, 2021 - Persisting your users preferences using Blazor and Local Storage.
Microsoft Teams App With Blazor Made Easy Using Blazorade Teams - January 10, 2021 - Microsoft Teams App With Blazor Made Easy Using Blazorade Teams. Source code stars last commit.
How to Use Query Strings in Blazor WebAssembly - January 7, 2021 - In this article, we are going to learn how to use query strings in Blazor WebAssembly. We are going to show you how to send query strings to the Blazor component and also how to read them inside the component. Source code stars last commit.
Displaying lists efficiently in Blazor - January 6, 2021 - Blazor's Virtualize component will let you display long lists faster without writing a lot of code. If you want to take full advantage of the component, however, you'll need a relatively smart repository to back it up.
Introducing Online GZIP de/compressor, built with Blazor WebAssembly - January 1, 2021 - Introducing Online GZIP de/compressor, built with Blazor WebAssembly.
Configure Alexa Skill to use Blazor backend - December 28, 2020 - Configure Alexa Skill to use Blazor backend. Source code stars last commit.
MicroFrontends with Blazor WebAssembly - December 22, 2020 - MicroFrontends with Blazor WebAssembly. Source code stars last commit.
Sitecore Power with ASP.NET Core and why it’s important - December 18, 2020 - Sitecore has recently introduced a development SDK with ASP.NET Core. This article explains why it’s super important for the Business to start thinking about it and how it will change the way of Sitecore development.
10 Blazor Features You Probably Didn't Know - December 15, 2020 - As a relatively new framework, there's probably a lot you don't know about Blazor yet. Here are 10 great features about Blazor you should know.
Exploring Blazor Mobile Bindings - December 13, 2020 - It's time to probe the promise of Blazor Mobile Bindings enticing web developers to come build mobile apps.
Polly and Blazor, Part 1 – Simple Wait and Retry - December 8, 2020 - Polly and Blazor, Part 1 – Simple Wait and Retry.
Blazor WebAssembly (client-side) with AOT and SkiaSharp - December 4, 2020 - Blazor WebAssembly (client-side) with AOT and SkiaSharp, by Uno Platform. Live sample.
How to Pass Arguments to Your onclick Functions in Blazor - December 3, 2020 - It's straightforward to wire up event handlers to HTML events like onClick in your Blazor components, but how can you pass additional information and different types of arguments?
Blazor Updates in .NET 5 - December 1, 2020 - Blazor Updates in .NET 5 by Daniel Roth on Code Magazine.
Developer decries WinForms-to-Blazor performance degradation - December 1, 2020 - Developer decries WinForms-to-Blazor performance degradation, on Visual Studio Magazine.
How to migrate Blazor Webassembly to .NET 5 - November 30, 2020 - How to migrate Blazor Webassembly to .NET 5.
How to Deploy a Blazor Application in Azure App Service - November 30, 2020 - How to Deploy a Blazor Application in Azure App Service.
Blazor JavaScript Isolation, Modules, and Dynamic C# - November 24, 2020 - .NET 5 is here, and with the release comes a barrel of Blazor improvements. One of the upgrades Blazorinos should be most excited about is JavaScript isolation and object references within .NET. This post will describe enhancing the existing Blazor API using extension methods to make importing JavaScript modules clearer. We’ll create a new type that will allow us to write C# code that looks similar to its JavaScript counterparts. Source code stars last commit.
Blazor WASM and Server in a Single Project Running on a Single Site - November 24, 2020 - This article looks at solving the challenges in creating a combined Blazor WASM and Server application - built in the same solution, and run on the same web site.
A Localization sample using Blazor WebAssembly - November 24, 2020 - A Localization sample using Blazor WebAssembly
Custom Validation in Blazor WebAssembly - November 24, 2020 - This article is about custom form validation in Blazor WebAssembly. It shows how to add custom validation attributes and use them for our model objects. Also, it shows how to customize our error messages and how to customize the style of the input elements on the form. Source code stars last commit.
Running a console application directly in your browser - November 22, 2020 - Running a console application directly in your browser. Source code stars last commit.
.NET5 - A Unified Platform - November 20, 2020 - The official version of .NET5 was released last week and bringing huge improvements into the .NET ecosystem. .NET 5 is the next version of .NET Core, and Microsoft continues the journey of unifying the .NET platform.
Library Interop Generator 1.0 Release - November 19, 2020 - The Library Interop Generator stars last commit is quite simple to grasp, you give it a TypeScript definition file and it will create a C# interop library for easier usage with ASP.NET Core Blazor. You can see a working site at Pirate Fort, it includes click action callbacks, animations, pixel system running, and sounds, all triggered from C#.
Step Into .NET 5 with Telerik UI for ASP.NET Core Components - November 18, 2020 - .NET 5 is here, and Telerik UI for ASP.NET Core is fully compatible. Check out what's new in .NET 5 and how you can take advantage today.
Write a WordPress blog with Blazor - November 18, 2020 - Write a WordPress blog with Blazor. Source code stars last commit.
Blazor WebAssembly - Unleash The Power Of Dynamic Template-Based UIs With Razor Engine - November 17, 2020 - In general, you can divide template engines into two types. The relatively simple ones are using template strings with placeholders to be replaced by some concrete values. The other template engines can do everything the simple ones can but additionally provide means for control of the code flow, like if-else statements, loops, and further. In this article, I will focus on the latter by using the Razor engine inside a Blazor WebAssembly application.
Visual Studio 2019 for Mac v8.8 Adds Blazor WebAssembly Debugging - November 16, 2020 - Visual Studio 2019 for Mac v8.8 Adds Blazor WebAssembly Debugging, on Visual Studio Magazine.
Building Real-Time Applications with Blazor Server and Firestore - November 16, 2020 - Building Real-Time Applications with Blazor Server and Firestore. Source code stars last commit.
Blazor and ASP.NET Core Get Faster in .NET 5 - November 12, 2020 - Blazor and ASP.NET Core Get Faster in .NET 5.
Announcing ASP.NET Core in .NET 5 - November 10, 2020 - .NET 5 is now released! .NET 5 is the next version of .NET Core and the future of the .NET platform. With .NET 5 you have everything you need to build rich, interactive front end web UI and powerful backend services. For a full list of everything that’s new in ASP.NET Core in this release, check out the ASP.NET Core in .NET 5 release notes. See also the .NET 5 release notes for additional details and known issues.
Announcing .NET 5.0 - November 10, 2020 - Announcing .NET 5.0, by Microsoft.
Blazor Stability Testing Tools for Bulletproof Applications - November 9, 2020 - Blazor testing may just be the biggest potential upside of the framework. Learn about the core concepts of Blazor testing that will help you make bulletproof apps.
Run Blazor Apps Within Electron Shell - November 5, 2020 - This post covers how to embed Blazor into an Electron app to ship Blazor on the desktop, and how to debug our Electron application using Rider.
Communicating between .NET and JavaScript in Blazor with in-browser samples - November 5, 2020 - The success of Blazor relies heavily upon how well it can integrate with the existing rich JavaScript ecosystem. The way Blazor allows you to integrate, is by enabling you to call JavaScript functions from Blazor and .NET functions from JavaScript. This is also referred to as 'JavaScript interoperability'.
Sending IoT Hub telemetry to a Blazor Web App - November 4, 2020 - Integrate Azure Functions and Blazor Web App using an API Controller. Use it together with IoT Hub routing.
Implement a Blazor full text search using Azure Cognitive Search - November 2, 2020 - This article shows how to implement a full text search in Blazor using Azure Cognitive Search. The search results are returned using paging and the search index can be created, deleted from a Blazor application. Source code stars last commit.
Exploring lighter alternatives to Electron for hosting a Blazor desktop app - November 1, 2020 - Can we get the benefits of Electron for desktop apps built with web technology, with far less resource consumption? By Steve Sanderson.
Unified Blazor UI in the Mobile Blazor Bindings Preview 5 - October 30, 2020 - Unified Blazor UI in the Mobile Blazor Bindings Preview 5.
ARC-8: devlog #2 - Blazor - October 29, 2020 - This article is about how to implement the graphics, sound, input, and log systems for Blazor.
Should your enterprise pick Angular, React or Blazor? - October 27, 2020 - Should your enterprise pick Angular, React or Blazor, by Jon Hilton for Progress Telerik.
Blast Off with Blazor: Get to know Blazor and our project - October 26, 2020 - Building a website from the ground up with no Blazor experience required. All you’ll need is a passing knowledge of C# and .NET. Source code stars last commit.
Is Blazor Safe for Your Enterprise to Bet On? - October 22, 2020 - As with any technology, you’d be foolish not to be concerned about moving your organization to Blazor. Let’s clarify what’s worth worrying about. Also: Why you shouldn’t worry.
Blazor FAST web components - October 22, 2020 - Interfaces built with FAST adapt to your design system and can be used with any modern UI Framework by leveraging industry standard Web Components. Let’s put this to the test using Blazor.
Using NPM Packages in Blazor - October 19, 2020 - Using NPM Packages in Blazor.
Building Real-Time Applications with Blazor Server and Firestore - October 16, 2020 - Building Real-Time Applications with Blazor Server and Firestore.
How to Add gRPC to Your Blazor App - October 14, 2020 - This post reivews how to get started with gRPC within your Blazor apps. We'll start with a basic Blazor WebAssembly app being hosted from an ASP.NET Core server, then modify it to use gRPC.
Combing through ComponentBase - October 14, 2020 - Combing through ComponentBase.
ASP.NET Core updates in .NET 5 Release Candidate 2 - October 13, 2020 - .NET 5 Release Candidate 2 (RC2) is now available and is ready for evaluation. .NET 5 RC2 is a “go live” release, meaning it’s supported in production. This prerelease of .NET 5 is very close to what we expect to ship for the .NET 5 release. Some improvements for Blazor: CSS isolation, component virtualization, support for toggle events, IAsyncDisposable support for components and more!
Blazor Debugging Boosted in .NET 5 RC 2 - October 13, 2020 - Blazor Debugging Boosted in .NET 5 RC 2, on Visual Studio Magazine.
Quick Helper For Blazor Performance - October 13, 2020 - Quick Helper For Blazor Performance.
Render Blazor WASM components in your existing MVC/Razor Pages applications - October 13, 2020 - Render Blazor WASM components in your existing MVC/Razor Pages applications.
Setup Your Blazor Wasm and ASP.NET Core Web API in Azure Devops: Dev To Azure - Part 1 - October 12, 2020 - Setup Your Blazor Wasm and ASP.NET Core Web API in Azure Devops: Dev To Azure - Part 1. Video.
Pushing UI changes from Blazor Server to browser on server raised events - October 12, 2020 - Pushing UI changes from Blazor Server to browser on server raised events. Source code stars last commit.
Printing PDF’s in Blazor - October 11, 2020 - Printing PDF’s in Blazor. Source code stars last commit.
Prerendering your Blazor WASM application with .NET 5 - October 9, 2020 - Prerendering your Blazor WASM application with .NET 5 (part 2 - solving the missing HttpClient problem).
For ASP.NET Core in .NET 6, Devs want AOT Compilation - October 8, 2020 - For ASP.NET Core in .NET 6, Devs want AOT Compilation, on Visual Studio Magazine.
Retrieving Data "As You Need It" with the Telerik UI for Blazor DataGrid - October 6, 2020 - Retrieving Data "As You Need It" with the Telerik UI for Blazor DataGrid.
Building a simple tooltip component for Blazor in under 10 lines of code - October 6, 2020 - Building a simple tooltip component for Blazor in under 10 lines of code. Source code stars last commit.
When does Blazor decide to render your UI? - October 3, 2020 - When does Blazor decide to render your UI?
Render diagrams on the fly in your Blazor apps - October 1, 2020 - Render diagrams on the fly in your Blazor apps.
Creating Real-Time Charts with Blazor WebAssembly and SignalR - September 30, 2020 - Creating Real-Time Charts with Blazor WebAssembly and SignalR.
Blazor Guru Details Best Performance Practices - September 30, 2020 - Blazor Guru Details Best Performance Practices, on Visual Studio Magazine.
Blazor vs. Silverlight: Is Blazor Silverlight 2.0? - September 29, 2020 - Blazor vs. Silverlight: Is Blazor Silverlight 2.0?
Streaming an HTTP response in Blazor WebAssembly - September 28, 2020 - Streaming an HTTP response in Blazor WebAssembly.
How to deploy Blazor WASM & Azure Functions to Azure Static Web Apps - September 24, 2020 - How to deploy Blazor WASM & Azure Functions to Azure Static Web Apps.
Four Micro-Frontend Architecture yypes you can implement with Blazor - September 24, 2020 - Four Micro-Frontend Architecture yypes you can implement with Blazor.
EditForm - forms and validation in Blazor - September 24, 2020 - ASP.Net Core Blazor ships some great components to get building web forms quickly and easily. The EditForm component allows us to manage forms, validations, and form submission events.
Blazor WebAssembly on Azure Static Web Apps - September 23, 2020 - Blazor WebAssembly on Azure Static Web Apps, by Scott Hanselman.
How to call isolated JavaScript code in .NET 5.0 Blazor projects with JSObjectReference - September 23, 2020 - How to call isolated JavaScript code in .NET 5.0 Blazor projects with JSObjectReference. Source code stars last commit.
Azure Static Web Apps with .NET and Blazor - September 22, 2020 - Azure Static Web Apps with .NET and Blazor, on the ASP.NET blog.
Deploy your Blazor app in minutes with Azure Static Web apps - September 22, 2020 - Deploy your Blazor app in minutes with Azure Static Web apps.
Leaving Silverlight: Converting to the Web - September 22, 2020 - If you’re migrating from Silverlight, the latest crop of technologies means that going to the web might be your best choice.
Run EF Core Queries on SQL Server From Blazor WebAssembly - September 20, 2020 - Run EF Core Queries on SQL Server From Blazor WebAssembly. What if I could write a LINQ query on a client the same way I would on a server, and execute it remotely with minimal configuration, setup, ritual and ceremony?
Creating Real-Time Charts with Blazor WebAssembly and SignalR - September 20, 2020 - Creating Real-Time Charts with Blazor WebAssembly and SignalR.
Calling public methods on Blazor component from another component - September 18, 2020 - Calling public methods on Blazor component from another component.
CSS isolation in Blazor - September 16, 2020 - CSS isolation in Blazor.
Making Scott Hanselman's Powerpoint Greenscreen trick work with RevealJS via Blazor Server - September 15, 2020 - Making Scott Hanselman's Powerpoint Greenscreen trick work with RevealJS via Blazor Server. Source code stars last commit.
The First Blazor Dock Manager - September 15, 2020 - This article shows how to use the brand-new Dock Manager component in the Ignite UI for Web Components product. Source code stars last commit.
Architecture of a C# game rendered with Blazor, Xamarin, UWP, WPF, and Winforms - September 15, 2020 - Architecture of a C# game rendered with Blazor, Xamarin, UWP, WPF, and Winforms.
.NET 5 Hits 'Go Live' Status in RC1, Ready for Production - September 15, 2020 - .NET 5 Hits 'Go Live' Status in RC1, Ready for Production.
Blazor Gets Faster (Even Without AOT) - September 14, 2020 - Blazor Gets Faster (Even Without AOT).
ASP.NET Core updates in .NET 5 Release Candidate 1 - September 14, 2020 - ASP.NET Core updates in .NET 5 Release Candidate 1.
Lazy load assemblies in a Blazor WebAssembly application - September 14, 2020 - Lazy load assemblies in a Blazor WebAssembly application.
.NET Blazor for Rails Developers - September 12, 2020 - .NET Blazor for Rails Developers.
WebAssembly Beyond the Browser: Running WASM in .NET Core Applications With WASI & Wasmtime - September 10, 2020 - WebAssembly Beyond the Browser: Running WASM in .NET Core Applications With WASI & Wasmtime. Source code stars last commit.
Blazor.Animate adds support for running animations manually - September 10, 2020 - Blazor.Animate adds support for running animations manually.
Use CSS isolation in your Blazor projects - September 10, 2020 - We talk about scoping your CSS to your Blazor components—all without a stylesheet reference.
Blazor Server CRUD App Using Visual Studio Code - September 9, 2020 - Blazor Server CRUD App Using Visual Studio Code.
Working with Local Storage in a Blazor Progressive Web App - September 9, 2020 - Working with Local Storage in a Blazor Progressive Web App, on Visual Studio Magazine.
Copying text to the clipboard in a Blazor application - September 9, 2020 - Copying text to the clipboard in a Blazor application.
Free e-book: Blazor for ASP.NET Web Forms Developers - September 8, 2020 - We are thrilled to announce the release of our new e-book: Blazor for ASP.NET Web Forms developers. This book caters specifically to ASP.NET Web Forms developers looking for guidelines. As well as strategies for migrating their existing apps to a modern, open-source, and cross-platform web framework. Download PDF.
Anchor navigation in a Blazor application - September 7, 2020 - Anchor navigation in a Blazor application.
Track Gps With Blazor Browserinterop - September 5, 2020 - Track Gps With Blazor Browserinterop. Source code.
Blazor Wasm - Get Access Token for User - September 5, 2020 - In this article Cody shows, using ASP.NET Core Blazor Wasm, a quick snippet to get the AccessToken for a logged in User. Not much to it just using the IAccessTokenProvider, and if the user is signed in and they have are using an authentication type that provides an access token, like OpenID.
Blazor - Page Animated Transitions - September 5, 2020 - This article is about how to use BlazorTransitionableRoute to create an animated transition between Blazor page transitions.
Using a web camera with fun filters in your ASP.NET Core Blazor WebAssembly application - September 4, 2020 - Using a web camera with fun filters in your ASP.NET Core Blazor WebAssembly application. Source code stars last commit.
Blazor Internals you need to know - September 3, 2020 - Blazor Internals you need to know.
Microsoft offers new documentation for Blazor and gRPC in ASP.NET Core - September 3, 2020 - With .NET 5 release candidates on tap ahead of an official November GA debut, Microsoft has published new documentation for some of the hottest ASP.NET Core components, including Blazor and gRPC.
Why Blazor Wasm is the Best Choice for API Integration - August 31, 2020 - Why Blazor Wasm is the Best Choice for API Integration.
.NET 5 Now 'Feature Complete' with Preview 8, Go Live Release Candidates Up Next - August 26, 2020 - .NET 5 Now 'Feature Complete' with Preview 8, Go Live Release Candidates Up Next on Visual Studio Magazine.
Showing a confirm dialog before doing an action in Blazor - August 26, 2020 - Showing a confirm dialog before doing an action in Blazor.
ASP.NET Core updates in .NET 5 Preview 8 - August 25, 2020 - .NET 5 Preview 8 is now available and is ready for evaluation. Here’s what’s new in this release: CSS isolation for Blazor components, Lazy loading in Blazor WebAssembly, Updated Blazor WebAssembly globalization support, New InputRadio Blazor component, Set UI focus in Blazor apps, Influencing the HTML head in Blazor apps, IAsyncDisposable for Blazor components, Control Blazor component instantiation and much more.
Announcing .NET 5.0 Preview 8 - August 25, 2020 - Today, we are releasing .NET 5.0 Preview 8. The .NET 5.0 release is now “feature complete”, meaning that very nearly all features are in their final form (with the exception of bug fixes still to come). Preview 8 is, appropriately, the last preview. We plan on releasing two go-live release candidates before the final .NET 5.0 release in November. This post describes a selection of features across the .NET 5.0 release.
Client/Server Dynamic Scripting - August 25, 2020 - For my new Blazor Game Client I wanted a way to create scripts that could be written by the user of the platform, and automatically load them from Client, without having to pull down a new client or having to reload the client. This article will go over the project I created to show how this might be done.
The .NET Docs Show: Open source .NET projects - August 24, 2020 - In this episode of The .NET Docs Show, Isaac Levin (@isaacrlevin) discusses several of his open source .NET projects. As part of this week's #CheckUp, we share an MS Learn module for building with Microsoft Graph as it related to the PresenceLight project. Video on YouTube.
How to prevent the UI from freezing while executing CPU intensive work in Blazor WebAssembly - August 24, 2020 - How to prevent the UI from freezing while executing CPU intensive work in Blazor WebAssembly.
How to Work With Client-Side Blazor - August 20, 2020 - You’ve probably heard talk of Blazor Wasm, but what is it and how can you use it to rapidly build your web applications?
Blazor WebAssembly - Changing The Log Level At Runtime - August 20, 2020 - Blazor WebAssembly - Changing The Log Level At Runtime.
Dynamically setting the page title in a Blazor application - August 19, 2020 - Dynamically setting the page title in a Blazor application.
Blazor and Media events - Hard to handle? - August 14, 2020 - Blazor and Media events - Hard to handle?
What's New in Blazor Tooling Updates - August 11, 2020 - What's New in Blazor Tooling Updates, on Visual Studio Magazine.
Blazor vs Angular - August 10, 2020 - A comparison of Blazor and Angular when it comes to modern web development—a review of the pros and cons by Telerik.
Online Multiplayer Word Game With Blazor and SignalR on .NetCore - August 8, 2020 - Let's build a simple online multiplayer word game with Blazor using SignalR for realtime communication between two players. All the words will keep in MongoDB and it will supports multi-platforms with .Net Core. Source code stars last commit.
Blazor Components Deep Dive - Lifecycle Is Not Always Straightforward - August 5, 2020 - When starting with new frameworks that have a lifecycle for their artifacts like components, then you may assume that the lifecycle is strictly linear. In other words, step A comes before step B comes before step C, and so on. Usually, this is the case until it is not. The lifecycle of the Blazor components is not an exception in this matter.
Make a responsive Navbar with Blazor and Tailwind? - August 4, 2020 - Make a responsive Navbar with Blazor and Tailwind?
Xamarin Blazor Mobile Button Event Handlers - August 3, 2020 - Using the Blazor programming model to handle button events, like OnClick, makes writing Xamarin mobile applications with form inputs a breeze.
Introducing Plugin Framework 1.0.0 – Plugins for .NET apps including Blazor and ASP.NET Core with built-in support for Nuget - August 3, 2020 - Plugin Framework is a new MIT-licensed plugin platform for .NET Core applications. It is light-weight and easy way to add a plugin-support into your application. It supports all the major types of .NET Core applications, including ASP.NET Core, Blazor, Console Apps and WPF & WinForms.
Creating a Progressive Web App with Blazor WebAssembly - August 3, 2020 - Not surprisingly, it's dead easy to create an app in Blazor that runs outside of the browser window and (potentially) in an offline mode. Before you get carried away, though, there are some key design decisions to make, by Visual Studio Magazine.
Implement the "download file" feature on a Blazor WebAssembly app - August 2, 2020 - If we want to implement the "download file" feature (please imagine a picture that was posted on Facebook can be downloadable) on your Blazor WebAssembly app project, how can we implement that feature? Source code stars last commit.
Run Blazor-based .NET Web applications on AWS Serverless - July 30, 2020 - Run Blazor-based .NET Web applications on AWS Serverless.
Authenticate Blazor WebAssembly with Azure Static Web Apps - July 28, 2020 - Azure Static Web Apps is a great place to host Blazor WebAssembly apps. Among Static Web Apps' many features, it has built-in support for authentication using social logins. In this article, we'll look at how we can take advantage of Static Web Apps Authentication in our Blazor WebAssembly apps. Source code stars last commit.
Role-based security with Blazor and Identity Server 4 - July 28, 2020 - This article covers how to add a role-based security both on the API side and in the UI of a Blazor application. Note: this article is the next part of a previous article. Source code stars last commit.
Project - EventHorizon Blazor Interop - July 28, 2020 - I have been working on a project that will generate a C# Blazor WASM abstraction from a TypeScript definition file, as part of that project I needed a way to run the equivalent functionality in JavaScript. This article will go over that WASM Interop project I created, I also package it up in an easy to use NuGet package if you want to use it as well. Source code stars last commit.
Blazor Interop Generation Tool Release - July 28, 2020 - This article is the Release post of my new Blazor Interop Generation Tool! Here I will do a quick overview of the tool and how to use it. Source code stars last commit.
Project - EventHorizon Blazor TypeScript Interop Generator - July 28, 2020 - This project’s name is a mouthful, but based on the name you should be able to get the gist of what the project does. The project generates a C# Blazor Interop abstraction from the Abstract Syntax Tree from a TypeScript definition file, giving the user a generated project that can make interfacing with JavaScript libraries easier from C#. Source code stars last commit.
Blazor WebAssembly authentication and authorization with IdentityServer4 - July 27, 2020 - This about implementing authentication on a Blazor WebAssembly app via OpenId Connect using IdentityServer4(IDS4). And also authorization on Blazor WebAssembly app. IDS4 is a certified OpenId provider library.
Optimizing JS Interop in a Blazor WebAssembly application - July 27, 2020 - Optimizing JS Interop in a Blazor WebAssembly application.
Blazor WebAssembly Targets .NET 5 in Latest ASP.NET Core Update - July 27, 2020 - In announcing updates to web-focused ASP.NET Core development as part of a new .NET 5 Preview 7, Microsoft noted that Blazor WebAssembly -- the client-side component of the Blazor project that allows for C#-based web development instead of JavaScript -- now targets .NET 5.
Generating and efficiently exporting a file in a Blazor WebAssembly application - July 27, 2020 - Generating and efficiently exporting a file in a Blazor WebAssembly application.
State Management with Blazor using Fluxor (Part 2) - July 26, 2020 - Implementing additional CRUD operations with Fluxor, a continuation of part 1. Source code stars last commit.
Blazor EditForms, an essential tool or too much magic? - July 23, 2020 - Blazor ships with something called an EditForm. But what is it, do you have to use it, and what if you don’t fancy relying on magic to make your application work?
Hybrid Blazor apps in the Mobile Blazor Bindings July update - July 22, 2020 - Mobile Blazor Bindings July update is released, which adds support for building Hybrid Blazor apps, which contain both native and web UI. Documentation. Source code stars last commit.
bUnit for Blazor and How to Integrate it in Azure Pipeline - July 22, 2020 - bUnit for Blazor and How to Integrate it in Azure Pipeline.
ASP.NET Core Updates in .NET 5 Preview 7 - July 21, 2020 - .NET 5 Preview 7 is now available and is ready for evaluation. Here’s what’s new in this release: Blazor WebAssembly apps now target .NET 5, updated debugging requirements for Blazor WebAssembly, Blazor accessibility improvements, Blazor performance improvements and more.
Securing Blazor WebAssembly Apps - July 21, 2020 - Learn how to secure Blazor WebAssembly applications with Auth0. Source code stars last commit.
How to build a Blazor web app with Azure Active Directory authentication and Microsoft Graph - July 21, 2020 - How to build a Blazor web app with Azure Active Directory authentication and Microsoft Graph.
Mobile Blazor Common App Layouts - July 20, 2020 - This tutorial explores different layouts you can use when designing native mobile apps using Blazor and some tricks for how you can customize them to get just the look and feel your customers need.
Blazor: Zero To Hero Real Time Implementation Part III - July 20, 2020 - This is part three of the “Blazor: Zero to Hero” article series. This article has a detailed look at the Project Structure.
SignalR without Javascript, the Promise of Blazor - July 18, 2020 - SignalR has always had one major flaw: to use it, you needed to use JavaScript. But with the dawn of Blazor, this age of compromise is over. We can manage all of the data transfers between our servers and clients straight out of CLR types! Source code stars last commit.
Blazor WebAssembly Forms, Form Validation, and @ref Directive - July 17, 2020 - Blazor WebAssembly Forms, Form Validation, and @ref Directive, by Code Maze. Source code stars last commit. Documentation.
Visual Studio Gets Experimental Razor Editor for Blazor, Other Projects - July 16, 2020 - The latest preview of Visual Studio 2019 16.7 adds an experimental Razor editor for working with Blazor, boosting web development with C#/.NET instead of JavaScript.
New experimental Razor editor for Visual Studio - July 15, 2020 - With the release of Visual Studio 2019 16.7 Preview 4, you can now try out our new experimental Razor editor for local development with MVC, Razor Pages, and Blazor.
Blazor and Dragons: How to consume gRPC-web from Blazor - July 14, 2020 - Blazor and Dragons: how to consume gRPC-web from Blazor.
How to Build a CORS Proxy for Client-side Blazor - July 13, 2020 - How to Build a CORS Proxy for Client-side Blazor.
V-Drum Explorer: Blazor and the Web MIDI API - July 12, 2020 - Blazor and the Web MIDI API, a way of accessing local MIDI devices from a browser. Source code stars last commit. Documentation.
Getting Started with Mobile Blazor Bindings - July 9, 2020 - This is the first in a tutorial series about developing native Android and iOS apps using Xamarin and Blazor. This lesson will help you set up your development environment.
How to send an SMS with Blazor - July 8, 2020 - This article covers how to send an SMS using Blazor and the Vonage SMS API. Source code stars last commit.
Securing a Blazor WebAssembly application with Azure Active Directory - July 7, 2020 - Securing a Blazor WebAssembly application with Azure Active Directory. Source code stars last commit.
Custom validation logic on client AND server with Blazor - July 7, 2020 - Custom validation logic on client AND server with Blazor.
Conway's Game of Life (With Emojis!) in C# and Blazor WebAssembly - July 6, 2020 - Conway's Game of Life (With Emojis!) in C# and Blazor WebAssembly. Code source stars last commit.
The .NET Stacks #6 - July 5, 2020 - A rundown on mobile Blazor bindings, EF updates, ASP.NET Core A-Z, and more.
Understanding about Cascading Values and Cascading Parameters in Blazor - July 4, 2020 - Understanding about Cascading Values and Cascading Parameters in Blazor. Source code stars last commit.
Understanding about Cascading Values and Cascading Parameters in Blazor - July 4, 2020 - Understanding about Cascading Values and Cascading Parameters in Blazor.
Blazor WebAssembly HttpClient – Consuming Web API - July 3, 2020 - This article from Code Maze covers the Blazor WebAssembly HttpClient and how to use it to fetch data from the ASP.NET Core Web API server.
Go faster with your own re-usable Blazor components - June 30, 2020 - Go faster with your own re-usable Blazor components.
Creating a Custom Validation Message Component for Blazor Forms - June 30, 2020 - Creating a Custom Validation Message Component for Blazor Forms, by Chris Sainty.
Blazor Upload File to Azure Blob Storage - June 29, 2020 - Blazor Upload File to Azure Blob Storage, by Bradley Wells.
Deploying a .NET Core Blazor App to Netlify using GitHub Actions - June 29, 2020 - Deploying a .NET Core Blazor App to Netlify using GitHub Actions.
Hosting both Blazor Server and WebAssembly in single website - June 27, 2020 - Hosting both Blazor Server and WebAssembly in single website.
State Management with Blazor using Fluxor - June 26, 2020 - Implementing the flux spec with Fluxor for Blazor applications. Source code stars last commit.
ASP.NET Core updates in .NET 5 Preview 6 - June 25, 2020 - .NET 5 Preview 6 is now available and is ready for evaluation. Here’s what’s new in this release: Blazor WebAssembly template now included, JSON extension methods for HttpRequest and HttpResponse, extension method to allow anonymous access to an endpoint, custom handling of authorization failures and SignalR Hub filters.
Blazor WebAssembly Template Lands in .NET 5 Preview 6 - June 25, 2020 - Blazor WebAssembly Template Lands in .NET 5 Preview 6, by David Ramel on Visual Studio Magazine.
Convert DateTime to user's time zone with server-side Blazor - June 25, 2020 - Convert DateTime to user's time zone with server-side Blazor.
State Management and Error Recovery in Blazor WebAssembly - June 24, 2020 - Centralized state management with serialization in localStorage when application crashes or user leaves the application. Source code.
Learn how you manage routing in Blazor for .NET Core and VS Code - June 24, 2020 - Learn how you manage routing in Blazor for .NET Core and VS Code. on Chris Noring's blog. on Dev.to.
Telerik UI for Blazor 2.15.0 - June 24, 2020 - Telerik UI for Blazor 2.15.0 includes new ButtonGroup, ToggleButton, Grid Updates and more.
Move Over, JSON, Here's gRPC-Web for .NET (& Blazor) - June 23, 2020 - Move Over, JSON, Here's gRPC-Web for .NET (& Blazor) by David Ramel, on Visual Studio Magazine.
3+1 ways to manage state in your Blazor application - June 23, 2020 - 3+1 ways to manage state in your Blazor application.
Partial Classes, RenderFragment and Lifecycle in Blazor WebAssembly - June 22, 2020 - Partial Classes, RenderFragment and Lifecycle in Blazor WebAssembly. Source code stars last commit. This article is part of the Blazor series.
Creating a Repeater component with Blazor - June 22, 2020 - If you are familiar with the old ASP.NET, you know the asp:Repeater control, a control that iterates on a collection (may comes from any kind of DataSource) and use a template to generate the page. This article shows how to create a control like that with Blazor.
Setting the Page Title in a Blazor App - June 22, 2020 - Let's set the page title using a Blazor component and a bit of JavaScript.
Build an Azure AD Secured Blazor Server Line of Business App - June 20, 2020 - Build an Azure AD Secured Blazor Server Line of Business App. Source code stars last commit.
How to utilize gRPC-Web from a Blazor WebAssembly application - June 19, 2020 - How to utilize gRPC-Web from a Blazor WebAssembly application. Source code stars last commit.
7 Things to Enjoy in MAUI - June 19, 2020 - .NET Multi-platform App UI (MAUI) is the next evolution of cross-platform UI solution for .NET developers. Just like the island, MAUI will have plenty to offer for developers. Let's explore the promise of .NET MAUI.
Minesweeper in Blazor WebAssembly Part 2: The Blazor Component - June 18, 2020 - Let's build a Blazor Component so we can play Minesweeper with it.
Hosting Blazor Web Assembly App on Azure Static Web App - June 17, 2020 - Hosting Blazor Web Assembly App on Azure Static Web App.
Minesweeper in Blazor WebAssembly Part 1: C# Implementation - June 15, 2020 - Let's build the computer game Minesweeper using C# and Blazor WebAssembly. Source code stars last commit.
Build a Blazor WebAssembly line of business app part 1: Intro and data access - June 13, 2020 - Build a Blazor WebAssembly line of business app part 1: Intro and data access. Source code stars last commit.
Secure Stripe Checkout with Blazor JSInterop - June 12, 2020 - Secure Stripe Checkout with Blazor JSInterop. Source code stars last commit.
Blazor vs React - June 9, 2020 - A comparison of Blazor and React when it comes to modern web development—a review of the pros and cons.
Blazor UI Components - An Update with New Controls & Features, and Blazor Reports! (available in v20.1) - June 9, 2020 - Blazor UI Components - An Update with New Controls & Features, and Blazor Reports! (available in v20.1).
Avoiding AccessTokenNotAvailableException when using the Blazor WebAssembly Hosted template with individual user accounts - June 9, 2020 - Avoiding AccessTokenNotAvailableException when using the Blazor WebAssembly Hosted template with individual user accounts.
How to detect unsupported browsers under a Blazor WebAssembly application? - June 8, 2020 - How to detect unsupported browsers under a Blazor WebAssembly application?
Blazor vs. React / Angular / Vue.js - June 4, 2020 - Blazor is a new Microsoft technology that allows developers to write code for browsers in C#. This article compares Blazor to three other common SPA frameworks: React, Angular, and Vue.js.
Adding React UI components to Blazor Web Assembly app - June 3, 2020 - Adding React UI components to Blazor Web Assembly app.
Custom connection details display - June 3, 2020 - Custom connection details display.
Blazor How-Tos: create a chat application - part 1: Introduction - June 1, 2020 - Blazor How-Tos: create a chat application - part 1: Introduction. Source code stars last commit.
Archives - 2020, 2019, 2018, 2017.
Podcasts
React, writing a book, and Blazor with Carl Rippon - March 22, 2021 - Coding after work, episode 57: React, writing a book, and Blazor with Carl Rippon. Duration: 35 minutes.
.NET 6 with Daniel Roth - March 11, 2021 - What's next for .NET? Carl and Richard chat with Dan Roth about all the good things coming this November for .NET. The conversation starts out with some discussion around Blazor, which is no longer an experimental project, but now a key part of .NET. Dan talks about the role of MAUI bringing together UI elements for smartphones, tablets, PCs, and more. There's a lot to look forward to by the end of 2021. Duration: 58 minutes.
Blazor Keeps Getting Better with Daniel Roth - March 9, 2021 - .NET 059: Blazor Keeps Getting Better with Daniel Roth. Blazor has come a long way since 2018. Blazor WebAssembly was released in 2020 and Blazor was integrated as a full-fledged member of .NET 5. Daniel Roth joins us to discuss the progress and improvements the Blazor team has made over the last year. We also discuss a number of updates coming in 2021 like the new Razor editor. The future of Blazor is bright, indeed. Duration: 61 minutes.
Blazor in Action with Chris Sainty - January 8, 2021 - Blazor in Action with Chris Sainty in the .NET Core Show, episode 67. Duration: 67 minutes.
.NET 5 with Scott Hunter - December 24, 2020 - .NET 5 is shipped! What happens now? As part of the .BLD() Tech Talks XXL event in the Netherlands, Carl and Richard streamed interviewing Scott Hunter about .NET 5. The conversation turns to how the scope of .NET 5 focused in on how to help projects move from the standard framework onto .NET 5. Scott also dives into the ever-improving performance of .NET, the latest version of Blazor, and the adoption of WinForms in .NET 5 - and what's coming for .NET 6. Duration: 53 minutes.
Building a Flight Simulator in C# with Laura Laban - December 17, 2020 - What does it take to make a flight simulator in C#? On a smartphone? Carl and Richard talk to Laura Laban about her experiences building Infinite Flight - starting with the Windows Phone in 2011! The conversation follows the history of using C# in smartphones, from WinPhone 7 through to MonoTouch, MonoGame, and Xamarin! Laura Laban discusses the challenges of tooling getting deprecated, platforms going away, and the vagaries of app stores. Duration: 54 minutes.
Building a TwitchBot in Blazor with Georgia Nelson - December 10, 2020 - What can you use Blazor for? Carl and Richard talk to Georgia Nelson about GifBot, a Twitch bot Georgia has built using a variety of tools and languages (including Java) and today is C# and Blazor. Georgia talks about evolving the bot from version to version, looking for ways to make it easier for Twitch streamers to use. From WinForms to WPF to Blazor, the UI has taken a few turns, but Blazor works great in the role of user interface. Duration: 55 minutes.
bUnit: A Blazor Testing Lib - December 7, 2020 - bUnit: A Blazor Testing Lib; with Egil Hansen in The 6th Figure Developer podcast, episode 173. Duration: 41 minutes.
Blazor in Action with Chris Sainty - November 17, 2020 - In this episode of expect(Exception) we talk with Chris Sainty, author of the book Blazor in Action. We talk about what Blazor actually is, why we like it and of course, how to test it. Blazor in Action's book.
Merge Conflict: .NET Conf 2020 & Apple M1 Event Recap - November 16, 2020 - Episode 228 of Merge Conflict's podcast: .NET Conf 2020 & Apple M1 Event Recap. This last week was crazy! .NET Conf 2020, .NET 5, Visual Studio 16.8, XAML Hot Reload 2.0, Xbox Series S/X launch, Apple M1 Events, and so much more. Duration: 62 minutes.
Oqtane and OSS with Shaun Walker - November 2, 2020 - Shaun Walker is the original creator of Oqtane and DotNetNuke, web application frameworks which have the earned the recognition of being among the largest, most successful, pioneering Open Source projects native to the Microsoft platform. He was recognized by Business In Vancouver in 2011 as a leading entrepreneur in their Forty Under 40 business awards, and is currently the Chair of the Project Committee for the .NET Foundation. Shaun is currently a Technical Director and Enterprise Guildmaster at Cognizant Softvision. Shaun joined The 6 Figure Developer to talk about his newest project, Oqtane, a Modular Application Framework for Blazor, as well as Open Source Software, and The .NET Foundation. Duration: 44 minutes.
The One About Blazor - September 7, 2020 - Merge conflict, episode 218: The One About Blazor. Duration: 49 minutes.
OpenSilver with Giovanni Albani - July 30, 2020 - OpenSilver with Giovanni Albani, on .NET Rocks. Got Silverlight apps? Carl and Richard talk to Giovanni Albani about the OpenSilver project - building an open-source version of Silverlight that runs without a plugin, using WebAssembly. Giovanni talks about companies he has communicate with that have Silverlight apps with hundreds of thousands of lines of code - not a simple thing to rewrite. The goal of OpenSilver is to let you migrate those applications.
.NET Multi-Platform App UI with Scott Hunter - Ready to go to Maui? Carl and Richard talk to Scott Hunter about the .NET Multi-Platform App UI or MAUI for short. Scott talks about how the next versions of .NET are focused on unifying the elements that go into .NET to make One .NET. And that includes the UI stacks - including Xamarin! The evolution of Xamarin into .NET means that all UI stacks will be treated equally. And that leads to the .NET Multi-Platform App UI, letting you make a single project that covers Windows, OS/X, iOS and Android.
Testing Blazor Apps with Egil Hansen - June 4, 2020 - Testing Blazor Apps with Egil Hansen, on .NET Rocks. How do you test your Blazor app? Carl Franklin and Richard Campbell talk to Egil Hansen about bUnit stars last commit, an open-source testing framework designed to work with Blazor - both the server-side Razor components and the WebAssembly client. Egil talks about building bUnit to allow for robust testing, that is, tolerant to the normal changes that come to an application without breaking all the tests. The conversation also turns to growing the bUnit project with more contributors, a wider set of features, and perhaps being part of the .NET Foundation.
Michael Washington on the State of Blazor - May 11, 2020 - In this episode of Azure DevOps Podcast, Jeffrey Palermo is speaking with Michael Washington about Blazor in-depth. They discuss the current state of Blazor; Oqtane, a modular application framework for Blazor; server-side Blazor apps; Radzen, a low-code, RAD solution; his books on the topic of Blazor; and his advice, tips, recommendations, and resources for Blazor as well.
Blazor with guest Carl Franklin - March 9, 2020 - Carl Franklin is the guest to Weekly Dev Tips. Carl Franklin and Steve Smith (aka Ardalis) discuss Blazor in general and look at how to create a generic object picker control for Blazor.
Podcast: Occam’s Blazor - January 14, 2020 - Podcast by Stack Overflow.
Archives - 2019, 2018, 2017.
Presentations slides
Using .NET 5 with the Raspberry Pi - January 28, 2021 - Using .NET 5 with the Raspberry Pi, on Slideshare.
Focus on Blazor - January 2020 - All the materials of the .NET Conf "Focus on Blazor". The videos are on YouTube.
Blazor, a new framework for browser-based .NET apps - January 29, 2020 - Source code of the session by Steve Sanderson at the NDC London, "Blazor, a new framework for browser-based .NET apps".
Blazor in more depth - January 28, 2020 - Blazor in more depth by Steve Sanderson and Ryan Nowak at the NDC London 2020. Presentation of Steve Sanderson. Presentation of Ryan Nowak.
Authoring custom components - .NET Conf "Focus on Blazor" - January 14, 2020 - Slides and demo of the presentation by Ed Charbeneau at the .NET Conf "Focus on Blazor".
Routing A-Z - .NET Conf "Focus on Blazor" - January 14, 2020 - Slides and demo of the presentation by Chris Sainty at the .NET Conf "Focus on Blazor" about routing.
Archives - 2019, 2018.
Tooling
Blazor Dev Server with CSS Live Reloader - stars last commit Alternative Blazor Dev Server to be available CSS live reloading.
LiveSharp - stars last commit Update .razor files and see the updates instantly without reloading the page. Your application state is preserved because there is no need to reload anything. livesharp.net.
BlazorFiddle - Blazor .Net Developer Playground and Code Editor in the Browser.
Blazor Minimum Project Templates - GitHub stars GitHub last commit A project templates package of Blazor apps without JavaScript and CSS libraries.
Blazor REPL - GitHub stars GitHub last commit Write, compile, execute and share Blazor components entirely in the browser - https://blazorrepl.com.
Blazor Snippets Visual Studio Code extension - A Visual Studio Code extension that offers Blazor and Razor snippets.
BlazorSourceMangler - GitHub stars GitHub last commit A console app to mangle Blazor DLLs. Check this YouTube video for more details. You can also check this Blazor TODO app to see result of this app (downloaded blazortodos.dll is mangled and decompilation shows uglyfied code).
WebCompiler - GitHub stars GitHub last commit A dotnet global tool for compilation, minification, and compression of scss, css and js.
.NET Core - .NET Core.
Razor+ Visual Studio Code extension - A Visual Studio Code extension that offers improved Razor support.
Tracetool - GitHub stars GitHub last commit Tracetool viewer, client Api for Dotnet, Java, Javasvript, C++ , Python, Delphi.
Visual Studio - Latest preview of Visual Studio.
Visual Studio Code - Visual Studio Code, free, open source and cross-platform code editor.
Books
Blazor Revealed - Blazor Revealed, Building Web Applications in .NET(Published February, 2019).
Blazor Quick Start Guide: Build web applications using Blazor, EF Core, and SQL Server - Blazor Quick Start Guide: Build web applications using Blazor, EF Core, and SQL Server (Published October 31, 2018).
E-Books
Blazor WebAssembly Succinctly - August 31, 2020 - Blazor is a framework for creating SPA webpages with either client-side or server-side architectures, using Razor technology written with the C# language. Because client-side Blazor with WebAssembly executes entirely on a user's browser, it’s very fast for many applications. In Blazor WebAssembly Succinctly, Michael Washington will take readers through the core elements of Blazor and then explore additional features by building a sample application. Free e-book.
Blazor Succinctly - April 16, 2020 - A free e-book for starting with the Blazor framework.
Blazor, A Beginners Guide - March 18, 2020 - A free e-book for getting started with the Blazor framework. Examples source code.
Blazor for ASP.NET Web Forms developers - Blazor for ASP.NET Web Forms developers, a free e-book from Microsoft.
Using CSLA 5: Blazor and WebAssembly - This book covers the new Blazor UI framework, including how to create server-side and client-side WebAssembly projects, how to implement authentication and authorization, and how to use data binding. It then covers how CSLA .NET supports Blazor, including walking through a complete sample app.
An Introduction to Building Applications with Blazor - August 24, 2019 - An Introduction to Building Applications with Blazor: How to get started creating applications using this exciting easy to use Microsoft C# framework
Archives - 2018.
Courses
Build a web app with Blazor WebAssembly and Visual Studio Code - Build a web app with Blazor WebAssembly and Visual Studio Code, on Microsoft Learn.
DevOps and Docker Support for .NET Core Blazor Applications - June 2020 - DevOps and Docker Support for .NET Core Blazor Applications, on Udemy. This Docker Support Course with DevOps concepts using ASP.NET Core Blazor will teach you Dockerisation of Blazor Apps.
Programming in Blazor - ASP.NET Core 3.1 - Create interactive web applications with C#, on Udemy.
Creating Blazor Components - December, 2019 - Building a Blazor app is building components. This course is essential for gaining a good understanding of components. On Pluralsight.
Authentication and Authorization in Blazor Applications - December, 2019 - Learn how to secure your Blazor application using a variety of best practice techniques for authentication and authorization. On Pluralsight.
Blazor: Getting Started - December, 2019 - Learn how to build your first application in a hands-on way using Blazor, Microsoft's solution to use C# to write interactive web UIs without JavaScript. On Pluralsight.
Blazor In-Depth Workshop (Blaze Invaders) - December 2019 - Blazor In-Depth Workshop (Blaze Invaders), on C# Academy. Learn serious Blazor concepts while building a working browser based game.
Blazor and Razor Components in a nutshell - October 2019 - Learn how to use a framework that allows you to run your compiled code directly in the browser on top of WebAssembly, a course on Udemy.
Blazor on ASP.NET Core 3.0 - October 2019 - Blazor on ASP.NET Core 3.0, a course on SkillShare.
Blazor First Look on LinkedIn Learning - Blazor First Look on LinkedIn Learning. Source code GitHub stars.
Free Blazor Training Course - DevExpress Blazor free training course Source code GitHub stars.
Community
Awesome Blazor on Twitter - This repository's Twitter feed.
Gitter - Blazor discussion on Gitter.
Learn Blazor - Community documentation on Blazor.
Blazor Help Website - Blogs and code samples primarily covering server-side Blazor.
Practical samples of Blazor - Practical samples of Blazor.
Practical samples of Blazor Server-Side - Practical samples of Blazor Server-Side.
Stack Overflow - Blazor questions feed on Stack Overflow.
Twitter - Hashtag on Twitter.
WebAssemblyMan - Man page for Blazor and WebAssembly.
Other Languages
Blaze of Code - [Portuguese] Blog about Blazor.
Blazor.ru - [Russian] Old official documentation website translated in Russian.
DevApps.be's podcast #44 - [French] DevApps.be's podcast #44: "Blazor et WebAssembly vont-ils tuer JavaScript ?".
DevApps.be's podcast #47 - [French] DevApps.be's podcast #47: "Actualités : TypeScript, Uno, Angular, DocFX, Database".
Modern web apps with Blazor - [Italian] Video about Blazor.
Playlist - Programando en Blazor - [Spanish] Series of videos about Blazor.
Insights from the oracle - [German] Blog about Blazor.
License
CC0

