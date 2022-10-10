
program Burbuja;
var
myArray: array [1..13] of integer;
i: integer;
temp: integer;
j: integer;
k: integer;
begin
myArray[1] := 1;
myArray[2] := 3;
myArray[3] := 7;
myArray[4] := 2;
myArray[5] := 3;
myArray[6] := 8;
myArray[7] := 9;
myArray[8] := 40;
myArray[9] := 32;
myArray[10] := 22;
myArray[11] := 11;
myArray[12] := 86;

for i:= 1 to 12 do
    for j:= 1 to i do
        if myArray[j] > myArray[j + 1] then
            begin
                temp := myArray[j];
                myArray[j] := myArray[j + 1];
                myArray[j + 1] := temp;
            end;

for k := 1 to 12 do
    writeln(myArray[k], ',');
end.

