.data
b: .word 5
c: .word 10

.text
lw $t0, b
lw $t1, c
add $t2, $t0, $t1