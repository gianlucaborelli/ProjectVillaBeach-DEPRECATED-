# VillaBeach Project 

![Preview-Screens]() 

## About this Project 

This project aims to assist in the management of a company called **VillaBeach** located in the city of [Brodowski](https://www.google.com/maps/place/Brodowski,+SP,+14340-000/@-20.9915545,-47.6566512,14), in the countryside of the State of São Paulo, and its core business is a gym environment with a beach volleyball court joined together with a pub and recreation environment. 

With the full consent of the company's owners, this project will not have the purpose of selling and monetization, being fully developed to practice my knowledge and compose my portfolio. 

**OBS:** All third-party material used in this project are included in the "References" tab at the end of this page, as well as included in the source code when applicable. 

## Why? 

The development of this project is carried out during my free time and during my studies, and was conceived after understanding the needs of a co-worker regarding the difficulties he has been facing in controlling the finances of his private bussiness. 

This project is part of my personal portfolio, so, I'll be happy if you could provide me any feedback about the project, code, structure or anything that you can report that could make me a better developer! 

Also, you can use this Project as you wish, be for study, be for make improvements or earn money with it! 

It's free! 

The only request when using this project is to reference this repository, the citation/reference when validly occurs provides respect for this work and the authors of the contents used as a reference.

## Some Observations about this App 

**1 -** Despite not being part of my professional interest (UX/UI), I was extremely uncomfortable with the appearance of the standard TextBox of the .Net Framework together with the Flat Design chosen as User Interface.

![Standard TextBox](https://github.com/gianlucaborelli/ProjectVillaBeach/blob/main/Pictures/Standard%20TextBox.jpg) 

Therefore, I created a component called  [FlatTextBox](https://github.com/gianlucaborelli/ProjectVillaBeach/tree/main/ProjetoVillaBeach/Controles/FlatTextBoxControler) using the UserControl class, which makes aesthetic changes to the standard TextBox, and implements several other features, for example:

- Validation of data entered in the TextBox, according to the type of validation selected during system construction (such as C.P.F., C.N.P.J. and others).

![Imagem validação](https://github.com/gianlucaborelli/ProjectVillaBeach/blob/main/Pictures/FlatTextBox.jpg)

- Validation if the component is mandatory.

![Imagem validação](https://github.com/gianlucaborelli/ProjectVillaBeach/blob/main/Pictures/FlatTextBox%20Requered%20Field.jpg) 

In addition to other minor internal behaviors.

## Built With

- [.Net Framework]( https://docs.microsoft.com/pt-br/dotnet/) - Build the native app using C# With .Net Framework
- [EntityFrameworkCore]( https://docs.microsoft.com/pt-br/ef/) – ORM and DataBase access
- [MariaDB]( https://mariadb.org/) – MariaDB DataBase

## Contributing

You can send how many PR's do you want; I'll be glad to analyze and accept them! And if you have any question about the project...

Email-me: gianlucaborelli2@hotmail.com

Connect with me at [LinkedIn](https://www.linkedin.com/in/borelli-gianluca/)

Thank you!

## License

This project is licensed under the MIT License - see the [LICENCE](https://github.com/gianlucaborelli/ProjectVillaBeach/blob/main/LICENSE) file for details.

## References

[Macoratti - C # - Validando CNPJ , CPF e PIS](https://www.macoratti.net/11/09/c_val1.htm)

[RJ Code Advance - IU Moderno, Menú Desplegable/Deslizante, Menú Lateral, Responsivo, Only Form – C#, VB.Net, WinForm](https://rjcodeadvance.com/iu-moderno-submenu-desplegable-deslizante-menu-lateral-responsivo-only-form-c-winform/)

[Code in PC - Custom Alert Box in C#](https://codeinpc.com/custom-alert-box/)

