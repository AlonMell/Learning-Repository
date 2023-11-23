# Learning Repository

## Описание

В репозитории находится 4 решения с проекта по разным тематикам.


### Стуктура решения ASP.NET CORE

1. WebAPI and EFCore - Проект представляет собой веб-проект основа которого RESTful API для управления данными о пользователях. Приложение поддерживает операции CRUD (Create, Read, Update, Delete) для сущности "Пользователь" и использует базу данных SQL Server для хранения данных. Запросы обрабатываются асинхронно с использованием Entity Framework для взаимодействия с базой данных.
2. Fundamentals in ASP.NET Core - Проект обрабатывает RESTful API для управления данными о пользователях. Он включает в себя обработку GET, POST, PUT и DELETE запросов для получения, создания, обновления и удаления информации о пользователях. Маршруты основаны на использовании регулярных выражений для обработки запросов с уникальными идентификаторами (GUID) и включают в себя обработку ошибок, такую как отсутствие пользователя или некорректные данные.
3. Routing - Это приложение демонстрирует использование различных ограничений маршрутов, включая встроенные и пользовательские, а также инъекцию зависимости в обработчик маршрута через конструктор.
4. ResultsAPI and Error handling - Проект представляет собой ASP.NET Core веб-приложение, в котором реализована обработка ошибок, определены различные маршруты, включая переадресацию, и возвращаются различные типы контента в ответ на запросы. 
5. Logging - Проект в котором реализованы различные маршруты, использующие логгирование с использованием ILogger и ILoggerFactory
6. Dependency Injection - Проект использующий механизм внедрения зависимостей (Dependency Injection, DI). В приложении определены три сервиса: TimeService, ICounter, и CounterService. Внедрение зависимостей настроено с использованием различных времен жизни сервисов (Transient, Scoped, Singleton). Приложение также использует Middleware для обработки запросов, включая TimerMiddleware и CounterMiddleware.
7. Cookies and Sessions - Проект демонстрирует возможность установки кук и их использования при запросе, а также базовую работу с сессиями и обработку запросов в ASP.NET Core.
8. Configuration - Проект использующий конфигурации из различных источников (JSON, XML, INI, TXT) и десериализацию объекта Person из конфигураций. Конечные точки (/, /json, /xml, /ini, /txt, /class) отображают различные значения из конфигураций, а также объект типа Person
9. Authentication and authorization(Jwt) - Проект представляет собой пример использования аутентификации и авторизации в ASP.NET Core, в частности, с использованием JWT-токенов. Приложение предоставляет конечную точку /login для входа, где пользователь может предоставить свои учетные данные (электронная почта и пароль) для получения JWT-токена. Токен затем используется для доступа к защищенной конечной точке /data. Пользовательские данные, такие как электронная почта и пароль, проверяются для аутентификации, а JWT-токен генерируется и возвращается в ответе при успешном входе.
10. Authentication and authorization(Cookies) - Такое же проект как и предыдущий, только основанный на Cookies

### Стуктура решения CSharp Main

1. Collections - Реализация коллекции граждан в C#. CitizenCollection реализует интерфейс IEnumerable, что позволяет итерироваться по коллекции. Коллекция предоставляет методы для добавления, удаления, проверки наличия и других операций с гражданами. Также реализована поддержка динамического изменения размера массива для управления вместимостью коллекции.
2. EFCore - Пример использования Entity Framework Core для работы с базой данных. Программа создает контекст базы данных (BlogContext), добавляет в базу данных автора и пост, а затем выполняет запрос для получения всех постов вместе с их авторами, используя метод Include для предварительной загрузки связанных данных. 
3. Garbage_Collector - Пример использования сборщика мусора для отслеживания и управления объектами в памяти. Программа создает два типа объектов: SmallObject и BigObject. SmallObject имеет конструктор и деструктор, а также создает массив BigObject в отдельном потоке. После запуска, программа выводит информацию о поколениях и размере кучи, позволяя следить за процессом сборки мусора.
4. IO - Консольное приложение для поиска, чтения и сжатия файлов. Пользователю предоставляется меню с четырьмя опциями:Поиск файла, Просмотр файла, Сжатие файла, Выход.
5. LINQ - Использование LINQ для запросов к коллекциям объектов. В частности, в коде создаются три списка объектов: автомобилей (autos), владельцев автомобилей (owners), и национальностей (nationality). Затем используются LINQ-запросы для выполнения различных операций.
6. ReflectionAndAttributes - Использование рефлексии для получения информации о типе и его членах. Также в коде применяются атрибуты для аннотирования класса Photo и его свойств.
7. SystemCollections - Примеры использования различных коллекций и структур данных в C# из пространства имен System.Collections и System.Collections.ObjectModel.
8. Threads - Проект представляет собой реализацию эффекта "падающей матрицы" в консоли. Он использует многопоточность для отображения нескольких столбцов матрицы одновременно. 
9. XML - Пример работы с XML в C#.

### Стуктура решения Design Patterns

Решение поделено на подкатегории: 
1. Порождающие паттерны
2. Паттерны поведения
3. Структурные паттерны

Каждый проект демонстрирует функционал требуемого паттерна.

### Проект HTML CSS Site
Простой сайт написанный на HTML/CSS представляет собой структуру сайта яхт-клуба. На сайте присутствует навигация, информация о яхтах, галерея, новости и контакты. 

## Технологии

- C# 12 .NET 8
- JavaScript
- HTML/CSS
- ASP.NET 7 CORE
- Entity Framework
- Razor Pages
