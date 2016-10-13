ORG 0000
LJMP AAA 
DLY: DB 255,175,125,75,50,25,10,2
SINETAB: DB 0,6,13,19,26,32,39,45,51,57,63,69,74,79,84,89,94,98,102,106,109,113,116,118,120,122,124,125,126,
126,127
TRITAB: DB 0,4,8,12,16,20,24,28,32,36,40,44,48,52,56,60,64,68,72,76,80,84,88,92,96,100,104,108,112,116,120
AAA:
	MOV SCON,#50H   ;configuring the serial port
	MOV TMOD,#20H 
	MOV TH1,#-3H   ; timer 1 required for the above purpose
	SETB TR1
	MOV P0,#00H
	MOV P1,#0FFH
      AA:
	ACALL GETCH  ;read a byte to P1
	MOV A,P1
	CLR ACC.7
	CLR ACC.6
	CLR ACC.5
	MOV DPTR,#DLY
	MOVC A,@A+DPTR
	MOV R2,A
	MOV TMOD,#01H
	JB P1.5,SINTRN
	JB P1.6,SWTTH
	JMP DIGI
	SJMP $
	
SWTTH:			  ;To generate saw-tooth wave
	MOV R3,#118
	MOV A,#7FH
	LP:	
		MOV P0,A
		ACALL DELAY
		INC A
		CJNE A,#118,LP
		JB RI,AA
		MOV A,#7FH
		JMP LP

DIGI: 		              ;To generate square wave
	  MOV A,#0FFH

	  MOV R3,#59
    UPPER:  		;upper half
	  MOV P0,A
	  ACALL DELAY
	  DJNZ R3,UPPER
	  
	  MOV A,#7FH
	  MOV R3,#59
	LOWER:               ;lower half
	  MOV P0,A
	  ACALL DELAY
	  DJNZ R3,LOWER

	  JB RI,AA
	  JMP DIGI


SINTRN:                        ;common code sine and triangular wave generation
       JB P1.6,TRN
       MOV DPTR,#SINETAB
	   JMP START
	TRN: MOV DPTR,#TRITAB
	START:
	 MOV R3, #30
	 LP1:               ;first quarter of one cycle of the wave
	 	CLR A
		MOVC A,@A+DPTR
		ADD A,#127
		MOV P0,A
		ACALL DELAY
		INC DPTR
		DJNZ R3,LP1

       
	
	MOV R3,#29
	MOV A,#29
	JB P1.6,TRN1
       MOV DPTR,#SINETAB
	   JMP START1
	TRN1: MOV DPTR,#TRITAB	
	START1:
	LP2:              ;second quarter of one cycle of the wave
	    PUSH 0E0H
		MOVC A,@A+DPTR
		ADD A,#127
		MOV P0,A
		ACALL DELAY
		POP 0E0H
		DEC A
		DJNZ R3,LP2
	 


	   MOV R3,#30
	 LP3:              ; third quarter of one cycle of the wave
	    	 CLR A
		 MOVC A,@A+DPTR
		 MOV R4,A
		 MOV A ,#127
		 SUBB A,R4
		 MOV P0,A
		 ACALL DELAY
		 INC DPTR
		 DJNZ R3,LP3

		JB P1.6,TRN2

             MOV DPTR,#SINETAB
                JMP START2
	TRN2: MOV DPTR,#TRITAB
	START2:
		MOV A,#29
		MOV R3,#29
	LP4:               ; fourth quarter of one cycle of the wave
		PUSH 0E0H
		MOVC A,@A+DPTR
		MOV R4,A
		MOV A,#127
		SUBB A, R4
		MOV P0,A
		ACALL DELAY
		POP 0E0H
		DEC A
		DJNZ R3,LP4

	    JB RI,TEMP
		JMP START
	TEMP:JMP AA
	
   DELAY:
   		PUSH 0E0H			;DELAY procedure uses Timer 0
		CLR A
		SUBB A,R2 
		MOV TL0,A	
		MOV TH0,#0FFH
		SETB TR0
	REP1:JNB TF0,REP1
		 CLR TF0
	    CLR A
		SUBB A,#0
		POP 0E0H
		RET 

GETCH:		;serial communication- read from the UI
GAGAIN:	JNB RI,GAGAIN
       		 MOV P1,SBUF
		CLR RI
		RET
	     
END	  
