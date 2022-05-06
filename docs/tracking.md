---
title: Трекинг почтовых отправлений (РПО)
---

Реализует функции [API Почты России](https://tracking.pochta.ru/specification) для работы с отправлениями.  
Для работы используется экземпляр класса `#!cs TrackingClient`.  

**Входные параметры:**

- *\<Login\>* - Логин
- *\<Password\>* - Пароль

### Единичный доступ

Метод `#!cs GetHistoryAsync()` используется для получения информации о конкретном отправлении.  
Возвращает `#!cs MailItem` содержащий информацию по всем операциям, совершенным над отправлением.  
**Пример:**

```cs
using PochtaAPI;
using PochtaAPI.Data;

TrackingClient TC = new TrackingClient(<Login>, <Password>);
MailItem MI = await TC.GetHistoryAsync(<TrackCode>);
```  

### Пакетный доступ (Не протестирован!)

Метод `#!cs GetTicketAsync()` создает заявку в сервисе Почты России и возвращает `#!cs Ticket` содержащий код билета.  
Метод `#!cs GetBatchAsync()` возвращает `#!cs Batch` содержащий информацию по отправлениям по ранее созданной заявке.

**Пример:**

```cs
using PochtaAPI;
using PochtaAPI.Data;
  
TrackingClient TC = new TrackingClient(<Login>, <Password>);
Ticket T = await TC.GetTicketAsync(new List<string>() { <TrackCode1>, <TrackCode2> });
//Подождать мин. 15 минут
Batch B = await TC.GetBatchAsync(T.ID);
```
