include irvine32.inc

.data
Board_11 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_1_1.txt",0
Board_12 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_1_2.txt",0
Board_13 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_1_3.txt",0
Board_21 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_2_1.txt",0
Board_22 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_2_2.txt",0
Board_23 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_2_3.txt",0
Board_31 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_3_1.txt",0
Board_32 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_3_2.txt",0
Board_33 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_3_3.txt",0
Final_11 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_1_1_solved.txt",0
Final_12 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_1_2_solved.txt",0
Final_13 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_1_3_solved.txt",0
Final_21 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_2_1_solved.txt",0
Final_22 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_2_2_solved.txt",0
Final_23 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_2_3_solved.txt",0
Final_31 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_3_1_solved.txt",0
Final_32 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_3_2_solved.txt",0
Final_33 byte "C:\Users\LENOVO\Downloads\Sudoku-Boards\Sudoku Boards\diff_3_3_solved.txt",0

 FileHandle dword ?
  space byte ' ',0
  BUFFER_SIZE = 5000
  ArraySize = 91
  buffer BYTE BUFFER_SIZE DUP(?)
  result byte buffer_size dup(?)
  SavedIndecies byte  ArraySize dup(?)
  bytesRead DWORD ?
  
  off byte ?,0
  CorrectCounter dword ?
  WrongCounter dword ?
  cho dword 0
  fileAddress Dword ?

   weightstring  byte 2 dup(0)
 
 resultScore        byte 110 dup(?),0
  
  bufferscores byte 5000 dup (?),0 
  tmp byte 22 dup(?),0
  tempedx dword ?
  getdata byte 22 dup(?),0


  scoreFile byte "C:\Users\LENOVO\Downloads\score.txt",0
   filename    BYTE 100 DUP(?),0
  
  correctstring byte 2 dup(0),0 
wrongstring byte 2 dup(0),0
   correct dword ?
  startuptime dword ?
  secs dword ?
  minutes dword ?
  hours dword ?
 time byte 8 dup(0),0


;put your static data
.code

;Write your functions here
;Do not forget to modify main.def file accordingly 





;-------------------------------------------------
;this function use edx and buffer to open the file
; RECIVES: Byte array
;and store the intial board in array
;-------------------------------------------------

openingfile proc  


call OpenInputFile
mov FileHandle, eax

cmp eax,INVALID_HANDLE_VALUE          ; error opening file

mov edx, esi                    ;points to the buffer
mov ecx, BUFFER_SIZE            ;max bytes to read
call ReadFromFile               ;read the file
mov bytesRead,eax               ;count of bytes read


ret
openingfile endp



;--------------------------------------------------------------------------------------------------
;Rcives eax => new value of the cell 
;retrieve eax=0 , if value out of range 
;else if value valid 
;-------------------------------------------------------------------------------------------------
 

IsValueInRange proc 

cmp eax, 1
jb no
cmp eax, 9 
ja no 
jmp l1 
no :
mov eax, 0

l1 :
ret 
IsValueInRange endp

;-------------------------------------------
;this function close the file 
;-------------------------------------------

closeingfile proc
mov eax, filehandle
call CloseFile
ret
closeingfile endp


;-----------------------------------------------
;LEVELS
;
;-------------------------------------------------

difcu proc INT1:Dword , buffer1: ptr byte , buffer2:ptr byte

mov eax ,INT1
cmp eax, 0 
jne l2
mov esi, offset Board_11 
mov edi, offset Final_11
jmp endde
l2 : 
cmp eax, 1
jne l3
mov esi, offset Board_12 
mov edi, offset Final_12
jmp endde
l3:
cmp eax, 2
jne l4
mov esi, offset Board_13
mov edi, offset Final_13
jmp endde
l4:
cmp eax, 3
jne l5
mov esi, offset Board_21
mov edi, offset Final_21
jmp endde
l5:
cmp eax, 4
jne l6
mov esi, offset Board_22
mov edi, offset Final_22
jmp endde
l6:
cmp eax, 5
jne l7
mov esi, offset Board_23
mov edi, offset Final_23
jmp endde
l7:
cmp eax, 6
jne l8
mov esi, offset Board_31
mov edi, offset Final_31
jmp endde
l8:
cmp eax, 7
jne l9
mov esi, offset Board_32
mov edi, offset Final_32
jmp endde
l9:
mov esi, offset Board_33
mov edi, offset Final_33
endde :

