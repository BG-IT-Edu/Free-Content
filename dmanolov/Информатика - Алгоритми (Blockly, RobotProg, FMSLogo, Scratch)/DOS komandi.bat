REM ����� �� ���������� 
c:

REM ����� �� ������������ 
cd \
cd \work\pg

REM ������� �� ������������ �� ���������� 
dir

REM ���������� �� ������
cls

REM ��������� �� ������� ����
@echo. > 9a.txt

REM �������� �� ����� � ����
copy 9a.txt 9b.txt
copy 9a.txt 9v.txt
copy 9a.txt 9g.txt
copy 9a.txt 9d.txt

REM ��������� �� �������������
md "9 class"

REM ����������� �� �������
move *.txt "9 class"

REM ��������� �� ������������ �� ����������
dir "9 class"

