# Описание решения задачи в контрольной работе №1"
## 1. Исходные данные:
Массив строк **_arraySource_** 
## 2. Методы, использованные в задании
### 2.1 Метод **_ShowArray_**
Принимает на вход массив строк и выводит его  в консоль
### 2.2 Метод **_FindNumberOfElemnts_**
Принимает на вход массив строк и проходя по нему подсчитывает количество элементов, содержащих символов не более переменной **_size_**.
### 2.2 Метод **_CreteStringArray_**
Принимает на вход массив строк, количество элементов, содержащих символов не более переменной **_size_**, переменную **_size_**. Создает новый массив **_rezultArray_** и заполняет его элментами исходного массива, содержащими символов не более переменной **_size_**
## 3. Порядок расчета
3.1 Задание исходных данных

3.2 Получение количества элементов, содержащих не более 3 символов при помощи **_FindNumberOfElemnts_**.

3.3 В случае, если количество искомых элементов больше 0, создание нового масиива при помощи **_CreteStringArray_**.

3.4 Вывод полученного массива в консоль для проверки работы приложения при помощи  **_ShowArray_**