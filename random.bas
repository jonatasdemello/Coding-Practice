100 DIM AR(100)
110 ND = 1000
120 PS = INT (ND / 38)
130 TEXT : HOME
140 PRINT "RANDOM NUMBER SPREAD ANALYSIS"
150 VTAB 5: PRINT "GENERATING "ND" RANDOM NUMBERS..."
160 VTAB 9
170 PRINT "% COMPLETE:"
180 PRINT "[--------------------------------------]";
190 VTAB 10
200 X = RND ( - 1 * ( PEEK (78) + 256 * PEEK (79)))
210 FOR I = 1 TO ND
220 IF I / PS = INT (I / PS) THEN HTAB I / PS + 1: PRINT "";
230 N = INT ( RND (1) * 100) + 1
240 AR(N) = AR(N) + 1
250 NEXT
260 HOME
270 FOR R = 0 TO 90 STEP 10
280 FOR C = 1 TO 10
290 HTAB ((C - 1) * 4) + 1: PRINT AR(R + C);
300 NEXT : PRINT : PRINT : NEXT
310 PRINT "PRESS ANY KEY FOR GRAPH": GET DUMMY$
320 HOME
330 HGR : VTAB 21: PRINT "DISPERSAL OF RANDOM NUMBERS"
340 FOR I = 0 TO 159 STEP 9: HPLOT 0,I TO 5,I: NEXT
350 FOR I = 10 TO 279 STEP 3: HPLOT I,0 TO I,3: NEXT
360 HPLOT 0,153 TO 279,153
380 VO = 17 - AR(1): IF VO < 0 THEN VO = 0
390 HPLOT 10,VO * 9
400 FOR I = 2 TO 89
410 V = 17 - AR(I): IF V < 0 THEN V = 0
420 HPLOT TO (I - 1) * 3 + 10,V * 9
440 NEXT