REM смяна на устройство 
c:

REM смяна на директорията 
cd \
cd \work\pg

REM преглед на съдържанието на директория 
dir

REM изчистване на екрана
cls

REM създаване на текстов файл
@echo. > 9a.txt

REM копиране на файла в друг
copy 9a.txt 9b.txt
copy 9a.txt 9v.txt
copy 9a.txt 9g.txt
copy 9a.txt 9d.txt

REM създаване на поддиректория
md "9 class"

REM преместване на файлове
move *.txt "9 class"

REM показване на съдържанието на директория
dir "9 class"