mov fileAddress,esi
mov edx,esi

	mov esi, buffer1
	call openingfile
	call closeingfile
	
	mov edx, fileAddress
	mov esi, offset buffer
	
	call openingfile
	call closeingfile
	

	mov fileAddress,edi
	mov edx,edi
 mov esi, buffer2
 call openingfile
 call closeingfile


 mov edx,edi
 mov esi,offset result
 call openingfile
 call closeingfile


ret
  difcu endp

  ;------------------------------------------------------------
  ;Check function check in result if is correct or not
  ;------------------------------------------------------------
  check proc 
mov dl ,result[esi]
sub dl, 48
cmp al, dl
je l2
mov edx, 0
jmp endd
l2 :
mov edx, 1
endd:
ret 
check endp
comment !
;-------------------------------
try_fun proc boole : dword

mov eax,1
mov boole,eax

ret
try_fun endp
!
  ;-------------------------------------------------------------
  ;Edit Function check if value correct or not
  ; Recives Row & col & value
  ;----------------------------------------------------------------
Edit proc   Row:Dword , Col:Dword , Val:Dword , var:ptr dword


mov esi, Row    ;row num 

mov edi, Col    ; col num 

mov eax, esi

mov edx, 11
mul edx
add eax, edi
mov esi, eax

mov eax ,Val 
call Isvalueinrange

cmp eax ,0
je outt
;-------- compare with the exact value 

call check 
cmp edx, 1
jne wrong 
add al,48
mov buffer[esi], al
mov edi,var
mov dword ptr[edi],1
inc CorrectCounter 
jmp l3

wrong : 
mov edi,var
mov dword ptr[edi],0
inc wrongCounter 

jmp l3 
outt:
mov edi,var
mov dword ptr[edi],2
;"You enterd wrong number, you must enter a number in range (1:9)"
l3 :


ret 
Edit endp


;---------------------------------------------------------
;finish proc sub from start time the finish time 
;--------------------------------------------------------
finish proc

call getmseconds
sub eax,startuptime      ;the duartion time in secounds 
mov startuptime,eax

ret
finish endp


;--------------------------------------
; start proc Calculate start time
;------------------------------------------
start proc
call getmseconds
mov startuptime,eax
mov correctcounter,0
mov wrongcounter ,0

ret
start endp





;------------------------------------------------------------------------
;recieves eax => number , edx => offset 
;
;-----------------------------------------------------------------------
ctostring proc uses ecx ebx edi edx
mov ebx, 10
mov esi, edx
mov ecx, edx
mov edi, 0

l1 : 
cmp eax, 0
je l2 
cdq 
div ebx
add edx, '0' 
mov byte ptr [esi+1], dl
sub esi, 1 
inc edi 
jmp l1 
l2 :
cmp edi, 1 
jne l3
mov esi,ecx
mov byte ptr [esi], '0' 
l3 :


ret 
ctostring endp



comment !
-------------------------------------------------
return correct and incorrect and weight and time(H:M:S)
-------------------------------------------------
!

endgame proc   correctstring1:ptr byte , wrongstring1: ptr byte , time1:ptr byte
;convert corret to string

mov eax,CorrectCounter
mov edx, correctstring1
call ctostring



mov eax,CorrectCounter
mov edx, offset correctstring
call ctostring



;convert incorrect to string
mov eax,wrongCounter
mov edx,wrongstring1
call ctostring

mov eax,wrongCounter
mov edx,offset wrongstring
call ctostring

;time 

mov eax, startuptime
mov esi, 3600000
cdq 
div esi 

mov hours, eax 
mov eax, edx 
mov esi, 60000
cdq 
div esi


mov minutes, eax
mov eax, edx 
mov esi, 1000
cdq 
div esi


mov secs, eax
;convert time to string

mov edx, time1
mov eax,hours
call ctostring

add edx,2
mov byte ptr [edx],':'

add edx,1
mov eax,minutes
call ctostring
add edx,2
mov byte ptr [edx],':'
add edx,1
mov eax,secs
call ctostring

