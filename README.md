 
<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/othneildrew/Best-README-Template">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Service station database</h3>

  <p align="center">База данных станции техничесского обслуживания<br />
    <a href="https://github.com/othneildrew/Best-README-Template"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template">View Demo</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Report Bug</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
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
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://example.com)

Ведение дел автосервиса занимает достаточно много времени, если делать это вручную. Интелектуальный ассистент Database of car service station позволяющий быстрее и качественней обслуживать клиентов автосервиса поможет Вам в этом. Благодаря простому интерфейсу любой пользователь сможет легко и без особых навыков освоить работу в этой программе. Система помогает в создании базы и ведении учета клиентов СТО и учета транспортных средств на станции обслуживания, а также создаст онлайн отчет по всему автосервису.
Актуальность работы определяется необходимостью учета клиентов автосервиса для поддержания конкурентоспособности организации. 
Наличие клиентской базы облегчает доступ к истории обслуживания автомобиля в любой момент. Удивите клиентов сервисом и комуникацией нового уровня!

Разработанная база данных содержит меню:
1. Создать новый автомобиль в базе данных. Необходимо ввести такую информацию об автомобиле: "Марка автомобиля", "Модель автомобиля", "Год выпуска", "Номерной знак автомобиля".
2. Вывести информацию об автомобилях из базы данных на экран.
3. Найти автомобиль в базе данных по номерному знаку автомобиля.
4. Отсортировать автомобили в базе данных по марке авто.
5. Создать новый заказ на обслуживание автомобиля. Необходимо ввести такую информацию о заказе: "Номерной знак автомобиля", "Дата и время заказа", "Описание работ". Если автомобиль с таким номерным знаком отсутствует в базе данных, тогда нужно ввести данные об автомобиле:"Марка автомобиля", "Модель автомобиля", "Год выпуска", "Номерной знак автомобиля", для его создания.
6. Найти заказ в базе данных по номерному знаку автомобиля.
7. Отсортировать заказы по дате поступления.
8. Добавить товар. Для этого нужно выбрать производителя товара и согласно категории ввести необходимые данные о товаре.
9. Показать все товары в базе данных.
10. Найти товар по названию.
11. Найти товар по названию производителя.
12. Найти товар по категории.
13. Найти товар по дате получения.
14. Распечатать чек.
15. Оплатить чек.
16. Выход.

В разработке:
1. Склад. (Возможность вести складской учет наличия автозапчастей, их количество и стоимость. А также легко и быстро провести анализ ассортимента или провести инвентаризацию.)
2. Артикул, как уникальный идентификатор товара. (У Вас появится возможность добавлять товары с одинаковым названием, а их уникальным идентификатором станет артикул.)
3. Управление персоналом. (Вы сможете лугко осуществлять контроль сотрудников, составлять график работы сотрудников и расчет зароботной платы.)
4. Разработка мобильного приложения. (У Вас будет возможноть доступа к Базе данных с любого устройства.)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
