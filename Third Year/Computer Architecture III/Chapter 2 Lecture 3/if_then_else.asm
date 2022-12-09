.data
f: .word   #Variable f has no value assigned
g: .word 2 #Variables g = 2
h: .word 3 #Variable h = 3
i: .word 4 #Variable i = 4
j: .word 5 #Variable j = 5


.text
lw $s1, g #Transfer g to register $s1
lw $s2, h #Transfer h to register $s2
lw $s3, i #Transfer i to register $s3
lw $s4, j #Transfer j to register $s4

bne $s3, $s4, Else
add $s0, $s1, $s2 # f = g + h
j Exit #Jump to Exit
Else:sub $s0, $s1, $s2
Exit: