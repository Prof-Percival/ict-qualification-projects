.data
a: .word 2022

.text
lw $t1, a # load or transfer 2022 from memory into register $t1
addi $t1, $t1, 8 #add 2022 with constant 8 (Immediate) : $t1 = $t1 + 8