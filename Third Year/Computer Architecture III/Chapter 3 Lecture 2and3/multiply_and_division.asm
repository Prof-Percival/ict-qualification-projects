.data
a: .word 1000
b: .word 1000

.text
lw $t1, a 
lw $t2, b
div $t1, $t2
mfhi $s0
mflo $s1
break
beq $t1, $t2, seven
bne $t1, $t2, ten
return_here:
addi $t7, $zero, 40

seven:
    addi $t7, $zero, 7
    j return_here
    
    
ten:
    addi $t7, $zero, 17
    addi $t6, $zero, 2022
    j return_here