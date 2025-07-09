# PochtaAPI [![Build artifact][build-src]][build-href] [![Codacy Badge][codacy-src]][codacy-href]

[![NuGet][nuget-src]][nuget-href]

Библиотека для работы с [API Почты России](https://www.pochta.ru/support/business/api)

## Аутентификация

Для использования сервисов Почты России, необходимы аутентификационные данные.  

- [Логин и пароль](https://tracking.pochta.ru/access-settings) для трекинга
- [Токен](https://otpravka.pochta.ru/specification#/authorization-token) и [ключ](https://otpravka.pochta.ru/specification#/authorization-key) для отправки

## Трекинг почтовых отправлений (РПО)

Реализует функции [API Почты России](https://tracking.pochta.ru/specification) для работы с отправлениями.  
Для работы используется экземпляр класса **TrackingClient**.  

**Входные параметры:**

- *\<Login>* - Логин
- *\<Password>* - Пароль

### Единичный доступ

Метод **GetHistoryAsync** используется для получения информации о конкретном отправлении.  
Возвращает **MailItem** содержащий информацию по всем операциям, совершенным над отправлением.  
**Пример:**

```C#
using PochtaAPI;
using PochtaAPI.Data;

TrackingClient TC = new TrackingClient(<Login>, <Password>);
MailItem MI = await TC.GetHistoryAsync(<TrackCode>);
```  

### Пакетный доступ (Не протестирован!)

Метод **GetTicketAsync** создает заявку в сервисе Почты России и возвращает **Ticket** содержащий код билета.  
Метод **GetBatchAsync** возвращает **Batch** содержащий информацию по отправлениям по ранее созданной заявке.

**Пример:**

```C#
using PochtaAPI;
using PochtaAPI.Data;
  
TrackingClient TC = new TrackingClient(<Login>, <Password>);
Ticket T = await TC.GetTicketAsync(new List<string>() { <TrackCode1>, <TrackCode2> });
//Подождать мин. 15 минут
Batch B = await TC.GetBatchAsync(T.ID);
```

## Отправка почтовых отправлений (РПО)

Реализует функции [API Почты России](https://otpravka.pochta.ru/specification#/main) для работы с отправлениями.  
Для работы используется экземпляр класса **SendingClient**.  

**Входные параметры:**

- *\<Token>* - Токен
- *\<Key>* - Ключ

## PochtaForm

Используется для проверки работы библиотеки.

<!-- Badges -->
[build-src]: https://img.shields.io/github/actions/workflow/status/Virenbar/PochtaAPI/build-artifact.yml?label=Build&logo=github
[build-href]: https://github.com/Virenbar/PochtaAPI/actions/workflows/build-artifact.yml

[codacy-src]: https://app.codacy.com/project/badge/Grade/30ac65f91ad341309f412526f41d60dc
[codacy-href]: https://app.codacy.com/gh/Virenbar/PochtaAPI/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade

[nuget-src]: https://img.shields.io/nuget/v/Virenbar.PochtaAPI?label=PochtaAPI&logo=nuget&style=for-the-badge
[nuget-href]: https://www.nuget.org/packages/Virenbar.PochtaAPI/
