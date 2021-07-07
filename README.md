[![Codacy Badge](https://api.codacy.com/project/badge/Grade/9b1f8932909a4c7a8cfb5c9ba83d150e)](https://app.codacy.com/gh/Virenbar/PochtaAPI?utm_source=github.com&utm_medium=referral&utm_content=Virenbar/PochtaAPI&utm_campaign=Badge_Grade_Settings)
# PochtaAPI [![Nuget](https://img.shields.io/nuget/v/Virenbar.PochtaAPI)](https://www.nuget.org/packages/Virenbar.PochtaAPI/) [![Virenbar.PochtaAPI on fuget.org](https://www.fuget.org/packages/Virenbar.PochtaAPI/badge.svg)](https://www.fuget.org/packages/Virenbar.PochtaAPI) [![Build Status](https://dev.azure.com/Virenbar/PochtaAPI/_apis/build/status/Virenbar.PochtaAPI?branchName=master)](https://dev.azure.com/Virenbar/PochtaAPI/_build/latest?definitionId=5&branchName=master)

Библиотека для работы с [API Почты России](https://www.pochta.ru/support/business/api)

## Аутентификация
Для использования сервисов Почты России, необходимы аутентификационные данные.  
-   [Логин и пароль](https://tracking.pochta.ru/access-settings) для трекинга
-   [Токен](https://otpravka.pochta.ru/specification#/authorization-token) и [ключ](https://otpravka.pochta.ru/specification#/authorization-key) для отправки

## Трекинг почтовых отправлений (РПО)
Реализует функции [API Почты России](https://tracking.pochta.ru/specification) для работы с отправлениями.  
Для работы используется экземпляр класса **TrackingClient**.  

**Входные параметры:**
-   *\<Login>* - Логин
-   *\<Password>* - Пароль

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
-   *\<Token>* - Токен
-   *\<Key>* - Ключ

## PochtaForm
Используется для проверки работы библиотеки.