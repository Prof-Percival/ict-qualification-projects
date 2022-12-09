.data
h: .word 7 #h = 7
A: .word 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 #ARRAY of Natural Numbers A = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]

.text
add $s3, $zero, 8 #TRansfer value 8 to register $s3 to act as an index of the thord element
lw $t0, A($s3) #set $t0 = A[8] . A is an array stored in memory
lw $s2, h #transfer or losd h to register $s3
add $s1, $s2, $t0 #add contents in $s2 and St0 storing result in $s1. g = h + A[8]