# Лабораторная работа. Интеграция сервиса для получения данных профиля пользователя.
Отчет по лабораторной работе #1 выполнила:
- Додонова Елена Игоревна
- РИ300002
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

## Цель работы
Cоздание интерактивного приложения и изучение принципов
интеграции в него игровых сервисов.

## Задание 1
### По теме видео практических работ 1-5 повторить реализацию игры на Unity. Привести описание выполненных действий.
Ход работы:
1) Добавляем ассет дракона.
![image](https://user-images.githubusercontent.com/90499063/193595049-8ab9099f-f8b4-4700-9e88-fe15b8b8963e.png)
![image](https://user-images.githubusercontent.com/90499063/193595127-004d1158-fcb8-47eb-966e-d397554a338e.png)

2) Добавляем префаб дракона на сцену.
![image](https://user-images.githubusercontent.com/90499063/193595290-577b340d-e22b-467f-b839-69d54d3d9a52.png)
![image](https://user-images.githubusercontent.com/90499063/193595336-e014e476-15bf-4b23-b909-144b2e7a67a3.png)

3)	Выставляем координаты дракона по 0.
![image](https://user-images.githubusercontent.com/90499063/193595499-e47efcb0-a8cb-48c3-b8ec-2bbbd73eb1b7.png)

4) Создаем контроллер анимации.
![image](https://user-images.githubusercontent.com/90499063/193595642-03bf1a6e-1190-4228-8e55-36890bcdab91.png)

5)	 Добавляем анимацию в сцену.
![image](https://user-images.githubusercontent.com/90499063/193595736-4712d666-5369-4539-b15f-35c720f30619.png)
![image](https://user-images.githubusercontent.com/90499063/193595764-b6528dcd-4cd7-4f0a-a47d-8ba7ca2b1b19.png)

6)	Подключаем анимационный контроллер к персонажу.
![image](https://user-images.githubusercontent.com/90499063/193595865-0646d060-84ff-42ad-a764-e12840a0ea17.png)
![image](https://user-images.githubusercontent.com/90499063/193595899-7dab6709-34f7-4db1-9882-286426a7b5e5.png)

7) При запуске сцены дракон двигается.
![image](https://user-images.githubusercontent.com/90499063/193595971-9a0f8020-4c78-4408-b52a-309474d745e5.png)
![image](https://user-images.githubusercontent.com/90499063/193595996-487d304a-1b1f-45a6-b935-a594e8f5247e.png)

8)	Создаем сферу, которую преобразовываем в яйцо.
![image](https://user-images.githubusercontent.com/90499063/193596087-9c892413-4729-4cc4-95ed-b60f524c446e.png)
![image](https://user-images.githubusercontent.com/90499063/193596116-b1952ab9-eaaa-4bc9-9f7b-676ff41c15f7.png)

9)	Добавляем яйцу цвет.
![image](https://user-images.githubusercontent.com/90499063/193596200-4cfd77dd-502c-478d-926f-00dd22bb9590.png)

10)	Добавляем яйцу компонент Rigitbody, чтоб оно могло падать.
![image](https://user-images.githubusercontent.com/90499063/193596252-f1632f4d-87b8-4ac4-8e76-e714188c129c.png)
![image](https://user-images.githubusercontent.com/90499063/193596269-0febb622-eb34-459c-903a-adafb31671a0.png)

11)	Яйцу добавляем тег.
![image](https://user-images.githubusercontent.com/90499063/193596329-dc7f5c2d-a187-433c-857e-d57e7a8eb61e.png)

12)	Создаем энергетический щит, добавляем к нему материал и компонент Rigitbody.   
![image](https://user-images.githubusercontent.com/90499063/193596409-953528a5-80cd-42c9-8bac-b3e7c8f319cd.png)
![image](https://user-images.githubusercontent.com/90499063/193596439-170e4283-1097-4090-b907-3ef9440c2d10.png)
![image](https://user-images.githubusercontent.com/90499063/193596458-d8430b82-15fd-48fa-998e-8db111b19ff9.png)

13)	Производим настройку камеры.
![image](https://user-images.githubusercontent.com/90499063/194866783-ec5d5fd9-582e-488b-b69e-4f541dea999e.png)

14)	Реализовываем скрипт, с помощью которого персонаж перемещается в лево и право, изменяет направление движения с определенной вероятностью через определенное время, а также через случайный интервал времени дракон сможет сбрасывать яйцо.
![image](https://user-images.githubusercontent.com/90499063/194866860-2030a00d-cb02-4d0e-88ca-1260bc8ce1c4.png)
![image](https://user-images.githubusercontent.com/90499063/194866884-88db046a-b5a2-4636-9259-dfe4027d3573.png)

15)	Пишем код, отвечающий за движение дракона.
![image](https://user-images.githubusercontent.com/90499063/194866945-b24e39a8-4748-460a-94f6-9f44d73cd5c5.png)
![image](https://user-images.githubusercontent.com/90499063/194866978-f95fd6bb-0560-4b13-a3c5-4e553caf97a3.png)
![image](https://user-images.githubusercontent.com/90499063/194866992-b07d35ac-c390-437c-a7f1-35f6b571c0b0.png)

16)	Добавим код, при котором дракон не будет улетать за край карты.
![image](https://user-images.githubusercontent.com/90499063/194867058-d1e24bc4-3a30-4aa1-bca0-fca265abb827.png)
![image](https://user-images.githubusercontent.com/90499063/194867112-474cca1f-a6b8-4feb-8e6b-c8216d4649f9.png)
![image](https://user-images.githubusercontent.com/90499063/194867139-6ff30b86-1789-401d-b88a-740d3d898efd.png)

17)	  Пишем код для случайного изменения направления движения дракона.
![image](https://user-images.githubusercontent.com/90499063/194870601-b6a9b89f-a8a5-4458-9e33-d6f872caaeba.png)
![image](https://user-images.githubusercontent.com/90499063/194870629-bcab3e06-9a81-4133-8a1a-5ad538f5920d.png)
![image](https://user-images.githubusercontent.com/90499063/194870648-5f359022-78ca-407b-8a93-8505066eaa3c.png)

18)	  Подключаем префаб DragonEgg к Enemy.
![image](https://user-images.githubusercontent.com/90499063/194870702-d1e43efb-db39-4771-8d32-7f0840b4e9b5.png)

19)	  Пишем код, который реализует падение яиц от дракона.
![image](https://user-images.githubusercontent.com/90499063/194870739-895828a4-837a-42c8-9c1b-4910c6017a43.png)
![image](https://user-images.githubusercontent.com/90499063/194870767-3de8904f-dc0e-47d8-ae94-886ab4c6d32e.png)

20)	 Создадим плоскость, которая будет служить землёй, наложим на нее текстуру.
![image](https://user-images.githubusercontent.com/90499063/194870828-58b02975-8451-4d0d-b16b-412431d964b1.png)
![image](https://user-images.githubusercontent.com/90499063/194870846-1e0a25eb-b13e-4f71-9026-4ea2b4100cf0.png)

21)	 Так же наложим текстуру на яйцо.
![image](https://user-images.githubusercontent.com/90499063/194870921-6f146f87-050a-40ff-a835-6dc321dacfed.png)
![image](https://user-images.githubusercontent.com/90499063/194870938-13926316-1b8d-4e0d-ad49-e7ee0770ade7.png)

22)	 Создаем скрипт, с помощью которого при столкновении яйца с землей будет происходить взрыв.
![image](https://user-images.githubusercontent.com/90499063/194871011-1ad772b1-e463-4532-8a47-7940934e20a1.png)
![image](https://user-images.githubusercontent.com/90499063/194871046-1d216206-e9a7-47d9-bb8c-1fbbb722f5bf.png)
![image](https://user-images.githubusercontent.com/90499063/194871072-5741e560-0b4a-40c8-84bf-09240b8921a4.png)

23)	 Настраиваем компоненты.
![image](https://user-images.githubusercontent.com/90499063/194871147-d5d500be-f143-470b-9db7-9e46885075e8.png)
![image](https://user-images.githubusercontent.com/90499063/194871186-bfc52f14-cafa-4ee1-8091-22909dc0427f.png)
![image](https://user-images.githubusercontent.com/90499063/194871204-12646165-70de-42ce-9f1e-59aa5dc71b3d.png)
![image](https://user-images.githubusercontent.com/90499063/194871220-63acf4f6-5a80-4a9c-9bf3-515cf65a1a72.png)
![image](https://user-images.githubusercontent.com/90499063/194871253-ba31096a-3017-447e-ae89-cbc823a2901a.png)
![image](https://user-images.githubusercontent.com/90499063/194871271-6192a68b-ee70-43ac-9f8a-d7dbb39c9b98.png)

24)	 Создадим скрипт основного функционала игры. Происходит клонирование энергетического щита.
![image](https://user-images.githubusercontent.com/90499063/194871338-3dcd5396-dd01-4522-9cc0-7c6f67770101.png)
![image](https://user-images.githubusercontent.com/90499063/194871358-e510476c-3a8c-41c4-bcf1-20e8b7f72491.png)
![image](https://user-images.githubusercontent.com/90499063/194871382-fbdabadd-0a41-4e0d-931d-0b2e5fe114f1.png)

25)	 Изучение платформы Яндекс Игры и ее SDK.
Заполняем данные о нашей игре.
![image](https://user-images.githubusercontent.com/90499063/194871477-096a3d90-6c6b-41b5-a0fe-986d594acd84.png)
![image](https://user-images.githubusercontent.com/90499063/194871497-d9f44e63-8ef4-4970-a182-798101fe1687.png)
![image](https://user-images.githubusercontent.com/90499063/194871513-36394fbc-0770-42d1-8653-9afe29acc922.png)
![image](https://user-images.githubusercontent.com/90499063/194871530-5e0155d5-03be-4eb4-ab39-f3707191e072.png)
![image](https://user-images.githubusercontent.com/90499063/194871760-ca4399b9-42fc-43f6-aef2-0e1da6a16cef.png)




## Задание 2
### Продемонстрируйте на сцене в Unity следующее:






## Выводы



