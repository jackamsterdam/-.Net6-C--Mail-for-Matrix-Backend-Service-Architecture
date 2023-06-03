# .Net6-CSharp-Mail-for-Matrix-Backend-Service-Architecture
Creating a backend REST API using C# dontnet6 called Jack's Mail for Matrix

# Mail API By Jack For Matrix

- [Mail API](#mail-api)
  - [Create Mail](#create-mail)
    - [Create Mail Request](#create-mail-request)
    - [Create Mail Response](#create-mail-response)
  - [Get Mail](#get-mail)
    - [Get Mail Request](#get-mail-request)
    - [Get Mail Response](#get-mail-response)
  - [Update Mail](#update-mail)
    - [Update Mail Request](#update-mail-request)
    - [Update Mail Response](#update-mail-response)
  - [Delete Mail](#delete-mail)
    - [Delete Mail Request](#delete-mail-request)
    - [Delete Mail Response](#delete-mail-response)

## Create Mail


### Create Mail Request

```js
POST /mails
```

```json
{
    "name": "Jack Amsterdam",
    "description": "This mail is about healthy food",
    "message": "You should be eating a lot of oatmeal because it is high in Soluble Fiber.As well you should be eating lots of bananas for good qulity Potassium. Also Strawberries are good for. End your dat with a home made salad. Get on that healthy diet right away!",
    "startDateTime": "2023-06-04T08:00:00",
    "endDateTime": "2023-06-04T11:00:00",
    "meal": [
        "Oatmeal",
        "Bananas",
        "Strawberries",
        "Salad"
    ]
}
```

### Create Mail Response

```js
201 Created
```

```yml
Location: {{host}}/Mail/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Jack Amsterdam",
    "description": "This mail is about healthy food",
    "message": "You should be eating a lot of oatmeal because it is high in Soluble Fiber.As well you should be eating lots of bananas for good qulity Potassium. Also Strawberries are good for. End your dat with a home made salad. Get on that healthy diet right away!",
     "startDateTime": "2023-06-04T08:00:00",
    "endDateTime": "2023-06-04T11:00:00",
    "lastModifiedDateTime": "2023-06-04T12:00:00",
     "meal": [
        "Oatmeal",
        "Bananas",
        "Strawberries",
        "Salad"
    ]
}
```

## Get Mail

### Get Mail Request

```js
GET /mails/{{id}}
```

### Get Mail Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Jack Amsterdam",
    "description": "This mail is about healthy food",
    "message": "You should be eating a lot of oatmeal because it is high in Soluble Fiber.As well you should be eating lots of bananas for good qulity Potassium. Also Strawberries are good for. End your dat with a home made salad. Get on that healthy diet right away!",
     "startDateTime": "2023-06-04T08:00:00",
    "endDateTime": "2023-06-04T11:00:00",
    "lastModifiedDateTime": "2023-06-04T12:00:00",
     "meal": [
        "Oatmeal",
        "Bananas",
        "Strawberries",
        "Salad"
    ]
}
```

## Update Mail

### Update Mail Request

```js
PUT /mails/{{id}}
```

```json
{
    "name": "Jack Amsterdam",
    "description": "UPDATED",
    "message": "UPDATED",
     "startDateTime": "2023-06-04T08:00:00",
    "endDateTime": "2023-06-04T11:00:00",
    "lastModifiedDateTime": "2023-06-04T12:00:00",
     "meal": [
        "Oatmeal",
        "Bananas",
        "Strawberries",
        "Salad"
    ]
}
```

### Update Mail Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Mails/{{id}}
```

## Delete Mail

### Delete Mail Request

```js
DELETE /mails/{{id}}
```

### Delete Mail Response

```js
204 No Content
```
