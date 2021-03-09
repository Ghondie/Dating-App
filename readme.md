<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->

[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- [![Contributors][contributors-shield]][contributors-url] -->
<!-- [![MIT License][license-shield]][license-url] -->
<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/Ghondie/Dating-App">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Dating App</h3>

  <p align="center">
    The 
    <br />
    <a href="https://github.com/Ghondie/Dating-App"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/Ghondie/Dating-App">View Demo</a>
    ·
    <a href="https://github.com/Ghondie/Dating-App/issues">Report Bug</a>
    ·
    <a href="https://github.com/Ghondie/Dating-App/issues">Request Feature</a>
  </p>
</p>

<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->

## About The Project

[![Product Name Screen Shot][product-screenshot]](https://example.com)

For this project I decited to make a dating app. Below you will find how the front end and back end is set up. This project was made using Dotnet, C#, and Angular.

<!-- All backend info needs to go here -->

## Backend

Controllers:
Set up multiple controllers to handle users, Accounts, Error handling controller.

DTO:
Set up DTO's to improve load times and break up the code into a more re-usable format.

Repository:
Set up a Repository for a DRY code enviroment, and easier testing.

AutoMapper: Adding a layer of obstraction for better unit testing. Set up with querable extentions to return data in a presentable format.

<!-- All Front end needs to go here -->

## Front end

User Authication:
Password hashing and Password salting Password registration to the DB JasonWeb Tokens.

Error Handling,
To accomplish my goal I used Toasts to desplay bad username, passwords. I also set up Toasts for 400, 400 Validation, 401, 404, and 500 errors. The 404 error routes you to a return to home page.

<!-- All of the services that I used -->

### Built With

Below is most of the framework/extentions I used.

-   [Angular Bootstrap](https://valor-software.com/ngx-bootstrap/#/)
-   [Dotnet](https://dotnet.microsoft.com/)
-   [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
-   [AutoMapper](https://automapper.org/)
-   [DTO](https://en.wikipedia.org/wiki/Data_transfer_object)
-   [Services](https://docs.microsoft.com/en-us/dotnet/api/system.web.services.description.service?view=netframework-4.8)
-   [Angular](https://angular.io/)
-   [SQLite](https://www.sqlite.org/index.html)
-   [Type Script](https://www.typescriptlang.org/)
-   [Node](https://www.npmjs.com/)
    -   [CORS](https://www.npmjs.com/package/cors)
    -   [Toastr](https://www.npmjs.com/package/ngx-toastr)
-   [JSON WebToken](https://jwt.io/)

<!-- GETTING STARTED -->

## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.

-   npm
    ```sh
    npm install npm@latest -g
    ```

### Installation

1. Clone the repo
    ```sh
    git clone https://github.com/your_username_/Project-Name.git
    ```
2. Install NPM packages
    ```sh
    npm install
    ```

<!-- USAGE EXAMPLES -->

## Usage

Use this space to show useful examples of how a project can be used. Additional screenshots, code examples and demos work well in this space. You may also link to more resources.

_For more examples, please refer to the [Documentation](https://example.com)_

<!-- ROADMAP -->

## Roadmap

See the [open issues](https://github.com/Ghondie/Dating-App/issues) for a list of proposed features (and known issues).

<!-- CONTRIBUTING -->

## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<!-- LICENSE -->

## License

Distributed under the MIT License. See `LICENSE` for more information.

<!-- CONTACT -->

## Contact

Jared Schau- [LinkedIn](https://www.linkedin.com/in/jared-schau-a2a56361/) - Jared.M.Schau@gmail.com

Project Link: [https://github.com/Ghondie/Dating-App](https://github.com/Ghondie/Dating-App)

<!-- ACKNOWLEDGEMENTS -->

## Acknowledgements

-   [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
-   [Img Shields](https://shields.io)
-   [Udemy](https://www.udemy.com/course/build-an-app-with-aspnet-core-and-angular-from-scratch/)
-   [Font Awesome](https://fontawesome.com)
-   [Readme Template](https://github.com/othneildrew/Best-README-Template/blob/master/README.md)
-   [Bootswatch](https://bootswatch.com/journal/)
-   [Json-generator](https://www.json-generator.com/)

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[forks-shield]: https://img.shields.io/github/forks/Ghondie/Dating-App.svg?style=for-the-badge
[forks-url]: https://github.com/Ghondie/Dating-App/network/members
[stars-shield]: https://img.shields.io/github/stars/Ghondie/Dating-App.svg?style=for-the-badge
[stars-url]: https://github.com/Ghondie/Dating-App/stargazers
[issues-shield]: https://img.shields.io/github/issues/Ghondie/Dating-App?style=for-the-badge
[issues-url]: https://github.com/Ghondie/Dating-App/issues
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/jared-schau-a2a56361/
[product-screenshot]: images/screenshot.png

<!-- [contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors -->
<!-- [license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt -->