mov esi, time1
mov edi,offset time
mov ecx,8
rep movsb


call calc
mov eax, correct
mov edx,offset weightstring 
call ctostring

ret
endgame endp



;-----------------------------------------------
;calculate the weight 
;use eax=>correct
;ebx=>ncorrect
;edx=>seconds
;ret eax:correct
;-----------------------------------------------
calc proc  uses ebx eax


mov ebx,10
mov eax, correctCounter
mul ebx
mov correctCounter,eax

mov ebx,5
mov eax, wrongcounter
mul ebx
mov wrongcounter,eax


mov eax, correctCounter
mov ebx,wrongcounter
mov edx, startuptime

cmp eax ,ebx
jbE L1
sub eax,ebx
mov correct,eax
mov eax,edx
mov ebx,6000
cdq
div ebx
sub correct,eax
jmp next
L1:
mov correct ,0

next:
ret
calc endp




;---------------------------------------------
;score proc  
; receives:
;correct >>> correctstring
;incorrect >>> wrongstring  
;time >>>> time
;name in user name 
;weight :weightstring 
;     
;---------------------------------------------
score proc uses ebx    name1:ptr byte , arr:ptr byte        

; add the user to string getdata

mov edx, name1
mov esi, offset weightstring
mov edi,offset getdata
mov ecx,2
cld
rep movsb

mov byte ptr[edi],' '
inc edi
mov esi, name1
mov ecx,4

cld
rep movsb

mov byte ptr[edi],' '
inc edi
mov esi,offset correctstring
mov ecx,2
cld
rep movsb

mov byte ptr[edi],' '
inc edi
mov esi,offset wrongstring
mov ecx,2
cld
rep movsb

mov byte ptr[edi],' '
inc edi

mov esi,offset time
mov ecx,8
cld
rep movsb

;gedata has weigth name correct incorrect time 
;--------------------------------------------------------------------
mov edx,offset scoreFile
mov esi, offset bufferscores
call openingfile
call closeingfile 



;-------------------------------------------------------------------
;here add data of user to bufferscore to sort them

mov esi,offset getdata         ;esi offset of array 
mov edi,offset bufferscores       
add edi,110                     ;22*5    
mov ecx,22
cld
rep movsb


;--------------------------------------------------------------------

mov edx,offset bufferscores         ;edx offset of array 
mov ebx,22                          ;ebx counter
mov ecx,6

l1:
mov tempedx,edx
push ecx
push ecx

mov ecx,2
call parsedecimal32      ;eax number

mov esi,eax              ;esi : first weigth


pop ecx 
cmp ecx,1
je quit 
dec ecx
l3:                      ;esi ; first weight
push ecx
add edx,ebx               ;edx=> second score  of (buffer score)
mov ecx,2
call parsedecimal32       ;eax number
					      ;eax ; secand weight
cmp esi,eax
ja l4

mov ecx,22
mov esi,tempedx      
mov edi, offset tmp       ; tmp=first score
cld
rep movsb 

mov ecx,22
mov esi,edx          ; tempedx=second score
mov edi,tempedx
cld
rep movsb 



mov ecx,22
mov esi,offset tmp
mov edi,edx            
cld
rep movsb                         ; edx==> first-first-third-fourth-fifth-6


l4:
push edx                     ;edx===> second-third-4-5-6  OR        edx==> first-first-third-fourth-fifth-6

mov ecx,2
mov edx,tempedx
call parsedecimal32
MOV ESI,eax                  ; esi==> second weight

pop edx
pop ecx
loop l3


mov edx,tempedx
add edx,ebx
quit:
pop ecx
loop l1


;-------------------------------------------------------------
;store bufferscores in file 


mov edx,OFFSET scoreFile 
call CreateOutputFile
mov fileHandle,eax 

mov edx,OFFSET bufferscores 
mov ecx,110
call WriteToFile 
call closeingfile 



mov esi,offset bufferscores
;mov edi,offset resultScore
mov edi,arr
mov ecx,110
rep movsb



ret
score endp






; DllMain is required for any DLL
DllMain PROC hInstance:DWORD, fdwReason:DWORD, lpReserved:DWORD 

mov eax, 1		; Return true to caller. 
ret 				
DllMain ENDP

END DllMain
